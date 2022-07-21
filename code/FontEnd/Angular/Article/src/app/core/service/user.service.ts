import { User } from './../models/user.model';
import { distinctUntilChanged, map, Observable, ReplaySubject } from 'rxjs';
import { JwtService } from './jwt.service';
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { ApiService } from "./api.service";
import { BehaviorSubject } from 'rxjs';

@Injectable()
export class UserService {
    // Subject nó là một Observable đặc biệt cho phép muticase value tới nhiều Observable cùng 1 lúc
    private currentUserSubject = new BehaviorSubject<User>({} as User);

    // distinctUntilChanged() tức là nếu có nhiều phần tử giống nhau thì chỉ lấy ra đại diện 1 phần tử
    public currentUser = this.currentUserSubject.asObservable().pipe(distinctUntilChanged())

    private isAuthSubject = new ReplaySubject<boolean>(1);
    public isAuth = this.isAuthSubject.asObservable();

    constructor(private api: ApiService, private http: HttpClient, private jwt: JwtService) { }

    // xác minh Jwt localStoge được lưu ở máy
    verifyJWT() {
        if (this.jwt.getToken()) {
            this.api.get('/user').subscribe(
                data => this.setAuth(data.user),
                er => this.purgeAuth()
            )
        }
    }

    populate() {
        if (this.jwt.getToken()) {
            this.api.get('/user').subscribe(
                    data => this.setAuth(data.user),
                    err => this.purgeAuth()
                );
        } 
        else {
            this.purgeAuth();
        }
    }

    attemptAuth(type: String, credentials: any): Observable<User> {
        const route = (type === 'login') ? '/login' : '';
        return this.api.post('/users' + route, {user: credentials})
          .pipe(map(
          data => {
            this.setAuth(data.user);
            return data;
          }
        ));
      }

    setAuth(user: User) {
        this.jwt.saveToken(user.token);
        this.currentUserSubject.next(user);
        this.isAuthSubject.next(true);
    }

    purgeAuth() {
        this.jwt.destroyToken();
        this.currentUserSubject.next({} as User);
        this.isAuthSubject.next(false);
    }

    // update tên người dùng trên máy chủ
    update(user: User): Observable<User> {
        return this.api.put('/user', { user })
            .pipe(map(data => {
                this.currentUserSubject.next(data.user);
                return data.user;
            }));
    }

    getCurrentUser(): User {
        return this.currentUserSubject.value;
    }
}
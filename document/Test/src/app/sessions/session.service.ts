import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { User } from "src/share/model/user.model";


@Injectable()
export class SessionService {
    constructor(private http: HttpClient) {}

    public login(username: string, password: string): Observable<User> {
        const Url = `...`;
        const body = {
            username,
            password
        }
        return this.http.post<User>(Url, body)
    }

    public logout(): void {
        localStorage.clear();
        location.reload();
    }
}
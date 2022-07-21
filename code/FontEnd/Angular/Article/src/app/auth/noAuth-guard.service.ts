import { UserService } from './../core/service/user.service';
import { Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from "@angular/router";
import { map, Observable, take } from "rxjs";

@Injectable()
export class NoAụthGuard implements CanActivate{
    constructor(private router: Router, private userService: UserService) {
        
    }
    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> {
        return this.userService.isAuth.pipe(take(1), map(isAuth => !isAuth));
    }
    
}
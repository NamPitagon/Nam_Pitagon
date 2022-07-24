import { Injectable } from '@angular/core';
import { CanActivateChild, Router } from '@angular/router';
import {
  ActivatedRouteSnapshot,
  CanActivate,
  RouterStateSnapshot,
} from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AuthGuard implements CanActivate, CanActivateChild {
  constructor(
    private router: Router,
  ) {}

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): Observable<boolean> | Promise<boolean> | boolean {
    const currentUser = localStorage.getItem('currentUser');
    if (currentUser) {
      return true;
    }

    this.router.navigate(['/sessions/login']);
    return false;
  }

  canActivateChild(
    childRoute: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): Observable<boolean> | Promise<boolean> | boolean {
    const currentUser = localStorage.getItem('currentUser');
    if (currentUser) {
      return true;
    }
    this.router.navigate(['/sessions/login']);
    return false;
  }
}

import { Injectable } from '@angular/core';
import {
  CanActivate,
  ActivatedRouteSnapshot,
  RouterStateSnapshot,
  Router,
} from '@angular/router';
import * as _ from 'lodash';
import { NGXLogger } from 'ngx-logger';
import { AuthenticationService } from '../services/auth/authentication.service';

@Injectable()
export class UserRoleGuard implements CanActivate {
  constructor(
    private router: Router,
    private authenticationService: AuthenticationService,
    private logger: NGXLogger
  ) {}

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    var role = this.authenticationService.currentRole;
    // Có role được định nghĩa trên route thì user phải có role đó
    if (!route.data.role) {
      return true;
    } else if (
      typeof route.data.role === 'string' &&
      role.role.includes(route.data.role)
    ) {
      return true;
    } else if (_.some(route.data.role, (x) => role.role.includes(x))) {
      return true;
    } else {
      this.logger.info('User không có quyền:', route.data.role);
      this.router.navigate(['/page-not-found'], {
        queryParams: {
          error: '403',
          accessUrl: state.url,
        },
      });
      return false;
    }
  }
}

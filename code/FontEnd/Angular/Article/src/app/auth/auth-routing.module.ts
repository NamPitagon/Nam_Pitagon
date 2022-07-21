import { AuthComponent } from './auth.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NoAụthGuard } from './noAuth-guard.service';

const routes: Routes = [
  {
    path: 'login',
    component: AuthComponent,
    canActivate: [NoAụthGuard]
  },
  {
    path: 'register',
    component: AuthComponent,
    canActivate: [NoAụthGuard]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

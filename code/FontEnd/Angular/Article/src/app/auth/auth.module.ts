import { SharedModule } from './../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthComponent } from './auth.component';
import { NoAụthGuard } from './noAuth-guard.service';



@NgModule({
  declarations: [
    AuthComponent,
  ],
  imports: [
    CommonModule,
    SharedModule
  ],
  providers:[
    NoAụthGuard
  ]
})
export class AuthModule { }

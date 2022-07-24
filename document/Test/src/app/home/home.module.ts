import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardComponent } from './dashboard/dashboard.component';
import { RouterModule } from '@angular/router';
import { routing } from './home.routing';
import { SessionService } from '../sessions/session.service';
import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [
    DashboardComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    RouterModule.forChild(routing)
  ],
  providers: [SessionService]
})
export class HomeModule { }

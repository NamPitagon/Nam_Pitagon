import { Component, OnInit } from '@angular/core';
import { SessionService } from 'src/app/sessions/session.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  constructor(private svSe: SessionService) { }

  ngOnInit(): void {
  }

  logout() {
    this.svSe.logout()
  }

}

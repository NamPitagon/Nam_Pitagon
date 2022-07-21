import { User } from './../../../core/models/user.model';
import { UserService } from './../../../core/service/user.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
})
export class HeaderComponent implements OnInit {

  constructor(private userService:UserService) { }
  currentUser!: User;
  ngOnInit(): void {
    this.userService.currentUser.subscribe(
      (userData) => {this.currentUser = userData}
    )
  }
}

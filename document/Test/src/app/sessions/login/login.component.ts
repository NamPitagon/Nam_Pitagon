import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { SessionService } from '../session.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  form!:FormGroup;
  constructor(private svSe: SessionService, private fb: FormBuilder, private route: Router) { }

  ngOnInit(): void {
    this.buildForm()
  }

  buildForm(): void {
    this.form = this.fb.group({
      username: ['', [Validators.required]],
      password: ['', [Validators.required]]
    })
  }

  onSubmit(): void {
    if (this.form.invalid) {
      return
    }
    this.svSe.login(this.form.value.username, this.form.value.password).subscribe(
      (res)=>{
        localStorage.setItem('currentUser', JSON.stringify(res))
        this.route.navigate(['home'])
      },
      err=> {
        alert(err)
      }
    )
  }

}

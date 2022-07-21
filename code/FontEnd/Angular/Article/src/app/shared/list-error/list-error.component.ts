import { Component, Input, OnInit } from '@angular/core';
import { Errors } from 'src/app/core/models/errors.model';

@Component({
  selector: 'app-list-error',
  templateUrl: './list-error.component.html',
})
export class ListErrorComponent{
  formattedErrors: Array<string> = [];

  @Input()
  set errors(errorList: Errors) {
    this.formattedErrors = Object.keys(errorList.errors || {})
      .map(key => `${key} ${errorList.errors[key]}`);
  }

  get errorList() { return this.formattedErrors; }
}

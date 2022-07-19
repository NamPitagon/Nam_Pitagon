import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MyserviceService {
  myProperty;
  constructor() { }

  getTodayDate() {
    let ndate = new Date();
    return ndate;
  }
}

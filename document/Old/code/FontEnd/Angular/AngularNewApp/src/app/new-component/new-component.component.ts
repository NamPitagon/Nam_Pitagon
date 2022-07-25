import { Component, OnInit } from '@angular/core';
import {MyserviceService} from './../myservice.service'

@Component({
  selector: 'app-new-component',
  templateUrl: './new-component.component.html',
  styleUrls: ['./new-component.component.css'],
})
export class NewComponentComponent implements OnInit {
  todo = ['Học TypeScript', 'Học Angular', 'Học HTML5'];
  title = "Nguyễn Văn Nam";
  months = [
    'Tháng 1',
    'Tháng 2',
    'Tháng 3',
    'Tháng 4',
    'Tháng 5',
    'Tháng 6',
    'Tháng 7',
    'Tháng 8',
    'Tháng 9',
    'Tháng 10',
    'Tháng 11',
    'Tháng 12',
  ];
  is_available = true;
  myClickFunction() {
    alert('Nhận được lệnh click từ button');
  }

  // Khai báo hàm change month để kiểm soát sự kiện change đã khai báo bên html
  changemonths() {
    alert('Bạn vừa thay đổi tháng trong dropdown');
  }
  todaydate;
  propertyService;
  constructor(private myservice: MyserviceService) { }
  ngOnInit() {
    this.todaydate = this.myservice.getTodayDate();
    this.myservice.myProperty = "myProperty: New Cmp Component";
    this.propertyService = this.myservice.myProperty;
  }
}

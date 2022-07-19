import { MyserviceService } from './myservice.service';
// AppComponent là thành phần cha của ứng dụng, các thành mới tạo ra đều là thành phần con của AppComponent
import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'AngularNewApp';
  todaydate;
  propertyService;

  results;
  constructor(private http: HttpClient) {}
  ngOnInit() {
    // subscribe sẽ có tác dụng log dữ liệu ra console
    this.http
      .get('http://jsonplaceholder.typicode.com/users')
      .subscribe((data) => {
        console.log(data);
        this.results = data;
      });
  }

  // constructor(private myservice: MyserviceService){}
  // ngOnInit() {
  //     this.todaydate = this.myservice.getTodayDate();
  //     this.myservice.myProperty = "myProperty : App Component";
  //     this.propertyService = this.myservice.myProperty;
  // }

  jsonval = {
    name: 'Nguyễn Nam',
    age: '22',
    address: { a1: 'Bắc Ninh', a2: 'Yên Phong' },
  };
  months = [
    'Jan',
    'Feb',
    'Mar',
    'April',
    'May',
    'Jun',
    'July',
    'Aug',
    'Sept',
    'Oct',
    'Nov',
    'Dec',
  ];
}

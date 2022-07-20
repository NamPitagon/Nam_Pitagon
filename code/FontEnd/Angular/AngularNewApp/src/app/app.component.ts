import { MyserviceService } from './myservice.service';
// AppComponent là thành phần cha của ứng dụng, các thành mới tạo ra đều là thành phần con của AppComponent
import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormControl, FormGroup, Validator} from '@angular/forms';
import { trigger, state, style, transition, animate } from '@angular/animations';

// @Component sẽ nhận một object với các tham số đều có kiểu là string
@Component({
  selector: 'app-root', // host element có tag là app-root
  templateUrl: './app.component.html', // xác định mã html được chèn vào DOM khi component được hiển thị
  styleUrls: ['./app.component.css'],
  // định nghĩa thêm thuộc tính animations
  animations:[
    // sử dụng trigger có 2 tham số, tham số thứ nhất là tên trigger
    // tham số thứ 2 chứa các hàm state và transition trong đó:
    // hàm state định nghĩa trạng thái của của 2 state
    trigger('myanimation', [
      // state smaller tức dịch chuyển 100px theo trục y
      state('smaller', style({transform: 'translateY(100px)'})),
      // state larger tức dịch chuyển 0px theo trục y tức là dịch chuyển về vị trí ban đầu
      state('larger', style({transform: 'translateY(0px)'})),
      // hàm transition định nghĩa các thông số hiển thị nên màn hình như độ dài, độ chế khi chuyển từ trạng thái này sang trạng thái khác
      transition('smaller <=> larger', animate('300ms ease-in'))
    ])
  ],
  // thêm thuộc tính styles để căn giữa các thẻ div
  styles: [`
     div{
        margin: 0 auto;
        text-align: center;
     }
     .rotate{
         width: 340px;
         heigh: 82px;
        border:solid 1px red;
     }
  `],
})
// sử dụng từ khóa export để có thể sử dụng ở các file khác trong ứng dụng
export class AppComponent {
  title = 'AngularNewApp';
  todaydate;
  propertyService;
  formdata;
  username;
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
    // khi sử dụng Form dạng Model Driven Form thì khai báo ở đây
      this.formdata = new FormGroup(
        {
          username: new FormControl("Freetuts.net"),
          password: new FormControl("123456")
        }
      );
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
  // sự kiện onClickSubmit khi sử dụng Template Driven Form
  onClickSubmit(data){
      alert("Username bạn vừa nhập là: " + data.Username);
  }

  ClickSubmit(data){
    this.username = data.username;
  }

  state: string = "smaller";
  animate(){
    this.state = this.state == 'larger' ? 'smaller': 'larger';
  }

}

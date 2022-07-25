import { ThisReceiver } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { TitleStrategy } from '@angular/router';
import { ShareService } from '../share.service';

@Component({
  selector: 'app-gg-convert',
  templateUrl: './gg-convert.component.html',
  styleUrls: ['./gg-convert.component.scss']
})
export class GgConvertComponent implements OnInit {

  // khai báo mảng để khai báo các loại dữ liệu
  type: any[] = [
    {
      name: 'String',
      code: 'String'
    },
    {
      name: 'Base64',
      code: 'Base64'
    },
    {
      name: 'Hex',
      code: 'Hex'
    },
    {
      name: 'ArrayByte',
      code: 'ArrayByte'
    }
  ]

  // khai báo các biến
  public inputType: any;
  public inputValue: any;
  public outputType: any;
  public outputValue: any;
  public copyInType: any;
  public copyOutType: any;
  public countInputValue: any;
  public copyInValue: any;
  public copyOutValue: any;

  hidden: boolean = false;

  constructor(private service: ShareService) {
    // gán giá trị mặc định của inputType là String
    this.inputType = this.type[0].code;
    this.inputValue = null;
    this.outputType = this.type[1].code;
    this.outputValue = null;
    this.countInputValue = 0;
  }

  ngOnInit(): void {
  }

  changeInType(event: any): void {
    this.inputValue = null;
    this.outputValue = null;
    if (this.inputValue == null || this.inputValue == "") {
      this.hidden = false;
      this.countInputValue = 0;
    }
  }

  changeOutType(event: any): void {
    if (this.inputValue != null) {
      this.clickConvert();
    }
  }

  ChangeInput(event: any) {
    this.clickConvert();
    this.countInputValue = this.inputValue.length;
    this.hidden = true;
    if (this.inputValue == null || this.inputValue == "") {
      this.hidden = false;
    }
  }

  removeValue() {
    this.inputValue = null;
    this.outputValue = null;
    if (this.inputValue == null || this.inputValue == "") {
      this.hidden = false;
      this.countInputValue = 0;
    }
  }

  clickChangeType() {
    this.copyInType = this.inputType;
    this.copyOutType = this.outputType;
    this.outputType = this.copyInType;
    this.inputType = this.copyOutType;
    this.copyInValue = this.outputValue;
    this.copyOutValue = this.inputValue;
    this.inputValue = this.copyInValue;
    this.outputValue = this.copyOutValue;
    this.countInputValue = this.inputValue.length;
  }

  clickConvert() {
    if (this.inputValue == null || this.inputType == undefined || this.inputType.length <= 0) {
      alert("Vui lòng thêm giá trị cho dữ liệu muốn chuyển!");
      return;
    }
    else {
      // switch (this.inputType) {
      //   case "String":
      //     if (this.outputType == "Base64") {
      //       if(this.inputValue == null || this.inputValue =="") this.outputValue = null;
      //       else{
      //         this.service.StringToBase64(this.inputValue).subscribe((res) => {
      //           if (res.success) {
      //             this.outputValue = res.value;
      //           }
      //         },
      //           (err) => {
      //             console.log(err);
      //           })
      //       }
      //     }
      //     else if (this.outputType == "Hex") {
      //       this.service.StringToHex(this.inputValue).subscribe((res) => {
      //         if (res.success) {
      //           this.outputValue = res.value;
      //         }
      //       },
      //         (err) => {
      //           console.log(err);
      //         })
      //     }
      //     else if (this.outputType == "ArrayByte") {
      //       this.service.StringToArrByte(this.inputValue).subscribe((res) => {
      //         if (res.success) {
      //           this.outputValue = res.value;
      //         }
      //       },
      //         (err) => {
      //           console.log(err);
      //         })
      //     }
      //     else {
      //       alert("Kiểu dữ liệu của input và output đang giống nhau");
      //       this.inputValue = null;
      //       this.outputValue = null;
      //       this.hidden = false;
      //       this.countInputValue = 0;
      //     }
      //     break;
      //   case "Base64":
      //     if (this.outputType == "String") {
      //       this.service.Base64ToString(this.inputValue).subscribe((res) => {
      //         if (res.success) {
      //           this.outputValue = res.value;
      //         }
      //       },
      //         (err) => {
      //           console.log(err);
      //         })
      //     }
      //     else if (this.outputType == "Hex") {
      //       this.service.Base64ToHex(this.inputValue).subscribe((res) => {
      //         if (res.success) {
      //           this.outputValue = res.value;
      //         }
      //       },
      //         (err) => {
      //           console.log(err);
      //         })
      //     }
      //     else if (this.outputType == "ArrayByte") {
      //       this.service.Base64ToArrByte(this.inputValue).subscribe((res) => {
      //         if (res.success) {
      //           this.outputValue = res.value;
      //         }
      //       },
      //         (err) => {
      //           console.log(err);
      //         })
      //     }
      //     else {
      //       alert("Kiểu dữ liệu của input và output đang giống nhau");
      //       this.inputValue = null;
      //       this.outputValue = null;
      //       this.hidden = false;
      //       this.countInputValue = 0;
      //     }
      //     break;
      //   case "Hex":
      //     if (this.outputType == "String") {
      //       this.service.HexToString(this.inputValue).subscribe((res) => {
      //         if (res.success) {
      //           this.outputValue = res.value;
      //         }
      //       },
      //         (err) => {
      //           console.log(err);
      //         })
      //     }
      //     else if (this.outputType == "Base64") {
      //       this.service.HexToBase64(this.inputValue).subscribe((res) => {
      //         if (res.success) {
      //           this.outputValue = res.value;
      //         }
      //       },
      //         (err) => {
      //           console.log(err);
      //         })
      //     }
      //     else if (this.outputType == "ArrayByte") {
      //       this.service.HexToArrByte(this.inputValue).subscribe((res) => {
      //         if (res.success) {
      //           this.outputValue = res.value;
      //         }
      //       },
      //         (err) => {
      //           console.log(err);
      //         })
      //     }
      //     else {
      //       alert("Kiểu dữ liệu của input và output đang giống nhau");
      //       this.inputValue = null;
      //       this.outputValue = null;
      //       this.hidden = false;
      //       this.countInputValue = 0;
      //     }
      //     break;
      //   case "ArrayByte":
      //     if (this.outputType == "String") {
      //       this.service.ArrByteToString(this.inputValue).subscribe((res) => {
      //         if (res.success) {
      //           this.outputValue = res.value;
      //         }
      //       },
      //         (err) => {
      //           console.log(err);
      //         })
      //     }
      //     else if (this.outputType == "Base64") {
      //       this.service.ArrByteToBase64(this.inputValue).subscribe((res) => {
      //         if (res.success) {
      //           this.outputValue = res.value;
      //         }
      //       },
      //         (err) => {
      //           console.log(err);
      //         })
      //     }
      //     else if (this.outputType == "Hex") {
      //       this.service.ArrByteToHex(this.inputValue).subscribe((res) => {
      //         if (res.success) {
      //           this.outputValue = res.value;
      //         }
      //       },
      //         (err) => {
      //           console.log(err);
      //         })
      //     }
      //     else {
      //       alert("Kiểu dữ liệu của input và output đang giống nhau");
      //       this.inputValue = null;
      //       this.outputValue = null;
      //       this.hidden = false;
      //       this.countInputValue = 0;
      //     }
      //     break;
      //   default:
      //     break;
      // }
      if (this.inputValue == null || this.inputValue == "") this.outputValue = null;
      else {
        this.service.ggConvertData(this.inputType, this.outputType, this.inputValue).subscribe((res) => {
          if (res.success) {
            this.outputValue = res.value;
          }
        },
          (err) => {
            console.log(err);
          })
      }
    }
  }
}
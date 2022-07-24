import { ThisReceiver } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { ShareService } from '../share.service';

@Component({
  selector: 'app-gg-convert',
  templateUrl: './gg-convert.component.html',
  styleUrls: ['./gg-convert.component.css']
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
  public inputType: string;
  public inputValue: string;
  public outputType: string;
  public outputValue: string;

  constructor(private service: ShareService) {
    // gán giá trị mặc định của inputType là String
    this.inputType = this.type[0].code;
    this.inputValue = "";
    this.outputType = this.type[0].code;
    this.outputValue = "";
  }

  ngOnInit(): void {
  }

  clickConvert() {
    if(this.inputType == "String" && this.outputType == "Base64")
    {
      this.service.StringToBase64(this.inputValue).subscribe(
        (res) => {
          if(res.success){
            this.outputValue = res.value;
          }
        },
        (err) => {
          console.log(err);
        }
      )
    }
   else{
    this.service.StringToHex(this.inputValue).subscribe(
      (res) => {
        if(res.success){
          this.outputValue = res.value;
        }
      },
      (err) => {
        console.log(err);
      }
    )
   }
  }
}

import { Directive, ElementRef } from '@angular/core';

@Directive({
  selector: '[appChangeText]',
})
export class ChangeTextDirective {
  constructor(Element: ElementRef) {
    console.log(Element);
    // truy cập vào trong DOM thay đổi text của thành phần này
    Element.nativeElement.innerText = 'Học Angular cơ bản';
  }
}

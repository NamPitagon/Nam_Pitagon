import { Pipe, PipeTransform } from "@angular/core";

// khai báo tên cho Pipe
@Pipe({
  name: 'sqrt'
})

export class SqrtPipe implements PipeTransform{
  transform(val: number) : number {
    return Math.sqrt(val);
  }
}

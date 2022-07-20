import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

// khai báo 1 mảng chứa path và tên component tương ứng
const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
// export để có thể sử dụng AppRoutingModule trong ứng dụng
export class AppRoutingModule { }

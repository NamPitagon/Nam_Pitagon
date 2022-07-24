// điều hướng
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

// import các commpont
import { GgConvertComponent } from './gg-convert/gg-convert.component';

const routes: Routes = [
  {
    path: 'ggConvert',
    component: GgConvertComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

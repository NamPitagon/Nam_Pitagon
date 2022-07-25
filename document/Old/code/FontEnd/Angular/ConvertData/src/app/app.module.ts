// khai báo các thư viện, ...
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

// khai báo thêm các thư viện
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { GgConvertComponent } from './gg-convert/gg-convert.component';
import {HttpClientModule} from '@angular/common/http';
import { ShareService } from './share.service';

@NgModule({
  declarations: [
    AppComponent,
    GgConvertComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [ShareService],
  bootstrap: [AppComponent]
})
export class AppModule { }

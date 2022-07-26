import { Injectable } from '@angular/core';

// khai báo thêm các thư viện
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
// cấu hình api
export class ShareService {

  // cấu hình apiURL ở trong dotnet
  readonly apiURL = "https://localhost:5001/api/GgConvert";

  constructor(private http: HttpClient) { }

  // định nghĩa các api
  ggConvertData(inputType: string, outputType: string ,inputValue: string): Observable<any> {

    return this.http.post(this.apiURL + '/convert',
      {
        inputType: inputType,
        outputType: outputType,
        inputValue: inputValue
      },
      {
        params: {
          inputType: inputType,
          outputType: outputType,
          inputValue: inputValue
        }
      });
  }
}

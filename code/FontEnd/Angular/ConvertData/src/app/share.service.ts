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

  StringToBase64(inputValue: string): Observable<any> {

    return this.http.post(this.apiURL + '/StringToBase64',
      {
        inputValue: inputValue
      },
      {
        params: {
          inputValue: inputValue
        }
      });
  }
  StringToHex(inputValue: string): Observable<any> {
    
    return this.http.post(this.apiURL + '/StringToHex',
      {
        inputValue: inputValue
      },
      {
        params: {
          inputValue: inputValue
        }
      });
  }
  StringToArrByte(val: any): Observable<any> {
    return this.http.post<any>(this.apiURL + '/StringToArrByte', val);
  }
  ArrByteToString(val: any): Observable<any> {
    return this.http.post<any>(this.apiURL + '/ArrByteToString', val);
  }
  Base64ToString(val: any): Observable<any> {
    return this.http.post<any>(this.apiURL + '/Base64ToString', val);
  }
  HexToString(val: any): Observable<any> {
    return this.http.post<any>(this.apiURL + '/HexToString', val);
  }
  Base64ToArrByte(val: any): Observable<any> {
    return this.http.post<any>(this.apiURL + '/Base64ToArrByte', val);
  }
  Base64ToHex(val: any): Observable<any> {
    return this.http.post<any>(this.apiURL + '/Base64ToHex', val);
  }
  ArrByteToBase64(val: any): Observable<any> {
    return this.http.post<any>(this.apiURL + '/ArrByteToBase64', val);
  }
  HexToBase64(val: any): Observable<any> {
    return this.http.post<any>(this.apiURL + '/HexToBase64', val);
  }
  HexToArrByte(val: any): Observable<any> {
    return this.http.post<any>(this.apiURL + '/HexToArrByte', val);
  }
  ArrByteToHex(val: any): Observable<any> {
    return this.http.post<any>(this.apiURL + '/ArrByteToHex', val);
  }
}

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
  // StringToBase64(inputValue: string): Observable<any> {

  //   return this.http.post(this.apiURL + '/StringToBase64',
  //     {
  //       inputValue: inputValue
  //     },
  //     {
  //       params: {
  //         inputValue: inputValue
  //       }
  //     });
  // }
  // StringToHex(inputValue: string): Observable<any> {
    
  //   return this.http.post(this.apiURL + '/StringToHex',
  //     {
  //       inputValue: inputValue
  //     },
  //     {
  //       params: {
  //         inputValue: inputValue
  //       }
  //     });
  // }
  // StringToArrByte(inputValue: string): Observable<any> {
    
  //   return this.http.post(this.apiURL + '/StringToArrByte',
  //     {
  //       inputValue: inputValue
  //     },
  //     {
  //       params: {
  //         inputValue: inputValue
  //       }
  //     });
  // }
  // ArrByteToString(inputValue: string): Observable<any> {
    
  //   return this.http.post(this.apiURL + '/ArrByteToString',
  //     {
  //       inputValue: inputValue
  //     },
  //     {
  //       params: {
  //         inputValue: inputValue
  //       }
  //     });
  // }

  // Base64ToString(inputValue: string): Observable<any> {
    
  //   return this.http.post(this.apiURL + '/Base64ToString',
  //     {
  //       inputValue: inputValue
  //     },
  //     {
  //       params: {
  //         inputValue: inputValue
  //       }
  //     });
  // }
  
  // HexToString(inputValue: string): Observable<any> {
    
  //   return this.http.post(this.apiURL + '/HexToString',
  //     {
  //       inputValue: inputValue
  //     },
  //     {
  //       params: {
  //         inputValue: inputValue
  //       }
  //     });
  // }
  // Base64ToArrByte(inputValue: string): Observable<any> {
    
  //   return this.http.post(this.apiURL + '/Base64ToArrByte',
  //     {
  //       inputValue: inputValue
  //     },
  //     {
  //       params: {
  //         inputValue: inputValue
  //       }
  //     });
  // }
  // Base64ToHex(inputValue: string): Observable<any> {
    
  //   return this.http.post(this.apiURL + '/Base64ToHex',
  //     {
  //       inputValue: inputValue
  //     },
  //     {
  //       params: {
  //         inputValue: inputValue
  //       }
  //     });
  // }
  // ArrByteToBase64(inputValue: string): Observable<any> {
    
  //   return this.http.post(this.apiURL + '/ArrByteToBase64',
  //     {
  //       inputValue: inputValue
  //     },
  //     {
  //       params: {
  //         inputValue: inputValue
  //       }
  //     });
  // }
  // HexToBase64(inputValue: string): Observable<any> {
    
  //   return this.http.post(this.apiURL + '/HexToBase64',
  //     {
  //       inputValue: inputValue
  //     },
  //     {
  //       params: {
  //         inputValue: inputValue
  //       }
  //     });
  // }
  // HexToArrByte(inputValue: string): Observable<any> {
    
  //   return this.http.post(this.apiURL + '/HexToArrByte',
  //     {
  //       inputValue: inputValue
  //     },
  //     {
  //       params: {
  //         inputValue: inputValue
  //       }
  //     });
  // }
  // ArrByteToHex(inputValue: string): Observable<any> {
    
  //   return this.http.post(this.apiURL + '/ArrByteToHex',
  //     {
  //       inputValue: inputValue
  //     },
  //     {
  //       params: {
  //         inputValue: inputValue
  //       }
  //     });
  // }
}

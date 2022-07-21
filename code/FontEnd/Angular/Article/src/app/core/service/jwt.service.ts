import { Injectable } from "@angular/core";

@Injectable()
export class JwtService {
    getToken(): String {
        // window.localStoge: lưu trữ dữ liệu dưới dạng key - value
        return window.localStorage['jwtToken'];
    }

    saveToken(token: String){
        window.localStorage['jwtToken'] = token;
    }

    destroyToken(){
        window.localStorage.removeItem('jwtToken');
    }
}
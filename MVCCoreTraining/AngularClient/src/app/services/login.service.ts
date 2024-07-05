import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, interval } from "rxjs";
import { map } from "rxjs/operators";

export interface Token{
  token :string
}

@Injectable({
  providedIn: 'root'
})

export class LoginService{
  private apiURL ='https://reqres.in/api/'
  constructor(private http:HttpClient) {
  }
  checkLogin(xEmail : string,xPassword :string):Observable<any>{
    var user:any={
      email:xEmail,
      password:xPassword
    }
    return this.http.post<any>(this.apiURL +"login",user);
  }
  getUsers():Observable<any>{
    return this.http.get<any>(this.apiURL +"users?page=2");
  }
  getRandomNumber(): Observable<number> {
    return interval(1000).pipe(
      map(() => Math.random())
    );
  }
}

import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from "@angular/common/http";
import { SalJWTToken } from "./common/Security";
import { Observable } from "rxjs";
import { Injectable } from "@angular/core";
@Injectable()
export class JwtInterceptor implements HttpInterceptor{
  constructor(private authenticationSservice: SalJWTToken) {
  }
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
   req=req.clone({
    setHeaders:{
      Authorization :`Bearer ${this.authenticationSservice.value}`
    }
   });
   return next.handle(req);
  }
}

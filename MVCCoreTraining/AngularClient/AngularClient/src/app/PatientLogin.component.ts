import { Component } from '@angular/core';
import { Config } from './common/Config';
import {HttpClient} from "@angular/common/http";
import { SalJWTToken } from './common/Security';
import {  Router } from '@angular/router';
@Component({
  selector: 'app-root',
  templateUrl: './PatientLogin.component.html',
  styleUrls: ['./app.component.css']
})
export class PatientLoginComponent {
  title = 'AngularClient';

  constructor(public _config:Config,
    public _http:HttpClient,
    public _token :SalJWTToken,
    public _router : Router
  ) {

  }

  Login(){
    var user:any ={};
    user.userName="test";
    this._http.post(this._config.value + "Security/Login",user)
          .subscribe(res=>this.Success(res),
                    res=>this.Error(res)
  );
  }

  Success(res :any){
      this._token.value=res.value;
      this._router.navigate(["AddPatient"]);
  }
  Error(res:any){
    console.log(res);
  }
}

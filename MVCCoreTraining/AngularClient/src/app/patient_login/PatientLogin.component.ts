import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { CookieService } from 'ngx-cookie-service';
import { Config } from '../common/Config';
import { SalJWTToken } from '../common/Security';
import { LoginService } from '../services/login.service';
@Component({
  selector: 'app-root',
  templateUrl: './PatientLogin.component.html',
})
export class PatientLoginComponent {
  title = 'AngularClient';
  randomNumbers: number[] = [];
  constructor(
    public _config: Config,
    public _http: HttpClient,
    public _token: SalJWTToken,
    public _router: Router,
    private cookieService: CookieService,
    private loginService: LoginService
  ) {}
  ngOnInit() {
    this.loginService.getRandomNumber().subscribe(
      number => {
        this.randomNumbers.unshift(number); // Add new number to the beginning of the array
        if (this.randomNumbers.length > 10) {
          this.randomNumbers.pop(); // Keep only the last 10 numbers for display
        }
      },
      error => {
        console.error('Error fetching random number:', error);
      }
    );
  }
  checkUser() {
    this.loginService.checkLogin('eve.holt@reqres.in', 'cityslicka')
    .subscribe(
      (respone) => {
      console.log(respone);
      this.cookieService.set('token',respone.token);
      this._router.navigate(['parent']);
       } ,(error) =>{
        console.log(error);
      }
      )
  }
  LoginOld() {
    var user: any = {};
    this.cookieService.set('auth', 'abc');
    user.userName = 'test';
    this._http.post(this._config.value + 'Security/Login', user).subscribe(
      (res) => this.Success(res),
      (res) => this.Error(res)
    );
  }
  DeleteCookie() {
    this.cookieService.delete('auth');
  }
  Success(res: any) {
    this._token.value = res.value;
    this._router.navigate(['AddPatient']);
  }
  Error(res: any) {
    console.log(res);
  }
}

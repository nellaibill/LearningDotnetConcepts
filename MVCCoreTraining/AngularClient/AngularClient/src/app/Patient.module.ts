import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutes } from './Routing';
import {  PatientAddComponent  } from './PatientAdd.component';
import { PatientLoginComponent } from './PatientLogin.component';
import { RouterModule } from '@angular/router';
import { SalJWTToken } from './common/Security';
import { HomepageComponent } from './Homepage.component';
import { SecurityCheck } from './common/SecurityCheck';
import { Config } from './common/Config';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { JwtInterceptor } from './JwtInterceptor';


@NgModule({
  declarations: [
    PatientAddComponent,
    PatientLoginComponent,HomepageComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(AppRoutes)
  ],
  providers: [
    SalJWTToken,
    SecurityCheck,
    Config,
    {provide:HTTP_INTERCEPTORS,useClass:JwtInterceptor,multi:true}
  ],
  bootstrap: [HomepageComponent]
})
export class AppModule { }

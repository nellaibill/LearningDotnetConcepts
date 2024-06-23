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
import { CustomerComponent } from './customer/customer.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ParentComponent } from './parent/parent.component';
import { ChildComponent } from './child/child.component';


@NgModule({
  declarations: [
    PatientAddComponent,
    PatientLoginComponent,HomepageComponent, CustomerComponent, ParentComponent, ChildComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
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

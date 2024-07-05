import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutes } from './Routing';
import { RouterModule } from '@angular/router';
import { SalJWTToken } from './common/Security';
import { SecurityCheck } from './common/SecurityCheck';
import { Config } from './common/Config';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { JwtInterceptor } from './JwtInterceptor';
import { CustomerComponent } from './customer/customer.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ParentComponent } from './parent/parent.component';
import { ChildComponent } from './child/child.component';
import { CookieService } from 'ngx-cookie-service';
import { PatientAddComponent } from './patient_add/PatientAdd.component';
import { PatientLoginComponent } from './patient_login/PatientLogin.component';
import { HomePageComponent } from './home/home.component';
import { UsersComponent } from './users/users.component';
import { CanDeactivateGuard } from './common/can-deactivate-guard';
import { HighlightDirective } from './directive/highlight.directive';
import { RxjsOperatorComponent } from './rxjs-operator/rxjs-operator.component';


@NgModule({
  declarations: [
    PatientAddComponent,
    PatientLoginComponent,
    HomePageComponent,
    CustomerComponent,
    ParentComponent,
    ChildComponent,
    UsersComponent,
    HighlightDirective,
    RxjsOperatorComponent
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
    CanDeactivateGuard,
    Config,
    CookieService,
    {provide:HTTP_INTERCEPTORS,useClass:JwtInterceptor,multi:true}
  ],
  bootstrap: [HomePageComponent]
})
export class AppModule implements Extracted { }
interface Extracted {}

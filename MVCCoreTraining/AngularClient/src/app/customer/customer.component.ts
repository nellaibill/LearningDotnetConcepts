import { Component, OnInit } from '@angular/core';
import { Customer } from './customer.model';
import { Observable } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {
 customerObj:Customer= new Customer();
 customerObjs:Array<Customer> = new Array<Customer>();
  apiResponse: Observable<any> | undefined;
  constructor(public http: HttpClient) { }

  ngOnInit(): void {
    this.getAPIData();
  }

  Add(){
    this.customerObjs.push(this.customerObj);
    this.customerObj = new Customer(); //Clear the screen
  }

  getAPIData(){
    //return this.http.get("https://api.sampleapis.com/countries/countrie").subscribe(res =>console.log(res),res=>console.log(res));
    return this.http.get("https://api.sampleapis.com/countries/countrie").pipe(retry(3));
  }

   handleError(error: HttpErrorResponse){
    console.log(error);
  }
  getMessage(){
    return "hello";
  }

}

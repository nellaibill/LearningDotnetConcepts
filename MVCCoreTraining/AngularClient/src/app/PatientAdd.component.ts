import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Config } from './common/Config';

@Component({
  selector: 'app-root',
  templateUrl: './PatientAdd.component.html',
  styleUrls: ['./app.component.css']
})
export class PatientAddComponent {
  title = 'AngularClient';
  constructor(public _http:HttpClient,
    public _config : Config
  ){

  }
  Add(){
    var pat : any ={}
    pat.patientName="Raja";
    this._http.post(this._config.value+"Patient/AddtoDb",pat).
    subscribe(res=>this.Success(res),
      res=>this.Error(res));
      }
      Success(res :any){

      }
      Error(res :any){

      }
}

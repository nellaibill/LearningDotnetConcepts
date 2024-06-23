import { FormBuilder, FormControl,
  FormGroup, Validators } from "@angular/forms";

export class Customer{
  name : string="";
  code : string="";
  formGroup : FormGroup;
  constructor(){
    var builder = new FormBuilder();
    this.formGroup=builder.group({});
    this.formGroup.addControl("CustomerNameControl",
        new FormControl('',Validators.required));
  }
}

import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { CustomerComponent } from '../customer/customer.component';

@Component({
  selector: 'app-homepage',
  templateUrl: './home.component.html'
})
export class HomePageComponent implements AfterViewInit{
  title = 'AngularClient';
  @ViewChild(CustomerComponent) customerComponent!: CustomerComponent;
  ngAfterViewInit(): void {
       //console.log(this.customerComponent.getMessage());

  }

}

import { Component, ViewChild, AfterViewInit } from '@angular/core';
import { ChildComponent } from '../child/child.component';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent implements AfterViewInit {
  parentMessage: string = 'Hello from Parent';
  receivedMessage: string = '';
  childViewMessage: string = '';

  @ViewChild(ChildComponent) childComponent!: ChildComponent;

  ngAfterViewInit() {
    this.childViewMessage = this.childComponent.getMessage();
  }

  receiveMessage($event: string) {
    this.receivedMessage = $event;
  }
}

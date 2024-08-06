import { Component, Input, Output, EventEmitter, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css'],
  encapsulation:ViewEncapsulation.None
})
export class ChildComponent {
  @Input() childMessage: string = '';
  @Output() messageEvent = new EventEmitter<string>();

  sendMessage() {
    this.messageEvent.emit('Hello from Child!');
  }

  getMessage(): string {
    return 'Message from Child Component';
  }
}

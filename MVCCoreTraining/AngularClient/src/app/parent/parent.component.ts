import { Component, ViewChild, AfterViewInit } from '@angular/core';
import { ChildComponent } from '../child/child.component';
import { CanComponentDeactivate } from '../common/can-deactivate-guard';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent implements AfterViewInit,CanComponentDeactivate {
  unsavedChanges = false;

  onNavigateAway() {
    // Simulate unsaved changes
    this.unsavedChanges = true;
  }
  canDeactivate(): boolean {
    if (this.unsavedChanges) {
      return confirm('Are you sure you want to leave? Any unsaved changes will be lost.');
    }
    return true;
  }
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

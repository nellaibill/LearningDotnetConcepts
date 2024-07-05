import { Directive, HostListener, HostBinding } from '@angular/core';

@Directive({
  selector: '[appHighlight]'
})
export class HighlightDirective {
  @HostBinding('style.backgroundColor') backgroundColor: string | undefined;

  constructor() { }

  @HostListener('mouseover')
  onMouseOver() {
    this.backgroundColor = 'yellow';
  }

  @HostListener('mouseout')
  onMouseOut() {
    this.backgroundColor = '';
  }
}

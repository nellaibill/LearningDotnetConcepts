import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-rxjs-operator',
  templateUrl: './rxjs-operator.component.html',
  styleUrls: ['./rxjs-operator.component.css'],
})
export class RxjsOperatorComponent implements OnInit {
  numbers: number[] = [1, 2, 3, 4, 5];
  result: number[] = [];
  constructor() {}

  ngOnInit(): void {}
  reset(): void {
    this.result = [1, 2, 3, 4, 5];
  }
  click_map(): void {
    this.result = this.numbers.map((x) => x * 2);
  }

  click_filter(): void {
    this.result = this.numbers.filter((x) => x % 2 == 0);
  }
  click_reduce(): void {
    this.result = Array.of(this.numbers.reduce((acc, value) => acc + value, 0));
  }
}

import { Component, ChangeDetectionStrategy, signal } from '@angular/core';

@Component({
  selector: 'app-demos-counter',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: `
    <div>
      <button (click)="decrement()" class="btn btn-warning btn-circle">
        -
      </button>
      <span class="px-4">{{ current() }}</span>
      <button (click)="increment()" class="btn btn-success btn-circle">
        +
      </button>
    </div>
  `,
  styles: ``,
})
export class Counter {
  current = signal(0);

  decrement() {
    this.current -= 1;
  }

  increment() {
    this.current += 1;
  }
}

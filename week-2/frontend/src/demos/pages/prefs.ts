import { Component, ChangeDetectionStrategy, signal } from '@angular/core';

const COUNT_BY_VALUES = [1, 3, 5] as const;
type CountByValues = keyof typeof COUNT_BY_VALUES;
@Component({
  selector: 'app-counter-prefs',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [],
  template: `
    <div class="join">
      @for (val of values; track val) {
        <button
          (click)="by.set(val)"
          [disabled]="by() === val"
          class="btn join-item"
        >
          {{ val }}
        </button>
      }
    </div>
  `,
  styles: ``,
})
export class Prefs {
  by = signal<CountByValues>(1);

  values = COUNT_BY_VALUES;
}

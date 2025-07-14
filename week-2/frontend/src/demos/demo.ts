import { ChangeDetectionStrategy, Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-demos',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [RouterLink, RouterOutlet],
  template: `
    <div class="flex flex-row gap-4">
      <a routerLink="counter" class="btn btn-primary">Counter</a>
    </div>
    <div>
      <router-outlet />
    </div>
  `,
  styles: ``,
})
export class Demo {}

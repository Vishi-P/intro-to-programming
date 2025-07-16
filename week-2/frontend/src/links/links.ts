import { ChangeDetectionStrategy, Component } from '@angular/core';
import { Add } from './components/add';
import { List } from './components/list';

@Component({
  selector: 'app-links',
  changeDetection: ChangeDetectionStrategy.OnPush,
  imports: [Add, List],
  template: `
    <div class="flex flex-row gap-4">
      <app-links-list />
      <app-links-add />
    </div>
  `,
  styles: ``,
})
export class Links {}

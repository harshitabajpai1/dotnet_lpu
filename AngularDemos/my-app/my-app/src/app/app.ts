// import { Component, signal } from '@angular/core';
// import { RouterOutlet } from '@angular/router';
// import { Parent } from './parent/parent';
// import {StructDirective} from './struct-directive/struct-directive';
// import {BuildInDirective} from './build-in-directive/build-in-directive';

// @Component({
//   selector: 'app-root',
//   standalone: true,
//   imports: [RouterOutlet,Parent,StructDirective,BuildInDirective],
//   templateUrl: './app.html',
//   styleUrl: './app.css'
// })
// export class App {
//   protected readonly title = signal('my-app');
// }



import { Component } from '@angular/core';
import { ProductListComponent } from './components/product-list/product-list.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ProductListComponent],
  template: `
    <app-product-list></app-product-list>
  `,
  styles: [`
    :host {
      display: block;
      min-height: 100vh;
      background-color: #f0f2f5;
    }
  `]
})
export class AppComponent {
  title = 'product-crud-app';
}

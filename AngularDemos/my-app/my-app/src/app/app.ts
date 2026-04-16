import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Parent } from './parent/parent';
import {StructDirective} from './struct-directive/struct-directive';
import {BuildInDirective} from './build-in-directive/build-in-directive';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,Parent,StructDirective,BuildInDirective],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('my-app');
}

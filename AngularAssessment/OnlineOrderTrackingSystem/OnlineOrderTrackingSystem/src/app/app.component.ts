import { Component } from '@angular/core';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, RouterLink, RouterLinkActive],
  template: `
    <nav class="navbar">
      <a routerLink="/" routerLinkActive="active" [routerLinkActiveOptions]="{ exact: true }">Home</a>
      <a routerLink="/orders" routerLinkActive="active">Orders</a>
    </nav>

    <main class="page-shell">
      <div class="page-card">
        <router-outlet />
      </div>
    </main>
  `,
  styleUrl: './app.css'
})
export class AppComponent {}

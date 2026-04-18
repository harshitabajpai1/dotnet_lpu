import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { OrderStatusPipe } from './order-status.pipe';

@Component({
  selector: 'app-orders',
  standalone: true,
  imports: [CommonModule, OrderStatusPipe],
  templateUrl: './orders.component.html'
})
export class OrdersComponent {
  orders = [
    { id: 1, productName: 'Laptop', price: 75000, orderDate: new Date(), status: 0 },
    { id: 2, productName: 'Phone', price: 25000, orderDate: new Date(), status: 1 },
    { id: 3, productName: 'Headphones', price: 3000, orderDate: new Date(), status: 2 },
    { id: 4, productName: 'Keyboard', price: 1500, orderDate: new Date(), status: 3 }
  ];
}

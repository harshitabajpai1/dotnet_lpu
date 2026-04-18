import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'OrderStatus',
  standalone: true
})
export class OrderStatusPipe implements PipeTransform {
  transform(status: number): string {
    switch (status) {
      case 0:
        return 'Pending';
      case 1:
        return 'Shipped';
      case 2:
        return 'Delivered';
      case 3:
        return 'Cancelled';
      default:
        return 'Unknown';
    }
  }
}

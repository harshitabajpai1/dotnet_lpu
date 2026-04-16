import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-child',
  standalone: true,
  imports: [],
  templateUrl: './child.html',
  styleUrl: './child.css',
})
export class Child {

  @Input() childMessage: string = '';
  @Output() messageFromChild =new EventEmitter<string>();

  sendMessge(){
    this.messageFromChild.emit('Message from Child Component!');
  }
}

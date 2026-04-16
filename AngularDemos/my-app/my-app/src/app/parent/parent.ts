import { Component } from '@angular/core';
import { Child } from '../child/child';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-parent',
  standalone: true,
  imports: [Child,FormsModule],
  templateUrl: './parent.html',
  styleUrl: './parent.css',
})
export class Parent {
  msgFromParent: string = 'Hello from Parent Component!';
  msgFromChild: string = '';

  ID: number = 101;
  name: string = 'Pen';
  price: number = 120;

  receiveMsg(msg: string) {
    this.msgFromChild = msg;
  }
  DoIt():void{
    
    alert('Button Clicked!........');
  }
  CallMe():void{
    alert('Called me........');
  }


}

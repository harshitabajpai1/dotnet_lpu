import { Component } from '@angular/core';

@Component({
  selector: 'app-struct-directive',
  imports: [],
  templateUrl: './struct-directive.html',
  styleUrl: './struct-directive.css',
})
export class StructDirective {
  isAdmin:boolean = false;
  empList:Array<string> = ["Alok","Riya","Harshita","Khushi","Sakshi"];
  isVisible:boolean=true;
}

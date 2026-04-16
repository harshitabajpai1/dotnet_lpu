import { Component,computed,signal} from '@angular/core';
import { CommonModule } from '@angular/common';
import {Product} from '../Models/Product';

@Component({
  selector: 'app-build-in-directive',
  imports: [CommonModule],
  templateUrl: './build-in-directive.html',
  styleUrl: './build-in-directive.css',
})
export class BuildInDirective {
  isActive=signal(true);
  isComputed=computed(()=>score()>=90);


  prodlist:Product[]=[];

  font:any;

}



function score(){
  return 95;
}

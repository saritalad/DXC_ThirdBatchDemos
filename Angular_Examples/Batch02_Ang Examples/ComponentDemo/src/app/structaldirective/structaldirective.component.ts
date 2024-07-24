import { Component } from '@angular/core';
import { Product } from '../Models/Product';

@Component({
  selector: 'app-structaldirective',
  templateUrl: './structaldirective.component.html',
  styleUrls: ['./structaldirective.component.css']
})
export class StructaldirectiveComponent {
  fruit:string="";
  x:number=0;
  variab=100;
  products:Product[]=
  [
    {id:1,name:"Dove",price:45},
    {id:2,name:"Wheat",price:25},
    {id:3,name:"Sunflower",price:245},
    {id:4,name:"surf",price:43},
  ]
}

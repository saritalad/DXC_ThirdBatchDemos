import { Component } from '@angular/core';
import { Product } from '../Models/Product';

@Component({
  selector: 'app-structuraldirectives',
  templateUrl: './structuraldirectives.component.html',
  styleUrls: ['./structuraldirectives.component.css']
})
export class StructuraldirectivesComponent {

  Fruits:string[]=["Apple","Banana","Mango","Grapes","Orange"];
  fruit:string="";
  x:number=0;
  variab=10;
  products:Product[]=[
   
 {id:1,name:"Dove",price:56},
 {id:2,name:"Wheat",price:46},
 {id:3,name:"SunFlower",price:544},
 {id:4,name:"Kisan Sauce",price:156},
];
}

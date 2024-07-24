import { Component } from '@angular/core';
import { Product } from '../Models/Product';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
products:Product[]=[
{id:1,name:"Good Day",price:35},
{id:2,name:"Dove",price:74},
{id:3,name:"Wheat",price:35},
{id:4,name:"Sun Flower",price:135}
]
paid:boolean=false;

vegan:boolean=false

}

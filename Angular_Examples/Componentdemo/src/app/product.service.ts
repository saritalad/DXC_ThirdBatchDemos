import { Injectable } from '@angular/core';
import {Product} from './Models/Product';
@Injectable({
  providedIn: 'root'
})
export class ProductService {
products:Product[]=[
 {id:1,name:"Dove",price:45},
 {id:2,name:"Rice bran oil",price:45},
 {id:3,name:"Pulse",price:45},
 {id:4,name:"rice",price:45}
]

getProducts():any
{
return this.products;
}

getProductById(id :number):any
{
  let products:Product[]=this.getProducts();
  return products.find(p => p.id==id);
}



}

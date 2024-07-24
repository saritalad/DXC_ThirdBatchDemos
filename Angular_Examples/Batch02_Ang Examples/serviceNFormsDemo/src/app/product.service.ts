import { Injectable } from '@angular/core';
import { Product } from './Models/Product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
products:Product[]=[
{id:1,name:"dove",price:58},
{id:2,name:"Rice",price:34},
{id:3,name:"Wheat",price:29},
{id:4,name:"Surf",price:120},
{id:5,name:"Dairy milk",price:5} 
]

getProducts():any{
  return this.products;
}

getProductById(Id:number):any{
  
 let products:Product[]=this.getProducts()

  return products.find(p=>p.id==Id);
}
  
}

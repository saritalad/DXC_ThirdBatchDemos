import { Component } from '@angular/core';
import { ProductService } from '../product.service';
import { Product } from '../Models/Product';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
prodlist:Product[]=[];
 
constructor(private service:ProductService)
   {
   this.prodlist=service.getProducts();
      }

}

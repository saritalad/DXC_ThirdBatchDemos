import { Component } from '@angular/core';
import { Product } from '../Models/Product';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
prodlist:Product[]=[];

    
     constructor(private service:ProductService) {
      
      this.prodlist=service.getProducts();
      
     }

}

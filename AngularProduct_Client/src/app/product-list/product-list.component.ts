import { Component } from '@angular/core';
import { Product } from '../Models/Product';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent {
productlist:Product[]=[];
constructor(private _service:ProductService) {}

  ngOnInit()
  {
this._service.getAllProducts().subscribe(data=>{
this.productlist=data;
console.log(this.productlist);
})
 }

  Delete(id:number)
{
  this._service.deleteProduct(id).subscribe();

}



}

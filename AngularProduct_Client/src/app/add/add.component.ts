import { Component } from '@angular/core';
import { Product } from '../Models/Product';
import { ProductService } from '../product.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent {

  newprod:Product;

constructor(private _service:ProductService,private route:Router) {}
 
onSubmit(form:any)
{
this.newprod=form;
this._service.addNewProduct(this.newprod).subscribe();
console.log(this.newprod);

}



}

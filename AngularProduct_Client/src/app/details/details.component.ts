import { Component } from '@angular/core';
import { Product } from '../Models/Product';
import { ProductService } from '../product.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent {
currentprod:Product;

constructor(private _service:ProductService,private ActivatedRoute:ActivatedRoute) {}
  
ngOnInit()
{
let Id=this.ActivatedRoute.snapshot.params['id'];
this._service.getProductById(Id).subscribe(data=>{

this.currentprod=data;
console.log(this.currentprod);

})
  
}

}

import { Component } from '@angular/core';
import { Product } from '../Models/Product';
import { ActivatedRoute } from '@angular/router';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent {

product:Product;
Id:number;

constructor(private service:ProductService,private activeroute:ActivatedRoute )
 {
  this.activeroute.params.subscribe(params => { 
    this.Id = params['id']; 
    this.product=this.service.getProductById(this.Id)
 })
}




}

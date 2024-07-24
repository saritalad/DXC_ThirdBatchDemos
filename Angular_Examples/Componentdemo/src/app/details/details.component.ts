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
product:Product={id:0,name:"",price:0}
Id:number=0;
constructor(private service:ProductService,private Activeroute:ActivatedRoute)
 {
    this.Activeroute.params.subscribe(params => { 
    this.Id = params['id']; 
    this.product=this.service.getProductById(this.Id)
     
  });
}
}
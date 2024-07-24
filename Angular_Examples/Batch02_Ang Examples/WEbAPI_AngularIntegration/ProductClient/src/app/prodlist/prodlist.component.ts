import { Component } from '@angular/core';
import { Product } from 'src/Models/Product';
import { ProductService } from '../product.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-prodlist',
  templateUrl: './prodlist.component.html',
  styleUrls: ['./prodlist.component.css']
})
export class ProdlistComponent {
list:Product[];
/**
 *
 */
constructor(private service:ProductService,private router:Router) {
 }
ngOnInit()
{
  this.service.getAllProducts().subscribe(data=>
        {
         this.list=data
         console.log(this.list)
    });
}
delete(id:number)
{
this.service.deleteProduct(id).subscribe(data=>{
  alert("record deleted")},
  (error)=>{
  alert(error)
  }
);

}
}

import { Component } from '@angular/core';
import { Product } from 'src/Models/Product';
import { ProductService } from '../product.service';
import { Router } from '@angular/router';
import { category } from 'src/Models/Category';
import { CatService } from '../cat.service';

@Component({
  selector: 'app-prod-add',
  templateUrl: './prod-add.component.html',
  styleUrls: ['./prod-add.component.css']
})
export class ProdAddComponent {
newprod:Product;
catlist:category[]=[];
catId:number
constructor(private service :ProductService,private catservice:CatService,private route:Router) {}  

ngOnInit()
{
  this.catservice.getAllCategories().subscribe(data=>{
    this.catlist=data;
    console.log(this.catlist)
  })
}

onSubmit(product:any)
{
  this.catId=parseInt(product.catid)
  product.catid=this.catId
  console.log(" data "+product+" catid " + this.catId)

this.service.AddNewProduct(product).subscribe(data=>{
 alert("new product Added");
},
(error)=>{console.log(error),
alert(error)});
//this.route.navigate(["/prodlist"]);

}
 
}

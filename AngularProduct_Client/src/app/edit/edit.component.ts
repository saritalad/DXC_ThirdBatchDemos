import { Component, numberAttribute } from '@angular/core';
import { Product } from '../Models/Product';
import { ProductService } from '../product.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent {
prod:Product;
Id:number;
constructor(private _service:ProductService,private activeRoute:ActivatedRoute,private router:Router) {}
  
ngOnInit()
{

  let ID=this.activeRoute.snapshot.params["id"];
 this.Id=ID;
 console.log(this.Id);
  this._service.getProductById(this.Id).subscribe(data=>{
  this.prod=data;
console.log(this.prod)
  })


}
onSubmit(prod:any)
{
this._service.Update(prod).subscribe();

}


}

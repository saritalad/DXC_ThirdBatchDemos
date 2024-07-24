import { Component } from '@angular/core';
import { Product } from 'src/Models/Product';
import { ProductService } from '../product.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-prod-edit',
  templateUrl: './prod-edit.component.html',
  styleUrls: ['./prod-edit.component.css']
})
export class ProdEditComponent {
modifiedproduct:Product
Id:number

      constructor(private service :ProductService,private activeRoute:ActivatedRoute ) {
        
 }

            ngOnInit()
            {
           this.Id= this.activeRoute.snapshot.params["id"]
              this.service.getProductById(this.Id).subscribe(data=>{
                this.modifiedproduct=data
                console.log(this.modifiedproduct);
              })
           }

           Submit(form:Product)
           {
            this.modifiedproduct=form
            this.modifiedproduct.catid=Number(form.catid);
            this.modifiedproduct.price=Number(form.price);
            this.service.UpdateProduct(this.modifiedproduct).subscribe(data=>
              {
                console.log(this.modifiedproduct),
                alert("Update Successfull!");},
                error=> {console.log(error);}
             
            );
           }

}

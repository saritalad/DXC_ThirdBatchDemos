import { Component } from '@angular/core';
import { category } from 'src/Models/Category';
import { CatService } from '../cat.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-cat-edit',
  templateUrl: './cat-edit.component.html',
  styleUrls: ['./cat-edit.component.css']
})
export class CatEditComponent {
modified:category
Id:number;
  errorMessage: any;
constructor(private service:CatService,private activeroute:ActivatedRoute) {
 
}
ngOnInit()
{
 this.Id= this.activeroute.snapshot.params["id"];
  this.service.getCatById(this.Id).subscribe(data=>{
    this.modified=data,
    console.log(this.modified)
  },
  (error)=>
  {
    console.error('error caught in component')
    this.errorMessage = error;
    alert(this.errorMessage)
  }
  );
}
Submit(form:any)
{
  this.modified=form
  this.service.Update(this.Id,this.modified).subscribe(data=>{
    console.log(this.modified)
  },
  (error)=>
  {
    alert(error)
  }
  )
}

}

import { Component } from '@angular/core';
import { category } from 'src/Models/Category';
import { CatService } from '../cat.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cat-add',
  templateUrl: './cat-add.component.html',
  styleUrls: ['./cat-add.component.css']
})
export class CatAddComponent {
newCategory:category
  errorMessage: any;

        constructor(private service:CatService,private router:Router) {
            
    }
  onSubmit(catForm:any)
  {
this.newCategory=catForm
    this.service.AddCategory(this.newCategory).subscribe(data=>
      {
        console.log(this.newCategory)
      },
      (error) => {                              //Error callback
        console.error('error caught in component')
        this.errorMessage = error;
        alert(this.errorMessage)
      })
  }
}

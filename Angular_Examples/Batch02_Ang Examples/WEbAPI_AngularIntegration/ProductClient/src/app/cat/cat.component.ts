import { Component } from '@angular/core';
import { category } from 'src/Models/Category';
import { CatService } from '../cat.service';

@Component({
  selector: 'app-cat',
  templateUrl: './cat.component.html',
  styleUrls: ['./cat.component.css']
})
export class CatComponent {
catlist:category[]=[];

constructor(private service:CatService) {
 
}
    ngOnInit()
    {
      this.service.getAllCategories().subscribe(result=>{
        this.catlist=result
      })
    }



}

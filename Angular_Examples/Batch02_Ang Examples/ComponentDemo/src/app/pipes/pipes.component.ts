import { Component } from '@angular/core';
import { Product } from '../Models/Product';
import {Customer} from '../Models/Customer'
@Component({
  selector: 'app-pipes',
  templateUrl: './pipes.component.html',
  styleUrls: ['./pipes.component.css']
})
export class PipesComponent {
//x:number=450.50
customer:string="Akash Kumar"
product:Product={id:1,name:"wheat",price:45}
dateVal:Date=new Date(2024,0,12);// yyyy/MM/dd
x:number=5400.456;
Val: Object = {foodname: 'Pasta', special: {topings: 'cheese'}};

Customer:Customer={Id:1,Name:"Bill",custAddress:"Pune"};
institute:string="Abc computers";
city:string="Nagpur";
}

import { Component } from '@angular/core';

@Component({
  selector: 'app-pipes',
  templateUrl: './pipes.component.html',
  styleUrls: ['./pipes.component.css']
})
export class PipesComponent {
  x:number=5400.456;
  obj: Object = {foodname: 'Pasta', special: {topings: 'cheese'}};
  dateVal=Date.now();
  customer:Customer={Id:1,Name:"Bill",custAddress:"Pune"};
  institute:string="Abc computers";
  city:string="Nagpur";
}

class Customer{
  Id:number=0;
  Name:string="";
  custAddress:string="";
}  
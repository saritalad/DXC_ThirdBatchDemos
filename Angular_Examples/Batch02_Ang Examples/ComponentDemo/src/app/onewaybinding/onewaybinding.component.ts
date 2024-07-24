import { Component } from '@angular/core';

@Component({
  selector: 'app-onewaybinding',
  templateUrl: './onewaybinding.component.html',
  styleUrls: ['./onewaybinding.component.css']
})
export class OnewaybindingComponent {
  title="One Way Binding Example:";
  x:number=10;
  y:number=20;
   name:string ="Sarita";
   profession:string="dot net trainer";
   user={name:"Sarita",email:"sarita_lad@rediffmail.com"}
   color:string='red';
   getColor()
   {
      return this.color;
   }
   count:number=0;
   ClickMe()
   {
     this.count++;
   
   }
   val="";
   handleInput(element:any) {
     this.val=element.value;
   }


}

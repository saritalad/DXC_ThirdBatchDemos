import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'demo';
  x:number=100;
  name:string="sarita"
  fruits:string[]=["apple","Orange","Mango","Grapes"]
  result:boolean=false;
  vegan:boolean=false
}

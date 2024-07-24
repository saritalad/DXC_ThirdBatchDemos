import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Componentdemo';
   name:string="Sarita"
   today:Date=new Date();
   img:string="./assets/images/Saraswati.png"

}

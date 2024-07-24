import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  image:string="./assets/images/Saraswati.png"
  fruits:string[]=["Apple","Orange","Grapes","Mange","Banana"]
}

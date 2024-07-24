import { Component } from '@angular/core';

@Component({
  selector: 'myroot',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ComponentDemo';
  name:string="Sarita";
  job:string="Corporate dotnet Trainer"
  today:Date=new Date();
}

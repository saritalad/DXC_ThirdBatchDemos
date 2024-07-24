import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'EduHub_AngularFrontEnd';
  /**
   *
   */
  constructor(private router:Router) {
      
  }
  logout()
{
localStorage.setItem('logged','false')
this.router.navigate(["home"])
}
}

import { Component } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-detail',
  templateUrl: './detail.component.html',
  styleUrls: ['./detail.component.css']
})
export class DetailComponent {

   constructor(private router:Router) {
   
    
  }

  gotoOrder()
  {
      this.router.navigate(['/order'])

  }
  goBack()
  {
this.router.navigateByUrl('/product')

  }



}

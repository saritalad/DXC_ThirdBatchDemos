import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-child-a',
  templateUrl: './child-a.component.html',
  styleUrls: ['./child-a.component.css']
})
export class ChildAComponent {

    /**
     *
     */
    constructor(private router:Router,private activated:ActivatedRoute) {
      

    }



  gotoChildB()
  {

this.router.navigate(['../child-b'],{relativeTo:this.activated})

  }



}

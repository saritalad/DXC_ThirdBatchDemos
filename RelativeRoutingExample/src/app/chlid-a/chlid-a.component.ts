import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-chlid-a',
  templateUrl: './chlid-a.component.html',
  styleUrls: ['./chlid-a.component.css']
})
export class ChlidAComponent {

  constructor(private router:Router,private activeRoute:ActivatedRoute){

  }
  // activeRoute is current Route that is Child-a

  goToChildB()
  {
    this.router.navigate(['../child-b'],{relativeTo:this.activeRoute})
  }


}

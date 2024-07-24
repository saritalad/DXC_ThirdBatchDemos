import { Component } from '@angular/core';
import { User } from '../Models/User';

@Component({
  selector: 'app-educator-dashboard',
  templateUrl: './educator-dashboard.component.html',
  styleUrls: ['./educator-dashboard.component.css']
})
export class EducatorDashboardComponent {

  ID:any;
  token:string=""
  Role:any
 username:any;
 photo:any;
    ngOnInit()
    {
     this.ID=sessionStorage.getItem("ID");
     this.Role=sessionStorage.getItem("userrole");
     this.username=sessionStorage.getItem("username");
     this.photo=sessionStorage.getItem("profileImage")
    }
      
      
    
  

}
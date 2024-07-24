import { Component } from '@angular/core';

@Component({
  selector: 'app-student-dash-board',
  templateUrl: './student-dash-board.component.html',
  styleUrls: ['./student-dash-board.component.css']
})
export class StudentDashBoardComponent {
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

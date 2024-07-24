import { Component } from '@angular/core';
import { EnrollmentService } from '../Services/enrollment.service';
import { Enrollment } from '../Models/Entrollment';
import { Router } from '@angular/router';

@Component({
  selector: 'app-enrollment',
  templateUrl: './enrollment.component.html',
  styleUrls: ['./enrollment.component.css']
})
export class EnrollmentComponent {
enrolledstudents:Enrollment[]=[];
constructor(private service:EnrollmentService,private router:Router) {}
ngOnInit()
{//debugger;
this.service.getEnrollments().subscribe(res=>{
  this.enrolledstudents=res;
  console.log(this.enrolledstudents)
});
  

}
}
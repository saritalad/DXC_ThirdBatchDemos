import { Component } from '@angular/core';
import { EnrollViewModel } from '../Models/EnrollmentViewModel';
import { Enrollment } from '../Models/Entrollment';
import { EnrollmentService } from '../Services/enrollment.service';

@Component({
  selector: 'app-enrollment-view',
  templateUrl: './enrollment-view.component.html',
  styleUrls: ['./enrollment-view.component.css']
})
export class EnrollmentViewComponent {
enrollist:Enrollment[]=[];
ID:any
myId:number
/**
 *
 */
constructor(private service:EnrollmentService) {
   
}
ngOnInit()
{
  this.ID=sessionStorage.getItem("ID")
this.myId=Number(this.ID)
  this.service.getEnrollmentsByStudentId(this.myId).subscribe(data=>{
    this.enrollist=data,
    console.log(data)
  })

}


}

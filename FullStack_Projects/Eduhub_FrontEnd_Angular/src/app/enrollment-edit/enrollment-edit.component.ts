import { Component } from '@angular/core';
import { Enrollment } from '../Models/Entrollment';
import { EnrollmentService } from '../Services/enrollment.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-enrollment-edit',
  templateUrl: './enrollment-edit.component.html',
  styleUrls: ['./enrollment-edit.component.css']
})
export class EnrollmentEditComponent {
enrolledstudent:Enrollment={enrollmentId:0,userId:0,courseId:0,enrollmentDate:new Date(),status:'active'}
Id:any;
Statuslist:string[]=['active','Accepted','Rejected']
selectedStatus: string = 'Active';
constructor(private service:EnrollmentService,private route :Router,private activeroute:ActivatedRoute) {
  
}
ngOnInit()
{ this.Id=this.activeroute.snapshot.params['id'];

  this.service.getEnrollment(this.Id).subscribe(data=>{
    this.enrolledstudent=data,
    console.log(this.enrolledstudent)
  })
}
onSubmit(Enquiry:any)
{
  this.service.updateEnrollment(this.Id,this.enrolledstudent).subscribe(data=>{
    alert("Status changed"),
    this.route.navigate(['/Edashboard/enrollist'])
  },
err=>alert(err)
  );
}
onStatusChange(event:any)
{
    this.enrolledstudent.status=event.target.value
    console.log('selected status is '+ this.enrolledstudent.status)
}



}

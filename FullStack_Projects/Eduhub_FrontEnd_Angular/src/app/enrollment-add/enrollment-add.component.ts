import { Component } from '@angular/core';
import { Enrollment } from '../Models/Entrollment';
import { EnrollmentService } from '../Services/enrollment.service';
import { Router } from '@angular/router';
import { Course } from '../Models/Course';
import { CourseService } from '../Services/course.service';

@Component({
  selector: 'app-enrollment-add',
  templateUrl: './enrollment-add.component.html',
  styleUrls: ['./enrollment-add.component.css']
})
export class EnrollmentAddComponent {
newenrolement:Enrollment={
  enrollmentId: 0,
  userId: 0,
  courseId: 0,
  enrollmentDate: new Date(),
  status:'active'
}
Statuslist:string[]=['pending','in process','closed']
selectedCourseId: number = 0; // To store the selected courseId
selectedStatus: string = 'pending'; 
course:Course={courseId:0,title:'',description:'',courseStartDate:new Date(),
courseEndDate:new Date(),category:'',level:'',userId:0
};

courselist:Course[]=[];
Id:any;
constructor(private service:EnrollmentService,private service1:CourseService,private router:Router) {}
  
ngOnInit()
{
  this.Id=sessionStorage.getItem("ID")
  this.newenrolement.userId=this.Id;
  console.log("UserId :"+this.newenrolement.userId)
  this.service1.getCourses().subscribe(data=>{
    this.courselist=data,
    console.log(this.courselist)
  })

}
onSubmit(enrolement:any)
{
  this.service.createEnrollment(this.newenrolement).subscribe(data=>{
    alert("You are Enrolled Successfully!")
  },
error=>alert(error))
}



onCourseChange(event: any) {
  this.selectedCourseId =event.target.value;
  this.newenrolement.courseId=this.selectedCourseId;
  console.log('Selected Course ID:',this.newenrolement.courseId);
  // You can perform actions based on the selected course ID here
}

}

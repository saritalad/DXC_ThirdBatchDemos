import { Component } from '@angular/core';
import { EnquiryService } from '../Services/enquiry.service';
import { Router } from '@angular/router';
import { Enquiry } from '../Models/Enquiry';
import { CourseService } from '../Services/course.service';
import { Course } from '../Models/Course';


@Component({
  selector: 'app-enquiry-add',
  templateUrl: './enquiry-add.component.html',
  styleUrls: ['./enquiry-add.component.css']
})
export class EnquiryAddComponent {
newenquiry:Enquiry={enquiryId:0,courseId:0,userId:0,subject:'',message:'',enquiryDate:new Date(),
status:'',response:''
}
Statuslist:string[]=['pending','in process','closed']
selectedCourseId: number = 0; // To store the selected courseId
selectedStatus: string = 'pending'; 
course:Course={courseId:0,title:'',description:'',courseStartDate:new Date(),
courseEndDate:new Date(),category:'',level:'',userId:0
};
Id:any;
courselist:Course[]=[];
currentDate: Date=new Date(2024,5,6,0,0,0);
constructor(private service:EnquiryService,private service1:CourseService,private router:Router) {}
ngOnInit()
{
 // this.newenquiry.enquiryDate=this.currentDate
  this.Id=sessionStorage.getItem("ID")
  this.newenquiry.userId=this.Id;
  console.log("UserId :"+this.newenquiry.userId)
this.service1.getCourses().subscribe(data=>{
  this.courselist=data,
  console.log(this.courselist)
})
}


  
onSubmit()
{
this.service.createEnquiry(this.newenquiry).subscribe(data=> 
  {alert("New enquiry  placed Successfully"),
    console.log(this.newenquiry)
  },
 
  err=>{alert(err);
    console.log(this.newenquiry)
  },
);
}
onCourseChange(event: any) {
  this.selectedCourseId =event.target.value;
  this.newenquiry.courseId=this.selectedCourseId;
  console.log('Selected Course ID:',this.newenquiry.courseId);
  // You can perform actions based on the selected course ID here
}
onStatusChange(event:any)
{
    this.newenquiry.status=event.target.value
    console.log('selected status is '+ this.newenquiry.status)
}

}

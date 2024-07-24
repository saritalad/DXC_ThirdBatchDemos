import { Component } from '@angular/core';
import { Course } from '../Models/Course';
import { CourseService } from '../Services/course.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-course-edit',
  templateUrl: './course-edit.component.html',
  styleUrls: ['./course-edit.component.css']
})
export class CourseEditComponent {
  currentcourse:Course={courseId:0,title:'',description:'',courseStartDate:new Date('2024-05-06T00:00:00'),
  courseEndDate:new Date('2024-05-06T00:00:00'),category:'',level:'',userId:0
};
constructor(private service:CourseService,private route:Router,private activeroute:ActivatedRoute) {}
 id:number;
ngOnInit()
  {
    const tid= this.activeroute.snapshot.params["id"];// route variable 
    this.id=Number(tid);
     this.service.getCourse(this.id).subscribe(data=>{
        this.currentcourse=data
             });

          
    }
    onSubmit(currentcourse:any)
    {
      this.service.updateCourse(this.currentcourse).subscribe((data) => {
        console.log(this.currentcourse);
        alert("Recorded Edited");
        this.route.navigate(['/Edashboard/course']);
    
  });
}

}
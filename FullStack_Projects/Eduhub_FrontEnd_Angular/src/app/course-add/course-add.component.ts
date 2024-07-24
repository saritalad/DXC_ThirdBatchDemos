import { Component } from '@angular/core';
import { Course } from '../Models/Course';
import { CourseService } from '../Services/course.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-course-add',
  templateUrl: './course-add.component.html',
  styleUrls: ['./course-add.component.css']
})
export class CourseAddComponent {
 newcourse:Course={courseId:0,title:'',description:'',courseStartDate:new Date('2024-05-06T00:00:00'),
  courseEndDate:new Date('2024-05-06T00:00:00'),category:'',level:'',userId:0
};
ID:any
      
      constructor(private service:CourseService,private router:Router) {
              
      }
      ngOnInit()
      {
        this.ID=sessionStorage.getItem("ID");
        this.newcourse.userId=parseInt(this.ID);
        console.log(this.ID)
      }
onSubmit()
{ 
this.service.createCourse(this.newcourse).subscribe(data=> 
  {
    alert("New Course added Successfully"),
    console.log(this.newcourse)
  },
 
  err=>{alert(err);
  console.log(this.newcourse)
  },
);
this.router.navigate(['Edashboard'])
}
}

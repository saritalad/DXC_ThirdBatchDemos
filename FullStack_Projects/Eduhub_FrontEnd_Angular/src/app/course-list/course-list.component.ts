import { Component } from '@angular/core';
import { CourseService } from '../Services/course.service';

@Component({
  selector: 'app-course-list',
  templateUrl: './course-list.component.html',
  styleUrls: ['./course-list.component.css']
})
export class CourseListComponent {
  courselist:any[]=[];
  
  constructor(private service:CourseService) {}
   
    ngOnInit()
    { this.service.getCourses().subscribe(data=>{
      this.courselist=data;
      console.log(this.courselist)
    });

    
    
  }
}

import { Component } from '@angular/core';
import { CourseService } from '../Services/course.service';


@Component({
  selector: 'app-course',
  templateUrl: './course.component.html',
  styleUrls: ['./course.component.css']
})
export class CourseComponent {
courselist:any[]=[];
  ID:any;
  constructor(private service:CourseService) {}
    
    ngOnInit()
    {this.ID=sessionStorage.getItem("ID");
    console.log("Id="+this.ID)
      this.service.getCoursesByUserId(this.ID)
      .subscribe(data=>{
        this.courselist=data;
        console.log("courselist"+data)
      })
      
    }
    
  
}

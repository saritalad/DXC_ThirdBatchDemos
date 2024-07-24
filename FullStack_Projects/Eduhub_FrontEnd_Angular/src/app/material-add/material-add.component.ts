import { Component } from '@angular/core';
import { Material } from '../Models/Material';
import { MaterialService } from '../Services/material.service';
import { CourseService } from '../Services/course.service';

@Component({
  selector: 'app-material-add',
  templateUrl: './material-add.component.html',
  styleUrls: ['./material-add.component.css']
})
export class MaterialAddComponent {
  selectedCourseId: number = 0;
  courselist:any[]=[];
  ID:any;
  newmaterial:Material={materialId:0,courseId:0,title:'',description:'',contentType:'',uploadDate:new Date(),url:''};
      constructor(private service:MaterialService,private service1:CourseService) {
              
      }
          
      ngOnInit()
      {this.ID=sessionStorage.getItem("ID");
         console.log("Id="+this.ID)
         this.service1.getCoursesByUserId(this.ID)
         .subscribe(data=>{
          this.courselist=data,
           console.log("courselist"+data)
      })
    }
    
onSubmit()
{
this.service.createMaterial(this.newmaterial).subscribe(data=> 
  {alert("New Material added Successfully"),
    console.log(this.newmaterial)
  },
 
  err=>{alert(err);},
);
}
onCourseChange(event: any) {
  this.selectedCourseId =event.target.value;
  this.newmaterial.courseId=this.selectedCourseId;
  console.log('Selected Course ID:',this.newmaterial.courseId);
  // You can perform actions based on the selected course ID here
}
}

import { Component } from '@angular/core';
import { Material } from '../Models/Material';
import { MaterialService } from '../Services/material.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-material',
  templateUrl: './material.component.html',
  styleUrls: ['./material.component.css']
})
export class MaterialComponent {
  mlist:Material[]=[];
id:number
userRole:any
constructor(private service:MaterialService,private router:Router,private activeRoute:ActivatedRoute) {}
 ngOnInit()
 { 
 this.id= this.activeRoute.snapshot.params["id"];

  this.service.getMaterialByCourseId(this.id).subscribe((res:any)=>{
    this.mlist=res
       console.log("material list"+this.mlist)
  }  );
 }

delete(id:number)
{
  confirm("Are You Sure?")
  this.service.deleteMaterial(id).subscribe(data=>{
    alert("Material removed successfully")
    this.router.navigate(['/Educatordashboard/courses',this.id])
  })
}
}


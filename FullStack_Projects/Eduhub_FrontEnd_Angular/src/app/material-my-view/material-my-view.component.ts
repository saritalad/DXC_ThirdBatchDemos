import { Component } from '@angular/core';
import { Material } from '../Models/Material';
import { MaterialService } from '../Services/material.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-material-my-view',
  templateUrl: './material-my-view.component.html',
  styleUrls: ['./material-my-view.component.css']
})
export class MaterialMyViewComponent {
  mlist:Material[]=[];
  id:number
  userRole:any
  constructor(private service:MaterialService,private router:Router,private activeRoute:ActivatedRoute) {}
   ngOnInit()
   { 
   this.id= this.activeRoute.snapshot.params["id"];
  //  sessionStorage.setItem("courseId",String(this.id))
  //  console.log("courseid ="+this.id)
   //this.userRole=sessionStorage.getItem("userrole")
  console.log(this.userRole)
    this.service.getMaterialByCourseId(this.id).subscribe((res:any)=>{
      this.mlist=res
         console.log("material list"+this.mlist)
    }  );
   }
  
}

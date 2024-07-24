import { Component } from '@angular/core';
import { Material } from '../Models/Material';
import { MaterialService } from '../Services/material.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-material-edit',
  templateUrl: './material-edit.component.html',
  styleUrls: ['./material-edit.component.css']
})
export class MaterialEditComponent {
currentmaterial:Material;
constructor(private service:MaterialService,private route:Router,private activeroute:ActivatedRoute) {}
 id:number;
ngOnInit()
  {
    const tid= this.activeroute.snapshot.params["id"];// route variable 
    this.id=Number(tid);
     this.service.getMaterial(this.id).subscribe(data=>{
        this.currentmaterial=data
             });

          
    }
    onSubmit(currentmaterial:any)
    {
      this.service.updateMaterial(this.currentmaterial).subscribe((data) => {
        console.log(this.currentmaterial);
        alert("Recorded Edited");
        this.route.navigate(['/Edashboard/course']);
    
  });

    }


}

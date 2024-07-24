import { Component } from '@angular/core';
import { Employee } from 'src/Models/Employee';
import { EmpService } from '../emp.service';

@Component({
  selector: 'app-emp-list',
  templateUrl: './emp-list.component.html',
  styleUrls: ['./emp-list.component.css']
})
export class EmpListComponent {
emplist:Employee[]=[];
/**
 *
 */
constructor(private service:EmpService) {
   }

   ngOnInit()
   {
    this.service.getAllEmployees().subscribe(data=>
      {
        this.emplist=data;
        console.log(this.emplist)
      },
      (error)=>{

        alert(error)
      }
      )
   
    }
    
   }





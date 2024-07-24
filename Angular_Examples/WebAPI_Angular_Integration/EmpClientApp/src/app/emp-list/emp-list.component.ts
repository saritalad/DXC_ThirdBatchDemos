import { Component } from '@angular/core';
import { Employee } from '../Models/Employee';
import { EmpService } from '../emp.service';

@Component({
  selector: 'app-emp-list',
  templateUrl: './emp-list.component.html',
  styleUrls: ['./emp-list.component.css']
})
export class EmpListComponent  {
employees:Employee[];


constructor(private service :EmpService) {
   
}



ngOnInit()
      {
        this.service.getEmployees().subscribe(data=>{
          if(data.success){
            this.employees=data,
            console.log(data)
          }
          else
          {
            alert("error")
          }
        
                  });
  
      }
}

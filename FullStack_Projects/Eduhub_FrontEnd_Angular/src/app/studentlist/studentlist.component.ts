import { Component } from '@angular/core';
import { UserService } from '../Services/user.service';
import { User } from '../Models/User';

@Component({
  selector: 'app-studentlist',
  templateUrl: './studentlist.component.html',
  styleUrls: ['./studentlist.component.css']
})
export class StudentlistComponent {
students:User[]=[];
  constructor(private service:UserService) {}

ngOnInit()
{
  this.service.getAllStudents().subscribe((data:any)=>{
    this.students=data
    console.log(this.students);
  })
}


  }


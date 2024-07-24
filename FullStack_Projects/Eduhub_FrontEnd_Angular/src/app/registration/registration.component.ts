import { Component } from '@angular/core';
import { User } from '../Models/User';
import { UserService } from '../Services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent {
  userRoles:string[] = ['Educator', 'Student', 'Admin'];
  selectedUserRole: string = 'Educator';
  user:User={userId:0,userName:'',email:'',password:'',mobileNumber:'',userRole:'',profileImage:''};
role:string
    /**
     *
     */
    constructor(private service:UserService,private router:Router) {}
     
onSubmit()
{
this.service.createUser(this.user).subscribe(res=>{
  alert("New User added Successfully"),
console.log(this.user)},
  error=>alert(error)
)
this.router.navigate(['home'])
}



onUserRoleChange(event: any) {
  this.selectedUserRole = event.target.value;
  // You can handle the change event here, for example:
  console.log('Selected User Role:', this.selectedUserRole);
  // Perform actions based on the selected user role
}




}

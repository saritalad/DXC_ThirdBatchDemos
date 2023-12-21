import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { UserService } from '../user.service';
import { ActivatedRoute, Router } from '@angular/router';
import { User } from '../Models/User';

@Component({
  selector: 'app-edit-user',
  templateUrl: './edit-user.component.html',
  styleUrls: ['./edit-user.component.css']
})
export class EditUserComponent {

 userForm=new FormGroup({
    id: new FormControl('1',Validators.required),
    firstname:new FormControl('a',[Validators.required,Validators.minLength(3)]),
    lastname:new FormControl('a',[Validators.required,Validators.minLength(3)])
     
    })
   constructor(private _service:UserService,private router:Router,private activatedroute:ActivatedRoute) {
   
    
  }

  // ngOnInit(): void {
  //   let id = this.activatedroute.snapshot.params["id"];
  //   let user = this._service.getUserById(id);
  //     this.userForm =new FormGroup({
  //      id:new FormControl(user?.id,Validators.required),
  //     firstname: new FormControl(user?.firstname, [Validators.required, Validators.minLength(4)]),
  //     lastname: new FormControl(user?.lastname,[Validators.required,Validators.minLength(4)]),
    

  //   })

 // }

onSubmit()
{
  console.log(this.userForm.value)
}

get Id()
{
return this.userForm.controls['id'];

}
get Firstname()
{  
  return this.userForm.controls['firstname'];
}
get Lastname()
{
  return this.userForm.controls['lastname'];
}
}

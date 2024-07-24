import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-reactive-form',
  templateUrl: './reactive-form.component.html',
  styleUrls: ['./reactive-form.component.css']
})
export class ReactiveFormComponent {
userForm=new FormGroup({
id:new FormControl("1",[Validators.required]),
firstname:new FormControl("Bill",[Validators.required,Validators.minLength(3)]),
lastname:new FormControl("Gates",[Validators.required,Validators.minLength(3)])
 
})

get Firstname()
{
  return this.userForm.controls['firstname']

}
get Lastname()
{
  return this.userForm.controls['lastname']

}

get Id()
{
  return this.userForm.controls['id']
}
Submit()
{
  console.log(this.userForm.value)
}

}

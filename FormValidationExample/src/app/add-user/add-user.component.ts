import { Component } from '@angular/core';
import { User } from '../Models/User';
import { UserService } from '../user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})
export class AddUserComponent {

user:User;
     constructor(private _service:UserService,private router :Router) {
          
    }


  onSubmit(newuser:any)
  {
this.user=newuser;
this._service.AddUser(this.user);
//console.log(this.user)
   this.router.navigate(['/list'])
  }

}

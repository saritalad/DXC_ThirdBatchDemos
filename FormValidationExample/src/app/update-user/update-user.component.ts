import { Component } from '@angular/core';
import { User } from '../Models/User';
import { UserService } from '../user.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-update-user',
  templateUrl: './update-user.component.html',
  styleUrls: ['./update-user.component.css']
})
export class UpdateUserComponent {
currentobj :any;

constructor(private _service:UserService,private router :Router,private activeroute:ActivatedRoute) {}

ngOnInit()
{
   let Id= this.activeroute.snapshot.params['id'];
   this.currentobj=this._service.getUserById(Id);

}
onSubmit()
{
  this._service.UpdateUser(this.currentobj);
  this.router.navigate(['/list']);
 // console.log(user);
}

}

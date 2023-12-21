import { Component } from '@angular/core';
import { UserService } from '../user.service';
import { User } from '../Models/User';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent {

userlist:User[];

constructor(private _service:UserService) {
 
}
ngOnInit()
{
  this.userlist=this._service.getUser();
}
delete(id:number)
{
this._service.RemoveUser(id);
alert("record deleted");
}

}

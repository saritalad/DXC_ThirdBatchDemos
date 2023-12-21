import { Injectable } from '@angular/core';
import { User } from './Models/User';

@Injectable({
  providedIn: 'root'
})
export class UserService {
users:User[]=[

{id:1,firstname:"bill",lastname:'Sates'},
{id:2,firstname:"Mill",lastname:'Jates'},
{id:3,firstname:"Jill",lastname:'Mates'},
{id:4,firstname:"Nill",lastname:'Nates'},
{id:5,firstname:"Jill",lastname:'Bates'}, 
]

getUser():User[]
{
  return this.users;
}
getUserById(id:number)
{
 return this.users.find(u=>u.id==id);
}
  
AddUser(newuser:User)
{
  let users :User[]=this.users;
  users.push(newuser);
}

UpdateUser(user:User)
{
let index=this.users.findIndex(u=>u.id==user.id);
this.users.splice(index,1);
this.users.push(user);
}
RemoveUser(id:number)
{
  let index=this.users.findIndex(u=>u.id==id);
  this.users.splice(index,1);

}

}

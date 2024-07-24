import { Component } from '@angular/core';
import { User } from '../Models/User';
import { AuthService } from '../Services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-stud-login',
  templateUrl: './stud-login.component.html',
  styleUrls: ['./stud-login.component.css']
})
export class StudLoginComponent {
  currentuser:User={userId:0,userName:'',userRole:'',mobileNumber:'',email:'',profileImage:''};

  constructor(private _service:AuthService,private router:Router) {}   
  
    onSubmit(form:any)
  {   let loginuser=form.value;
    this._service.Login(loginuser).subscribe((res:any)=>
      {  
      if(res.status==200)
      {
            alert("login success!");
            sessionStorage.setItem('loginToken',res.body.token)
            sessionStorage.setItem("ID", res.body.userId)
            sessionStorage.setItem("username",res.body.userName)
            sessionStorage.setItem("userrole",res.body.userRole)
            sessionStorage.setItem("profileImage",res.body.profileImage)
            this.currentuser=res.body;
           // console.log(res.body.userName)
            this.router.navigateByUrl('Sdashboard');
                     
      }
      },(err:any)=>
      {
      alert("There was a problem logging"+err.message);
     
      });


    }


}

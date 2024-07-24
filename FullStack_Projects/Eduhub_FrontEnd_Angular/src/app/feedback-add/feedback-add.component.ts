import { Component } from '@angular/core';
import { Feedback } from '../Models/Feedback';
import { FeedbackService } from '../Services/feedback.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-feedback-add',
  templateUrl: './feedback-add.component.html',
  styleUrls: ['./feedback-add.component.css']
})
export class FeedbackAddComponent {
newfeedback:Feedback={ feedBackId: 0,
userId: 0,
feedbackmsg: "",
feedbackdate:new Date()}
/**
 *
 */
constructor(private service:FeedbackService,private router:Router) {
  }
fId:any;
ngOnInit()
{
  this.fId=sessionStorage.getItem("ID")
  this.newfeedback.userId=this.fId;
}

onSubmit(feedback:any)
{ this.service.CreateFeedback(this.newfeedback).subscribe(data=>{
  alert("You are Enrolled Successfully!")
},
error=>alert(error))

}
}
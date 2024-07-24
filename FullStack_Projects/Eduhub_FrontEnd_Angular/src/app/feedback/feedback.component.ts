import { Component } from '@angular/core';
import { Feedback } from '../Models/Feedback';
import { FeedbackService } from '../Services/feedback.service';

@Component({
  selector: 'app-feedback',
  templateUrl: './feedback.component.html',
  styleUrls: ['./feedback.component.css']
})
export class FeedbackComponent {
feedbacklist:Feedback[]=[];

constructor(private service:FeedbackService) {}
    
ngOnInit()
{
  this.service.getAllfeedbacks().subscribe(data=>{
    this.feedbacklist=data,
    console.log(this.feedbacklist)
  },
  err=>{alert(err)});
 
  
}


}

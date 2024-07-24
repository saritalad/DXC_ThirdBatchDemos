import { Component } from '@angular/core';
import { Enquiry } from '../Models/Enquiry';
import { EnquiryService } from '../Services/enquiry.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-enquiry-edit',
  templateUrl: './enquiry-edit.component.html',
  styleUrls: ['./enquiry-edit.component.css']
})
export class EnquiryEditComponent {
enquiry:Enquiry={enquiryId:0,userId:0,courseId:0,subject:'',message:'',status:'',enquiryDate:new Date()}
 enId:any;
 Statuslist:string[]=['pending','in process','closed']
 selectedStatus: string = 'pending'; 
constructor(private service:EnquiryService,private router:Router,private activeroute:ActivatedRoute) {}

  ngOnInit()
  {
const id=this.activeroute.snapshot.params["id"]
this.enId=Number(id)

this.service.getEnquiry(this.enId).subscribe(data=>{
  this.enquiry=data,
  console.log((this.enquiry))
})
  }
onSubmit(Enquiry:any)
{
  this.service.updateEnquiry(this.enId,this.enquiry).subscribe(data=>{
    alert("Status changed")
  },
err=>alert(err)
  );
}

onStatusChange(event:any)
{
    this.enquiry.status=event.target.value
    console.log('selected status is '+ this.enquiry.status)
}


  }







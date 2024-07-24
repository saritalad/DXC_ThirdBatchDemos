import { Component } from '@angular/core';
import { Enquiry } from '../Models/Enquiry';
import { EnquiryService } from '../Services/enquiry.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-enquiry',
  templateUrl: './enquiry.component.html',
  styleUrls: ['./enquiry.component.css']
})
export class EnquiryComponent {
enquirylist:Enquiry[]=[];
/**
 *
 */
constructor(private service:EnquiryService,private router:Router) {}
    ngOnInit()
    {
        this.service.getEnquiries().subscribe((res:any)=>{
          this.enquirylist=res;
          console.log(this.enquirylist)
        })
    }
  



}

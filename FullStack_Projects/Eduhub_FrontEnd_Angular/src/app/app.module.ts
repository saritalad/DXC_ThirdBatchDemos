import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HTTP_INTERCEPTORS, HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
import { StudentlistComponent } from './studentlist/studentlist.component';
import { MaterialComponent } from './material/material.component';
import { EducatorDashboardComponent } from './educator-dashboard/educator-dashboard.component';
import { StudentDashBoardComponent } from './student-dash-board/student-dash-board.component';
import { CourseComponent } from './course/course.component';
import { MyInterceptor } from './my.interceptor';
import { CourseAddComponent } from './course-add/course-add.component';
import { CourseEditComponent } from './course-edit/course-edit.component';
import { MaterialEditComponent } from './material-edit/material-edit.component';
import { MaterialAddComponent } from './material-add/material-add.component';
import { StudLoginComponent } from './stud-login/stud-login.component';
import { EnquiryComponent } from './enquiry/enquiry.component';
import { EnquiryAddComponent } from './enquiry-add/enquiry-add.component';
import { EnquiryEditComponent } from './enquiry-edit/enquiry-edit.component';
import { EnquiryDeleteComponent } from './enquiry-delete/enquiry-delete.component';
import { FeedbackComponent } from './feedback/feedback.component';
import { CourseListComponent } from './course-list/course-list.component';
import { EnrollmentAddComponent } from './enrollment-add/enrollment-add.component';
import { EnrollmentComponent } from './enrollment/enrollment.component';
import { EnrollmentEditComponent } from './enrollment-edit/enrollment-edit.component';
import { FeedbackViewComponent } from './feedback-view/feedback-view.component';
import { FeedbackAddComponent } from './feedback-add/feedback-add.component';
import { EnrollmentViewComponent } from './enrollment-view/enrollment-view.component';
import { MaterialMyViewComponent } from './material-my-view/material-my-view.component';


@NgModule({
  declarations: [
    AppComponent,HomeComponent,LoginComponent,PagenotfoundComponent
    ,StudentlistComponent,MaterialAddComponent,MaterialComponent,MaterialEditComponent
    ,EducatorDashboardComponent,StudentDashBoardComponent,StudLoginComponent,
    CourseComponent,CourseListComponent,CourseAddComponent,CourseEditComponent,EnquiryComponent,
    EnquiryAddComponent,EnquiryEditComponent,EnquiryDeleteComponent,EnrollmentComponent,
    EnrollmentAddComponent,EnrollmentEditComponent,FeedbackComponent,FeedbackViewComponent
   ,RegistrationComponent, FeedbackAddComponent, EnrollmentViewComponent, MaterialMyViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,HttpClientModule,FormsModule,ReactiveFormsModule
  ],
  providers: [
    { provide:HTTP_INTERCEPTORS,
     useClass:MyInterceptor,
     multi:true 
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

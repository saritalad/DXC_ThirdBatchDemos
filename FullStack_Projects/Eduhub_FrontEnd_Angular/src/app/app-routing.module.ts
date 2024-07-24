import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
import { MaterialComponent } from './material/material.component';
import { EducatorDashboardComponent } from './educator-dashboard/educator-dashboard.component';
import { StudentDashBoardComponent } from './student-dash-board/student-dash-board.component';
import { CourseComponent } from './course/course.component';
import { CourseAddComponent } from './course-add/course-add.component';
import { CourseEditComponent } from './course-edit/course-edit.component';
import { MaterialAddComponent } from './material-add/material-add.component';
import { MaterialEditComponent } from './material-edit/material-edit.component';
import { EnquiryComponent } from './enquiry/enquiry.component';
import { StudLoginComponent } from './stud-login/stud-login.component';
import { EnquiryAddComponent } from './enquiry-add/enquiry-add.component';
import { FeedbackComponent } from './feedback/feedback.component';
import { EnquiryEditComponent } from './enquiry-edit/enquiry-edit.component';
import { CourseListComponent } from './course-list/course-list.component';
import { StudentlistComponent } from './studentlist/studentlist.component';
import { EnrollmentAddComponent } from './enrollment-add/enrollment-add.component';
import { EnrollmentComponent } from './enrollment/enrollment.component';
import { EnrollmentEditComponent } from './enrollment-edit/enrollment-edit.component';
import { FeedbackViewComponent } from './feedback-view/feedback-view.component';
import { FeedbackAddComponent } from './feedback-add/feedback-add.component';
import { authenticationGuard } from './authentication.guard';
import { EnrollmentViewComponent } from './enrollment-view/enrollment-view.component';
import { MaterialMyViewComponent } from './material-my-view/material-my-view.component';

const routes: Routes = [
  {path:"",redirectTo:"home",pathMatch:'full'},
   {path:"home", component:HomeComponent},
  {path:"Educator/Login", component:LoginComponent},
  {path:"register",component:RegistrationComponent},
  {path:"Student/StudentLogin", component:StudLoginComponent},
  {path:"Edashboard",component:EducatorDashboardComponent, 
  children:[
   
 {path:'course',component:CourseComponent,canActivate:[authenticationGuard]},
  {path:'addcourse',component:CourseAddComponent},
 {path:'editcourse/:id',component:CourseEditComponent},
 {path:'material/:id',component:MaterialComponent},
 {path:'addmaterial',component:MaterialAddComponent},
 {path:'editmaterial/:id',component:MaterialEditComponent},
 {path:'allstudents',component:StudentlistComponent},
 {path:'enquirylist',component:EnquiryComponent},
 {path:'editenquiry/:id',component:EnquiryEditComponent},
 {path:'enrollist',component:EnrollmentComponent},
 {path:'editstatus/:id',component:EnrollmentEditComponent},
 {path:'feedbacklist',component:FeedbackComponent}
  ]},
 {path:"Sdashboard",component:StudentDashBoardComponent,children:[
  {path:'course',component:CourseListComponent},
{path:'addenquiry',component:EnquiryAddComponent},
{path:'viewmaterial/:id',component:MaterialMyViewComponent},
{path:'viewmycourses',component:CourseListComponent},
{path:'enroll',component:EnrollmentAddComponent},
{path:'myenrolelist',component:EnrollmentViewComponent},
{path:'addfeedback',component:FeedbackAddComponent},
{path:'viewfeedback',component:FeedbackViewComponent}

 ]},
  {path:"regist", component:RegistrationComponent},
  {path:"**", component:PagenotfoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

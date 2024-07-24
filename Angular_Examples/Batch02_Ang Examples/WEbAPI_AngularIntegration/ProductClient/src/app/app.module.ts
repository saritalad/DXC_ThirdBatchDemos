import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProdlistComponent } from './prodlist/prodlist.component';
import { ProdAddComponent } from './prod-add/prod-add.component';
import { ProdEditComponent } from './prod-edit/prod-edit.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { CatComponent } from './cat/cat.component';
import { CatEditComponent } from './cat-edit/cat-edit.component';
import { CatAddComponent } from './cat-add/cat-add.component';
import { EmpListComponent } from './emp-list/emp-list.component';

@NgModule({
  declarations: [
    AppComponent,
    ProdlistComponent,
    ProdAddComponent,
    ProdEditComponent,
    CatComponent,
    CatEditComponent,
    CatAddComponent,
    EmpListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,HttpClientModule,FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

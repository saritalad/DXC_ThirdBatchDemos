import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { ProductComponent } from './product/product.component';
import { OnewaybindingComponent } from './onewaybinding/onewaybinding.component';
import { TwowaybindingComponent } from './twowaybinding/twowaybinding.component';
import { StructaldirectiveComponent } from './structaldirective/structaldirective.component';
import { AttibdirectiveComponent } from './attibdirective/attibdirective.component';
import { PipesComponent } from './pipes/pipes.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
import { FormsModule } from '@angular/forms';
import { DemoPipe } from './demo.pipe';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ProductComponent,
    OnewaybindingComponent,
    TwowaybindingComponent,
    StructaldirectiveComponent,
    AttibdirectiveComponent,
    PipesComponent,
    PagenotfoundComponent,
    DemoPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

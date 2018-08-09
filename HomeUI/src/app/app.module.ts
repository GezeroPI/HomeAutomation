import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { TopbarComponent } from './topbar/topbar.component';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { LivingroomComponent } from './livingroom/livingroom.component';
import { BedroomComponent } from './bedroom/bedroom.component';
import { BackbalconyComponent } from './backbalcony/backbalcony.component';
import {NgxChartsModule } from '@swimlane/ngx-charts';
@NgModule({
  declarations: [
    AppComponent,
    TopbarComponent,
    FooterComponent,
    HeaderComponent,
    LivingroomComponent,
    BedroomComponent,
    BackbalconyComponent
  ],
  imports: [
    BrowserModule,
    NgxChartsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

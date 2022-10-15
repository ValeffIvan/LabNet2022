import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ShippersComponent } from './datosapi/shippers/shippers.component';
import { DatosapiModule } from './datosapi/datosapi.module';

@NgModule({
  declarations: [
    AppComponent,
    ShippersComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    DatosapiModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

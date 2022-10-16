import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {ReactiveFormsModule} from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
 
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DatosapiModule } from './datosapi/datosapi.module';
import { ExtraboxComponent } from './modulosextras/extrabox/extrabox.component';
import { NavVarComponent } from './modulosextras/nav-var/nav-var.component';


@NgModule({
  declarations: [
    AppComponent,
    NavVarComponent,
    ExtraboxComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    DatosapiModule,
    ReactiveFormsModule,

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

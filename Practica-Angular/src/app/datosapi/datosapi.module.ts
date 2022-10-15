import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { ShippinglistComponent } from './shippinglist/shippinglist.component';
import { ShipperscomandComponent } from './shipperscomand/shipperscomand.component';
import {MatTabsModule} from '@angular/material/tabs'; 


@NgModule({
  declarations: [
    ShippinglistComponent,
    ShipperscomandComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    HttpClientModule,
    MatTabsModule
  ]
})
export class DatosapiModule { }

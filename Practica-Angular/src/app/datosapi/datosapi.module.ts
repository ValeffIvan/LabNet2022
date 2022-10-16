import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import {MatSelectModule} from '@angular/material/select';

import { ShipperslistComponent } from './shipperslist/shipperslist.component';
import { ShipperscomandComponent } from './shipperscomand/shipperscomand.component';
import {MatTabsModule} from '@angular/material/tabs'; 
import {MatCardModule} from '@angular/material/card';
import { AgregarComponent } from './agregar/agregar.component';
import { ModificarComponent } from './modificar/modificar.component';
import { EliminarComponent } from './eliminar/eliminar.component'; 


@NgModule({
  declarations: [
    ShipperslistComponent,
    ShipperscomandComponent,
    AgregarComponent,
    ModificarComponent,
    EliminarComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    HttpClientModule,
    MatTabsModule,
    MatCardModule,
    MatSelectModule
  ]
})
export class DatosapiModule { }

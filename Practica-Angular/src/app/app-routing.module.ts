import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ShipperscomandComponent } from './datosapi/shipperscomand/shipperscomand.component';
import { ShipperslistComponent } from './datosapi/shipperslist/shipperslist.component';

const routes: Routes = [
  {
    path: 'shipperslist',
    component: ShipperslistComponent
  },
  {
    path: 'shipperscomand',
    component: ShipperscomandComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

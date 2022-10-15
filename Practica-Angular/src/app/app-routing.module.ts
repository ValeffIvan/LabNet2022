import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ShipperscomandComponent } from './datosapi/shipperscomand/shipperscomand.component';
import { ShippinglistComponent } from './datosapi/shippinglist/shippinglist.component';

const routes: Routes = [
  {
    path: 'shipperslist',
    component: ShippinglistComponent
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

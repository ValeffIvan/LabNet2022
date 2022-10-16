import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Shipper } from '../models/Shipper';
import { ShippersService } from '../services/shippers.service';

@Component({
  selector: 'app-shippinglist',
  templateUrl: './shippinglist.component.html',
  styleUrls: ['./shippinglist.component.scss']
})
export class ShippinglistComponent implements OnInit {
  public shipperslist: Array<Shipper> =[];
  constructor(private formBuilder:FormBuilder, private shippersService : ShippersService) { }

  
  ngOnInit(): void
  {
    this.obtenerShippers();

  }
  obtenerShippers()
  {
    this.shippersService.obtenerShippers().subscribe (res => {
      this.shipperslist= res;
    })
  }

  guardarShipper()
  {
    var shipper = new Shipper()
  }


}

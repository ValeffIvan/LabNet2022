import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Shipper } from '../models/Shipper';
import { ShippersService } from '../services/shippers.service';

@Component({
  selector: 'app-shipperscomand',
  templateUrl: './shipperscomand.component.html',
  styleUrls: ['./shipperscomand.component.scss']
})
export class ShipperscomandComponent implements OnInit {
  public shipperslist: Array<Shipper> =[];
  constructor(private formBuilder:FormBuilder, private shippersService : ShippersService) {        
  }

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

  cancelarFormulario()
  {

  }
}


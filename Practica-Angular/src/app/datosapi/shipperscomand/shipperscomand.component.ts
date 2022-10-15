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

  constructor(private formBuilder:FormBuilder, private shippersService : ShippersService) {    
    shipperslist: this.shippersService.obtenerShippers()
  }

  ngOnInit(): void {
  }

  guardarShipper()
  {
    var shipper = new Shipper()
  }

  cancelarFormulario()
  {

  }
}


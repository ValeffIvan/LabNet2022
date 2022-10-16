import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Shipper } from '../models/Shipper';
import { ShippersService } from '../services/shippers.service';

@Component({
  selector: 'app-shipperslist',
  templateUrl: './shipperslist.component.html',
  styleUrls: ['./shipperslist.component.scss']
})
export class ShipperslistComponent implements OnInit {
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


}

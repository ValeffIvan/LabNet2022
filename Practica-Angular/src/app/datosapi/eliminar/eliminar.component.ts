import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { Shipper } from '../models/Shipper';
import { ShippersService } from '../services/shippers.service';

@Component({
  selector: 'app-eliminar',
  templateUrl: './eliminar.component.html',
  styleUrls: ['./eliminar.component.scss']
})
export class EliminarComponent implements OnInit {
  public shipperslist: Array<Shipper> =[];
  public form = new FormGroup(
    {
      companyName: new FormControl(''),
      phone:new FormControl('')      
    }
  );
  constructor(private formBuilder:FormBuilder, private shippersService : ShippersService) {}

  ngOnInit(): void {
    this.obtenerShippers()
    this.form = this.formBuilder.group({
      companyName:[''],
      phone:[''],
    });
  }
  obtenerShippers()
  {
    this.shippersService.obtenerShippers().subscribe (res => {
      this.shipperslist= res;
      
    })
  }
}

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { Shipper } from '../models/Shipper';
import { ShippersService } from '../services/shippers.service';

@Component({
  selector: 'app-agregar',
  templateUrl: './agregar.component.html',
  styleUrls: ['./agregar.component.scss']
})
export class AgregarComponent implements OnInit {
  public shipperslist: Array<Shipper> =[];
  constructor(private formBuilder:FormBuilder,private shippersService : ShippersService) {}
  public form = new FormGroup(
    {
      companyName: new FormControl(''),
      phone:new FormControl('')      
    }
  );
  ngOnInit(): void {
    this.form = this.formBuilder.group({
      companyName:[''],
      phone:[''],
    });
  }

}

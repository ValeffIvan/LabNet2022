import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { Shipper } from '../models/Shipper';
import { ShippersService } from '../services/shippers.service';

@Component({
  selector: 'app-modificar',
  templateUrl: './modificar.component.html',
  styleUrls: ['./modificar.component.scss']
})
export class ModificarComponent implements OnInit {
  public shipperslist: Array<Shipper> =[];
  public shipperunico: Shipper;
  public phoneid = document.getElementById('phone');
  public companyNameid = document.getElementById('companyName')
  public form = new FormGroup(
    {
      companyName: new FormControl(''),
      phone:new FormControl('')      
    }
  );
  constructor(private formBuilder:FormBuilder, private shippersService : ShippersService) { 
    this.shipperunico = new Shipper;
    
  }

  
  ngOnInit(): void
  {
    this.form = this.formBuilder.group({
      companyName:[''],
      phone:[''],
    });
    this.obtenerShippers();

  }

  obtenerShippers()
  {
    this.shippersService.obtenerShippers().subscribe (res => {
      this.shipperslist= res;
    })
  }

  obtenerShippersConId(id: number)
  {
    this.shippersService.obtenerShippersConId(id).subscribe (res => {
      this.shipperunico= res;
    })
    if (this.phoneid?.textContent != undefined) {
      this.phoneid.textContent= this.shipperunico.Phone;
    }
    if (this.companyNameid?.textContent != undefined) {
      this.companyNameid.textContent= this.shipperunico.CompanyName;
    }
  }
  
}

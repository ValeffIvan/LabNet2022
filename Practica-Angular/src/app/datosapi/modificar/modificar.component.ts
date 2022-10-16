import { Component, OnInit } from '@angular/core';
import { AsyncValidator, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Shipper } from '../models/Shipper';
import { ShippersService } from '../services/shippers.service';

@Component({
  selector: 'app-modificar',
  templateUrl: './modificar.component.html',
  styleUrls: ['./modificar.component.scss']
})
export class ModificarComponent implements OnInit {
  phonevalidator:string ='(([+][(]?[0-9]{1,3}[)]?)|([(]?[0-9]{4}[)]?))\s*[)]?[-\s\.]?[(]?[0-9]{1,3}[)]?([-\s\.]?[0-9]{3})([-\s\.]?[0-9]{3,4})';
  shipperIDvalidator:string =('^[0-9]+$');
  companyName = new FormControl ('',[Validators.required, Validators.minLength(1), Validators.nullValidator]);
  phone= new FormControl('',[Validators.required, Validators.minLength(1), Validators.nullValidator,Validators.pattern(this.phonevalidator)]);
  get f(){return this.form.controls;}
  public shipperslist: Array<Shipper> =[];
  private maximo:number = this.shipperslist.length;
  public shipperunico = new Shipper;
  public phoneid = document.getElementById('phone');
  public companyNameid = document.getElementById('companyName')
  public form = new FormGroup(
    {
      ShipperID :new FormControl(''),
      companyName: new FormControl(''),
      phone:new FormControl('')      
    }
  );

  constructor(private formBuilder:FormBuilder, private shippersService : ShippersService) { 
    
  }
  
  ShipperID = new FormControl ('',[Validators.required, Validators.nullValidator,Validators.maxLength(this.maximo), Validators.pattern(this.shipperIDvalidator)]);
  ngOnInit(): void
  {
    this.form = this.formBuilder.group({
      ShipperID : [''],
      companyName:['',[Validators.required, Validators.minLength(1), Validators.nullValidator]],
      phone:['',[Validators.required, Validators.minLength(1), Validators.nullValidator, Validators.maxLength(this.maximo)]],
    });
    this.obtenerShippers();

  }

  obtenerShippers()
  {
    this.shippersService.obtenerShippers().subscribe (res => {
      this.shipperslist= res;
    })
  }

  obtenerShippersConId()
  {
    var num= this.form.get('ShipperID')!.value;
    this.shippersService.obtenerShippersConId(num).subscribe (res => {
      this.shipperunico= res;
    })
    if (this.phoneid?.textContent != undefined) {
      this.phoneid!.textContent= this.shipperunico.Phone;
    }
    if (this.companyNameid?.textContent != undefined) {
      this.companyNameid!.textContent= this.shipperunico.CompanyName;
    }
  }
  
  updateShipper ()
  {
    var shipper=new Shipper();
    shipper.ShipperID=this.form.get('ShipperID')!.value;
    shipper.CompanyName= this.form.get('companyName')!.value;
    shipper.Phone= this.form.get('phone')!.value;
    this.shippersService.eliminarShipper(shipper.ShipperID).subscribe();
    this.shippersService.crearShipper(shipper).subscribe();
    
  }

}

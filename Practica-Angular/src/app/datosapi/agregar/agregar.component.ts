import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Shipper } from '../models/Shipper';
import { ShippersService } from '../services/shippers.service';

@Component({
  selector: 'app-agregar',
  templateUrl: './agregar.component.html',
  styleUrls: ['./agregar.component.scss']
})
export class AgregarComponent implements OnInit {
  private phonevalidator:string ='(([+][(]?[0-9]{1,3}[)]?)|([(]?[0-9]{4}[)]?))\s*[)]?[-\s\.]?[(]?[0-9]{1,3}[)]?([-\s\.]?[0-9]{3})([-\s\.]?[0-9]{3,4})';
  public shipperslist: Array<Shipper> =[];
  companyName= new FormControl('',[Validators.required, Validators.minLength(1), Validators.nullValidator])
  phone= new FormControl('',[Validators.required, Validators.minLength(1), Validators.nullValidator,Validators.pattern(this.phonevalidator)]);  

  form = new FormGroup(
    {
      companyName: new FormControl(''),
      phone:new FormControl('')      
    }
  );
get f(){return this.form.controls;}

constructor(private formBuilder:FormBuilder,private shippersService : ShippersService) {}


  ngOnInit(): void {
  }

  cargarShipper()
  {
  let shipper=new Shipper();
  shipper.CompanyName= this.form.get('companyName')!.value;
  shipper.Phone= this.form.get('phone')!.value;
  this.shippersService.crearShipper(shipper).subscribe()
  this.form.reset()
};
}

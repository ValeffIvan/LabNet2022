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
  public shipperslist: Array<Shipper> =[];
  
  form = new FormGroup(
    {
      companyName: new FormControl(''),
      phone:new FormControl('')      
    }
  );
get f(){return this.form.controls;}
private phonevalidator:string ='(([+][(]?[0-9]{1,3}[)]?)|([(]?[0-9]{4}[)]?))\s*[)]?[-\s\.]?[(]?[0-9]{1,3}[)]?([-\s\.]?[0-9]{3})([-\s\.]?[0-9]{3,4})';
constructor(private formBuilder:FormBuilder,private shippersService : ShippersService) {}


  ngOnInit(): void {
    this.form = this.formBuilder.group({
      companyName:['algo',[Validators.required, Validators.minLength(1), Validators.maxLength(5)]],
      phone:['123',[Validators.required, Validators.minLength(10), Validators.pattern(this.phonevalidator)]],
    });
  }

  cargarShipper()
  {
  let shipper=new Shipper();
  shipper.CompanyName= this.form.get('companyName')!.value;
  shipper.Phone= this.form.get('phone')!.value;
  this.shippersService.crearShipper(shipper).subscribe(res =>
    this.form.reset()
    
    )};

    validationcompanyName() : boolean
    {
      return (!this.form.get('companyName')?.valid);
    }

    validationPhone () : boolean
    {
      return (!this.form.get('phone')?.valid);
    }
}

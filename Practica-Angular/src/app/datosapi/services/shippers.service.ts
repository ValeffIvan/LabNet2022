import {HttpClient} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Shipper } from '../models/Shipper';

@Injectable({
  providedIn: 'root'
})
export class ShippersService {

  endpoint: string = '/Shippers';

  constructor(private http:HttpClient) { }

  public crearShipper (shipperRequest:Shipper): Observable<any>{
    let url =environment.apiShippers + this.endpoint;
    return this.http.post(url,shipperRequest);
  }

  public obtenerShippers (): Observable<Shipper[]>{
    let url =environment.apiShippers + this.endpoint;
    return this.http.get<Array<Shipper>>(url);
  }

}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PricesCalculatorApiRequest } from '../models/prices-calculator-api-request.model';

@Injectable({
  providedIn: 'root'
})
export class VehiclePriceCalculatorService {

  constructor(private http: HttpClient) { }

  sendPricesToApi(request: PricesCalculatorApiRequest): Observable<PricesCalculatorApiRequest>{
    return this.http.post<PricesCalculatorApiRequest>('http://localhost:5169/api/VehiclePriceCalculator', request);
  }
}

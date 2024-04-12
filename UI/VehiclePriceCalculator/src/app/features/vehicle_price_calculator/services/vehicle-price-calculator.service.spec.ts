import { TestBed } from '@angular/core/testing';

import { VehiclePriceCalculatorService } from './vehicle-price-calculator.service';

describe('VehiclePriceCalculatorService', () => {
  let service: VehiclePriceCalculatorService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(VehiclePriceCalculatorService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

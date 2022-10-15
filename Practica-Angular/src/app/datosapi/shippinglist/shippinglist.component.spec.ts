import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShippinglistComponent } from './shippinglist.component';

describe('ShippinglistComponent', () => {
  let component: ShippinglistComponent;
  let fixture: ComponentFixture<ShippinglistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShippinglistComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShippinglistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

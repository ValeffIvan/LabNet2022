import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShipperscomandComponent } from './shipperscomand.component';

describe('ShipperscomandComponent', () => {
  let component: ShipperscomandComponent;
  let fixture: ComponentFixture<ShipperscomandComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShipperscomandComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShipperscomandComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

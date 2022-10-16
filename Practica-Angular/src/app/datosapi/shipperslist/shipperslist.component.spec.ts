import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShipperslistComponent } from './shipperslist.component';

describe('ShipperslistComponent', () => {
  let component: ShipperslistComponent;
  let fixture: ComponentFixture<ShipperslistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShipperslistComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShipperslistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExtraboxComponent } from './extrabox.component';

describe('ExtraboxComponent', () => {
  let component: ExtraboxComponent;
  let fixture: ComponentFixture<ExtraboxComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExtraboxComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ExtraboxComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

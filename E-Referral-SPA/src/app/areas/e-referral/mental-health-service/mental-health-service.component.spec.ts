import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MentalHealthServiceComponent } from './mental-health-service.component';

describe('MentalHealthServiceComponent', () => {
  let component: MentalHealthServiceComponent;
  let fixture: ComponentFixture<MentalHealthServiceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MentalHealthServiceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MentalHealthServiceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

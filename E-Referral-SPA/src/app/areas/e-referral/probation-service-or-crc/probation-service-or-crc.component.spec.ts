import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProbationServiceOrCrcComponent } from './probation-service-or-crc.component';

describe('ProbationServiceOrCrcComponent', () => {
  let component: ProbationServiceOrCrcComponent;
  let fixture: ComponentFixture<ProbationServiceOrCrcComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProbationServiceOrCrcComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProbationServiceOrCrcComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

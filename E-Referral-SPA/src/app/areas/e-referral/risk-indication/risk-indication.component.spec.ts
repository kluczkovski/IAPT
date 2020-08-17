import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RiskIndicationComponent } from './risk-indication.component';

describe('RiskIndicationComponent', () => {
  let component: RiskIndicationComponent;
  let fixture: ComponentFixture<RiskIndicationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RiskIndicationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RiskIndicationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

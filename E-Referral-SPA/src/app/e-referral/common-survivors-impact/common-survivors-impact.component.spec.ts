import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CommonSurvivorsImpactComponent } from './common-survivors-impact.component';

describe('CommonSurvivorsImpactComponent', () => {
  let component: CommonSurvivorsImpactComponent;
  let fixture: ComponentFixture<CommonSurvivorsImpactComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CommonSurvivorsImpactComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CommonSurvivorsImpactComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

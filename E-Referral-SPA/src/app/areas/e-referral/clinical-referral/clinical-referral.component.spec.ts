import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ClinicalReferralComponent } from './clinical-referral.component';

describe('ClinicalReferralComponent', () => {
  let component: ClinicalReferralComponent;
  let fixture: ComponentFixture<ClinicalReferralComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ClinicalReferralComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ClinicalReferralComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

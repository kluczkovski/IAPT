import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { IsvaReferralComponent } from './isva-referral.component';

describe('IsvaReferralComponent', () => {
  let component: IsvaReferralComponent;
  let fixture: ComponentFixture<IsvaReferralComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ IsvaReferralComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(IsvaReferralComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EReferralComponent } from './e-referral.component';

describe('EReferralComponent', () => {
  let component: EReferralComponent;
  let fixture: ComponentFixture<EReferralComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EReferralComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EReferralComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

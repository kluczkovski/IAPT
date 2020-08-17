import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LongTermPhysicalHealthComponent } from './long-term-physical-health.component';

describe('LongTermPhysicalHealthComponent', () => {
  let component: LongTermPhysicalHealthComponent;
  let fixture: ComponentFixture<LongTermPhysicalHealthComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LongTermPhysicalHealthComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LongTermPhysicalHealthComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

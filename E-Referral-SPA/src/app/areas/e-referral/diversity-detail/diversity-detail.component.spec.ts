import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DiversityDetailComponent } from './diversity-detail.component';

describe('DiversityDetailComponent', () => {
  let component: DiversityDetailComponent;
  let fixture: ComponentFixture<DiversityDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DiversityDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DiversityDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

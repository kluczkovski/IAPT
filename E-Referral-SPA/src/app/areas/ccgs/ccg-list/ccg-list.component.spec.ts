import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CcgListComponent } from './ccg-list.component';

describe('CcgListComponent', () => {
  let component: CcgListComponent;
  let fixture: ComponentFixture<CcgListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CcgListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CcgListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

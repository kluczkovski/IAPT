import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListOfOffencesComponent } from './list-of-offences.component';

describe('ListOfOffencesComponent', () => {
  let component: ListOfOffencesComponent;
  let fixture: ComponentFixture<ListOfOffencesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListOfOffencesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListOfOffencesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatTableModule } from '@angular/material/table';

import { GpPracticeListComponent } from './gp-practice-list.component';

describe('GpPracticeListComponent', () => {
  let component: GpPracticeListComponent;
  let fixture: ComponentFixture<GpPracticeListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GpPracticeListComponent ],
      imports: [
        NoopAnimationsModule,
        MatPaginatorModule,
        MatSortModule,
        MatTableModule,
      ]
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GpPracticeListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should compile', () => {
    expect(component).toBeTruthy();
  });
});

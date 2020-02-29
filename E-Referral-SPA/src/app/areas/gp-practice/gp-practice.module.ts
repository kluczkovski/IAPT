import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GpPracticeListComponent } from './gp-practice-list/gp-practice-list.component';
import { MaterialModule } from 'src/app/material.module';



@NgModule({
  declarations: [GpPracticeListComponent],
  imports: [
    CommonModule,
    MaterialModule
  ]
})
export class GpPracticeModule { }

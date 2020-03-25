import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReligiousGrupListComponent } from './religious-grup-list/religious-grup-list.component';
import { ReligionComponent } from './religion/religion.component';
import { MaterialModule } from 'src/app/material.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    ReligiousGrupListComponent,
    ReligionComponent],
  imports: [
    CommonModule,
    MaterialModule,
    ReactiveFormsModule
  ],
  exports: [
    FormsModule,
    ReactiveFormsModule,
  ],
  entryComponents: [
    ReligionComponent
  ]
})
export class ReligionModule { }

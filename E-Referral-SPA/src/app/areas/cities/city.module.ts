import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MaterialModule } from 'src/app/material.module';
import { CityListComponent } from './city-list/city-list.component';
import { CityComponent } from './city/city.component';


@NgModule({
  declarations: [
    CityListComponent,
    CityComponent
  ],
  imports: [
    CommonModule,
    MaterialModule,
    ReactiveFormsModule,
  ],
  exports: [
    FormsModule,
    ReactiveFormsModule
  ],
  entryComponents: [
    CityComponent
  ]
})
export class CityModule {}

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CityListComponent } from './city-list/city-list.component';
import { MaterialModule } from 'src/app/material.module';




@NgModule({
  declarations: [CityListComponent],
  imports: [
    CommonModule,
    MaterialModule
  ]
})
export class CityModule {}

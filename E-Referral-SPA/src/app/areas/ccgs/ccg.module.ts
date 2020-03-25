import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialModule} from '../../material.module'
import { CcgListComponent } from './ccg-list/ccg-list.component';



@NgModule({
  declarations: [
    CcgListComponent],
  imports: [
    CommonModule,
    MaterialModule
  ]
})
export class CcgModule { }

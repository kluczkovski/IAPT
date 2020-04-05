import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialModule} from '../../material.module'
import { CcgListComponent } from './ccg-list/ccg-list.component';
import { CcgComponent } from './ccg/ccg.component';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    CcgListComponent,
    CcgComponent
  ],
  imports: [
    CommonModule,
    MaterialModule,
    ReactiveFormsModule
  ],
  entryComponents: [
    CcgComponent
  ]
})
export class CcgModule { }

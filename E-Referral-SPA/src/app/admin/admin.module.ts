import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminRouterModule } from './admin.route';
import { AdminAppComponent } from './admin.app.component';
import { CcgComponent } from './ccgs/ccg/ccg.component';
import { CcgListComponent } from './ccgs/ccg-list/ccg-list.component';
import { MaterialModule } from '../material.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CityListComponent } from './cities/city-list/city-list.component';
import { CityComponent } from './cities/city/city.component';
import { DisabilityListComponent } from './disabilities/disability-list/disability-list.component';
import { DisabilityComponent } from './disabilities/disability/disability.component';
import { EthnicCategoryListComponent } from './ethnic-categories/ethnic-category-list/ethnic-category-list.component';
import { EthnicCategoryComponent } from './ethnic-categories/ethnic-category/ethnic-category.component';
import { GpPracticeListComponent } from './gp-practices/gp-practice-list/gp-practice-list.component';
import { GpPracticeComponent } from './gp-practices/gp-practice/gp-practice.component';
import { ReferralListComponent } from './referrals/referral-list/referral-list.component';
import { ReligiousGrupListComponent } from './religious-group/religious-grup-list/religious-grup-list.component';
import { ReligionComponent } from './religious-group/religion/religion.component';

import { NgxSpinnerModule } from 'ngx-spinner';
import { ConfirmDialogComponent } from '../shared/components/confirm-dialog/confirm-dialog.component';


@NgModule({
  declarations: [
    AdminAppComponent,
    CcgListComponent,
    CcgComponent,
    CityListComponent,
    CityComponent,
    ReligiousGrupListComponent,
    ReligionComponent,
    DisabilityListComponent,
    DisabilityComponent,
    EthnicCategoryListComponent,
    EthnicCategoryComponent,
    GpPracticeListComponent,
    GpPracticeComponent,
    ReferralListComponent
  ],
  imports: [
    CommonModule,
    AdminRouterModule,
    MaterialModule,
    ReactiveFormsModule,
    NgxSpinnerModule,
  ],
  exports: [
    FormsModule,
    ReactiveFormsModule
  ]
})
export class AdminModule { }

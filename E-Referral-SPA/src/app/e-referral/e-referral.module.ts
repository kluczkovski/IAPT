import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EReferralComponent } from './e-referral.component';
import { ContactDetailComponent } from './components/contact-detail/contact-detail.component';
import { DiversityDetailComponent } from './components/diversity-detail/diversity-detail.component';
import { MaterialModule } from 'src/app/material.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { TypeReferralComponent } from './components/type-referral/type-referral.component';
import { FormDebugComponent } from 'src/app/e-referral/components/_form-debug/form-debug.component';
import { ArmedForcesDetailComponent } from './components/armed-forces-detail/armed-forces-detail.component';
import { MatVerticalStepperScrollerDirective } from './utils/mat-vertical-stepper-scroller.directive';
import { LongTermPhysicalHealthComponent } from './components/long-term-physical-health/long-term-physical-health.component';
import { RiskIndicationComponent } from './components/risk-indication/risk-indication.component';
import { ClinicalReferralComponent } from './components/clinical-referral/clinical-referral.component';
import { MentalHealthServiceComponent } from './components/mental-health-service/mental-health-service.component';
import { IsvaReferralComponent } from './components/isva-referral/isva-referral.component';
import { ReferralInformationComponent } from './components/referral-information/referral-information.component';
import { CommonSurvivorsImpactComponent } from './components/common-survivors-impact/common-survivors-impact.component';
import { ProbationServiceOrCrcComponent } from './components/probation-service-or-crc/probation-service-or-crc.component';
import { ListOfOffencesComponent } from './components/list-of-offences/list-of-offences.component';
import { NumberDirective } from './utils/numbers-only.directive';

import { NgxSpinnerModule } from 'ngx-spinner';



@NgModule({
  declarations: [
    EReferralComponent,
    ContactDetailComponent,
    DiversityDetailComponent,
    TypeReferralComponent,
    FormDebugComponent,
    ArmedForcesDetailComponent,
    MatVerticalStepperScrollerDirective,
    LongTermPhysicalHealthComponent,
    RiskIndicationComponent,
    ClinicalReferralComponent,
    MentalHealthServiceComponent,
    IsvaReferralComponent,
    ReferralInformationComponent,
    CommonSurvivorsImpactComponent,
    ProbationServiceOrCrcComponent,
    ListOfOffencesComponent,
    NumberDirective
  ],
  imports: [
    CommonModule,
    MaterialModule,
    ReactiveFormsModule,
    NgxSpinnerModule
  ],
  exports: [
    FormsModule,
    ReactiveFormsModule
  ]
})
export class EReferralModule { }

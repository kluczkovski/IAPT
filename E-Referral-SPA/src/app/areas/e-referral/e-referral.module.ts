import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EReferralComponent } from './e-referral.component';
import { ContactDetailComponent } from './contact-detail/contact-detail.component';
import { DiversityDetailComponent } from './diversity-detail/diversity-detail.component';
import { MaterialModule } from 'src/app/material.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { TypeReferralComponent } from './type-referral/type-referral.component';
import { FormDebugComponent } from 'src/app/areas/e-referral/_form-debug/form-debug.component';
import { ArmedForcesDetailComponent } from './armed-forces-detail/armed-forces-detail.component';
import { MatVerticalStepperScrollerDirective } from './mat-vertical-stepper-scroller.directive';
import { LongTermPhysicalHealthComponent } from './long-term-physical-health/long-term-physical-health.component';
import { RiskIndicationComponent } from './risk-indication/risk-indication.component';
import { ClinicalReferralComponent } from './clinical-referral/clinical-referral.component';
import { MentalHealthServiceComponent } from './mental-health-service/mental-health-service.component';



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
    MentalHealthServiceComponent
  ],
  imports: [
    CommonModule,
    MaterialModule,
    ReactiveFormsModule
  ],
  exports: [
    FormsModule,
    ReactiveFormsModule
  ]
})
export class EReferralModule { }

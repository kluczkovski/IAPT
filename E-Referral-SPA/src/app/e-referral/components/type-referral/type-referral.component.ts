import { Component, OnInit, Input, AfterViewInit, OnChanges } from '@angular/core';
import { FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { ReferralTypeEnum } from '../../models/enums/referralTypeEnum';

@Component({
  selector: 'app-type-referral',
  templateUrl: './type-referral.component.html',
  styleUrls: ['./type-referral.component.scss']
})
export class TypeReferralComponent implements OnInit, OnChanges {

  private referralTypes = ReferralTypeEnum;
  public referralTypeOptions = [];
  @Input() form: FormGroup;


  constructor() { }

  ngOnInit(): void {
    // Get all the keys from ReferralTypeEnum
    this.referralTypeOptions = Object.keys(this.referralTypes);
   }

  ngOnChanges(): void {

    // Type of Referral
    this.form.get('typeReferral.type').valueChanges.subscribe( (val) => {
      // Prof
      if (val === 'Prof') {
        this.form.patchValue({
          typeReferral: {
            source: ''
          }
        });
        // Enable validator for Agency
        this.form.get('typeReferral.agencyInformation.agency').setValidators(Validators.required);
        this.form.get('typeReferral.agencyInformation.agency').updateValueAndValidity();
        this.form.get('typeReferral.agencyInformation.contactPerson').setValidators(Validators.required);
        this.form.get('typeReferral.agencyInformation.contactPerson').updateValueAndValidity();
        this.form.get('typeReferral.agencyInformation.agencyHasClientConsent').setValidators(Validators.required);
        this.form.get('typeReferral.agencyInformation.agencyHasClientConsent').updateValueAndValidity();
        // this.form.get('typeReferral.agencyInformation.agencyHasClientConsent').hasError();

        // Disable validator for Source
        this.form.get('typeReferral.source').setValidators(null);
        this.form.get('typeReferral.source').updateValueAndValidity();
      } else {
        // Self

        // Enable validor for Source
        this.form.get('typeReferral.source').setValidators(Validators.required);
        this.form.get('typeReferral.source').updateValueAndValidity();

        // Disable validator for Agency
        this.form.get('typeReferral.agencyInformation.agency').setValidators(null);
        this.form.get('typeReferral.agencyInformation.agency').updateValueAndValidity();
        this.form.get('typeReferral.agencyInformation.contactPerson').setValidators(null);
        this.form.get('typeReferral.agencyInformation.contactPerson').updateValueAndValidity();
        this.form.get('typeReferral.agencyInformation.agencyHasClientConsent').setValidators(null);
        this.form.get('typeReferral.agencyInformation.agencyHasClientConsent').updateValueAndValidity();


        this.form.patchValue({
          typeReferral: {
            agencyInformation: {
              agency: '',
              contactPerson: '',
              phone: '',
              email: '',
              agencyHasClientConsent: '',
            }
          }
        });
      }

      // reset the error
      this.form.get('typeReferral.source').markAsUntouched();
      this.form.get('typeReferral.source').updateValueAndValidity();
      this.form.get('typeReferral.agencyInformation').markAsUntouched();
      this.form.get('typeReferral.agencyInformation').updateValueAndValidity();
    });

  }

}

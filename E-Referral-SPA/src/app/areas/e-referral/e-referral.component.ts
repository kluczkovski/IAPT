import { Component, OnInit, ViewChild } from '@angular/core';
import { MatStepper } from '@angular/material/stepper';

import { NgxSpinnerService } from "ngx-spinner";

import { EReferralService } from './_services/e-referral.service';
import { NotificationService } from 'src/app/shared/notification.service';
import { Ereferral } from './_models/e-referral';
import { RiskIndicationComponent } from './risk-indication/risk-indication.component';


@Component({
  selector: 'app-e-referral',
  templateUrl: './e-referral.component.html',
  styleUrls: ['./e-referral.component.scss']
})
export class EReferralComponent implements OnInit {

  eReferral: Ereferral;


  @ViewChild(MatStepper)
  private stepper: MatStepper;

  localDate: Date;

  constructor(public ereferralService: EReferralService,
              private notification: NotificationService,
              private spinner: NgxSpinnerService) { }

  ngOnInit(): void {
    this.ereferralService.initializeForm();

    // Set suicideRisk and selfHarmRisk fields with zeros
    this.ereferralService.Form.get('riskIndicatorInformation.suicideRisk').setValue(0);
    this.ereferralService.Form.get('riskIndicatorInformation.selfHarmRisk').setValue(0);
  }

  onSubmit() {
    // this.eReferral = Object.assign({}, this.ereferralService.Form.value);
    this.LoadDataFromForm();
    console.log(this.eReferral);
    this.spinner.show();
    this.ereferralService.add(this.eReferral)
      .subscribe(
        () => {
          this.notification.success('The Referral was sent with with successed.');
          this.ereferralService.initializeForm();
        },
        error => this.notification.error('The Referral has errors, please check you data: ' + error)
        );
    this.spinner.hide();
  }

  private LoadDataFromForm() {

    // Update Date for YYY/MM/DD
    this.localDate = this.ereferralService.Form.get('contactDetail.birthDay').value;
    this.ereferralService.Form.get('contactDetail.birthDay').setValue(this.ConvertDateToYYYMMDD(this.localDate));

    this.eReferral = {
      type: this.ereferralService.Form.get('typeReferral.type').value,
      source: this.ereferralService.Form.get('typeReferral.source').value,
      agencyInformation: this.ereferralService.Form.get('typeReferral.agencyInformation').value,
      contactDetail: this.ereferralService.Form.get('contactDetail').value,
      diversityDetail: this.ereferralService.Form.get('diversityDetail').value,
      armedForceDetail: this.ereferralService.Form.get('armedForceDetail').value,
      longTermPhysicalHealth: this.ereferralService.Form.get('longTermPhysicalHealth').value,
      riskIndicator: this.ereferralService.Form.get('riskIndicatorInformation').value,
      clinicalReferral: this.ereferralService.Form.get('clinicalReferral').value,
      isvaReferral: this.ereferralService.Form.get('isvaReferral').value,
      referralInformation: this.ereferralService.Form.get('referralInformation').value,
      commonSurvivorImpact: this.ereferralService.Form.get('commonSurvivorImpactIndicators').value
    };
  }

  private ConvertDateToYYYMMDD(date: Date): string {
    let day: string = date.getDate().toString();
    day = +day < 10 ? '0' + day : day;
    let month: string = (date.getMonth() + 1).toString();
    month = +month < 10 ? '0' + month : month;
    let year = date.getFullYear();
    return `${year} - ${month} - ${day}`;
  }


}


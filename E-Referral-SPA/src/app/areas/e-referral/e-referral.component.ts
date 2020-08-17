import { Component, OnInit, ViewChild } from '@angular/core';
import { StepperSelectionEvent } from '@angular/cdk/stepper';
import { MatStepper } from '@angular/material/stepper';

import { EReferralService } from './_services/e-referral.service';
import { NotificationService } from 'src/app/shared/notification.service';

@Component({
  selector: 'app-e-referral',
  templateUrl: './e-referral.component.html',
  styleUrls: ['./e-referral.component.scss']
})
export class EReferralComponent implements OnInit {


  @ViewChild(MatStepper)
  private stepper: MatStepper;

  constructor(public ereferralService: EReferralService,
              private notification: NotificationService) { }

  ngOnInit(): void {
  }

  public selectionChange(event?: StepperSelectionEvent): void {
    console.log('passed on selection Changed...');
  }

}


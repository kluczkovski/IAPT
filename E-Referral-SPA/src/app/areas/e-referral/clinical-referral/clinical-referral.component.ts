import { Component, OnInit, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { MentalHealthService } from '../_models/mentalHealthService';

@Component({
  selector: 'app-clinical-referral',
  templateUrl: './clinical-referral.component.html',
  styleUrls: ['./clinical-referral.component.scss']
})
export class ClinicalReferralComponent implements OnInit {


  @Input() form: FormGroup;

  listOfMHS: MentalHealthService[] = [];
  constructor() { }

  ngOnInit(): void {
    this.listOfMHS.push(
      {
        service: 'Test Serve',
        treatmentProvided: 'SHN',
        startMonthYear: '07/2010',
        endMonthYear: '08/2010'
      },
      {
        service: 'Test Serve II',
        treatmentProvided: 'SHN II',
        startMonthYear: '01/2011',
        endMonthYear: '05/2012'
      },
      {
        service: 'Test Serve II',
        treatmentProvided: 'SHN II',
        startMonthYear: '01/2011',
        endMonthYear: '05/2012'
      },
      {
        service: 'Test Serve III',
        treatmentProvided: 'SHN III',
        startMonthYear: '07/2010',
        endMonthYear: '08/2010'
      });
  }

  logForm() {
  }
}

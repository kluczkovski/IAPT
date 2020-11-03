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

  constructor() { }

  ngOnInit(): void {
  }

}

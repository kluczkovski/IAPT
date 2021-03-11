import { Component, OnInit, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-referral-information',
  templateUrl: './referral-information.component.html',
  styleUrls: ['./referral-information.component.scss']
})
export class ReferralInformationComponent implements OnInit {

  @Input() form: FormGroup;

  constructor() { }

  ngOnInit(): void {
  }

}

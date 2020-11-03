import { Component, OnInit, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-isva-referral',
  templateUrl: './isva-referral.component.html',
  styleUrls: ['./isva-referral.component.scss']
})
export class IsvaReferralComponent implements OnInit {

  @Input() form: FormGroup;

  constructor() { }

  ngOnInit(): void {
  }

}

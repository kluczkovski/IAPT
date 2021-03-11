import { Component, OnInit, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-common-survivors-impact',
  templateUrl: './common-survivors-impact.component.html',
  styleUrls: ['./common-survivors-impact.component.scss']
})
export class CommonSurvivorsImpactComponent implements OnInit {

  @Input() form: FormGroup;
  constructor() { }

  ngOnInit(): void {
  }

}

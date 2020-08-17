import { Component, OnInit, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-risk-indication',
  templateUrl: './risk-indication.component.html',
  styleUrls: ['./risk-indication.component.scss']
})
export class RiskIndicationComponent implements OnInit {

  @Input() form: FormGroup;

  constructor() { }

  ngOnInit(): void {
  }

}

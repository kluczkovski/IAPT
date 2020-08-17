import { Component, OnInit, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-long-term-physical-health',
  templateUrl: './long-term-physical-health.component.html',
  styleUrls: ['./long-term-physical-health.component.scss']
})
export class LongTermPhysicalHealthComponent implements OnInit {

  @Input() form: FormGroup;

  constructor() { }

  ngOnInit(): void {
  }

}

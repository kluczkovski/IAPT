import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormArray, FormControl } from '@angular/forms';

@Component({
  selector: 'app-probation-service-or-crc',
  templateUrl: './probation-service-or-crc.component.html',
  styleUrls: ['./probation-service-or-crc.component.scss']
})
export class ProbationServiceOrCrcComponent implements OnInit {

  @Input() probationServiceCRCArray: FormArray;

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
    this.probationServiceCRCArray.clear();
    this.addRecord();
  }

  addRecord() {
    this.probationServiceCRCArray.push(this.getMHS());
  }

  onDelete(index: number) {
    this.probationServiceCRCArray.removeAt(index);
  }

  onDeleteAll() {
    this.probationServiceCRCArray.clear();
  }

  private getMHS() {
    return this.fb.group({
      name: new FormControl(''),
      service: new FormControl(''),
      telephone: new FormControl(''),
      consentToContact: new FormControl('')
    });
  }
}

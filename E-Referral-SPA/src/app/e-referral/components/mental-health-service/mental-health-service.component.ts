import { Component, OnInit, Input } from '@angular/core';
import { MentalHealthService } from '../../models/mentalHealthService';
import { FormGroup, FormControl, FormArray, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-mental-health-service',
  templateUrl: './mental-health-service.component.html',
  styleUrls: ['./mental-health-service.component.scss']
})
export class MentalHealthServiceComponent implements OnInit {

  @Input() mentalHealthServiceArray: FormArray;

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
    this.mentalHealthServiceArray.clear();
    this.addRecord();
  }

  addRecord() {
    this.mentalHealthServiceArray.push(this.getMHS());
  }

  onDelete(index: number) {
    this.mentalHealthServiceArray.removeAt(index);
  }

  onDeleteAll() {
    this.mentalHealthServiceArray.clear();
  }

  private getMHS() {
    return this.fb.group({
      service: new FormControl(''),
      typeOfTreatment: new FormControl(''),
      startTreament: new FormControl(''),
      endTreament: new FormControl('')
    });
  }
}


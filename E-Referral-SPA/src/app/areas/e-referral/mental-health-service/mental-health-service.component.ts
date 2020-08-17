import { Component, OnInit, Input } from '@angular/core';
import { MentalHealthService } from '../_models/mentalHealthService';
import { FormGroup, FormControl, FormArray, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-mental-health-service',
  templateUrl: './mental-health-service.component.html',
  styleUrls: ['./mental-health-service.component.scss']
})
export class MentalHealthServiceComponent implements OnInit {

  constructor(private fb: FormBuilder) { }

  mentalHealthServiceArray = new FormArray([]);
  skills =  new FormArray([]);

  ngOnInit(): void {
    this.addRecord();
  }

  // convenience getters for easy access to form fields
  // get mhss() {
  //   return this.mentalHealthServiceForm.get('mentalHealthService') as mhs;
  // }

  addRecord() {
    this.mentalHealthServiceArray.push(this.getMHS());
  }

  addSkill() {
    this.skills.push(new FormControl(''));
  }

  onDelete(index: number) {
    // this.skills.removeAt(index);
    this.mentalHealthServiceArray.removeAt(index);
  }

  onDeleteAll() {
    this.skills.clear();
    this.mentalHealthServiceArray.clear();
  }

  private getMHS() {
    return this.fb.group({
      service: new FormControl(''),
      treatmentProvided: new FormControl(''),
      startMonthYear: new FormControl(''),
      endMonthYear: new FormControl('')
    });
  }
}


import { Component, OnInit, Input } from '@angular/core';
import { FormArray, FormBuilder, FormControl } from '@angular/forms';

@Component({
  selector: 'app-list-of-offences',
  templateUrl: './list-of-offences.component.html',
  styleUrls: ['./list-of-offences.component.scss']
})
export class ListOfOffencesComponent implements OnInit {

  @Input() offencesArray: FormArray;

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
    this.offencesArray.clear();
    this.addRecord();
  }

  addRecord() {
    this.offencesArray.push(this.getMHS());
  }

  onDelete(index: number) {
    this.offencesArray.removeAt(index);
  }

  onDeleteAll() {
    this.offencesArray.clear();
  }

  private getMHS() {
    return this.fb.group({
      offence: new FormControl(''),
      conviction: new FormControl(''),
      lengthOfSentence: new FormControl(''),
      monthYearSentence: new FormControl('')
    });
  }

}

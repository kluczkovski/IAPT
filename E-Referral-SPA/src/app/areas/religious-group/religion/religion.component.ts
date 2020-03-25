import { Component, OnInit } from '@angular/core';
import { ReligionService } from '../religion.service';
import { NotificationService } from 'src/app/shared/notification.service';
import { MatDialogRef } from '@angular/material/dialog';
import { FormControl, FormGroup } from '@angular/forms';
import { Religion } from '../religion';


@Component({
  selector: 'app-religion',
  templateUrl: './religion.component.html',
  styleUrls: ['./religion.component.scss']
})
export class ReligionComponent implements OnInit {

  religion: Religion;

  constructor(public religionService: ReligionService,
              private notification: NotificationService,
              private dialogRef: MatDialogRef<ReligionComponent>) { }

  ngOnInit(): void {
  }

  onSubmit() {
    if (!this.religionService.Form.invalid) {

      if (!this.religionService.Form.get('id').value) {
        // Add
        this.religion = Object.assign({}, this.religionService.Form.value);
        this.religionService
          .addReligion(this.religion)
          .subscribe(
              () => {
                  this.notification.success('The Religon was added with successed.');
                  this.onClose();
              },
              error => this.notification.error('The Religon was not added, error: ' + error),
          );
      } else {
        // Update
        this.religion = Object.assign({}, this.religionService.Form.value);
        this.religionService
          .updateReligion(this.religion)
          .subscribe(
              () => {
                  this.notification.success('The Religon was updated with successed.');
                  this.onClose();
              },
              error => this.notification.error('The Religon was not updated, error: ' + error),
          );
      }
    }
  }

  onClose() {
    this.religionService.Form.reset();
    this.religionService.initializeForm();
    this.dialogRef.close();
  }
}

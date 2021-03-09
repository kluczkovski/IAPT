import { Component, OnInit } from '@angular/core';
import { DisabilityService } from '../disability.service';
import { NotificationService } from 'src/app/shared/notification.service';
import { MatDialogRef } from '@angular/material/dialog';
import { Disability } from '../disability';
import { FormControl, FormGroup } from '@angular/forms';


@Component({
  selector: 'app-disability',
  templateUrl: './disability.component.html',
  styleUrls: ['./disability.component.scss']
})
export class DisabilityComponent implements OnInit {

  disability: Disability;

  constructor(public disabilityService: DisabilityService,
              private notificationService: NotificationService,
              private dialogRef: MatDialogRef<DisabilityComponent>) { }

  ngOnInit(): void {
  }

  onSubmit() {
    if (this.disabilityService.Form.valid) {
      if (!this.disabilityService.Form.get('id').value) {
        // Add
        this.disability = Object.assign({}, this.disabilityService.Form.value);
        this.disabilityService
          .addDisability(this.disability)
          .subscribe(
            () => {
              this.notificationService.success('Disability Code was added with successed.'),
              this.dialogRef.close();
            },
            error => this.notificationService.error('Disability Code was not added, error: ' + error)
          );
      } else {
        // Updated
        this.disability = Object.assign({}, this.disabilityService.Form.value);
        this.disabilityService
          .updateDisability(this.disability)
          .subscribe(
            () => {
              this.notificationService.success('Disability Code was Updated with successed.');
              this.dialogRef.close();
            },
            error => this.notificationService.error('Disabilty Code was not updated, error: ' + error)
          );
      }
    }
  }

  onCancel() {
    this.disabilityService.Form.reset();
    this.disabilityService.initializeDisabilityForm();
    this.dialogRef.close();
  }
}

import { Component, OnInit } from '@angular/core';
import { CcgService } from '../ccg.service';
import { NotificationService } from 'src/app/shared/notification.service';
import { MatDialogRef } from '@angular/material/dialog';
import { CCG } from '../Ccg';

@Component({
  selector: 'app-ccg',
  templateUrl: './ccg.component.html',
  styleUrls: ['./ccg.component.scss']
})
export class CcgComponent implements OnInit {

  ccg: CCG;

  constructor(public ccgService: CcgService,
              private notification: NotificationService,
              private dialogRef: MatDialogRef<CcgComponent>) { }

  ngOnInit(): void {
  }

  onSubmit() {
    if (!this.ccgService.Form.invalid) {
      if (!this.ccgService.Form.get('id').value) {
        // Add
        this.ccg = Object.assign({}, this.ccgService.Form.value);
        this.ccgService
          .addCCG(this.ccg)
          .subscribe(
            () => {
              this.notification.success('The CCG was added with success');
              this.onCancel();
            },
            error => this.notification.error('The CCG was not added, error: ' + error)
          );
      } else {
        // Update
        this.ccg = Object.assign({}, this.ccgService.Form.value);
        this.ccgService
          .updateCCG(this.ccg)
          .subscribe(
            () => {
              this.notification.success('The CCG was updated with success');
              this.onCancel();
            },
            error => this.notification.error('The CCG was not updated, error: ' + error)
          );
      }
    }
  }

  onCancel() {
    this.ccgService.Form.reset();
    this.ccgService.initializeForm();
    this.dialogRef.close();
  }
}

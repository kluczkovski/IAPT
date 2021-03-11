import { Component, OnInit, Inject } from '@angular/core';
import { GpPracticeService } from '../../../services/gp-practice.service';
import { NotificationService } from 'src/app/shared/services/notification.service';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CCG } from '../../../models/CCG';
import { CcgService } from '../../../services/ccg.service';
import { GpPractice } from '../../../models/gpPractice';

@Component({
  selector: 'app-gp-practice',
  templateUrl: './gp-practice.component.html',
  styleUrls: ['./gp-practice.component.scss']
})
export class GpPracticeComponent implements OnInit {

  listCCG: CCG[];
  CCGid: string;
  gpPractice: GpPractice;

  constructor(@Inject(MAT_DIALOG_DATA) public data,
              public  gpPracticeService: GpPracticeService,
              private notification: NotificationService,
              private dialogRef: MatDialogRef<GpPracticeComponent>,
              private ccgService: CcgService) { }

  ngOnInit(): void {
    this.loadAllCCG();
  }

  onSubmit() {
    if (!this.gpPracticeService.Form.invalid) {
      // Update gpPractice obj with data from Form
      this.getDataFromForm();
      if (this.gpPractice.id === null) {
        // Insert
        this.gpPracticeService
          .addGpPractice(this.gpPractice)
          .subscribe(
            () => {
              this.notification.success('The GP Practise was added with success.');
              this.onCancel();
            },
            error => this.notification.error('The GP Practise was not added, error: ' + error)
          );
      } else {
        // Update
        this.gpPracticeService
          .updateGpPractice(this.gpPractice)
          .subscribe(
            () => {
              this.notification.success('The Gp Practice was update with success.');
              this.onCancel();
            },
            error => this.notification.error('The Gp Practice was not update, error: ' + error)
          );
      }
    }
  }

  onCancel() {
    this.gpPracticeService.Form.reset();
    this.gpPracticeService.initializeForm();
    this.dialogRef.close();
  }

  // Load all CCG
  loadAllCCG() {
    this.ccgService
      .getAllCCGs()
      .subscribe(
        (data: CCG[]) => this.listCCG = data,
        error => this.notification.error('Error to get All CCG, error:' + error)
      );
  }

  // Get information from Form
  getDataFromForm() {
    this.gpPractice = null;
    this.gpPractice = {
      id: this.gpPracticeService.Form.get('id').value,
      code: this.gpPracticeService.Form.get('code').value,
      description: this.gpPracticeService.Form.get('description').value,
      addressLine1: this.gpPracticeService.Form.get('addressLine1').value,
      addressLine2: this.gpPracticeService.Form.get('addressLine2').value,
      addressLine3: this.gpPracticeService.Form.get('addressLine3').value,
      addressLine4: this.gpPracticeService.Form.get('addressLine4').value,
      postCode: this.gpPracticeService.Form.get('postCode').value,
      ccgCode: this.listCCG.find(x => x.id === this.gpPracticeService.Form.get('ccgCodeId').value)
    };
  }
}

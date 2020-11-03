import { Component, OnInit, Inject } from '@angular/core';
import { EthnicCategoryService } from '../ethnic-category.service';
import { NotificationService } from 'src/app/shared/notification.service';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { EthnicCategory } from '../ethnicCategory';

@Component({
  selector: 'app-ethnic-category',
  templateUrl: './ethnic-category.component.html',
  styleUrls: ['./ethnic-category.component.scss']
})
export class EthnicCategoryComponent implements OnInit {

  ethnic: EthnicCategory;

  constructor(@Inject(MAT_DIALOG_DATA) public data,
              public ethnicService: EthnicCategoryService,
              private notification: NotificationService,
              private dialogRef: MatDialogRef<EthnicCategoryComponent>) { }

  ngOnInit(): void {
  }

  onSubmit() {
    if (!this.ethnicService.Form.invalid) {
      this.ethnic = Object.assign({}, this.ethnicService.Form.value);
      if (this.ethnic.id == null) {
        // Add
        this.ethnicService
          .insertEthnicCategory(this.ethnic)
          .subscribe(
            () => {
            this.notification.success('The Ethnic was added');
            this.onCancel();
            },
            error => this.notification.error('The Ethnic was not added, error: ' + error)
          );
      } else {
        // Update
        this.ethnicService
          .updateEthnicCategory(this.ethnic)
          .subscribe(
            () => {
            this.notification.success('The Ethnic was added');
            this.onCancel();
            },
            error => this.notification.error('The Ethnic was not added, error: ' + error)
          );
      }
    }
  }

  onCancel() {
    this.ethnicService.Form.reset();
    this.ethnicService.initializeForm();
    this.dialogRef.close();
  }
}

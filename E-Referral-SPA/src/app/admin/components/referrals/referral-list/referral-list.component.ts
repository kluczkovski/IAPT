import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialogConfig } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { DialogService } from 'src/app/shared/services/dialog.service';
import { NotificationService } from 'src/app/shared/services/notification.service';
import { Referral } from '../../../models/referral';
import { ReferralService } from '../../../services/referral.service';

import { NgxSpinnerService } from "ngx-spinner";
import { saveAs } from 'file-saver';

@Component({
  selector: 'app-referral-list',
  templateUrl: './referral-list.component.html',
  styleUrls: ['./referral-list.component.scss']
})
export class ReferralListComponent implements OnInit {

  @ViewChild(MatSort, {static: true}) sort: MatSort;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  displayedColumns: string[] = ['receivedDate', 'status', 'firstName', 'lastName' , 'birthDay',
                                'type', 'gpPracticeName', 'ccgCommissioner', 'actions'];
  dataSource =  new MatTableDataSource<Referral>();
  dialogConfig = new MatDialogConfig();

  constructor(private referralService: ReferralService,
              private notification: NotificationService,
              private dialogService: DialogService,
              private spinner: NgxSpinnerService) { }

  ngOnInit(): void {
    // Loading Referrals
    this.loadingReferrals();
  }

  // Filter/Search
  applyFilter(filter: string) {
    this.dataSource.filter = filter.trim().toLocaleLowerCase();
  }

  // Load Referral
  loadingReferrals() {
    this.spinner.show();
    this.referralService.getAllReferral()
      .subscribe(
          (data: Referral[]) => {
            this.dataSource.data = data
            this.spinner.hide();
          },
        error => this.notification.error('Error to access Referral, error: ' + error)
      );
    // Add Sort and Paginator to data
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
    
  }

  onDetail(data: Referral) {

  }

  onPDF(data: Referral) {
    this.spinner.show();
    this.referralService
      .pdfReferral(data.id)
      .subscribe( 
        (data)=> {
          this.spinner.hide();
          console.log(data)
          var blob = new Blob([data], { type: 'application/pdf' });
          saveAs(blob, 'referral.pdf')
        },
      );
      
  }


  onDelete(data: Referral) {
    // console.log(data);
    this.dialogService
        .openConfirmDialog(data.firstName + ' ' + data.lastName)
        .afterClosed().subscribe(
            result => {
              if (result) {
                this.spinner.show();
                this.referralService
                  .deleteReferral(data.id)
                  .subscribe(
                    () => {
                      this.spinner.hide();
                      this.notification.success('The Referral was deleted.');
                      this.loadingReferrals();
                    },
                    error => {
                      this.spinner.hide();
                      this.notification.error('The Referral was not deleted, error: ' + error);
                    }
                  );
                this.spinner.hide();
              }
            }
        );
  }


}

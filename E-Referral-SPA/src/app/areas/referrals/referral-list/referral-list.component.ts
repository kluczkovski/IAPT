import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { DialogService } from 'src/app/shared/dialog.service';
import { NotificationService } from 'src/app/shared/notification.service';
import { Referral } from '../referral';
import { ReferralService } from '../referral.service';

import { NgxSpinnerService } from "ngx-spinner";

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
    this.spinner.show();
    this.loadingReferrals();
    this.spinner.hide();
  }

  // Filter/Search
  applyFilter(filter: string) {
    this.dataSource.filter = filter.trim().toLocaleLowerCase();
  }

  // Load Referral
  loadingReferrals() {
    this.referralService.getAllReferrals()
      .subscribe(
        (data: Referral[]) => this.dataSource.data = data,
        error => this.notification.error('Error to access Referral, error: ' + error)
      );
    // Add Sort and Paginator to data
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
  }

  onDetail(data: Referral) {

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

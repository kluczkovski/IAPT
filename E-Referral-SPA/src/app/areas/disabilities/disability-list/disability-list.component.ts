import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Disability } from '../disability';
import { DisabilityService } from '../disability.service';
import { NotificationService } from 'src/app/shared/notification.service';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { DialogService } from 'src/app/shared/dialog.service';
import { DisabilityComponent } from '../disability/disability.component';

@Component({
  selector: 'app-disability-list',
  templateUrl: './disability-list.component.html',
  styleUrls: ['./disability-list.component.scss']
})

export class DisabilityListComponent implements OnInit {

  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;
  displayedColumns = ['code', 'description', 'actions'];
  dataSource = new MatTableDataSource<Disability>();
  dialogConfig = new MatDialogConfig();

  constructor(private disabilityService: DisabilityService,
              private notificationService: NotificationService,
              private dialog: MatDialog,
              private dialogService: DialogService) {}

  ngOnInit() {
    this.loadDisabilities();
    this.dialogConfig.disableClose = true;
    this.dialogConfig.autoFocus = true;
    this.dialogConfig.width = '45%';
  }


  applyFilter(filter: string) {
    this.dataSource.filter = filter.trim().toLocaleLowerCase();
  }


  onCreate() {
    this.disabilityService.initializeDisabilityForm();
    this.dialog
      .open(DisabilityComponent, this.dialogConfig)
      .afterClosed().subscribe(result => this.loadDisabilities());
  }

  onUpdate(data: any) {
    this.disabilityService.populateDisabilityForm(data);
    this.dialog
      .open(DisabilityComponent, this.dialogConfig)
      .afterClosed().subscribe(result => this.loadDisabilities());
  }

  onDelete(data: any) {
    this.dialogService
      .openConfirmDialog(data.code)
      .afterClosed().subscribe( result => {
        if (result) {
           this.disabilityService
            .deleteDisability(data.id)
            .subscribe(
              () =>  {
                  this.notificationService.success('The Disability Code was deleted.');
                  this.loadDisabilities();
              },
              (error) => this.notificationService.error('The Disability Code was not deleted, error: ' + error)
            );
        }
      });
  }

  // Get all disabilities from API
  loadDisabilities() {
    this.disabilityService.getAllDisabilities()
      .subscribe(
        (data: Disability[]) => this.dataSource.data = data,
        (error) => this.notificationService.error(error)
      );
      // Add Sorte and Paginator to data
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
  }

}

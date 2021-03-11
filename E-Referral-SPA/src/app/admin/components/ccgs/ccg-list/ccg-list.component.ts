import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { MatDialogConfig, MatDialog } from '@angular/material/dialog';
import { CCG } from '../../../models/CCG';
import { CcgService } from '../../../services/ccg.service';
import { NotificationService } from 'src/app/shared/services/notification.service';
import { DialogService } from 'src/app/shared/services/dialog.service';
import { CcgComponent } from '../ccg/ccg.component';


@Component({
  selector: 'app-ccg-list',
  templateUrl: './ccg-list.component.html',
  styleUrls: ['./ccg-list.component.scss']
})
export class CcgListComponent implements OnInit {

  @ViewChild(MatSort, {static: true}) sort: MatSort;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  displayedColumns: string[] = ['code', 'description', 'hub', 'actions'];
  dataSource =  new MatTableDataSource<CCG>();
  dialogConfig = new MatDialogConfig();

  constructor(private ccgService: CcgService,
              private notification: NotificationService,
              private dialog: MatDialog,
              private dialogService: DialogService) { }

  ngOnInit(): void {
    this.loadCCGs();
    // Setup DialogConfig;
    this.dialogConfig.disableClose = true;
    this.dialogConfig.autoFocus = true;
    this.dialogConfig.width = '45%';
  }

  applyFilter(filter: string) {
    this.dataSource.filter = filter.trim().toLocaleLowerCase();
  }

  // Create new CCG
  onCreate() {
    this.dialog
      .open(CcgComponent, this.dialogConfig)
      .afterClosed().subscribe(() => this.loadCCGs());
  }

  // Update CCG
  onUpdate(data: CCG) {
    this.ccgService.populateCCGForm(data);
    this.dialog
      .open(CcgComponent, this.dialogConfig)
      .afterClosed().subscribe(() => this.loadCCGs());
  }

  // Delete CCG
  onDelete(data: CCG) {
    this.dialogService
      .openConfirmDialog(data.code)
      .afterClosed().subscribe(
        (result) => {
          if (result) {
            this.ccgService
              .deleteCCG(data.id)
              .subscribe(
                () => {
                  this.notification.success('The CCG Code was deleted');
                  this.loadCCGs();
                },
                error => this.notification.error('The CCG Code was not deleted, error: ' + error)
              );
          }
        }
      );


  }

  // Load all CCGs from back-end
  loadCCGs() {
    this.ccgService
      .getAllCCGs()
      .subscribe(
        (data: CCG[]) => this.dataSource.data = data,
        error => this.notification.error('Error to get all CCG Codes: ' + error)
      );
    // Add Sorte and Paginator to data
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
  }
}

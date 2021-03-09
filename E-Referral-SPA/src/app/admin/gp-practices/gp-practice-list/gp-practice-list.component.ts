import { Component, ViewChild, OnInit } from '@angular/core';
import { MatTableDataSource} from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { GpPractice } from '../gpPractice';
import { GpPracticeService } from '../gp-practice.service';
import { Observable } from 'rxjs';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
//import { GpComponent } from '.';
import { NotificationService } from 'src/app/shared/notification.service';
import { DialogService } from 'src/app/shared/dialog.service';
import { GpPracticeComponent } from '../gp-practice/gp-practice.component';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';


@Component({
  selector: 'app-gp-practice-list',
  templateUrl: './gp-practice-list.component.html',
  styleUrls: ['./gp-practice-list.component.scss']
})

export class GpPracticeListComponent implements OnInit {

  @ViewChild(MatSort, {static: true}) sort: MatSort;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  displayedColumns: string[] = ['code', 'description', 'postCode', 'ccgCodeDescription', 'actions'];
  dataSource =  new MatTableDataSource<GpPractice>();
  dialogConfig = new MatDialogConfig();

  constructor(private gpPracticeService: GpPracticeService,
              private notification: NotificationService,
              private dialog: MatDialog,
              private dialogService: DialogService) { }

  ngOnInit(): void {
    // Load GPPractice
    this.loadGpPractice();
    // Setup Dialog
    this.dialogConfig.disableClose = true;
    this.dialogConfig.autoFocus = true;
    this.dialogConfig.width = '45%';
  }

  // Filter/Search
  applyFilter(filter: string) {
    this.dataSource.filter = filter.trim().toLocaleLowerCase();
  }

  onCreate() {
    this.gpPracticeService.initializeForm();
    this.dialogConfig.data = {
      action: 'Add',
    };
    this.dialog
      .open(GpPracticeComponent, this.dialogConfig)
      .afterClosed().subscribe(
        () => this.loadGpPractice()
      );
  }

  onDetail(data: GpPractice) {
    this.dialogConfig.data = {
      action: 'Detail',
    };
    this.gpPracticeService.populateForm(data);
    this.gpPracticeService.Form.disable();
    this.dialog.open(GpPracticeComponent, this.dialogConfig)
      .afterClosed()
      .subscribe( () => this.gpPracticeService.Form.enable());
  }

  onEdit(data: GpPractice) {
    this.dialogConfig.data = {
      action: 'Edit',
    };
    this.gpPracticeService.populateForm(data);
    this.dialog.open(GpPracticeComponent, this.dialogConfig)
      .afterClosed().subscribe(
        () => this.loadGpPractice());
  }

  onDelete(data: GpPractice) {
    this.dialogService
      .openConfirmDialog(data.code)
      .afterClosed().subscribe(
          result => {
            if (result) {
              this.gpPracticeService
                .deleteGPPractice(data.id)
                .subscribe(
                  () => {
                    this.notification.success('The GP Practice was deleted.');
                    this.loadGpPractice();
                  },
                  error => this.notification.error('The GP Practice was not deleted, error: ' + error)
                );
            }
          }
      );
  }

  // Load all Gp Practices from Back-end
  loadGpPractice() {
    this.gpPracticeService
      .getAllGpPractices()
      .subscribe(
        (data: GpPractice[]) => this.dataSource.data = data,
        error => this.notification.error('Error to access the GP Practices, error: ' + error)
    );
    // Add Sort and Paginator to data
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
  }

}

import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { EthnicCategory } from '../../../models/ethnicCategory';
import { MatTableDataSource } from '@angular/material/table';
import { MatDialogConfig, MatDialog } from '@angular/material/dialog';
import { MatSort } from '@angular/material/sort';
import { EthnicCategoryService } from '../../../services/ethnic-category.service';
import { NotificationService } from 'src/app/shared/services/notification.service';
import { DialogService } from 'src/app/shared/services/dialog.service';
import { EthnicCategoryComponent } from '../ethnic-category/ethnic-category.component';

@Component({
  selector: 'app-ethnic-category-list',
  templateUrl: './ethnic-category-list.component.html',
  styleUrls: ['./ethnic-category-list.component.scss']
})
export class EthnicCategoryListComponent implements OnInit {

  @ViewChild(MatSort, {static: true}) sort: MatSort;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  displayedColumns: string[] = [ 'sequence', 'code', 'description', 'actions'];
  dataSource =  new MatTableDataSource<EthnicCategory>();
  dialogConfig = new MatDialogConfig();

  constructor(private ethnicService: EthnicCategoryService,
              private notification: NotificationService,
              private dialogService: DialogService,
              private dialog: MatDialog) { }

  ngOnInit(): void {
    this.loadEthnicCategories();
    this.dialogConfig.disableClose = true;
    this.dialogConfig.autoFocus = true;
    this.dialogConfig.width = '45%';
  }

  applyFilter(filter: string) {
    this.dataSource.filter = filter.toLocaleLowerCase().trim();
  }

  onCreate() {
    this.dialogConfig.data = {
      action: 'Add'
    };
    this.ethnicService.initializeForm();
    this.dialog.open(EthnicCategoryComponent, this.dialogConfig)
      .afterClosed().subscribe( () => this.loadEthnicCategories());
  }

  onEdit(data: EthnicCategory) {
    this.dialogConfig.data = {
      action: 'Edit'
    };
    this.ethnicService.populateForm(data);
    this.dialog.open(EthnicCategoryComponent, this.dialogConfig)
      .afterClosed().subscribe( () => this.loadEthnicCategories());
  }

  onDelete(data: EthnicCategory) {
    this.dialogService
      .openConfirmDialog(data.code)
      .afterClosed().subscribe(
        result => {
          if (result) {
            this.ethnicService.deleteEthnicCategory(data)
              .subscribe(
                () => {
                  this.notification.success('The Ethnic Category was deleted.');
                  this.loadEthnicCategories();
                },
                error => this.notification.error('The Ethnic Category was not deleted, error: ' + error),
              );
          }
        }
      )
  }

  loadEthnicCategories() {
    this.ethnicService.getAllEthnicCategories()
      .subscribe(
        (data: EthnicCategory[]) => this.dataSource.data = data,
        error => this.notification.error('Error to access the Ethnic Category, error: ' + error)
      );
    // Add Sort and Paginator to data
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
  }
}

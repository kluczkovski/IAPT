import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { NotificationService } from 'src/app/shared/notification.service';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { DialogService } from 'src/app/shared/dialog.service';
import { Religion } from '../religion';
import { ReligionService } from '../religion.service';
import { ReligionComponent } from '../religion/religion.component';
import { error } from 'protractor';

@Component({
  selector: 'app-religious-grup-list',
  templateUrl: './religious-grup-list.component.html',
  styleUrls: ['./religious-grup-list.component.scss']
})
export class ReligiousGrupListComponent implements OnInit {

  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;
  displayedColumns = ['code', 'description', 'actions'];
  dataSource = new MatTableDataSource<Religion>();
  dialogConfig = new MatDialogConfig();

  constructor(private religionService: ReligionService,
              private notification: NotificationService,
              private dialog: MatDialog,
              private dialogService: DialogService) { }

  ngOnInit(): void {
    this.loadReligiousGrup();
    this.dialogConfig.autoFocus = true;
    this.dialogConfig.width = '45%';
  }

  applyFilter(filter: string) {
    this.dataSource.filter = filter.trim().toLocaleLowerCase();
  }

  loadReligiousGrup() {
    this.religionService
      .getAllReligousGroup()
      .subscribe(
        (data: Religion[]) => this.dataSource.data = data,
        error => this.notification.error('Error to get all Religious-Group: ' + error)
      );
    // Add Sorte and Paginator to data
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
  }

  onCreate() {
    this.religionService.initializeForm();
    this.dialog.open(ReligionComponent, this.dialogConfig)
      .afterClosed().subscribe( () => this.loadReligiousGrup());
  }

  onUpdate(data: Religion) {
    this.religionService.populateCityForm(data);
    this.dialog.open(ReligionComponent, this.dialogConfig)
      .afterClosed().subscribe( () => this.loadReligiousGrup());
  }

  onDelete(data: Religion) {
    this.dialogService
      .openConfirmDialog(data.code)
      .afterClosed().subscribe(
        result => {
          if (result) {
            this.religionService
              .deleteReligion(data.id)
              .subscribe(
                () => {
                  this.notification.success('The Religion was delete with sucesseful');
                  this.loadReligiousGrup();
                },
                (error) => this.notification.error('The Religion was not delete, error: ' + error),
              );
          }
        }
      );
  }
}

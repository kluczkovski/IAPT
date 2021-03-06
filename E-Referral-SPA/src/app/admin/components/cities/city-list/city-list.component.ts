import { Component, ViewChild, OnInit } from '@angular/core';
import { MatTableDataSource} from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { City } from '../../../models/city';
import { CityService } from '../../../services/city.service';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { CityComponent } from '../city/city.component';
import { NotificationService } from 'src/app/shared/services/notification.service';
import { DialogService } from 'src/app/shared/services/dialog.service';


@Component({
  selector: 'app-city-list',
  templateUrl: './city-list.component.html',
  styleUrls: ['./city-list.component.scss']
})


export class CityListComponent implements OnInit {

  @ViewChild(MatSort, {static: true}) sort: MatSort;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  displayedColumns: string[] = ['name', 'actions'];
  dataSource =  new MatTableDataSource<City>();
  dialogConfig = new MatDialogConfig();

  constructor(private cityService: CityService,
              private notification: NotificationService,
              private dialog: MatDialog,
              private dialogService: DialogService) { }


  ngOnInit() {
    // Load Cities
    this.loadCities();
    // Setup DialogConfig;
    this.dialogConfig.disableClose = true;
    this.dialogConfig.autoFocus = true;
    this.dialogConfig.width = '45%';
  }


  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }


  onCreate() {
    this.cityService.initializeCityForm();
    this.dialog
      .open(CityComponent, this.dialogConfig)
      .afterClosed().subscribe( result => this.loadCities());
  }


  onEdit(data: City) {
    this.cityService.populateCityForm(data);
    this.dialog
      .open(CityComponent, this.dialogConfig)
      .afterClosed().subscribe( result => this.loadCities());

  }

  onDelete(data: any) {
    this.dialogService
      .openConfirmDialog(data.name)
      .afterClosed().subscribe( result => {
        if (result) {
           this.cityService
            .deleteCity(data.id)
            .subscribe(
              () =>  {
                  this.notification.success('The city was deleted.');
                  this.loadCities();
              },
              (error) => this.notification.error('The City was not deleted, error: ' + error)
            );
        }
      });
  }


  loadCities() {
    // Get all cities
    this.cityService.getAllCities()
      .subscribe(
        (data: City[]) => this.dataSource.data = data,
        (error) => {
          this.notification.error(error);
        }
    );
    // Add Sorte and Paginator to data
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
  }

}

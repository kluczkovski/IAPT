import { Component, ViewChild, OnInit } from '@angular/core';
import { MatTableDataSource} from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { City } from '../city';



const ELEMENT_DATA: City[] = [
  {id: '1',  name: 'Hydrogen'},
  {id: '2',  name: 'Helium'},
  {id: '3',  name: 'Lithium'},
  {id: '4',  name: 'Beryllium'},
  {id: '5',  name: 'Boron'},
  {id: '6',  name: 'Carbon'},
  {id: '7',  name: 'Nitrogen'},
  {id: '8',  name: 'Oxygen'},
  {id: '9',  name: 'Fluorine'},
  {id: '10', name: 'Neon'},
];

/**
 * @title Basic use of `<table mat-table>`
 */

@Component({
  selector: 'app-city-list',
  templateUrl: './city-list.component.html',
  styleUrls: ['./city-list.component.scss']
})

export class CityListComponent implements OnInit{

  displayedColumns: string[] = ['id', 'name'];
  dataSource =  new MatTableDataSource(ELEMENT_DATA);

  @ViewChild(MatSort, {static: true}) sort: MatSort;
  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;

  ngOnInit() {
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
  }

  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  logData(data: string) {
    console.log(data);
  }

}

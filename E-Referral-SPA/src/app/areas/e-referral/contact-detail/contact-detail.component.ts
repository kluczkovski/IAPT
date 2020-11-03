import { Component, OnInit, Input, OnChanges } from '@angular/core';
import { FormGroup, Validators } from '@angular/forms';
import { City } from '../../cities/city';
import { CityService } from '../../cities/city.service';
import { NotificationService } from 'src/app/shared/notification.service';
import { CommunicationMethodEnum } from '../_models/enums/communicationMethodEnum';
import { GpPractice } from '../../gp-practices/gpPractice';
import { GpPracticeService } from '../../gp-practices/gp-practice.service';
import { error } from 'console';

@Component({
  selector: 'app-contact-detail',
  templateUrl: './contact-detail.component.html',
  styleUrls: ['./contact-detail.component.scss']
})
export class ContactDetailComponent implements OnInit, OnChanges {

  myStringDate: string;
  actualDate: Date;
  myDate: Date;
  @Input() form: FormGroup;
  listOfCities: City[] = [];
  listofGPs: GpPractice[] = [];
  communicantioMethod = CommunicationMethodEnum;
  listOfCommunicantioMethod: string[];
  selectedCity: City = null;

  constructor(private cityService: CityService,
              private gpService: GpPracticeService,
              private notification: NotificationService) { }

  ngOnInit(): void {
    // Load the Cities
    this.loadAllCities();
    // Load the GPs
    this.loadAllGps();
    // List of Communication Methods from Enum
    this.listOfCommunicantioMethod = Object.keys(this.communicantioMethod);
  }

  loadAllCities() {
    this.cityService
      .getAllCities()
      .subscribe(
        (data: City[]) => this.listOfCities = data,
        error => this.notification.error('Error to access the Cities, error: ' + error)
      );
  }

  loadAllGps() {
    this.gpService
      .getAllGpPractices()
      .subscribe(
        (data: GpPractice[]) => this.listofGPs = data,
        error => this.notification.error('Error to access the GP Surgery, error:' + error)
      );
  }


  ngOnChanges(): void {
  // Get the name of Ciy which was seleced.
    this.form.get('contactDetail.cityId').valueChanges.subscribe( (idValue) => {
      if (idValue) {
        this.selectedCity = this.listOfCities.find( val => val.id === idValue);

        // Check if would set the Required on State City
        this.form.get('contactDetail.anotherCity').setValidators(null);
        if (this.selectedCity.name === 'Other') {
          this.form.get('contactDetail.anotherCity').setValidators(Validators.required);
        }
        this.form.get('contactDetail.anotherCity').updateValueAndValidity();
      }
    });
  }

  checkDate() {
    // actual date
    this.actualDate = new Date();
    // Check date
    this.myStringDate = this.form.get('contactDetail.birthDay').value;
    try {
      this.myDate = new Date(this.myStringDate);
      if (this.myDate.getFullYear() <= 1900) {
        this.form.get('contactDetail.birthDay').setErrors({'incorrect': true});
      } else {
        if ( this.myDate.getFullYear() > this.actualDate.getFullYear() -1 ) {
          this.form.get('contactDetail.birthDay').setErrors({'incorrect': true});
        }
      }
    } catch (error) {
      this.form.get('contactDetail.birthDay').setErrors({'incorrect': true});
    }
  }

}

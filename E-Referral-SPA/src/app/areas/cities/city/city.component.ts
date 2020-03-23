import { Component, OnInit } from '@angular/core';
import { CityService } from '../city.service';
import { NotificationService} from '../../../shared/notification.service';
import { FormControl, FormGroup } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { City } from '../city';

@Component({
  selector: 'app-city',
  templateUrl: './city.component.html',
  styleUrls: ['./city.component.scss']
})
export class CityComponent implements OnInit {

  city: City;

  constructor(public cityService: CityService,
              private notificationService: NotificationService,
              private dialogRef: MatDialogRef<CityComponent>) { }


  ngOnInit(): void {}


  onSubmit() {
    if (this.cityService.Form.valid) {

      if (!this.cityService.Form.get('id').value) {
        // Add
        this.city = Object.assign({}, this.cityService.Form.value);
        this.cityService
              .addCity(this.city)
              .subscribe(
                () => {
                        this.notificationService.success('The City was added with successed.');
                        this.onClose();
                },
                error => { this.notificationService.error('The City was not added, error: ' + error);
              });
      } else {
        // Update
        this.city = Object.assign({}, this.cityService.Form.value);
        this.cityService
              .updateCity(this.city)
              .subscribe(
                () =>  {
                          this.notificationService.success('The City was updated with sucessed.'),
                          this.onClose();
                },
                error => this.notificationService.error('The City was not updated, error: ' + error)
              );
      }
    }
  }

  onClose() {
    this.cityService.Form.reset();
    this.cityService.initializeCityForm();
    this.dialogRef.close();
  }
}

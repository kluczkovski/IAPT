import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable, throwError } from 'rxjs';
import { Disability } from '../models/disability';
import { catchError } from 'rxjs/operators';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { BaseService } from 'src/app/shared/services/base.service';


@Injectable({
  providedIn: 'root'
})
export class DisabilityService extends BaseService {

  private url: string = this.baseUrl + '/v1/disabilitycodes';

  Form: FormGroup = new FormGroup({
    id: new FormControl(null),
    code: new FormControl('', [Validators.required, Validators.minLength(2)]),
    description: new FormControl('', [Validators.required, Validators.minLength(5)])
  });

  constructor(private http: HttpClient) {
    super();
   }

  // Get all codes from backend
  getAllDisabilities(): Observable<Disability[]> {
    return this.http
      .get<Disability[]>(this.url);
  }

  // Add a new Disability Code
  addDisability(data: Disability): Observable<any> {
    return this.http
      .post(this.url, data, super.getAuthHeaderJson());
  }

  // Update Disability Code
  updateDisability(data: Disability): Observable<any> {
    return this.http
      .put(this.url + '/' + data.id, data, super.getAuthHeaderJson());
  }

  // Delete Disabiliy Code
  deleteDisability(id: string): Observable<any> {
    return this.http
      .delete(this.url + '/' + id, super.getAuthHeaderJson());
  }

  // Initialize the Disability Form
  initializeDisabilityForm() {
    this.Form.setValue({
      id: null,
      code: '',
      description: '',
    });
  }

  // Put Data to Form
  populateDisabilityForm(data: Disability) {
    this.Form.setValue(data);
  }

}

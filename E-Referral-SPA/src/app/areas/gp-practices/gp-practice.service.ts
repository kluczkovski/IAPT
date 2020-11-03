import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable, throwError } from 'rxjs';
import { GpPractice } from './gpPractice';
import { catchError } from 'rxjs/operators';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { BaseService } from 'src/app/shared/base.service';

@Injectable({
  providedIn: 'root'
})
export class GpPracticeService extends BaseService {

  url =  this.baseUrl + '/v1/gppractices';

  Form: FormGroup = new FormGroup({
    id: new FormControl(null),
    code: new FormControl('', [Validators.required, Validators.minLength(6), Validators.maxLength(6)]),
    description: new FormControl('', [Validators.required, Validators.minLength(5)]),
    addressLine1: new FormControl('', [Validators.required]),
    addressLine2: new FormControl('', [Validators.required]),
    addressLine3: new FormControl(''),
    addressLine4: new FormControl(''),
    postCode: new FormControl('', [Validators.required]),
    ccgCodeId: new FormControl('', [Validators.required])
  });


  constructor(private http: HttpClient) {
    super();
   }

  // Initialize Form
  initializeForm() {
    this.Form.setValue({
      id: null,
      code: '',
      description: '',
      addressLine1: '',
      addressLine2: '',
      addressLine3: '',
      addressLine4: '',
      postCode: '',
      ccgCodeId: '',
    });
  }

  // Populate Form
  populateForm(data: GpPractice) {
    this.Form.setValue({
      id: data.id,
      code: data.code,
      description: data.description,
      addressLine1: data.addressLine1,
      addressLine2: data.addressLine2,
      addressLine3: data.addressLine3,
      addressLine4: data.addressLine4,
      postCode: data.postCode,
      ccgCodeId: data.ccgCode != null ? data.ccgCode.id : '',
    });
  }

  // Get all Gp Practices
  getAllGpPractices(): Observable<GpPractice[]> {
    return this.http
      .get<GpPractice[]>(this.url)
      .pipe(catchError(this.handlerError));
  }

  // Add New GP Practice
  addGpPractice(data: GpPractice): Observable<any> {
    return this.http
      .post(this.url, data)
      .pipe(catchError(this.handlerError));
  }

  // Update GP Practice
  updateGpPractice(data: GpPractice): Observable<any> {
    return this.http
      .put(this.url + '/' + data.id, data)
      .pipe(catchError(this.handlerError));
  }

  // Delete GP Practice
  deleteGPPractice(id: string): Observable<any> {
    return this.http
      .delete(this.url + '/' + id)
      .pipe(catchError(this.handlerError));
  }

}

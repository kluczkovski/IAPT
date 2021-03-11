import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { CCG } from '../models/CCG';
import { catchError } from 'rxjs/operators';
import { BaseService } from 'src/app/shared/services/base.service';


@Injectable({
  providedIn: 'root'
})
export class CcgService extends BaseService {

  private url: string = this.baseUrl + '/v1/ccgcodes';

  Form: FormGroup = new FormGroup({
    id: new FormControl(null),
    code: new FormControl('', [Validators.required, Validators.minLength(3)]),
    description: new FormControl('', [Validators.required, Validators.minLength(5)]),
    hub: new FormControl(''),
  });

  constructor(private http: HttpClient) {
    super();
   }

  // Initialize the Form
  initializeForm() {
    this.Form.setValue({
      id: null,
      code: '',
      description: '',
      hub: '',
    });
  }

  // Put Data to Form
  populateCCGForm(data: CCG) {
    this.Form.setValue(data);
  }

  // Get All CCG Codes
  getAllCCGs(): Observable<CCG[]> {
    return this.http
      .get<CCG[]>(this.url);
  }

  // Add new CCG Code
  addCCG(data: CCG): Observable<any> {
    return this.http
      .post(this.url + '/', data, super.getAuthHeaderJson());
  }

  // Update CCG Code
  updateCCG(data: CCG): Observable<any> {
    return this.http
      .put(this.url + '/' + data.id, data, super.getAuthHeaderJson());
  }

  // Delete CCG Code
  deleteCCG(id: string): Observable<any> {
    return this.http
      .delete(this.url + '/' + id, super.getAuthHeaderJson());
  }

}

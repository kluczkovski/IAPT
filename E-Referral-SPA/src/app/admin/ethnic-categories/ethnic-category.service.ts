import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { EthnicCategory } from './ethnicCategory';
import { catchError } from 'rxjs/operators';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { BaseService } from 'src/app/shared/base.service';

@Injectable({
  providedIn: 'root'
})
export class EthnicCategoryService  extends BaseService{

  url: string = this.baseUrl + '/v1/ethniccategories';

  Form: FormGroup = new FormGroup({
    id : new FormControl(null),
    sequence: new FormControl('', Validators.required),
    code: new FormControl('', Validators.required),
    description: new FormControl('', [Validators.required, Validators.minLength(5)])
  });

  constructor(private http: HttpClient) { 
    super();
  }

  // Inizialize Form
  initializeForm() {
    this.Form.setValue({
      id: null,
      sequence: '',
      code: '',
      description: '',
    });
  }

  // Populate the Form
  populateForm(data: EthnicCategory) {
    this.Form.setValue(data);
  }

  // Get all Ethnic Categories from db
  getAllEthnicCategories(): Observable<EthnicCategory[]> {
  return this.http
    .get<EthnicCategory[]>(this.url)
    .pipe(catchError(this.handlerError));
  }

  // Insert Ethnic
  insertEthnicCategory(data: EthnicCategory): Observable<any> {
    return this.http
      .post(this.url, data)
      .pipe(catchError(this.handlerError));
  }

  // Update Ethnic
  updateEthnicCategory(data: EthnicCategory): Observable<any> {
    return this.http
      .put(this.url + '/' + data.id, data)
      .pipe(catchError(this.handlerError));
  }

  // Delete Ethnic
  deleteEthnicCategory(data: EthnicCategory): Observable<any> {
    return this.http
      .delete(this.url + '/' + data.id)
      .pipe(catchError(this.handlerError));
  }


}





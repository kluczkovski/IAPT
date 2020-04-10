import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { EthnicCategory } from './ethnicCategory';
import { catchError } from 'rxjs/operators';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class EthnicCategoryService {

  baseUrl: string = environment.apiUrl + ('/v1/ethniccategories');

  Form: FormGroup = new FormGroup({
    id : new FormControl(null),
    sequence: new FormControl('', Validators.required),
    code: new FormControl('', Validators.required),
    description: new FormControl('', [Validators.required, Validators.minLength(5)])
  });

  constructor(private http: HttpClient) { }

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
    .get<EthnicCategory[]>(this.baseUrl)
    .pipe(catchError(this.handleError));
  }

  // Insert Ethnic
  insertEthnicCategory(data: EthnicCategory): Observable<any> {
    return this.http
      .post(this.baseUrl, data)
      .pipe(catchError(this.handleError));
  }

  // Update Ethnic
  updateEthnicCategory(data: EthnicCategory): Observable<any> {
    return this.http
      .put(this.baseUrl + '/' + data.id, data)
      .pipe(catchError(this.handleError));
  }

  // Delete Ethnic
  deleteEthnicCategory(data: EthnicCategory): Observable<any> {
    return this.http
      .delete(this.baseUrl + '/' + data.id)
      .pipe(catchError(this.handleError));
  }

  // Handler Error
  handleError(error: HttpErrorResponse) {
    const messages: string[]  = [];
    if (error.status === 400) {
      if (!error.error.success) {
          // Bad Request - Get erros from Back-end
          const backEndValidations = error.error.erros;
          backEndValidations.forEach(element => {
            messages.push(element);
            console.log(element);
          });
        }
    } else {
        messages.push(error.message);
    }
    console.log('ERROR OCCURED: ' + messages);
    return throwError(messages);
  }

}





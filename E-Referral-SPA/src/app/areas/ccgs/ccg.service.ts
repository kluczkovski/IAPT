import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { CCG } from './Ccg';
import { catchError } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class CcgService {

  private baseUrl: string = environment.apiUrl + ('/v1/ccgcodes');

  Form: FormGroup = new FormGroup({
    id: new FormControl(null),
    code: new FormControl('', [Validators.required, Validators.minLength(3)]),
    description: new FormControl('', [Validators.required, Validators.minLength(5)]),
    hub: new FormControl(''),
  });

  constructor(private http: HttpClient) {
    // console.log('CCG Service...');
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
      .get<CCG[]>(this.baseUrl)
      .pipe(catchError(this.handleError));
  }

  // Add new CCG Code
  addCCG(data: CCG): Observable<any> {
    return this.http
      .post(this.baseUrl + '/', data)
      .pipe(catchError(this.handleError));
  }

  // Update CCG Code
  updateCCG(data: CCG): Observable<any> {
    return this.http
      .put(this.baseUrl + '/' + data.id, data)
      .pipe(catchError(this.handleError));
  }

  // Delete CCG Code
  deleteCCG(id: string): Observable<any> {
    return this.http
      .delete(this.baseUrl + '/' + id)
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

import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable, throwError } from 'rxjs';
import { Disability } from './disability';
import { catchError } from 'rxjs/operators';
import { FormGroup, FormControl, Validators } from '@angular/forms';


@Injectable({
  providedIn: 'root'
})
export class DisabilityService {

  private baseUrl: string = environment.apiUrl + ('/v1/disabilitycodes');
  Form: FormGroup = new FormGroup({
    id: new FormControl(null),
    code: new FormControl('', [Validators.required, Validators.minLength(2)]),
    description: new FormControl('', [Validators.required, Validators.minLength(5)])
  });

  constructor(private http: HttpClient) { }

  // Get all codes from backend
  getAllDisabilities(): Observable<Disability[]> {
    return this.http
      .get<Disability[]>(this.baseUrl)
      .pipe(catchError(this.handlerError));

  }

  // Add a new Disability Code
  addDisability(data: Disability): Observable<any> {
    return this.http
      .post(this.baseUrl, data)
      .pipe(catchError(this.handlerError));
  }

  // Update Disability Code
  updateDisability(data: Disability): Observable<any> {
    return this.http
      .put(this.baseUrl + '/' + data.id, data)
      .pipe(catchError(this.handlerError));
  }

  // Delete Disabiliy Code
  deleteDisability(id: string): Observable<any> {
    return this.http
      .delete(this.baseUrl + '/' + id)
      .pipe(catchError(this.handlerError));
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

  // Handler Error
  handlerError(error: HttpErrorResponse) {
    const messages: string[] = [];
    if (error.status === 400) {
      if (!error.error.success) {
        const backEndValidations = error.error.erros;
        backEndValidations.forEach(element => {
          messages.push(element);
        });
      }
    } else {
      messages.push(error.message);
    }
    console.log('ERROR OCCURED: ' + messages);
    return throwError(messages);
  }
}

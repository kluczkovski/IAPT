import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Observable, throwError } from 'rxjs';
import { Religion } from '../models/religion';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { catchError } from 'rxjs/operators';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { BaseService } from 'src/app/shared/services/base.service';

@Injectable({
  providedIn: 'root'
})
export class ReligionService extends BaseService {

  private url: string = this.baseUrl + '/v1/religiousgroups';

  Form: FormGroup = new FormGroup( {
    id: new FormControl(null),
    code: new FormControl('', [Validators.required, Validators.minLength(1)]),
    description: new FormControl('', [Validators.required, Validators.minLength(3)]),
  });

  constructor(private http: HttpClient) { 
    super();
  }

  // Initialize Religion Group
  initializeForm() {
    this.Form.setValue({
      id: null,
      code: '',
      description: '',
    });
  }

  // Put Data to Form
  populateCityForm(data: Religion) {
    this.Form.setValue(data);
  }

  getAllReligousGroup(): Observable<Religion[]> {
    return this.http.get<Religion[]>(this.url);
  }

  // Add Religion
  addReligion(data: Religion): Observable<any> {
    return this.http.post(this.url, data, super.getAuthHeaderJson());
  }

  // Update Religion
  updateReligion(data: Religion): Observable<any> {
    return this.http.put(this.url + '/' + data.id, data, super.getAuthHeaderJson());
  }


  // Delete Religion
  deleteReligion(id: string): Observable<any> {
    return this.http.delete(this.url + '/' + id, super.getAuthHeaderJson());
  }

}

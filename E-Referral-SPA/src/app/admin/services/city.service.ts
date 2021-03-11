import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { map, tap, catchError } from 'rxjs/operators';
import { City } from '../models/city';
import { environment } from 'src/environments/environment';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { BaseService } from 'src/app/shared/services/base.service';



@Injectable({
    providedIn: 'root'
})
export class CityService  extends BaseService {

    url: string = this.baseUrl + '/v1/cities';

    Form: FormGroup = new FormGroup({
        id: new FormControl(null),
        name: new FormControl('', [Validators.required, Validators.minLength(3)])
    });


    constructor(private http: HttpClient) {
        super();
    }


    // Initialize the City Form
    initializeCityForm() {
        this.Form.setValue({
            id: null,
            name: '',
        });
    }

    // Put Data to Form
    populateCityForm(data: City) {
        this.Form.setValue(data);
    }

    // Get All cities from API //
    getAllCities(): Observable<City[]> {
        return this.http.get<City[]>(this.url);
    }

    // Post - Add
    addCity(data: City): Observable<any> {
        return this.http.post(this.url, data, super.getAuthHeaderJson());
    }

    // Put - Edit
    updateCity(data: City): Observable<any> {
        return this.http.put(this.url + '/' + data.id, data, super.getAuthHeaderJson())
    }

    // Delete
    deleteCity(id: string): Observable<any> {
        return this.http.delete(this.url + '/' + id, super.getAuthHeaderJson());
    }

}

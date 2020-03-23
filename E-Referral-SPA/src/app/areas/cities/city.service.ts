import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { map, tap, catchError } from 'rxjs/operators';
import { City } from './city';
import { environment } from 'src/environments/environment';
import { FormGroup, FormControl, Validators } from '@angular/forms';



@Injectable({
    providedIn: 'root'
})
export class CityService {

    baseUrl = environment.apiUrl + ('/v1/cities');

    Form: FormGroup = new FormGroup({
        id: new FormControl(null),
        name: new FormControl('', [Validators.required, Validators.minLength(3)])
    });


    constructor(private http: HttpClient) {}


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

    // Get All cities from API // full response!!!
    // getAllCities(): Observable<City[]> {
    //     return this.http.get<City[]>(this.baseUrl, {observe: 'response'})
    //             .pipe(
    //                 tap(response => console.log(response)),
    //                 map(response => response.body)
    //             );
    // }


    // Get All cities from API //
    getAllCities(): Observable<City[]> {
        return this.http
                .get<City[]>(this.baseUrl)
                .pipe(
                    catchError(this.handleError)
                );
    }


    // Post - Add
    addCity(data: City): Observable<any> {
        return this.http
            .post(this.baseUrl, data)
            .pipe(catchError(this.handleError));
    }


    // Put - Edit
    updateCity(data: City): Observable<any> {
        return this.http
            .put(this.baseUrl + '/' + data.id, data)
            .pipe(catchError(this.handleError));
    }


    // Delete
    deleteCity(id: string): Observable<any> {
        return this.http
            .delete(this.baseUrl + '/' + id)
            .pipe(catchError(this.handleError));
    }


    // Handler Error
    handleError(error: HttpErrorResponse) {
        const messages: string[]  = [];
        if (error.status === 400) {
            if (!error.error.success) {
                // tslint:disable-next-line: comment-format
                //Bad Request - Get erros from Back-end
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

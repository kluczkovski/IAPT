import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { catchError, map } from "rxjs/operators";
import { BaseService } from "src/app/shared/services/base.service";
import { User } from "../models/user";

@Injectable() 
export class AccountService extends BaseService {

    urlAdd: string = this.baseUrl + '/v1/myaccount/new-user';
    urlLogin: string = this.baseUrl + '/v1/myaccount/login';

    constructor(private http: HttpClient) {
        super();
    }


    registerUser(user: User): Observable<User> {
        let response = this.http
            .post(this.urlAdd, user)
            .pipe(map(this.extractData));
        return response;
    }

    login(user: User): Observable<User>{
        let response = this.http
            .post(this.urlLogin, user)
            .pipe(map(this.extractData));
        return response;
    }
}
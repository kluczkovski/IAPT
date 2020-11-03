import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/internal/operators/catchError';
import { BaseService } from 'src/app/shared/base.service';
import { Referral } from './referral';

@Injectable({
  providedIn: 'root'
})
export class ReferralService extends BaseService {

  private url: string = this.baseUrl + ('/v1/eReferrals');

  constructor(private http: HttpClient) {
    super();
  }

  // Get All Referrals
  getAllReferrals(): Observable<Referral[]> {
    return this.http.get<Referral[]>(this.url)
              .pipe(catchError(this.handlerError));
  }

  // Delete Referral
  deleteReferral(id: string): Observable<any> {
    return this.http
      .delete(this.url + '/' + id)
      .pipe();
  }

}

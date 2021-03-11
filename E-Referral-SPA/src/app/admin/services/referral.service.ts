import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/internal/operators/catchError';
import { BaseService } from 'src/app/shared/services/base.service';
import { Referral } from '../models/referral';

@Injectable({
  providedIn: 'root'
})
export class ReferralService extends BaseService {

  private url: string = this.baseUrl + ('/v1/eReferrals');

  constructor(private http: HttpClient) {
    super();
  }

  // Get All Referrals
  getAllReferral(): Observable<Referral[]> {
    return this.http.get<Referral[]>(this.url + '/GetAllReferrals', super.getAuthHeaderJson());
  }

  // Delete Referral
  deleteReferral(id: string): Observable<any> {
    return this.http.delete(this.url + '/' + id, super.getAuthHeaderJson());
  }

  // PDF Referral
  // to Improve the security
  pdfReferral(id: string): Observable<any> {
    var mediaType = 'application/pdf';
    return this.http.get(this.url + '/pdfReferral/' + id, {responseType: 'blob'},);
  }

}

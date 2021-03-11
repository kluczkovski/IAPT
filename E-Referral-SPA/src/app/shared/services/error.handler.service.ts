import { HttpErrorResponse, HttpEvent, HttpHandler, HttpInterceptor, HttpRequest, HttpResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { Observable, throwError } from "rxjs";
import { catchError, map, retry } from "rxjs/operators";
import { LocalStorage } from "../utils/localStorage";

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {

    private localStorageUtil = new LocalStorage();

    constructor(private router: Router) {}

    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        return next.handle(req).pipe(
            retry(2),
            catchError(error => {
                const messages: string[] = [];
                if (error instanceof HttpErrorResponse) {
                    // console.log("error from backend")
                    // console.log(error)
                    // Unknown
                    if (error.statusText === "Unknown Error") {
                        messages.push("Occured an unknow error");
                         messages.push(error.error.erros);
                    }
                    // Bad Request
                    if (error.status === 400) {
                        if (!error.error.success) {
                            // Bad Request - Get erros from Back-end
                            const backEndValidations = error.error.erros;
                            backEndValidations.forEach(element => {
                                messages.push(element);
                            });
                        }
                    }
                    // Unauthorized 
                    if (error.status === 401) {
                        // this.localStorageUtil.clearUserData()
                        messages.push(error.statusText);
                        this.router.navigate(['/e-referral'])
                        console.log(messages)
                    }
                    // Unknow/Forbidden
                    if (error.status === 403) {
                        messages.push('Forbidden Error')
                        this.router.navigate(['/not-found'])
                    }
                }
                else {
                    messages.push(error)
                }
                return throwError(messages);
        }));
        
    }

}
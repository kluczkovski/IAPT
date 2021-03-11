import { throwError } from 'rxjs';
import { environment } from 'src/environments/environment';
import { HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { LocalStorage } from '../utils/localStorage';
import { cwd } from 'process';

export abstract class BaseService {

    public LocalStorage = new LocalStorage();
    protected baseUrl: string = environment.apiUrl;

    // Get HeeaderJson
    protected getHeaderJson() {
        return {
            headers: new HttpHeaders({
                'Content-Type': 'application/json'
            })
        };
    }

    protected getAuthHeaderJson() {
        return {
            headers: new HttpHeaders({
                'Content-Type': 'application/json',
                'Authorization': `Bearer ${this.LocalStorage.getUserToken()}`
            })
        }
    }

    protected getAuthHeaderBlob() {
        return {
            headers: new HttpHeaders({
                'Content-Type': 'application/json',
                'responseType': 'blob',
                'Authorization': `Bearer ${this.LocalStorage.getUserToken()}`
            })
        }
    }
    // Generic function to Handler the Errors
    // protected handlerError(response: Response | any) {
    //     const messages: string[]  = [];

    //     if (response instanceof HttpErrorResponse) {
    //         console.log(response)
    //         if (response.statusText === "Unknown Error") {
    //             messages.push("Occured an unknow error");
    //             response.error.erros = messages;
    //         }

    //         if (response.status === 400) {
    //             if (!response.error.success) {
    //                 // Bad Request - Get erros from Back-end
    //                 const backEndValidations = response.error.erros;
    //                 backEndValidations.forEach(element => {
    //                     messages.push(element);
    //                 });
    //             }
    //         }

    //         if (response.status === 500) {
    //             messages.push("Internal Server Error");
    //         } 

    //     }
    //     console.log('ERROR OCCURED: ' + messages);
    //     return throwError(messages);
    // }

    // Extrac Data from the from the response
    protected extractData(response: any){
        return response.data || {};
    }
}

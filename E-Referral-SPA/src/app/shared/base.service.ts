import { throwError } from 'rxjs';
import { environment } from 'src/environments/environment';
import { HttpErrorResponse, HttpHeaders } from '@angular/common/http';

export abstract class BaseService {

    protected baseUrl: string = environment.apiUrl;


    // Get HeeaderJson
    protected getHeaderJson() {
        return {
            headers: new HttpHeaders({
                'Content-Type': 'application/json'
            })
        };
    }

    // Generic function to Handler the Errors
    protected handlerError(response: Response | any) {
        const messages: string[]  = [];

        if (response instanceof HttpErrorResponse) {
            if (response.status === 400) {
                if (!response.error.success) {
                    // Bad Request - Get erros from Back-end
                    const backEndValidations = response.error.erros;
                    backEndValidations.forEach(element => {
                        messages.push(element);
                    });
                }
            } else {
                messages.push(response.message);
            }
        }
        console.log('ERROR OCCURED: ' + messages);
        return throwError(messages);
    }
}

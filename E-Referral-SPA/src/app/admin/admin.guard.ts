import { Injectable } from '@angular/core'
import { CanLoad, Route, UrlSegment } from '@angular/router';
import { Observable } from 'rxjs';
import { LocalStorage } from '../shared/localStorage';

@Injectable()
export class AdminAuthGuard implements CanLoad {

    localStorage = new LocalStorage();
    
    canLoad(route: Route, segments: UrlSegment[]): boolean | Observable<boolean> | Promise<boolean> {
        return  this.localStorage.getUserToken() !== null;
    }

}
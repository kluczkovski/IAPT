import { Component, OnInit } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map, shareReplay } from 'rxjs/operators';
import { LocalStorage } from 'src/app/shared/localStorage';

@Component({
  selector: 'app-main-nav',
  templateUrl: './main-nav.component.html',
  styleUrls: ['./main-nav.component.scss']
})
export class MainNavComponent implements OnInit{

  isHandset$: Observable<boolean> = this.breakpointObserver
    .observe([Breakpoints.XLarge, Breakpoints.Large, Breakpoints.Medium,
              Breakpoints.Small,  Breakpoints.Tablet, Breakpoints.Handset])
    .pipe(
      map(result => result.matches),
      shareReplay()
    );

  isSmall$: Observable<boolean> = this.breakpointObserver
    .observe([Breakpoints.XSmall, Breakpoints.Small])
    .pipe(
      map(result => result.matches),
      shareReplay()
    );

  localStorage = new LocalStorage();
  
  constructor(private breakpointObserver: BreakpointObserver) {}

  ngOnInit(): void {}

  checkUserLogin(): boolean {
    return this.localStorage.getUserToken() !== null;
  }
}

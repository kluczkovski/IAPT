import { Component } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { MatIconRegistry } from '@angular/material/icon';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent  {
  title = 'Survivors Manchester';

  constructor(private matIconRegistry: MatIconRegistry,
              private domSanitizer: DomSanitizer) {
                this.matIconRegistry.addSvgIcon(
                  'sm-logo',
                  this.domSanitizer.bypassSecurityTrustResourceUrl('../assets/sm-logo.svg')
                );
              }

}
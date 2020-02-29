import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { Routes, Router, RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import { MaterialModule } from './material.module';
import { GpPracticeModule } from './areas/gp-practice/gp-practice.module';
import { CityModule} from './areas/city/city.module';

import { AppComponent } from './app.component';
import { MainNavComponent } from './navigation/main-nav/main-nav.component';
import { rootRouterConfig } from './app.routers';
import { FooterComponent } from './navigation/footer/footer.component';

@NgModule({
  declarations: [
    AppComponent,
    MainNavComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    MaterialModule,
    CityModule,
    GpPracticeModule,
    BrowserAnimationsModule,
    HttpClientModule,
    [RouterModule.forRoot(rootRouterConfig, {useHash: false})]
  ],
  providers: [],
  bootstrap: [AppComponent],
  schemas: []
})
export class AppModule { }

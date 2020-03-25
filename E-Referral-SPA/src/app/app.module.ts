import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { Routes, Router, RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { MaterialModule } from './material.module';
import { GpPracticeModule } from './areas/gp-practice/gp-practice.module';
import { CityModule} from './areas/cities/city.module';

import { AppComponent } from './app.component';
import { MainNavComponent } from './navigation/main-nav/main-nav.component';
import { rootRouterConfig } from './app.routers';
import { FooterComponent } from './navigation/footer/footer.component';
import { CityService } from './areas/cities/city.service';
import { NotificationService } from './shared/notification.service';
import { ConfirmDialogComponent } from './confirm-dialog/confirm-dialog.component';
import { DisabilityModule } from './areas/disabilities/disability.module';
import { DisabilityService } from './areas/disabilities/disability.service';
import { ReligionModule } from './areas/religious-group/religion.module';
import { CcgModule } from './areas/ccgs/ccg.module';

@NgModule({
  declarations: [
    AppComponent,
    MainNavComponent,
    FooterComponent,
    ConfirmDialogComponent
  ],
  imports: [
    BrowserModule,
    MaterialModule,
    CityModule,
    DisabilityModule,
    ReligionModule,
    CcgModule,
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    [RouterModule.forRoot(rootRouterConfig, {useHash: false})]
  ],
  providers: [
    CityService,
    DisabilityService,
    NotificationService
  ],
  bootstrap: [AppComponent],
  schemas: []
})
export class AppModule { }

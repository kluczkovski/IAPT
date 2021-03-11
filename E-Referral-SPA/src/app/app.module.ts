import { BrowserModule } from '@angular/platform-browser';
import { LOCALE_ID, NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { MaterialModule } from './material.module';


import { AppComponent } from './app.component';
import { MainNavComponent } from './navigation/components/main-nav/main-nav.component';
import { FooterComponent } from './navigation/components/footer/footer.component';
import { CityService } from './admin/services/city.service';
import { NotificationService } from './shared/services/notification.service';
import { ConfirmDialogComponent } from './shared/components/confirm-dialog/confirm-dialog.component';
import { DisabilityService } from './admin/services/disability.service';
import { EReferralModule } from './e-referral/e-referral.module';
import { MAT_DATE_LOCALE, MAT_DATE_FORMATS, DateAdapter } from '@angular/material/core';
import { CustomDateAdapter } from './shared/utils/CustomDateAdapter';
import { FlexLayoutModule } from '@angular/flex-layout';
import { AppRoutingModule } from './app.routing.module';
import { MenuLoginComponent } from './navigation/components/menu-login/menu-login.component';
import { NotFoundComponent } from './navigation/components/not-found/not-found.component';
import { AdminAuthGuard } from './admin/admin.guard';
import { ErrorInterceptor } from './shared/services/error.handler.service';

@NgModule({
  declarations: [
    AppComponent,
    MainNavComponent,
    FooterComponent,
    ConfirmDialogComponent,
    MenuLoginComponent,
    NotFoundComponent
  ],
  imports: [
    BrowserModule,
    MaterialModule,
    AppRoutingModule,
    EReferralModule,
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    FlexLayoutModule,
    ],

  providers: [
    CityService,
    DisabilityService,
    NotificationService,
    AdminAuthGuard,
    {provide: LOCALE_ID, useValue: 'en-GB'},
    {provide: MAT_DATE_LOCALE, useValue: 'en-GB'},
    {provide: DateAdapter, useClass: CustomDateAdapter},
    {provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true}
  ],
  bootstrap: [AppComponent],
  schemas: []
})
export class AppModule { }

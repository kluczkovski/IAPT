import { BrowserModule } from '@angular/platform-browser';
import { LOCALE_ID, NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { MaterialModule } from './material.module';
// import { GpPracticeModule } from './admin/gp-practices/gp-practice.module';


import { AppComponent } from './app.component';
import { MainNavComponent } from './navigation/main-nav/main-nav.component';
import { FooterComponent } from './navigation/footer/footer.component';
import { CityService } from './admin/cities/city.service';
import { NotificationService } from './shared/notification.service';
import { ConfirmDialogComponent } from './shared/components/confirm-dialog/confirm-dialog.component';
// import { DisabilityModule } from './admin/disabilities/disability.module';
import { DisabilityService } from './admin/disabilities/disability.service';
// import { ReligionModule } from './admin/religious-group/religion.module';
// import { EthnicCategoryModule } from './admin/ethnic-categories/ethnic-category.module';
import { EReferralModule } from './e-referral/e-referral.module';
import { MAT_DATE_LOCALE, MAT_DATE_FORMATS, DateAdapter } from '@angular/material/core';
import { CustomDateAdapter } from './shared/CustomDateAdapter';
// import { ReferralModule } from './admin/referrals/referral.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import { AppRoutingModule } from './app.routing.module';
import { MenuLoginComponent } from './navigation/menu-login/menu-login.component';
import { NotFoundComponent } from './navigation/not-found/not-found.component';
import { AdminAuthGuard } from './admin/admin.guard';

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
    {provide: DateAdapter, useClass: CustomDateAdapter}
  ],
  bootstrap: [AppComponent],
  schemas: []
})
export class AppModule { }

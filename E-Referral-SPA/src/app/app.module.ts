import { BrowserModule } from '@angular/platform-browser';
import { LOCALE_ID, NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { MaterialModule } from './material.module';
import { GpPracticeModule } from './areas/gp-practices/gp-practice.module';
import { CityModule} from './areas/cities/city.module';

// import { NgxSpinnerModule } from "ngx-spinner";

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
import { EthnicCategoryModule } from './areas/ethnic-categories/ethnic-category.module';
import { EReferralModule } from './areas/e-referral/e-referral.module';
import { MAT_DATE_LOCALE, MAT_DATE_FORMATS, DateAdapter } from '@angular/material/core';
import { CustomDateAdapter } from './shared/CustomDateAdapter';
import { ReferralModule } from './areas/referrals/referral.module';

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
    GpPracticeModule,
    EthnicCategoryModule,
    EReferralModule,
    ReferralModule,
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    [RouterModule.forRoot(rootRouterConfig, {useHash: false})]
  ],

  providers: [
    CityService,
    DisabilityService,
    NotificationService,
    {provide: LOCALE_ID, useValue: 'en-GB'},
    {provide: MAT_DATE_LOCALE, useValue: 'en-GB'},
    {provide: DateAdapter, useClass: CustomDateAdapter}
  ],
  bootstrap: [AppComponent],
  schemas: []
})
export class AppModule { }

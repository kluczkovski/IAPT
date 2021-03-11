import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MaterialModule } from 'src/app/material.module';
import { HttpClientModule } from '@angular/common/http';

import { SignInComponent } from './components/sign-in/sign-in.component';
import { SignUpComponent } from './components/sign-up/sign-up.component';
import { AccountRouterModule } from './account.route';
import { AccountAppComponent } from './account.app.component';
import { AccountService } from './services/account.service';



@NgModule({
  declarations: [
    AccountAppComponent,
    SignInComponent,
    SignUpComponent
  ],
  imports: [
    CommonModule,
    AccountRouterModule,
    MaterialModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers:[
    AccountService
  ]
})
export class AccountModule { }

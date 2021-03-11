import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NotificationService } from 'src/app/shared/services/notification.service';
import { User } from '../../models/user';
import { AccountService } from '../../services/account.service';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.scss']
})
export class SignInComponent implements OnInit {

  loginForm: FormGroup;
  user: User;
  
  constructor(private fb: FormBuilder,
              private accountService: AccountService,
              private notificationService: NotificationService,
              private router: Router) { }

  ngOnInit(): void {
    this.loginForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required]]
    })
  }

  login() {
    if (this.loginForm.dirty && this.loginForm.valid) {
      this.user = Object.assign({}, this.user, this.loginForm.value)
    }

    this.accountService.login(this.user)
      .subscribe(
        (response) =>  {
          this.notificationService.success('Welcome to System')
          this.accountService.LocalStorage.saveDataLocalUser(response)
          this.router.navigate(['/e-referral'])
        },
        error => { this.notificationService.error('Error: ' + error);
      });
  }

}

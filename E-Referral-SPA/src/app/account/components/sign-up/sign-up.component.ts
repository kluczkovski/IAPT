import { AfterViewInit, Component, OnInit } from '@angular/core';
import { validateBasis } from '@angular/flex-layout';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MustMatch } from 'src/app/shared//utils/mustMatch.validator';
import { NotificationService } from 'src/app/shared/services/notification.service';
import { User } from '../../models/user';
import { AccountService } from '../../services/account.service';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.scss']
})
export class SignUpComponent implements OnInit {

  accountRegister: FormGroup;
  user: User;


  constructor(private fb: FormBuilder,
              private accountService: AccountService,
              private notificationService: NotificationService) { }
  
  ngOnInit(): void {
    this.accountRegister = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(6)]],
      confirmPassword: ['', [Validators.required]]
    }, {
      validator: MustMatch('password', 'confirmPassword')
    });
  }

  addUser() {
    if (this.accountRegister.dirty && this.accountRegister.valid) {
      this.user = Object.assign({}, this.user, this.accountRegister.value)
    }

    this.accountService.registerUser(this.user)
      .subscribe(
        (response) =>  {
          this.notificationService.success('The User was added with successed.')
          this.accountService.LocalStorage.saveDataLocalUser(response)
        },
        error => { this.notificationService.error('The User was not added, error: ' + error);
      });
  }

}

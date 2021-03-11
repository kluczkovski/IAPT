import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LocalStorage } from 'src/app/shared/utils/localStorage';

@Component({
  selector: 'app-menu-login',
  templateUrl: './menu-login.component.html',
  styleUrls: ['./menu-login.component.scss']
})
export class MenuLoginComponent implements OnInit {

  token: string = "";
  user: any;
  email: string = "";
  localStorage = new LocalStorage();

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  userLogin(): boolean {
    this.token = this.localStorage.getUserToken();
    this.user = this.localStorage.getUser();

    if(this.user) 
      this.email = this.user.email;

    return this.token !== null;
  }

  logOut() {
    this.localStorage.clearUserData();
    this.router.navigate(['/e-referral'])
  }

}

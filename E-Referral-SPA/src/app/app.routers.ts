import { Routes } from '@angular/router';
import { EReferralComponent } from './areas/e-referral/e-referral.component';
import { UserAddComponent } from './admin/user/user-add/user-add.component';

import { CityListComponent } from './areas/cities/city-list/city-list.component';
import { CityComponent } from './areas/cities/city/city.component';

export const rootRouterConfig: Routes = [
    { path: ' ', redirectTo: '/home', pathMatch: 'full'},
    { path: 'e-referral', component: EReferralComponent},
    { path: 'user', component: UserAddComponent},
    { path: 'city', component: CityListComponent},
    { path: 'city-add', component: CityComponent}
];

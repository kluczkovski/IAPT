import { Routes } from '@angular/router';
import { EReferralComponent } from './areas/e-referral/e-referral.component';
import { UserAddComponent } from './admin/user/user-add/user-add.component';

import { CityListComponent } from './areas/cities/city-list/city-list.component';
import { DisabilityListComponent } from './areas/disabilities/disability-list/disability-list.component';
import { ReligiousGrupListComponent } from './areas/religious-group/religious-grup-list/religious-grup-list.component';
import { CcgListComponent } from './areas/ccgs/ccg-list/ccg-list.component';
export const rootRouterConfig: Routes = [
    { path: ' ', redirectTo: '/home', pathMatch: 'full'},
    { path: 'e-referral', component: EReferralComponent},
    { path: 'user', component: UserAddComponent},
    { path: 'city', component: CityListComponent},
    { path: 'disability', component: DisabilityListComponent},
    { path: 'religion', component: ReligiousGrupListComponent},
    { path: 'ccg', component: CcgListComponent}
];

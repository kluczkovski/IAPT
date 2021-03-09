import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminAppComponent } from './admin.app.component';
import { CcgListComponent } from './ccgs/ccg-list/ccg-list.component';
import { CityListComponent } from './cities/city-list/city-list.component';
import { DisabilityListComponent } from './disabilities/disability-list/disability-list.component';
import { EthnicCategoryListComponent } from './ethnic-categories/ethnic-category-list/ethnic-category-list.component';
import { GpPracticeListComponent } from './gp-practices/gp-practice-list/gp-practice-list.component';
import { ReferralListComponent } from './referrals/referral-list/referral-list.component';
import { ReligiousGrupListComponent } from './religious-group/religious-grup-list/religious-grup-list.component';

const adminRouterConfig: Routes = [
    {
        path: '', component: AdminAppComponent,
        children: [
            { path: 'ccg', component: CcgListComponent},
            { path: 'city', component: CityListComponent },
            { path: 'disability', component: DisabilityListComponent },
            { path: 'ehnicCategory', component: EthnicCategoryListComponent },
            { path: 'gppractice', component: GpPracticeListComponent },
            { path: 'religion', component: ReligiousGrupListComponent},
            { path: 'referral', component: ReferralListComponent}
        ]
    }
]

@NgModule({
    imports: [
        RouterModule.forChild(adminRouterConfig)
    ],
    exports: [RouterModule]
})
export class AdminRouterModule {}
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminAuthGuard } from './admin/admin.guard';
import { EReferralComponent } from './e-referral/e-referral.component';
import { NotFoundComponent } from './navigation/not-found/not-found.component';

const routes : Routes = [
    { path: '', redirectTo: 'e-referral', pathMatch: 'full'},
    { path: 'e-referral', component: EReferralComponent},
    { path: 'account',
        loadChildren: () => import('./account/account.module')
            .then( m => m.AccountModule)
    },
    { path: 'admin',
    loadChildren: () => import('./admin/admin.module')
        .then( m => m.AdminModule),
        canLoad:[AdminAuthGuard]
    },

    { path: '**', component: NotFoundComponent}
]

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
  })
  export class AppRoutingModule { }

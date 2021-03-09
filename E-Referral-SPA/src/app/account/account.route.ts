import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AccountAppComponent } from './account.app.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { SignUpComponent } from './sign-up/sign-up.component';


const accountRouterConfig: Routes = [
    {
        path: '', component: AccountAppComponent,
        children: [
            { path: 'signIn', component: SignInComponent },
            { path: 'signUp', component: SignUpComponent }
        ]
    }
]


@NgModule({
    imports: [
        RouterModule.forChild(accountRouterConfig)
    ],
    exports: [RouterModule]
})
export class AccountRouterModule {}
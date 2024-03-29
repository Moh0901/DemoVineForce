import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddCountryComponent } from 'Components/Country/add-country/add-country.component';
import { EditCountryComponent } from 'Components/Country/edit-country/edit-country.component';
import { AddStateComponent } from 'Components/State/add-state/add-state.component';
import { EditStateComponent } from 'Components/State/edit-state/edit-state.component';
import { GetStateComponent } from 'Components/State/get-state/get-state.component';

const routes: Routes = [
    { path: '', redirectTo: '/app/about', pathMatch: 'full' },
    {
        path: 'account',
        loadChildren: () => import('account/account.module').then(m => m.AccountModule), // Lazy load account module
        data: { preload: true }
    },
    {
        path: 'app',
        loadChildren: () => import('app/app.module').then(m => m.AppModule), // Lazy load account module
        data: { preload: true }
    }, 
    {
        path: 'get-state',
        component: GetStateComponent
    },
    {
        path: 'add-state',
        component: AddStateComponent
    },
    {
        path: 'edit-state',
        component:EditStateComponent
    },
    {
        path: 'add-country',
        component: AddCountryComponent 
    },{
        path: 'edit-country',
        component:EditCountryComponent
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })],
    exports: [RouterModule],
    providers: []
})
export class RootRoutingModule { }

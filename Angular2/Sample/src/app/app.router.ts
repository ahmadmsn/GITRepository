import {ModuleWithProviders} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';

import { CASYTodayComponent }  from './casytoday/casytoday.component';
import { UserComponent }  from './user/user.component';



const appRoutes: Routes = [   
    {path:'casytoday',
    component: CASYTodayComponent
    },
    {
        path: 'user',
        component: UserComponent
    }
];

export const router: ModuleWithProviders = RouterModule.forRoot(appRoutes);




import { Component } from '@angular/core';
import { ChildComponent } from './child/child.component';
import { SecurityCheck } from './common/SecurityCheck';
import { CanDeactivateGuard } from './common/can-deactivate-guard';
import { ParentComponent } from './parent/parent.component';
import { PatientAddComponent } from './patient_add/PatientAdd.component';
import { PatientLoginComponent } from './patient_login/PatientLogin.component';
import { UsersComponent } from './users/users.component';
import { RxjsOperatorComponent } from './rxjs-operator/rxjs-operator.component';

export const AppRoutes = [
  { path: 'Login', component: PatientLoginComponent },
  { path: 'parent',
    component: ParentComponent,
      canDeactivate:[CanDeactivateGuard]
   },
  { path: 'child', component: ChildComponent },
  { path: 'users', component: UsersComponent },
  {
    path: 'AddPatient',
    component: PatientAddComponent,
    canActivate: [SecurityCheck],
  },
  {
    path:'rxjs',
    component:RxjsOperatorComponent
  }
];

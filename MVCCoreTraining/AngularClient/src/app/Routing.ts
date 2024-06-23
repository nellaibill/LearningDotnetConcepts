import { HomepageComponent } from "./Homepage.component";
import { PatientAddComponent } from "./PatientAdd.component";
import { PatientLoginComponent } from "./PatientLogin.component";
import { SecurityCheck } from "./common/SecurityCheck";
import { ParentComponent } from "./parent/parent.component";

export const AppRoutes=[
  {path:'Login',component: PatientLoginComponent},
  {path:'parent',component: ParentComponent},
  {path:'AddPatient',component: PatientAddComponent,
    canActivate :[SecurityCheck]
  }
]

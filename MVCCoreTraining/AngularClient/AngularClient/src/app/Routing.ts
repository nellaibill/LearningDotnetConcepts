import { HomepageComponent } from "./Homepage.component";
import { PatientAddComponent } from "./PatientAdd.component";
import { PatientLoginComponent } from "./PatientLogin.component";
import { SecurityCheck } from "./common/SecurityCheck";

export const AppRoutes=[
  {path:'',component: HomepageComponent},
  {path:'Login',component: PatientLoginComponent},
  {path:'AddPatient',component: PatientAddComponent,
    canActivate :[SecurityCheck]
  }
]

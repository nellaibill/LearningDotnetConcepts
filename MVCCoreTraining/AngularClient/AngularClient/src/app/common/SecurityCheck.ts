import { Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot } from "@angular/router";
import { SalJWTToken } from "./Security";

@Injectable()
export class SecurityCheck implements CanActivate {
    constructor(
        private router: Router,public _token : SalJWTToken) { }
    canActivate(
        route: ActivatedRouteSnapshot,
        state: RouterStateSnapshot): boolean | Promise<boolean> {

        if (this._token.value.length!=0) {
         return true;
        }
        this.router.navigate(['/Login']);
        return false;
    }
}

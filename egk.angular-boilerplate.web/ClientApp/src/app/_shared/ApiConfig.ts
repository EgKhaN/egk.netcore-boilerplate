import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';

@Injectable()

export class ApiConfig {
    constructor(private controllerName= 'test') {
    }

    readonly Base = environment.runFromdocker ? environment.docker.url : environment.app.url;

    readonly GetAll = this.Base + `${this.controllerName}`;
    readonly Get = this.Base + `${this.controllerName}/{ID}`;
    readonly Create = this.Base + `${this.controllerName}`;
    readonly Update = this.Base + `${this.controllerName}/{ID}`;
    readonly Delete = this.Base+ `${this.controllerName}/{ID}`;

    static readonly TestControllerName = 'test';

}

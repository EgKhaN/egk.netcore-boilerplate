import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { IGenericService } from './IGenericService';
import { ApiConfig } from '../ApiConfig';
import { Operation } from "fast-json-patch";

export abstract class GenericService<T, ID> implements IGenericService<T, ID> {

  apiConfig;
  constructor(
    private _http: HttpClient,
    private controllerName: string,
  ) {
    this.apiConfig = new ApiConfig(controllerName);
  }

  get(id: ID): Observable<T> {
    return this._http.get<T>(this.apiConfig.Get.replace('{ID}',id as any));
  }

  getAll(): Observable<T[]> {
    return this._http.get<T[]>(this.apiConfig.GetAll)
  }

  save(t: T): Observable<T> {
    return this._http.post<T>(this.apiConfig.Create, t);
  }

  update(id: ID, t: T): Observable<T> {
    return this._http.put<T>(this.apiConfig.Update.replace('{ID}',id as any), t, {});
  }

  patch(id: ID, operations: Operation[]): Observable<T> {
    return this._http.patch<T>(this.apiConfig.Patch.replace('{ID}',id as any), operations, {});
  }


  delete(id: ID): Observable<T> {
    return this._http.delete<T>(this.apiConfig.Delete.replace('{ID}',id as any));
  }

}

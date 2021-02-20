import { Observable } from 'rxjs';

export interface IGenericService<T, ID> {
  get(id: ID): Observable<T>;
  getAll(): Observable<T[]>;
  save(t: T): Observable<T>;
  update(id: ID, t: T): Observable<T>;
  delete(id: ID): Observable<any>;
}
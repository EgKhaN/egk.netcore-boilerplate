import { Observable } from 'rxjs';
import { Operation } from 'fast-json-patch';

export interface IGenericService<T, ID> {
  get(id: ID): Observable<T>;
  getAll(): Observable<T[]>;
  save(t: T): Observable<T>;
  update(id: ID, t: T): Observable<T>;
  patch(id: ID, operations: Operation[]): Observable<T>;
  delete(id: ID): Observable<any>;
}

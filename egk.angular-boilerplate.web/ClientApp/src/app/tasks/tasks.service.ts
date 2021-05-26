import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Task } from '../_model/task';
import { ApiConfig } from '../_shared/ApiConfig';
import { GenericService } from '../_shared/Service/GenericService';

@Injectable({
  providedIn: 'root'
})
export class TaskService extends GenericService<Task,number> {
  constructor(private http: HttpClient) {
      super(http , ApiConfig.TaskControllerName);
  }

  getAllByProjectId(projectId : number): Observable<Task[]> {
    return this.http.get<Task[]>(this.apiConfig.GetAllTasksByProjectId.replace('{projectId}',projectId as any))
  }
}

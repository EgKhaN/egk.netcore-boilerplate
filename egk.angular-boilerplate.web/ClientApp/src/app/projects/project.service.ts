import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Project } from '../_model/project';
import { ApiConfig } from '../_shared/ApiConfig';
import { GenericService } from '../_shared/Service/GenericService';

@Injectable({
  providedIn: 'root'
})
export class ProjectService extends GenericService<Project,number> {
  constructor(private http: HttpClient) {
      super(http , ApiConfig.ProjectControllerName);
  }
}

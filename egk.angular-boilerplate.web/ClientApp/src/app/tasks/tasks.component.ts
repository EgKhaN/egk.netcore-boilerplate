import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ProjectService } from '../projects/project.service';
import { Project } from '../_model/project';
import { Task } from '../_model/task';
import { TaskService } from './tasks.service';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.css']
})
export class TasksComponent implements OnInit {

  taskArray : Task[] =[];
  task: Task;
  taskForm = new FormGroup({});
  projectArray : Project[] =[];
  selectedProjectId : number;

  constructor(private taskService : TaskService, private projectService: ProjectService) {
    this.selectedProjectId = 1;
  }

  ngOnInit() : void {
    this.getTasksByProjectId();
    this.getProjects();
  }

  getTasks() {
    this.taskService.getAll().subscribe(tasks => {
      this.taskArray = tasks;
      console.log("tasks",tasks);
    });
  }

  getTasksByProjectId() {
    this.taskService.getAllByProjectId(this.selectedProjectId).subscribe(tasks => {
      this.taskArray = tasks;
      console.log("tasks",tasks);
    });
  }

  async addTask(value){
    if(value!==""){
      this.task = new Task();
    this.task = {
      Title : value,
      ProjectId : this.selectedProjectId,
      ...this.task
    };
    //  this.taskArray.push(this.task)
     this.taskForm.reset()

    //  console.log(this.taskArray);
    this.taskService.save(this.task).subscribe( task => {
      console.log("Saved with Id: ", task.Id);
      this.getTasksByProjectId();
    });
  }else{
    alert('Field required **')
  }

  }

  /*delete item*/
  deleteItem(task){
    this.taskService.delete(task.Id).subscribe(result => {
      console.log("silindi");
      this.getTasksByProjectId();
    });
  	// for(let i=0 ;i<= this.taskArray.length ;i++){
  	// 	if(task== this.taskArray[i]){
  	// 		this.taskArray.splice(i,1)
  	// 	}
  	// }

  }

  // submit Form
  saveTask(value:any){
     if(value!==""){
    this.taskArray.push(value.todo)
     //this.todoForm.reset()
    }else{
      alert('Field required **')
    }
  }

  updateIsDone(event , task: Task) {
    let isChecked = event.srcElement.checked;
    task.IsDone = isChecked;
    this.taskService.update(task.Id , task).subscribe( result =>
      {
        console.log("updated");
        this.getTasksByProjectId();
      }
    );
  }

  getProjects() {
    this.projectService.getAll().subscribe(projects => {
      this.projectArray = projects;
      console.log("projects",projects);
    });
  }

  onProjectChange(event){
    this.selectedProjectId = event.target.value;
    // console.log("selectedProjectId", this.selectedProjectId);
    this.getTasksByProjectId();
  }

}

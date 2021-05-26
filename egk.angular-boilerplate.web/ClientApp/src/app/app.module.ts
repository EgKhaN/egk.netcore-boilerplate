import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductService } from './product/product.service';
import { ProductComponent } from './product/product.component';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { ProductsComponent } from './product/products/products.component';
import { ReactiveFormsModule } from '@angular/forms';
import { CommonService } from './_shared/Service/CommonService';
import { TasksComponent } from './tasks/tasks.component';
import { TaskService } from './tasks/tasks.service';
import { ProjectService } from './projects/project.service';
import { ProjectsComponent } from './projects/projects.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductComponent,
    ProductsComponent,
    TasksComponent,
    ProjectsComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    CommonModule,
    ReactiveFormsModule
  ],
  providers: [ProductService , CommonService, TaskService, ProjectService],
  bootstrap: [AppComponent]
})
export class AppModule { }

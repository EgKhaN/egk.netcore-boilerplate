import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductService } from './product.service';
import { ProductComponent } from './product/product.component';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { ProductsComponent } from './product/products/products.component';
import { ReactiveFormsModule } from '@angular/forms';
import { CommonService } from './_shared/Service/CommonService';

@NgModule({
  declarations: [
    AppComponent,
    ProductComponent,
    ProductsComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    CommonModule,
    ReactiveFormsModule
  ],
  providers: [ProductService , CommonService],
  bootstrap: [AppComponent]
})
export class AppModule { }

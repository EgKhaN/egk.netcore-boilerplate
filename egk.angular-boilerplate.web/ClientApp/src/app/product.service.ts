import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from './_model/product';
import { ApiConfig } from './_shared/ApiConfig';
import { GenericService } from './_shared/Service/GenericService';

@Injectable({
  providedIn: 'root'
})
export class ProductService extends GenericService<Product,number> {
  constructor(private http: HttpClient) {
      super(http , ApiConfig.TestControllerName);
  }
}

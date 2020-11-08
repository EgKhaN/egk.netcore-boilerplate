import { Component } from '@angular/core';
import { ProductService } from './product.service';
import { Product } from './_model/product';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  products: Product[];
  title = 'egk-angular-boilerplate';

  constructor(private productService: ProductService) { }
  ngOnInit(): void {
    this.getProducts();
    
  }
    getProducts () {
  this.productService.getAll().subscribe( (data) => {
    this.products = data;
  });
  }
}

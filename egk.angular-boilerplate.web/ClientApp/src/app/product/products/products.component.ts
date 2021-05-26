import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ProductService } from 'src/app/product/product.service';
import { Product } from 'src/app/_model/product';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  products: Product[];

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

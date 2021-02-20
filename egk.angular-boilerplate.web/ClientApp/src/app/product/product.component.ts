import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router, RouterEvent } from '@angular/router';
import { ProductService } from '../product.service';
import { Product } from '../_model/product';
import { FormBuilder, Validators } from '@angular/forms';
import { CommonService } from '../_shared/Service/CommonService';


@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  product: Product;
  productID: number;
  submitted: false;

  productForm = this.formBuilder.group({
    productName: ['' , [Validators.required] ],
    unitPrice: [0 , [Validators.required, Validators.pattern("^[0-9]*$")] ]
  });

  constructor(private productService: ProductService,private route: ActivatedRoute, private formBuilder: FormBuilder , private commonService : CommonService) {
    this.route.paramMap.subscribe(params => {
      this.productID = +params.get("id");
      this.getProduct();
    })
}

  ngOnInit(): void {
  }

  getProduct () {
    this.productService.get(this.productID).subscribe( (data) => {
      this.product = data;
      // console.log('product :>> ', this.product);
      this.productForm.patchValue(this.product);

    });
}

onSubmit() {
  if (this.productForm.invalid) {
    return;
  }
  const patch = this.commonService.createPatch(this.product, this.productForm.value);
  this.productService.patch(this.productID, patch).subscribe( item =>  {this.productForm.patchValue(item);});
  // this.onReset();
}

onReset() {
  this.submitted = false;
  this.productForm.reset();
}

}

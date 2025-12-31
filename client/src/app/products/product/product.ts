import { Component, Input } from '@angular/core';
import { ProductModel } from '../../_models/productModel';
import { CurrencyPipe } from '@angular/common';

@Component({
  selector: 'app-product',
  imports: [CurrencyPipe],
  templateUrl: './product.html',
  styleUrl: './product.css',
})
export class Product {
  @Input()
  product: ProductModel = {
    id: 0,
    name: '',
    description: '',
    tnc: '',
    price: 0
  };

  onProductClick(productId: number)
  {
    alert("Clicked on ProductId " + productId);
  }
}

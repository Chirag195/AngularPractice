import { Component, EventEmitter, Output } from '@angular/core';
import { ProductSearch } from "../product-search/product-search";
import { Productlist } from '../productlist/productlist';

@Component({
  selector: 'app-product-page',
  imports: [ProductSearch, Productlist],
  templateUrl: './product-page.html',
  styleUrl: './product-page.css',
})
export class ProductPage {
  searchValue: string = '';

  UpdateSearchFilterValue(value: string)
  {
    this.searchValue = value;
  }
}

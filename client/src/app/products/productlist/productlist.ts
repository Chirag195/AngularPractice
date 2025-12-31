import { Component, Input, } from '@angular/core';
import { ProductModel } from '../../_models/productModel';
import { FormsModule } from '@angular/forms';
import { Product } from '../product/product';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-productlist',
  imports: [FormsModule, Product, CommonModule],
  templateUrl: './productlist.html',
  styleUrl: './productlist.css',
})
export class Productlist {
  @Input()
  searchValue:string = '';

  products: ProductModel[];

  constructor()
  {
    this.products = [
      {id:1, name: "Oven", description: "A Durable Oven", tnc: "physical damage can make warranty invalid", price: 10000},
      {id:2, name: "iPhone", description: "iPhone 17 Pro Max", tnc: "physical damage can make warranty invalid", price: 10000},
      {id:3, name: "Laptop", description: "A Durable Laptop", tnc: "physical damage can make warranty invalid", price: 10000},
      {id:4, name: "Fridge", description: "Double Door Fridge", tnc: "physical damage can make warranty invalid", price: 10000},
    ];
  }
}

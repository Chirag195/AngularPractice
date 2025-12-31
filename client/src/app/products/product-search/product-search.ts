import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-product-search',
  imports: [FormsModule],
  templateUrl: './product-search.html',
  styleUrl: './product-search.css',
})
export class ProductSearch {
  @Output()
  searchEvent: EventEmitter<string> = new EventEmitter<string>();

  searchQuery: string = '';

  onClick()
  {
    this.searchEvent.emit(this.searchQuery);
  }
}

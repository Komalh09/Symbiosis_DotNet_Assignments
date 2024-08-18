import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-item-transfer',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './item-transfer.component.html',
  styleUrl: './item-transfer.component.css'
})
export class ItemTransferComponent {

  availableItems: string[] = ['Item 1', 'Item 2', 'Item 3', 'Item 4', 'Item 5'];
  selectedItems: string[] = [];

  // Move item to selected list
  transferToSelected(item: string): void {
    this.selectedItems.push(item);
    this.availableItems = this.availableItems.filter(i => i !== item);
  }

  // Move item back to available list
  transferToAvailable(item: string): void {
    this.availableItems.push(item);
    this.selectedItems = this.selectedItems.filter(i => i !== item);
  }
}



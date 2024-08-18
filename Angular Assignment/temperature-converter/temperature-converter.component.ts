import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-temperature-converter',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './temperature-converter.component.html',
  styleUrl: './temperature-converter.component.css'
})
export class TemperatureConverterComponent {

  celsius: number | null = null;
  fahrenheit: number | null = null;

  // Converts Celsius to Fahrenheit
  convertToFahrenheit(): void {
    if (this.celsius !== null) {
      this.fahrenheit = (this.celsius * 9/5) + 32;
    }
  }

  // Converts Fahrenheit to Celsius
  convertToCelsius(): void {
    if (this.fahrenheit !== null) {
      this.celsius = (this.fahrenheit - 32) * 5/9;
    }
  }

  // Clears the input fields
  clearFields(): void {
    this.celsius = null;
    this.fahrenheit = null;
  }
}


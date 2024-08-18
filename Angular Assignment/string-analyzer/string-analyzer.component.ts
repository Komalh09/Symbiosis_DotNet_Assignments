import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { StringAnalyzerService } from '../string-analyzer.service';

@Component({
  selector: 'app-string-analyzer',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './string-analyzer.component.html',
  styleUrl: './string-analyzer.component.css'
})
export class StringAnalyzerComponent {

  inputString: string = '';
  mostRepetitiveChar: string | null = null;

  constructor(private stringAnalyzerService: StringAnalyzerService) {}

  analyzeString() {
    this.mostRepetitiveChar = this.stringAnalyzerService.findMostRepetitiveChar(this.inputString);
  }
}


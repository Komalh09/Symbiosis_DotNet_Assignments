import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StringAnalyzerService {

  constructor() { }

  findMostRepetitiveChar(inputString: string): string | null {
    if (!inputString) return null;

    const charCount: { [key: string]: number } = {};
    let maxCount = 0;
    let mostRepetitiveChar: string | null = null;

    for (let char of inputString) {
      char = char.toLowerCase();
      charCount[char] = (charCount[char] || 0) + 1;

      if (charCount[char] > maxCount) {
        maxCount = charCount[char];
        mostRepetitiveChar = char;
      }
    }

    return mostRepetitiveChar;
  }
}


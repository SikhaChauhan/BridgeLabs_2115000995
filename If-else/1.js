// Generate 5 random 3-digit numbers
let num1 = Math.floor(Math.random() * 900) + 100;
let num2 = Math.floor(Math.random() * 900) + 100;
let num3 = Math.floor(Math.random() * 900) + 100;
let num4 = Math.floor(Math.random() * 900) + 100;
let num5 = Math.floor(Math.random() * 900) + 100;

console.log("Generated Numbers:", num1, num2, num3, num4, num5);

// Initialize min and max with the first value
let min = num1;
let max = num1;

// Find the minimum value
if (num2 < min) min = num2;
if (num3 < min) min = num3;
if (num4 < min) min = num4;
if (num5 < min) min = num5;

// Find the maximum value
if (num2 > max) max = num2;
if (num3 > max) max = num3;
if (num4 > max) max = num4;
if (num5 > max) max = num5;

// Output the results
console.log("Minimum Value:", min);
console.log("Maximum Value:", max);

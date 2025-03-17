// Generate 5 random two-digit numbers (between 10 and 99)
const numbers = Array.from({ length: 5 }, () => Math.floor(Math.random() * 90) + 10);

// Calculate the sum of the numbers
const sum = numbers.reduce((acc, num) => acc + num, 0);

// Calculate the average
const average = sum / numbers.length;

console.log("Random 2-digit numbers:", numbers);
console.log("Sum:", sum);
console.log("Average:", average);

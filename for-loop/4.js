// Import readline module for user input
const readline = require('readline');

// Create input interface
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

// Function to check if a number is prime
function isPrime(num) {
  if (num <= 1) return false; // Numbers <= 1 are not prime
  if (num === 2) return true; // 2 is a prime number
  for (let i = 2; i <= Math.sqrt(num); i++) {
    if (num % i === 0) return false; // If divisible, not a prime
  }
  return true; // Otherwise, it's prime
}

// Function to find and print prime numbers in a range
function printPrimesInRange(start, end) {
  console.log(`Prime numbers between ${start} and ${end}:`);
  for (let i = start; i <= end; i++) {
    if (isPrime(i)) {
      process.stdout.write(i + " "); // Print prime numbers on the same line
    }
  }
  console.log(); // New line after printing primes
}

// Prompt user for input range
rl.question("Enter the starting number of the range: ", (startInput) => {
  rl.question("Enter the ending number of the range: ", (endInput) => {
    const start = parseInt(startInput);
    const end = parseInt(endInput);

    // Validate input
    if (isNaN(start) || isNaN(end) || start > end) {
      console.log("Please enter valid numbers with start <= end.");
    } else {
      printPrimesInRange(start, end);
    }

    rl.close();
  });
});

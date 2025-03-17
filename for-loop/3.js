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
  if (num === 2) return true; // 2 is the only even prime number
  for (let i = 2; i <= Math.sqrt(num); i++) {
    if (num % i === 0) return false; // If divisible, not a prime
  }
  return true; // Otherwise, it's prime
}

// Prompt user for input
rl.question("Enter a number to check if it's prime: ", (input) => {
  const num = parseInt(input);

  if (isNaN(num)) {
    console.log("Please enter a valid number.");
  } else if (isPrime(num)) {
    console.log(`${num} is a prime number.`);
  } else {
    console.log(`${num} is not a prime number.`);
  }

  rl.close();
});

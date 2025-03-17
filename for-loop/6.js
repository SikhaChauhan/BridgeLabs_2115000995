// Import readline module for user input
const readline = require('readline');

// Create input interface
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

// Function to compute prime factors
function primeFactors(n) {
  console.log(`Prime factors of ${n}:`);

  // Step 1: Divide by 2 until n is odd
  while (n % 2 === 0) {
    process.stdout.write("2 ");
    n = Math.floor(n / 2);
  }

  // Step 2: Check for odd factors from 3 to √n
  for (let i = 3; i * i <= n; i += 2) {
    while (n % i === 0) {
      process.stdout.write(i + " ");
      n = Math.floor(n / i);
    }
  }

  // Step 3: If n is a prime number greater than 2
  if (n > 2) {
    process.stdout.write(n + " ");
  }

  console.log(); // For new line
}

// Prompt user for input
rl.question("Enter a number to find its prime factors: ", (input) => {
  const num = parseInt(input);

  if (isNaN(num) || num <= 1) {
    console.log("Please enter a valid number greater than 1.");
  } else {
    primeFactors(num);
  }

  rl.close();
});

// Import readline module for user input
const readline = require('readline');

// Create input interface
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

// Function to calculate factorial
function calculateFactorial(n) {
  let factorial = 1;
  for (let i = 1; i <= n; i++) {
    factorial *= i; // Multiply each number up to 'n'
  }
  return factorial;
}

// Prompt user for input
rl.question("Enter a number to calculate its factorial: ", (input) => {
  const num = parseInt(input);

  if (isNaN(num) || num < 0) {
    console.log("Please enter a valid non-negative number.");
  } else {
    console.log(`${num}! = ${calculateFactorial(num)}`);
  }

  rl.close();
});

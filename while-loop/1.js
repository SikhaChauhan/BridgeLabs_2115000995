// Import readline module for user input
const readline = require('readline');

// Create input interface
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

// Function to print powers of 2 up to 2^n or 256
function printPowersOfTwo(n) {
  let power = 0;
  let result = 1; // 2^0 = 1

  console.log(`Powers of 2 up to 2^${n} or 256:`);

  // Continue until power <= n and result <= 256
  while (power <= n && result <= 256) {
    console.log(`2^${power} = ${result}`);
    power++;
    result = Math.pow(2, power); // Calculate the next power of 2
  }
}

// Prompt user for input
rl.question("Enter the value of n: ", (input) => {
  const n = parseInt(input);

  if (isNaN(n) || n < 0) {
    console.log("Please enter a valid non-negative integer.");
  } else {
    printPowersOfTwo(n);
  }

  rl.close();
});

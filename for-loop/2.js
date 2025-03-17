// Get the command-line argument and convert it to an integer
const n = parseInt(process.argv[2]);

// Validate input: Ensure it's a positive integer
if (isNaN(n) || n <= 0) {
  console.log("Please enter a valid positive integer.");
  process.exit(1);
}

let harmonicNumber = 0;

// Calculate the nth harmonic number using a for loop
for (let i = 1; i <= n; i++) {
  harmonicNumber += 1 / i;
}

console.log(`The ${n}th harmonic number is: ${harmonicNumber.toFixed(6)}`);

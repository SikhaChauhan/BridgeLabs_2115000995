// Import readline module for user input
const readline = require('readline');

// Create input interface
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

// Function to find the magic number
function findMagicNumber() {
  let low = 1;
  let high = 100;

  console.log("Think of a number between 1 and 100.");

  while (low <= high) {
    let mid = Math.floor((low + high) / 2);
    console.log(`Is your number ${mid}?`);

    rl.question("Enter (L) if it's lower, (H) if it's higher, (Y) if it's correct: ", (answer) => {
      answer = answer.toUpperCase();

      if (answer === 'Y') {
        console.log(`Magic Number Found: ${mid}`);
        rl.close();
      } else if (answer === 'L') {
        high = mid - 1; // Number is smaller
      } else if (answer === 'H') {
        low = mid + 1; // Number is larger
      } else {
        console.log("Invalid input. Please enter 'L', 'H', or 'Y'.");
      }

      if (low > high) {
        console.log("Oops! Something went wrong.");
        rl.close();
      }
    });
  }
}

// Start the magic number game
findMagicNumber();

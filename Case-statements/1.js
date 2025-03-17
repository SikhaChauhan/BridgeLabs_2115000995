// Get the number from the command line argument
const number = parseInt(process.argv[2]);

// Validate input: Ensure it's a single-digit number (0-9)
if (isNaN(number) || number < 0 || number > 9) {
  console.log("Please enter a valid single-digit number (0-9).");
  process.exit(1);
}

// Convert number to word using switch case
let numberInWord;

switch (number) {
  case 0:
    numberInWord = "Zero";
    break;
  case 1:
    numberInWord = "One";
    break;
  case 2:
    numberInWord = "Two";
    break;
  case 3:
    numberInWord = "Three";
    break;
  case 4:
    numberInWord = "Four";
    break;
  case 5:
    numberInWord = "Five";
    break;
  case 6:
    numberInWord = "Six";
    break;
  case 7:
    numberInWord = "Seven";
    break;
  case 8:
    numberInWord = "Eight";
    break;
  case 9:
    numberInWord = "Nine";
    break;
  default:
    numberInWord = "Invalid input";
}

// Output the result
console.log(`The number ${number} in words is: ${numberInWord}`);

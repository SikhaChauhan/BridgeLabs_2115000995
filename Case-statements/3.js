// Get the number from the command line argument
const number = parseInt(process.argv[2]);

// Validate input: Ensure the number is a valid power of 10 (1, 10, 100, etc.)
if (isNaN(number) || ![1, 10, 100, 1000, 10000, 100000, 1000000].includes(number)) {
  console.log("Please enter a valid number (1, 10, 100, 1000, etc.).");
  process.exit(1);
}

// Map numbers to their place value using switch-case
let placeValue;

switch (number) {
  case 1:
    placeValue = "Unit";
    break;
  case 10:
    placeValue = "Ten";
    break;
  case 100:
    placeValue = "Hundred";
    break;
  case 1000:
    placeValue = "Thousand";
    break;
  case 10000:
    placeValue = "Ten Thousand";
    break;
  case 100000:
    placeValue = "Lakh";
    break;
  case 1000000:
    placeValue = "Ten Lakh";
    break;
  default:
    placeValue = "Invalid Input";
}

// Output the corresponding place value
console.log(`The place value for ${number} is: ${placeValue}`);

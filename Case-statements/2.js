// Get the number from the command line argument
const dayNumber = parseInt(process.argv[2]);

// Validate input: Ensure it's a number between 1 and 7
if (isNaN(dayNumber) || dayNumber < 1 || dayNumber > 7) {
  console.log("Please enter a valid number between 1 and 7.");
  process.exit(1);
}

// Map number to corresponding weekday using switch-case
let weekDay;

switch (dayNumber) {
  case 1:
    weekDay = "Sunday";
    break;
  case 2:
    weekDay = "Monday";
    break;
  case 3:
    weekDay = "Tuesday";
    break;
  case 4:
    weekDay = "Wednesday";
    break;
  case 5:
    weekDay = "Thursday";
    break;
  case 6:
    weekDay = "Friday";
    break;
  case 7:
    weekDay = "Saturday";
    break;
  default:
    weekDay = "Invalid Input";
}

// Output the corresponding weekday
console.log(`The day corresponding to ${dayNumber} is: ${weekDay}`);

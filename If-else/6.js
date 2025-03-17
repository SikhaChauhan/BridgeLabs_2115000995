// Read a number (input from command-line argument)
const number = parseInt(process.argv[2]);

// Check the number and print the corresponding weekday
if (number === 1) {
    console.log("Sunday");
} else if (number === 2) {
    console.log("Monday");
} else if (number === 3) {
    console.log("Tuesday");
} else if (number === 4) {
    console.log("Wednesday");
} else if (number === 5) {
    console.log("Thursday");
} else if (number === 6) {
    console.log("Friday");
} else if (number === 7) {
    console.log("Saturday");
} else {
    console.log("Invalid input! Please enter a number between 1 and 7.");
}

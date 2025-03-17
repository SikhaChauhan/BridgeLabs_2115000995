const prompt = require('prompt-sync')(); // To take user input

// Display options to user
console.log("Unit Conversion:");
console.log("1. Feet to Inch");
console.log("2. Feet to Meter");
console.log("3. Inch to Feet");
console.log("4. Meter to Feet");

// Take user input
const choice = parseInt(prompt("Enter your choice (1-4): "));
const value = parseFloat(prompt("Enter the value to convert: "));

// Perform conversion based on user choice
if (choice === 1) {
    console.log(`${value} feet = ${value * 12} inches`);
} else if (choice === 2) {
    console.log(`${value} feet = ${value * 0.3048} meters`);
} else if (choice === 3) {
    console.log(`${value} inches = ${value / 12} feet`);
} else if (choice === 4) {
    console.log(`${value} meters = ${value * 3.28084} feet`);
} else {
    console.log("Invalid choice! Please select between 1 and 4.");
}

const readline = require('readline');

// Create input interface
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

// Display menu for unit conversion
console.log("Unit Conversion Menu:");
console.log("1. Feet to Inch");
console.log("2. Feet to Meter");
console.log("3. Inch to Feet");
console.log("4. Meter to Feet");

// Function to handle unit conversion
rl.question("Select an option (1-4): ", (choice) => {
  rl.question("Enter the value to convert: ", (value) => {
    value = parseFloat(value);
    let result;

    if (isNaN(value)) {
      console.log("Please enter a valid number.");
      rl.close();
      return;
    }

    switch (parseInt(choice)) {
      case 1:
        result = value * 12; // Feet to Inch
        console.log(`${value} Feet is ${result} Inches.`);
        break;
      case 2:
        result = value * 0.3048; // Feet to Meter
        console.log(`${value} Feet is ${result.toFixed(4)} Meters.`);
        break;
      case 3:
        result = value / 12; // Inch to Feet
        console.log(`${value} Inches is ${result.toFixed(4)} Feet.`);
        break;
      case 4:
        result = value / 0.3048; // Meter to Feet
        console.log(`${value} Meters is ${result.toFixed(4)} Feet.`);
        break;
      default:
        console.log("Invalid option. Please select between 1 and 4.");
    }

    rl.close();
  });
});

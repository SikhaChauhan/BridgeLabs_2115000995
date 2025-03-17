// Get year from command-line argument
const year = parseInt(process.argv[2]);

// Check if year is a 4-digit number
if (year >= 1000 && year <= 9999) {
    // Leap year conditions:
    // 1. Divisible by 4 AND NOT divisible by 100
    // 2. OR Divisible by 400
    if ((year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0)) {
        console.log(year + " is a Leap Year");
    } else {
        console.log(year + " is NOT a Leap Year");
    }
} else {
    console.log("Please enter a valid 4-digit year.");
}

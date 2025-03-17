// a. Convert 42 inches to feet
const inches = 42;
const feet = inches / 12;
console.log(`a. ${inches} inches is ${feet.toFixed(2)} feet`);

// b. Convert Rectangular Plot (60 feet x 40 feet) to meters
const lengthFeet = 60;
const widthFeet = 40;
const feetToMeters = 0.3048; // 1 foot = 0.3048 meters

const lengthMeters = lengthFeet * feetToMeters;
const widthMeters = widthFeet * feetToMeters;
console.log(`b. Rectangular Plot: ${lengthMeters.toFixed(2)}m x ${widthMeters.toFixed(2)}m`);

// c. Calculate the area of 25 such plots in acres
const areaOnePlotFeet = lengthFeet * widthFeet; // Area in square feet
const totalAreaFeet = areaOnePlotFeet * 25; // Area of 25 plots in square feet
const squareFeetToAcre = 43560; // 1 Acre = 43,560 square feet
const areaInAcres = totalAreaFeet / squareFeetToAcre;

console.log(`c. Area of 25 plots in acres: ${areaInAcres.toFixed(4)} acres`);

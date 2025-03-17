// Generate two random dice numbers between 1 and 6
const dice1 = Math.floor(Math.random() * 6) + 1;
const dice2 = Math.floor(Math.random() * 6) + 1;

// Calculate the sum of both dice
const sum = dice1 + dice2;

console.log(`Dice 1: ${dice1}, Dice 2: ${dice2}, Sum: ${sum}`);
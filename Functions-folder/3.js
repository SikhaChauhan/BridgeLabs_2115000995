// Function to check if a number is prime
function isPrime(num) {
    if (num <= 1) return false;
    for (let i = 2; i <= Math.sqrt(num); i++) {
      if (num % i === 0) return false;
    }
    return true;
  }
  
  // Function to find the palindrome of a number
  function getPalindrome(num) {
    return parseInt(num.toString().split('').reverse().join(''));
  }
  
  // Main function to check the conditions
  function checkPrimeAndPalindrome(num) {
    if (!isPrime(num)) {
      console.log(`${num} is NOT a prime number.`);
      return;
    }
  
    console.log(`${num} is a prime number.`);
    const palindrome = getPalindrome(num);
  
    console.log(`Palindrome of ${num} is ${palindrome}.`);
  
    if (isPrime(palindrome)) {
      console.log(`Palindrome ${palindrome} is also a prime number.`);
    } else {
      console.log(`Palindrome ${palindrome} is NOT a prime number.`);
    }
  }
  
  // Example Usage
  checkPrimeAndPalindrome(13);  // Outputs both prime checks
  checkPrimeAndPalindrome(101); // Outputs both prime checks
  
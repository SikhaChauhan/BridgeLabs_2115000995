// Function to check if a number is a palindrome
function isPalindrome(num) {
    const original = num.toString();
    const reversed = original.split('').reverse().join('');
    return original === reversed;
  }
  
  // Example Usage
  const num1 = 121;
  const num2 = 123;
  
  console.log(`${num1} is a palindrome?`, isPalindrome(num1)); // true
  console.log(`${num2} is a palindrome?`, isPalindrome(num2)); // false
  
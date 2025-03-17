// Function to convert Celsius to Fahrenheit
function celsiusToFahrenheit(celsius) {
    if (celsius < 0 || celsius > 100) {
      console.log("Invalid input! Enter a value between 0°C and 100°C.");
      return;
    }
    return (celsius * 9 / 5) + 32;
  }
  
  // Function to convert Fahrenheit to Celsius
  function fahrenheitToCelsius(fahrenheit) {
    if (fahrenheit < 32 || fahrenheit > 212) {
      console.log("Invalid input! Enter a value between 32°F and 212°F.");
      return;
    }
    return (fahrenheit - 32) * 5 / 9;
  }
  
  // User Input Simulation
  function temperatureConversion(choice, value) {
    switch (choice) {
      case 'CtoF':
        console.log(`${value}°C = ${celsiusToFahrenheit(value)}°F`);
        break;
      case 'FtoC':
        console.log(`${value}°F = ${fahrenheitToCelsius(value)}°C`);
        break;
      default:
        console.log("Invalid choice! Use 'CtoF' or 'FtoC'.");
    }
  }
  
  // Example Usage
  temperatureConversion('CtoF', 25); 
  temperatureConversion('FtoC', 98); 
  
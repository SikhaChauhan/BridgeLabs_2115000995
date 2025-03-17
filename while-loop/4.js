// Function to simulate the gambler's betting game
function gamble() {
    let money = 100;      // Starting amount
    const goal = 200;     // Goal amount
    let wins = 0;         // Track number of wins
    let bets = 0;         // Track number of bets
  
    while (money > 0 && money < goal) {
      bets++;
  
      // Simulate a bet (50% chance to win or lose)
      let betResult = Math.random() < 0.5 ? -1 : 1;
  
      // Update money based on win/loss
      money += betResult;
  
      // If won, increment win counter
      if (betResult === 1) {
        wins++;
      }
    }
  
    // Display game results
    console.log(`Final Amount: Rs ${money}`);
    console.log(`Total Bets Made: ${bets}`);
    console.log(`Total Wins: ${wins}`);
  
    if (money >= goal) {
      console.log("Congratulations! You reached your goal!");
    } else {
      console.log("Oops! You went broke!");
    }
  }
  
  // Start the gambling simulation
  gamble();
  
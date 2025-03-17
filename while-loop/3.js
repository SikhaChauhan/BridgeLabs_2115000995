// Function to simulate coin flip until either heads or tails wins 11 times
function flipCoinGame() {
    let headsCount = 0;
    let tailsCount = 0;
  
    while (headsCount < 11 && tailsCount < 11) {
      // Simulate coin flip (0: Heads, 1: Tails)
      let flip = Math.floor(Math.random() * 2);
  
      if (flip === 0) {
        headsCount++;
        console.log(`It's Heads! (Heads: ${headsCount}, Tails: ${tailsCount})`);
      } else {
        tailsCount++;
        console.log(`It's Tails! (Heads: ${headsCount}, Tails: ${tailsCount})`);
      }
    }
  
    // Declare the winner
    if (headsCount === 11) {
      console.log("Heads wins 11 times!");
    } else {
      console.log("Tails wins 11 times!");
    }
  }
  
  // Start the coin flip game
  flipCoinGame();
  
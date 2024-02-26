Random coin = new();

// Let's say that 0 = heads and 1 = tails
int coinFlip = coin.Next(2);
string coinFlipResult = coinFlip == 0 ? "heads" : "tails";

Console.WriteLine(coinFlipResult);
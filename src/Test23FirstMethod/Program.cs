
using System;



HelperManager helperManager = new HelperManager();
for (int i = 0; i < 5; i++)
{
    int randomNum = helperManager.generateRandomNumbers(1, 5);
    Console.WriteLine($"Random number between 1 and 5: {randomNum}");
}



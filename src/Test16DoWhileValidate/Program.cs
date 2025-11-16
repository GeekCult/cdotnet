Random random = new Random();

Console.WriteLine("\nValidate");



string? readResult;
bool validEntry = false;
bool validNumber = false;
int numericValue = 0;

Console.WriteLine("Enter a number between 5 and 10");
do
{
  readResult = Console.ReadLine();
  if (readResult != null)
  {
    validNumber = int.TryParse(readResult, out numericValue);
    if (numericValue >= 5 && numericValue <= 10 && validNumber)
    {
      Console.WriteLine($"Your input {readResult}, is acceptable.");
      validEntry = true;
    }
    else
    {
      Console.WriteLine($"Your input is {readResult}, please try again.");
    }
  }
} while (validEntry == false);
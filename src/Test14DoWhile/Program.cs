Random random = new Random();
int current = 0;

Console.WriteLine("Loop 1 - Do While");
do
{
  current = random.Next(1, 11);
  Console.WriteLine($"Loop1 - {current}");
} while (current != 7);

Console.WriteLine("\nLoop2 - While");
int current2 = random.Next(1, 11);

do
{
  current2 = random.Next(1, 11);

  if (current2 >= 8) continue;

  Console.WriteLine($"Loop2 - {current2}");
} while (current2 != 7);

Console.WriteLine("\nLoop3 - While");
int current3 = 5;
while (current3 >= 3)
{
  Console.WriteLine($"Loop3 - {current3}");
  current3 = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current3}");
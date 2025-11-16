Random random = new Random();

Console.WriteLine("\nGame Battle Simulation");

int heroLife = 10;
int monsterLife = 10;

do
{
  int heroAttack = random.Next(1, 11);

  monsterLife -= heroAttack;
  Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterLife} health.");

  if (monsterLife <= 0) continue;

  int monsterAttack = random.Next(1, 11);

  heroLife -= monsterAttack;
  Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroLife} health.");

} while (heroLife > 0 && monsterLife > 0);

if (heroLife <= 0 && monsterLife <= 0)
  Console.WriteLine("It's a Draw!");
else if (heroLife <= 0)
  Console.WriteLine("Monster Wins!");
else
  Console.WriteLine("Hero Wins!");


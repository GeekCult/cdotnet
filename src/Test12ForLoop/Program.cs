Console.WriteLine("Loop 10++");
for (int i = 0; i < 10; i++)
{
  Console.WriteLine(i);
}


Console.WriteLine("Loop 10--");
for (int c = 10; c >= 0; c--)
{
  Console.WriteLine(c);
}


Console.WriteLine("Loop Break at 7");
for (int i = 0; i < 10; i++)
{
  Console.WriteLine(i);
  if (i == 7) break;
}

Console.WriteLine("Loop Array Forward");
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
  Console.WriteLine(names[i]);
}

string[] names2 = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names2.Length; i++)
  if (names2[i] == "David") names2[i] = "Sammy";

foreach (var name in names2) Console.WriteLine(name);
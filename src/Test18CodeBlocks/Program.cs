bool flag = true;
if (flag)
{
  int value = 10;
  Console.WriteLine($"Inside the code block: {value}");
}


// Code sample 1
int value2;
if (true)
{
  value2 = 10;
  Console.WriteLine($"Inside the code block: {value2}");
}

Console.WriteLine($"Outside the code block: {value2}");
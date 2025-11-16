Console.WriteLine("\nWhat I Like string search");

string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
int stringsCount = myStrings.Length;

for (int i = 0; i < stringsCount; i++)
{
  int nIndex = 0;
  List<string> myList = new List<string>(myStrings[i].Split("."));

  while (nIndex < myList.Count)
  {
    Console.WriteLine(myList[nIndex].Trim().TrimStart());
    nIndex++;
  }
}

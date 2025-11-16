namespace ImplementInterfaces
{

  public class Student : IPerson
  {
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }

    public void Introduce()
    {
      Console.WriteLine($"Hello, my name is {Name}, I am {Age} years old.");
    }
  }

}
namespace ImplementInterfaces
{
    public class Teacher : IPerson
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; } = 0;

        public void Introduce()
        {
            Console.WriteLine($"Teacher Name: {Name}, Age: {Age}");
        }
    }
}
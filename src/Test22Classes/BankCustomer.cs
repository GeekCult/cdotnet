using System;

namespace BankProject;

class BankCustomer
{

    public string FirstName = "Tim";
    public string LastName = "Shao";
    public string CustomerId { get; set; } = default!;
    private static int s_nextCustomerId;


    static BankCustomer()
    {
        Random random = new Random();
        s_nextCustomerId = random.Next(10000000, 20000000);
    }


    public BankCustomer(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        CustomerId = (s_nextCustomerId++).ToString("D10");

    }
}
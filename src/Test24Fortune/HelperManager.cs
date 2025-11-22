
class HelperManager
{
    public int generateRandomNumbers(int initialNumber, int finalNumber)
    {
        Random random = new Random();
        int randomNumber = random.Next(initialNumber, finalNumber);

        return randomNumber;
    }

    public void TellFortune()
    {
        Random random = new Random();
        int luck = random.Next(100);

        string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
        string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
        string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
        string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };


        Console.WriteLine("A fortune teller whispers the following words:");
        string[] fortune = luck > 75 ? good : luck < 25 ? bad : neutral;

        Console.Write($"{text[random.Next(0, 3)]} {fortune[random.Next(0, 3)]} ");

    }

}
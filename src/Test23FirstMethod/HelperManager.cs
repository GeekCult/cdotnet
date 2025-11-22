
class HelperManager
{
    public int generateRandomNumbers(int initialNumber, int finalNumber)
    {
        Random random = new Random();
        int randomNumber = random.Next(initialNumber, finalNumber);

        return randomNumber;
    }

}
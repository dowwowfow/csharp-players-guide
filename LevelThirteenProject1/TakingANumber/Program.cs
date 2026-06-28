

int result = AskForANumber("Pick a number any number! ");
Console.WriteLine(result);

int range = AskForNumberInRange("Guess a number! ", 10, 20);
Console.WriteLine($"Your guess of {range} was in the RANGE!");

int AskForANumber(string text)
{
    int number = 0;
    Console.Write(text);
    number = int.Parse(Console.ReadLine());
    return number;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = 0;
        Console.Write(text);
        number = int.Parse(Console.ReadLine());
        if (number >= min && number <= max)
        {
            return number;
        }
        Console.WriteLine("Try Again!");
    }
}
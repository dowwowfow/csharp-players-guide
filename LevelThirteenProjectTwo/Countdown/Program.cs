Console.Write("Pick a number to count down from: ");
int number = int.Parse(Console.ReadLine());
Countdown(number);

void Countdown(int number)
{
    if(number == 0)
    {
        Console.WriteLine("Finished Counting Down!");
        return;
    }
    Console.WriteLine(number);
    Countdown(number - 1);
}
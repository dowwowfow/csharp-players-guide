
int numberToGuess;

do {
    Console.WriteLine("Pilot we need a number between 1 and 100");
    numberToGuess = int.Parse(Console.ReadLine());
    if (numberToGuess < 1)
    {
        Console.WriteLine("That number is too low pick a new number between 1 and 100");
    } else if (numberToGuess > 100)
    {
        Console.WriteLine("The number is too big pick a new number between 1 and 100");
    }
}while(numberToGuess < 1 || numberToGuess > 100);

Console.Clear();

int guess;

do
{
    Console.WriteLine("Hunter we need a guess! ");
    guess = int.Parse(Console.ReadLine());
    if (guess > numberToGuess)
    {
        Console.WriteLine("That number is to high!");
    } else if(guess< numberToGuess)
    {
        Console.WriteLine("That number is to low");
    }
}while(guess != numberToGuess);

Console.WriteLine("You guessed the right number!");
//Excercise A - FIZZBUZZBOOM

for (int i = 1; i <= 30; i++)
{
    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
    {
        Console.WriteLine("FizzBuzzBoom");
    }
    else if (i % 3 == 0 && i % 7 == 0)
    {
        Console.WriteLine("FizzBoom");
    }
    else if (i % 5 == 0 && i % 7 == 0)
    {
        Console.WriteLine("BuzzBoom");
    }
    else if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 7 == 0)
    {
        Console.WriteLine("Boom");
    }
    else 
    {
        Console.WriteLine(i);
    }
}

//Exercise B -- Array Reverse
int[] numbers = new int[4];
for (int index  = 0; index < numbers.Length; index++)
{
    Console.WriteLine("Give me 5 numbers and i will return them then reverse it");
    int number = int.Parse(Console.ReadLine());
    numbers[index] = number;
}
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

for (int index = numbers.Length - 1; index >= 0; index--)
{
    Console.WriteLine(numbers[index]);
}


//Excercise C -- Method IsPrime

Console.WriteLine("Give me a number and i will tell you if it is prime");
int value = int.Parse(Console.ReadLine());
IsPrime(value);
bool IsPrime(int n)
{
    if (n%n  == 0 && n%1 == 0)
    {
        Console.WriteLine("It is a prime number");
        return true;
    }
    else
    {
        Console.WriteLine("It is not a prime number");
        return false;
    }
}

//Excercise D -- Safe Input
string question = "Give me a number";

AskForInt(question);

int AskForInt(string prompt)
{
    do
    {
        Console.WriteLine(prompt);
        string answer = Console.ReadLine();
        if (int.TryParse(answer, out int result))
        {
            Console.WriteLine($"{result} is a number");
            return result;
        }
        else
        {
            Console.WriteLine("TryAgain");
        }
    } while (true);
}
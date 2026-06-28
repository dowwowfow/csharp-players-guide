int[] numbers = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};

int total = 0;
int currentSmallest = int.MaxValue;

foreach (int number in numbers)
{
    total += number;
    if (number < currentSmallest)
    {
        currentSmallest = number;
    }
}

float average = (float)total / numbers.Length;

Console.WriteLine($"The average of the array is {average}, and the smallest number is {currentSmallest}");
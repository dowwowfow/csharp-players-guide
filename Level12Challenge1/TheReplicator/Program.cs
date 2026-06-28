int[] arrayOfNumbers = new int[5];

for(int index = 0; index < arrayOfNumbers.Length; index++)
{
    Console.WriteLine("Add a number to the array: ");
    int input = int.Parse(Console.ReadLine());
    arrayOfNumbers[index] = input;
}

int[] anotherArray = new int[5];

for (int index = 0;index < anotherArray.Length; index++)
{
    anotherArray[index] = arrayOfNumbers[index];
}

Console.WriteLine("Here is the original array you created: ");
for (int index = 0; index < arrayOfNumbers.Length; index++)
{
    
    Console.WriteLine(arrayOfNumbers[index]);
}

Console.WriteLine("Here is the contents of the new array: ");
for (int index = 0; index < anotherArray.Length; index++)
{
    
    Console.WriteLine(anotherArray[index]);
}
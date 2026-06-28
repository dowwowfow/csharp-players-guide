
for(int shot = 1; shot <= 20; shot++)
{
    if (shot % 3 == 0 && shot % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{shot}: Electric and Fire");
        
    }
    else if( shot % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{shot}:Electric");
    }
    else if(shot % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{shot}:Fire");
    }
    else
    {
        Console.ForegroundColor= ConsoleColor.White;
        Console.WriteLine($"{shot}: Normal");
    }
}

Console.ResetColor();  
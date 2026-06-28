
Console.Title = "The Dungeoneer's Terminal";
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;

string title = Console.Title;
//It says it can ^^^ only be accessed on windows, i am on windows but will investigate
string keepPlaying;

//hero stats
int maxHealth = 100;
int currentHealth = maxHealth;
int gold = 0;
int level = 1;
int timer = 5;

bool keepShopping = true;
bool keepDelving = true;

int[] totalGold = new int[5];

Console.Write($"Welcome to {title}, what is your name? ");
string name  = Console.ReadLine();



Console.WriteLine($"Welcome Hero: Name: {name} | Health: {currentHealth} | Gold: {gold} | Level: {level}");

do {

    Console.WriteLine("|------------- Diving In ---------------|");
    Countdown(timer);
    //five rounds in the dungeon
    for (int round = 1; round <= 5; round++)
    {
        Console.WriteLine($"Round : {round}");
        if (currentHealth <= 0)
        {
            keepDelving = IsDead(keepDelving);
            break;
        }
        Random rng = new Random();
        int roll = rng.Next(1, 4);

        if (roll == 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You encountered a monster and lost 15 Health");
            currentHealth = currentHealth - 15;
            Console.ResetColor();
            Console.WriteLine($"Current Health: {currentHealth} | Gold: {gold}");
        }
        else if (roll == 2)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You have found Treasure, here is 20 gold");
            //i can either add the 20 gold to gold here
            gold = gold + 20;
            totalGold[round - 1] = 20;
            Console.ResetColor();
            Console.WriteLine($"Current Health: {currentHealth} | Gold: {gold}");
        }
        else if (roll == 3)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("No encounter continue your journey");
            Console.ResetColor();
            Console.WriteLine($"Current Health: {currentHealth} | Gold: {gold}");
        }
    }

    Console.WriteLine("|------------- Dungeon Run Over ---------------|");
//level up if hero has more than 40 gold
    if (gold >= 40)
    {
        level = level + 1;
        maxHealth = maxHealth + 25;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"You have leveled up! Current Level: {level}");
        Console.WriteLine($"You grow stronger! Max Health has risen to {maxHealth}");
        Console.ResetColor();
    }
    Console.WriteLine("|------------- Level Up Process Complete ---------------|");

    foreach (int piece in totalGold)
    {
        if (piece == 0) continue;
        Console.ForegroundColor = ConsoleColor.Yellow;
        //or i could add piece to gold here to get total gold
        Console.WriteLine($"You gained {piece} pieces of gold");
        Console.ResetColor();
    }
    Console.WriteLine($"Total Gold after your dungeon dive: {gold} ");

    Console.WriteLine($"Status Update: Name: {name} | Health: {currentHealth} | Gold: {gold} | Level: {level}");

    Console.WriteLine("|------------- Shopping Time ---------------|");

    //i had to do some googling here in the book it only covered switch expressions for half a page and wasn't this indepth
    do
    {
        Console.Write("Welcome to the Shop! Here are your options\n 1 - Health Potion 10g\n 2 - Iron Shield 30g\n 3 - Leave Shop\n");
        string input = Console.ReadLine();
        int option;
        if (!int.TryParse(input, out option))
        {
            option = -1;
        }

        (currentHealth, gold, keepShopping) = option switch
        {
            1 when (currentHealth + 25) >= maxHealth => BlockPotion(currentHealth, gold, keepShopping),
            1 => BuyPotion(currentHealth, gold, keepShopping),
            2 => BuyShield(currentHealth, gold, keepShopping),
            3 => LeaveShop(currentHealth, gold, keepShopping),
            _ => InvalidOption(currentHealth, gold, keepShopping)
        };

    } while (keepShopping == true);

    if (currentHealth > 50)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Final Update: Name: {name} | Health: {currentHealth} | Gold: {gold} | Level: {level}");
        Console.ResetColor();
    }
    else if (currentHealth >= 25 && currentHealth <= 50)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Final Update: Name: {name} | Health: {currentHealth} | Gold: {gold} | Level: {level}");
        Console.ResetColor();
    }
    else if (currentHealth < 25)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Final Update: Name: {name} | Health: {currentHealth} | Gold: {gold} | Level: {level}");
        Console.ResetColor();
    }

    Console.WriteLine("Would you like to dive again? Y for yes, N for No");
    keepPlaying = Console.ReadLine().ToLower();
    if(keepPlaying == "n")
    {
        Console.WriteLine("Live to dive another day!");
        break;
    }
    Array.Clear(totalGold, 0, totalGold.Length);

}while (keepDelving == true);



(int, int, bool) BlockPotion(int hp, int gold, bool keepShopping)
{
    Console.WriteLine("Sorry you're topped up can't sell you that");
    keepShopping = true;
    return (hp, gold, keepShopping);
}
(int, int, bool) BuyPotion(int hp, int gold, bool keepShopping)
{
    if (gold >= 10)
    {
        Console.WriteLine("Here ya go! 10 gold please");
        keepShopping = true;
        return (hp + 25, gold - 10, keepShopping);
    }
    else
    {
        Console.WriteLine($"Sorry you don't have enough gold! Current Gold: {gold}");
        return (hp, gold, keepShopping);
    }
}
(int, int, bool) BuyShield(int hp, int gold, bool keepShopping)
{
    if (gold >= 30)
    {
        Console.WriteLine("The Best offence is a good defence, 30 gold please!");
        keepShopping = true;
        return (hp, gold - 30, keepShopping);
    }
    else
    {
        Console.WriteLine($"Sorry you don't have enough gold! Current Gold: {gold}");
        return (hp, gold, keepShopping);
    }
}
(int, int, bool) LeaveShop(int hp, int gold, bool keepShopping)
{
    Console.WriteLine("See Yah next time!");
    keepShopping = false;
    return (hp, gold, keepShopping);
}
(int, int, bool) InvalidOption(int hp, int gold, bool keepShopping)
{
    Console.WriteLine("WHAT! can't hear ye, my hearing isn't what it used to be!");
    keepShopping = true;
    return (hp, gold, keepShopping);
}

bool IsDead(bool dive)
{
    Console.WriteLine($"Your Delve is Over, {name}");
    dive = false;
    return dive;
}

void Countdown(int n)
{
    if(n == 0)
    {
        Console.WriteLine("May your dive be successful");
        return;
    }
    Console.WriteLine(n);
    Countdown(n - 1);
}
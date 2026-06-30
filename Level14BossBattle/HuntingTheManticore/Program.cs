int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;
int givenDistance;
int chosenDistance;
int damage = 0;
int enemyDamage = 0;

bool isDead = false;


givenDistance = GetPlayerInput("Player 1");

Console.Clear();

Console.WriteLine("Player Two Consolas is under attack! Please direct our canons to take down the Manticore!");
Console.WriteLine($"|--------------------------------------------------------------------------------------------------|");
do
{
    Console.WriteLine($"Status: Round {round}, City Health is {cityHealth} / 15, Manticore Health is {manticoreHealth} / 10 ");

    damage = DetermineDamage(round, damage);
    
    enemyDamage = DetermineEnemyDamage(round);

    chosenDistance = GetPlayerInput("Player 2");

    manticoreHealth = manticoreHealth - VerifyDamage(chosenDistance, givenDistance, damage);

    isDead = IsDead(cityHealth, manticoreHealth);

    if (isDead == false)
    {
        Console.WriteLine($"The Manticore fires at the city dealing {enemyDamage} points of damage");
        cityHealth = cityHealth - enemyDamage;
        isDead = IsDead(cityHealth, manticoreHealth);
        round = round + 1;
    }
        
    
    Console.WriteLine($"|--------------------------------------------------------------------------------------------------|");

} while (isDead == false);

int GetPlayerInput(string player)
{
    do
    {
        Console.Write($"{player} please enter your desired distance between 0 and 100: ");
        string playerInput = Console.ReadLine();
        bool numberInRange = int.TryParse(playerInput, out int distance);
        if (numberInRange == true && distance >= 0 && distance <= 100)
        {
            return distance;
        }
        else
        {
            Console.WriteLine("Try again!");
        }
    } while (true);
}

int DetermineDamage(int round, int damage)
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        damage = 10;
        Console.WriteLine("The cannon is expected to deal 10 damage, and shoot an Electric-Fire Round");
        Console.ResetColor();
        return damage;
    }
    else if (round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        damage = 3;
        Console.WriteLine("The cannon is expected to deal 3 damage and shoot an Electric blast.");
        Console.ResetColor();
        return damage;
    }
    else if (round % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        damage = 3;
        Console.WriteLine("The canon is expected to deal 3 damage, and spew a Fire Ball.");
        Console.ResetColor();
        return damage;
    }
    else
    {
        Console.WriteLine("The canon is expected to deal 1 damage, shooting a regular canon ball");
        damage = 1;
        return damage;
    }
}


int VerifyDamage(int chosenDistance,int givenDistance, int damage)
{
    if (chosenDistance < givenDistance)
    {
        Console.WriteLine("The shot FELL SHORT!");
        return 0;
    }
    else if (chosenDistance > givenDistance)
    {
        Console.WriteLine("You OVER SHOT!");
        return 0;
    }
    else
    {
        Console.WriteLine($"You HIT! Dealing {damage} points of damage.");
        return damage;
    }
}

bool IsDead(int cityHealth, int manticoreHealth)
{
    if (manticoreHealth < 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Player 2, you have saved Consolas!");
        Console.ResetColor();
        return true;
    }
    else if (cityHealth < 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Consolas has fallen!");
        Console.ResetColor();
        return true;
    }
    else return false;
}


int DetermineEnemyDamage(int round)
{
    if(round<2)
    {
        return 1;
    }
    for(int i = 2; i < round; i++)
    {
        if (round % i == 0) return 1;
    }
    return 2;
}


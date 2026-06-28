string name = "Jesse";
Console.WriteLine("Before we get down to business, what's your name? ");
string inputName = Console.ReadLine();

Console.Write($"Hello and Welcome to my Shop, {inputName}! \n The Following Items are Available\n 1 - Rope\n 2 - Torches\n 3 - Climbing Equipment\n 4 - Clean Water\n 5 - Machete\n 6 - Canoe\n 7 - Food Supplies\n");

Console.Write("What number do you want to see the price of? ");
int choice = int.Parse(Console.ReadLine());

if (name != inputName)
{
    string response;
    response = choice switch
    {
        1 => "That Rope will put you back 10 gold.",
        2 => "Torches, gotta be able to see, 15 gold",
        3 => "Going for a wee climb, 25 gold",
        4 => "Ah Watah, you know you can go three days without, 1 gold",
        5 => "Doing some slashing, now are we, 20 gold",
        6 => "Why would you buy this canoe? 200 gold",
        7 => "Food Supplies, gotta keep the energy up, 1 gold",
        _ => "what I didn't quiet catch that?"

    };
    Console.WriteLine(response);
}
else
{
    string response;
    response = choice switch
    {
        1 => "That Rope will put you back 5 gold.",
        2 => "Torches, gotta be able to see, 7 gold",
        3 => "Going for a wee climb, 12 gold",
        4 => "Ah Watah, you know you can go three days without, 5 silver",
        5 => "Doing some slashing, now are we, 10 gold",
        6 => "Why would you buy this canoe? 100 gold",
        7 => "Food Supplies, gotta keep the energy up, 5 silver",
        _ => "what I didn't quiet catch that?"

    };
    Console.WriteLine(response);
}

    

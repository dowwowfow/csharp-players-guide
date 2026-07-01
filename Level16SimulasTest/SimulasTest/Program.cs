ChestState chestState = ChestState.Locked;
string userInput;
string question = "What do you want to do? ";
do
{
    Console.Write($"The chest is {chestState}: ");
    userInput = GetInput(question);

    ChestState previousState = chestState;
    chestState = (chestState, userInput) switch
    {
        (ChestState.Locked, "unlock") => ChestState.Closed,
        (ChestState.Closed, "open") => ChestState.Opened,
        (ChestState.Closed, "lock") => ChestState.Locked,
        (ChestState.Opened, "close") => ChestState.Closed,
        _ => chestState
    };

    if (chestState == previousState) 
    {
        Console.WriteLine($"The Chest is {chestState}, you cannot {userInput} it!");
     }

} while (true);


string GetInput(string question)
{
    Console.Write(question);
    string input = Console.ReadLine().ToLower();
    return input;
}



enum ChestState {Opened, Closed, Locked};

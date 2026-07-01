Food soupType = Food.Soup;
MainIngredient ingredient = MainIngredient.Mushroom;
Seasoning flavor = Seasoning.Salty;
var meal = (soupType, ingredient, flavor);


int choice;

//figured out how to change the enum => meal.soupType = Food.Gumbo;
Console.Write("Let's make a soup! Start by choosing the type of soup.\n 1. Soup\n 2. Stew\n 3. Gumbo\n");

choice = GetInput(1,3);

meal.soupType = choice switch
{
    1 => Food.Soup,
    2 => Food.Stew,
    3 => Food.Gumbo,
    _ => Food.Soup
};



// to test the output for picking soup type => Console.WriteLine(meal.soupType);

Console.WriteLine("Nice now it is time to pick the ingredient! Here are your options:\n 1. Mushrooms\n 2. Chicken\n 3. Carrots\n 4. Potatos\n");

choice = GetInput(1,4);

meal.ingredient = choice switch
{
    1 => MainIngredient.Mushroom,
    2 => MainIngredient.Chicken,
    3 => MainIngredient.Carrot,
    4 => MainIngredient.Potato,
    _ => MainIngredient.Mushroom
};


// to test the ouput for picking the main ingredient => Console.WriteLine(meal.ingredient);

Console.WriteLine("Finally what kind of flavor profile do you want:\n 1. Spicy\n 2. Salty\n 3. Sweet\n");

choice = GetInput(1,3);

meal.flavor = choice switch
{
    1 => Seasoning.Spicy,
    2 => Seasoning.Salty,
    3 => Seasoning.Sweet,
    _ => Seasoning.Spicy
};


//to test output for the picking the flavor Console.WriteLine(meal.flavor);

Console.WriteLine($"{meal.flavor} {meal.ingredient} {meal.soupType}");


int GetInput(int minRange, int maxRange)
{
    do
    {
        string userInput = Console.ReadLine() ?? string.Empty;
        bool validInput = int.TryParse(userInput, out int input);
        if (validInput && input >= minRange && input <= maxRange)
        {
            return input;
        }
        else
        {
            Console.WriteLine("That isn't a valid option");
        }

    } while (true);
}


enum Food {Soup, Stew, Gumbo};
enum MainIngredient {Mushroom, Chicken, Carrot, Potato};
enum Seasoning { Spicy, Salty, Sweet};
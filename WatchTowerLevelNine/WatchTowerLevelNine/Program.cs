int xValue = 0;
int yValue = 0;

Console.WriteLine("Please input an x value");
xValue = Console.ReadLine();

xValue = int.Parse(xValue);
Console.WriteLine("You have chosen " +  xValue + " as your x value");

Console.WriteLine("Please Enter a y value");
yValue = Console.ReadLine();

yValue = int.Parse(yValue);
Console.WriteLine("You have chosen " + yValue + " as your y Value");

if (xValue == 0 && yValue == 0)
{
    Console.WriteLine("The Enemy is on top of you!");
}
else if(xValue == 0 && yValue > 0)
{
    Console.WriteLine("The Enemy is to the north!");
}
else if (xValue == 0 && yValue < 0)
{
    Console.WriteLine("The Enemy is to the south!");
}
else if (xValue < 0 && yValue > 0)
{
    Console.WriteLine("The Enemy is to the north west!");
}
else if (xValue < 0 && yValue == 0)
{
    Console.WriteLine("The Enemy is to the West!");
}
else if (xValue < 0 && yValue < 0)
{
    Console.WriteLine("The Enemy is to the South West!");
}
else if (xValue > 0 && yValue > 0)
{
    Console.WriteLine("The Enemy is to the North East!");
}
else if (xValue > 0 && yValue == 0)
{
    Console.WriteLine("The Enemy is to the East!");
}
else if (xValue > 0 && yValue < 0)
{
    Console.WriteLine("The Enemy is to the South East!");
}
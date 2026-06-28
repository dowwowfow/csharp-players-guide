string inputedRow;
string inputedColumn;

int row;
int column;

int rowUp = 0;
int columnRight = 0;
int rowDown = 0;
int columnLeft = 0;

Console.Title = "Defense of Consolas!";

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine("What row would you like to deploy the shield: ");
inputedRow = Console.ReadLine();

Console.WriteLine("What column would you like to deploy the shield to");
inputedColumn = Console.ReadLine();

row = int.Parse(inputedRow);
//Console.WriteLine(row);
column = int.Parse(inputedColumn);
//Console.WriteLine(column);

rowUp = row + 1;
//Console.WriteLine(rowUp);
columnRight = column + 1;
//Console.WriteLine(columnRight);
rowDown = row - 1;
//Console.WriteLine(rowDown);
columnLeft = column - 1;
//Console.WriteLine(columnLeft);

Console.WriteLine("Deploying to: ");
Console.WriteLine($"({ row},  { columnLeft} )");
Console.WriteLine($"({rowDown}, {column})");
Console.WriteLine($"({row}, {columnRight})");
Console.WriteLine($"({rowUp}, {column})");

Console.Beep();
static void GetSolution()
{
    int row = default;
    int column = default;
    int height = default;

    int.TryParse(Console.ReadLine(), out height);

    for (row = 0; row < height; row++)
    {
        for (column = 0; column <= row; column++)
        {
            Console.Write('*');
        }
        Console.WriteLine();
    }
    Console.ReadKey();

}


//-----Main Program-----
Console.Title = "Star Patterns Programs in C#";
Console.ForegroundColor = ConsoleColor.Yellow;

Console.Write("Enter height: ");

GetSolution();


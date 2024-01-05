static void GetSolution()
{

}


//----Main Program----

int spacePrinting, lenght = 1, height;

Console.Title = "Star Patterns Programs in C#";
Console.ForegroundColor = ConsoleColor.Yellow;


Console.WriteLine("Enter height: "); // ingreso 4 filas como ejemplo.
height = Convert.ToInt32(Console.ReadLine()!); 
spacePrinting = height - 1;

for (int row = 1; row <= height; row++) // Para cada fila 
{
    for (int column = 1; column <= spacePrinting; column++) // Este for imprime los espacios en blanco // Para cada columna
    {
        Console.Write('e'); // Voy a imprimir espacios en blanco en cada columna
    }
    for(int starPrinting= 1; starPrinting <= lenght; starPrinting++) // Este for imprime las estrellas
    {
        Console.Write('*');
    }
    //spacePrinting--;
    //lenght = lenght + 2;
    Console.WriteLine();
}
Console.ReadKey();


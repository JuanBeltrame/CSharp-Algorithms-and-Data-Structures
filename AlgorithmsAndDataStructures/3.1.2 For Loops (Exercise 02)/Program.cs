/* 
Practica 1 - For loops - Exercise 3.1.2
----------------------------------------------------------------------
English:
Given 100 integers as input, 
display each of them indicating whether it is
'POSITIVE' or 'NEGATIVE', as appropriate.

Spanish: 
Dados como datos 100 números enteros, 
mostrar cada uno de ellos indicando si es
‘POSITIVO’ o ‘NEGATIVO’, según corresponda.
----------------------------------------------------------------------
*/

//--------Programa Principal----------
Console.Title = "Practica 1 - For loops - Exercise 3.1.2";
Console.ForegroundColor = ConsoleColor.Yellow;

int cantidad = 5;

for (int i = 0; i < cantidad; i++)
{
    Console.Write("Ingresar un numero: ");
    int.TryParse(Console.ReadLine(), out int valor);

    if (valor > 0)
    {
        Console.WriteLine("El numeroo ingresado es positivo");
    }
    else if(valor < 0)
    {
        Console.WriteLine("El numero ingresado es negativo");
    }
    else
        Console.WriteLine("El numero ingresado es cero");
}

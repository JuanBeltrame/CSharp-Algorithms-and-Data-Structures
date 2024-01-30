/* 
Practica 1 - For loops - Exercise 3.1.3
----------------------------------------------------------------------
English:
Entering a sequence of 300 integers, 
determine the number of positive numbers in it.

Spanish: 
Ingresando una sucesión de 300 números enteros, 
determinar la cantidad de números positivos que hay en ella.
----------------------------------------------------------------------
*/

//--------Programa Principal----------
Console.Title = "Practica 1 - For loops - Exercise 3.1.3";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;

int cantidad = 5;
int contador = default;
for (int i = 0; i < cantidad; i++)
{
    Console.Write("Ingresar un numero: ");
    int.TryParse(Console.ReadLine(), out int numero);
    if (numero > 0)
    {
        contador += 1;
    }
    else
    {

    }
    
}
Console.WriteLine($"Se ingresaron {contador} numeros positivos");

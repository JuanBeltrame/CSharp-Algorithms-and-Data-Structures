/* 
Practica 1 - For loops - Exercise 3.1.13
----------------------------------------------------------------------
English:
Calculate and display the factorial of any number entered by keyboard.

Spanish: 
Calcular y exhibir el factorial de un número cualquiera ingresado por teclado.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

Console.Title = "Practica 1 - For loops - Exercise 3.1.13";
Console.ForegroundColor = ConsoleColor.Yellow;

Console.Write("Ingresar un numero: ");
int numero = int.Parse(Console.ReadLine()!);
int acumulador = 1;

for (int i = 2; i <= numero; i++)
{
    acumulador = acumulador * i;
    
}

Console.WriteLine($"El factorial es: {acumulador} ");




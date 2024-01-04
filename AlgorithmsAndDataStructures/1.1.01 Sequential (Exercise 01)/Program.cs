/*
Practica 1 - Sequential - Exercise 1.1.01
----------------------------------------------------------------------
English:
Given two numbers entered via keyboard as data, 
calculate their sum and report the result. 
Declare the variables to be used: N1, N2, SUM, all of numerical type.

Spanish: 
Dados como datos (ingresados por teclado) dos números cualesquiera 
calcular su suma e informar el resultado.
Declarar las variables a utilizar N1, N2, SUMA de tipo numérico
----------------------------------------------------------------------
*/

//---Main Program---
Console.Title = "Sequential - Exercise 1.1.01";

int firstNumber = default;
int secondNumber = default;
int result = default;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Enter 2 integers numbers: ");
Console.Write("Enter the first number: ");

if (int.TryParse(Console.ReadLine(), out firstNumber))
{
    Console.Write("Enter the second number: ");
    if (int.TryParse(Console.ReadLine(), out secondNumber))
    {
        result = firstNumber + secondNumber;
        Console.Write("The result is: {0}", result);
    }
    else
    {
        Console.WriteLine("The input is not valid");
    }
}
else
{
    Console.WriteLine("The input is not valid");
}
Console.ReadKey();


/*
Practica 1 - Sequential - Exercise 05
----------------------------------------------------------------------
English:
Given a number, show the result of multiplying that number by 6, assuming you can only use the addition operator (+).

Spanish: 
Dado un número mostrar el producto de ese número por 6, suponiendo que se cuenta
solamente con el operador suma (+).
----------------------------------------------------------------------
*/

int numero, product;

Console.WriteLine("Ingrese un numero");
numero = int.Parse(Console.ReadLine());
product = numero + numero + numero + numero + numero + numero;

Console.WriteLine($"El resultao es {product}");

/*
Practica 1 - If Conditional - Exercise 06
----------------------------------------------------------------------
English:
Enter three capital letters and display them in alphabetical order.

Spanish: 
Ingresar tres letras mayúsculas y mostrarlas ordenadas alfabéticamente.
----------------------------------------------------------------------
*/

System.Console.WriteLine("Ingresar Tres Letras");
char letter1 = char.Parse(Console.ReadLine());
char letter2 = char.Parse(Console.ReadLine());
char letter3 = char.Parse(Console.ReadLine());

char letter1Mayus = char.ToUpper(letter1);
char letter2Mayus = char.ToUpper(letter2);
char letter3Mayus = char.ToUpper(letter3);


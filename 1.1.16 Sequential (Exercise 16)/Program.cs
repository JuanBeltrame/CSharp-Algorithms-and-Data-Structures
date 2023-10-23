/*
Practica 1 - Sequential - Exercise 16
----------------------------------------------------------------------
English:
Indicate what the output will be after performing the requested task in the previous exercise, 
if 10 is entered in variable X, 15 in variable Y, and 20 in variable Z.

Spanish: 
Indicar cómo será la salida luego de realizar lo pedido en el ejercicio anterior, 
si se ingresa 10 en la variable X, 15 en la variable Y y 20 en la variable Z.
----------------------------------------------------------------------
*/
int x, y, z;
int auxiliar;

x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());
z = int.Parse(Console.ReadLine());
Console.WriteLine($"X, Y, Z, Con en el orden original {x} - {y} - {z}");
auxiliar = x;
x = z;
z = y;
y = auxiliar;
Console.WriteLine($"X, Y, Z, Son sus valores rotados {x} - {y} - {z}");
/*
Practica 1 - Sequential - Exercise 1.1.15
----------------------------------------------------------------------
English:
Enter 3 values into 3 variables X, Y, and Z.
It is desired to obtain a rotation of their values,
meaning that the content of Z goes to X, the content of X goes to Y, and the content of Y goes to Z.
The variables X, Y, and Z should be displayed with their original values, and then X, Y, and Z should be displayed with the values after the rotation.

Spanish: 
Ingresar 3 valores en 3 variables X, Y y Z. 
Se desea obtener una rotación de sus valores,
es decir que el contenido de Z pase a X, el contenido de X pase a Y, y el contenido de Y pase a Z. 
Se debe mostrar las variables X, Y y Z con sus valores originales y mostrar X,
Y y Z con los valores luego de la rotación.
----------------------------------------------------------------------
*/

string x, y, z;
string auxiliar;

x = Console.ReadLine();
y = Console.ReadLine();
z = Console.ReadLine();
Console.WriteLine($"X, Y, Z, Con en el orden original {x} - {y} - {z}");
auxiliar = x;
x = z;
z = y;
y = auxiliar;
Console.WriteLine($"X, Y, Z, Son sus valores rotados {x} - {y} - {z}");
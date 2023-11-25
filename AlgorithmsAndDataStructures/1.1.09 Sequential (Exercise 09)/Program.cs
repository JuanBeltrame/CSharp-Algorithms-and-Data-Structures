/*
Practica 1 - Sequential - Exercise 09
----------------------------------------------------------------------
English:
Keep in mind that only the 4 basic operations are recognized.
What would be the algorithm if the machine also has the power operation?

Spanish: 
Tener en cuenta, que solo se reconocen 4 operaciones básicas. ¿Cuál sería el
algoritmo si la máquina cuenta además con la operación potencia?
----------------------------------------------------------------------
*/

int numero, potencia;
double powerOperation;

Console.WriteLine("Ingrese un numero:");
numero = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese a que potencia desea elevar el valor del numero Ingresado");
potencia = int.Parse(Console.ReadLine());
powerOperation = Math.Pow(numero,potencia);
Console.WriteLine("El Resultado es: "+ powerOperation);



/* 
Practica 1 - If Conditional - Exercise 2.1.12
----------------------------------------------------------------------
English:
Same logic as the previous example, 
but indicate the position in which the major entered. 
(e.g. "The major was xx and was entered fifth").

Spanish: 
Misma logica que el ejemplo anterior, 
pero indicar la posición en que entró el mayor. 
(Ej. “El mayor fue xx y fue ingresado quinto”
----------------------------------------------------------------------
*/


Console.Title = "Practica 1 - If Conditional - Exercise 2.1.12";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.CursorVisible = true;

const int tamanio = 6;
var numero = 0;
int maximo = default;
int posicion = default;

for (int i = 0; i < tamanio; i++)
{
    Console.Write("Ingresar un numero: ");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        if(numero > maximo)
        {
            maximo = numero;
            posicion = i+1;
        }
    }
    else
    {
        Console.WriteLine("El valor ingresado no es un numero");
    }
}

Console.WriteLine($"El numero mas grande ingresado fue: {maximo}, en la posicion {posicion}");
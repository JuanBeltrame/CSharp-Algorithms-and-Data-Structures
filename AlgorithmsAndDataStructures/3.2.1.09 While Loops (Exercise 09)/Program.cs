/*
Practica 1 - While Loops - Pre-Conditional - Exercise 3.2.1.9
----------------------------------------------------------------------
English: 
Enter an alphabetical sequence of letters with repetitions. Report
each character and the number of times it appears in the list. The sequence ends with
an '*'.

Spanish: 
Ingresar una secuencia ordenada alfabéticamente de letras con repeticiones. Informar
cada carácter y la cantidad de veces que aparece en la lista. La secuencia finaliza con
un ‘*’.
----------------------------------------------------------------------
*/

//--------Programa Principal----------

Console.Title = "Practica 1 - While loops - Exercise 3.2.1.09";
Console.ForegroundColor = ConsoleColor.Yellow;

char letra = default;
int contadorLetras = 0;

Console.Write("Ingresar una letra: ");
while(!char.TryParse(Console.ReadLine(), out letra))
{
    Console.WriteLine("El dato ingresado no es una letra, intenta nuevamente");
    Console.Write("Ingresar una letra: ");
}

while (letra != '*')
{
    char letraAnterior = letra;
    while(letraAnterior == letra)
    {
        contadorLetras += 1;

        Console.Write("Ingresar una letra: ");
        while (!char.TryParse(Console.ReadLine(), out letra))
        {
            Console.WriteLine("El dato ingresado no es una letra, intenta nuevamente");
            Console.Write("Ingresar una letra: ");
        }
    }
    Console.WriteLine($"La letra {letraAnterior} se ingreso {contadorLetras} veces");
}
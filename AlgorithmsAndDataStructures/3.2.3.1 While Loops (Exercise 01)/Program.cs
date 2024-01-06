/* 
Ejercicio I05 - Tirame un centro - UTN Avellaneda
----------------------------------------------------------------------
English:
A numerical center is a number that separates a list of integers 
(starting from 1) into two groups of numbers, whose sums are equal.
The first numerical center is 6, which separates the list (1 to 8) into the groups: (1; 2; 3; 4; 5) and (7; 8) whose sums are both equal to 15. 
The second numerical center is 35, which separates the list (1 to 49) into the groups: (1 to 34) and (36 to 49) whose sums are both equal to 595.
An application is requested to calculate the numerical centers between 1 and the number that the user enters through the console.

Spanish: 
Un centro numérico es un número que separa una lista de números enteros
(comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
El primer centro numérico es el 6, 
el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 
El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
----------------------------------------------------------------------
*/

//--------Programa Principal----------
Console.Title = "Ejercicio I05 - Tirame un centro";

Console.WriteLine("Ingrese un numero: ");

int numero;

while (int.TryParse(Console.ReadLine(), out numero))
{
    // Recorro desde el 1 hasta el numero que ingreso el usuario
    for (int centro = 1; centro < numero; centro++)
    {
        // Sumo los numeros inferiores al centro
        int sumaAntes = 0;
        for (int i = 0; i < centro; i++)
        {
            sumaAntes += i;
        }

        // Sumo los numeros superiores al centro
        int sumaDespues = 0;
        for (int j = centro+1; j <= sumaAntes; j++)
        {
            if((sumaAntes == sumaDespues) || (sumaDespues > sumaAntes))
            {
                break;
            }
            sumaDespues += j;
        }

        // Mostrar en pantalla
        if (sumaAntes == sumaDespues)
        {
            Console.WriteLine("Es un centro numerico: {0}", centro);
        }
    }
}
Console.WriteLine("No es un numero");
Console.ReadKey();
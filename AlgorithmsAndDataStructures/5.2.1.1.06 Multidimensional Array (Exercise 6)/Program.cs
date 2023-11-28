/*
Practica 3 - Multidimensional Array - Ejercicio 06
----------------------------------------------------------------------
English:



Spanish: 
Se tiene una planilla con los siguientes datos de 30 empleados de una empresa:
Nro. de empleado (entero entre 100 y 200)
Cantidad total vendida del artículo 1
Cantidad total vendida del artículo 2
Cantidad total vendida del artículo 3
Cantidad total vendida del artículo 4
Cantidad total vendida del artículo 5
Cantidad total vendida del artículo 6

También se cuenta con los precios unitarios de cada uno de los 6 artículos que serán ingresados una única vez.
Se desea saber:
a) La comisión que se pagará a cada empleado (5% del monto de las ventas)
b) El número de empleado que le proporcionó a la empresa el mayor ingreso en pesos por sus ventas.
c) El total vendido de cada artículo.
----------------------------------------------------------------------
*/

using static System.Runtime.InteropServices.JavaScript.JSType;

int fila = 2;
int columna = 3;
int[,] matrizEnteros = new int[fila, columna];

int tamArrayPrecios = 2;
decimal[] arrayPreciosReales = new decimal[tamArrayPrecios];

int tamArrayComisiones = 2;
decimal[] arrayComisionesReales = new decimal[tamArrayComisiones];

void InicializarMatriz(int[,] m, int f, int c)
{
    for (int i = 0; i < f; i++)
    {
        for (int j = 0; j < c; j++)
        {
            m[i, j] = 0;
        }
    }
}

void InicializarArray(decimal[] arr, int tam)
{
    for (int i = 0; i < tam; i++)
    {
        arr[i] = 0;
    }
}

void CargarMatriz(int[,] m, int f, int c, string mensaje1)
{
    int datoAcargar = 0;
    for (int i = 0; i < f; i++)
    {
        Console.WriteLine(mensaje1);
        for (int j = 0; j < c; j++)
        {
            if (j != 2)
            {
                Console.Write($"Fila {i} - Columna {j}: ");
                datoAcargar = int.Parse(Console.ReadLine()!);
                while (datoAcargar <= 0 || datoAcargar >= 1000)
                {
                    Console.WriteLine("Error, debe ser entre 1 y 1000");
                    Console.Write($"Fila {i} - Columna {j}: ");
                    datoAcargar = int.Parse(Console.ReadLine()!);
                }
                m[i, j] = datoAcargar;
            }
            else
            {
                Console.WriteLine("Ingresar Codigo de Vendedor");
                Console.Write($"Fila {i} - Columna {j}: ");
                datoAcargar = int.Parse(Console.ReadLine()!);
                while (datoAcargar <= 0 || datoAcargar >= 1000)
                {
                    Console.WriteLine("Error, debe ser entre 1 y 1000");
                    Console.Write($"Fila {i} - Columna {j}: ");
                    datoAcargar = int.Parse(Console.ReadLine()!);
                }
                m[i, j] = datoAcargar;
            }
        }
    }
}

void CargarArray(decimal[] arr, int tam, string mensaje)
{
    decimal datoAcargar = 0.0M;

    for (int i = 0; i < tam; i++)
    {
        do
        {
            Console.Write($"Cargar {mensaje} en la posicion {i}: ");
            datoAcargar = decimal.Parse(Console.ReadLine()!);
        } while (datoAcargar <= 0.1M || datoAcargar >= 1000.0M);

        arr[i] = datoAcargar;
    }
}

void CalcularComisionYMayorVenta(int[,] m, decimal[] arP, decimal[] arC)
{
    decimal maximo = 0;
    int mejorEmpleado = 0;
    for (int i = 0; i < fila; i++)
    {
        decimal totalDeVentasXempleado = 0.0M;

        for (int j = 0; j < columna - 1; j++)
        {
            totalDeVentasXempleado = totalDeVentasXempleado + (m[i, j] * arP[j]);
        }
        decimal comision = totalDeVentasXempleado * 0.05M;
        arC[i] = comision;
        Console.WriteLine($"La comision del Empleado {m[i,2]}, es {comision} ");

        if (totalDeVentasXempleado > maximo)
        {
            maximo = totalDeVentasXempleado;
            mejorEmpleado = m[i, 2];
        }
    }

    Console.WriteLine($"El Empleado con mayor ganancia de ventas fue el empleado NUMERO: {mejorEmpleado}");
    Console.WriteLine($"Con un total de: {maximo}");
}


//--------Programa Principal-------------------
InicializarMatriz(matrizEnteros, fila, columna);
InicializarArray(arrayPreciosReales, tamArrayPrecios);
InicializarArray(arrayComisionesReales, tamArrayComisiones);

Console.WriteLine("-------Cargar Matriz con Cantidad de Articulos Vendidos + Empleados ------------");
CargarMatriz(matrizEnteros, fila, columna, "Ingresar cantidad de productos vendidos");

Console.WriteLine("-------Cargar los precios de los productos-------");
CargarArray(arrayPreciosReales, tamArrayPrecios, "PRECIOS");

Console.WriteLine("-------Calcular Comisiones-------");
CalcularComisionYMayorVenta(matrizEnteros, arrayPreciosReales, arrayComisionesReales);





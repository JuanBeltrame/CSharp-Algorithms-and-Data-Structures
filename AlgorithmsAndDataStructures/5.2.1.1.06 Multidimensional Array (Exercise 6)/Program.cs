/*
Practica 3 - Multidimensional Array - Ejercicio 06
----------------------------------------------------------------------
English:
You have a spreadsheet with the following data for 30 employees of a company:
Employee no. (integer between 100 and 200).
Total quantity sold of item 1
Total quantity sold of item 2
Total quantity sold of item 3
Total quantity sold of item 4
Total quantity sold of item 5
Total quantity sold of item 6

You also have the unit prices of each of the 6 items that will be entered only once.
It is desired to know:
a. The commission to be paid to each employee (5% of the total amount of sales).
b. The number of employee who provided the company with the highest income in pesos for their sales.
c. The total sold of each item by each employee (Show Matrix).
d. Show the total number of units per item (Vertical Overlay).
e. Issue a list sorted in descending order by commission for each employee.


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
a. La comisión que se pagará a cada empleado (5% del monto total de las ventas)
b. El número de empleado que le proporcionó a la empresa el mayor ingreso en pesos por sus ventas.
c. El total vendido de cada artículo por cada empleado (Mostrar la Matriz).
d. Mostrar el total de unidades por articulo (Recorro Vertical)
e. Emitir un listado ordenado en forma decreciente por comision de cada empleado
----------------------------------------------------------------------
*/

using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

int fila = 3;
int columna = 7;
int[,] matrizEnteros = new int[fila, columna];

int tamArrayPrecios = 6;
decimal[] arrayPreciosReales = new decimal[tamArrayPrecios];

int tamArrayComisiones = 3;
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
            if (j != 6)
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
        } while (datoAcargar <= 0.1M || datoAcargar >= 1000000.0M);

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
        decimal comision = 0;

        for (int j = 0; j < columna - 1; j++)
        {
            totalDeVentasXempleado = totalDeVentasXempleado + (m[i, j] * arP[j]);
        }
        comision = totalDeVentasXempleado * 0.05M;
        arC[i] = comision;
        Console.WriteLine($"La comision del Empleado {m[i, 6]}, es {arC[i]} ");

        if (totalDeVentasXempleado > maximo)
        {
            maximo = totalDeVentasXempleado;
            mejorEmpleado = m[i, columna - 1];
        }
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"El Empleado con mayor ganancia de ventas fue el empleado NUMERO: {mejorEmpleado}");
    Console.WriteLine();
    Console.WriteLine($"Con un total de: {maximo}");
}

void CalcularTotalUnidadesXArticulo(int[,] m)
{
    for (int j = 0; j < columna - 1; j++)
    {
        int suma = 0;

        for (int i = 0; i < fila; i++)
        {
            suma = suma + m[i, j];
        }
        Console.WriteLine();
        Console.WriteLine($"La columna {j} de articulos suma un total de: " + suma, " articulos vendidos");
    }
}

void OrdenarEmpleados(int[,] matriz, decimal[] arrayDeComisiones)
{
    for (int i = 0; i < fila - 1; i++)
    {
        for (int j = i + 1; j < fila; j++)
        {
            if (arrayDeComisiones[i] < arrayDeComisiones[j])
            {
                decimal auxiliar = arrayDeComisiones[i];
                arrayDeComisiones[i] = arrayDeComisiones[j];
                arrayDeComisiones[j] = auxiliar;

                for (int k = 0; k < columna; k++)
                {
                    int auxiliar2 = matriz[i, k];
                    matriz[i, k] = matriz[j, k];
                    matriz[j, k] = auxiliar2;
                }
            }
        }
    }
}

void MostrarMatriz(int[,] m)
{

    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna; j++)
        {
            Console.Write(m[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MostrarArray(decimal[] c)
{
    for (int j = 0; j < columna - 1; j++)
    {
        Console.Write(c[j] + " ");
    }

}

void MostrarComisiones(decimal[] comisiones)
{
    for (int i = 0; i < fila; i++)
    {
        Console.Write(comisiones[i] + " ");
    }
}  

static void ProcesosDeConsola()
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
}


//--------Programa Principal-------------------
InicializarMatriz(matrizEnteros, fila, columna);
InicializarArray(arrayPreciosReales, tamArrayPrecios);
InicializarArray(arrayComisionesReales, tamArrayComisiones);

ProcesosDeConsola();
Console.WriteLine("-------Cargar Matriz con Cantidad de Articulos Vendidos + Empleados ------------");
Console.ForegroundColor = ConsoleColor.Gray;
CargarMatriz(matrizEnteros, fila, columna, "Ingresar cantidad de productos vendidos");

Console.Clear();
ProcesosDeConsola();
Console.WriteLine("-------El total Vendido de cada Articulo es -------");
Console.WriteLine("Matriz de Articulos y Empleados: "); Console.ForegroundColor = ConsoleColor.Gray;
MostrarMatriz(matrizEnteros);

ProcesosDeConsola();
Console.WriteLine("-------Cargar los precios de los productos-------"); Console.ForegroundColor = ConsoleColor.Gray;
CargarArray(arrayPreciosReales, tamArrayPrecios, "PRECIOS");

ProcesosDeConsola();
Console.WriteLine("Listado de precios x Articulo"); Console.ForegroundColor = ConsoleColor.Gray;
MostrarArray(arrayPreciosReales);

Console.Clear();
ProcesosDeConsola();
Console.WriteLine("-------El total Vendido de cada Articulo es -------");
Console.WriteLine("Matriz de Articulos y Empleados: "); Console.ForegroundColor = ConsoleColor.Gray;
MostrarMatriz(matrizEnteros);

ProcesosDeConsola();
Console.WriteLine("Listado de precios x Articulo"); Console.ForegroundColor = ConsoleColor.Gray;
MostrarArray(arrayPreciosReales);

ProcesosDeConsola();
Console.WriteLine("-------Calcular Comisiones-------"); Console.ForegroundColor = ConsoleColor.Gray;
CalcularComisionYMayorVenta(matrizEnteros, arrayPreciosReales, arrayComisionesReales);

ProcesosDeConsola();
Console.WriteLine("-------Mostrar el total de unidades por articulo (Recorro Vertical)-------"); Console.ForegroundColor = ConsoleColor.Gray;
CalcularTotalUnidadesXArticulo(matrizEnteros);

ProcesosDeConsola();
Console.WriteLine("-------Emitir un listado ordenado en forma decreciente por comision de cada empleado-------");
Console.WriteLine("SIN ORDENAR"); 
ProcesosDeConsola();
MostrarMatriz(matrizEnteros);
ProcesosDeConsola();
CalcularComisionYMayorVenta(matrizEnteros, arrayPreciosReales, arrayComisionesReales);
OrdenarEmpleados(matrizEnteros, arrayComisionesReales);
ProcesosDeConsola();
Console.WriteLine("COMISIONES ORDENADAS"); Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Matriz Ordenada");
MostrarMatriz(matrizEnteros);
MostrarComisiones(arrayComisionesReales);
ProcesosDeConsola();
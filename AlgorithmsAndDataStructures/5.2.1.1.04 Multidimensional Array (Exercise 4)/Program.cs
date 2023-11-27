/*
Practica 3 - Multidimensional Array - Ejercicio 04
----------------------------------------------------------------------
English:
The following data are available for each of the first year students of the Faculty:
- Commission number(integer between 1 and 10)
- Age (integer)

These data are entered out of order and the number of students is not known, 
After entering the data of each student, a sign will appear on the screen with the following question: 'Do you continue or not?
question: 'Continue or finish?' 

Upon which the operator will enter a 'C' or 'F' (validate) as appropriate. 

Each time a commission number is entered, validate that it is within the correct range.

For each commission, display a line where it is specified:
Commission N.: Number of students:  Average age: 

At the end show the Commission No. with the highest average age and that average. 
(if there is more than one commission with the highest average, show the last one found).


Spanish: 
Para cada uno de los alumnos de primer año de la Facultad se tienen los siguientes datos:
• Nro.de comisión(entero entre 1 y 10)
• Edad(entero)

Estos datos ingresan desordenados y no se conoce la cantidad de alumnos, 
por lo que luego de introducidos los datos de cada estudiante aparecerá en pantalla un cartel con la
pregunta: '¿Continúa o finaliza?' 

Ante lo cual el operador ingresará una 'C' o una 'F' (validar) según corresponda. 

Cada vez que se ingrese un nro. de comisión validar que esté dentro del rango correcto.

Por cada comisión, mostrar un renglón donde se especifique:
Nro.Comisión:  Cantidad de estudiantes:  Promedio de edad: 

Al final mostrar el Nro. de Comisión con mayor promedio de edad y dicho promedio. 
(si hubiera más de una comisión con promedio máximo mostrar la última encontrada).
----------------------------------------------------------------------
*/

int fila = 10;
int columna = 2;
int[,] matrix = new int[fila, columna];

string alumno = null;

int comision = 0;
int anterior = 0;
int edad = 0;

int mayorPromedio = 0;
int comisionConMayorPromedio = 0;

bool ValidarRangoEnteros(int num, int desde, int hasta)
{
    if (num >= desde && num <= hasta)
        return true;
    else
        return false;
}

int ObtenerComision()
{
    int c = 0;
    do
    {
        Console.Write("Ingresar Comision [1 - 10]: ");
        c = int.Parse(Console.ReadLine()!);
    } while (!ValidarRangoEnteros(c, 1, 10));

    return c;
}

string ObtenerNombre()
{
    string a = null!;
    Console.Write("Ingresar nombre del Alumno: ");
    a = Console.ReadLine()!;

    return a;
}

int ObtenerEdad()
{
    int e = 0;
    do
    {
        Console.Write($"Ingresar edad del alumno [0 - 100]: ");
        e = int.Parse(Console.ReadLine()!);
    } while (!ValidarRangoEnteros(e, 0, 100));

    return e;
}

void CargarMatriz(int[,] matriz, int numC, int cant, int avg)
{
    matriz[numC - 1, 0] = cant;
    matrix[numC - 1, 1] = avg;
}

void MostrarMatriz(int[,] m)
{
    for (int i = 0; i < fila; i++)
    {
        Console.WriteLine($"Comision: {i + 1} Cantidad de Alumnos: {m[i, 0]}  Promedio de Edad: {m[i, 1]}");
    }
}

void InicializarMatrix(int[,] m)
{
    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna; j++)
        {
            m[i, j] = 0;
        }
    }
}



//------------Programa Principal---------------
InicializarMatrix(matrix);
Console.WriteLine(" ");

comision = ObtenerComision();
char continua = 'C';
while (continua == 'C')
{
    int cantidad = 0;
    int acumulador = 0;
    int promedio = 0;

    anterior = comision;
    while (anterior == comision)
    {
        alumno = ObtenerNombre();
        edad = ObtenerEdad();

        cantidad = cantidad + 1;
        acumulador = acumulador + edad;

        do
        {
            Console.Write("Desea ingresar otro alumno: [C] Continuar / [F] Finalizar: ");
            continua = char.ToUpper(char.Parse(Console.ReadLine()!));
        } while (continua != 'C' && continua != 'F');

        if (continua == 'C')
        {
            comision = ObtenerComision();
            if (comision != anterior)
            {
                promedio = acumulador / cantidad;
                if(promedio >= mayorPromedio)
                {
                    mayorPromedio = promedio;
                    comisionConMayorPromedio = anterior;
                }
                CargarMatriz(matrix, anterior, cantidad, promedio);
                MostrarMatriz(matrix);

            }
            else
            {

            }
        }
        else
        {
            promedio = acumulador / cantidad;
            if (promedio >= mayorPromedio)
            {
                mayorPromedio = promedio;
                comisionConMayorPromedio = anterior;
            }
            CargarMatriz(matrix, anterior, cantidad, promedio);
            MostrarMatriz(matrix);
            Console.WriteLine($"El mayor promedio fue: {mayorPromedio}, perteneciente a la Comision: {comisionConMayorPromedio}");
            Console.Write("Saliendo del Sistema....");
            comision = -1;
        }
    }
}


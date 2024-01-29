/* 
Practica 1 - For loops - Exercise 3.1.1
----------------------------------------------------------------------
English:
Calculate the salary of each of the 50 workers in a factory,
given as data the hourly wage (it is the same for all workers) and the number of hours worked in the month by each worker. 
and the number of hours worked in the month by each worker.

Spanish: 
Calcular el sueldo de cada uno de los 50 operarios de una fábrica,
dados como datos la remuneración por hora (es la misma para todos los operarios) 
y la cantidad de horas que trabajó en el mes cada operario.
----------------------------------------------------------------------
*/

//--------Programa Principal----------
Console.Title = "Practica 1 - For loops - Exercise 3.1.1";
Console.ForegroundColor = ConsoleColor.Yellow;

Console.Write("Ingresar la remuneracion por hora: ");
if (decimal.TryParse(Console.ReadLine(), out decimal precioHora))
{
    
    int cantidadOperarios = 3;
    for (int i = 0; i < cantidadOperarios; i++)
    {
        Console.WriteLine("Ingresar la cantidad de horas trabajadas por el operario: ");
        int horasTrabajadas = int.Parse(Console.ReadLine()!);
        decimal salario = precioHora * horasTrabajadas;
        Console.WriteLine($"El operario: {i + 1}, cobra un salario de: {salario}");
    }

}
else
{
    Console.WriteLine("Solo se deben ingresar numeros");
}

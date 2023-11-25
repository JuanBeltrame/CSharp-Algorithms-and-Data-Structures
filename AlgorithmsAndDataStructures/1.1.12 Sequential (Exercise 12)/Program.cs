/*
Practica 1 - Sequential - Exercise 12
----------------------------------------------------------------------
English:
Determine the number of hours, minutes, and seconds in 6250 seconds.

Spanish: 
Determinar el número de horas, minutos y segundos que hay en 6250 segundos.
----------------------------------------------------------------------
*/

const int segundosAcalcular = 6250;

int horas = segundosAcalcular / 3600;
int minutos = (segundosAcalcular % 3600) / 60;
int segundos = (segundosAcalcular % 3600) - (minutos *60);
System.Console.WriteLine($"6250 Son: hora:{horas} minutos: {minutos} segundos: {segundos} ");
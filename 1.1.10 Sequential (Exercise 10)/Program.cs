/*
Practica 1 - Sequential - Exercise 10
----------------------------------------------------------------------
English:
Given the net amount of an invoice as data, 
calculate the corresponding value of the VAT (Value Added Tax) (21%).

Spanish: 
Dado como dato el importe neto de una factura, 
calcular el valor correspondiente al IVA. (21%)
----------------------------------------------------------------------
*/

double importeNeto, valorIva, ivaDelProducto, importeTotal;

valorIva = 0.21;
Console.WriteLine("Ingrese el importe neto de la factura");
importeNeto = double.Parse(Console.ReadLine());

ivaDelProducto = importeNeto * valorIva;
Console.WriteLine($"El valor del iva el producto es: {ivaDelProducto}");

importeTotal = importeNeto + ivaDelProducto;
Console.WriteLine($"El valor Total del producto con iva es: {importeTotal}");
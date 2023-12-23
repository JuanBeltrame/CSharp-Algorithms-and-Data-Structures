/*
Practica 1 - Sequential - Exercise 1.1.13
----------------------------------------------------------------------
English:
Given the gross amount of an invoice, 
calculate the result of granting a 4% discount.
Calculate the VAT (21%) on the amount obtained.
Finally, provide information on:
the gross amount,
the value of the discount,
the discounted gross amount,
the corresponding amount of VAT, and
the resulting net amount.

Spanish: 
Dado el importe bruto de una factura 
calcular el resultado de bonificarlo (descuento) con un 4%. 
Al monto obtenido calcularle el IVA (21%). 
Finalmente informar: 
el importe bruto,
el valor de la bonificación, 
el importe bruto bonificado, 
el monto correspondiente al IVA y
el importe neto resultante.
----------------------------------------------------------------------
*/
const double valorIva = 0.21;
System.Console.WriteLine("Ingresar el importe bruto de la factura: ");
double importeBruto = int.Parse(Console.ReadLine());
double calculoBonificacion = importeBruto * 0.04;
double importeConDescuento = importeBruto * 0.96;
double calculoIva = importeConDescuento * valorIva;
double importeNeto = importeConDescuento + calculoIva;

System.Console.WriteLine("Importe Bruto: $" + importeBruto);
System.Console.WriteLine("Valor de la bonificacion : $" + calculoBonificacion);
System.Console.WriteLine("Importe con descuento: $" + importeConDescuento);
System.Console.WriteLine("Importe correspondiente al IVA: $" + calculoIva);
System.Console.WriteLine("Importe neto resultante: $" + importeNeto);
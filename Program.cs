//  Un vendedor recibe un sueldo base de $XXXX. Además, recibe una comisión del 10% sobre el valor total de cada venta que realiza.//

// Definir constantes
using System;

const double sb= 2000000;
const double pc = 0.10;
const double ov = 1000000;
const double be = 100000;

//definir variable para las ventas//
double v1, v2, v3;
Console.WriteLine("ingrese el valor de la primer venta:");
v1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ingrese el valor de la segunda venta:");
v2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ingrese el valor de la segunda venta:");
v3 = Convert.ToDouble(Console.ReadLine());

//determinar el valor de las comisiones// 
double c1, c2, c3;
c1= v1 * pc;
Console.WriteLine("el valor de comisión por primer venta del mes es de:" + c1);
c2 = v2 * pc;
Console.WriteLine("el valor de comisión por segunda venta del mes es de:" + c2);
c3 = v3 * pc;
Console.WriteLine("el valor de comisión por tercera venta del mes es de:" + c3);

//¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes?//
double tc = (c1 + c2 + c3);
Console.WriteLine("el total de las comisiones es de:" + tc);

//¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?//
double tm = sb + tc;
Console.WriteLine("el total que recibira en el mes es de:"+tm);

// Verificar si superó el objetivo de ventas
if (tc >= ov)
{
    Console.WriteLine("¡Felicitaciones! Has superado el objetivo de ventas del mes y ganaste un beneficio extra de:"+be);
}
else
{
    Console.WriteLine("No has superado el objetivo de ventas del mes.");
}

//¿Cuál fue la venta que le generó la mayor comisión?//

if (c1 > c2 && c1 > c3)
{
    Console.WriteLine("la primer venta es la mas grande de las tres") ;
}
else if (c2 > c1 && c2 > c3)
{
    Console.WriteLine("la segunda venta es la mas grande de las tres");
}
else
{
    Console.WriteLine("la tercer venta es la mas grande de las tres");
}

// ¿Cuál fue el promedio de las comisiones que recibió por cada venta?//

double cp = tc / 3;
Console.WriteLine("el promedio de las comisiones es de:" + cp);

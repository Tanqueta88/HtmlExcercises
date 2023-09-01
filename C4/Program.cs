// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


#region Manejo de strings

//string nombre;

//nombre = "";
//nombre = null; 

//if (String.IsNullOrEmpty(nombre))
//{
//    Console.WriteLine("Es vacia o nula");
//}

//nombre = "Paproglio";
//Console.WriteLine(nombre.IndexOf("a"));

//nombre = "Paproglio";
//Console.WriteLine(nombre.Replace("pro", "xxc"));

//nombre = "Paproglio";
//Console.WriteLine(nombre.ToUpper());

//nombre = "Paproglio";
//Console.WriteLine(nombre.ToLower());

//Console.WriteLine(nombre[2]);

#endregion

#region Char

//Char
//Console.WriteLine("CHAR");
//char unCaracter = 'l', unNumero = '9', unSimbolo = '$';
//bool es;

//Console.WriteLine($"{unCaracter} {unNumero} {unSimbolo}");

//es = Char.IsDigit(unNumero);
//Console.WriteLine(es);
//Console.WriteLine("Numero entero " + (int)unNumero);

#endregion

#region Datetime

//datetime
//Console.WriteLine("Datetime");
//Console.WriteLine(DateTime.Now);
//Console.WriteLine(DateTime.Now.Month);

//Console.WriteLine(DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString());

//Console.WriteLine(DateTime.Now.AddMonths(7).Month < 10 ? "0" + DateTime.Now.AddMonths(7).Month.ToString() : DateTime.Now.AddMonths(7).Month.ToString());
//Console.WriteLine(DateTime.Now.ToShortTimeString());
//Console.WriteLine(DateTime.Now.ToLongTimeString());
//Console.WriteLine(DateTime.Now.ToShortDateString());

//const float pi = 3.14f;
//float total = pi * 15;
//Console.WriteLine(total);   

#endregion

#region Enums

//enum TiposHabitaciones { Dormitorio = 1, Cocina, Comedor }; -> Esto va fuera del metodo main

//Console.WriteLine("Enumeraciones");
//Console.WriteLine(TiposHabitaciones.Cocina);
//Console.WriteLine((int)TiposHabitaciones.Cocina);

#endregion

#region Variables compuestas

//Casa miCasa = new Casa();
//miCasa.m2 = 100;
//miCasa.tieneCochera = true;
//miCasa.cantidadHabitaciones = 3;

//Console.WriteLine(miCasa.m2);

//----------------------- CLASE CASA-------------------------
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace ClaseTresPl23
// {
//     internal class Casa
//     {
//         public int cantidadHabitaciones;
//         public int m2;
//         public bool tieneCochera;

//     }
// }

#endregion

#region Casteo explicito/implicito

// //Casteo implicito:
// valorLong = valor;

// //Casteo explicito:
// valor = Convert.ToInt32(valorLong);

// valor = (int)valorLong;

#endregion

#region Exeptions

//Exceptiones
//int valor1, valor2, resutado;

//try
//{
//    Console.WriteLine("Ingrese un numero");
//    valor1 = int.Parse(Console.ReadLine());
//    valor2 = int.Parse(Console.ReadLine());
//    resutado = valor1 / valor2;

//    Console.WriteLine(resutado);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine("Error de tipo");
//}
//finally 
//{

//}

#endregion
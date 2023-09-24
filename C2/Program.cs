// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


#region Exercise one


// Console.WriteLine("ingrese un valor");
// x = int.Parse(Console.ReadLine());

//Ingresar un numero y por consola indicar si ente es:
// - Si mayor o igual a 50
// - si esta entre 10 y 50
// - Si es menor que 10

// if (x >50)
// {
//     Console.Write("el numero es mayor que 50");

// }
// else if (x >=10)
// {
//     Console.Write("el numero esta entre 10 y 50 ");
// }
// else{
//     Console.Write("el numero es menor que 10");
// }
#endregion

#region Exercise two

// Console.WriteLine("ingrese un valor");
// x = int.Parse(Console.ReadLine());

//Ingresar un numero y por consola indicar si ente esta dentro del intervalo entre´{0, 100}:

// if (x <= 0 || x>=100)
// {
//     Console.Write("el numero esta fuera del intervalo");

// }
// else 
// {
//     Console.Write("el numero esta dentro del intervalo ");
// }
#endregion

#region Exercise three
//Ingresar un numero y por consola indicar si ente esta dentro del intervalo entre´{0, 100}:

// if (x <= 0 || x >= 100)

// Console.WriteLine("ingrese un valor");
// x = int.Parse(Console.ReadLine());

// if (x == 150 || x >= 0 && x <= 100)
// {
//     Console.Write("el numero esta dentro del intervalo");

// }
// else
// {
//     Console.Write("el numero esta fuera del intervalo ");
// }
#endregion

#region Exercise four

// Console.WriteLine("ingrese un valor");
// x = int.Parse(Console.ReadLine());

//NEGAR: Al ingresar la negacion el valor ingresado va a invertir su interpretacion en el condicional


// if (!(x > 100))
// {
//     Console.Write("el numero esta dentro del intervalo");

// }
// else
// {
//     Console.Write("el numero esta fuera del intervalo ");
// }
#endregion

#region Exercise five

//NEGAR: Al ingresar la negacion el valor ingresado va a invertir su interpretacion en el condicional

// string resultado;

// Console.WriteLine("ingrese un valor");
// x = int.Parse(Console.ReadLine());
// resultado = (x >= 0 && x <= 100) ? "Dentro del intervalo" : "Fuera del intervalo";

// Console.Write(resultado);

#endregion

#region Exercise six
// Generar una sentencia multiple donde al ingresar un numero muestre el mes correspondiente
// Console.WriteLine("ingrese el numero de mes");
// x = int.Parse(Console.ReadLine());

// switch (x)
// {
//     case 1:
//         Console.WriteLine("Enero");
//         break;
//     case 2:
//         Console.WriteLine("Febrero");
//         break;
//     case 3:
//         Console.WriteLine("Marzo");
//         break;
//     default: Console.WriteLine("Otro mes");
//         break;
// }

#endregion

#region Exercise seven

//Al ingresar un mes debe entregar el numero que le corresponde
// string  NombreMes;
// Console.WriteLine("ingrese el nombre del mes");
// NombreMes = (Console.ReadLine());

// switch (NombreMes)
// {
//     case Enero:
//         Console.WriteLine("Enero");
//         break;
//     case Febrero:
//         Console.WriteLine("Febrero");
//         break;
//     case Marzo:
//         Console.WriteLine("Marzo");
//         break;
//     default:
//         Console.WriteLine("Otro mes");
//         break;
// }

#endregion

#region ingresar dos numeros e imprimir cual es el menor de los dos
// int V1;
// int V2;

// Console.WriteLine("Ingrese el primer valor");
// V1=int.Parse((Console.ReadLine()));
// Console.WriteLine("Ingrese el segundo valor");
// V2= int.Parse(Console.ReadLine());

// if (V1>V2)
// {
//     Console.WriteLine("El primer valor es mayor al segundo");
// }
// else 
// {
//     Console.WriteLine("El primer valor es menor al segundo");
// }

#endregion

#region Ingresar un numero mayor a 10 y par

// int V1;
// Console.WriteLine("Ingrese un valor");
// V1=int.Parse(Console.ReadLine());

// if (V1 > 10 && V1 %2 == 0)
// {
//     Console.WriteLine($"el numero {V1} es par ");
// }
// else{
//     Console.WriteLine("El numero no cumple las condiciones");
// }

#endregion

#region Indica con la leyenda si/no si la palabra ingresada es lunes

// string v1;

// Console.WriteLine("Ingrese la palabras");
// v1 = Console.ReadLine();

// if (v1 == "Lunes"){
//     Console.WriteLine("Ingreso la palabra Lunes");
// }
// else{
//     Console.WriteLine("No se encuentra en la lista");
// }

#endregion 

#region Ingresar dos valores y decir cual es el menor (uso de ? para devolver un string)
// int v1;
// int v2;
// // string resultado;

// Console.WriteLine("Ingrese el primer valor");
// v1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese el segundo valor");
// v2 = int.Parse(Console.ReadLine());

// // Manera compleja de imprimir el resultado
// // resultado = (v1 < v2) ? "El primer valor es menor" : "El segundo valor es menor";
// // Console.WriteLine(resultado);

// //Manera facil de imprimir el resultado
// Console.WriteLine((v1 < v2) ? "El primer valor es menor" : "El segundo valor es menor");

#endregion

#region Ingresar sueldo mostrando un mensaje de aumento solo para los valores <= 30000

// int sueldo;

// Console.WriteLine("Ingrese su seldo");
// sueldo= int.Parse(Console.ReadLine());

// if (sueldo <= 30000){
//     Console.WriteLine("Tiene aumento de sueldo");
// }
// else{
//     Console.WriteLine("Sin aumento");
// } 

#endregion
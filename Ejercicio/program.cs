// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using actividad_asincrona.entidades;
using actividad_asincrona.negocio;

datos datos = new datos();
cls_datos dato = new cls_datos();

Console.WriteLine("Escriba la palabra que dese contar la cantidad de letras");
string palabra = Console.ReadLine();
Console.WriteLine("El numero de cantidad de caracter es: ");


datos.palabra = palabra;

int Resultado = dato.Conteo(datos);
Console.WriteLine(Resultado);
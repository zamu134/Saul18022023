// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//la primera parte de un bucle for es para inicializar la interacion
//segunda parte es decirle hasta donde llegara el bucle for 
//tercera parte indicar cuato sera el crecimiento de nuestra variable inicial

////for (int indice=0;indice<10;indice++) {
////    Console.WriteLine($"Hello, World! {indice}");

//}
//int[] numero = { 1, 2, 3, 36, 6 };
//string[] estudiante = { "steven", "amy", "kenia"};

//Console.WriteLine(estudiante[1);

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el valor inicial: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor final: ");
        int fin = int.Parse(Console.ReadLine());

        Console.Write("Los números pares entre {0} y {1} son: ", inicio, fin);

        // Si el valor inicial es impar, se aumenta en 1 para que sea par
        if (inicio % 2 != 0)
        {
            inicio++;
        }

        // Imprime los números pares entre inicio y fin, incrementando de 2 en 2
        for (int i = inicio; i <= fin; i += 2)
        {
            Console.Write(i + " ");
        }

        Console.ReadLine();
    }
}

//foreach (var mostrar in estudiante) {
//    Console.WriteLine(mostrar);
//}

//Jose Izaac Robles Trinidad
//Samir Dominguez Perez
//Ervin Alexander Farrera Diego

using System;
using System.IO;

namespace Nuevaaplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del archivo");
            String Arc = Console.ReadLine();

            Stream Archivo = new FileStream("C:\\" + Arc + ".txt", FileMode.OpenOrCreate);

            StreamWriter Escribir = new StreamWriter(Archivo);

            Console.WriteLine("Ingrese el texto para escribir en: " + Arc + ".txt");
            String Texto = Console.ReadLine();

            Escribir.WriteLine(Texto);

            Escribir.Close();
            Archivo.Close();

            Stream Archivo2 = new FileStream("C:\\" + Arc + ".txt", FileMode.OpenOrCreate);
            Console.WriteLine("\nLectura:\n");

            StreamReader Leer = new StreamReader(Archivo2);
            Console.WriteLine(Leer.ReadToEnd());

            Leer.Close();
            Archivo2.Close();

        }
    }
}

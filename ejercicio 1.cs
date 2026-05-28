using System;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hola mundo");

        string nombre = "Lucas";
        int edad = 20;
        double altura = 1.80;
        string ciudad = "Buenos Aires";

        var puntos = 100;
        var precio = 99.99;
        var activo = true;

        Console.WriteLine(puntos.GetType());
        Console.WriteLine(precio.GetType());
        Console.WriteLine(activo.GetType());

        bool esMayorDeEdad = true;

        char inicial = 'L';

        Console.WriteLine(nombre);
        Console.WriteLine(edad);
        Console.WriteLine(altura);
        Console.WriteLine(ciudad);
        Console.WriteLine(esMayorDeEdad);
        Console.WriteLine(inicial);

        Console.WriteLine($"Hola, mi nombre es {nombre}, tengo {edad} años y vivo en {ciudad}");

        // int numero = "Hola";

        // int valor;
        // Console.WriteLine(valor);
    }
}
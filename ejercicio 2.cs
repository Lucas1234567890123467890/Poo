using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        string invertida = "";

        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            invertida += palabra[i];
        }

        Console.WriteLine("Palabra invertida: " + invertida);
    }
}
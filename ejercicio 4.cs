using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        string resultado = "";

        foreach (char letra in palabra)
        {
            if (letra == 'z')
            {
                resultado += 'a';
            }
            else
            {
                resultado += (char)(letra + 1);
            }
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}
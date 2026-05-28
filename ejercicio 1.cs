using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine().ToLower();

        int contador = 0;

        foreach (char letra in frase)
        {
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                contador++;
            }
        }

        Console.WriteLine("Cantidad de vocales: " + contador);
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine().ToLower().Replace(" ", "");

        string invertida = "";

        for (int i = frase.Length - 1; i >= 0; i--)
        {
            invertida += frase[i];
        }

        if (frase == invertida)
        {
            Console.WriteLine("Es un palindromo");
        }
        else
        {
            Console.WriteLine("No es un palindromo");
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 20; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        for (int i = 2; i <= 20; i += 2)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        int suma = 0;

        for (int i = 1; i <= 100; i++)
        {
            suma += i;
        }

        Console.WriteLine("Suma: " + suma);

        int contador = 10;

        while (contador >= 1)
        {
            Console.Write(contador + " ");
            contador--;
        }

        Console.WriteLine();

        int numero;

        do
        {
            Console.Write("Ingrese un numero positivo: ");
            numero = int.Parse(Console.ReadLine());
        }
        while (numero <= 0);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("5 x " + i + " = " + (5 * i));
        }

        string texto = "Hola";

        foreach (char letra in texto)
        {
            Console.WriteLine(letra);
        }

        for (int i = 1; i <= 20; i++)
        {
            if (i == 13)
            {
                break;
            }

            Console.Write(i + " ");
        }

        Console.WriteLine();

        for (int i = 1; i <= 20; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }

            Console.Write(i + " ");
        }

        Console.WriteLine();

        for (int fila = 1; fila <= 5; fila++)
        {
            for (int columna = 1; columna <= fila; columna++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
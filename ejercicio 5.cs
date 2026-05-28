usingusing System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] notas = { 8, 6, 9, 7, 5 };

        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine(notas[i]);
        }

        int suma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }

        double promedio = (double)suma / notas.Length;

        Console.WriteLine("Promedio: " + promedio);

        int maximo = notas[0];
        int minimo = notas[0];

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] > maximo)
            {
                maximo = notas[i];
            }

            if (notas[i] < minimo)
            {
                minimo = notas[i];
            }
        }

        Console.WriteLine("Maximo: " + maximo);
        Console.WriteLine("Minimo: " + minimo);

        int[] invertido = new int[notas.Length];

        int indice = 0;

        for (int i = notas.Length - 1; i >= 0; i--)
        {
            invertido[indice] = notas[i];
            indice++;
        }

        Console.WriteLine("Array invertido:");

        foreach (int n in invertido)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine();

        int mayores = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] > 7)
            {
                mayores++;
            }
        }

        Console.WriteLine("Mayores a 7: " + mayores);

        List<string> tareas = new List<string>();

        tareas.Add("Estudiar");
        tareas.Add("Programar");
        tareas.Add("Entrenar");

        tareas.Remove("Programar");

        Console.WriteLine("Cantidad de tareas: " + tareas.Count);

        foreach (string tarea in tareas)
        {
            Console.WriteLine(tarea);
        }

        int[,] matriz =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        Console.WriteLine("Diagonal:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(matriz[i, i]);
        }

        int buscar = 7;
        bool existe = false;

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] == buscar)
            {
                existe = true;
            }
        }

        Console.WriteLine("Existe el numero 7: " + existe);
    }
}
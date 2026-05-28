using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su apellido: ");
        string apellido = Console.ReadLine();

        Console.WriteLine(nombre + " " + apellido);

        Console.Write("Ingrese una oracion: ");
        string oracion = Console.ReadLine();

        string sinEspacios = oracion.Replace(" ", "");

        Console.WriteLine("Cantidad de letras: " + sinEspacios.Length);

        Console.Write("Ingrese un texto: ");
        string texto = Console.ReadLine();

        Console.WriteLine(texto.ToUpper());
        Console.WriteLine(texto.ToLower());

        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        if (palabra.Contains("a"))
        {
            Console.WriteLine("Contiene la letra a");
        }
        else
        {
            Console.WriteLine("No contiene la letra a");
        }

        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine();

        string reemplazo = frase.Replace(" ", "-");

        Console.WriteLine(reemplazo);

        Console.Write("Ingrese otra frase: ");
        string fraseSplit = Console.ReadLine();

        string[] palabras = fraseSplit.Split(' ');

        foreach (string p in palabras)
        {
            Console.WriteLine(p);
        }

        Console.Write("Ingrese el primer texto: ");
        string texto1 = Console.ReadLine();

        Console.Write("Ingrese el segundo texto: ");
        string texto2 = Console.ReadLine();

        if (texto1.ToLower() == texto2.ToLower())
        {
            Console.WriteLine("Los textos son iguales");
        }
        else
        {
            Console.WriteLine("Los textos son diferentes");
        }

        Console.Write("Ingrese un numero: ");
        string numeroTexto = Console.ReadLine();

        int numero = int.Parse(numeroTexto);

        Console.WriteLine("Numero convertido: " + numero);

        Console.Write("Nombre: ");
        string nombreForm = Console.ReadLine();

        Console.Write("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ciudad: ");
        string ciudad = Console.ReadLine();

        Console.WriteLine($"Nombre: {nombreForm}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Ciudad: {ciudad}");

        Console.Write("Ingrese un palindromo: ");
        string palindromo = Console.ReadLine().ToLower().Replace(" ", "");

        string invertido = "";

        for (int i = palindromo.Length - 1; i >= 0; i--)
        {
            invertido += palindromo[i];
        }

        if (palindromo == invertido)
        {
            Console.WriteLine("Es un palindromo");
        }
        else
        {
            Console.WriteLine("No es un palindromo");
        }
    }
}
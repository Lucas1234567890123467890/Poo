using System;

class Program
{
    static void Main()
    {
        double baseRectangulo = 10;
        double altura = 5;
        double area = baseRectangulo * altura;

        Console.WriteLine("Area del rectangulo: " + area);

        int resto = 100 % 7;

        Console.WriteLine("Resto de 100 / 7: " + resto);

        double celsius = 30;
        double fahrenheit = celsius * 9 / 5 + 32;

        Console.WriteLine("Temperatura en Fahrenheit: " + fahrenheit);

        string textoNumero = "50";
        int numero = int.Parse(textoNumero);

        Console.WriteLine("Numero convertido: " + numero);

        string textoDecimal = "3.14";

        if (double.TryParse(textoDecimal, out double pi))
        {
            Console.WriteLine("Conversion correcta: " + pi);
        }
        else
        {
            Console.WriteLine("Error en la conversion");
        }

        double precio = 1000;
        double precioFinal = precio * 1.21;

        Console.WriteLine("Precio final con IVA: " + precioFinal);

        int a = 10;
        int b = 3;

        Console.WriteLine("Division entera: " + (a / b));

        double resultadoReal = (double)a / b;

        Console.WriteLine("Division real: " + resultadoReal);

        int contador = 0;
        contador++;

        Console.WriteLine("Contador incrementado: " + contador);

        double numeroDecimal = 9.99;
        int numeroEntero = (int)numeroDecimal;

        Console.WriteLine("Double convertido a int: " + numeroEntero);

        int horas = 1000;
        int dias = horas / 24;

        Console.WriteLine("Dias completos en 1000 horas: " + dias);
    }
}
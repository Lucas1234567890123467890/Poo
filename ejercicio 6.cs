using System;

class Program
{
    static void Main()
    {
        Saludar("Lucas");

        int resultadoSuma = Sumar(10, 5);
        Console.WriteLine("Suma: " + resultadoSuma);

        bool par = EsPar(8);
        Console.WriteLine("Es par: " + par);

        int mayor = Mayor(20, 15);
        Console.WriteLine("Mayor: " + mayor);

        int factorial = CalcularFactorial(5);
        Console.WriteLine("Factorial: " + factorial);

        double total = CalcularIVA(1000);
        Console.WriteLine("Precio con IVA: " + total);

        MetodoScope();

        int[] numeros = { 1, 2, 3, 4, 5, 6 };

        ImprimirArray(numeros);

        int cantidadPares = ContarPares(numeros);
        Console.WriteLine("Cantidad de pares: " + cantidadPares);

        MostrarResultado(numeros);
    }

    static void Saludar(string nombre)
    {
        Console.WriteLine("Hola " + nombre);
    }

    static int Sumar(int a, int b)
    {
        return a + b;
    }

    static bool EsPar(int n)
    {
        return n % 2 == 0;
    }

    static int Mayor(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static int CalcularFactorial(int n)
    {
        int resultado = 1;

        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
        }

        return resultado;
    }

    static double CalcularIVA(double precio, double iva = 0.21)
    {
        return precio * (1 + iva);
    }

    static void MetodoScope()
    {
        int numero = 10;
        Console.WriteLine(numero);
    }

    static void ImprimirArray(int[] arr)
    {
        foreach (int n in arr)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine();
    }

    static int ContarPares(int[] arr)
    {
        int contador = 0;

        foreach (int n in arr)
        {
            if (n % 2 == 0)
            {
                contador++;
            }
        }

        return contador;
    }

    static int ObtenerCantidadPares(int[] arr)
    {
        int cantidad = 0;

        foreach (int n in arr)
        {
            if (n % 2 == 0)
            {
                cantidad++;
            }
        }

        return cantidad;
    }

    static void MostrarResultado(int[] arr)
    {
        int resultado = ObtenerCantidadPares(arr);

        Console.WriteLine("Resultado desde otro metodo: " + resultado);
    }
}
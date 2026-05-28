using System;

class Program
{
    static void Main()
    {
        int numero = 10;

        if (numero % 2 == 0)
        {
            Console.WriteLine("El numero es par");
        }
        else
        {
            Console.WriteLine("El numero es impar");
        }

        int valor = -5;

        if (valor > 0)
        {
            Console.WriteLine("Positivo");
        }
        else if (valor < 0)
        {
            Console.WriteLine("Negativo");
        }
        else
        {
            Console.WriteLine("Es cero");
        }

        int edad = 20;

        if (edad >= 18)
        {
            Console.WriteLine("Es mayor de edad");
        }
        else
        {
            Console.WriteLine("Es menor de edad");
        }

        int numeroRango = 50;

        if (numeroRango >= 1 && numeroRango <= 100)
        {
            Console.WriteLine("El numero esta entre 1 y 100");
        }

        string dia = "Sabado";

        if (dia == "Sabado" || dia == "Domingo")
        {
            Console.WriteLine("Es fin de semana");
        }

        string estado = edad >= 18 ? "Mayor" : "Menor";

        Console.WriteLine(estado);

        int diaSemana = 3;

        switch (diaSemana)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;

            case 2:
                Console.WriteLine("Martes");
                break;

            case 3:
                Console.WriteLine("Miercoles");
                break;

            case 4:
                Console.WriteLine("Jueves");
                break;

            case 5:
                Console.WriteLine("Viernes");
                break;

            case 6:
                Console.WriteLine("Sabado");
                break;

            case 7:
                Console.WriteLine("Domingo");
                break;

            default:
                Console.WriteLine("Dia invalido");
                break;
        }

        int categoria = 2;

        string producto = categoria switch
        {
            1 => "Electronica",
            2 => "Ropa",
            3 => "Alimentos",
            _ => "Otra categoria"
        };

        Console.WriteLine(producto);

        bool tieneLicencia = true;

        if (edad >= 18)
        {
            if (tieneLicencia)
            {
                Console.WriteLine("Puede conducir");
            }
            else
            {
                Console.WriteLine("No tiene licencia");
            }
        }
        else
        {
            Console.WriteLine("Es menor de edad");
        }

        int opcion = 2;

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Jugar");
                break;

            case 2:
                Console.WriteLine("Ver puntaje");
                break;

            case 3:
                Console.WriteLine("Salir");
                break;

            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}
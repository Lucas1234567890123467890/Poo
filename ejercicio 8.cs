using System;

class Persona
{
    public string Nombre;
    public int Edad;

    public void Presentarse()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Edad: " + Edad);
    }

    public bool EsMayor()
    {
        return Edad >= 18;
    }
}

class Rectangulo
{
    public double Ancho;
    public double Alto;

    public double Area()
    {
        return Ancho * Alto;
    }

    public double Perimetro()
    {
        return 2 * (Ancho + Alto);
    }
}

class Auto
{
    public string Marca;
    public string Modelo;
    public int Año;

    public void MostrarDescripcion()
    {
        Console.WriteLine(Marca + " " + Modelo + " " + Año);
    }
}

class Program
{
    static void Main()
    {
        Persona p1 = new Persona();
        p1.Nombre = "Lucas";
        p1.Edad = 20;

        Persona p2 = new Persona();
        p2.Nombre = "Ana";
        p2.Edad = 15;

        p1.Presentarse();
        Console.WriteLine("Es mayor: " + p1.EsMayor());

        p2.Presentarse();
        Console.WriteLine("Es mayor: " + p2.EsMayor());

        Rectangulo rect = new Rectangulo();
        rect.Ancho = 10;
        rect.Alto = 5;

        Console.WriteLine("Area: " + rect.Area());
        Console.WriteLine("Perimetro: " + rect.Perimetro());

        Auto auto1 = new Auto();
        auto1.Marca = "Ford";
        auto1.Modelo = "Focus";
        auto1.Año = 2020;

        Auto auto2 = new Auto();
        auto2.Marca = "Toyota";
        auto2.Modelo = "Corolla";
        auto2.Año = 2022;

        Auto auto3 = new Auto();
        auto3.Marca = "Chevrolet";
        auto3.Modelo = "Cruze";
        auto3.Año = 2019;

        auto1.MostrarDescripcion();
        auto2.MostrarDescripcion();
        auto3.MostrarDescripcion();

        auto1.Modelo = "Fiesta";

        Console.WriteLine(auto1.Modelo);
        Console.WriteLine(auto2.Modelo);

        Persona[] personas = new Persona[3];

        personas[0] = new Persona();
        personas[0].Nombre = "Juan";
        personas[0].Edad = 18;

        personas[1] = new Persona();
        personas[1].Nombre = "Maria";
        personas[1].Edad = 25;

        personas[2] = new Persona();
        personas[2].Nombre = "Pedro";
        personas[2].Edad = 30;

        foreach (Persona p in personas)
        {
            p.Presentarse();
        }
    }
}
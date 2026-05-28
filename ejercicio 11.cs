using System;
using System.Collections.Generic;

class Motor
{
    public int Cilindros { get; set; }

    public Motor(int cilindros)
    {
        Cilindros = cilindros;
    }

    public void Arrancar()
    {
        Console.WriteLine("Motor encendido");
    }
}

class Auto
{
    public string Marca { get; set; }
    public Motor Motor { get; set; }

    public Auto(string marca, int cilindros)
    {
        Marca = marca;
        Motor = new Motor(cilindros);
    }
}

class CPU
{
    public string Modelo { get; set; }

    public CPU(string modelo)
    {
        Modelo = modelo;
    }
}

class RAM
{
    public int GB { get; set; }

    public RAM(int gb)
    {
        GB = gb;
    }
}

class Computadora
{
    public CPU Cpu { get; set; }
    public RAM Ram { get; set; }

    public Computadora(string cpu, int ram)
    {
        Cpu = new CPU(cpu);
        Ram = new RAM(ram);
    }
}

class Conductor
{
    public string Nombre { get; set; }

    public Conductor(string nombre)
    {
        Nombre = nombre;
    }
}

class Colectivo
{
    public string Linea { get; set; }

    public Conductor? Conductor { get; private set; }

    public Colectivo(string linea)
    {
        Linea = linea;
    }

    public void AsignarConductor(Conductor conductor)
    {
        Conductor = conductor;
    }

    public void Desvincular()
    {
        Conductor = null;
    }
}

class Jugador
{
    public string Nombre { get; set; }

    public Jugador(string nombre)
    {
        Nombre = nombre;
    }
}

class Equipo
{
    public string Nombre { get; set; }

    public List<Jugador> Jugadores { get; set; }

    public Equipo(string nombre)
    {
        Nombre = nombre;
        Jugadores = new List<Jugador>();
    }

    public void AgregarJugador(Jugador jugador)
    {
        Jugadores.Add(jugador);
    }
}

class LineaFactura
{
    public string Producto { get; set; }
    public double Precio { get; set; }

    public LineaFactura(string producto, double precio)
    {
        Producto = producto;
        Precio = precio;
    }
}

class Factura
{
    public List<LineaFactura> Lineas { get; set; }

    public Factura()
    {
        Lineas = new List<LineaFactura>();
    }

    public void AgregarLinea(string producto, double precio)
    {
        Lineas.Add(new LineaFactura(producto, precio));
    }
}

class Program
{
    static void Main()
    {
        Auto auto = new Auto("Ford", 4);

        Console.WriteLine(auto.Marca);
        auto.Motor.Arrancar();

        Computadora pc = new Computadora("Ryzen 5", 16);

        Console.WriteLine(pc.Cpu.Modelo);
        Console.WriteLine(pc.Ram.GB + "GB");

        Conductor conductor1 = new Conductor("Carlos");
        Conductor conductor2 = new Conductor("Juan");

        Colectivo colectivo1 = new Colectivo("152");
        Colectivo colectivo2 = new Colectivo("60");

        colectivo1.AsignarConductor(conductor1);

        Console.WriteLine(colectivo1.Conductor?.Nombre);

        colectivo2.AsignarConductor(conductor1);

        Console.WriteLine(colectivo2.Conductor?.Nombre);

        colectivo1.AsignarConductor(conductor2);

        Console.WriteLine(colectivo1.Conductor?.Nombre);

        Equipo equipo = new Equipo("River");

        equipo.AgregarJugador(new Jugador("Messi"));
        equipo.AgregarJugador(new Jugador("Di Maria"));

        foreach (Jugador j in equipo.Jugadores)
        {
            Console.WriteLine(j.Nombre);
        }

        Factura factura = new Factura();

        factura.AgregarLinea("Teclado", 15000);
        factura.AgregarLinea("Mouse", 8000);

        foreach (LineaFactura linea in factura.Lineas)
        {
            Console.WriteLine(linea.Producto + " " + linea.Precio);
        }
    }
}
using System;

class Rectangulo
{
    public double Ancho { get; }
    public double Alto { get; }

    public Rectangulo() : this(1, 1)
    {
    }

    public Rectangulo(double lado) : this(lado, lado)
    {
    }

    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public double Area()
    {
        return Ancho * Alto;
    }
}

class Persona
{
    private static int contador = 1;

    public int Id { get; }
    public string Nombre { get; set; }

    public Persona()
    {
        Id = contador++;
    }
}

class Fraccion
{
    public int Numerador { get; set; }
    public int Denominador { get; set; }

    public Fraccion(int num, int den)
    {
        if (den != 0)
        {
            Numerador = num;
            Denominador = den;
        }
        else
        {
            Console.WriteLine("El denominador no puede ser 0");
        }
    }

    public Fraccion(int num) : this(num, 1)
    {
    }
}

class Jugador
{
    private string nombre;
    private int x;
    private int y;

    public Jugador(string nombre)
    {
        this.nombre = nombre;
    }

    public Jugador Mover(int dx, int dy)
    {
        x += dx;
        y += dy;

        Console.WriteLine(nombre + " se movio a " + x + "," + y);

        return this;
    }

    public Jugador Atacar()
    {
        Console.WriteLine(nombre + " ataco");

        return this;
    }
}

class Singleton
{
    private static Singleton instancia;

    private Singleton()
    {
    }

    public static Singleton ObtenerInstancia()
    {
        if (instancia == null)
        {
            instancia = new Singleton();
        }

        return instancia;
    }
}

class Config
{
    public string Tema { get; set; }
    public int Volumen { get; set; }

    public Config()
    {
        Tema = "Claro";
        Volumen = 50;
    }
}

class SinConstructor
{
    public string Texto;
}

class Program
{
    static void Main()
    {
        Rectangulo r1 = new Rectangulo();
        Rectangulo r2 = new Rectangulo(5);
        Rectangulo r3 = new Rectangulo(10, 4);

        Console.WriteLine(r1.Area());
        Console.WriteLine(r2.Area());
        Console.WriteLine(r3.Area());

        Persona p1 = new Persona();
        p1.Nombre = "Lucas";

        Persona p2 = new Persona { Nombre = "Ana" };

        Console.WriteLine(p1.Id);
        Console.WriteLine(p2.Id);

        Fraccion f1 = new Fraccion(4, 2);
        Fraccion f2 = new Fraccion(5);

        Console.WriteLine(f1.Numerador + "/" + f1.Denominador);
        Console.WriteLine(f2.Numerador + "/" + f2.Denominador);

        Jugador jugador = new Jugador("Carlos");

        jugador.Mover(1, 0).Atacar();

        Singleton s1 = Singleton.ObtenerInstancia();
        Singleton s2 = Singleton.ObtenerInstancia();

        Console.WriteLine(s1 == s2);

        Config config = new Config();

        Console.WriteLine(config.Tema);
        Console.WriteLine(config.Volumen);

        SinConstructor obj = new SinConstructor();

        obj.Texto = "C# crea constructor vacio automaticamente";

        Console.WriteLine(obj.Texto);
    }
}
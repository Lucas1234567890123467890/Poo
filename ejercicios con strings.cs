using System;

class CuentaBancaria
{
    private decimal _saldo;
    private string _clave;
    public readonly int IdCuenta;
    public const decimal IVA = 0.21m;

    private static int contador = 1;

    public CuentaBancaria(decimal saldoInicial)
    {
        _saldo = saldoInicial;
        IdCuenta = contador++;
    }

    public decimal Saldo
    {
        get { return _saldo; }
    }

    public string Clave
    {
        set { _clave = value; }
    }

    public void Depositar(decimal monto)
    {
        if (monto > 0)
        {
            _saldo += monto;
            Console.WriteLine("Deposito realizado.");
        }
    }

    public void Retirar(decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("Monto invalido.");
        }
        else if (monto > _saldo)
        {
            Console.WriteLine("No hay saldo suficiente.");
        }
        else
        {
            _saldo -= monto;
            Console.WriteLine("Retiro realizado.");
        }
    }
}

class Temperatura
{
    private double _grados;

    public double Grados
    {
        get { return _grados; }
        set
        {
            if (value > -273)
            {
                _grados = value;
            }
            else
            {
                Console.WriteLine("La temperatura no puede ser menor a -273.");
            }
        }
    }
}

class Rectangulo
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public double Perimetro
    {
        get { return 2 * (Ancho + Alto); }
    }
}

class Persona
{
    private string _nombre;
    private int _edad;

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public int Edad
    {
        get { return _edad; }
        set
        {
            if (value >= 0 && value <= 150)
            {
                _edad = value;
            }
            else
            {
                Console.WriteLine("Edad invalida.");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        CuentaBancaria cuenta = new CuentaBancaria(1000);

        cuenta.Depositar(500);
        cuenta.Retirar(300);
        cuenta.Retirar(2000);

        Console.WriteLine("Saldo actual: " + cuenta.Saldo);
        Console.WriteLine("ID Cuenta: " + cuenta.IdCuenta);
        Console.WriteLine("IVA: " + CuentaBancaria.IVA);

        cuenta.Clave = "1234";

        Temperatura temp = new Temperatura();
        temp.Grados = 25;
        Console.WriteLine("Temperatura: " + temp.Grados);

        temp.Grados = -500;

        Rectangulo r = new Rectangulo();
        r.Ancho = 5;
        r.Alto = 10;

        Console.WriteLine("Perimetro: " + r.Perimetro);

        Persona persona = new Persona();
        persona.Nombre = "Lucas";
        persona.Edad = 20;

        Console.WriteLine("Nombre: " + persona.Nombre);
        Console.WriteLine("Edad: " + persona.Edad);

        persona.Edad = 200;
    }
}
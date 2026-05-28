using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Clases_01
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string info()
        {

            if (esMayor)
                return $"{nombre}, {apellido} es mayor y tiene {edad} año";
            return $"{nombre}, {apellido} tiene {edad} año";
        }

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        private bool esMayor => edad > 18;
    }

    internal class Program
    {
        static Persona persona_1, persona_2, persona_3;


        static void Main(string[] args)
        {

            persona_1 = new Persona("Pablo", "Fiscella", 50);
            persona_2 = new Persona("Andrea", "Perez", 40);

            persona_1.Nombre = "pedro";
            Console.WriteLine(persona_1.Nombre);

            Console.WriteLine($"Persona 1 {persona_1.info()}");
            Console.WriteLine($"Persona 2 {persona_2.info()}");

            Console.ReadKey();
        }
    }
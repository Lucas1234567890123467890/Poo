using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_01
{
    class Persona
    {
        public string nombre;
        public string apellido;


        public string info()
        {
            return $"{nombre}, {apellido}";
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }

    internal class Program
    {
        static Persona persona_1, persona_2, persona_3;


        static void Main(string[] args)
        {

            persona_1 = new Persona("Pablo", "Fiscella");
            persona_2 = new Persona("Andrea", "Perez");

            Console.WriteLine($"Persona 1 {persona_1.info()}");
            Console.WriteLine($"Persona 2 {persona_2.info()}");

            Console.ReadKey();
        }
    }
}
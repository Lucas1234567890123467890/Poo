using System;
using System.Collections.Generic;

namespace SistemaAdopcion
{
    class Program
    {
        static void Main(string[] args)
        {
            CentroAdopcion centro = new CentroAdopcion();

            centro.AgregarAnimal(new Perro("Max", "Labrador"));
            centro.AgregarAnimal(new Gato("Michi", "Siames"));
            centro.AgregarAnimal(new Perro("Rocky", "Bulldog"));

            centro.RegistrarPersona(new Persona("Juan Perez", "12345678"));
            centro.RegistrarPersona(new Persona("Maria Gomez", "87654321"));

            int opcion;

            do
            {
                Console.WriteLine("\n===== CENTRO DE ADOPCION =====");
                Console.WriteLine("1. Mostrar animales disponibles");
                Console.WriteLine("2. Registrar nueva persona");
                Console.WriteLine("3. Adoptar una mascota");
                Console.WriteLine("4. Mostrar adoptantes y sus mascotas");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opcion: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese un numero valido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        centro.MostrarAnimalesDisponibles();
                        break;

                    case 2:
                        Console.Write("Ingrese nombre: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Ingrese DNI: ");
                        string dni = Console.ReadLine();

                        centro.RegistrarPersona(new Persona(nombre, dni));

                        Console.WriteLine("Persona registrada correctamente.");
                        break;

                    case 3:
                        centro.MostrarPersonas();

                        Console.Write("Ingrese el DNI de la persona: ");
                        string dniBusqueda = Console.ReadLine();

                        Persona persona = centro.BuscarPersona(dniBusqueda);

                        if (persona == null)
                        {
                            Console.WriteLine("La persona no esta registrada.");
                            break;
                        }

                        centro.MostrarAnimalesDisponibles();

                        Console.Write("Ingrese el numero del animal a adoptar: ");

                        int indice;

                        if (!int.TryParse(Console.ReadLine(), out indice))
                        {
                            Console.WriteLine("Indice invalido.");
                            break;
                        }

                        centro.AdoptarAnimal(persona, indice - 1);

                        break;

                    case 4:
                        centro.MostrarAdoptantes();
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }

            } while (opcion != 5);
        }
    }

    class Animal
    {
        public string Nombre { get; }
        public string Raza { get; }

        public Animal(string nombre, string raza)
        {
            Nombre = nombre;
            Raza = raza;
        }

        public virtual string HacerSonido()
        {
            return "Sonido";
        }
    }

    class Perro : Animal
    {
        public Perro(string nombre, string raza) : base(nombre, raza)
        {
        }

        public override string HacerSonido()
        {
            return "Guau";
        }
    }

    class Gato : Animal
    {
        public Gato(string nombre, string raza) : base(nombre, raza)
        {
        }

        public override string HacerSonido()
        {
            return "Miau";
        }
    }

    class Persona
    {
        public string Nombre { get; }
        public string DNI { get; }

        private List<Animal> mascotasAdoptadas;

        public Persona(string nombre, string dni)
        {
            Nombre = nombre;
            DNI = dni;
            mascotasAdoptadas = new List<Animal>();
        }

        public void AdoptarMascota(Animal animal)
        {
            mascotasAdoptadas.Add(animal);
        }

        public List<Animal> ObtenerMascotas()
        {
            return mascotasAdoptadas;
        }
    }

    class CentroAdopcion
    {
        private List<Animal> animalesDisponibles;
        private List<Persona> personas;

        public CentroAdopcion()
        {
            animalesDisponibles = new List<Animal>();
            personas = new List<Persona>();
        }

        public void AgregarAnimal(Animal animal)
        {
            animalesDisponibles.Add(animal);
        }

        public void RegistrarPersona(Persona persona)
        {
            personas.Add(persona);
        }

        public void MostrarAnimalesDisponibles()
        {
            Console.WriteLine("\n=== ANIMALES DISPONIBLES ===");

            if (animalesDisponibles.Count == 0)
            {
                Console.WriteLine("No hay animales disponibles.");
                return;
            }

            for (int i = 0; i < animalesDisponibles.Count; i++)
            {
                Animal animal = animalesDisponibles[i];

                Console.WriteLine(
                    $"{i + 1}. Tipo: {animal.GetType().Name} | " +
                    $"Nombre: {animal.Nombre} | " +
                    $"Raza: {animal.Raza} | " +
                    $"Sonido: {animal.HacerSonido()}"
                );
            }
        }

        public void MostrarPersonas()
        {
            Console.WriteLine("\n=== PERSONAS REGISTRADAS ===");

            foreach (Persona persona in personas)
            {
                Console.WriteLine($"Nombre: {persona.Nombre} - DNI: {persona.DNI}");
            }
        }

        public Persona BuscarPersona(string dni)
        {
            foreach (Persona persona in personas)
            {
                if (persona.DNI == dni)
                {
                    return persona;
                }
            }

            return null;
        }

        public void AdoptarAnimal(Persona persona, int indiceAnimal)
        {
            if (indiceAnimal < 0 || indiceAnimal >= animalesDisponibles.Count)
            {
                Console.WriteLine("El animal seleccionado no existe.");
                return;
            }

            Animal animal = animalesDisponibles[indiceAnimal];

            persona.AdoptarMascota(animal);

            animalesDisponibles.Remove(animal);

            Console.WriteLine($"{persona.Nombre} adopto a {animal.Nombre} correctamente.");
        }

        public void MostrarAdoptantes()
        {
            Console.WriteLine("\n=== ADOPTANTES Y SUS MASCOTAS ===");

            foreach (Persona persona in personas)
            {
                Console.WriteLine($"\nPersona: {persona.Nombre} - DNI: {persona.DNI}");

                List<Animal> mascotas = persona.ObtenerMascotas();

                if (mascotas.Count == 0)
                {
                    Console.WriteLine("No adopto mascotas.");
                }
                else
                {
                    foreach (Animal animal in mascotas)
                    {
                        Console.WriteLine(
                            $"- {animal.GetType().Name}: {animal.Nombre} ({animal.Raza})"
                        );
                    }
                }
            }
        }
    }
}
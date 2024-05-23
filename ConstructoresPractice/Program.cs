using PracticadeConstructores;

class Instancias
{
    static void Main(string[] args)
    {
        // Crea una instancia de la clase Persona sin parámetros
        Persona persona1 = new Persona();
        Console.WriteLine("Datos de la persona 1:");
        Console.WriteLine("Nombre: " + persona1.Nombre + " " + persona1.Apellido + ", Edad: " + persona1.Edad);

        // Crea una instancia de la clase Persona con parámetros
        Persona persona2 = new Persona("Juan", "Perez", 30);
        Console.WriteLine("\nDatos de la persona 2:");
        Console.WriteLine("Nombre: " + persona2.Nombre + " " + persona2.Apellido + ", Edad: " + persona2.Edad);
    }
}

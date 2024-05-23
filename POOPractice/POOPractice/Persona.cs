using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOPractice
{
    public class Persona
    {
        public String? Nombre { get; set; }
        public String? Apellido { get; set; }
        public int? Edad { get; set; }

        //constructor sin parametros
        public Persona() { 
        }
        //constructor con parametros
        public Persona(String nombre, String apellido, int edad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Me llamo " + Nombre);
            Console.WriteLine(" Mi apellido es " + Apellido);
            Console.WriteLine(" y tengo" + Edad + "años de edad");
        }
    }
}

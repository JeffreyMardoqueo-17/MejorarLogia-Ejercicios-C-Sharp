using System;
using System.Collections.Generic; // Necesario para usar List<T>

namespace Delegados
{
    // Declaración del delegado
    public delegate void MiDelegado(string mensaje);

    public delegate void Lista(List<string> lista);

    class Program
    {
        static void Main(string[] args)
        {
            // Inicialización del delegado con el método PrintMessage
            MiDelegado del = PrintMessage;
            Lista listaNombre = ImprimirLista;

            // Llamada al delegado
            del("Hola aqui esta funcionando");

            // Creación de la lista y llamada al delegado
            List<string> nombres = new List<string> { "Jeffrey", "Mardoqueo", "Jimenez", "Santos" };
            listaNombre(nombres);
        }

        // Método que coincide con la firma del delegado Lista
        public static void ImprimirLista(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine((i + 1) + " - " + lista[i]);
            }
        }

        // Método que coincide con la firma del delegado MiDelegado
        public static void PrintMessage(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}

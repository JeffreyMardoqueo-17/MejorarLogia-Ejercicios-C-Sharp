using System;

class Program
{
    static void Main()
    {
        string[] palabras = { "Hola", "amor", "love", "vida" };
        string palabra = "love";

        int indice = BusquedaString(palabras, palabra);

        if (indice != -1)
            Console.WriteLine($"La palabra '{palabra}' se encuentra en la posición {indice}");
        else
            Console.WriteLine($"La palabra '{palabra}' no se encuentra");
    }

    static int BusquedaString(string[] array, string palabra)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == palabra)
                return i;
        }
        return -1;
    }
}

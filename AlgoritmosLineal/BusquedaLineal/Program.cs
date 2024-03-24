using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 5, 52, 53, 1, 5, 2, 245, 6 };
        int objeto = 245; // número a buscar

        int indice = BusquedaLineal(numeros, objeto);

        if (indice != -1)
            Console.WriteLine($"El número {objeto} se encuentra en la posición {indice}");
        else
            Console.WriteLine($"El número {objeto} no se encuentra en el arreglo");
    }

    static int BusquedaLineal(int[] array, int objeto)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == objeto)
                return i;
        }
        return -1;
    }
}

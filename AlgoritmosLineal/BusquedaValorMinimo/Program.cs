using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 8, 2, 4, 1, 6, 1, 7 };
        int indiceMinimo = BusquedaMinimo(numeros); //kamo la funsion y le paso el array

        Console.WriteLine($"El valor mínimo es {numeros[indiceMinimo]} y se encuentra en la posición {indiceMinimo}");
    }

    // Función para buscar el índice del valor mínimo en un arreglo de enteros
    static int BusquedaMinimo(int[] array)
    {
        // Inicializar el índice del mínimo como 0
        int indiceMinimo = 0;

        // Recorrer el arreglo a partir del segundo elemento
        for (int i = 1; i < array.Length; i++)
        {
            // Si el elemento actual es menor que el mínimo encontrado hasta ahora
            if (array[i] < array[indiceMinimo])
                // Actualizar el índice del mínimo
                indiceMinimo = i;
        }
        // Devolver el índice del valor mínimo encontrado
        return indiceMinimo;
    }
}

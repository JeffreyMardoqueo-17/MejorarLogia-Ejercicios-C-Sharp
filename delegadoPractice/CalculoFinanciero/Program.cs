public delegate decimal CalculoFinanciero(decimal[] datos);

public class AnalizadorFinanciero
{
    public decimal EjecutarCalculo(CalculoFinanciero calculo, decimal[] datos)
    {
        return calculo(datos);
    }
}

// Definición de diferentes cálculos
public class Calculos
{
    public static decimal SumaTotal(decimal[] datos) => datos.Sum();
    public static decimal Promedio(decimal[] datos) => datos.Average();
}

// Uso de los cálculos
class Program
{
    static void Main()
    {
        var analizador = new AnalizadorFinanciero();
        decimal[] datos = { 100m, 200m, 300m };

        // Pasando diferentes cálculos usando delegados
        decimal suma = analizador.EjecutarCalculo(Calculos.SumaTotal, datos);
        decimal promedio = analizador.EjecutarCalculo(Calculos.Promedio, datos);

        Console.WriteLine($"Suma: {suma}, Promedio: {promedio}");
    }
}

using System;

namespace OpercacionesDelgados
{
    public delegate void Suma(int num1, int num2);
    public delegate void Resta(int num1, int num2);
    public delegate void Multiplicacion(int num1, int num2);
    public delegate void Division(int num1, int num2);

    public class Program
    {
        public static void Main(string[] args)
        {
            Suma sumar1 = OperacionSumar;
            Resta restar1 = OperacionRestar;
            Multiplicacion multiplicar1 = OperacionMultiplicar;
            Division dividir1 = OperacionDividir;

            sumar1(10, 5);
            restar1(10, 5);
            multiplicar1(10, 5);
            dividir1(10, 5);

        }

        public static void OperacionSumar(int num1, int num2){
            int resultado;
            resultado = num1 + num2;
            Console.WriteLine("El resultado de la suma es: " + resultado);
        }

        public static void OperacionRestar(int num1, int num2){
            int resultado;
            resultado = num1 - num2;
            Console.WriteLine("El resultado de la resta es: " + resultado);
        }

        public static void OperacionMultiplicar(int num1, int num2){
            int resultado;
            resultado = num1 * num2;
            Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
        }

        public static void OperacionDividir(int num1, int num2){
            int resultado;
            resultado = num1 / num2;
            Console.WriteLine("El resultado de la division es: " + resultado);
        }
    }
}
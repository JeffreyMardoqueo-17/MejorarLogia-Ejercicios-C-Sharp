
using BancoSimplePOO;

Cuenta cuenta = new Cuenta();

Console.WriteLine("HOLA BIENVENIDO A TU BANCO");

Console.WriteLine("Ingrese su nombre: ");
cuenta.Titular = Console.ReadLine();

Console.WriteLine("Ingrese la Cantidad");
cuenta.cantidad = double.Parse(Console.ReadLine());

Console.WriteLine(cuenta.ToString());

Console.WriteLine("Desea retirar dinero? (s/n)");
string respuesta = Console.ReadLine();

if (respuesta == string.Empty || respuesta == "s")
{
    Console.WriteLine("Ingrese la cantidad a retirar");
    double cantidad = double.Parse(Console.ReadLine());
    cuenta.Retirar();
    Console.WriteLine(cuenta.ToString());
}
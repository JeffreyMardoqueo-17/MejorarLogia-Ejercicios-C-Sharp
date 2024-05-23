public class Persona
{
    string Nombre { get; set; }
    string Apellido { get; set; }
    int Edad { get; set; }

    public Persona()
    {
        Nombre = "Nombre";
        Apellido = "Apellido";
        Edad = 0;
    }
    public Persona(string Nombre; string Apellido; int Edad)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Edad = Edad;
    }
}
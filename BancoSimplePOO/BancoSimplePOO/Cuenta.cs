using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSimplePOO
{

    public class Cuenta
    {
        public String Titular { get; set; }
        public double cantidad { get; set; }

        public Cuenta(String titular, double cantidad = 0.0)
        {
            //si titular no es null entonces this.Titular = titular, sino lanza una excepcion
            this.Titular = titular ?? throw new ArgumentNullException(nameof(titular));
            this.cantidad = cantidad;
        }
        public Cuenta()
        {

        }
        
        //sobre carga de metodos y ToString
        public override string ToString()
        {
            return $"Titular: {this.Titular}, Cantidad: {this.cantidad}";
        }

        public void Ingresar()
        {
            double cantidad = this.cantidad;
            if (cantidad > 0)
            {
                this.cantidad += cantidad; //this.cantidad = this.cantidad + cantidad 
            }
        }
        public void Retirar()
        {
            double canetirar = this.cantidad;
            if (cantidad > 0)
            {
                if (this.cantidad - cantidad < 0)  //si la this.cantidad - cantidad es menor a 0 
                    this.cantidad = 0.0;
                else
                    this.cantidad -= cantidad; //this.cantidad = this.cantidad - cantidad 
            }
        }
    }
}

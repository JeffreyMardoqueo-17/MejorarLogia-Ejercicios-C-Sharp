using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace POOPractice
{
    public class Jeffrey: Persona
    {
        public String ?Carrera { get; set; }
        public String ?Novia { get; set; }

        public Jeffrey()
        {

        }
        public Jeffrey(String carrera, String novia)
        {
            this.Carrera = carrera;
            this.Novia = novia;
        }

        [PreserveBaseOverrides]
        public void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Mi carrera es: " + Carrera);
            Console.WriteLine("Mi novia es: " + Novia);
        }
        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando");
        }
    }
}

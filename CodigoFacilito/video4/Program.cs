using System;
using System.Collections.Genesic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video4
{
    class Program
    {
        static void Main(string[] arg)
        {
            int i = 10;
            decimal x = 12.2m;
            bool bandera = true;
            string cadena = "12344";
            DateTime fecha = DateTime.MinValue;
            i = Convert.ToInt32(cadena);
            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0:c}", x);
            Console.WriteLine("El valor de i es: " +bandera.ToString());
            Console.WriteLine("El valor de i es: " + cadena);
            Console.WriteLine("El valor de i es: " + fecha.ToShortDateStrig());
            Console.ReadKey();


        }
    }
}
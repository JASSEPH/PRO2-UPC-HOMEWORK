using Sistem;
using Sistem.Collections.Genesic;
using Sistem.Linq;
using Sistem.Text;
using Sistem.Threading.Tasks;

namespace video3
{
     class programa
     {
         static void Main(string[] args)
            {
                int i = 0;
                decimal x = 0.0m;
                float f = 0.0f;
                double d = 0.0D;
                string cadena = "Hola Mundo";
                bool bandera = false;
                DateaTime fecha = DateTime.MinValue;
                Console.WriteLine("el valor de i es: ¨{0}", i);
                Console.WriteLine("el valor de x es: ¨{0:C}", x);
                Console.WriteLine("el valor de f es: ¨{0:F2}", f);
                Console.WriteLine("el valor de d es: ¨{0:F2}", d);
                Console.WriteLine("el valor de cadena es: ", + cadena);
                Console.WriteLine("el valor de bandera es: " + bandera.ToString() );
                Console.WriteLine("el valor de fecha es: " + fecha.ToShortDateStrig());
                Console.ReadKey();
            }    
        

     }
}


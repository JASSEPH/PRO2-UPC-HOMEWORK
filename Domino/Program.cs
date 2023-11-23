namespace Programacion2jass
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //long f = Factorial(64);
           //Console.WriteLine(f);
           GenerarSerieV1Recursivo(6);
        }   
        static int A = 0;
        static int B = 7;
         public static void GenerarSerieV1Recursivo(int N){
            
            if(N == 0){
                return;
            }else{
                GenerarSerieV1Recursivo(N - 1); 
                int serie1 = A + 1;
                int serie2 = B - 1;
                Console.WriteLine("Serie: " + serie1);
                Console.WriteLine("Serie: " + serie2);
                A = serie1;    
                B = serie2;
            }
        }


    }
}
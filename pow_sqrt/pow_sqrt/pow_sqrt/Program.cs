// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;


namespace yaz
{
    class Program
    {
        static void Main()
        {
            int choise;
            Console.Write("kare alma işlemi için 1 e basın , karekök işlemi için 2 ye basın ");
            choise = int.Parse(Console.ReadLine());
            if (choise == 1){
                Console.WriteLine("taban değeri ve üs değerini girin");
                int taban, üs;
                taban = int.Parse(Console.ReadLine());
                üs = int.Parse(Console.ReadLine());
                My_calculation.my_pow(taban, üs);

            }
            if (choise == 2)
            {
                Console.Write("karekökü alınacak sayıyı girin");
                int sayi;
                sayi = int.Parse(Console.ReadLine());
                My_calculation.my_sqrt(sayi);

            }


        }
        class My_calculation
        {
            public static void my_pow(int a,int b)
            {
                int result;
                
                result = 1;
                for (int i = 0; i < b; i++)
                {
                    result = result * a;
                    
                }
                Console.WriteLine(result);
                Console.ReadKey();

            }
            public static void my_sqrt(double a)
            {
                double x1 = 0;
                double x2 = a / 2;
                do
                {
                    x1 = x2;
                    x2 = (x1 + (a / x1)) / 2;
                }
                while (x2 - x1 != 0)
;                Console.WriteLine(x2);

            }

        }

    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Klavyeden verilmis 2 sayinin çarpimi tek mi çift mi oldugunu gösteren programlama");


            int sayi1 = 0;
            bool kontrol = false;
            do
            {
                Console.Write("Birinci sayiyi giriniz: ");
                string sayi11 = Console.ReadLine();
                try
                {
                    sayi1 = Convert.ToInt32(sayi11);
                    kontrol = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen sayi giriniz: ");
                }
            } while (kontrol == false);

            int sayi2 = 0;
            do
            {
                Console.Write("Ikinci sayiyi giriniz: ");
                string sayi22 = Console.ReadLine();
                try
                {
                    sayi2 = Convert.ToInt32(sayi22);
                    kontrol = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen sayi giriniz: ");
                }
            } while (kontrol == false);


            int çarpim = sayi1 * sayi2;
            float mod2kalani = çarpim % 2;
            Console.Write("Sayilarin çarpimi: " + çarpim + "'dir. ");

            if (mod2kalani == 0)
            {
                int sayi3 = sayi1 - sayi2;
                Console.WriteLine("Sayilar çifttir.");
            }
            else if (mod2kalani != 0)
            {
                int sayi4 = sayi2 - sayi1;
                Console.WriteLine("Sayilar tektir.");

            }


            Console.Read();


        }
    }
}

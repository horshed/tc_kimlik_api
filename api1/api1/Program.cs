using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long tc;
            string ad, soyad;
            int yil;
            Console.WriteLine("tc girin");
            tc = long.Parse(Console.ReadLine());
            Console.WriteLine("adınızı girin");
            ad = Console.ReadLine();
            Console.WriteLine("soyadınızı girin");
            soyad = Console.ReadLine();
            Console.WriteLine("yıl girin");
            yil = Convert.ToInt32(Console.ReadLine());
            kimlik.KPSPublicSoapClient kontrol=new kimlik.KPSPublicSoapClient();
            bool durum;
            durum = kontrol.TCKimlikNoDogrula(tc, ad, soyad, yil);
            if (durum==true)
            {
                Console.WriteLine("doru");
            }
            else
            {
                Console.WriteLine("yanlış");
            }
            Console.Read();
        }
    }
}

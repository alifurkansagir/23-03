using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatematikIslemleri;

namespace MatematikIslemleri
{
    public class Hesaplama
    {
        public int toplama(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}

namespace Odev_NamespaceVeGenisletilebilirlik
{
    class Program
    {
        static void Main(string[] args)
        {
            Hesaplama hesaplama = new Hesaplama();

            int toplamSonucu = hesaplama.toplama(8, 3);
            int carpimSonucu = hesaplama.carpma(8, 3);

            Console.WriteLine($"Toplam: {toplamSonucu}");
            Console.WriteLine($"Çarpım: {carpimSonucu}");
        }
    }
}

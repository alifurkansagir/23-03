using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciYonetimi
{
    public class User
    {
        private string isim;
        private string soyisim;
        private int yas;
        public string Email { get; set; }

        public string GetIsim()
        {
            return isim;
        }

        public void SetIsim(string isim)
        {
            this.isim = isim;
        }

        public string GetSoyisim()
        {
            return soyisim;
        }

        public void SetSoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }
        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int age)
        {
            if (age > 0)
                yas = age;
            else
                Console.WriteLine("Yas negatif olamaz!");
        }

        public void BilgileriGoster()
        {
            Console.WriteLine($"Isim: {isim}\n" +
                $"Soyisim: {soyisim}\n" +
                $"Yas: {yas}\n" +
                $"Email: {Email}");
        }
    }
}

namespace Odev_ErisimBelirleyicilerVeDegiskenler
{
    using KullaniciYonetimi;
    public class Program
    {
        static void Main(string[] args)
        {
            User kullanici = new User();
            kullanici.SetIsim("Ali furkan");
            kullanici.SetSoyisim("Sağır");
            kullanici.SetYas(22);
            kullanici.Email = "alifurkan309@gmail.com";
            kullanici.BilgileriGoster();
        }
    }
}

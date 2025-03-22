double[] sayilar = new double[5];

double toplam = 0;

Console.WriteLine("Lütfen 5 tane sayı giriniz");

for (int i = 0; i < sayilar.Length; i++)
{
    Console.Write($"Sayı {i + 1}: ");

    sayilar[i] = Convert.ToDouble(Console.ReadLine());

    toplam += sayilar[i];
}

double ortalama = toplam / sayilar.Length;

Console.WriteLine($"Girilen sayıların ortalaması: {ortalama}");
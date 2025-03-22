Random random = new Random();
int rastgeleSayi = random.Next(1, 101);
int tahmin = 0;
int tahminSayisi = 0;

Console.WriteLine("Sayi tahmin oyununa hosgeldiniz. 1 ile 100 arasinda bir sayi tahmin edin");

while (tahmin != rastgeleSayi)
{
    Console.Write("Tahmininiz:");
    string sayi = Console.ReadLine();

    if (int.TryParse(sayi, out tahmin))
    {
        tahminSayisi++;

        if (tahmin < rastgeleSayi)
        {
            Console.WriteLine("Daha buyuk bir sayi giriniz");
        }

        else if (tahmin > rastgeleSayi)
        {
            Console.WriteLine("Daha kucuk bir sayi giriniz");
        }

        else
        {
            Console.WriteLine($"Tebrikler {tahminSayisi}. tahminde dogru bildiniz.");
        }
    }

    else
    {
        Console.WriteLine("Lutfen gecerli bir sayi giriniz.");
    }
}
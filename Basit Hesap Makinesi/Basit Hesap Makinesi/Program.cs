while (true)
{
    Console.Write("Birinci Sayiyi Giriniz: ");
    int sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ikinci Sayiyi Giriniz: ");
    int sayi2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Yapmak istediginiz islemi seciniz:\n" +
        "'+' : Toplama\n" +
        "'-' : Cikarma\n" +
        "'*' : Carpma\n" +
        "'/' : Bolme\n" +
        "'q' : Cikis");
    Console.Write("Seciminiz:");
    char islem = Convert.ToChar(Console.ReadLine());

    if (islem == '+')
    {
        Console.WriteLine($"Sonuc: {sayi1 + sayi2}");
    }
    else if (islem == '-')
    {
        Console.WriteLine($"Sonuc: {sayi1 - sayi2}");
    }
    else if (islem == '*')
    {
        Console.WriteLine($"Sonuc: {sayi1 * sayi2}");
    }
    else if (islem == '/')
    {
        if (sayi2 != 0)
        {
            Console.WriteLine($"Sonuc: {sayi1 / sayi2}");
        }
        else
        {
            Console.WriteLine("Sifira bolme islemi yapilamaz.");
        }
    }
    else if (islem == 'q' || islem == 'Q')
    {
        Console.WriteLine("Programdan cikiliyor.");
        break;
    }
    else
    {
        Console.WriteLine("Gecersiz islem!!");
    }
    Console.WriteLine();
}
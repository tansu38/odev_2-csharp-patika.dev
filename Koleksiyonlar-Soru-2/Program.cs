// Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

using System.Collections;

ArrayList girilenSayilar = new ArrayList();
ArrayList ilkUcSayi = new ArrayList(); // en küçük üç sayi yer alır
ArrayList sonUcSayi =new ArrayList();  //en büyük üç sayi yer alır

Console.WriteLine("LÜtfen 20 adet sayi giriniz!");



string sayi;
    for (int i = 1; i <= 20; i++)
        {
            Console.Write($"{i}. sayiyi giriniz:");
            sayi = Console.ReadLine();
            try
            {   
                girilenSayilar.Add(Convert.ToInt32(sayi));
            }
            catch
            {
                Console.WriteLine("Hatali giriş! Bir sayi giriniz:");
                i--;
            }
        }

girilenSayilar.Sort();

ilkUcSayi.Add(girilenSayilar[0]);
ilkUcSayi.Add(girilenSayilar[1]);
ilkUcSayi.Add(girilenSayilar[2]);

sonUcSayi.Add(girilenSayilar[girilenSayilar.Count-1]);
sonUcSayi.Add(girilenSayilar[girilenSayilar.Count-2]);
sonUcSayi.Add(girilenSayilar[girilenSayilar.Count-3]);

int kucukSayilarTop = 0;
int buyukSayilarTop = 0;
foreach (var item in ilkUcSayi)
{
    kucukSayilarTop+= Convert.ToInt32(item);
}
foreach (var item in sonUcSayi)
{
    buyukSayilarTop+= Convert.ToInt32(item);
}

Console.WriteLine($"Girilen sayılardan en küçük 3'ünün ortalaması:{(double)kucukSayilarTop/3}");
Console.WriteLine($"Girilen sayılardan en büyük 3'ünün ortalaması:{(double)buyukSayilarTop/3}");
Console.WriteLine($"İki ortalamanın toplamı:{((double)kucukSayilarTop/3)+((double)buyukSayilarTop/3)} ");
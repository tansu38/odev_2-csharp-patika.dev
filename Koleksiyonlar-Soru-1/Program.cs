/* Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/

using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("20 adet sayi giriniz:");
        ArrayList girilenSayilar = new ArrayList();
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanSayilar = new ArrayList();
        string sayi;
        for (int i = 1; i <= 20; i++)
        {
            Console.Write($"{i}. sayiyi giriniz:");
            sayi = Console.ReadLine();
            try
            {
            if (Convert.ToInt16(sayi) < 0)
            {
                Console.WriteLine("Negatif sayi girdiniz! Pozitif bir sayi giriniz:");
                i--;
            }
            else
            {
                girilenSayilar.Add(sayi);
            }
            }
            catch
            {
                Console.WriteLine("Hatali giriş! Bir sayi giriniz:");
                i--;
            }
        }
            int asalToplam = 0;
            int asalOlmayanToplam = 0;
        foreach (var deger in girilenSayilar)
        {   int deger1 = Convert.ToInt32(deger);
            int asalMi=0;
            if(deger1==1||deger1==0)
               asalMi++;
            else
            {
                for(int i=2; i<deger1; i++)
                {
                   if(deger1%i==0 && deger1!=2)
                   asalMi++;
                }
            }
            if(asalMi==0)
            {
                asalSayilar.Add(deger1);
                asalToplam+=deger1;
            }
            else
            {
                asalOlmayanSayilar.Add(deger1);
                asalOlmayanToplam += deger1;
            }
        }

        asalSayilar.Sort();

       

        Console.Write("Asal sayilar:");
        foreach (var item in asalSayilar)
        {
            Console.Write($"{item} ");
        }

        asalOlmayanSayilar.Sort();

        Console.WriteLine("");
        Console.Write("Asal olmayan sayilar:");

        foreach (var item in asalOlmayanSayilar)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("");
        Console.WriteLine($"Asal sayilarin adeti:{asalSayilar.Count}. Ortalamasi={asalToplam/asalSayilar.Count}");
        Console.WriteLine($"Asal olmayan sayilarin adeti:{asalOlmayanSayilar.Count}. Ortalamasi={asalOlmayanToplam/asalOlmayanSayilar.Count}");

    }
}
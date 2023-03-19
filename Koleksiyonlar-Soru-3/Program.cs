// Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

Console.WriteLine("***** Cümle içerisindeki Sesli harlerin bulunması *****");
Console.WriteLine("Bir cümle yaziniz:");
string girilenCumle = Console.ReadLine();
char[] harfler = girilenCumle.ToCharArray();

Console.Write("Girilen cümlede yer alan sesli harfler: ");
foreach (var item in harfler)
{
    if(item=='a'||item=='e'||item=='ı'||item=='i'||item=='o'||item=='ö'||item=='u'||item=='ü')
    {
       Console.Write($" {item}"); 
    }
    
}
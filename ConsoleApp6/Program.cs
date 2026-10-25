int[] rndsayılar = { 3, 67, 12, 89, 34, 56, 78, 90, 21, 107 };
Console.WriteLine("Rastgele sayılar: 3, 67, 12, 89, 34, 56, 78, 90, 21, 107");

int enb = rndsayılar[0];
int enk = rndsayılar[0];

foreach (int sayı in rndsayılar)
{
    if (sayı > enb)
    {
        enb = sayı;
    }
    if (sayı < enk)
    {
        enk = sayı;
    }
}
Console.WriteLine("En büyük sayı: " + enb);
Console.WriteLine("En küçük sayı: " + enk);

Console.WriteLine(" --------------------- ");

foreach (int sayı in rndsayılar) 
if (sayı % 2 == 0)
{
    Console.WriteLine( sayı + "sayı çift sayıdır:");
}
else
{
    Console.WriteLine( sayı + "sayı tek sayıdır:");
}

Console.WriteLine(" --------------------- ");

Console.WriteLine("Lütfen bir sayı giriniz: ");
string a = Console.ReadLine();

foreach (int sayı in rndsayılar)
{
    if (sayı > int.Parse(a))
    
    Console.WriteLine("Girilen sayıdan büyük olan sayıyı yazıyroum: ");
    Console.WriteLine(sayı);
    
}




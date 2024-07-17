int sayi;

Console.WriteLine("Lütfen bir sayı giriniz:");
string StrSayi= Console.ReadLine();

sayi = Convert.ToInt32(StrSayi);

if (sayi == 10)

{
    Console.WriteLine("Girilen sayı 10'a eşittir.");
}
else if (sayi <10 )
            
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
}

else

{
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
}




if (sayi > 0)

{
    if (sayi % 2 == 0)
    { Console.WriteLine("Girilen sayı çifttir."); }
    else { Console.WriteLine("Girilen Sayı tektir."); }
}
else
{
    Console.WriteLine("Girilen sayı negatif veya sıfırdır.");
}
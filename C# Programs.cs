/*
    String Uygulamaları
*/

string ornek = ".NET 7 ile C# Programlama Dili";

// 1- Kaç karaktere sahiptir ? 
// 2- Hepsini küçük harf yapınız.
// 3- '.' ile mi başlamaktadır ? 
// 4- C# yazısı hangi konumda bulunmaktadır ?
// 5- String 'C#' bilgisini içeriyor mu?
// 6- 'Dili' kelimesi yerine 'Dersleri' yaz.

var karakterSayisi = ornek.Length;
Console.WriteLine(karakterSayisi);

var kucukHarf = ornek.ToLower();
Console.WriteLine(kucukHarf);

var nokta = ornek.StartsWith('.');
Console.WriteLine("string . ile başlıyor: " + nokta);

var konum = ornek.IndexOf("C#");
Console.WriteLine("konum" +" "+ konum);

var iceriyormu = ornek.Contains("C#");
Console.WriteLine("C# içeriyor mu: " + iceriyormu);

var guncellenenString = ornek.Replace("Dili","Dersleri");
Console.WriteLine(guncellenenString);


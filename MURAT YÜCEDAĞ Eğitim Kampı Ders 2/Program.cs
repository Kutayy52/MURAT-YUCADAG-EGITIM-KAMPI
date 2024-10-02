Console.WriteLine("***** Fiyat Listesi *****");
Console.WriteLine();
double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
applePrice = 14.85;
orangePrice = 20.95;
strawberryPrice = 45;
potatoPrice = 9.74;
tomatoPrice = 6.88;

Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

#region Char Değişkenler
//ABCDEFGH
//DEF...
//TOPLANTI SAAT 20:00'DE
//"
char symbol;
symbol = 'a'; 
#endregion
Console.Read();

Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
Console.WriteLine();
string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
Console.Write("Yolcu Adı: ");
passengerName = Console.ReadLine(); // Kullanıcıdan ad alınır
Console.Write("Yolcu Soyadı: ");
passengerSurname = Console.ReadLine(); // Kullanıcıdan soyad alınır
Console.Write("İlçe Bilgisi: ");
passengerDistrict = Console.ReadLine();
Console.Write("Şehir Bilgisi: ");
passengerCity = Console.ReadLine(); // Eksik atama operatörü düzeltildi
Console.Write("Yolcu Yaşı: ");
passengerAge = Console.ReadLine(); // Eksik atama operatörü düzeltildi
Console.Write("Yolcu TC Kimlik No: ");
passengerIdentityNumber = Console.ReadLine(); // Eksik atama operatörü düzeltildi

Console.WriteLine(); // Boş satır ekleme
Console.WriteLine("----------------------------");
Console.WriteLine("Yolcu Bilgileri: ");
Console.WriteLine("TC Kimlik No: " + passengerIdentityNumber);
Console.WriteLine("Ad Soyad: " + passengerName + " " + passengerSurname);
Console.WriteLine("Yaş: " + passengerAge);
Console.WriteLine("İlçe ve Şehir: " + passengerDistrict + ", " + passengerCity); 

Console.Read();

#region Klavyeden Ondalıklı Sayı İşlemleri
double exam1, exam2, exam3, result;
Console.Write("Lütfen 1.Sınav notunu giriniz: "); exam1 = double.Parse(Console.ReadLine());
Console.Write("Lütfen 2.Sınav notunu giriniz: ");
exam1 = double.Parse(Console.ReadLine());
Console.Write("Lütfen 1. Sınav notunu giriniz: "); exam1 = double.Parse(Console.ReadLine());
#endregion

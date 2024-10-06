using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSE KARAR YAPILARI
            //Console.Write("Lütfen Şifreyi Giriniz:");
            //string password;
            //password = Console.ReadLine();  

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Girilen Şifre Doğru!");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Şifre Yanlış!");

            //}

            //string capital, country;
            //capital = "ankara"; country = "türkiye";
            //Console.Write("Başkent Giriniz:");
            //capital =Console.ReadLine();
            //Console.Write("Ülke Giriniz:");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı!");
            //}
            //else 
            //{ 
            //    Console.Write("Eksik yada Yanlış Veri Girildi"); 
            //}

            //int number;           
            //Console.Write("Lütfen Sayı Giriniz:");
            //number = int.Parse(Console.ReadLine());

            //if (number==5)
            //{
            //    Console.WriteLine("Doğru Sayı Girdiniz!");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış Sayı Girdiniz!");
            //}

            //int exam1, exam2, exam3, average;
            //string result="HATA!!!!";

            //Console.Write("Sınav1 Notu Giriniz:");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Sınav2 Notu Giriniz:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3 Notu Giriniz:");
            //exam3 = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınav Ortalama Puanı: "+average);
            //Console.WriteLine();

            //if(average >0 & average <=50)
            //{
            //  result= "Sonuç Vasat...";
            //}
            //if (average > 50 & average <= 70)
            //{
            //   result= "Sonuç İdare eder...";
            //}
            //if (average > 70 & average <= 85)
            //{
            //  result= "Sonuç İyi...";
            //}
            //if (average > 85 & average <= 100)
            //{
            //   result= "Sonuç Mükemmel...";
            //}

            //Console.Write(result);

            //string city;
            //Console.Write("Lütfen Şehir Adını Giriniz: ");
            //city=Console.ReadLine();

            //if(city=="ankara" | city=="Zonguldak"| city=="Bursa" |city=="sivas")
            //{
            //    Console.Write("Şehir Doğrulandı!");
            //}
            //else
            //{
            //    Console.Write("Yanlış Şehir Bilgisi! ");
            //}
            //Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
            //string Kullanici=Console.ReadLine();    

            //if(Kullanici != "admin")
            //{
            //    Console.Write("Yanlış Kullanıcı Adı!");
            //}
            //else
            //{
            //    Console.Write("Hoş Geldiniz!"); 

            #endregion

            #region  MOD İŞLEMLERİ
            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //int num1, num2, result;
            //Console.Write("Sayı1 Griniz: ");
            //num1=int.Parse(Console.ReadLine());
            //Console.Write("Sayı2 Griniz: ");
            //num2 = int.Parse(Console.ReadLine());
            //result = num1 % num2;
            //Console.Write("1Sayının 2Sayıya Bölümünden Kalan: "+result);

            //Console.Write("Lütfen sayı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}
            #endregion

            #region CHAR DEĞİŞKENLER İLE KARAR YAPILARI

            //char team;
            //Console.Write("Lütfen Takımınızın Sembolünü Girin: ");
            //team=char.Parse(Console.ReadLine());

            //if(team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");

            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");

            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");

            //}


            #endregion

            #region ÖRNEK PROJE UYGULAMASI

            //Console.WriteLine("********** C# EĞİTİM KAMPI RESTORANI **********");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar ");
            //Console.WriteLine("3-Pizzalar ");
            //Console.WriteLine("4-İçecekler ");
            //Console.WriteLine("5-Tatlılar ");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //Console.WriteLine();

            //string menuıtem;
            //Console.Write( "Detayını görmek istediğiniz menüyü seçiniz: " );
            //menuıtem= Console.ReadLine();   

            //if(menuıtem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Ana Yemekler ------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Patlıcam Musakka");
            //    Console.WriteLine("4-Izgara Köfte ");
            //    Console.WriteLine("5-Kuru Fasulye Pilav");

            //    Console.WriteLine();
            //    Console.WriteLine("-----------Ana Yemekler ------------");
            //}

            //if (menuıtem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Çorbalar------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Ezogelin Çorbası");
            //    Console.WriteLine("2-Mercimek Çorbası");
            //    Console.WriteLine("3-Tarhana Çorbası");
            //    Console.WriteLine("4-Ayranaşı Çorbası");
            //    Console.WriteLine("5-Tavuksuyu Çorbası");

            //    Console.WriteLine();
            //    Console.WriteLine("-----------Çorbalar------------");
            //}

            //if (menuıtem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Pizzalar------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Sucuklu Kaşarlı Pizza");
            //    Console.WriteLine("2-Vejeteryan Pizza");
            //    Console.WriteLine("3-Akdeniz Pizza");
            //    Console.WriteLine("4-Kuşbaşılı Pizza");
            //    Console.WriteLine("5-Karışık Pizza");

            //    Console.WriteLine();
            //    Console.WriteLine("-----------Pizzalar------------");
            //}


            //if (menuıtem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------İçecekler------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Kola");
            //    Console.WriteLine("4-Gazoz");
            //    Console.WriteLine("5-Soda");
            //    Console.WriteLine("6-Meyve Suyu");
            //    Console.WriteLine("7-Kokteyl");

            //    Console.WriteLine();
            //    Console.WriteLine("-----------İçecekler------------");
            //}

            //if (menuıtem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Tatlılar------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Kazandibi");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("3-Profiterol");
            //    Console.WriteLine("4-Spangle");
            //    Console.WriteLine("5-Triliçe");
            //    Console.WriteLine("6-Baklava");
            //    Console.WriteLine("7-Tulumba");

            //    Console.WriteLine();
            //    Console.WriteLine("-----------Tatlılar------------");
            //}

            #endregion

            #region SWİTCH CASE KARAR YAPISI

            //Console.Write("Lütfen Ay Sayısını Giriniz: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.Write("Ocak");break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //}

            #endregion

            #region SWİTCH CASE HESAP MAKİNASI

            //int num1, num2, result;
            //char symbol;

            //Console.Write("Lütefen 1 Sayıyı Giriniz: ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2 Sayıyı Giriniz: ");
            //num2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Sembolü Giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.Write(result); break;
            //    case '-':
            //        result = num1 - num2;
            //        Console.Write(result); break;
            //    case '/':
            //        result = num1 / num2;
            //        Console.Write(result); break;
            //    case '*':
            //        result = num1 * num2;
            //        Console.Write(result); break;
            //}

            //Console.Read();

            #endregion
        }
    }
}

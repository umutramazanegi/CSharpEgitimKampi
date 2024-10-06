using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            Console.WriteLine("***** Fiyat Listesi *****"); 
            Console.WriteLine();

            double elmafiyat, portakalfiyat, cilekfiyat, patatesfiyat, domatesfiyat;

            elmafiyat = 14.85;
            portakalfiyat = 20.95;
            cilekfiyat = 445;
            patatesfiyat = 9.74;
            domatesfiyat = 6.88;

            Console.WriteLine("--- Elma birim fiyatı: " +  elmafiyat);
            Console.WriteLine("--- Portakal birim fiyatı: " + portakalfiyat);
            Console.WriteLine("--- Çilek birim fiyatı: " + cilekfiyat);
            Console.WriteLine("--- Patates birim fiyatı: " + patatesfiyat);
            Console.WriteLine("--- Domates birim fiyatı: " + domatesfiyat);

            double elmagram, portakalgram, cilekgram, patatesgram, domatesgram; 
            elmagram = 1245; 
            portakalgram = 2650; 
            cilekgram = 750;
            patatesgram = 4.859;
            domatesgram = 3.745;

            double toplamelmafiyati = elmagram * elmafiyat;
            double toplamportakalfiyati = portakalgram * portakalfiyat;
            double toplamcilekfiyati = cilekgram * cilekfiyat;
            double toplampatatesfiyati = patatesgram * patatesfiyat;
            double toplamdomatesfiyati = domatesgram * domatesfiyat;

            Console.WriteLine("Alınan ürün Elma - " + "Birim Fiyatı: " + elmafiyat + 
                " - Gramaj: " + elmagram + " Toplam Tutar: " + toplamelmafiyati);

            Console.WriteLine("Alınan ürün Portakal - " + "Birim Fiyatı: " + portakalfiyat +
               " - Gramaj: " + portakalgram + " Toplam Tutar: " + toplamportakalfiyati);

            Console.WriteLine("Alınan ürün Cilek - " + "Birim Fiyatı: " + cilekfiyat +
               " - Gramaj: " + cilekgram + " Toplam Tutar: " + toplamcilekfiyati);

            Console.WriteLine("Alınan ürün Patates - " + "Birim Fiyatı: " + patatesfiyat +
                           " - Gramaj: " + patatesgram + " Toplam Tutar: " + toplampatatesfiyati);

            Console.WriteLine("Alınan ürün Domates - " + "Birim Fiyatı: " + domatesfiyat +
               " - Gramaj: " + domatesgram + " Toplam Tutar: " + toplamdomatesfiyati);
            #endregion
            #region Char Değişkenler
            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //"
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion
            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****"); 
            //Console.WriteLine(); 
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, 
            //    passengerIdentityNumber;
            //Console.Write("Yolcu Adı: "); 
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");  
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimliği ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine(); Console.WriteLine("------------------------ "); 
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + 
            //    "- Yolcu Adı Soyadı: " + passengerName + " " + passengerSurname+
            //    " "+ passengerDistrict + "/"+ passengerCity + " " + passengerAge);

            #endregion
            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            //int ayakkabifiyati, leptopfiyat, sandalyefiyat, tvfiyat;
            //ayakkabifiyati = 1000;
            //leptopfiyat = 20000;
            //sandalyefiyat = 5000;
            //tvfiyat = 12000;

            //int ayakkabisayisi, leptopsayisi, sandalyesayisi, tvfiyyesayisi;

            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //ayakkabisayisi = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız leptop sayısını giriniz: ");
            //leptopsayisi = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız sandalye sayısını giriniz: ");
            //sandalyesayisi = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvfiyyesayisi = int.Parse(Console.ReadLine());

            //int toplamfiyat = ayakkabisayisi*ayakkabifiyati + leptopsayisi*leptopfiyat +
            //    sandalyesayisi*sandalyefiyat+ tvfiyyesayisi* tvfiyat;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar:  " + toplamfiyat);













            #endregion
            #region Klavyeden Ondalıklı Sayi İşlemleri
            //double sinav1,sinav2,sinav3,ortalama;

            //Console.Write("Lütfen 1. Sınav notunu giriniz: ");
            //sinav1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 1. Sınav notunu giriniz: ");
            //sinav2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 1. Sınav notunu giriniz: ");
            //sinav3 = double.Parse(Console.ReadLine());

            //ortalama = (sinav1 + sinav2 + sinav3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: " + ortalama);
            #endregion
            #region Klavyeden Karakter Girişleri
            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);
            #endregion

            Console.Read();



        }
    }
}

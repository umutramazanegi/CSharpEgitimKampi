using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //void Customerlist()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //Customerlist();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();
            #endregion

            #region Geriye Değer Döndürmeyen String  Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //void customerCard(string name,string surName)
            //{

            //    Console.WriteLine("Müşteri Ad:"+name+" "+surName);

            //}

            //customerCard("Ahmet", "baris");

            #endregion

            #region Geriye Değer Döndürmeyen Int  Parametreli Metotlar

            //void Sum(int number1,int number2,int number3)
            //{

            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);

            //}

            //Sum(4, 6, 8);


            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Ahmet Kaya";

            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Sabri";
            //    string surname = "Solmaz";
            //    return name + " " + surname;

            //}
            //Console.WriteLine(StudentCard());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            // string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardinfo = "Ülke: " + countryName + "--Başkent: " + capital + "-- Bayrak Rengi: " + flagColor;
            //    return cardinfo;

            //}

            //string x, y, z;

            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkenti Giriniz ");
            //y= Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz:  ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));


            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1,int number2)
            // {
            //     int result =number1 + number2;

            //     return result;
            // }

            // Console.WriteLine(Sum(45,67));
            // Console.WriteLine(Sum(23,78));
            // Console.WriteLine(Sum(98,234));
            // Console.WriteLine(Sum(4547,2345));
            // Console.WriteLine(Sum(25,75));



            #endregion

            #region Örnek Uygulama

            //string ExamResult(string Student, int exam1,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return Student + "      İsimli Öğrenci Sınavı Geçti!" + "Ortalam:   " + result;
            //    }
            //    else
            //    {
            //        return Student + "       İsimli Öğrenci Sınavı Kaldı!" + "Ortalam:   " + result;

            //    }

            //}

            //Console.WriteLine(ExamResult("Ali", 45, 23, 67));
            //Console.WriteLine(ExamResult("Ayşe", 76, 98, 65));
            //Console.WriteLine(ExamResult("ferit", 67, 55, 34));

            #endregion

            Console.Read();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //ÜÇ PARAMETRESİ MEVCUT.
            //1 PARAMETRE=Başlangıç değeri,
            //2 PARAMETRE=Bitiş Değeri 
            //3 PARAMETRESİ= Kaçar Kaçar Artacağı yada Azalacağı



            //int i;
            //for ( i = 1; i < 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}   

            //for (int i = 1; i <=20; i++) 
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <=50; i+=3) 
            //{ 
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana kaç kez yazdırılacağını Bildirin: ");
            //int finishNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 1; i <= finishNumber; i++)
            //{ 
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion
            #region For Döngüsü İle Karar Yapıları

            //for (int i = 1; i <=100; i++)
            //{
            //    if (i % 5 == 0)
            //    { 
            //        Console.WriteLine(i);

            //    }
            //}

            //int totalvalue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalu);

            //int totalvalue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("--------+");
            //Console.WriteLine(totalvalue);

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count ++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    if (i < 10)
            //    {
            //        Console.WriteLine("0" + i + " " + "Saatin Sonundaki Bakteri Sayısı:" + " " + bacterium);
            //    }
            //    else {
            //        Console.WriteLine(i + " " + "Saatin Sonundaki Bakteri Sayısı:" + " " + bacterium);
            //    }
            //}

            #endregion
            #region While Döngüsü

            //BU döngü Şart Sağlandıkça anlamında kullanılır. 
            //Başlangıç değeri mutlak olmalı ve artış değeri süslü parantez içerisinde belirtilmeli.


            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while(i<=10)
            //{
            //    sum+=i;
            //    i++;
            //}
            //Console.WriteLine(sum);



            #endregion
            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamaklarının toplamını 
            //hesaplayan Kodu yazınız?

            //456

            //Console.Write("Sayıyı Giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens =( number %100)/10;
            //hundreds = number / 100;
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Birler Basamağı: "+ones);
            //Console.WriteLine("Onlar Basamağı: " + tens);
            //Console.WriteLine("Yüzler Basamağı: "+hundreds);
            //Console.WriteLine("---------------------------");

            //sum =hundreds+tens+ones;
            //Console.WriteLine("3 Basamaklı Sayıların Toplamı: "+sum);

            #endregion
           // Console.Read();
        }
    }
}

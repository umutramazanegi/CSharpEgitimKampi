using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Tane Yıldız Oluşturma 

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Yan Yana 10 Tane Yıldız Oluşturma 

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region Alt Alta 10 tane yıldız oluşturma ve Her Satırda 10 tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{             
            //    Console.WriteLine("**********");

            //}
            #endregion

            #region Dik Üçgen Formatı 

            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ters Dik Üçgen formatı

            //for (int i = 5; i >=1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Dik ve Ters Üçgen Beraber

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 4; k >= 1; k--)
            //{
            //    for(int z = 1;z <= k; z++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();

            //}
            #endregion

            #region Baklava Dilimi
            //int n = 5;
            ////Üst Kısım
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j =n- 1; j >0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////Alt Kısım
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();

            //}

            #endregion

            #region Piramit

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    //bolluklar için 
            //    for (int j = n-i; j >0; j--)
            //    {
            //        Console.Write(" ");      
            //    }

            //    //Yıldız yazdırma alanı
            //    for (int k = 1; k <=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            #endregion

            #region Ters Piramit
            //int n = 5;

            //for (int i =n; i>=1; i--)
            //{
            //    //boşluklar
            //    for (int j = n-i;j>0 ; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //Yıldızlar
            //    for (int k = 1; k<=2*i-1 ; k++)
            //    {
            //        Console.Write("*");
            //    }    

            //    Console.WriteLine();
            //}

            #endregion
            //Console.Read();

        }
    }
}

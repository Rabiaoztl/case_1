using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken adı
            //In
            //Liste,Koleksiyon,Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int i in numbers)
            //{
            //    if(i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach(int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması
            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            ////Sınıftaki öğrenci sayısı kullanıcıdan alma
            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var: ");
            //int studentcount=int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            ////Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentnames=new string[studentcount];
            //double[] studentexamavg=new double[studentcount];

            //for(int i=0; i<studentcount; i++)
            //{
            //    Console.Write($"{i + 1}.öğrencinin ismini giriniz: ");
            //    studentnames[i] = Console.ReadLine();

            //    double totalexamresult = 0;

            //    //Her öğrenci için 3 sınav notu girişi

            //    for(int  j=0; j<studentcount; j++)
            //    {
            //        Console.Write($"{studentnames[i]} adlı öğrencini {j+1}.sınav notunu giriniz: ");
            //        double value=double.Parse(Console.ReadLine());
            //        totalexamresult += value;//Notlar toplanır.
            //    }
            //    Console.WriteLine();
            //    studentexamavg[i] = totalexamresult / 3;

            //}
            ////Öğrencilerin ortalaması ve geçip kalma durumu
            //for(int i=0;i<studentcount; i++)
            //{
            //    Console.WriteLine($"{studentnames[i]}" +
            //        $"adlı öğrencinin ortalaması: {studentexamavg[i]}") ;

            //    if (studentexamavg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentnames[i]} adlı öğrenci dersi geçti.");

            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentnames[i]} adlı öğrenci dersten kaldı");
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}

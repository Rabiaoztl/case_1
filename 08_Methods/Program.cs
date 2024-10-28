using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //() metot olması için gerekir.
            //1.Geriye değer döndürmeyen metotlar
            //Customer-->listele,ekle,sil,güncelle
            //void

            //void customerlist()
            //{
            //    Console.WriteLine("ali yıldız");
            //    Console.WriteLine("ayşe yıldız");
            //    Console.WriteLine("hakan öztürk");
            //    Console.WriteLine("merve çınar");
            //}

            //customerlist();
            //customerlist();
            //customerlist();
            //customerlist();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //} 
            //sum();
            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void writemethod(string customername)
            //{
            //    Console.Writeline(customername);
            //}

            //writemethod("mehmet");

            //void customercard(string name,string surname)
            //{
            //    Console.WriteLine("müşteri: " + name + " " + surname);
            //}

            //customercard("mehmet", "yıldız");
            //customercard("ayşegül", "kaya");
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void sum(int number1, int number2,int number3)
            //{
            //    int result=number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(4, 5, 6);
            #endregion 

            #region Geriye Değer Döndüren Metotlar

            //string customername()
            //{
            //    return "Buse Yıldız";
            //}

            //customername();

            //string studentcard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(studentcard());
            #endregion 

            #region Geriye Değer Döndüren Parametreli Metotlar

            //string countrycard(string country, string capital, string flagcolor)
            //{
            //    string cardınfo = "Ülke: " + country + "-Başkent: " + capital + "-Bayrak Rengi: " + flagcolor;
            //    return cardınfo;


            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(countrycard(x, y, z));

            //Console.WriteLine(countrycard("turkıye", "ankara", "kırmızı-beyaz"));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int sum(int number,int number2)
            //{
            //    int result=number+number2;
            //    return result;
            //}

            //Console.WriteLine(sum(45, 98));
            //Console.WriteLine(sum(36, 25));
            //Console.WriteLine(sum(44, 36));
            //Console.WriteLine(sum(14, 20));

            #endregion

            #region Örnek Uygulama

            //string examresult(string student,int exam1,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) /3;
            //    if (result >= 50)
            //    {
            //        return student +" isimli öğrenci sınavı geçti" + " Ortalama: "+ result;
            //    }
            //    else
            //    {
            //        return student + "isimli öğrenci sınavı geçemedi" + " Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(examresult("Ali", 25, 41, 85));
            //Console.WriteLine(examresult("Ayşe", 36, 88, 33));
           
            #endregion 

            Console.Read();

        }
    }
}

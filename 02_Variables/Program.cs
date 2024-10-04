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

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double appleprice,orangeprice,strawberryprice,potatoprice,tomatoprice;

            //appleprice = 14.85;
            //orangeprice = 20.95;
            //strawberryprice = 45;
            //potatoprice = 9.74;
            //tomatoprice = 6.88;

            //Console.WriteLine("----- Elma Birim Fiyatı: " + appleprice + "TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı: " + orangeprice + "TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı: " + strawberryprice + "TL");
            //Console.WriteLine("----- Patates Birim Fiyatı: " + potatoprice + "TL");
            //Console.WriteLine("----- Domates Birim Fiyatı: " + tomatoprice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double applegram,orangegram,strawberrygram,potatogram,tomatogram;

            //applegram = 1.245;
            //orangegram = 2.650;
            //strawberrygram = 0.750;
            //potatogram = 4.859;
            //tomatogram = 3.745;

            //double appletotalprice = applegram * appleprice;
            //double orangetotalprice = orangegram * orangeprice;
            //double strawberrytotalprice = strawberrygram * strawberryprice;
            //double potatototalprice = potatogram * potatoprice;
            //double tomatototalprice = tomatogram * tomatoprice;

            //Console.WriteLine(" Alınan Ürün : Elma - " + " Birim Fiyat: " + appleprice + " - Gramaj: " + applegram  + " - Toplam Tutar: " + appletotalprice);
            //Console.WriteLine(" Alınan Ürün : Portakal - " + " Birim Fiyat: " + orangeprice + " - Gramaj: " + orangegram  + " - Toplam Tutar: " + orangetotalprice);
            //Console.WriteLine(" Alınan Ürün : Çilek - " + " Birim Fiyat: " + strawberryprice + " - Gramaj: " + strawberrygram  + " - Toplam Tutar: " + strawberrytotalprice);
            //Console.WriteLine(" Alınan Ürün : Patates - " + " Birim Fiyat: " + potatoprice + " - Gramaj: " + potatogram  + " - Toplam Tutar: " + potatototalprice);
            //Console.WriteLine(" Alınan Ürün : Domates - " + " Birim Fiyat: " + tomatoprice + " - Gramaj: " + tomatogram  + " - Toplam Tutar: " + tomatototalprice);

            //double shoppingtotalprice=appletotalprice + orangetotalprice + strawberrytotalprice + potatototalprice + tomatototalprice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingtotalprice + "TL");

            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //" '

            //char synbol;
            //synbol = 'a';

            //Console.WriteLine(synbol);

            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengername, passengersurname, passengerdistrict, passengercity, passengerage ,passengerıdentitynumber;

            //Console.Write("Yolcu Adı: ");
            //passengername = Console.ReadLine();

            //Console.Write("Yolcu Soyadı :");
            //passengersurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerdistrict = Console.ReadLine(); 

            //Console.Write("Şehir Bilgisi: ");
            //passengercity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerage = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerıdentitynumber = Console.ReadLine();  

            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: "+ passengerıdentitynumber + " " + "Yolcu Ad Soyad: " + passengername + " " + passengersurname + " " + passengerdistrict + " / " + passengercity + " " +passengerage );


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //AB12D

            //int shoeprice, computerprice, chairprice, tvprice;
            //shoeprice = 1000;
            //computerprice = 20000;
            //chairprice = 5000;
            //tvprice = 12000;

            //int shoecount,computercount,chaircount,tvcount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoecount = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computercount = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chaircount = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvcount = int.Parse( Console.ReadLine());

            //int totalprice=shoecount*shoeprice + computercount*computerprice + chairprice*chaircount + tvprice*tvcount;
            //Console.WriteLine();
            //Console.WriteLine("Uygulamaya girmeniz gereken değer: " + totalprice);


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunu giriniz: ");
            //exam2=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunu giriniz: ");
            //exam3=double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav Ortalamanız: " +result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet giriniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet :" +gender);
            #endregion

            Console.Read();
        }
    }
}

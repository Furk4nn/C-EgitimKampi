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
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            #region Dobule Değişken
            ////double number;
            ////number= 4.85;
            ////Console.WriteLine(number);
            //
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.75;
            //tomatoPrice = 6.98;
            //
            //Console.WriteLine("---- Elma Birim Fiyatı -----" + applePrice+" "+"₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı -----" + orangePrice + " " + "₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı -----" + strawberryPrice + " " + "₺");
            //Console.WriteLine("---- Patates Birim Fiyatı -----" + potatoPrice + " " + "₺");
            //Console.WriteLine("---- Domates Birim Fiyatı -----" + tomatoPrice + " " + "₺");
            //Console.WriteLine();
            //
            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.956;
            //tomatoGram = 3.475;
            //
            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün:Elma-"+"Birim Fiyatı:"+applePrice+" "+"Gramaj:"+appleGram+" "+"Tutar:"+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün:Portakal-"+"Birim Fiyatı:"+orangePrice+" "+"Gramaj:"+orangeGram+" "+"Tutar:"+ orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün:Çilek-"+"Birim Fiyatı:"+strawberryPrice+" "+"Gramaj:"+strawberryGram+" "+"Tutar:"+ strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün:Patates-"+"Birim Fiyatı:"+potatoPrice+" "+"Gramaj:"+potatoGram+" "+"Tutar:"+ potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün:Domates-"+"Birim Fiyatı:"+tomatoPrice+" "+"Gramaj:"+tomatoGram+" "+"Tutar:"+ tomatoTotalPrice);
            //Console.WriteLine();
            //double shoppingTotalPrice = Math.Round((appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice),2);
            //Console.WriteLine("Alışveriş Toplam Tutar:"+shoppingTotalPrice);
            ////Console.WriteLine("Alışveriş Toplam Tutar:"+Math.Round((appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice),2));
            //Console.WriteLine();

            #endregion

            #region Char Değişken

            //ABCDEFGH
            //" ' Tek tırnakla tanımlanır.
            // char symbol;
            // symbol = 'a';
            // Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenleri

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName= Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname= Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict= Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity= Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge= Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber= Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: "+passengerIdentityNumber+" - "+"Yolcu Bilgileri: "+passengerName+" "+passengerSurname+" "+passengerAge+" "
            //    +passengerDistrict+"/"+passengerCity);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1250;
            //computerPrice = 30000;
            //chairPrice = 4950;
            //tvPrice = 11750;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoesPrice * shoesCount) + (computerCount * computerPrice) + (chairCount * chairPrice) + (tvCount * tvPrice);

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gerekn Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");            
            //exam2=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3=double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sıvan Ortalamanız: "+result);
            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: "+gender);  //dizi bir karakterli olmalıdır...

            #endregion

            Console.Read();
        }
    }
}

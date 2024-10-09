using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_IntroductionToCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleVariables
            //double number;

            //number = 3.1454653;

            //Console.WriteLine(number);
            //Console.ReadLine();

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.45;
            //orangePrice = 22.20;
            //strawberryPrice = 45;
            //potatoPrice = 7.90;
            //tomatoPrice = 18.60;

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("----- Elma Birim Fiyatı:₺" + applePrice);
            //Console.WriteLine("----- Portakal Birim Fiyatı:₺" + orangePrice);
            //Console.WriteLine("----- Çilek Birim Fiyatı:₺" + strawberryPrice);
            //Console.WriteLine("----- Patates Birim Fiyatı:₺" + potatoPrice);
            //Console.WriteLine("----- Domates Birim Fiyatı:₺" + tomatoPrice);
            //Console.WriteLine();
            //Console.WriteLine();


            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.901;
            //orangeGram = 3.234;
            //strawberryGram = 8.991;
            //potatoGram = 0.991;
            //tomatoGram = 4.567;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomateTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Ürün:Elma - "+ "Birim Fiyat: ₺" + applePrice+" - Gramaj: "+appleGram+" - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün:Portakal - "+ "Birim Fiyat: ₺" + orangePrice + " - Gramaj: "+ orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün:Çilek - "+ "Birim Fiyat: ₺" + strawberryPrice + " - Gramaj: "+ strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün:Patates - "+ "Birim Fiyat: ₺" + potatoPrice + " - Gramaj: "+ potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün:Domates - "+ "Birim Fiyat: ₺" + tomatoPrice + " - Gramaj: "+ tomatoGram + " - Toplam Tutar: " + tomateTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomateTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutarı: ₺" + shoppingTotalPrice);

            #endregion

            #region CharVariables



            #endregion

            #region StringInputFromKeyboard
            //Console.WriteLine("*** Malatya Hava Yolları Yolcu Bilgisi ***");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Kimlik NO: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-------------");
            //Console.WriteLine("Yolcu : "+ passengerName+ " "+passengerSurname+ " "+passengerDistrict+"/"+passengerCity+" "+passengerIdentityNumber);

            #endregion

            #region IntegerInputFromKeyboard

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1400;
            //computerPrice = 35000;
            //chairPrice = 7000;
            //tvPrice = 54000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen kaç ayakkabı alacağınızı giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen kaç bilgisayar alacağınızı giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen kaç sandalye alacağınızı giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen kaç TV alacağınızı giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice*tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödeyeceğiniz tutar: "+totalPrice);


            #endregion

            #region DecimalInputFromKeyboard

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1.sınav notunu giriniz:");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2+ exam3)/3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız:"+result);
            #endregion

            #region CharInputFromKeyboard

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet: "+ gender); 

            #endregion



            Console.Read();
        }
    }
}

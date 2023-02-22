using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _1_ConsoleOr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Menu\n1-Toplama(f2)\n2-Çıkarma(f3)\n3-Dongu(Enter)\nÇıkış(Esc)");
            Console.WriteLine("Bir tuşa basınız");
            ConsoleKeyInfo cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.F2)
                Console.WriteLine("Toplama yapıldı");
            else if (cki.Key == ConsoleKey.F3)
                Console.WriteLine("Çıkarma yapıldı");
            else if (cki.Key == ConsoleKey.Enter)
                Main(args);
            else if (cki.Key == ConsoleKey.Escape)
                return;

            Console.Read();
                */

            /*  KONSOLDAN GİRİLEN SAYI TEK Mİ ÇİFT Mİ NEGO MU POZİTİF Mİ

            Console.WriteLine("Bir sayı giriniz: ");
            
            int sayi = int.Parse(Console.ReadLine());
            if (sayi % 2 == 0)
                if (sayi > 0)
                    Console.WriteLine("Çift ve Pozitif");
                else if (sayi < 0)
                    Console.WriteLine("Çift ve Negatif");
                else
                    Console.WriteLine("Çift ve Sıfır");

            if (sayi % 2 == 1) 
            {
                if (sayi > 0)
                    Console.WriteLine("Tek ve Pozitif");
                else
                    Console.WriteLine("Tek ve Negatif");
            }
            
            */

            /* 4 İŞLEM YAPMA
            Console.WriteLine("1.Sayıyı Giriniz: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Giriniz: ");
            int y = int.Parse(Console.ReadLine());


            Console.WriteLine("Menu\n1-Toplama(f2)\n2-Çıkarma(f3)\n3-Çarpma(f4)\n4-Bölme(f5)");
            Console.WriteLine("Bir tuşa basınız: ");
            ConsoleKeyInfo cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.F2)
                Console.WriteLine(x + y);
            else if (cki.Key == ConsoleKey.F3)
                Console.WriteLine(x-y);
            else if (cki.Key == ConsoleKey.F4)
                Console.WriteLine(x*y);
            else if (cki.Key == ConsoleKey.F5)
                Console.WriteLine(x/y);
                

            Console.ReadLine();

           */


            /* YÜZDE HESAPLAMA
            Console.WriteLine("Bir Sayı Giriniz:"); 
            double sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Yüzde Giriniz:");
            double yuzde = int.Parse(Console.ReadLine());

            Console.WriteLine(sayi * yuzde / 100);
            Console.ReadLine();
            */



            /*KAR ZARAR HESAPLAMA (BENİM YAPTIĞIM)
            Console.WriteLine("Alış fiyatı giriniz:");
            double afiyati = double.Parse(Console.ReadLine());
            Console.WriteLine("Satış fiyatı giriniz:");
            double sfiyati = double.Parse(Console.ReadLine());

            double kar = (sfiyati - afiyati) / afiyati * 100;
            double zarar = (afiyati-sfiyati) / afiyati * 100;

            if (afiyati<sfiyati)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Karınız:"+ kar);

            }
            else
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Zararınız:"+ zarar);

            Console.ReadLine();
            */

            /* HOCANIN YAPTIĞI
            Console.Write("Alış : ");
            double buy =  double.Parse(Console.ReadLine());
            Console.Write("Satış : ");
            double sales = double.Parse(Console.ReadLine());

            double result = (sales - buy) / buy * 100;
            if (result > 0)
            {

                Console.WriteLine($"%{result}%");
            }
            
            */

            /* Maks 4 basamaklı sayının okunuşu
            
            Console.WriteLine("Maksimum 4 basamaklı bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi == 0) 
            {
                Console.Write("sıfır");
                
            }
            else
            {
                if (sayi < 0)
                {
                    Console.Write("eksi");
                    sayi = -sayi;

                }
                int bolum = Math.DivRem(sayi, 1000, out sayi);
                switch (bolum)
                {
                    case 0:
                        Console.Write("");
                        break;
                    case 1:
                        Console.Write("bin");
                        break;
                    case 2:
                        Console.Write("ikibin");
                        break;
                    case 3:
                        Console.Write("üçbin");
                        break;
                    case 4:
                        Console.Write("dörtbin");
                        break;
                    case 5:
                        Console.Write("beşbin");
                        break;
                    case 6:
                        Console.Write("altıbin");
                        break;
                    case 7:
                        Console.Write("yedibin");
                        break;
                    case 8:
                        Console.Write("sekizbin");
                        break;
                    case 9:
                        Console.Write("dokuzbin");
                        break;
                    default:
                        Console.Write("max 4 basamaklı giriniz");
                        Main(args);
                        break;
                }

                bolum = Math.DivRem(sayi, 100, out sayi);
                switch (bolum)
                {
                    case 0:
                        Console.Write(" ");
                        break;
                    case 1:
                        Console.Write(" yüz");
                        break;
                    case 2:
                        Console.Write(" ikiyüz");
                        break;
                    case 3:
                        Console.Write(" üçyüz");
                        break;
                    case 4:
                        Console.Write(" dörtyüz");
                        break;
                    case 5:
                        Console.Write(" beşyüz");
                        break;
                    case 6:
                        Console.Write(" altıyüz");
                        break;
                    case 7:
                        Console.Write(" yediyüz");
                        break;
                    case 8:
                        Console.Write(" sekizyüz");
                        break;
                    case 9:
                        Console.Write(" dokuzyüz");
                        break;

                }
                bolum = Math.DivRem(sayi, 10, out sayi);
                switch (bolum)
                {
                    case 0:
                        Console.Write(" ");
                        break;
                    case 1:
                        Console.Write(" on");
                        break;
                    case 2:
                        Console.Write(" yirmi");
                        break;
                    case 3:
                        Console.Write(" otuz");
                        break;
                    case 4:
                        Console.Write(" kırk");
                        break;
                    case 5: 
                        Console.Write(" elli");
                        break;
                    case 6:
                        Console.Write(" altmış");
                        break;
                    case 7:
                        Console.Write(" yetmiş");
                        break;
                    case 8:
                        Console.Write(" seksen");
                        break;
                    case 9:
                        Console.Write(" doksan");
                        break;

                }


                switch (sayi)
                {
                    case 0:
                        Console.Write(" ");
                        break;
                    case 1:
                        Console.Write(" bir");
                        break;
                    case 2:
                        Console.Write(" iki");
                        break;
                    case 3:
                        Console.Write(" üç");
                        break;
                    case 4:
                        Console.Write(" dört");
                        break;
                    case 5:
                        Console.Write(" beş");
                        break;
                    case 6:
                        Console.Write(" altı");
                        break;
                    case 7:
                        Console.Write(" yedi");
                        break;
                    case 8:
                        Console.Write(" sekiz");
                        break;
                    case 9:
                        Console.Write(" dokuz");
                        break;

                }
            }

            Console.Read();
            */


            /*POZİTİF NEGATİF BELİRLEME
            Console.Write("Sayı: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number > 0 ? "pozitif" : "negatif");
            Console.ReadLine();

            */
            /* ÜÇGEN VE DDÖRTGENİN ALAN VE ÇEVRESİ BENİM YATPIĞIM
            Console.WriteLine("Menu\n1-Dikdörtgen(f2)\n2-Üçgen(f3)");
            Console.WriteLine("Bir tuşa basınız");
            ConsoleKeyInfo cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.F2) 
            {
                Console.WriteLine("1-Alan(f2)\n2-Çevre(f3)");
                ConsoleKeyInfo mki = Console.ReadKey();
                if (mki.Key == ConsoleKey.F2) {
                    Console.WriteLine("Uzun Kenar giriniz: ");
                    int ukenar = int.Parse(Console.ReadLine());
                    Console.WriteLine("Kısa Kenar giriniz: ");
                    int kkenar = int.Parse(Console.ReadLine());
                    int dalan = ukenar * kkenar;
                    Console.WriteLine("Alan: " + dalan);
                }
                else if (mki.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("Uzun Kenar giriniz: ");
                    int ukenar = int.Parse(Console.ReadLine());
                    Console.WriteLine("Kısa Kenar giriniz: ");
                    int kkenar = int.Parse(Console.ReadLine());
                    int dcevre = 2 * ukenar + 2 * kkenar;
                    Console.WriteLine("Çevre: " + dcevre);
                   
                }


            }
           Console.ReadLine();
            */
            /*
             Menu
            1-dikdörtgen
            2-Ucgen
            3-Dongu
            4-Cıkıs

            1-alan
            2-çevre
             */

            /* HOCANIN YAPTIĞI
            Console.WriteLine("Menu\n1-Dikdörtgen\n2-Ucgen\n3-Dongu\n4-Cıkıs");
            Console.WriteLine("Secim : ");
            byte choice = Convert.ToByte(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("1-Alan\n2-Cevre");
                    Console.WriteLine("Secim : ");
                    choice = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("x : ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("y : ");
                    int y = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Alan : {x * y}");
                            break;
                        case 2:
                            Console.WriteLine($"Çevre : {2 * (x + y)}");
                            break;
                        default:
                            Console.WriteLine("Yanlış seçim");
                            break;
                    }
                    //choice =  Menu2();
                    break;
                case 2:
                    Console.WriteLine("1-Alan\n2-Cevre");
                    Console.Write("Secim : ");
                    choice = Convert.ToByte(Console.ReadLine());
                    //choice =  Menu2();
                    switch (choice)
                    {
                        case 1:
                            Console.Write("yükseklik : ");
                            int h = int.Parse(Console.ReadLine());
                            Console.Write("taban : ");
                            int a = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Alan : {h * a / 2}");
                            break;
                        case 2:
                            Console.Write("a : ");
                            a = int.Parse(Console.ReadLine());
                            Console.Write("b : ");
                            int b = int.Parse(Console.ReadLine());
                            Console.Write("c : ");
                            int c = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Çevre : {a + b + c}");
                            break;
                        default:
                            Console.WriteLine("Yanlış seçim");
                            break;
                    }
                    break;
                case 3:
                    Console.Clear();
                    Main(args);
                    break;
                case 4:
                    Environment.Exit(0);//return
                    break;
                default:
                    break;
            }

            Console.Read();
            */

            /* İSTEDİĞİN METNİ İSTEDİĞİN ADETTE YAZDIRMA
            Console.WriteLine("Metin Giriniz: ");
            string metin = Console.ReadLine();

            Console.WriteLine("Adet: ");
            int adet = int.Parse(Console.ReadLine());
            for (int i=0; i<adet; i++)
            {
                Console.WriteLine(metin);
            }
            Console.ReadLine();
            */


            /* GİRİLEN İKİ SAYI ARASINDAKİ ASAL SAYILAR
            Console.WriteLine("Min Sayıyı giriniz: ");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Max Sayıyı giriniz: ");
            int max = int.Parse(Console.ReadLine());
            int count = 0;
            min=Math.Min(min, max);
            if (min < 0)
                min= 0;
            max = Math.Max(min, max);
            if (max < 0)
                max = 0;


            for (int i = min; i <= max; i++)
            {
                for (int j=2;j < i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if (count == 0)
                {
                    if (i > 1)
                        Console.WriteLine(i);
                   
                  

                }
                count = 0;

            }

            Console.ReadLine();
            */
            /*1 İLE 100 ARASINDAKİ TEK VE ÇİFT SAYILARIN ADEDİ VE TOPLAMI
            int tek = 0, cift = 0, ctop = 0, ttop = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    cift++;
                    ctop += i;
                }


                else
                {

                    tek++;
                    ttop += i;
                }
            }
            Console.WriteLine($"Çiftlerin Toplamı = {ctop} adet = {cift}");
            Console.WriteLine($"Teklerin toplamı = {ttop} adet = {tek}");
            Console.ReadLine();

            */

            /*
            Console.WriteLine("Bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayi; i++) 
            {
            if (sayi%i==0)
                {
                    Console.WriteLine(i);
                }
            
            }
            Console.ReadLine();

            */

            /* 0-100 ARASINDAKİ MÜQ SAYILARI BULMA
            int toplam=0;
            for (int i = 0; i <= 100; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        toplam += j;
                    }
                }
                if (toplam == i && i != 0)
                    Console.WriteLine(i);


                toplam = 0;
            }
            Console.ReadLine();

            */

            /*DİK KENAR KADAR ÜÇGEN
            Console.WriteLine("Bir dik kenar giriniz: ");
            int dkenar = int.Parse(Console.ReadLine());

            for (int i = 1; i <=dkenar; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("x");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
            */

            /*ÜÇGEN OLUŞTURMA
            Console.WriteLine("Bir dik kenar giriniz: ");
            int dkenar = int.Parse(Console.ReadLine());

            for (int i = 1; i <=dkenar; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("x");
                    
                }
                Console.WriteLine();
                
            }
            
            Console.Read();
            */

            /* OK YAPIMI
            Console.WriteLine("kenar : ");
            int kenar = int.Parse(Console.ReadLine());
            int ort = kenar / 2;
            if (kenar % 2 == 1)
            {
                for (int i = 0; i < ort; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                        
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < ort + 1; i++)
                {
                    for (int j = ort + 1; j > i; j--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < ort; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < ort; i++)
                {
                    for (int j = ort; j > i; j--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            Console.Read();
            */
            /* BASAMAK SAYISI
            Console.WriteLine("Sayı giriniz");
            int sayi=int.Parse(Console.ReadLine());
            int bas = 0;
            while (sayi>0)
            {
                sayi/=10;
                bas++;
            }
            Console.WriteLine("Girdiğiniz basamak sayısı: " + bas);
            Console.Read();
            */


            /* SAYI TAHMİN
            Random rastgele= new Random();
            int sayi= rastgele.Next(10);
            int tahmin, hak = 3;
            do
            {
                hak--;
                Console.WriteLine("Tahmininiz: ");
                tahmin = int.Parse(Console.ReadLine());
                if (tahmin > sayi)
                    Console.WriteLine($"Daha küçük bir sayı giriniz!\n{hak} hakkınız kaldı");
                else if (tahmin < sayi)
                    Console.WriteLine($"Daha büyük bir sayı giriniz!\n{hak} hakkınız kaldı");
                else
                {
                    Console.WriteLine($"Tebrikler! {3-hak}. hakta bildiniz!");
                    break;
                }
            } while (hak > 0);
            if (hak == 0) 
            Console.WriteLine($"Bilemediniz. Sayı {sayi} olacak");

            Console.Read();
            */

            /*
            string kelime = "";
            var rnd = new Random();
            for (int i=0;i<6;i++) 
            {
                kelime += ((char)rnd.Next('A', 'Z')).ToString();
            }
            return kelime;

            Console.ReadLine();

            */

            /*
            Console.Write("Para : ");
            int para = int.Parse(Console.ReadLine());
            int adet = 0;
            while (para > 0)
            {
                if (para >= 200)
                {
                    adet = Math.DivRem(para, 200, out para);
                    Console.WriteLine($"{adet} adet 200₺");
                }
                else if (para >= 100)
                {
                    adet = Math.DivRem(para, 100, out para);
                    Console.WriteLine($"{adet} adet 100TL");
                }
                else if (para >= 50)
                {
                    adet = Math.DivRem(para, 50, out para);
                    Console.WriteLine($"{adet} adet 50₺");
                }
                else if (para >= 20)
                {
                    adet = Math.DivRem(para, 20, out para);
                    Console.WriteLine($"{adet} adet 20₺");
                }
                else if (para >= 10)
                {
                    adet = Math.DivRem(para, 10, out para);
                    Console.WriteLine($"{adet} adet 10₺");
                }
                else if (para >= 5)
                {
                    adet = Math.DivRem(para, 5, out para);
                    Console.WriteLine($"{adet} adet 5₺");
                }
                else
                {
                    Console.WriteLine($"{para} adet 1₺");
                    para=0;
                }
            }
            
            Console.ReadLine();

            */


            //Değer(Veri) Tipler ve Referans Tipler
            /*
             Değer Tipleri = Bellekte Stack te tutulur

            Referans Tipler = Heap te tutulur.Ref veya out kelimesi ile dönüştürülür.
            Ref = başlangıç değeri verilmeli
            out = başlangıç değeri verilmemeli.
             */
            /* Method şeyi
            int a = 10, b = 10;
            Metot(a, b);
            Console.WriteLine($"a: {a} b:{b}");

            int c = 10, d;
            Metot2(ref c, out d);
            Console.WriteLine($"a: {a} b:{b}");
            Console.Read();  
            */


            Console.WriteLine("10 ADET NOT GİRİNİZ: ");
            int sayac = 0;
            int not;
            for (int i = 0; i <10; i++)
            {
                not = int.Parse(Console.ReadLine());
                if (not <= 50)
                {
                    sayac++;
                   
                }
                
            }
            Console.WriteLine($"{sayac} tanesi 50 ve altındadır");

            Console.ReadLine();


        }




       

    
    private static void Metot2(ref int a, out int b)
    {
        a = 5;
        b = 5;
    }

    private static void Metot(int a, int b)
    {
        a = 5;
        b = 5;
    }

    private static void NewMethod()
        {
            /*
             C# Veriables(Veri Tipleri)

            Integer Veriables
            -byte: 0-255 arası veri tutar.
            -sbyte: signal(işaret) byte -128 - +127
            short/Int16: -32000 - +32000
            ushort: nsignal(İşaretsiz) 65000
            int:
            uint:
            long:
            ulong:



            Reel(Ondalıklı) Veriables
            float: f
            double: d getirilebilir.
            decimal: m/M


            Metinsel Veriables
            char: 'x'
            string: "              "



            Boolean Veriable
            bool/Boolean:



            Other Veriables
            object
            var


            Datetime Veriable
            -Datetime



            Console Methods
            1-Write/WriteLine: Veri yazmak için
            2-Read/ReadLine/ReadKey: Veri almak için
            Read: Ascii kodunu tutar
            ReadLine: Veriyi string tutar.
            ReadKey:ConsoleKeyInfo - hangi tuşa basıldığını tutar.
            3-Clear: Console temizler.
            4-BackgroundColor:Arka plan rengi
            5-ForegroundColor:Yazı rengi

            */

            /*
            //Write/WriteLine Kullanım Çeşitleri

            string name = "Yusuf", surname = "Şahin";
            //1.Yöntem
            Console.WriteLine("Adı : " + name + "Soyadı : " + surname);


            //2.Yöntem
            Console.WriteLine("Adı : {0} Soyadı : {1}", name, surname);


            //3.Yöntem
            Console.WriteLine($"Adı : {name} Soyadı : {surname}");

            //int x = Console.Read();
            //ConsoleKeyInfo cki = Console.ReadKey();
            string s = Console.ReadLine();

            /*Dönüştürme Metodları
             1-Convert.ToVeriable : ör: Convert.ToInt32
             2-Veriable.Parse : double.Parse()
             3-ToString():stringe dönüştürür
            */
            
        }


        
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciLoop
{
    class Program
    {
        static double fibonacci_Calculation(int sayi) 
        {
            if (sayi == 1 || sayi == 2)
            {
                return 1;
            }
            else
            {
                double x = 1;
                double y = 1;
                double sonuc = 1;
                while (sayi > 2)
                {
                    sayi--;
                    sonuc = x + y;
                    x = y;
                    y = sonuc;
                }
                return sonuc;
            }
        }
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();//Sonucu bulana kadar geçen zamanı öğrenebilmek için bir stopwatch nesnesi yaratıldı.
            Console.Write("Kacinci fibonacci değerini ögrenmek istiyorsunuz : ");
            int deger = Int32.Parse(Console.ReadLine());
            watch.Start();// süre başlatıldı.
            Console.WriteLine("{0}. fibonacci degeri : " + fibonacci_Calculation(deger), deger); // işlemler başlatıldı.
            watch.Stop();// işlem bittiği anda süre durduruldu.
            TimeSpan ts = watch.Elapsed;// süreyi ekrana yazdırabilmek için zaman dilimi (TimeSpan) nesnesi watch nesnesi ile ilişkilendirildi.
            Console.WriteLine("İslem icin harcanan sure : "+ts.Hours+" sa      "+ts.Minutes+" dk      "+ts.Seconds+" sn      "+ts.Milliseconds+" ms      ");
            Console.WriteLine("Toplam milisaniye : " + ts.TotalMilliseconds); // Sonucu bir de toplam milisaniye şeklinde gösteriliyor.
            Console.ReadKey();// Ekrana basılan sonucun görülebilmesi için kullandım. Kullanıcı bir tuşa basınca program otomatik kapanır.
        }
    }
}

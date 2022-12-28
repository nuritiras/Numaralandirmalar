using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numaralandirmalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Gunler.Pazar +" "+ Gunler.Pazar);
            // enum tanımlama
            Kategoriler kat = Kategoriler.Mobilya;
            // değer adının kullanımı
            Console.WriteLine(kat);
            // değerin sayısal değerinin kullanımı
            Console.WriteLine((int)kat);
            // enuma sayısal değer atama
            kat = (Kategoriler)7;
            // if ile kullanımı
            if (kat == Kategoriler.Kırtasiye)
                Console.WriteLine("Kırtasiye kategorisi");
            // switch ile kullanımı
            switch (kat)
            {
                case Kategoriler.Bilgisayar: // ..
                    break;
                case Kategoriler.Mobilya: // ..
                    break;
                case Kategoriler.Kırtasiye: // ..
                    Console.WriteLine("Kırtasiye kategorisi");
                    break;
                case Kategoriler.Hırdavat: // ..
                    break;
                case Kategoriler.Otomobil: // ..
                    break;
                default:
                    break;
            }
        }
    }
    enum Gunler
    {
        Pazartesi,Sali,Carsamba,Persembe,Cuma,Cumartesi,Pazar
    }
    enum Kategoriler
    {
        Bilgisayar = 3,
        Mobilya = 10,
        Kırtasiye = 7,
        Hırdavat, // 8
        Otomobil // 9
    }
}

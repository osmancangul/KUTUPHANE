using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_PROJELER
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kutuphane kutuphane = new Kutuphane();

            Kitap kitap = new Kitap();

            kitap.id = 1;
            kitap.ad = "C# ile Programlama";
            kitap.yazar = "Ali Veli";
            kitap.tur = "Programlama";
            kitap.yayinTarihi = new DateTime(2020, 5, 10);

            eKitap eKitap = new eKitap();

            eKitap.id = 2;
            eKitap.ad = "OOP Rehberi";
            eKitap.yazar = "Ayşe Yılmaz";
            eKitap.tur = "Eğitim";
            eKitap.yayinTarihi = new DateTime(2021, 8, 15);
            eKitap.dosya_boyutu = 5.4;


            SesliKitap sesliKitap = new SesliKitap();

            sesliKitap.id = 3;
            sesliKitap.ad = "Başarı Hikayeleri";
            sesliKitap.yazar = "Mehmet Kaya";
            sesliKitap.tur = "Gelişim";
            sesliKitap.yayinTarihi = new DateTime(2019, 3, 25);
            sesliKitap.sure = 120;

            kutuphane.KitapEkle(kitap);
            kutuphane.KitapEkle(eKitap);
            kutuphane.KitapEkle(sesliKitap);

            Console.WriteLine("\n Tüm Kitaplar");
            kutuphane.Listele();

            Console.WriteLine("\n Kitap Ara: ");
            var aranan = kutuphane.kitapAra("OOP Rehberi");

            if (aranan != null)
            {
                Console.WriteLine("Kitap Bulundu");
            }

            else
            {
                Console.WriteLine("Kitap Bulunamadı");
            }


            Console.Read();
        }
    }
}

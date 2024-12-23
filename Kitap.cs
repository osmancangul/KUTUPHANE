using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_PROJELER
{
    public class Kitap
    {
        public int id;
        public string ad;
        public string yazar;
        public string tur;
        public DateTime yayinTarihi;

        public override string ToString()
        {
            return $"Id: {id}, Ad: {ad}, Yazar: {yazar}, Tür: {tur}, Yayın Tarihi: {yayinTarihi.ToShortDateString()}";
        }
    }

    public class eKitap : Kitap
    {
        public double dosya_boyutu;

        public override string ToString()
        {
            return base.ToString() + $", Dosya Boyutu: {dosya_boyutu} MB";
        }
    }

    public class SesliKitap : Kitap
    {
        public int sure;

        public override string ToString()
        {
            return base.ToString() + $", Süre: {sure}";
        }
    }


    public interface KutuphaneYonetimi
    {
        void KitapEkle(Kitap kitap);
        void KitapSil(int id);
        void KitapGuncelle(int id, Kitap yeniBilgiler);
        Kitap kitapAra(string ad);
    }

    public class Kutuphane : KutuphaneYonetimi
    {
        private List<Kitap> kitaplar = new List<Kitap>();

        public void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
            Console.WriteLine($"Kitap eklendi. {kitap.ad}");
        }

        public void KitapSil(int id)
        {
            var kitap = kitaplar.FirstOrDefault(k => k.id == id);

            if (kitap != null)
            {
                kitaplar.Remove(kitap);
                Console.WriteLine($"Kitap silindi. {kitap.ad}");
            }

            else
            {
                Console.WriteLine("Kitap bulunamadı");
            }
        }

        public void KitapGuncelle(int id, Kitap yeniBilgiler)
        {
            var kitap = kitaplar.FirstOrDefault(k => k.id == id);

            if (kitap != null)
            {
                kitap.ad = yeniBilgiler.ad;
                kitap.yazar = yeniBilgiler.yazar;
                kitap.tur = yeniBilgiler.tur;
                kitap.yayinTarihi = yeniBilgiler.yayinTarihi;
                Console.WriteLine("Kitap güncellendi.");
            }

            else
            {
                Console.WriteLine("Kitap güncellenemedi");
            }
        }

        public Kitap kitapAra(string ad)
        {
            var kitap = kitaplar.FirstOrDefault(k => k.ad.Equals(ad, StringComparison.OrdinalIgnoreCase));
            return kitap;
        }


        public void Listele()
        {
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine(kitap);
            }
        }

    }
}

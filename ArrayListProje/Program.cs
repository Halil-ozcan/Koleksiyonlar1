using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciSecim = string.Empty;
            ArrayList degerListesi = new ArrayList();
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1- Deger Ekle");
                Console.WriteLine("2- Deger Listele");
                Console.WriteLine("3- Deger Ara");
                Console.WriteLine("4- Deger Düzenle");
                Console.WriteLine("5- Deger Sil");
                Console.WriteLine("6- Uygulama Çıkış");
                Console.Write("Seciniz : ");

                 kullaniciSecim = Console.ReadLine();

                

                switch (kullaniciSecim)
                {
                    case "1":
                        Console.Write("Lütfen Eklemek İstediğiniz değeri giriniz : ");
                        string kullanicideger = Console.ReadLine();
                        degerListesi.Add(kullanicideger);
                        Console.WriteLine("Değeriniz Başarılı bir şekilde eklendi");
                        System.Threading.Thread.Sleep(2000);// Sistemin 2 saniye bekletir.
                        break;

                    case "2":
                        for(int i = 0; i<degerListesi.Count; i++)
                        {
                            Console.WriteLine("{0}. değer : {1}", i, degerListesi[i]);
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basınız");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Aramak istediğniz değeri giriniz : ");
                        string kullaniciArananDeger = Console.ReadLine();
                        bool kontrol = degerListesi.Contains(kullaniciArananDeger);
                        if(kontrol)
                        {
                            int bulunanIndex = degerListesi.IndexOf(kullaniciArananDeger);
                            string bulunandeger = degerListesi[bulunanIndex].ToString();
                            Console.WriteLine("Degeriniz Bulundu : İndex sirasi : {0}. deger : {1}", bulunanIndex, bulunandeger);

                        }
                        else
                        {
                            Console.WriteLine("Aradıgınız kriterlerde bir deger bulunamdı.");
                        }
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "4":
                        Console.WriteLine("Güncellemek İstediğniz degeri giriniz : ");
                        string kullaniciDuzenlenecekDeger = Console.ReadLine();

                        Console.WriteLine("{0} degerini hangi deger ile güncellemek istiyorsunuz", kullaniciDuzenlenecekDeger);

                        string kullaniciYeniDeger = Console.ReadLine();

                        if(degerListesi.Contains(kullaniciDuzenlenecekDeger))
                        {
                            int kullaniciHedefIndex = degerListesi.IndexOf(kullaniciDuzenlenecekDeger);
                            degerListesi[kullaniciHedefIndex] = kullaniciYeniDeger;
                            Console.WriteLine("Degeriniz Güncellendi");
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız değer Liste içerisinde bulunamadı");
                        }
                        System.Threading.Thread.Sleep(2000);
                        break;
                    case "5":
                        Console.WriteLine("Tüm değerleri mi silemek istiyorsunuz (E/H)");
                        string kullaniciSilCevap = Console.ReadLine();

                        if(kullaniciSilCevap.ToUpper() == "E")
                        {
                            degerListesi.Clear();
                            Console.WriteLine("Tüm Değerler Silindi");

                        }
                        else
                        {
                            Console.WriteLine("Liste içerisinde Silmek istediğiniz değeri Giriniz : ");
                            string KullaniciSilDeger = Console.ReadLine();
                            if(degerListesi.Contains(KullaniciSilDeger))
                            {
                                degerListesi.Remove(KullaniciSilDeger);
                                Console.WriteLine("Değeriniz Silindi");
                            }
                            else
                            {
                                Console.WriteLine("Silmek İstediğiniz deger liste içerisinde bulunamadı.");
                            }
                        }
                        break;
                    default:
                        break;

                }
                
            }while(kullaniciSecim !="6");
            {

            }
        }
    }
}

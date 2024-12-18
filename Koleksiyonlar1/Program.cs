using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList A1 = new ArrayList();

            A1.Add("Halil Özcan");
            A1.Add(100);

            // Birden Fazla Deger Ekleme İşlemi

            ArrayList A2 = new ArrayList();

            A2.Add("Halil");
            A2.Add("Hasan");

            A1.AddRange(A2);

            // Koleksiyon içindeki değere ulaşmak

            object O1 = A1[1];
            string S1 = A1[1].ToString();
            int T1 = (int)A1[1];

            A1[1] = "Hamza Çetin";

            //Array List Koleksiyonu içerisindeki değeri silme

            A1.Remove("Hamza Çetin");
            A1.RemoveRange(2, 2); // 2.elemandan başla 2 eleman sil demek oluyor.
            A1.RemoveAt(1); //1.indexi Sil demek.


            // ArrayList Sıralama
            // A-Z Sıralama
            A1.Sort(); // Sortta değer tiplerine bakarak sıraladığı için int ve string türünü aynı anda sırlamaz hata verir.
            //Dizinin mevcut sırlamasını terse çevirir.
            A1.Reverse();// Burda ise hata vermez direk diziyi ters çevirir.

            // Koleksiyonlar yardımcı metotlar

            bool kontrol = A1.Contains("Halil");// A1 koleksiyonun içerisinde bu değerin olup olmadığına bakar. varsa true yoksa false döner.
            bool kontrol2 = A1.Contains(100);

            int indexDegeri = A1.IndexOf("Halil"); //Dizi içerindeki o değerin indexini bulup gösterir.

            A1.Clear(); // bütün diziyi temizler.

            object[] d1 = A1.ToArray(); // Değerleri Dizi Şeklinde verir.

            // 10 elemanlı ArrayList içindeki  değerleri Z-A olacak şekilde Sıralayın.

            ArrayList OdevListe = new ArrayList();

            OdevListe.Add("Zeynep");
            OdevListe.Add("Hakan");
            OdevListe.Add("Musa");
            OdevListe.Add("Yakup");
            OdevListe.Add("İsmail");
            OdevListe.Add("Kazım");
            OdevListe.Add("Sibel");
            OdevListe.Add("Cengiz");
            OdevListe.Add("Hülya");
            OdevListe.Add("Furkan");

            OdevListe.Sort(); // Önce sort yapıp sonra reverse yaparak indexlerin karışmasını önledik
            OdevListe.Reverse();
        }
    }
}

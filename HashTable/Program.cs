using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();

            H1.Add("Car", "Araba");
            H1.Add("House", "Ev");

            // yardımcı metotlar
            bool kontrol = H1.Contains("House");

            H1.ContainsKey("House");
            H1.ContainsValue("Ev");

            H1.Clear();

            int KoleksiyonCount = H1.Count; // Koleksiyon içindeki toplamm değeri verir;

            H1.Remove("Car");

            H1["House"] = "Villa"; // Güncellemek istenen deger
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_květen
{
    class Inventory
    {
        private List<Product> produkty = new List<Product>();
        public void PridatProdukt()
        {
            Product produkt = new Product();
            try
            {
                Console.Write("Napiš název: ");
                produkt.Name = Console.ReadLine();
                Console.Write("Napiš cenu: ");
                produkt.Price = double.Parse(Console.ReadLine());
                Console.Write("Napiš počet: ");
                produkt.Quantity = int.Parse(Console.ReadLine());
                produkty.Add(produkt);
                Console.Clear();
                Console.WriteLine(produkt.Name  + " byl přidán");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba při přidávání produktu: " + ex.Message);
            }
        }
        public void OdebratProdukt()
        {
            try
            {
                Console.WriteLine("Npiš číslo řádku produktu který chceš odebrat");
                int indexListu = int.Parse(Console.ReadLine()) -1;
                produkty.RemoveAt(indexListu);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba při odebírání produktu: " + ex.Message);
            }
        }
        public void VypisInventar()
        {
            Console.WriteLine("Aktuální inventář:");
            foreach (Product produkt in produkty)
            {
                Console.WriteLine(produkt.Name + " - " + produkt.Quantity + " - " + produkt.Price + " Kč ");
            }
        }
    }
}
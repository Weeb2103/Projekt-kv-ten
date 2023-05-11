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
                Console.WriteLine(produkt.Name  + " byl přidán");  //použito aby si uživatel byl jistý že produkt byl přidán
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
                //Zde jsem vypsal inventář aby mohl uživatel ihned zjistit číslo řádku produktu který chce odebrat
                znovu:
                foreach (Product produkt in produkty)
                {
                    Console.WriteLine((produkty.IndexOf(produkt) + 1) + ")" + produkt.Name + " - " + produkt.Price + " Kč - " + produkt.Quantity + " ks"); //použit IndexOf na ocislovani radku
                }
                Console.WriteLine("--------------------------");
                Console.WriteLine("Napiš číslo řádku produktu který chceš odebrat a ukonči odebírání pomocí čísla 777");
                int indexListu = int.Parse(Console.ReadLine()) - 1;
                if (indexListu == 777); //použito aby mohl uživatel mazat stále dokola a pomocí čísla 777 ukončit mazání (předpokládá se že mají pod 777 položek)
                else
                produkty.RemoveAt(indexListu);
                Console.Clear();
                goto znovu;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Chyba při odebírání produktu: " + ex.Message);
            }
        }
        public void VypisInventar()
        {
            Console.WriteLine("Aktuální inventář");
            Console.WriteLine("------------------");
            foreach (Product produkt in produkty)
            {
                Console.WriteLine((produkty.IndexOf(produkt) + 1) + ")" + produkt.Name + " - " + produkt.Price + " Kč - "  + produkt.Quantity + " ks" ); //použit IndexOf na ocislovani radku
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Calculator
{

    public class BillMaker
    {
        public List<Produkt> MakeBill()
        {
            var paragon1 = new List<Produkt>();
            int ilosc = 0;

            Console.WriteLine("Podaj ilość produktów:");
            ilosc = Convert.ToInt32(Console.ReadLine());
            //Tworzenie listy paragonowej
            for (int i = 0; i < ilosc; i++)
            {
                var nowyProdukt = new Produkt();

                Console.WriteLine("Nazwa produktu:");
                nowyProdukt.Nazwa = Console.ReadLine().Trim();

                Console.WriteLine("Cena produktu:");
                nowyProdukt.Cena = Console.ReadLine().Trim();

                paragon1.Add(nowyProdukt);
            }
            return paragon1;
        }

    }
}

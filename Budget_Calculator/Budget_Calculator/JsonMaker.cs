using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace Budget_Calculator
{
    public class JsonMaker

    {
        string data = DateTime.Now.ToString("MMMM");
        string sciezkaDoPliku = Path.Combine(Environment.CurrentDirectory, @"Paragon", DateTime.Now.ToString("MMMM") + " " + DateTime.Now.ToString("yyyy") + ".json");

        public int MakeJson()
        {
            string potwierdzenie;

            var paragon = new BillMaker();
            var paragon2 = paragon.MakeBill();

            do
            {
                //Ostatnie sprawdzenie listy
                Console.WriteLine("Sprawdź czy paragon się zgadza: Tak/Nie");
                potwierdzenie = Console.ReadLine().Trim().ToLower();

            } while (potwierdzenie != "tak" && potwierdzenie != "nie");

            if (potwierdzenie == "tak")
            {

                // Zapis JSON do pliku na dysku/ else aktualizacja


                if (!File.Exists(sciezkaDoPliku))
                {
                    // Zamiana listy obiektów na JSON
                    var jsonParagonu = JsonConvert.SerializeObject(paragon2);

                    //Stworzenie Pliku
                    File.WriteAllText(sciezkaDoPliku, jsonParagonu);

                }

                else
                {
                    var paragonZPliku = JsonReader(sciezkaDoPliku);

                    // Dodanie nowego paragonu do starego
                    paragonZPliku.AddRange(paragon2);

                    // Zamiana obiektu z powrotem na string
                    var jsonParagonu = JsonConvert.SerializeObject(paragonZPliku);

                    // Zapis do pliku
                    File.WriteAllText(sciezkaDoPliku, jsonParagonu);
                }
                return 0;

            }

            else if (potwierdzenie == "nie") ;
            {
                return 0;
            }
        }

        public List<Produkt> JsonReader(string sciezka)
        {
            // Wczytaj z istniejącego pliku
             var czystyJson = File.ReadAllText(sciezka);

            // Zamiana stringa z pliku na obiekt
            var paragonZPliku = JsonConvert.DeserializeObject<List<Produkt>>(czystyJson);
            Console.WriteLine(czystyJson);
            return paragonZPliku;
        }
    }
}
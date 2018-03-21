using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace Budget_Calculator
{
    public class JsonMaker
    {
        public int MakeJson()
        {
            string data = DateTime.Now.ToString("MMMM");
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
                var sciezkaDoPliku = @"e:\paragon_" + data + ".json";

                if (!File.Exists(sciezkaDoPliku))
                {
                    // Zamiana listy obiektów na JSON
                    var jsonParagonu = JsonConvert.SerializeObject(paragon2);

                    //Stworzenie Pliku
                    File.WriteAllText(sciezkaDoPliku, jsonParagonu);

                }
                
                else
                {
                    // Wczytaj z istniejącego pliku
                    var czystyJson = File.ReadAllText(sciezkaDoPliku);

                    // Zamiana stringa z pliku na obiekt
                    var paragonZPliku = JsonConvert.DeserializeObject<List<Produkt>>(czystyJson);

                    // Dodanie nowego paragonu do starego
                    paragonZPliku.AddRange(paragon2);

                    // Zamiana obiektu z powrotem na string
                    var jsonParagonu = JsonConvert.SerializeObject(paragonZPliku);

                    // Zapis do pliku
                    File.WriteAllText(sciezkaDoPliku, jsonParagonu);
                }
                return 0;
                
            }
            
            else if (potwierdzenie == "nie");
            {
                return 0;
            }
        }
    }
}
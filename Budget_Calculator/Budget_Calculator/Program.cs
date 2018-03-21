using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Budget_Calculator
{
    class Program
    {

        static void Main()
        {
            bool exit;
            do
            {
                var billMaker = new BillMaker();
                var jsonMaker = new JsonMaker();
                var counter = new Counter();


                Console.WriteLine("1.Dodaj paragon");
                Console.WriteLine("2.Podsumowanie miesiąca");



                Console.WriteLine("100.Exit");

                Console.WriteLine("Opcja: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                        var jfile = jsonMaker.MakeJson();
                        break;
                    case "2":
                        var cou = counter.MakeMonthlyCount();
                        break;
                    case "100":
                        //Application.Terminate(); 
                        break;

                    default:
                        Console.WriteLine("Nie ma takiej opcji");
                        break;
                }

            } while (true);

            {

            }


            //Potrzebuję:
            //Stworzenie pliku1(obecne nazwa miesiąca): wprowadzenie do niego tekstu: DONE
            //Zczystanie tekstu z konsoli:"nazwaProduktu/cena" Done
            //wyszukanie nazwy produktu na liście w pliku1. dodatnie kosztów w miesiącu do ceny wprowadzonej. Edit. Aktualizacja pliku o powturzenie produktu

            //Rozszerzenie:
            //zczytanie produktów z zdjęcia paragonu
            //podzielenie produktów na kategorie
            //zrobienie zestawień miesiecznych
        }
    }
}


using System;

namespace Budget_Calculator
{
    
    public class Counter
    {

        public void MakeMonthlyCount()
        {
            Console.WriteLine("Podaj miesiąc który cię interesuje i rok");

            var sciezka = Console.ReadLine();

            var jsonMaker = new JsonMaker();
            var lista = jsonMaker.JsonReader(sciezka);
            

            foreach (var item in lista)
            {
                if (true)
                {

                }
            }

        }
    }
    
}
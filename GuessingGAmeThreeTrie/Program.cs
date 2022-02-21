using System;

namespace GuessingGAmeThreeTrie
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme kastega numbrit ära arvata
            //siis mängu võidab arvuti.
            //*programm genereerib juhuslikku numbrit ühte korda.
            
            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            Console.WriteLine("Mängu võitmiseks tuleb valida üks number (1 kuni 10). Teil on kolm katset!");

            while( i < 3)
            {
                Console.WriteLine("Palun kirjuta number:");
                int UserNumber = Convert.ToInt32(Console.ReadLine());

                if(UserNumber == cpuNumber)
                {
                    Console.WriteLine("Oled võitja!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Proovi uuesti! Teil on veel {3 - i} katset on jäänud.");
                }
               

            }


            Console.WriteLine($"Juhuslik number oli: {cpuNumber}");












        }
    }
}

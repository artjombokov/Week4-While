using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
          //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool loopActive = true;
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Mängu võitmiseks tuleb valida üks number (1 kuni 10):");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Oled võitja!");
                    loopActive = false; 
                }
                else
                {
                    i++;
                  Console.WriteLine("Vale vastus! Proovi veel!");
                }

            }
            
            
            Console.WriteLine($"Juhuslik number oli: {cpuNumber}");
        }
    }
}

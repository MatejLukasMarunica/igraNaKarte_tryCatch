using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igraNaKarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int karte = 0;
            int vrijednost = 0;

            while (vrijednost < 31)
            {

                Console.WriteLine("  Unesi vrijednost karte čija vrijednost može biti od 1 do 13.  ");
            povratak:
                try
                {
                    karte = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception greska)
                {
                    
                        Console.WriteLine(" Unesli ste slovo ili znak  ");
                    Console.WriteLine(greska.Message);
                }
                if(karte < 1 || karte > 13)
                {
                    Console.WriteLine("  Pogrešan raspon vrijednosti ste upisali. Unesi ponovno  ");
                    karte = 0;
                    goto povratak;
                }
                else
                {
                    vrijednost = vrijednost += karte;
                    karte = 0;
                }
            }

            Console.WriteLine("  Ukupan iznos unešenih vrijednosti karta je:  " +vrijednost );

            if(vrijednost == 31)
            {
                Console.WriteLine("  Svakačast, Pobjedio.  ");
            }

            else if(vrijednost > 31)
            {
                Console.WriteLine("  Izgubio si.  ");
            }
            Console.ReadKey();
        }
    }
}

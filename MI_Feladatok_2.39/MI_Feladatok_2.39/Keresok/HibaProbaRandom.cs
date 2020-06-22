using MI_Feladatok_2._39.Allapotter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_Feladatok_2._39.Keresok
{
    class HibaProbaRandom:Kereso
    {
        public HibaProbaRandom()
        {
            Kereses();
        }
        public override void Kereses()
        {
            Allapot kezdAllapot = new Allapot();
            Stack<Allapot> ut = new Stack<Allapot>();

            ut.Push(kezdAllapot);

            Random rnd = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int szam = rnd.Next(0, operatorok.Count());
                Operator aktualisOperator = operatorok[szam];

                if (aktualisOperator.EloFeltetel(ut.Peek()))
                {
                    Allapot ujAllapot = aktualisOperator.Mozgatas(ut.Peek());
                    ut.Push(ujAllapot);

                    if (ujAllapot.celFeltetel())
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < ut.Count; i++)
            {
                Utvonal.Add(ut.ElementAt(i));
                Console.WriteLine(ut.ElementAt(i));
            }
            Utvonal.Reverse();
            Console.WriteLine(Utvonal.Count);
        }
    }
}

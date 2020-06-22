using MI_Feladatok_2._39.Allapotter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_Feladatok_2._39.Keresok
{
    class BackTrack:Kereso
    {
        public BackTrack()
        {
            Kereses();
        }

        public override void Kereses()
        {
            Stack<Csomopont> ut = new Stack<Csomopont>();
            Csomopont kezdoAllapot = new Csomopont(new Allapot(), 0);

            ut.Push(kezdoAllapot);

            while (ut.Count > 0 && !ut.Peek().Allapot.celFeltetel())
            {
                Csomopont aktualisCsomopont = ut.Peek();

                if (this.operatorok.Count > aktualisCsomopont.Index)
                {
                    Operator aktualisOperator = operatorok[aktualisCsomopont.Index];
                    if (aktualisOperator.EloFeltetel(aktualisCsomopont.Allapot))
                    {
                        Allapot ujAllapot = aktualisOperator.Mozgatas(aktualisCsomopont.Allapot);
                        Csomopont ujCsomopont = new Csomopont(ujAllapot, 0);

                        if (!ut.Contains(ujCsomopont))
                        {
                            ut.Push(ujCsomopont);
                        }
                    }
                    aktualisCsomopont.Index++;
                }
                else
                {
                    ut.Pop();
                }
            }
            for (int i = 0; i < ut.Count; i++)
            {
                Utvonal.Add(ut.ElementAt(i).Allapot);
                Console.WriteLine(ut.ElementAt(i));
            }
            Utvonal.Reverse();
        }
    }
}

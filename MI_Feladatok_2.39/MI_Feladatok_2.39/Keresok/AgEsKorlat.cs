using MI_Feladatok_2._39.Allapotter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_Feladatok_2._39.Keresok
{
    class AgEsKorlat:Kereso
    {
        public AgEsKorlat()
        {
            Kereses();
        }

        public override void Kereses()
        {
            Stack<Csomopont> ut = new Stack<Csomopont>();
            Csomopont kezdoAllapot = new Csomopont(new Allapot(), 0);
            ut.Push(kezdoAllapot);

            while (ut.Count > 0)
            {
                Csomopont aktualisCsomopont = ut.Peek();
                if (this.operatorok.Count > aktualisCsomopont.Index)
                {
                    Operator aktualisOperator = operatorok[aktualisCsomopont.Index];

                    if (aktualisOperator.EloFeltetel(aktualisCsomopont.Allapot))
                    {
                        Allapot ujAllapot = aktualisOperator.Mozgatas(aktualisCsomopont.Allapot);
                        Csomopont ujCsomopont = new Csomopont(ujAllapot, 0);
                        if (!ut.Contains(ujCsomopont) && (Utvonal.Count == 0 || ut.Count < Utvonal.Count))
                        {
                            ut.Push(ujCsomopont);
                        }
                    }
                    aktualisCsomopont.Index++;
                }
                else
                {
                    Csomopont torol = ut.Pop();
                }
                if (ut.Count > 0 && ut.Peek().Allapot.celFeltetel())
                {
                    if (Utvonal.Count == 0 || ut.Count < Utvonal.Count)
                    {
                        Utvonal.Clear();
                        for (int i = 0; i < ut.Count; i++)
                        {
                            Utvonal.Add(ut.ElementAt(i).Allapot);
                        }
                        Utvonal.Reverse();
                    }
                }
            }
        }
    }
}

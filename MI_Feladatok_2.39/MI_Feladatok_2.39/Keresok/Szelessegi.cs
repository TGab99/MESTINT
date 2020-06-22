using MI_Feladatok_2._39.Allapotter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_Feladatok_2._39.Keresok
{
    class Szelessegi:Kereso
    {
        public override void Kereses()
        {
            Queue<Csomopont> nyilt = new Queue<Csomopont>();
            List<Csomopont> zart = new List<Csomopont>();

            nyilt.Enqueue(new Csomopont(new Allapot(), 0, null));

            while (nyilt.Count > 0 && nyilt.Peek().Allapot.celFeltetel())
            {
                Csomopont aktualisCsomopont = nyilt.Dequeue();
                foreach (Operator aktualisOperator in operatorok)
                {
                    if (aktualisOperator.EloFeltetel(aktualisCsomopont.Allapot))
                    {
                        Allapot ujAllapot = aktualisOperator.Mozgatas(aktualisCsomopont.Allapot);
                        Csomopont ujCsomopont = new Csomopont(ujAllapot, 0);
                        if (nyilt.Contains(ujCsomopont) && !zart.Contains(ujCsomopont))
                        {

                        }
                        nyilt.Enqueue(ujCsomopont);
                    }
                }
                zart.Add(aktualisCsomopont);
            }
        }
    }
}

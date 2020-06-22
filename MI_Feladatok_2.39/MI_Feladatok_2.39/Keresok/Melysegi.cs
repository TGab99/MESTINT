using MI_Feladatok_2._39.Allapotter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_Feladatok_2._39.Keresok
{
    class Melysegi:Kereso
    {
        public Melysegi()
        {
            Kereses();
        }
        public override void Kereses()
        {
            Stack<Csomopont> nyilt = new Stack<Csomopont>();
            List<Csomopont> zart = new List<Csomopont>();

            nyilt.Push(new Csomopont(new Allapot(), 0, null));

            while (nyilt.Count > 0 && !nyilt.Peek().Allapot.celFeltetel())
            {
                Csomopont aktualisCsomopont = nyilt.Pop();
                foreach (Operator aktualisOperator in operatorok)
                {
                    if (aktualisOperator.EloFeltetel(aktualisCsomopont.Allapot))
                    {
                        Allapot ujAllapot = aktualisOperator.Mozgatas(aktualisCsomopont.Allapot);
                        Csomopont ujCsomopont = new Csomopont(ujAllapot, 0, aktualisCsomopont);
                        if (!nyilt.Contains(ujCsomopont) && !zart.Contains(ujCsomopont))
                        {
                            nyilt.Push(ujCsomopont);
                        }
                    }
                }
                zart.Add(aktualisCsomopont);
            }

            if (nyilt.Count > 0)
            {
                Csomopont celCsomopont = nyilt.Peek();
                if (celCsomopont != null)
                {
                    this.Utvonal.Add(celCsomopont.Allapot);
                    celCsomopont = celCsomopont.Szulo;
                }
                Utvonal.Reverse();
            }
        }
    }
}

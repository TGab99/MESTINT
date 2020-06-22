﻿using MI_Feladatok_2._39.Allapotter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_Feladatok_2._39.Keresok
{
    class Optimalis:Kereso
    {
        public override void Kereses()
        {
            List<Csomopont> ut = new List<Csomopont>();
            ut.Add(new Csomopont(new Allapot(), 0, null));

            while (ut.Count > 0 && !ut.Last().Allapot.celFeltetel())
            {
                Csomopont aktualisCsomopont = ut.Last();
                ut.RemoveAt(ut.Count - 1);
                foreach (Operator aktOperator in this.operatorok)
                {
                    if (aktOperator.EloFeltetel(aktualisCsomopont.Allapot))
                    {
                        Allapot ujAllapot = aktOperator.Mozgatas(aktualisCsomopont.Allapot);
                        Csomopont ujCsomopont = new Csomopont(ujAllapot, 0, aktualisCsomopont);

                        if (!ut.Contains(ujCsomopont))
                        {
                            ut.Add(ujCsomopont);
                        }
                        else
                        {
                            int i = ut.IndexOf(ujCsomopont);
                            Csomopont regiCsomopont = ut.ElementAt(i);

                            if (regiCsomopont.Koltseg > ujCsomopont.Koltseg)
                            {
                                ut[i] = ujCsomopont;
                            }
                        }
                    }
                }

                ut.Sort(
                    delegate (Csomopont cs1, Csomopont cs2)
                    {
                        if (cs1.Koltseg > cs2.Koltseg)
                        {
                            return -1;
                        }
                        else if (cs1.Koltseg < cs2.Koltseg)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    });
            }

            if (ut.Count > 0)
            {
                Csomopont celCsomopont = ut.Last();
                while (celCsomopont != null)
                {
                    this.Utvonal.Add(celCsomopont.Allapot);
                    celCsomopont = celCsomopont.Szulo;
                }
                Utvonal.Reverse();
            }

        }
    }
}

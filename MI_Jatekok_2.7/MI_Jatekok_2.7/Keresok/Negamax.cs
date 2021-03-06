﻿using MI_Jatekok_2._7.Allapotter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_Jatekok_2._7.Keresok
{
    class Negamax
    {
        public const int maxMelyseg = 2;
        List<Operator> ajanlottOperatorok = new List<Operator>();

        public List<Operator> ajanl(Allapot allapot)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Operator aktualisOperator = new Operator(new System.Drawing.Point(i, j));
                    if (aktualisOperator.eloFeltetel(allapot))
                    {
                        Allapot ujAllapot = aktualisOperator.letesz(allapot);
                        bejaras(ujAllapot, aktualisOperator, 0, 1);
                        ajanlottOperatorok.Add(aktualisOperator);
                    }
                }
            }

            ajanlottOperatorok = ajanlottOperatorok.OrderByDescending(o => o.Suly).ToList();

            return ajanlottOperatorok;
        }

        public void bejaras(Allapot allapot, Operator eredetiOperator, int melyseg, int elojel)
        {
            if (allapot.celFeltetel() != null)
            {
                eredetiOperator.Suly = elojel * allapot.heurisztika();
            }
            else
            {
                if (melyseg < maxMelyseg)
                {
                    int max = Int32.MinValue;
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Operator aktualisOperator = new Operator(new System.Drawing.Point(i, j));
                            if (aktualisOperator.eloFeltetel(allapot))
                            {
                                Allapot ujAllapot = aktualisOperator.letesz(allapot);
                                int aktSuly = elojel * ujAllapot.heurisztika();
                                if (aktSuly > max)
                                {
                                    max = aktSuly;
                                }
                                eredetiOperator.Suly += max;

                                bejaras(ujAllapot, eredetiOperator, melyseg + 1, -elojel);
                            }
                        }
                    }
                }
            }
        }
    }
}

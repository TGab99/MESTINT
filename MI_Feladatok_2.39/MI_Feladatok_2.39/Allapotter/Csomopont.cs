﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_Feladatok_2._39.Allapotter
{
    class Csomopont
    {
        private Allapot allapot;
        public Allapot Allapot
        {
            get { return allapot; }
            set { allapot = value; }
        }
        private int index;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }


        private Csomopont szulo;

        public Csomopont Szulo
        {
            get { return szulo; }
            set { szulo = value; }
        }

        private int koltseg;

        public int Koltseg { get => koltseg; set => koltseg = value; }

        private int heurisztika;

        public int Heurisztika { get => heurisztika; set => heurisztika = value; }

        private int osszKoltseg;

        public int OsszKoltseg { get => osszKoltseg; set => osszKoltseg = value; }
        public Csomopont(Allapot allap, int index)
        {
            this.index = index;
            this.allapot = allap;
        }
        public Csomopont(Allapot allap, int index, Csomopont szulo)
        {
            this.index = index;
            this.allapot = allap;
            this.szulo = szulo;
            if (szulo == null)
            {
                Koltseg = 1;
            }
            else
            {
                Koltseg = szulo.Koltseg + 1;
            }
        }

        public override bool Equals(object obj)
        {
            Csomopont masikCsomopont = (Csomopont)obj;

            return Allapot.Equals(masikCsomopont.Allapot);
        }
        public override string ToString()
        {
            return Allapot.ToString();
        }
    }
}

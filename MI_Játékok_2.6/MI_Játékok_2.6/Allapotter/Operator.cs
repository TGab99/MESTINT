using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_Játékok_2._6.Allapotter
{
    class Operator
    {
        public Operator(Point koordinata)
        {
            this.Koordinata = koordinata;
            this.Suly = 0;
        }

        private Point koordinata;

        public Point Koordinata
        {
            get
            {
                return koordinata;
            }
            set
            {
                koordinata = value;
            }
        }

        private int suly;

        public int Suly
        {
            get
            {
                return suly;
            }
            set
            {
                suly = value;
            }
        }

        public bool eloFeltetel(Allapot allapot)
        {
            return allapot.Matrix[koordinata.X, koordinata.Y] == ".";
        }

        public Allapot felvesz(Allapot allapot)
        {
            Allapot ujAllapot = new Allapot();
            ujAllapot.Jatekos = allapot.Jatekos;
            ujAllapot.Matrix = (string[,])allapot.Matrix.Clone();
            ujAllapot.Matrix[koordinata.X, koordinata.Y] = allapot.Matrix[koordinata.X,koordinata.Y].Replace(".",null);

            if (ujAllapot.Jatekos == true)
            {
                ujAllapot.Jatekos = false;
            }
            else
            {
                ujAllapot.Jatekos = true;
            }
            return ujAllapot;
        }
    }
}

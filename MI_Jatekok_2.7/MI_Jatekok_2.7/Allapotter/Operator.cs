using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_Jatekok_2._7.Allapotter
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
            return allapot.Matrix[koordinata.X, koordinata.Y] == null;
        }

        public Allapot letesz(Allapot allapot)
        {
            Allapot ujAllapot = new Allapot();
            ujAllapot.Jatekos = allapot.Jatekos;
            ujAllapot.Matrix = (string[,])allapot.Matrix.Clone();
            ujAllapot.Matrix[koordinata.X, koordinata.Y] = ujAllapot.Jatekos;

            if(ujAllapot.Jatekos == ElsoJatekosJelei.X.ToString())
            {
                ujAllapot.Jatekos = MasodikJatekosJelei.O.ToString();
            }else if(ujAllapot.Jatekos == MasodikJatekosJelei.O.ToString())
            {
                ujAllapot.Jatekos = ElsoJatekosJelei.Y.ToString();
            }else if(ujAllapot.Jatekos == ElsoJatekosJelei.Y.ToString())
            {
                ujAllapot.Jatekos = MasodikJatekosJelei.P.ToString();
            }else if(ujAllapot.Jatekos == MasodikJatekosJelei.P.ToString())
            {
                ujAllapot.Jatekos = ElsoJatekosJelei.X.ToString();
            }

            return ujAllapot;
        }
    }
}

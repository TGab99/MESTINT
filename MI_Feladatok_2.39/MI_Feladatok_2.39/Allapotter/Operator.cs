using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_Feladatok_2._39.Allapotter
{
    class Operator
    {
        private int melyiket;
        public int Melyiket
        {
            get
            {
                return melyiket;
            }
            set
            {
                melyiket = value;
            }
        }

        private string hova;

        public string Hova
        {
            get
            {
                return hova;
            }
            set
            {
                hova = value;
            }
        }

        public Operator(int melyiket, string hova)
        {
            this.Melyiket = melyiket;
            this.Hova = hova;
        }

        public Allapot Mozgatas(Allapot allapot)
        {
            Allapot ujAllapot = new Allapot();
            for (int i = 0; i < Allapot.korongSzam; i++)
            {
                ujAllapot.Korong1[i] = allapot.Korong1[i];
            }
            ujAllapot.Korong1[melyiket] = hova;
            for (int i = 0; i < Allapot.korongSzam; i++)
            {
                ujAllapot.Korong2[i] = allapot.Korong2[i];
            }
            ujAllapot.Korong2[melyiket] = hova;
            return ujAllapot;
        }

        public bool EloFeltetel(Allapot allapot)
        {
            if (allapot.Korong1[melyiket] == hova)
            {
                return false;
            }
            if (allapot.Korong2[melyiket] == hova)
            {
                return false;
            }
            for (int i = 0; i < melyiket; i++)
            {
                if (allapot.Korong1[i] == allapot.Korong1[melyiket] || allapot.Korong1[i] == hova)
                {
                    return false;
                }
            }
            for (int i = 0; i < melyiket; i++)
            {
                if (allapot.Korong2[i] == allapot.Korong2[melyiket] || allapot.Korong2[i] == hova)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

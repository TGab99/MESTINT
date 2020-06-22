using MI_Feladatok_2._39.Allapotter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_Feladatok_2._39.Keresok
{
    abstract class Kereso
    {
        private List<Allapot> utvonal = new List<Allapot>();

        public List<Allapot> Utvonal
        {
            get
            {
                return utvonal;
            }
            set
            {
                utvonal = value;
            }
        }

        protected List<Operator> operatorok = new List<Operator>();

        public Kereso()
        {
            operatorokGeneralasa();
        }

        public void operatorokGeneralasa()
        {
            for (int i = 0; i < Allapot.korongSzam; i++)
            {
                for (int j = 0; j < Allapot.oszlopok.Length; j++)
                {
                    operatorok.Add(new Operator(i, Allapot.oszlopok[j]));
                }
            }
        }

        public abstract void Kereses();
    }
}

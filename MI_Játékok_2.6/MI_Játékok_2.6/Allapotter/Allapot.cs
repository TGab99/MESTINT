using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_Játékok_2._6.Allapotter
{
    class Allapot
    {
        public Allapot()
        {
            Jatekos = true;
        }

        private string[,] matrix = new string[4, 4];

        private bool jatekos;

        public string[,] Matrix
        {
            get
            {
                return matrix;
            }
            set
            {
                matrix = value;
            }
        }

        public bool Jatekos
        {
            get
            {
                return jatekos;
            }
            set
            {
                jatekos = value;
            }
        }


        public string celFeltetel()
        {
            int szam = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrix[i, j] != null)
                        szam++;
                }
            }

            if(szam == 1)
            {
                if(jatekos == true)
                {
                    return "Az első játékos vesztett!";
                }
                else
                {
                    return "A második játékos vesztett!";
                }
            }

            return null;
        }

        public int heurisztika()
        {
            int suly = 0;

            if(celFeltetel() == "Az első játékos vesztett!")
            {
                return 100;
            }

            if(celFeltetel() == "A második játékos vesztett!")
            {
                return 100;
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(j + 1 < 4 && matrix[i,j+1] == " " && jatekos == true)
                    {
                        suly += 2;
                    }
                    if(i+1 < 4 && matrix[i+1,j] == " " && jatekos == true)
                    {
                        suly += 2;
                    }
                }
            }

            return suly;
        }
    }
}

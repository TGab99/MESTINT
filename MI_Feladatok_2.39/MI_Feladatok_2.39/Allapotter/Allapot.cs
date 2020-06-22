using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_Feladatok_2._39.Allapotter
{
    class Allapot
    {
        public Allapot()
        {
            for (int i = 0; i < korongSzam; i++)
            {
                Korong1[i] = "P";
            }
            for (int i = 0; i < korongSzam; i++)
            {
                Korong2[i] = "Q";
            }
        }
        public static int korongSzam = 8;

        private string[] korong1 = new string[korongSzam];

        private string[] korong2 = new string[korongSzam];

        public static string[] oszlopok = new string[] { "P", "Q", "R" };

        public string[] Korong1
        {
            get
            {
                return korong1;
            }
            set
            {
                korong1 = value;
            }
        }

        public string[] Korong2
        {
            get
            {
                return korong2;
            }
            set
            {
                korong2 = value;
            }
        }

        public bool celFeltetel()
        {
            for (int i = 1; i < korongSzam; i+=2)
            {
                if(korong1[i] != "P")
                {
                    return false;
                }
            }
            for (int i = 0; i < korongSzam; i += 2)
            {
                if (korong2[i] != "P")
                {
                    return false;
                }
            }
            for (int i = 0; i < korongSzam; i += 2)
            {
                if (korong1[i] != "Q")
                {
                    return false;
                }
            }
            for (int i = 1; i < korongSzam; i += 2)
            {
                if (korong2[i] != "Q")
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("(");
            for (int i = 0; i < korongSzam; i++)
            {
                builder.Append(korong1[i]);
                builder.Append(", ");
            }
            builder.Append(")");
            builder.Append("(");
            for (int i = 0; i < korongSzam; i++)
            {
                builder.Append(korong2[i]);
                builder.Append(", ");
            }
            builder.Append(")");
            return builder.ToString();
        }

        public override bool Equals(object obj)
        {
            Allapot masikAllapot = (Allapot)obj;
            for (int i = 0; i < korongSzam; i++)
            {
                if (korong1[i] != masikAllapot.Korong1[i])
                {
                    return false;
                }
                if (korong2[i] != masikAllapot.Korong2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

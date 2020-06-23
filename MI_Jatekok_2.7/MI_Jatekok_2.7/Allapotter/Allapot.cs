using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI_Jatekok_2._7.Allapotter
{
    class Allapot
    {
        public Allapot()
        {
            Jatekos = ElsoJatekosJelei.X.ToString();
        }

        private string[,] matrix = new string[5, 5];

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

        private string jatekos;

        public string Jatekos
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
            for (int i = 0; i < 5; i++)
            {
                if(matrix[i,0] != null && matrix[i,0] == ElsoJatekosJelei.X.ToString() && matrix[i,1] 
                    == ElsoJatekosJelei.X.ToString() && matrix[i,2] == ElsoJatekosJelei.X.ToString() && matrix[i,3] == 
                    ElsoJatekosJelei.X.ToString() && matrix[i,4] == ElsoJatekosJelei.Y.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == ElsoJatekosJelei.Y.ToString() && matrix[i, 1]
                    == ElsoJatekosJelei.X.ToString() && matrix[i, 2] == ElsoJatekosJelei.X.ToString() && matrix[i, 3] ==
                    ElsoJatekosJelei.X.ToString() && matrix[i, 4] == ElsoJatekosJelei.X.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == ElsoJatekosJelei.X.ToString() && matrix[i, 1]
                    == ElsoJatekosJelei.Y.ToString() && matrix[i, 2] == ElsoJatekosJelei.X.ToString() && matrix[i, 3] ==
                    ElsoJatekosJelei.X.ToString() && matrix[i, 4] == ElsoJatekosJelei.X.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == ElsoJatekosJelei.X.ToString() && matrix[i, 1]
                    == ElsoJatekosJelei.X.ToString() && matrix[i, 2] == ElsoJatekosJelei.Y.ToString() && matrix[i, 3] ==
                    ElsoJatekosJelei.X.ToString() && matrix[i, 4] == ElsoJatekosJelei.X.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == ElsoJatekosJelei.X.ToString() && matrix[i, 1]
                    == ElsoJatekosJelei.X.ToString() && matrix[i, 2] == ElsoJatekosJelei.X.ToString() && matrix[i, 3] ==
                    ElsoJatekosJelei.Y.ToString() && matrix[i, 4] == ElsoJatekosJelei.X.ToString())
                {
                    return matrix[i, 0];
                }
            }


            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == ElsoJatekosJelei.X.ToString() && matrix[i, 1]
                    == ElsoJatekosJelei.Y.ToString() && matrix[i, 2] == ElsoJatekosJelei.Y.ToString() && matrix[i, 3] ==
                    ElsoJatekosJelei.Y.ToString() && matrix[i, 4] == ElsoJatekosJelei.Y.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == ElsoJatekosJelei.Y.ToString() && matrix[i, 1]
                    == ElsoJatekosJelei.X.ToString() && matrix[i, 2] == ElsoJatekosJelei.Y.ToString() && matrix[i, 3] ==
                    ElsoJatekosJelei.Y.ToString() && matrix[i, 4] == ElsoJatekosJelei.Y.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == ElsoJatekosJelei.Y.ToString() && matrix[i, 1]
                    == ElsoJatekosJelei.Y.ToString() && matrix[i, 2] == ElsoJatekosJelei.X.ToString() && matrix[i, 3] ==
                    ElsoJatekosJelei.Y.ToString() && matrix[i, 4] == ElsoJatekosJelei.Y.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == ElsoJatekosJelei.Y.ToString() && matrix[i, 1]
                    == ElsoJatekosJelei.Y.ToString() && matrix[i, 2] == ElsoJatekosJelei.Y.ToString() && matrix[i, 3] ==
                    ElsoJatekosJelei.X.ToString() && matrix[i, 4] == ElsoJatekosJelei.Y.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == ElsoJatekosJelei.Y.ToString() && matrix[i, 1]
                    == ElsoJatekosJelei.Y.ToString() && matrix[i, 2] == ElsoJatekosJelei.Y.ToString() && matrix[i, 3] ==
                    ElsoJatekosJelei.Y.ToString() && matrix[i, 4] == ElsoJatekosJelei.X.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == MasodikJatekosJelei.P.ToString() && matrix[i, 1]
                    == MasodikJatekosJelei.O.ToString() && matrix[i, 2] == MasodikJatekosJelei.O.ToString() && matrix[i, 3] ==
                    MasodikJatekosJelei.O.ToString() && matrix[i, 4] == MasodikJatekosJelei.O.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == MasodikJatekosJelei.O.ToString() && matrix[i, 1]
                    == MasodikJatekosJelei.P.ToString() && matrix[i, 2] == MasodikJatekosJelei.O.ToString() && matrix[i, 3] ==
                    MasodikJatekosJelei.O.ToString() && matrix[i, 4] == MasodikJatekosJelei.O.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == MasodikJatekosJelei.O.ToString() && matrix[i, 1]
                    == MasodikJatekosJelei.O.ToString() && matrix[i, 2] == MasodikJatekosJelei.P.ToString() && matrix[i, 3] ==
                    MasodikJatekosJelei.O.ToString() && matrix[i, 4] == MasodikJatekosJelei.O.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == MasodikJatekosJelei.O.ToString() && matrix[i, 1]
                    == MasodikJatekosJelei.O.ToString() && matrix[i, 2] == MasodikJatekosJelei.O.ToString() && matrix[i, 3] ==
                    MasodikJatekosJelei.P.ToString() && matrix[i, 4] == MasodikJatekosJelei.O.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == MasodikJatekosJelei.O.ToString() && matrix[i, 1]
                    == MasodikJatekosJelei.O.ToString() && matrix[i, 2] == MasodikJatekosJelei.O.ToString() && matrix[i, 3] ==
                    MasodikJatekosJelei.O.ToString() && matrix[i, 4] == MasodikJatekosJelei.P.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == MasodikJatekosJelei.O.ToString() && matrix[i, 1]
                    == MasodikJatekosJelei.P.ToString() && matrix[i, 2] == MasodikJatekosJelei.P.ToString() && matrix[i, 3] ==
                    MasodikJatekosJelei.P.ToString() && matrix[i, 4] == MasodikJatekosJelei.P.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == MasodikJatekosJelei.P.ToString() && matrix[i, 1]
                    == MasodikJatekosJelei.O.ToString() && matrix[i, 2] == MasodikJatekosJelei.P.ToString() && matrix[i, 3] ==
                    MasodikJatekosJelei.P.ToString() && matrix[i, 4] == MasodikJatekosJelei.P.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == MasodikJatekosJelei.P.ToString() && matrix[i, 1]
                    == MasodikJatekosJelei.P.ToString() && matrix[i, 2] == MasodikJatekosJelei.O.ToString() && matrix[i, 3] ==
                    MasodikJatekosJelei.P.ToString() && matrix[i, 4] == MasodikJatekosJelei.P.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == MasodikJatekosJelei.P.ToString() && matrix[i, 1]
                    == MasodikJatekosJelei.P.ToString() && matrix[i, 2] == MasodikJatekosJelei.P.ToString() && matrix[i, 3] ==
                    MasodikJatekosJelei.O.ToString() && matrix[i, 4] == MasodikJatekosJelei.P.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (matrix[i, 0] != null && matrix[i, 0] == MasodikJatekosJelei.P.ToString() && matrix[i, 1]
                    == MasodikJatekosJelei.P.ToString() && matrix[i, 2] == MasodikJatekosJelei.P.ToString() && matrix[i, 3] ==
                    MasodikJatekosJelei.P.ToString() && matrix[i, 4] == MasodikJatekosJelei.O.ToString())
                {
                    return matrix[i, 0];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == null)
                    {
                        return null;
                    }
                }
            }

            return "Döntetlen!";
        }

        public int heurisztika()
        {
            int suly = 0;

            if(celFeltetel() == jatekos)
            {
                return 100;
            }

            if(celFeltetel() == "X" || celFeltetel() == "O")
            {
                if(celFeltetel() != jatekos)
                {
                    return 50;
                }
            }else if(celFeltetel() == "X" || celFeltetel() == "P")
            {
                if (celFeltetel() != jatekos)
                    return 50;
            }else if(celFeltetel() == "Y" || celFeltetel() == "O")
            {
                if (celFeltetel() != jatekos)
                    return 50;
            }else if(celFeltetel() == "Y" || celFeltetel() == "P")
            {
                if (celFeltetel() != jatekos)
                    return 50;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == jatekos)
                    {
                        if (j + 1 < 5 && matrix[i, j + 1] == jatekos)
                        {
                            suly += 2;
                        }

                        if (i + 1 < 5 && matrix[i + 1, j] == jatekos)
                        {
                            suly += 2;
                        }

                        if (i + 1 < 5 && j + 1 < 3 && matrix[i + 1, j + 1] == jatekos)
                        {
                            suly += 2;
                        }

                        if (i + 1 < 5 && j - 1 >= 0 && matrix[i + 1, j - 1] == jatekos)
                        {
                            suly += 2;
                        }
                    }
                }
            }


            return suly;
        }
    }
}

using MI_Jatekok_2._7.Allapotter;
using MI_Jatekok_2._7.Keresok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MI_Jatekok_2._7
{
    public partial class Form1 : Form
    {
        Allapot allapot;
        Mezo[,] palya = new Mezo[5, 5];
        public Form1()
        {
            InitializeComponent();

            allapot = new Allapot();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Mezo mezo = new Mezo(i, j);
                    mezo.Location = new Point(j * 100, i * 100);
                    Controls.Add(mezo);
                    mezo.Click += new EventHandler(mezo_Kattintas);
                    palya[i, j] = mezo;
                }
            }
        }

        private void vizsgalCelfeltetel(Allapot allapot)
        {
            if (allapot.celFeltetel() != null)
            {
                if (allapot.celFeltetel() == "Döntetlen!")
                {
                    System.Windows.Forms.MessageBox.Show(allapot.celFeltetel());
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Vesztes játékos: " + allapot.celFeltetel());
                }
                this.Close();
            }
        }

        private void kirajzol(Mezo mezo, Allapot allapot)
        {
            if (allapot.Jatekos == ElsoJatekosJelei.X.ToString())
            {
                mezo.Text = allapot.Jatekos;
                mezo.ForeColor = Color.Red;
            }
            else if(allapot.Jatekos == MasodikJatekosJelei.O.ToString())
            {
                mezo.Text = "O";
                mezo.ForeColor = Color.Blue;
            }else if(allapot.Jatekos == ElsoJatekosJelei.Y.ToString())
            {
                mezo.Text = allapot.Jatekos;
                mezo.ForeColor = Color.Red;
            }else if(allapot.Jatekos == MasodikJatekosJelei.P.ToString())
            {
                mezo.Text = "P";
                mezo.ForeColor = Color.Blue;
            }
        }
        protected void mezo_Kattintas(object sender, EventArgs e)
        {
            Mezo mezo = sender as Mezo;
            Point koordinata = mezo.Koordinata;

            Operator op = new Operator(koordinata);
            if (op.eloFeltetel(allapot))
            {
                kirajzol(mezo, allapot);

                allapot = op.letesz(allapot);

                vizsgalCelfeltetel(allapot);

                Negamax negamax = new Negamax();
                List<Operator> ajanlottOperatorok = negamax.ajanl(allapot);

                Operator op2 = ajanlottOperatorok[0];
                Mezo mezo2 = palya[op2.Koordinata.X, op2.Koordinata.Y];

                kirajzol(mezo2, allapot);

                allapot = op2.letesz(allapot);

                vizsgalCelfeltetel(allapot);

            }
        }
    }
}

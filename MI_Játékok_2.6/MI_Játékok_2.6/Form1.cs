using MI_Játékok_2._6.Allapotter;
using MI_Játékok_2._6.Keresok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MI_Játékok_2._6
{
    public partial class Form1 : Form
    {
        Allapot allapot;
        Mezo[,] palya = new Mezo[4, 4];
        public Form1()
        {
            InitializeComponent();

            allapot = new Allapot();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Mezo mezo = new Mezo(i, j);
                    mezo.Location = new Point(j * 100, i * 100);
                    Controls.Add(mezo);
                    mezo.Click += new EventHandler(mezo_Kattintas);
                    palya[i, j] = mezo;
                }
            }
        }

        private void mezo_Kattintas(object sender, EventArgs e)
        {
            Mezo mezo = sender as Mezo;
            Point koordinata = mezo.Koordinata;

            Operator op = new Operator(koordinata);
            if (op.eloFeltetel(allapot))
            {
                kirajzol(mezo, allapot);

                allapot = op.felvesz(allapot);

                vizsgalCelfeltetel(allapot);

                Negamax negamax = new Negamax();
                List<Operator> ajanlottOperatorok = negamax.ajanl(allapot);

                Operator op2 = ajanlottOperatorok[0];
                Mezo mezo2 = palya[op2.Koordinata.X, op2.Koordinata.Y];

                kirajzol(mezo2, allapot);

                allapot = op2.felvesz(allapot);

                vizsgalCelfeltetel(allapot);

            }
        }

        private void vizsgalCelfeltetel(Allapot allapot)
        {
            if (allapot.celFeltetel() != null)
            {
                if (allapot.celFeltetel() == "Az első játékos vesztett!")
                {
                    System.Windows.Forms.MessageBox.Show(allapot.celFeltetel());
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(allapot.celFeltetel());
                }
                this.Close();
            }
        }

        private void kirajzol(Mezo mezo, Allapot allapot)
        {
            if (allapot.Jatekos == true && mezo.Text == ".")
            {
                mezo.Text = null;
                mezo.ForeColor = Color.Red;
            }
            if(allapot.Jatekos == false && mezo.Text == ".")
            {
                mezo.Text = null;
                mezo.ForeColor = Color.Blue;
            }
        }
    }
}

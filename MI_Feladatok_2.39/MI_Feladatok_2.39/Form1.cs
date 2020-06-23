using MI_Feladatok_2._39.Allapotter;
using MI_Feladatok_2._39.Keresok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MI_Feladatok_2._39
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        List<Allapot> megoldas = new List<Allapot>();
        int aktualisHely = 0;
        List<Kereso> keresok = new List<Kereso>();
        public Form1()
        {
            InitializeComponent();
            keresok.Add(new HibaProbaRandom());
            keresok.Add(new Aalgoritmus());
            keresok.Add(new AgEsKorlat());
            keresok.Add(new BackTrack());
            keresok.Add(new BestFirst());
            keresok.Add(new Melysegi());
            keresok.Add(new Optimalis());
            keresok.Add(new Szelessegi());
            foreach(Kereso kereso in keresok)
            {
                comboBox1.Items.Add(kereso.GetType().Name);
            }
            megoldas = keresok[0].Utvonal;
            this.comboBox1.SelectedIndex = 0;
        }

        private void Kirajzol()
        {
            Bitmap image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = image;
            graphics = Graphics.FromImage(image);

            for (int i = 0; i < Allapot.oszlopok.Length; i++)
            {
                graphics.FillRectangle(new SolidBrush(Color.Gray), new Rectangle(i * 150 + 40, 60, 20, 200));
            }

            string[] korongok1 = megoldas[aktualisHely].Korong1;
            string[] korongok2 = megoldas[aktualisHely].Korong2;

            for (int i = 0; i < korongok1.Length; i+=2)
            {
                int oszlopSzam = 0;
                if (korongok1[i] == "R")
                {
                    oszlopSzam = 2;
                }
                else if (korongok1[i] == "Q")
                {
                    oszlopSzam = 1;
                }

                int pozicio = 0;
                for (int j = i + 2; j < korongok1.Length; j++)
                {
                    if (korongok1[j] == korongok1[i]) pozicio++;
                }
                graphics.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(30+ oszlopSzam  * 1 - i * 1, 250 -pozicio* 10, 30 + i * 10, 10));
            }
            for (int i = 1; i < korongok1.Length; i += 2)
            {
                int oszlopSzam = 0;
                if (korongok1[i] == "R")
                {
                    oszlopSzam = 2;
                }
                else if (korongok1[i] == "P")
                {
                    oszlopSzam = 0;
                }

                int pozicio = 0;
                for (int j = i + 2; j < korongok1.Length; j++)
                {
                    if (korongok1[j] == korongok1[i]) pozicio++;
                }
                graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(30 + oszlopSzam * 1 - i * 1, 250 -pozicio* 10, 30 + i * 10, 10));
            }
            for (int i = 0; i < korongok2.Length; i += 2)
            {
                int oszlopSzam = 0;
                if (korongok2[i] == "R")
                {
                    oszlopSzam = 2;
                }
                else if (korongok2[i] == "P")
                {
                    oszlopSzam = 0;
                }

                int pozicio = 0;
                for (int j = i + 2; j < korongok2.Length; j++)
                {
                    if (korongok2[j] == korongok2[i]) pozicio++;
                }

                graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(30 + oszlopSzam* 1 - i * 1, 250 -pozicio* 10, 30 + i * 10, 10));
            }
            for (int i = 1; i < korongok2.Length; i += 2)
            {
                int oszlopSzam = 0;
                if (korongok2[i] == "R")
                {
                    oszlopSzam = 2;
                }
                else if (korongok2[i] == "Q")
                {
                    oszlopSzam = 1;
                }

                int pozicio = 0;
                for (int j = i + 2; j < korongok2.Length; j++)
                {
                    if (korongok2[j] == korongok2[i]) pozicio++;
                }

                graphics.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(30 + oszlopSzam * 1 - i * 1, 250 - pozicio * 10, 30 + i * 10, 10));
            }
            label1.Text = "Lépések (kezdő állapottal együtt): " + megoldas.Count();
            pictureBox1.Refresh();
        }

        private void pictureBox1_paint(object sender, PaintEventArgs e)
        {
            Kirajzol();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (aktualisHely > 0)
            {
                aktualisHely--;

            }
            Kirajzol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (aktualisHely + 1 < megoldas.Count)
            {
                aktualisHely++;

            }
            Kirajzol();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            megoldas = keresok[comboBox1.SelectedIndex].Utvonal;
            aktualisHely = 0;
            Kirajzol();
        }
    }
}

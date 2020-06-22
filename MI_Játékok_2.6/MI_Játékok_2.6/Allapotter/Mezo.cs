using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MI_Játékok_2._6.Allapotter
{
    class Mezo : Button
    {
        public Mezo(int x, int y)
        {
            koordinata = new Point(x, y);
            this.Size = new Size(100, 100);
            this.BackColor = Color.White;
            this.Font = new Font(this.Font.FontFamily, 30, FontStyle.Bold);
            this.Text = ".";
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
    }
}

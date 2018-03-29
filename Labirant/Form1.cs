using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Point p1 = new Point(34, 28);
            farePic.Location=p1;
            asagı1.Start();
            asagı1.Interval = 10;
            yukarı1.Interval = 10;
            saga1.Interval = 10;
            yukarı2.Interval = 10;
            saga2.Interval = 10;
            yukarı3.Interval = 10;
            sola1.Interval = 10;
            saga3.Interval = 10;
            asag2.Interval = 10;
            sola2.Interval = 10;
            asag3.Interval = 10;
            sag4.Interval = 10;
            yukarı4.Interval = 10;
            sag5.Interval = 10;
            asag4.Interval = 10;
            sag6.Interval = 10;
            yukarı5.Interval = 10;
            sola3.Interval = 10;
            asag5.Interval = 10;
            sag7.Interval = 10;
            asag6.Interval = 10;
            sag8.Interval = 10;
            asag7.Interval = 10;
        }
       
        private void asagı1_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X, farePic.Location.Y + 3);

            if(farePic.Location.Y>470)
            {
                asagı1.Stop();
                yukarı1.Start();
            }
        }

        private void yukarı1_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X, farePic.Location.Y - 3);

            if(farePic.Location.Y<215)
            {
                yukarı1.Stop();
                saga1.Start();
            }
        }

        private void saga1_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X+3, farePic.Location.Y);
            if(farePic.Location.X>123)
            {
                saga1.Stop();
                yukarı2.Start();

            }
        }

        private void yukarı2_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X, farePic.Location.Y-3);
            if(farePic.Location.Y<125)
            {
                yukarı2.Stop();
                saga2.Start();

            }

        }

        private void saga2_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X+3, farePic.Location.Y );
            if(farePic.Location.X>238)
            {
                saga2.Stop();
                yukarı3.Start();
            }
        }

        private void yukarı3_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X, farePic.Location.Y-3);

            if(farePic.Location.Y<50)
            {
                yukarı3.Stop();
                sola1.Start();
            }
        }

        private void sola1_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X - 3, farePic.Location.Y);
            if (farePic.Location.X < 103)
            {
                sola1.Stop();
                saga3.Start();
            }
        }

        private void saga3_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X +3, farePic.Location.Y);
            if (farePic.Location.X > 239)
            {
                saga3.Stop();
                asag2.Start();

            }
        }

        private void asag2_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X , farePic.Location.Y+3);
            if (farePic.Location.Y > 145)
            {
                asag2.Stop();
                sola2.Start();
            }
        }

        private void sola2_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X - 3, farePic.Location.Y);
            if (farePic.Location.X < 100)
            {
                sola2.Stop();
                asag3.Start();
            }
        }

        private void asag3_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X , farePic.Location.Y+3);
            if (farePic.Location.Y >380)
            {
                asag3.Stop();
                sag4.Start();
            }
        }

        private void sag4_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X +3, farePic.Location.Y);
            if (farePic.Location.X > 312)
            {
                sag4.Stop();
                yukarı4.Start();
            }
        }

        private void yukarı4_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X , farePic.Location.Y-3);
            if (farePic.Location.Y < 299)
            {
                yukarı4.Stop();
                sag5.Start();
            }
        }

        private void sag5_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X + 3, farePic.Location.Y);
            if (farePic.Location.X > 400)
            {
                sag5.Stop();
                asag4.Start();
                    
            }
        }

        private void asag4_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X , farePic.Location.Y+3);
            if (farePic.Location.Y > 405)
            {
                asag4.Stop();
                sag6.Start();
                    
                    
            }
        }

        private void sag6_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X + 3, farePic.Location.Y);
            if (farePic.Location.X > 525)
            {
                sag6.Stop();
                yukarı5.Start();
                    
            }
        }

        private void yukarı5_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X , farePic.Location.Y-3);
            if (farePic.Location.Y< 39)
            {
                yukarı5.Stop();
                sola3.Start();

            }
        }

        private void sola3_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X - 3, farePic.Location.Y);
            if (farePic.Location.X < 308)
            {
                sola3.Stop();
                asag5.Start();
            }
        }

        private void asag5_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X, farePic.Location.Y+3);
            if (farePic.Location.Y > 190)
            {
                asag5.Stop();
                sag7.Start();
                    
            }
        }

        private void sag7_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X + 3, farePic.Location.Y);
            if (farePic.Location.X > 520)
            {
                sag7.Stop();
                asag6.Start();
            }
        }

        private void asag6_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X , farePic.Location.Y+3);
            if (farePic.Location.Y > 363)
            {
                asag6.Stop();
                sag8.Start();
            }
        }

        private void sag8_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X +3, farePic.Location.Y);
            if (farePic.Location.X > 604)
            {
                sag8.Stop();
                asag7.Start();
            }
        }

        private void asag7_Tick(object sender, EventArgs e)
        {
            farePic.Location = new Point(farePic.Location.X, farePic.Location.Y+3);
            if (farePic.Location.Y > 433)
            {
                asag7.Stop();
                pbPeynir.Visible = false;
                MessageBox.Show("Karnım Doymadı....");
            }
        }
    }
}

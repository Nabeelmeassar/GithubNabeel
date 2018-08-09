using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

using System.Windows.Forms;

namespace Schlange
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }



        private int directionX = 1; // 1 = nach rechts, -1 = nach links
        private int directionY = 1; // 1 = nach unten, -1 = nach oben

   
       

       
        

            int y = 0;
            int x = 0;

        private void btnStart_Click_1(object sender, EventArgs e)
        { 
            try
            {
                while (true)
                {

                    System.Threading.Thread.Sleep(100);
                    x = 299;

                    if (y >= 400) // Ball ist unten
                    {
                        directionY = -1; // Ball soll nach oben
                    }
                    if (y <= 0)
                    {
                        directionY = 1;
                    }

                    if (x <= 0)
                    {
                        directionX = 1;
                    }
                    if (x >= 600)
                    {
                        directionX = -1;
                    }
                    if (directionX == 1)
                        x += 10;
                    if (directionX == -1)
                        x -= 5;
                    if (directionY == 1)
                        y += 5;
                    if (directionY == -1)


                        ball1.Location = new Point(x, y);

                    panel1.Update();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Fehler !!");
            }
        }

    }

}


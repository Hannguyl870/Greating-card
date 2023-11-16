//hannah guylee
//nov 15,2023
// greeting card
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;
using System.Windows.Forms;


namespace Greating_card
{
    public partial class Form1 : Form
    {
        SoundPlayer sp;
        Pen darkturquoisepen = new Pen(Color.DarkTurquoise, 5);
        Pen greenpen = new Pen(Color.Green, 5);
        Pen blackpen = new Pen(Color.Black);
        Pen turquoisepen = new Pen(Color.Turquoise, 5);
        Pen Whitepen = new Pen(Color.White, 5);
        Pen deepskybluepen = new Pen(Color.DeepSkyBlue, 5);
        Pen orangepen = new Pen(Color.Orange);
        Pen redpen = new Pen(Color.Red);


        SolidBrush blackbrush = new SolidBrush(Color.Black);
        SolidBrush redbrush = new SolidBrush(Color.Red);
        SolidBrush greenbrush = new SolidBrush(Color.Green);
        SolidBrush whitebrush = new SolidBrush(Color.White);
        SolidBrush turquoisebrush = new SolidBrush(Color.Turquoise);
        SolidBrush deepskybluebrush = new SolidBrush(Color.DeepSkyBlue);
        SolidBrush orangebrush = new SolidBrush(Color.Orange); 
        int i = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
            Graphics g = this.CreateGraphics();
            g.Clear(Color.LightBlue);

            //snowflake 1
            g.DrawLine(Whitepen, 40, 40, 100, 100);
            g.DrawLine(Whitepen, 40, 100, 100, 40);
            g.DrawLine(Whitepen, 70, 30, 70, 110);
            g.DrawLine(Whitepen, 30, 70, 110, 70);

            //snowflake 2
            g.DrawLine(Whitepen, 200, 200, 250, 250);
            g.DrawLine(Whitepen, 200, 250, 250, 200);
            g.DrawLine(Whitepen, 225, 190, 225, 260);
            g.DrawLine(Whitepen, 190, 225, 260, 225);

            //snowflake 3
            g.DrawLine(Whitepen, 310, 30, 360, 80);
            g.DrawLine(Whitepen, 310, 80,360 , 30);
            g.DrawLine(Whitepen, 335, 20, 335, 90);
            g.DrawLine(Whitepen, 300, 55, 370, 55);


            Font drawFont = new Font("minstral", 20, FontStyle.Bold);
            g.DrawString("IT'S WINTER \n TIME", drawFont,deepskybluebrush , 100, 100);


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            sp = new SoundPlayer(Properties.Resources._369473__ylearkisto__enkelikello_kilina_angel_chimes_jingling);
            sp.Play();
            Graphics g = this.CreateGraphics();
            g.Clear(Color.LightBlue);

            Font drawFont = new Font("flame", 20, FontStyle.Bold);
            g.DrawString("LET'S BUILD A \n SNOWMAN", drawFont, deepskybluebrush, 100, 100);

            ///snowman 
            g.DrawEllipse(Whitepen, 25, 200, 100, 100);
            g.DrawEllipse(Whitepen, 25, 127, 75, 75);
            g.DrawEllipse(Whitepen, 25, 77, 50, 50);
            g.FillEllipse(whitebrush, 25, 200, 100, 100);
            g.FillEllipse(whitebrush, 25, 127, 75, 75);
            g.FillEllipse(whitebrush, 25, 77, 50, 50);

            g.DrawPie(orangepen, 50, 100, 50, 50, 210, 30);
            g.FillPie(orangebrush, 50, 100, 50,50,210,30);

            g.DrawEllipse(blackpen, 55, 95 , 5, 5);
            g.DrawEllipse(blackpen, 44, 100, 5, 5);
            g.FillEllipse(blackbrush, 55, 95, 5, 5);
            g.FillEllipse(blackbrush, 44, 100, 5, 5);

            g.DrawPie(redpen, -25, 6, 90, 90, 30, 60);
            g.FillPie(redbrush,-25, 6, 90, 90, 30, 60);
            g.FillEllipse(blackbrush, 10,45, 20, 20);

            g.FillEllipse(blackbrush, 85, 210, 10, 10);
            g.FillEllipse(blackbrush, 75, 170, 10, 10);
            g.FillEllipse(blackbrush, 70, 140, 10, 10);



            int colourValue = 0;

            for (int i= 0; i<=10;i++ )
            {
                colourValue += 20;

                Whitepen = new Pen(Color.FromArgb(colourValue, 255, 255, 255),5);

                g.DrawEllipse(Whitepen, 300, 30, 5, 5);
                g.DrawEllipse(Whitepen, 100, 60, 5, 5);
                g.DrawEllipse(Whitepen, 60, 40, 5, 5);
                g.DrawEllipse(Whitepen, 350, 40, 5, 5);
                g.DrawEllipse(Whitepen, 150, 95, 5, 5);
                g.DrawEllipse(Whitepen, 130, 95, 5, 5);
                g.DrawEllipse(Whitepen, 200, 80, 5, 5);
                g.DrawEllipse(Whitepen, 250, 120, 5, 5);
                g.DrawEllipse(Whitepen, 100, 150, 5, 5);
                g.DrawEllipse(Whitepen, 300, 200, 5, 5);
                g.DrawEllipse(Whitepen, 200, 200, 5, 5);
                g.DrawEllipse(Whitepen, 100, 120, 5, 5);
                g.DrawEllipse(Whitepen, 300, 95, 5, 5);
                g.DrawEllipse(Whitepen, 100, 300, 5, 5);
                g.DrawEllipse(Whitepen, 55, 310, 5, 5);
                g.DrawEllipse(Whitepen, 160, 260, 5, 5);
                g.DrawEllipse(Whitepen, 300, 300, 5, 5);
                g.DrawEllipse(Whitepen, 200, 300, 5, 5);

                Thread.Sleep(200);

            }

        }

    }
    
   
}

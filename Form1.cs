using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greating_card
{
    public partial class Form1 : Form
    {
        Pen darkturquoisepen = new Pen(Color.DarkTurquoise, 5);
        Pen greenpen = new Pen(Color.Green, 5);
        Pen blackpen = new Pen(Color.Black, 5);
        Pen turquoisepen = new Pen(Color.Turquoise, 5);
        Pen Whitepen = new Pen(Color.White, 5);
        Pen deepskybluepen = new Pen(Color.DeepSkyBlue, 5);

        SolidBrush blackbrush = new SolidBrush(Color.Black);
        SolidBrush redbrush = new SolidBrush(Color.Red);
        SolidBrush greenbrush = new SolidBrush(Color.Green);
        SolidBrush whitebrush = new SolidBrush(Color.White);
        SolidBrush turquoisebrush = new SolidBrush(Color.Turquoise);
        SolidBrush deepskybluebrush = new SolidBrush(Color.DeepSkyBlue);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
            Graphics g = this.CreateGraphics();
            g.Clear(Color.LightBlue);

            g.DrawLine(Whitepen, 40, 40, 100, 100);
            g.DrawLine(Whitepen, 40, 100, 100, 40);

           
            Font drawFont = new Font("flame", 20, FontStyle.Bold);
            g.DrawString("IT'S WINTER \n TIME", drawFont,deepskybluebrush , 100, 100);


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.LightBlue);

            Font drawFont = new Font("flame", 20, FontStyle.Bold);
            g.DrawString("LET'S BUILD A \n SNOWMAN", drawFont, deepskybluebrush, 100, 100);

            g.DrawEllipse(Whitepen, 25, 200, 100, 100);

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        int speedY = 5;
        int speedX = 5;
        int speedBall = 1;
        int point = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) { 

            if(panelBall.Top >= panelArea.Height - panelBall.Height) 
            {
                speedY = speedY * -1;
            }

            if (panelBall.Left >= panelArea.Width - panelBall.Width)
            {
                speedBall++;
                speedX = speedX +4;
                speedY = speedY +4;
                speedX = speedX * -1;
                label2.Text = Convert.ToString(speedBall);
            }

            if (panelBall.Top <= 0)
            {
                speedY = speedY * -1;
            }

            if (panelBall.Left <= 0)
            {
                speedX = speedX * -1;
                point++;
                label4.Text = Convert.ToString(point);
            }

            panelBall.Top = panelBall.Top + speedY;
            panelBall.Left = panelBall.Left + speedX;

            if (Cursor.Position.Y - this.Top - 125 >= 0 && Cursor.Position.Y - this.Top - 26 <= panelArea.Height)
            {
                panelPlayer1.Top = Cursor.Position.Y - this.Top - 125;
            }

            panelPlayer2.Top = panelBall.Top;

            if (panelBall.Left < panelPlayer1.Left && (panelBall.Top < panelPlayer1.Top - panelBall.Height || panelBall.Top > panelPlayer1.Top + panelPlayer1.Height))
            {
                timer1.Enabled = false;
                MessageBox.Show("Game over");
            }

              
        
        }
    }
}

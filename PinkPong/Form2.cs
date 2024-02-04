using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinkPong
{
    public partial class Form2 : Form
    {
        int player1 = 0;
        int player2 = 0;

        int movex=16;
    int movey = 16;
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.D4)
            {
                pictureBox1.Top -= 5;
            }
            if (e.KeyCode == Keys.B)
            {
                pictureBox1.Top += 5;
            }
            if (e.KeyCode == Keys.A)
            {
                pictureBox2.Top -= 5;
            }
            if (e.KeyCode == Keys.C)
            {
                pictureBox2.Top += 5;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();                       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Visible = false;


            pictureBox3.Left += movex;
            pictureBox3.Top += movey;


            if (pictureBox3.Location.Y >= 402)
            {
                movey = -movey;
            }
            if (pictureBox3.Location.X >= 584)
            {
                movex = -movex;
                player1++;
                label2.Text = player1.ToString();
            }
            if (pictureBox3.Location.Y <= 0)
            {
                movey = -movey;
               
            }
            if (pictureBox3.Location.X <= 0)

            {
                movex = -movex;
                player2++;
                label3.Text= player2.ToString();
            }
           if(pictureBox3.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                movex= -movex;
                panel1.Visible = true;
                timer1.Stop();
            }
            if (pictureBox3.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                movex = -movex;
                panel1.Visible = true;
                timer1.Stop();  
            }
        }




        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
            pictureBox3.Location = new Point(246, 173);

            timer1.Start(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

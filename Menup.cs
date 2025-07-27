using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinAssurance
{
    public partial class Menup : Form
    {
        public Menup()
        {
            InitializeComponent();
        }

        private void Menup_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label2.Left < 572)
            {
                label2.Left += 10;
            }
            else
            {
                label2.Left = 1;
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Green;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.CornflowerBlue;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = System.Drawing.Color.Green;

        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = System.Drawing.Color.Green;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = System.Drawing.Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.CornflowerBlue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.Color.CornflowerBlue;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = System.Drawing.Color.CornflowerBlue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            

            if (MessageBox.Show("Êtes-vous Sûr de quitter?", "Sortie...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                button4.Cursor = System.Windows.Forms.Cursors.AppStarting;
                do
                {
                    System.Threading.Thread.Sleep(1000);

                    i++;
                }
                while (i < 5);

                Form1 frm = new Form1();
                frm.Fermeture();
                frm.Visible = true;
                
                this.Dispose();
              
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_client client = new frm_client();
            this.Visible = false;
            client.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Assurance ass = new Frm_Assurance();

            this.Visible = false;
            ass.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_plainte plaint = new frm_plainte();

            this.Visible = false;
            plaint.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_view_client vclient = new frm_view_client();
            this.Visible = false;
            vclient.Visible = true;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.BackColor = System.Drawing.Color.Green;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = System.Drawing.Color.CornflowerBlue;
        }

       
    }
}

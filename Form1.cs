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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menup mp = new Menup();
        
            this.Visible = false;
            mp.Visible = true;

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
          
           
           
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            timer1.Enabled = false;
        }
        public void Fermeture()
        {
            this.button2.Visible = true; // Rend le button de sortie visible
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

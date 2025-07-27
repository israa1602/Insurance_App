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
    public partial class frm_view_client : Form
    {
        AssuranceDataContext hornel = new AssuranceDataContext();

        public frm_view_client()
        {
           

            InitializeComponent();
        }

        private void frm_view_client_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reqs = from ds in hornel.Client
                       select ds;


            dg.DataSource = reqs;
            
        }

        private void txtrech_TextChanged(object sender, EventArgs e)
        {
            if (txtrech.Text == "")
            {
                dg.ClearSelection();
            }

            var req = from ds in hornel.Client
                      where ds.Numcli.StartsWith(txtrech.Text)
                      select ds;




            

          
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menup mp = new Menup();
            
            this.Visible = false;
            mp.Visible = true;
        }

       
    }
}

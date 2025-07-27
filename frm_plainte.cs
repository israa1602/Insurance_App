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
    public partial class frm_plainte : Form
    {
        AssuranceDataContext hornel = new AssuranceDataContext();
        static int i = 0;

        public frm_plainte()
        {
            InitializeComponent();
        }
        private void frm_plainte_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 32; i++)
            {
                cbojrs.Items.Add(i);
            }

            for (int j = 1; j < 13; j++)
            {
                cboms.Items.Add(j);
            }

            for (int k = 2000; k < (DateTime.Now.Year + 1); k++)
            {
                cboan.Items.Add(k);
            }

        }

        private void cbocateg_DropDown(object sender, EventArgs e)
        {
            var req = from ds in hornel.Categorie_Plainte
                      select ds;


            cbocateg.Items.Clear();

            foreach (var lama in req)
            {
                cbocateg.Items.Add(lama.LibCategPl);
            }
        }

        private void cboclient_DropDown(object sender, EventArgs e)
        {
            var req = from ds in hornel.Client
                      select ds;


            cboclient.Items.Clear();

            foreach (var lama in req)
            {
                cboclient.Items.Add(lama.Numcli);
            }
        }

        private void btnenreg_Click(object sender, EventArgs e)
        {
            string codecateg = ""; // la variable qui aura la valeur du code de la Categorie de la Plainte

            var req = from ds in hornel.Categorie_Plainte
                      where ds.LibCategPl.StartsWith(cbocateg.Text) //On fait une recherche Par Rapport au contenu du cbocateg
                      select ds;


            foreach (var lama in req)
            {
                codecateg = lama.CodeCategpl.ToString();
   
             }
            

           
            Plainte pl = new Plainte();


            pl.Codepl = txtnumpl.Text;
            pl.Jrpl = cbojrs.Text;
            pl.Mspl = cboms.Text;
            pl.Anpl = cboan.Text;
            pl.codecategPl = codecateg; // on affecte la valeur du code de la Plainte,dans la propriété de la Table Plainte(pour respecter La contrainte D'intégrité)

            hornel.Plainte.InsertOnSubmit(pl);
            hornel.SubmitChanges();

            MessageBox.Show("Enregistrement Reussi !", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

     
        private void cbocateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menup mp = new Menup();
            this.Dispose();
            mp.Visible = true;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (txtnumpl.Text == "")
            {
                MessageBox.Show("Inserer une le code d'assurance", "Recherche");
                return;
            }
            i++;
            string codecateg = "";

            //Pour le Respect de la conrainte D'Intégrité,on Cherche d'abord le code de la categorie
            var reqs = from ds in hornel.Categorie_Plainte
                       where ds.LibCategPl == cbocateg.Text
                       select ds;

            foreach (var hlama in reqs)
            {
                codecateg = hlama.CodeCategpl; // on affecte le code categorie à la Variable(codecateg)
            }

            //Ici l'on fait une mise à jour(Modification)

            var req = from ds in hornel.Plainte
                      where ds.Codepl == txtnumpl.Text
                      select ds;

            foreach (var lama in req)
            {
                lama.Codepl = txtnumpl.Text;
                lama.Jrpl = cbojrs.Text;
                lama.Mspl = cboms.Text;
                lama.Anpl = cboan.Text;
                lama.codecategPl = codecateg; //On affecte au champs 'codecategpl'  de la Table par la variable codecateg
            }
            hornel.SubmitChanges(); 
            MessageBox.Show("Modifcation éffectuée !", "Modification des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtnumpl_TextChanged(object sender, EventArgs e)
        {
            string code = ""; // variable devant contenir le code de la Categorie de la plainte

            if (txtnumpl.Text != "") // si le textbox n'est pas vide,alors on éffectue une recherche
            {
                var req = from ds in hornel.Plainte
                          where ds.Codepl == txtnumpl.Text
                          select ds;


                foreach (var lama in req)
                {
                    txtnumpl.Text = lama.Codepl;
                    cbojrs.Text = lama.Jrpl;
                    cboms.Text = lama.Mspl;
                    cboan.Text = lama.Anpl;
                    code = lama.codecategPl; //on affecte à la variable code par la donnée trouvée
                }
            }

            //Apres,l'on fait une recherche par rapport au contenu du code(variable Créée)

            var reqs = from ds in hornel.Categorie_Plainte
                       where ds.CodeCategpl == code //Recherche par rapport au code
                       select ds;

            foreach (var hlama in reqs)
            {
                cbocateg.Text = hlama.LibCategPl; //on affecte cette donnée trouvée au combobox(cbocateg)
            }

        }

        private void Btn_Enreg_Click(object sender, EventArgs e)
        {

            if (txtnumpl.Text != "")
            {
                Presentation_Pliante present = new Presentation_Pliante();

                present.CodePres = txtnumpres.Text;
                present.NumCli = cboclient.Text;
                present.LibPres = RtxtMsg.Text;
                present.Codepl =Convert.ToString(txtnumpl.Text );
                hornel.Presentation_Pliante.InsertOnSubmit(present);
                hornel.SubmitChanges();
                MessageBox.Show("Données Enregistrée !", "Enregistrement");
            }
            else
            {
                MessageBox.Show("Le Numero de la Plainte est vide,veuillez remplir le champs...", "Erreur de Mise à Jour", MessageBoxButtons.OK, MessageBoxIcon.Stop); 
            }

        }

        private void Btn_Modif_Click(object sender, EventArgs e)
        {
            if (txtnumpres.Text != "")
            {
                var req = from ds in hornel.Presentation_Pliante
                          where ds.CodePres == txtnumpres.Text
                          select ds;


                foreach (var lama in req)
                {
                    lama.CodePres = txtnumpres.Text;
                    lama.NumCli = cboclient.Text;
                    lama.LibPres = RtxtMsg.Text;
                }
                hornel.SubmitChanges();
                MessageBox.Show("Données Modifiées !", "Modification des Données", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtnumpres_TextChanged(object sender, EventArgs e)
        {
            if (txtnumpres.Text != "")
            {
                var req = from ds in hornel.Presentation_Pliante
                          where ds.CodePres == txtnumpres.Text
                          select ds;


                foreach (var lama in req)
                {
                    txtnumpres.Text = lama.CodePres;
                    cboclient.Text = lama.NumCli;
                    RtxtMsg.Text = lama.LibPres;
                }
            }

        }
    }
}

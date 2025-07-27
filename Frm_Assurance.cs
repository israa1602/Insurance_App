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
    public partial class Frm_Assurance : Form
    {
        AssuranceDataContext hornel = new AssuranceDataContext(); //Le DataContext qui est la Source des Données
        public Frm_Assurance()
        {
            InitializeComponent();
        }

        private void Frm_Assurance_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 32; i++) //Charger les Jours
            {
                cbojrs.Items.Add(i);
            }

            for (int j = 1; j < 13; j++) //Charger Les Mois
            {
                cbomois.Items.Add(j);
            }

            for (int an = 1998; an < (DateTime.Now.Year + 1); an++) // Charger Les Années
            {
                cboan.Items.Add(an);
            }
        }

        private void btnEnreg_Click(object sender, EventArgs e)
        {
            Date_livraison dateLivr = new Date_livraison();
            Random rand = new Random();

            string code_genere="Ass" + Convert.ToString(rand.Next(20)); //Génère le code Aléatoirement

            //Les Affectations des Valeurs,Mise à jour pour la date de livraison

            dateLivr.CodeLivr =code_genere  ;
            dateLivr.Jrlivr = cbojrs.Text;
            dateLivr.MsLivr = cbomois.Text;
            dateLivr.AnLivr = cboan.Text;

            //Mettre à Jour(Enregistrer)

            hornel.Date_livraison.InsertOnSubmit(dateLivr);
            hornel.SubmitChanges();

            Assurance ass = new Assurance(); //Création d'Une Instance de la Classe Assurance(Objet)

            //Les Affectation des Valeurs

            ass.NumAss = txtnum.Text;
            ass.LibAss = txtlib.Text;
            ass.Numcli = cbocli.Text;
            ass.CodeLivr = code_genere;

            //Mise à Jour(Enregistrer)

            hornel.Assurance.InsertOnSubmit(ass);
            hornel.SubmitChanges();
            MessageBox.Show("Donnée Enregistrée !", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void cbocli_DropDown(object sender, EventArgs e)
        {
            // Chargement Dans Combox Pour Les Numero de Chaque Client

            var req = from ds in hornel.Client
                      select ds;


            cbocli.Items.Clear();

            foreach (var lama in req)
            {
                cbocli.Items.Add(lama.Numcli);
            }
        }

        private void txtrech_TextChanged(object sender, EventArgs e)
        {
            string codedate = ""; //la Variable qui doit contenir le code de la Date de livraison de l'Assurance

            //1.On cherche les inforamtions sur l'Assurance Par le Numero d'assurance

            var reque = from ds in hornel.Assurance
                      where ds.NumAss.StartsWith(txtrech.Text)
                      select ds;

            foreach (var lama in reque)
            {
                txtnum.Text = lama.NumAss;
                txtlib.Text = lama.LibAss;
                cbocli.Text = lama.Numcli;
                codedate = lama.CodeLivr; //On affecte à codedate le code de la livraison de l'assurance
            }

            //Recherche de la Date de la Livraison(Jour,Mois,Année),Par Rapport à la Nouvelle Valeur de Codedate

           var reqs = from ds in hornel.Date_livraison
                      where ds.CodeLivr == codedate //On cherche par rapport à codedate
                      select ds;

           
            
            
            foreach (var lama in reqs)
           {
                //On attribut ces valeurs aux controls(combox) par jour,mois,année

               cbojrs.Text = lama.Jrlivr;  
               cbomois.Text = lama.MsLivr;
               cboan.Text = lama.AnLivr;
           }


            //NOTA BENE:

            /* Dans cette Function(Procédure) on effectue 2 mouvement: On Enregistre dans la table 
             Assurance et en même temps dans La Table Date de Livraison,Pour Respecter la contrainte
             d'intégrité,on a Crée la variable "codedate" pour Prendre le code de la Date de livraison pcq celui
             qui est la clé de la contrainte,Puis faisons une seconde Recherche dans la Table Date de livraison grâce 
             au codedate......
             */

             
             
        }

        private void btnModif_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menup mp = new Menup();
            this.Dispose();
            mp.Visible = true;
        }
    }
}

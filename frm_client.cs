using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinAssurance
{
    public partial class frm_client : Form
    {
        AssuranceDataContext hornel = new AssuranceDataContext();
        public frm_client()
        {
            InitializeComponent();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            string code = ""; //La variable qui reçoit le Numero de Categorie de Vehile du client

            //La Requête pour Affichez les informations du Clients

            var req = from ds in hornel.Client
                      where ds.Numcli==txtrecherche.Text 
                      select ds;

            foreach (var lama in req)
            {
                txtnum.Text = lama.Numcli;
                txtnom.Text = lama.Nom;
                txtpostnom.Text = lama.Postnom;
                txtprenom.Text = lama.Prenom;
                cbosexe.Text = lama.Sexe.ToString();
                cbojrsnaiss.Text = lama.Jrnaiss;
                cbomoisnaiss.Text = lama.MsNaiss;
                cboanenaiss.Text = lama.AnNaiss;
                txtrue.Text = lama.Rue;
                txtnrue.Text = lama.NumRue;
                txtquartier.Text = lama.Quartier;
                txtcommune.Text = lama.Commune;
                cboville.Text = lama.Ville;
                txtnationalite.Text = lama.Nationalite;
                txttel.Text = lama.Tel;
                code = lama.CodeCateg;
            }
            //******************************************************************************


            //code pour chercher le numero de categorie de vehicule,puis l'affiche dans le comboBox(cbocategorie)

            var reqs = from ds in hornel.Categorie_client
                       where ds.CodeCateg == code
                       select ds;


            foreach (var hlama in reqs)
            {
                cbocategorie.Text = hlama.LibCateg; //La valeur Récuperée par Rapport à la variable code(trouvée)
            }

            //***************************************************************************


            //Si le Champs de recherche est vide....

            if (txtrecherche.Text == "")
            {
                txtnum.Text = "";
                txtnom.Text = "";
                txtpostnom.Text = "";
                txtprenom.Text = "";
                cbosexe.Text = "";
                cbojrsnaiss.Text = "";
                cbomoisnaiss.Text = "";
                cboanenaiss.Text = "";
                txtrue.Text = "";
                txtnrue.Text = "";
                txtquartier.Text = "";
                txtcommune.Text = "";
                cboville.Text = "";
                txtnationalite.Text = "";
                txttel.Text = "";
                cbocategorie.Text = "";

            }

        }

        private void btnEnreg_Click(object sender, EventArgs e)
        {
            string numcateg = ""; //Cette Variable Transforme,le Libellé Categorie En Code Categorie

            //Recherche Par Rapport Au Libllé Categorie

            var req = from ds in hornel.Categorie_client
                      where ds.LibCateg == cbocategorie.Text
                      select ds;

            foreach (var lama in req)
            {
                numcateg = lama.CodeCateg; //Affectation du champs.....
            }
            //****************************************

            if (MessageBox.Show("Voulez-vous Enregistrer Ces données?", "Enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Client cli = new Client(); //Créaton d'une Instance par rapport à la Table de la BDD


                //Affectation et Enregistrement des données


                cli.Numcli = txtnum.Text;
                cli.Nom = txtnom.Text;
                cli.Postnom = txtpostnom.Text;
                cli.Prenom = txtprenom.Text;
                cli.Sexe = Convert.ToChar(cbosexe.Text);
                cli.Jrnaiss = cbojrsnaiss.Text;
                cli.MsNaiss = cbomoisnaiss.Text;
                cli.AnNaiss = cboanenaiss.Text;
                cli.Rue = txtrue.Text;
                cli.NumRue = txtnrue.Text;
                cli.Quartier = txtquartier.Text;
                cli.Commune = txtcommune.Text;
                cli.Ville = cboville.Text;
                cli.Nationalite = txtnationalite.Text;
                cli.Tel = txttel.Text;
                cli.CodeCateg = numcateg;
                hornel.Client.InsertOnSubmit(cli);
                hornel.SubmitChanges();
                MessageBox.Show("Donnée Enregistrées avec Succès !", "Enregistrement Reussi !", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //Fin du code D'enregistrement......

            }
            else
            {
                MessageBox.Show("Aucune Données n'est enrégistrée...", "Enrégistrement Echoué", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void frm_client_Load(object sender, EventArgs e)
        {
            string[] town = new string[20]; //Table Qui contient les villes
            
            town[0] = "CASABLANCA";
            town[1] = "Rabat";
            town[2] = "Fés";
            town[3] = "Marrakech";
            town[4] = "Tanger";
            town[5] = "Settat";
            town[6] = "Oujda";
            town[7] = "Daraa";
            town[8] = "Souss/Massa";
            town[9] = "Guelmim";
            town[10] = "Laayoun";
            town[11] = "Dakhla";
            town[12] = "Salé";
            town[13] = "Tetouan";
            town[14] = "Meknès";
            town[15] = "Essaouira";
            town[16] = "Khenifra";
            town[17] = "Tafilalet";
            town[18] = "Massa";
            town[19] = "Beni mellal";

            //*********************************

            for (int i = 1; i < 32; i++)
            {
                cbojrsnaiss.Items.Add(i); //Chargement du Jour
            }
            for (int j = 1; j < 13; j++)
            {
                cbomoisnaiss.Items.Add(j); //Chargement du Mois
            }

            for (int k = 1930; k < (DateTime.Now.Year + 1); k++)
            {
                cboanenaiss.Items.Add(k); //Chargement de l'Année
            }
            for (int m = 0; m < 20; m++)
            {
                cboville.Items.Add(town[m]); //Chargement des Villes
            }
        }

        private void cbocategorie_DragOver(object sender, DragEventArgs e)
        {

        }

        private void cbocategorie_DropDown(object sender, EventArgs e)
        {
            var req = from ds in hornel.Categorie_client
                      select ds;



            cbocategorie.Items.Clear();

            foreach (var lama in req)
            {
                cbocategorie.Items.Add(lama.LibCateg); //Chargement des données provénant de la Table Categorie_client
            }
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            string code = "";
            var reqs = from ds in hornel.Categorie_client
                       where ds.LibCateg == cbocategorie.Text
                       select ds;

            foreach (var hlama in reqs)
            {
                code = hlama.CodeCateg;
            }

            if (MessageBox.Show("Voulez-vous Modifier Ces données?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Code Pour La modification Des données...
                var req = from ds in hornel.Client
                          where ds.Numcli == txtnum.Text
                          select ds;


                //Affectation et Modification des données



                foreach (var lama in req)
                {
                    lama.Numcli = txtnum.Text;
                    lama.Nom = txtnom.Text;
                    lama.Postnom = txtpostnom.Text;
                    lama.Prenom = txtprenom.Text;
                    lama.Sexe = Convert.ToChar(cbosexe.Text);
                    lama.Jrnaiss = cbojrsnaiss.Text;
                    lama.MsNaiss = cbomoisnaiss.Text;
                    lama.AnNaiss = cboanenaiss.Text;
                    lama.Rue = txtrue.Text;
                    lama.NumRue = txtnrue.Text;
                    lama.Quartier = txtquartier.Text;
                    lama.Commune = txtcommune.Text;
                    lama.Ville = cboville.Text;
                    lama.Nationalite = txtnationalite.Text;
                    lama.Tel = txttel.Text;
                    lama.CodeCateg = code;
                }

                hornel.SubmitChanges();


                MessageBox.Show("Donnée Modifées avec Succès !", "Modification Reussi !", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //Fin du code De Modification......

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menup mp = new Menup();
            this.Dispose();
            mp.Visible = true;
        }

        private void cboville_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {
            string code = ""; //La variable qui reçoit le Numero de Categorie de Vehile du client

            //La Requête pour Affichez les informations du Clients

            var rep = from ds in hornel.Client
                      where ds.Numcli == txtnum.Text 
                      select ds; 

            foreach (var lamas in rep)
            {
                lamas.Numcli = txtnum.Text;
                lamas.Nom = txtnom.Text;
                lamas.Postnom = txtpostnom.Text;
                lamas.Prenom = txtprenom.Text;
                lamas.Sexe = Convert.ToChar(cbosexe.Text);
                lamas.Jrnaiss = cbojrsnaiss.Text;
                lamas.MsNaiss = cbomoisnaiss.Text;
                lamas.AnNaiss = cboanenaiss.Text;
                lamas.Rue = txtrue.Text;
                lamas.NumRue = txtnrue.Text;
                lamas.Quartier = txtquartier.Text;
                lamas.Commune = txtcommune.Text;
                lamas.Ville = cboville.Text;
                lamas.Nationalite = txtnationalite.Text;
                lamas.Tel = txttel.Text;
                lamas.CodeCateg = code;
            }
            //******************************************************************************


            //code pour chercher le numero de categorie de vehicule,puis l'affiche dans le comboBox(cbocategorie)

            var reqs = from ds in hornel.Categorie_client
                       where ds.CodeCateg == code
                       select ds;


            foreach (var hlama in reqs)
            {
                cbocategorie.Text = hlama.LibCateg; //La valeur Récuperée par Rapport à la variable code(trouvée)
            }

            //***************************************************************************
            if (txtnum.Text == "")
            {
                txtnum.Text = "";
                txtnom.Text = "";
                txtpostnom.Text = "";
                txtprenom.Text = "";
                cbosexe.Text = "";
                cbojrsnaiss.Text = "";
                cbomoisnaiss.Text = "";
                cboanenaiss.Text = "";
                txtrue.Text = "";
                txtnrue.Text = "";
                txtquartier.Text = "";
                txtcommune.Text = "";
                cboville.Text = "";
                txtnationalite.Text = "";
                txttel.Text = "";
                cbocategorie.Text = "";

            }
        }
    }
}
    

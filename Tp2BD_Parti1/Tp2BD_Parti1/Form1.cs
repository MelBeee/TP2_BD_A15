using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;

namespace Tp2BD_Parti1
{
    public partial class Form1 : Form
    {
        String ConnexionChaine = "Data Source=P104-10\\SQLEXPRESS2012;Initial Catalog=bdOperation;User ID=conOperation;Password=oracle";
        SqlConnection Connexion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeCBIdFournisseur();
            UpdateControls();
        }

        // Ici on se connecte a la BD
        private void ConnexionBDSQL()
        {
            Connexion = new SqlConnection(ConnexionChaine);
            try
            {
                Connexion.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }

        // Ici on se deconnecte de la BD
        private void DeconnexionBDSql()
        {
            try
            {
                Connexion.Close();
            }
            catch (Exception e)
            {

            }
        }

        private void UpdateControls()
        {
            if (TB_IdInventaire.Text != String.Empty && CB_IdFournisseur.SelectedIndex != -1 && TB_QteMax.Text != String.Empty && TB_QteMin.Text != String.Empty && TB_QteStock.Text != String.Empty && TB_Description.Text != String.Empty)
                BT_AjouterInventaire.Enabled = true;
            else
                BT_AjouterInventaire.Enabled = false;


            if (TB_RechercheDescription.Text != String.Empty)
                BT_RechercheDescription.Enabled = true;
            else
                BT_RechercheDescription.Enabled = false;

            if (TB_RechercheNom.Text != String.Empty)
                BT_RechercheNom.Enabled = true;
            else
                BT_RechercheNom.Enabled = false;

            if (TB_IdFournisseur.Text != String.Empty && TB_NomFournisseur.Text != String.Empty && TB_AdFournisseur.Text != String.Empty && TB_VilleFournisseur.Text != String.Empty && TB_CPFFournisseur.Text != String.Empty && TB_TelFournisseur.Text != String.Empty && TB_SoldeFournisseur.Text != String.Empty && TB_CourrielFournisseur.Text != String.Empty)
                BT_AjouterFournisseur.Enabled = true;
            else
                BT_AjouterFournisseur.Enabled = false;

        }

        private void MakeCBIdFournisseur()
        {
            CB_IdFournisseur.Items.Clear();
            ConnexionBDSQL();
            SqlCommand GetIDFournisseur = new SqlCommand("select IdFournisseur from Fournisseur", Connexion);
            try
            {
                SqlDataReader DataReader = GetIDFournisseur.ExecuteReader();

                while (DataReader.Read())
                {
                    CB_IdFournisseur.Items.Add(DataReader["IdFournisseur"].ToString());
                }
            }
            catch (Exception e)
            {

            }
            DeconnexionBDSql();
        }

        private void TB_IdInventaire_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void CB_IdFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_QteStock_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_QteMin_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_QteMax_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_Description_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_RechercheDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_RechercheNom_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_IdFournisseur_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_NomFournisseur_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_AdFournisseur_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_VilleFournisseur_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_CPFFournisseur_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_TelFournisseur_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_SoldeFournisseur_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_CourrielFournisseur_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void BT_AjouterInventaire_Click(object sender, EventArgs e)
        {


        }

        private void BT_RechercheDescription_Click(object sender, EventArgs e)
        {
            CB_IdFournisseur.Items.Clear();
            ConnexionBDSQL();
            SqlCommand SelectInventaire = new SqlCommand("select * from inventaire where idinventaire = " + TB_RechercheDescription.Text, Connexion);
            try
            {
                SqlDataReader DataReader = SelectInventaire.ExecuteReader();

                if(DataReader.Read())
                {
                    TB_IdInventaire.Text = DataReader["IdInventaire"].ToString();
                    CB_IdFournisseur.Text = DataReader["IdFournisseur"].ToString();
                    TB_QteStock.Text = DataReader["QteStock"].ToString();

                }

                while (DataReader.Read())
                {
                    CB_IdFournisseur.Items.Add(DataReader["IdFournisseur"].ToString());
                }
            }
            catch (Exception exc)
            {

            }
            DeconnexionBDSql();
        }
    }
}

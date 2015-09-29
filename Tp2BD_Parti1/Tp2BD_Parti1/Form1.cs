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
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
        }

        // Ici on se deconnecte de la BD
        private void DeconnexionBDSql()
        {
            try
            {
                Connexion.Close();
            }
            catch (Exception exc)
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
            catch (Exception exc)
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
            ConnexionBDSQL();
            string sql = " insert into inventaire (idinventaire, descriptioninventaire, idfournisseur, qtestock, qteminimum, qtemaximum)" +
                         " values (@ID, @Description, @IDFournisseur, @QteStock, @QteMin, @QteMax)";

            try
            {
                SqlCommand AddInventaire = new SqlCommand(sql, Connexion);
                AddInventaire.CommandType = CommandType.Text;
                AddInventaire.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(TB_IdInventaire.Text);
                AddInventaire.Parameters.Add("@Description", SqlDbType.VarChar, 50).Value = TB_Description.Text;
                AddInventaire.Parameters.Add("@IDFournisseur", SqlDbType.VarChar, 50).Value = TB_IdFournisseur.Text;
                AddInventaire.Parameters.Add("@QteStock", SqlDbType.VarChar, 50).Value = TB_QteStock.Text;
                AddInventaire.Parameters.Add("@QteMin", SqlDbType.VarChar, 50).Value = TB_QteMin.Text;
                AddInventaire.Parameters.Add("@QteMax", SqlDbType.VarChar, 50).Value = TB_QteMax.Text;

                AddInventaire.ExecuteNonQuery();
            }
            catch(Exception exc)
            {

            }

            DeconnexionBDSql();
        }

        private void BT_RechercheDescription_Click(object sender, EventArgs e)
        {
            ConnexionBDSQL();
            SqlCommand SelectInventaire = new SqlCommand("select * from inventaire where descriptioninventaire like %'" + TB_RechercheDescription.Text + "'%", Connexion);
            try
            {
                SqlDataReader DataReader = SelectInventaire.ExecuteReader();

                if (DataReader.Read())
                {
                    TB_IdInventaire.Text = DataReader["IdInventaire"].ToString();
                    CB_IdFournisseur.Text = DataReader["IdFournisseur"].ToString();
                    TB_QteStock.Text = DataReader["QteStock"].ToString();
                    TB_QteMin.Text = DataReader["QteMinimum"].ToString();
                    TB_QteMax.Text = DataReader["QteMaximum"].ToString();
                    TB_Description.Text = DataReader["DescriptionInventaire"].ToString();
                }
            }
            catch (Exception exc)
            {

            }
            DeconnexionBDSql();
        }

        private void BT_RechercheNom_Click(object sender, EventArgs e)
        {
            ConnexionBDSQL();
            SqlCommand SelectInventaire = new SqlCommand("select * from fournisseur where nomfournisseur like %'" + TB_RechercheNom.Text + "'%", Connexion);
            try
            {
                SqlDataReader DataReader = SelectInventaire.ExecuteReader();

                if (DataReader.Read())
                {
                    TB_IdFournisseur.Text = DataReader["IdFournisseur"].ToString();
                    TB_NomFournisseur.Text = DataReader["NomFournisseur"].ToString();
                    TB_AdFournisseur.Text = DataReader["AdFournisseur"].ToString();
                    TB_VilleFournisseur.Text = DataReader["VilleFournisseur"].ToString();
                    TB_CPFFournisseur.Text = DataReader["CPFFournisseur"].ToString();
                    TB_TelFournisseur.Text = DataReader["TelFournisseur"].ToString();
                    TB_SoldeFournisseur.Text = DataReader["SoldeFournisseur"].ToString();
                    TB_CourrielFournisseur.Text = DataReader["CourrielFournisseur"].ToString();
                }
            }
            catch (Exception exc)
            {

            }
            DeconnexionBDSql();
        }

        private void BT_AjouterFournisseur_Click(object sender, EventArgs e)
        {
            ConnexionBDSQL();
            string sql = " insert into fournisseur (IdFournisseur, NomFournisseur, AdFournisseur, VilleFournisseur, CPFournisseur, TelFournisseur, SoldeFournisseur, CourrielFournisseur)" +
                         " values (@ID, @Nom, @Adresse, @Ville, @CodePostal, @Telephone, @Solde, @Courriel)";

            try
            {
                SqlCommand AddInventaire = new SqlCommand(sql, Connexion);
                AddInventaire.CommandType = CommandType.Text;
                AddInventaire.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(TB_IdFournisseur.Text);
                AddInventaire.Parameters.Add("@Nom", SqlDbType.VarChar, 50).Value = TB_NomFournisseur.Text;
                AddInventaire.Parameters.Add("@Adresse", SqlDbType.VarChar, 50).Value = TB_AdFournisseur.Text;
                AddInventaire.Parameters.Add("@Ville", SqlDbType.VarChar, 50).Value = TB_VilleFournisseur.Text;
                AddInventaire.Parameters.Add("@CodePostal", SqlDbType.VarChar, 50).Value = TB_CPFFournisseur.Text;
                AddInventaire.Parameters.Add("@Telephone", SqlDbType.VarChar, 50).Value = TB_TelFournisseur.Text;
                AddInventaire.Parameters.Add("@Solde", SqlDbType.Int, 50).Value = TB_SoldeFournisseur.Text;
                AddInventaire.Parameters.Add("@Courriel", SqlDbType.VarChar, 50).Value = TB_CourrielFournisseur.Text;

                AddInventaire.ExecuteNonQuery();
            }
            catch (Exception exc)
            {

            }

            DeconnexionBDSql();
        }
    }
}

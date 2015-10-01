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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

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
            MettreAJourTableau();

            // arranger la largeur des colonnes
            int widthdgv = DGV_Produit.Width - 3;
            Fournisseur.Width = widthdgv / 3;
            Article.Width = widthdgv / 3;
            Nombre.Width = widthdgv / 3;
        }

        private void ListeToutFournisseur()
        {
            ConnexionBDSQL();

            try
            {
                DataSet DataTableFournisseur;
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                ReportDocument RapportToutFournisseur = new ReportDocument();
                String sqlToutFournisseur = "select * from Fournisseur";
                DataTableFournisseur = new DataSet("Fournisseur");


                dataAdapter.SelectCommand = new SqlCommand(sqlToutFournisseur, Connexion);
                dataAdapter.Fill(DataTableFournisseur, "Fournisseur");

                if (this.BindingContext[DataTableFournisseur, "Fournisseur"].Count > 0)
                {
                   String chemin = "..\\..\\ToutListeFournisseur.rpt";
                   RapportToutFournisseur.Load(chemin);
                   RapportToutFournisseur.SetDataSource(DataTableFournisseur.Tables["Fournisseur"]);

                    CRV_Main.ReportSource = RapportToutFournisseur;
                    CRV_Main.Refresh();
                }

                DataTableFournisseur.Clear();
                dataAdapter.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DeconnexionBDSql();
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
                MessageBox.Show(exc.Message);
            }
        }

        private void UpdateControls()
        {
            if (TB_IdInventaire.Text != String.Empty && CB_IdFournisseur.SelectedIndex != -1 && TB_QteMax.Text != String.Empty && TB_QteMin.Text != String.Empty && TB_QteStock.Text != String.Empty && TB_Description.Text != String.Empty)
            {
                BT_AjouterInventaire.Enabled = true;
                BT_SupprimerInventaire.Enabled = true;
                BT_ModifierInventaire.Enabled = true;
            }
            else
            {
                BT_AjouterInventaire.Enabled = false;
                BT_SupprimerInventaire.Enabled = false;
                BT_ModifierInventaire.Enabled = false;
            }

            if (TB_RechercheDescription.Text != String.Empty)
                BT_RechercheDescription.Enabled = true;
            else
                BT_RechercheDescription.Enabled = false;

            if (TB_RechercheNom.Text != String.Empty)
                BT_RechercheNom.Enabled = true;
            else
                BT_RechercheNom.Enabled = false;

            if (TB_IdFournisseur.Text != String.Empty && TB_NomFournisseur.Text != String.Empty && TB_AdFournisseur.Text != String.Empty && TB_VilleFournisseur.Text != String.Empty && TB_CPFFournisseur.Text != String.Empty && TB_TelFournisseur.Text != String.Empty && TB_SoldeFournisseur.Text != String.Empty && TB_CourrielFournisseur.Text != String.Empty)
            {
                BT_AjouterFournisseur.Enabled = true;
                BT_SupprimerFournisseur.Enabled = true;
                BT_ModifierFournisseur.Enabled = true;
            }
            else
            {
                BT_AjouterFournisseur.Enabled = false;
                BT_SupprimerFournisseur.Enabled = false;
                BT_ModifierFournisseur.Enabled = false;
            }
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
                MessageBox.Show(exc.Message);
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

        private void MettreAJourTableau()
        {
            DGV_Produit.Rows.Clear();
            ConnexionBDSQL();
            SqlCommand GetLesArticlesManquants = new SqlCommand("select f.nomfournisseur, i.descriptioninventaire, i.qtemaximum - i.qtestock as Qte from fournisseur f inner join inventaire i on i.idfournisseur = f.idfournisseur " + 
                                                         " where i.qtestock < i.qteminimum " , Connexion);
            try
            {
                SqlDataReader DataReader = GetLesArticlesManquants.ExecuteReader();

                while (DataReader.Read())
                {
                    DGV_Produit.Rows.Add(DataReader["nomfournisseur"].ToString(), 
                                         DataReader["descriptioninventaire"].ToString(),
                                         DataReader["qte"].ToString());
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            DeconnexionBDSql();
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
                AddInventaire.Parameters.Add("@IDFournisseur", SqlDbType.VarChar, 50).Value = CB_IdFournisseur.Text;
                AddInventaire.Parameters.Add("@QteStock", SqlDbType.VarChar, 50).Value = TB_QteStock.Text;
                AddInventaire.Parameters.Add("@QteMin", SqlDbType.VarChar, 50).Value = TB_QteMin.Text;
                AddInventaire.Parameters.Add("@QteMax", SqlDbType.VarChar, 50).Value = TB_QteMax.Text;

                AddInventaire.ExecuteNonQuery();
                MessageBox.Show("Insertion reussite");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Insertion non reussite");
            }

            DeconnexionBDSql();
            MettreAJourTableau();
        }

        private void BT_RechercheDescription_Click(object sender, EventArgs e)
        {
            ConnexionBDSQL();
            SqlCommand SelectInventaire = new SqlCommand("select * from inventaire where DescriptionInventaire like '%" + TB_RechercheDescription.Text + "%'", Connexion);
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

                    MessageBox.Show("Recherche reussite");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Recherche non reussite");
            }
            DeconnexionBDSql();
        }

        private void BT_RechercheNom_Click(object sender, EventArgs e)
        {
            ConnexionBDSQL();
            SqlCommand SelectInventaire = new SqlCommand("select * from fournisseur where nomfournisseur like '%" + TB_RechercheNom.Text + "%'", Connexion);
            try
            {
                SqlDataReader DataReader = SelectInventaire.ExecuteReader();

                if (DataReader.Read())
                {
                    TB_IdFournisseur.Text = DataReader["IdFournisseur"].ToString();
                    TB_NomFournisseur.Text = DataReader["NomFournisseur"].ToString();
                    TB_AdFournisseur.Text = DataReader["AdFournisseur"].ToString();
                    TB_VilleFournisseur.Text = DataReader["VilleFournisseur"].ToString();
                    TB_CPFFournisseur.Text = DataReader["CPFournisseur"].ToString();
                    TB_TelFournisseur.Text = DataReader["TellFournisseur"].ToString();
                    TB_SoldeFournisseur.Text = DataReader["SoldeFournisseur"].ToString();
                    TB_CourrielFournisseur.Text = DataReader["CourrielFournisseur"].ToString();

                    MessageBox.Show("Recherche reussite");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Recherche non reussite");
            }
            DeconnexionBDSql();
        }

        private void BT_AjouterFournisseur_Click(object sender, EventArgs e)
        {
            ConnexionBDSQL();
            string sql = " insert into fournisseur (IdFournisseur, NomFournisseur, AdFournisseur, VilleFournisseur, CPFournisseur, TellFournisseur, SoldeFournisseur, CourrielFournisseur)" +
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
                AddInventaire.Parameters.Add("@Solde", SqlDbType.VarChar, 50).Value = TB_SoldeFournisseur.Text;
                AddInventaire.Parameters.Add("@Courriel", SqlDbType.VarChar, 50).Value = TB_CourrielFournisseur.Text;

                AddInventaire.ExecuteNonQuery();
                MessageBox.Show("Insertion reussite");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Insertion non reussite");
            }

            DeconnexionBDSql();
            MettreAJourTableau();
        }

        private void BT_SupprimerInventaire_Click(object sender, EventArgs e)
        {
            ConnexionBDSQL();

            string sql = "delete from inventaire where idinventaire =" + TB_IdInventaire.Text;

            try
            {
                SqlCommand DeleteInventaire = new SqlCommand(sql, Connexion);

                DeleteInventaire.ExecuteNonQuery();
                MessageBox.Show("Suppression reussite");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Suppression non reussite");
            }

            DeconnexionBDSql();
            MettreAJourTableau();
        }

        private void BT_SupprimerFournisseur_Click(object sender, EventArgs e)
        {
            ConnexionBDSQL();

            string sql = "delete from fournisseur where idfournisseur =" + TB_IdFournisseur.Text;

            try
            {
                SqlCommand DeleteInventaire = new SqlCommand(sql, Connexion);

                DeleteInventaire.ExecuteNonQuery();
                MessageBox.Show("Suppression reussite");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Suppression non reussite");
            }

            DeconnexionBDSql();
            MettreAJourTableau();
        }

        private void BT_ModifierInventaire_Click(object sender, EventArgs e)
        {
            ConnexionBDSQL();
            string sql = " update inventaire set IdInventaire = @ID, " +
                                                " DescriptionInventaire = @Description, " +
                                                " IdFournisseur = @IDFournisseur, " +
                                                " QteStock = @QteStock, " +
                                                " QteMinimum = @QteMin, " +
                                                " QteMaximum = @QteMax " +
                                                " where IdInventaire = " + TB_IdInventaire.Text;
            try
            {
                SqlCommand AddInventaire = new SqlCommand(sql, Connexion);
                AddInventaire.CommandType = CommandType.Text;
                AddInventaire.Parameters.Add("@ID", SqlDbType.Int).Value = int.Parse(TB_IdInventaire.Text);
                AddInventaire.Parameters.Add("@Description", SqlDbType.VarChar, 50).Value = TB_Description.Text;
                AddInventaire.Parameters.Add("@IDFournisseur", SqlDbType.VarChar, 50).Value = CB_IdFournisseur.Text;
                AddInventaire.Parameters.Add("@QteStock", SqlDbType.VarChar, 50).Value = TB_QteStock.Text;
                AddInventaire.Parameters.Add("@QteMin", SqlDbType.VarChar, 50).Value = TB_QteMin.Text;
                AddInventaire.Parameters.Add("@QteMax", SqlDbType.VarChar, 50).Value = TB_QteMax.Text;

                AddInventaire.ExecuteNonQuery();
                MessageBox.Show("Modification reussite");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Modification non reussite");
            }

            DeconnexionBDSql();
            MettreAJourTableau();
        }

        private void BT_ModifierFournisseur_Click(object sender, EventArgs e)
        {
            ConnexionBDSQL();
            string sql = " update fournisseur set IdFournisseur = @ID, " +
                                                 " NomFournisseur = @Nom, " +
                                                 " AdFournisseur = @Adresse, " +
                                                 " VilleFournisseur = @Ville," +
                                                 " CPFournisseur = @CodePostal, " +
                                                 " TellFournisseur = @Telephone, " +
                                                 " SoldeFournisseur = @Solde, " +
                                                 " CourrielFournisseur = @Courriel " + 
                                                 " where IdFournisseur = " + TB_IdFournisseur.Text;

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
                AddInventaire.Parameters.Add("@Solde", SqlDbType.VarChar, 50).Value = TB_SoldeFournisseur.Text;
                AddInventaire.Parameters.Add("@Courriel", SqlDbType.VarChar, 50).Value = TB_CourrielFournisseur.Text;

                AddInventaire.ExecuteNonQuery();
                MessageBox.Show("Modification reussite");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Modification non reussite");
            }

            DeconnexionBDSql();
            MettreAJourTableau();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BT_ToutFournisseur_Click(object sender, EventArgs e)
        {
            ListeToutFournisseur();
        }

       
    }
}

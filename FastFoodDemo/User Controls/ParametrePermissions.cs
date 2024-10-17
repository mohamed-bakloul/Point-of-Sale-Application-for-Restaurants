using FastFoodDemo.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FastFoodDemo.User_Controls
{
    public partial class ParametrePermissions : UserControl
    {
        public static ParametrePermissions ParametrePermissionsInstance;

        public static ParametrePermissions Instance
        {
            get
            {
                if (ParametrePermissionsInstance == null)
                {
                    ParametrePermissionsInstance = new ParametrePermissions();
                }
                return ParametrePermissionsInstance;
            }
        }

        public ParametrePermissions()
        {
            InitializeComponent();
            ParametrePermissionsInstance = this;
        }

        ADO ADO = new ADO();

        public void CheckPermissionsParRole(string Role)
        {
            ADO.Connecter();

            if (Role.Equals(ADO.UserRoles.Caissier.ToString()))
            {
                ADO.sda = new SqlDataAdapter("select SuppressionCaisse,AnnulationCaisse,ValidationCaisse,OuvrirTiroirCaisse,ImprimerTicketCuisineCaisse,ImprimerTicketClientCaisse,Remise from Autorisation where Role=@Role", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@Role", Role);
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                if (table.Rows.Count > 0)
                {
                    CmbSupprimerCommande.Text = table.Rows[0][0].ToString();
                    CmbAnnulerCommande.Text = table.Rows[0][1].ToString();
                    CmbValiderCommande.Text = table.Rows[0][2].ToString();
                    CmbOuvrirTiroir.Text = table.Rows[0][3].ToString();
                    CmbImprimerTicketCuisine.Text = table.Rows[0][4].ToString();
                    CmbImprimerTicketClient.Text = table.Rows[0][5].ToString();
                    CmbRemise.Text = table.Rows[0][6].ToString();
                }
            }
            else
            {
                ADO.sda = new SqlDataAdapter("select SuppressionCaisse,AnnulationCaisse,ValidationCaisse,OuvrirTiroirCaisse,ImprimerTicketCuisineCaisse,ImprimerTicketClientCaisse,Remise,GestionProduitCategorie,Rapport,ImprimerRapport,Benefice,Parametrage,GesiontUtilisateur,Commandes,SuppressionTicket,ImprimerDuplicata,Charges,RapportEnLigne from Autorisation where Role=@Role", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@Role", Role);
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                if (table.Rows.Count > 0)
                {
                    CmbSupprimerCommande.Text = table.Rows[0][0].ToString();
                    CmbAnnulerCommande.Text = table.Rows[0][1].ToString();
                    CmbValiderCommande.Text = table.Rows[0][2].ToString();
                    CmbOuvrirTiroir.Text = table.Rows[0][3].ToString();
                    CmbImprimerTicketCuisine.Text = table.Rows[0][4].ToString();
                    CmbImprimerTicketClient.Text = table.Rows[0][5].ToString();
                    CmbRemise.Text = table.Rows[0][6].ToString();
                    CmbCategoriesProduits.Text = table.Rows[0][7].ToString();
                    CmbRapport.Text = table.Rows[0][8].ToString();
                    CmbImprimerTicketRapport.Text = table.Rows[0][9].ToString();
                    CmbBenefice.Text = table.Rows[0][10].ToString();
                    CmbParametrage.Text = table.Rows[0][11].ToString();
                    CmbUtilisateurs.Text = table.Rows[0][12].ToString();
                    CmbCommandes.Text = table.Rows[0][13].ToString();
                    CmbSupprimerCommandePayer.Text = table.Rows[0][14].ToString();
                    CmbImprimerDuplicata.Text = table.Rows[0][15].ToString();
                    CmbCharges.Text = table.Rows[0][16].ToString();
                    CmbRapportEnLigne.Text = table.Rows[0][17].ToString();
                }
            }

            ADO.Deconnecter();
        }

        private void ParametrePermissions_Load(object sender, EventArgs e)
        {
            GroupBoxPointDeVente.Enabled = false;
            GroupBoxBenefice.Enabled = false;
            GroupBoxCategoriesProduits.Enabled = false;
            GroupBoxCharges.Enabled = false;
            GroupBoxCommandes.Enabled = false;
            GroupBoxParametrage.Enabled = false;
            GroupBoxRapport.Enabled = false;
            GroupBoxUtilisateurs.Enabled = false;
            GroupBoxRapportEnLigne.Enabled = false;
            GroupBoxCategorie.Width = Form1.GeneralInstance.PnlAffichage.Width - 25;
            this.Dock = DockStyle.Fill;
        }

        private void CmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbRoles.SelectedIndex != 0)
            {
                CheckPermissionsParRole(CmbRoles.Text);
                if (CmbRoles.Text == ADO.UserRoles.Caissier.ToString())
                {

                    GroupBoxPointDeVente.Enabled = true;

                    CmbRapport.Text = CmbCategoriesProduits.Text = CmbImprimerTicketRapport.Text = CmbParametrage.Text = CmbUtilisateurs.Text = CmbBenefice.Text = CmbCharges.Text = CmbCommandes.Text = CmbImprimerDuplicata.Text = CmbSupprimerCommandePayer.Text = "Non";

                    GroupBoxBenefice.Enabled = GroupBoxCategoriesProduits.Enabled = GroupBoxCharges.Enabled = GroupBoxCommandes.Enabled = GroupBoxParametrage.Enabled = GroupBoxRapport.Enabled = GroupBoxUtilisateurs.Enabled = GroupBoxRapportEnLigne.Enabled = false;
                }
                else
                {
                    GroupBoxPointDeVente.Enabled = GroupBoxBenefice.Enabled = GroupBoxCategoriesProduits.Enabled = GroupBoxCharges.Enabled = GroupBoxCommandes.Enabled = GroupBoxParametrage.Enabled = GroupBoxRapport.Enabled = GroupBoxUtilisateurs.Enabled = GroupBoxRapportEnLigne.Enabled = true;
                }
            }
            else
            {
                GroupBoxPointDeVente.Enabled = GroupBoxBenefice.Enabled = GroupBoxCategoriesProduits.Enabled = GroupBoxCharges.Enabled = GroupBoxCommandes.Enabled = GroupBoxParametrage.Enabled = GroupBoxRapport.Enabled = GroupBoxUtilisateurs.Enabled = GroupBoxRapportEnLigne.Enabled = false;

            }
        }

        private void BtnModifierPermissions_Click(object sender, EventArgs e)
        {
            if (CmbRoles.SelectedIndex != 0)
            {
                ADO.Connecter();
                if (CmbRoles.Text.Equals(ADO.UserRoles.Caissier.ToString()))
                {
                    ADO.cmd = new SqlCommand("update Autorisation set SuppressionCaisse=@SuppressionCaisse,AnnulationCaisse=@AnnulationCaisse,ValidationCaisse=@ValidationCaisse,OuvrirTiroirCaisse=@OuvrirTiroirCaisse,ImprimerTicketCuisineCaisse=@ImprimerTicketCuisineCaisse,ImprimerTicketClientCaisse=@ImprimerTicketClientCaisse,Remise=@Remise where Role=@Role", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Role", CmbRoles.Text);
                    ADO.cmd.Parameters.AddWithValue("@SuppressionCaisse", CmbSupprimerCommande.Text);
                    ADO.cmd.Parameters.AddWithValue("@AnnulationCaisse", CmbAnnulerCommande.Text);
                    ADO.cmd.Parameters.AddWithValue("@ValidationCaisse", CmbValiderCommande.Text);
                    ADO.cmd.Parameters.AddWithValue("@OuvrirTiroirCaisse", CmbOuvrirTiroir.Text);
                    ADO.cmd.Parameters.AddWithValue("@ImprimerTicketCuisineCaisse", CmbImprimerTicketCuisine.Text);
                    ADO.cmd.Parameters.AddWithValue("@ImprimerTicketClientCaisse", CmbImprimerTicketClient.Text);
                    ADO.cmd.Parameters.AddWithValue("@Remise", CmbRemise.Text);
                    ADO.cmd.ExecuteNonQuery();
                }
                else
                {
                    ADO.cmd = new SqlCommand("update Autorisation set SuppressionCaisse=@SuppressionCaisse,AnnulationCaisse=@AnnulationCaisse,ValidationCaisse=@ValidationCaisse,OuvrirTiroirCaisse=@OuvrirTiroirCaisse,ImprimerTicketCuisineCaisse=@ImprimerTicketCuisineCaisse,ImprimerTicketClientCaisse=@ImprimerTicketClientCaisse,GestionProduitCategorie=@GestionProduitCategorie,Rapport=@Rapport,Benefice=@Benefice,Parametrage=@Parametrage,GesiontUtilisateur=@GesiontUtilisateur,Commandes=@Commandes,SuppressionTicket=@SuppressionTicket,ImprimerDuplicata=@ImprimerDuplicata,Remise=@Remise,Charges=@Charges,ImprimerRapport=@ImprimerRapport,RapportEnLigne=@RapportEnLigne where Role=@Role", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Role", CmbRoles.Text);
                    ADO.cmd.Parameters.AddWithValue("@SuppressionCaisse", CmbSupprimerCommande.Text);
                    ADO.cmd.Parameters.AddWithValue("@AnnulationCaisse", CmbAnnulerCommande.Text);
                    ADO.cmd.Parameters.AddWithValue("@ValidationCaisse", CmbValiderCommande.Text);
                    ADO.cmd.Parameters.AddWithValue("@OuvrirTiroirCaisse", CmbOuvrirTiroir.Text);
                    ADO.cmd.Parameters.AddWithValue("@ImprimerTicketCuisineCaisse", CmbImprimerTicketCuisine.Text);
                    ADO.cmd.Parameters.AddWithValue("@ImprimerTicketClientCaisse", CmbImprimerTicketClient.Text);
                    ADO.cmd.Parameters.AddWithValue("@Remise", CmbRemise.Text);
                    ADO.cmd.Parameters.AddWithValue("@GestionProduitCategorie", CmbCategoriesProduits.Text);
                    ADO.cmd.Parameters.AddWithValue("@Rapport", CmbRapport.Text);
                    ADO.cmd.Parameters.AddWithValue("@Benefice", CmbBenefice.Text);
                    ADO.cmd.Parameters.AddWithValue("@Parametrage", CmbParametrage.Text);
                    ADO.cmd.Parameters.AddWithValue("@GesiontUtilisateur", CmbUtilisateurs.Text);
                    ADO.cmd.Parameters.AddWithValue("@Commandes", CmbCommandes.Text);
                    ADO.cmd.Parameters.AddWithValue("@SuppressionTicket", CmbSupprimerCommandePayer.Text);
                    ADO.cmd.Parameters.AddWithValue("@ImprimerDuplicata", CmbImprimerDuplicata.Text);
                    ADO.cmd.Parameters.AddWithValue("@Charges", CmbCharges.Text);
                    ADO.cmd.Parameters.AddWithValue("@ImprimerRapport", CmbImprimerTicketRapport.Text);
                    ADO.cmd.Parameters.AddWithValue("@RapportEnLigne", CmbRapportEnLigne.Text);
                    ADO.cmd.ExecuteNonQuery();
                }
                ADO.Deconnecter();
                MessageBox.Show("Autorisation est bien modifier pour le " + CmbRoles.Text + " !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CheckPermissionsParRole(CmbRoles.Text);
            }
        }
    }
}
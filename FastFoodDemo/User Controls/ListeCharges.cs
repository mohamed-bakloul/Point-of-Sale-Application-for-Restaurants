using FastFoodDemo.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class ListeCharges : UserControl
    {
        public static ListeCharges ListeChargesInstance;

        public static ListeCharges Instance
        {
            get
            {
                if (ListeChargesInstance == null)
                {
                    ListeChargesInstance = new ListeCharges();
                }
                return ListeChargesInstance;
            }
        }

        public ListeCharges()
        {
            InitializeComponent();
            ListeChargesInstance = this;
        }

        ADO ADO = new ADO();

        public void ListTiers()
        {
            try
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("GetTierIdAndName", ADO.con);
                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                DGVTiers.DataSource = table;
                //DGVTiers.Columns[1].Width = 200;

                if (DGVTiers.Rows.Count == 0)
                {
                    System.Data.DataTable dd = new System.Data.DataTable();
                    //DGVListeImprimantes.Width = 140;
                    //DGVListeImprimantes.Height = 90;
                    dd.Columns.Add("Message");
                    //dd.Columns.Add("Nom");
                    dd.Rows.Add("Pas de données !");
                    DGVTiers.DataSource = dd;
                    DGVTiers.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ListCharges()
        {
            try
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("ListeChargesParDate", ADO.con);
                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                DGVListeCharges.DataSource = table;

                if (DGVListeCharges.Rows.Count == 0)
                {
                    System.Data.DataTable dd = new System.Data.DataTable();
                    //DGVListeImprimantes.Width = 140;
                    //DGVListeImprimantes.Height = 90;
                    dd.Columns.Add("Message");
                    //dd.Columns.Add("Nom");
                    dd.Rows.Add("Pas de données !");
                    DGVListeCharges.DataSource = dd;
                    DGVListeCharges.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAjouterCharge_Click(object sender, EventArgs e)
        {
            ADO.RemplirCombo("GetTierIdAndName", CmbTiers, "Nom", "Id_Tier", "", "-- Choisir le tier --");
            GroupBoxListeCharges.Enabled = false;
            GroupBoxAddCharge.BringToFront();
            GroupBoxAddCharge.Visible = true;
        }

        private void ListeCharges_Load(object sender, EventArgs e)
        {
            DPDateDebut.Value = DateTime.Now;
            DPDateCharge.Value = DateTime.Now;
            DPDateFin.Value = DateTime.Now.AddDays(1);
            ListCharges();

            GroupBoxListeCharges.Width = Form1.GeneralInstance.PnlAffichage.Width - 25;

            this.Dock = DockStyle.Fill;
        }

        private void TxtPrixUnitaire_Leave(object sender, EventArgs e)
        {
            if (TxtQuantite.Text != "" && TxtPrixUnitaire.Text != "")
            {
                if (decimal.Parse(TxtQuantite.Text) > 0 && decimal.Parse(TxtPrixUnitaire.Text) > 0)
                    TxtTotal.Text = (decimal.Parse(TxtQuantite.Text) * decimal.Parse(TxtPrixUnitaire.Text)).ToString();
            }
        }

        private void TxtQuantite_Leave(object sender, EventArgs e)
        {
            if (TxtQuantite.Text == "")
                TxtQuantite.Text = "1";

            if (TxtQuantite.Text != "" && TxtPrixUnitaire.Text != "")
            {
                if (decimal.Parse(TxtQuantite.Text) > 0 && decimal.Parse(TxtPrixUnitaire.Text) > 0)
                    TxtTotal.Text = (decimal.Parse(TxtQuantite.Text) * decimal.Parse(TxtPrixUnitaire.Text)).ToString();
            }
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            TxtQuantite.Text = TxtPrixUnitaire.Text = TxtTotal.Text = "";
            //CmbTiers.SelectedIndex = 0;
            DPDateCharge.Value = DateTime.Now;
            GroupBoxAddCharge.Visible = false;
            GroupBoxListeCharges.Enabled = true;
        }

        private void BtnAjouterTier_Click(object sender, EventArgs e)
        {
            GroupBoxAjouterTier.Visible = true;
            GroupBoxAddCharge.Visible = false;
            GroupBoxAjouterTier.BringToFront();
            TxtTier.Focus();
            ListTiers();
        }

        private void BtnFermerTier_Click(object sender, EventArgs e)
        {
            ADO.RemplirCombo("GetTierIdAndName", CmbTiers, "Nom", "Id_Tier", "", "-- Choisir le tier --");
            GroupBoxAjouterTier.Visible = false;
            GroupBoxAddCharge.Visible = true;
            GroupBoxAddCharge.BringToFront();
            TxtTier.Clear();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (TxtTier.Text != "")
            {
                ADO.Connecter();

                ADO.cmd = new SqlCommand("insert into Tiers values(@Nom)", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Nom", TxtTier.Text);
                ADO.cmd.ExecuteNonQuery();

                MessageBox.Show("Tier est bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListTiers();
                DGVTiers.ClearSelection();
                TxtTier.Clear();
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (TxtTier.Text != "")
            {
                ADO.Connecter();

                ADO.cmd = new SqlCommand("update Tiers set Nom=@Nom where Id_Tier=@Id_Tier", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Nom", TxtTier.Text);
                ADO.cmd.Parameters.AddWithValue("@Id_Tier", DGVTiers.SelectedRows[0].Cells[0].Value.ToString());
                ADO.cmd.ExecuteNonQuery();

                MessageBox.Show("Tier est bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListTiers();
                DGVTiers.ClearSelection();
                TxtTier.Clear();
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVTiers.Rows.Count > 0)
                {
                    if (DGVTiers.SelectedRows.Count == 1)
                    {
                        DialogResult dr = (MessageBox.Show("Voulez-vous vraiment supprimer ce produit !", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
                        if (dr == DialogResult.Yes)
                        {
                            ADO.cmd = new SqlCommand("delete from Tiers where Id_Tier=@Id_Tier", ADO.con);
                            ADO.cmd.Parameters.AddWithValue("@Id_Tier", DGVTiers.SelectedRows[0].Cells[0].Value.ToString());
                            ADO.cmd.ExecuteNonQuery();

                            MessageBox.Show("Tier est bien supprimer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ListTiers();
                            DGVTiers.ClearSelection();
                            TxtTier.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Opération de suppression pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Attention, veuillez choisir une ligne !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Attention, aucun ligne dans la table !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GroupBoxAjouterTier_Click(object sender, EventArgs e)
        {

        }

        private void BtnAjouterCharges_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbTiers.Text != "" && TxtLibelle.Text != "" && TxtQuantite.Text != "" && TxtPrixUnitaire.Text != "" && TxtTotal.Text != "")
                {
                    ADO.Connecter();

                    ADO.cmd = new SqlCommand("insert into Charges values(@Date_Charge,@Tier,@Libelle,@Quantite,@Prix_Unitaire,@Prix_Total)", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Date_Charge", Convert.ToDateTime(DPDateCharge.Value.ToString()));
                    ADO.cmd.Parameters.AddWithValue("@Tier", CmbTiers.Text);
                    ADO.cmd.Parameters.AddWithValue("@Libelle", TxtLibelle.Text);
                    ADO.cmd.Parameters.AddWithValue("@Quantite", TxtQuantite.Text);
                    ADO.cmd.Parameters.AddWithValue("@Prix_Unitaire", TxtPrixUnitaire.Text);
                    ADO.cmd.Parameters.AddWithValue("@Prix_Total", TxtTotal.Text);
                    ADO.cmd.ExecuteNonQuery();

                    MessageBox.Show("Charge est bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DPDateCharge.Value = DateTime.Now;
                    CmbTiers.SelectedIndex = 0;
                    TxtLibelle.Text = TxtPrixUnitaire.Text = TxtQuantite.Text = TxtTotal.Text = "";
                    GroupBoxAddCharge.Visible = false;
                    GroupBoxListeCharges.Enabled = true;
                    ListCharges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            ListCharges();
        }

        private void TxtLibelle_Leave(object sender, EventArgs e)
        {
            if (TxtLibelle.Text == "")
                TxtLibelle.Text = "-";
        }
    }
}
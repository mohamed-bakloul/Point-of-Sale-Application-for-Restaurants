using FastFoodDemo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.User_Controls
{
    public partial class BonReception : UserControl
    {
        public static BonReception BonReceptionInstance;

        public static BonReception Instance
        {
            get
            {
                if (BonReceptionInstance == null)
                {
                    BonReceptionInstance = new BonReception();
                }
                return BonReceptionInstance;
            }
        }

        public BonReception()
        {
            InitializeComponent();
            BonReceptionInstance = this;
        }

        ADO ADO = new ADO();

        DataTable tableProduits = new DataTable();
        DataTable dataTableDelete = new DataTable();
        DataTable dataTableAdd = new DataTable();

        public bool CheckIsInBalance()
        {
            ADO.Connecter();
            ADO.sda = new SqlDataAdapter("select COUNT(CIN) from Balance where CIN=@CIN", ADO.con);
            //ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            ADO.sda.SelectCommand.Parameters.AddWithValue("@CIN", CmbFournisseur.SelectedValue);
            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            ADO.Deconnecter();
            if (!table.Rows[0][0].ToString().Equals("0"))
                return true;
            return false;
        }

        public string ReferenceBonReception()
        {
            ADO.Connecter();

            string Reference = "";

            //ADO.sda = new SqlDataAdapter("select Id from BonReception", ADO.con);
            //DataTable data = new DataTable();
            //ADO.sda.Fill(data);
            ADO.sda = new SqlDataAdapter("select 'BR-' + CAST(ISNULL(MAX(Id),0) + 1 as nvarchar(MAX)) as 'Référence' from BonReception", ADO.con);
            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            ADO.Deconnecter();
            if (table.Rows.Count == 1)
            {
                Reference = table.Rows[0][0].ToString();
            }
            //if (data.Rows.Count == 0)
            //{
            //    ADO.sda = new SqlDataAdapter("select Id from BonReception", ADO.con);
            //    DataTable CheckIdent = new DataTable();
            //    ADO.sda.Fill(CheckIdent);
            //    if (CheckIdent.Rows[0][0].ToString().Equals("0"))
            //    {
            //        ADO.sda = new SqlDataAdapter("select ('BR-' + CAST(IDENT_CURRENT('BonReception') + 1 as nvarchar(max))) as 'Référence'", ADO.con);
            //        DataTable table = new DataTable();
            //        ADO.sda.Fill(table);
            //        ADO.Deconnecter();
            //        if (table.Rows.Count == 1)
            //        {
            //            Reference = table.Rows[0][0].ToString();
            //        }
            //    }
            //}
            //else
            //{
            //    ADO.sda = new SqlDataAdapter("select ('BR-' + CAST(IDENT_CURRENT('BonReception') + 1 as nvarchar(max))) as 'Référence'", ADO.con);
            //    DataTable table = new DataTable();
            //    ADO.sda.Fill(table);
            //    ADO.Deconnecter();
            //    if (table.Rows.Count == 1)
            //    {
            //        Reference = table.Rows[0][0].ToString();
            //    }
            //}

            return Reference;
        }

        public string IdBonReception()
        {
            ADO.Connecter();

            string Reference = "";
            ADO.sda = new SqlDataAdapter("select ISNULL(MAX(Id),0) + 1 as 'Référence' from BonReception", ADO.con);
            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            ADO.Deconnecter();
            if (table.Rows.Count == 1)
            {
                Reference = table.Rows[0][0].ToString();
            }

            //ADO.sda = new SqlDataAdapter("select Id from BonReception", ADO.con);
            //DataTable data = new DataTable();
            //ADO.sda.Fill(data);
            //ADO.Deconnecter();
            //if (data.Rows.Count == 0)
            //{
            //    ADO.sda = new SqlDataAdapter("select IDENT_CURRENT('BonReception') + 1 as 'Référence'", ADO.con);
            //    DataTable table = new DataTable();
            //    ADO.sda.Fill(table);
            //    ADO.Deconnecter();
            //    if (table.Rows.Count == 1)
            //    {
            //        Reference = table.Rows[0][0].ToString();
            //    }
            //}
            //else
            //{
            //    ADO.sda = new SqlDataAdapter("select IDENT_CURRENT('BonReception') as 'Référence'", ADO.con);
            //    DataTable table = new DataTable();
            //    ADO.sda.Fill(table);
            //    ADO.Deconnecter();
            //    if (table.Rows.Count == 1)
            //    {
            //        Reference = table.Rows[0][0].ToString();
            //    }
            //}

            return Reference;
        }

        public string IdDetailBonReception()
        {
            ADO.Connecter();

            string IdDetail = "";

            ADO.sda = new SqlDataAdapter("select ISNULL(IDENT_CURRENT('DetailsBonReception'),0) + 1 as 'Id Detail'", ADO.con);
            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            ADO.Deconnecter();
            if (table.Rows.Count == 1)
            {
                IdDetail = table.Rows[0][0].ToString();
            }

            return IdDetail;
        }

        public void Totals()
        {
            try
            {
                if (DGVDetailsBR.Rows.Count > 0)
                {
                    decimal Price = 0;

                    for (int i = 0; i < DGVDetailsBR.Rows.Count; i++)
                    {
                        Price += Convert.ToDecimal(DGVDetailsBR.Rows[i].Cells[5].Value.ToString());
                    }

                    if (Price > 0)
                        LblMontantCommande.Text = Price.ToString("#.00");
                    else
                        LblMontantCommande.Text = "0.00";
                }
                else
                {
                    LblMontantCommande.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AfficherProduits()
        {
            try
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("GetListOfProductsByIdCategorie", ADO.con);
                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCategorie", CmbCategorie.SelectedValue);
                tableProduits.Clear();
                ADO.sda.Fill(tableProduits);
                DGVProduits.DataSource = tableProduits;
                DGVProduits.Columns[0].Visible = false;
                DGVProduits.Columns[1].Width = 400;

                if (DGVProduits.Rows.Count == 0)
                {
                    System.Data.DataTable dd = new System.Data.DataTable();
                    dd.Columns.Add("Message");
                    dd.Rows.Add("Pas de données !");
                    DGVProduits.DataSource = dd;
                    DGVProduits.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAjouterProduit_Click(object sender, EventArgs e)
        {
            GroupBoxListeProduits.Visible = true;
            ADO.RemplirCombo("GetCategorieIdAndName", CmbCategorie, "Nom_Categorie", "Id_Categorie", "", "Choisir la catégorie");
            AfficherProduits();
            GroupBoxListeProduits.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BonReception_Load(object sender, EventArgs e)
        {
            ADO.RemplirCombo("GetFournisseurCINAndName", CmbFournisseur, "NomComplet", "CIN", "", "Choisir le fournisseur");
            if (ListeBonReception.Type.Equals("Edit"))
            {
                BtnPayerCredit.Enabled = BtnPayerDirect.Enabled = BtnPayerPartie.Enabled = false;
                TxtReference.Text = ListeBonReception.ReferenceBon;
                DPDateBR.Value = ListeBonReception.DateBon;
                CmbFournisseur.Text = ListeBonReception.Fournisseur;
                LblMontantCommande.Text = ListeBonReception.Total;
                foreach (DataRow row in ListeBonReception.DetailsBon.Rows)
                {
                    DGVDetailsBR.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                }
            }
            else
            {
                BtnPayerCredit.Enabled = BtnPayerDirect.Enabled = BtnPayerPartie.Enabled = true;
                DPDateBR.Value = DateTime.Now;
                TxtReference.Text = ReferenceBonReception();
            }

            Totals();

            this.Dock = DockStyle.Fill;
        }

        private void BtnCloseListeProduits_Click(object sender, EventArgs e)
        {
            GroupBoxListeProduits.Visible = false;
        }

        private void CmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherProduits();
        }

        private void DGVProduits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVProduits.Columns.Count > 1)
            {
                PnlAjouterQuantite.Visible = true;
                TxtNomProduit.Text = DGVProduits.SelectedRows[0].Cells[1].Value.ToString();
                TxtPrixProduit.Text = DGVProduits.SelectedRows[0].Cells[2].Value.ToString();
                string IdProduit = ADO.IdProduitByNom(TxtNomProduit.Text);
                TxtPrixTotal.Text = TxtPrixProduit.Text = ADO.PrixProduitById(int.Parse(IdProduit));
                PnlAjouterQuantite.BringToFront();
                TxtQuantite.Focus();
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            TxtQuantite.Text = "1.00";
            NumberPickerQuantite.Value = 1;
            PnlAjouterQuantite.Visible = false;
        }

        private void BtnAjouterBR_Click(object sender, EventArgs e)
        {
            if (double.Parse(TxtPrixProduit.Text) > 0)
            {
                string IdDetail = IdDetailBonReception();
                string IdBon = ListeBonReception.IdBon;
                string IdProduit = ADO.IdProduitByNom(TxtNomProduit.Text);
                string Produit = TxtNomProduit.Text;
                string Quantite = TxtQuantite.Text;
                string Prix = TxtPrixProduit.Text;

                if (ListeBonReception.Type.Equals("Create"))
                {
                    string Montant = TxtPrixTotal.Text;
                    DGVDetailsBR.Rows.Add(IdDetail, IdProduit, Produit, Quantite, Prix, Montant);
                    DGVDetailsBR.Columns[2].Width = 300;
                    TxtQuantite.Text = "1.00";
                    NumberPickerQuantite.Value = 1;
                    PnlAjouterQuantite.Visible = false;
                    DGVDetailsBR.ClearSelection();
                    Totals();
                }
                else
                {
                    string Montant = TxtPrixTotal.Text;
                    dataTableAdd.Columns.Add("IdBon", typeof(string));
                    dataTableAdd.Columns.Add("IdProduit", typeof(string));
                    dataTableAdd.Columns.Add("Quantite", typeof(string));
                    dataTableAdd.Columns.Add("Prix", typeof(string));
                    dataTableAdd.Columns.Add("Montant", typeof(string));

                    dataTableAdd.Rows.Add(IdBon, IdProduit, Quantite, Prix, Montant);

                    DGVDetailsBR.Rows.Add(IdDetail, IdProduit, Produit, Quantite, Prix, Montant);
                    DGVDetailsBR.Columns[2].Width = 300;
                    TxtQuantite.Text = "1.00";
                    NumberPickerQuantite.Value = 1;
                    PnlAjouterQuantite.Visible = false;
                    DGVDetailsBR.ClearSelection();
                    Totals();
                }
            }
        }

        private void TxtQuantite_TextChanged(object sender, EventArgs e)
        {
            if (TxtQuantite.Text != "")
            {
                TxtPrixTotal.Text = (decimal.Parse(TxtPrixProduit.Text) * decimal.Parse(TxtQuantite.Text)).ToString("#.00");
            }
            else
            {
                TxtPrixTotal.Text = "0.00";
            }
        }

        private void TxtQuantite_Leave(object sender, EventArgs e)
        {
            if (TxtQuantite.Text == "" || decimal.Parse(TxtQuantite.Text) <= 0)
                TxtQuantite.Text = "1.00";
        }

        private void DGVDetailsBR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int rowIndex = DGVDetailsBR.SelectedRows[0].Index;
                DialogResult dr = (MessageBox.Show("Voulez-vous vraiment supprimer ce produit ?", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
                if (dr == DialogResult.Yes)
                {
                    if (ListeBonReception.Type.Equals("Edit"))
                    {
                        // Add columns
                        dataTableDelete.Columns.Add("IdDetail", typeof(string));
                        dataTableDelete.Columns.Add("Montant", typeof(string));

                        dataTableDelete.Rows.Add(DGVDetailsBR.SelectedRows[0].Cells[0].Value.ToString(), DGVDetailsBR.SelectedRows[0].Cells[5].Value.ToString());
                    }
                    DGVDetailsBR.Rows.RemoveAt(rowIndex);
                    MessageBox.Show("Produit est bien supprimer dans cette commande !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Totals();
                }
                else
                {
                    MessageBox.Show("Opération de suppression pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DGVDetailsBR.ClearSelection();
            }
            else if (e.ColumnIndex == 7)
            {
                MessageBox.Show("Hi !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            if (TxtRechercherProduit.Width == 0)
                TxtRechercherProduit.Width = 220;
            else
                TxtRechercherProduit.Width = 0;
        }

        private void TxtRechercherProduit_TextChanged(object sender, EventArgs e)
        {
            if (DGVProduits.Columns.Count > 1)
            {
                try
                {
                    DataView dataView = new DataView(tableProduits);
                    dataView.RowFilter = string.Format("Produit like '%{0}%'", TxtRechercherProduit.Text);
                    DGVProduits.DataSource = dataView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void NumberPickerQuantite_ValueChanged(object sender, EventArgs e)
        {
            TxtQuantite.Text = NumberPickerQuantite.Value.ToString("#.00");
        }

        private void BtnPayerCredit_Click(object sender, EventArgs e)
        {
            if (CmbFournisseur.SelectedIndex != 0 && DGVDetailsBR.Rows.Count > 0)
            {
                string IdBonR = IdBonReception();

                ADO.Connecter();

                ADO.cmd = new SqlCommand("insert into BonReception values(@Id,@Date,@CIN,@Total,@MontantPayer,@MontantRest)", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Id", IdBonR);
                ADO.cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(DPDateBR.Value.ToString()));
                ADO.cmd.Parameters.AddWithValue("@CIN", CmbFournisseur.SelectedValue);
                ADO.cmd.Parameters.AddWithValue("@Total", LblMontantCommande.Text);
                ADO.cmd.Parameters.AddWithValue("@MontantPayer", 0);
                ADO.cmd.Parameters.AddWithValue("@MontantRest", LblMontantCommande.Text);
                ADO.cmd.ExecuteNonQuery();

                ADO.Deconnecter();

                if (CheckIsInBalance())
                {
                    ADO.Connecter();

                    ADO.cmd = new SqlCommand("update Balance set Credit+=@Credit where CIN=@CIN", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@CIN", CmbFournisseur.SelectedValue);
                    ADO.cmd.Parameters.AddWithValue("@Credit", LblMontantCommande.Text);
                    ADO.cmd.ExecuteNonQuery();

                    ADO.Deconnecter();
                }
                else
                {
                    ADO.Connecter();

                    ADO.cmd = new SqlCommand("insert into Balance values(@CIN,@Debit,@Credit)", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@CIN", CmbFournisseur.SelectedValue);
                    ADO.cmd.Parameters.AddWithValue("@Debit", 0);
                    ADO.cmd.Parameters.AddWithValue("@Credit", LblMontantCommande.Text);
                    ADO.cmd.ExecuteNonQuery();

                    ADO.Deconnecter();
                }

                ADO.Connecter();

                foreach (DataGridViewRow row in DGVDetailsBR.Rows)
                {
                    ADO.cmd = new SqlCommand("insert into DetailsBonReception values(@IdBon,@IdProduit,@Quantite,@Prix)", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@IdBon", IdBonR);
                    ADO.cmd.Parameters.AddWithValue("@IdProduit", row.Cells[1].Value.ToString());
                    ADO.cmd.Parameters.AddWithValue("@Quantite", row.Cells[3].Value.ToString());
                    ADO.cmd.Parameters.AddWithValue("@Prix", row.Cells[4].Value.ToString());
                    ADO.cmd.ExecuteNonQuery();
                }

                ADO.Deconnecter();

                DPDateBR.Value = DateTime.Now;
                CmbFournisseur.SelectedIndex = 0;
                TxtReference.Text = ReferenceBonReception();
                DGVDetailsBR.Rows.Clear();
                DGVDetailsBR.DataSource = null;
                Totals();

                MessageBox.Show("Bon de récéption est bien valider !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //if (CmbFournisseur.SelectedIndex != 0 && DGVDetailsBR.Rows.Count > 0)
            //{
            //    using (SqlConnection con=new SqlConnection(ADO.ConnectionString))
            //    {
            //        string IdBonR = IdBonReception();

            //        con.Open();

            //        //SqlTransaction transaction = con.BeginTransaction();

            //        try
            //        {
            //            using (SqlCommand cmd = new SqlCommand("insert into BonReception values(@Date,@CIN,@Total,@MontantPayer,@MontantRest)", con))
            //            {
            //                // ... Set parameters and execute the command
            //                cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(DPDateBR.Value.ToString()));
            //                cmd.Parameters.AddWithValue("@CIN", CmbFournisseur.SelectedValue);
            //                cmd.Parameters.AddWithValue("@Total", LblMontantCommande.Text);
            //                cmd.Parameters.AddWithValue("@MontantPayer", 0);
            //                cmd.Parameters.AddWithValue("@MontantRest", LblMontantCommande.Text);
            //                cmd.ExecuteNonQuery();
            //            }

            //            if (CheckIsInBalance())
            //            {
            //                using (SqlCommand cmd = new SqlCommand("update Balance set Credit+=@Credit where CIN=@CIN", con))
            //                {
            //                    // ... Set parameters and execute the command
            //                    cmd.Parameters.AddWithValue("@CIN", CmbFournisseur.SelectedValue);
            //                    cmd.Parameters.AddWithValue("@Credit", LblMontantCommande.Text);
            //                    cmd.ExecuteNonQuery();
            //                }
            //            }
            //            else
            //            {
            //                using (SqlCommand cmd = new SqlCommand("insert into Balance values(@CIN,@Debit,@Credit)", con))
            //                {
            //                    // ... Set parameters and execute the command
            //                    cmd.Parameters.AddWithValue("@CIN", CmbFournisseur.SelectedValue);
            //                    cmd.Parameters.AddWithValue("@Debit", 0);
            //                    cmd.Parameters.AddWithValue("@Credit", LblMontantCommande.Text);
            //                    cmd.ExecuteNonQuery();
            //                }
            //            }

            //            // Commit the transaction if all operations succeeded
            //            //transaction.Commit();

            //            using (SqlCommand cmd = new SqlCommand("insert into DetailsBonReception values(@IdBon,@IdProduit,@Quantite,@Prix)", con))
            //            {
            //                foreach (DataGridViewRow row in DGVDetailsBR.Rows)
            //                {
            //                    // ... Set parameters and execute the command
            //                    cmd.Parameters.AddWithValue("@IdBon", IdBonR);
            //                    cmd.Parameters.AddWithValue("@IdProduit", row.Cells[1].Value.ToString());
            //                    cmd.Parameters.AddWithValue("@Quantite", row.Cells[3].Value.ToString());
            //                    cmd.Parameters.AddWithValue("@Prix", row.Cells[4].Value.ToString());
            //                    cmd.ExecuteNonQuery();
            //                }
            //            }

            //            DPDateBR.Value = DateTime.Now;
            //            CmbFournisseur.SelectedIndex = 0;
            //            TxtReference.Text = ReferenceBonReception();
            //            DGVDetailsBR.Rows.Clear();
            //            DGVDetailsBR.DataSource = null;
            //            Totals();

            //            MessageBox.Show("Bon de récéption est bien valider !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        catch (Exception ex)
            //        {
            //            // Roll back the transaction if an error occurs
            //            // Handle the exception here
            //            MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //}
        }

        private void BtnPayerPartie_Click(object sender, EventArgs e)
        {
            if (!LblMontant.Visible)
                LblMontant.Visible = TxtMontantPayerEnPartie.Visible = true;
            else
                LblMontant.Visible = TxtMontantPayerEnPartie.Visible = false;
        }

        private void BtnPayerDirect_Click(object sender, EventArgs e)
        {

        }

        private void BtnValiderCommande_Click(object sender, EventArgs e)
        {
            if (ListeBonReception.Type.Equals("Edit"))
            {
                string IdBonR = ListeBonReception.IdBon;

                double MontantOld = double.Parse(ListeBonReception.Total);
                double MontantNew = double.Parse(LblMontantCommande.Text);
                string UpdatedMontant = "";

                if (MontantNew > MontantOld)
                {
                    UpdatedMontant = (MontantNew - MontantOld).ToString();
                }
                else if (MontantNew < MontantOld)
                {
                    UpdatedMontant = (MontantOld - MontantNew).ToString();
                }
                else if (MontantNew == MontantOld)
                {
                    UpdatedMontant = "0.00";
                }

                //ADO.Connecter();

                //ADO.cmd = new SqlCommand("update BonReception set Date=@Date,CIN=@CIN,Total=@Total,MontantRest+=@MontantRest where Id=@Id", ADO.con);
                //ADO.cmd.Parameters.AddWithValue("@Id", IdBonR);
                //ADO.cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(DPDateBR.Value.ToString()));
                //ADO.cmd.Parameters.AddWithValue("@CIN", CmbFournisseur.SelectedValue);
                //ADO.cmd.Parameters.AddWithValue("@Total", LblMontantCommande.Text);
                //if (!UpdatedMontant.Equals("0.00"))
                //{
                //    ADO.cmd.Parameters.AddWithValue("@MontantRest", UpdatedMontant);
                //}
                //else
                //{
                //    ADO.cmd.Parameters.AddWithValue("@MontantRest", 0);
                //}
                //ADO.cmd.ExecuteNonQuery();

                //ADO.Deconnecter();

                if (dataTableDelete.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTableDelete.Rows)
                    {
                        string IdDetail = row[0].ToString();
                        string MontantDetail = row[1].ToString();

                        //ADO.Connecter();

                        //ADO.cmd = new SqlCommand("update BonReception set Total-=@Total,MontantRest-=@MontantRest where Id=@Id", ADO.con);
                        //ADO.cmd.Parameters.AddWithValue("@Id", ListeBonReception.IdBon);
                        //ADO.cmd.Parameters.AddWithValue("@Total", MontantDetail);
                        //ADO.cmd.Parameters.AddWithValue("@MontantRest", MontantDetail);
                        //ADO.cmd.ExecuteNonQuery();

                        //ADO.Deconnecter();

                        ADO.Connecter();

                        ADO.cmd = new SqlCommand("delete from DetailsBonReception where IdDetail=@IdDetail", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@IdDetail", IdDetail);
                        ADO.cmd.ExecuteNonQuery();

                        ADO.Deconnecter();
                    }
                }
                if (dataTableDelete.Rows.Count > 0)
                    dataTableDelete.Rows.Clear();

                if (dataTableAdd.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTableAdd.Rows)
                    {
                        ADO.Connecter();

                        ADO.cmd = new SqlCommand("insert into DetailsBonReception values(@IdBon,@IdProduit,@Quantite,@Prix)", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@IdBon", row[0].ToString());
                        ADO.cmd.Parameters.AddWithValue("@IdProduit", row[1].ToString());
                        ADO.cmd.Parameters.AddWithValue("@Quantite", row[2].ToString());
                        ADO.cmd.Parameters.AddWithValue("@Prix", row[3].ToString());
                        ADO.cmd.ExecuteNonQuery();

                        ADO.Deconnecter();
                    }
                }
                if (dataTableAdd.Rows.Count > 0)
                    dataTableAdd.Rows.Clear();
            }

            Form1.GeneralInstance.PnlParametrage.Visible = false;
            Form1.GeneralInstance.BtnHideOrShowSideBar.Enabled = false;
            Form1.GeneralInstance.SideBar.Visible = false;
            Form1.GeneralInstance.PnlAffichage.Controls.Clear();
            Form1.GeneralInstance.PnlAffichage.Controls.Add(new User_Controls.ListeBonReception());
        }
    }
}
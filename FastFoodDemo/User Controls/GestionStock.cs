using FastFoodDemo.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FastFoodDemo.User_Controls
{
    public partial class GestionStock : UserControl
    {
        public static GestionStock GestionStockInstance;

        public static GestionStock Instance
        {
            get
            {
                if (GestionStockInstance == null)
                {
                    GestionStockInstance = new GestionStock();
                }
                return GestionStockInstance;
            }
        }

        public GestionStock()
        {
            InitializeComponent();
            GestionStockInstance = this;
        }

        readonly ADO ADO = new ADO();

        public void ListeProduitsEnStock()
        {
            ADO.Connecter();

            ADO.sda = new SqlDataAdapter("ListeProduitEnStock", ADO.con);
            ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            if (table.Rows.Count > 0)
            {
                DGVListeProduitsEnStock.DataSource = table;
                DGVListeProduitsEnStock.Columns[0].Visible = false;
                DGVListeProduitsEnStock.Columns[1].Width = 150;
                DGVListeProduitsEnStock.Columns[1].ReadOnly = true;
                DGVListeProduitsEnStock.Columns[2].ReadOnly = false;
                DGVListeProduitsEnStock.Columns[3].ReadOnly = true;
                DGVListeProduitsEnStock.Columns[4].ReadOnly = true;
                DGVListeProduitsEnStock.Columns[5].ReadOnly = true;
            }
            else
            {
                DataTable dd = new DataTable();
                //DGVListeImprimantes.Width = 140;
                //DGVListeImprimantes.Height = 90;
                dd.Columns.Add("Message");
                //dd.Columns.Add("Nom");
                dd.Rows.Add("Pas de données !");
                DGVListeProduitsEnStock.DataSource = dd;
                DGVListeProduitsEnStock.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
            }

            ADO.Deconnecter();
        }

        private void GestionStock_Load(object sender, EventArgs e)
        {
            ListeProduitsEnStock();

            ADO.RemplirCombo("GetCategorieIdAndName", CmbCategories, "Nom_Categorie", "Id_Categorie", "Vide");

            TxtQuantiteAjouter.Focus();

            GroupBoxCategorie.Width = guna2GroupBox1.Width = Form1.GeneralInstance.PnlAffichage.Width - 25;

            this.Dock = DockStyle.Fill;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (CmbCategories.Text != "")
            {
                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("select Id_Produit from Produit where Id_CategorieProduit=@Id_CategorieProduit", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_CategorieProduit", CmbCategories.SelectedValue);
                DataTable tableProduits = new DataTable();
                ADO.sda.Fill(tableProduits);
                if (tableProduits.Rows.Count > 0)
                {
                    ADO.sda = new SqlDataAdapter("select Id_Produit from ProduitEnStock", ADO.con);
                    DataTable tableProduitsStock = new DataTable();
                    ADO.sda.Fill(tableProduitsStock);
                    if (tableProduitsStock.Rows.Count > 0)
                    {
                        bool Find = false;
                        foreach (DataRow produit in tableProduits.Rows)
                        {
                            foreach (DataRow produitEnStock in tableProduitsStock.Rows)
                            {
                                if (produit[0].ToString() == produitEnStock[0].ToString())
                                {
                                    Find = true;
                                    break;
                                }
                                //else
                                //{
                                //    MessageBox.Show("Ooops !");
                                //}
                            }
                            if (!Find)
                            {
                                ADO.cmd = new SqlCommand("insert into ProduitEnStock values(@Id_Produit,@Stock_Alert,@Stock_Initial,@Stock_Entree,@Stock_Sortie)", ADO.con);
                                ADO.cmd.Parameters.AddWithValue("@Id_Produit", produit[0].ToString());
                                ADO.cmd.Parameters.AddWithValue("@Stock_Alert", 0);
                                ADO.cmd.Parameters.AddWithValue("@Stock_Initial", 0);
                                ADO.cmd.Parameters.AddWithValue("@Stock_Entree", 0);
                                ADO.cmd.Parameters.AddWithValue("@Stock_Sortie", 0);
                                ADO.cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        foreach (DataRow produit in tableProduits.Rows)
                        {
                            //MessageBox.Show(produit[0].ToString());

                            ADO.cmd = new SqlCommand("insert into ProduitEnStock values(@Id_Produit,@Stock_Alert,@Stock_Initial,@Stock_Entree,@Stock_Sortie)", ADO.con);
                            ADO.cmd.Parameters.AddWithValue("@Id_Produit", produit[0].ToString());
                            ADO.cmd.Parameters.AddWithValue("@Stock_Alert", 0);
                            ADO.cmd.Parameters.AddWithValue("@Stock_Initial", 0);
                            ADO.cmd.Parameters.AddWithValue("@Stock_Entree", 0);
                            ADO.cmd.Parameters.AddWithValue("@Stock_Sortie", 0);
                            ADO.cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            ADO.Deconnecter();

            ListeProduitsEnStock();
        }

        private void DGVListeProduitsEnStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVListeProduitsEnStock.SelectedRows.Count == 1)
            {
                TxtNom.Text = DGVListeProduitsEnStock.SelectedRows[0].Cells[1].Value.ToString();
                TxtQuantiteDisponible.Text = DGVListeProduitsEnStock.SelectedRows[0].Cells[5].Value.ToString();
                TxtQuantiteAjouter.Text = "0.00";
                TxtQuantiteAjouter.Focus();
            }
        }

        private void TxtQuantiteAjouter_TextChanged(object sender, EventArgs e)
        {
            if (TxtQuantiteAjouter.Text != "")
            {
                decimal QteAjouter = decimal.Parse(TxtQuantiteAjouter.Text);
                decimal QteDisponible = decimal.Parse(DGVListeProduitsEnStock.SelectedRows[0].Cells[5].Value.ToString());
                TxtQuantiteDisponible.Text = (QteDisponible + QteAjouter).ToString();
            }
            else
            {
                TxtQuantiteDisponible.Text = DGVListeProduitsEnStock.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (TxtQuantiteAjouter.Text != "")
            {
                decimal StockEntree = decimal.Parse(TxtQuantiteAjouter.Text);

                if (StockEntree > 0)
                {
                    ADO.Connecter();

                    ADO.cmd = new SqlCommand("update ProduitEnStock set Stock_Entree+=@Stock_Entree where Id_Produit=@Id_Produit", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Stock_Entree", StockEntree);
                    ADO.cmd.Parameters.AddWithValue("@Id_Produit", DGVListeProduitsEnStock.SelectedRows[0].Cells[0].Value.ToString());
                    ADO.cmd.ExecuteNonQuery();

                    ADO.Deconnecter();

                    ListeProduitsEnStock();

                    MessageBox.Show("Quantité est bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        decimal StockInitial = 0;
        decimal StockInitialOld = 0;

        private void DGVListeProduitsEnStock_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVListeProduitsEnStock.SelectedRows[0].Cells[2].Value.ToString() != "")
            {
                StockInitial = decimal.Parse(DGVListeProduitsEnStock.SelectedRows[0].Cells[2].Value.ToString());
                StockInitialOld = StockInitial;

                if (StockInitial > 0)
                {
                    ADO.Connecter();

                    ADO.cmd = new SqlCommand("update ProduitEnStock set Stock_Initial=@Stock_Initial where Id_Produit=@Id_Produit", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Stock_Initial", StockInitial);
                    ADO.cmd.Parameters.AddWithValue("@Id_Produit", DGVListeProduitsEnStock.SelectedRows[0].Cells[0].Value.ToString());
                    ADO.cmd.ExecuteNonQuery();

                    ADO.Deconnecter();

                    ListeProduitsEnStock();
                }
                else
                {
                    MessageBox.Show("Eror !");
                }
            }
            else
            {
                DGVListeProduitsEnStock.SelectedRows[0].Cells[1].Value = StockInitialOld;
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (DGVListeProduitsEnStock.SelectedRows.Count >= 1)
            {
                if (DGVListeProduitsEnStock.SelectedRows.Count == 1)
                {
                    ADO.Connecter();

                    ADO.cmd = new SqlCommand("delete from ProduitEnStock where Id_Produit=@Id_Produit", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Id_Produit", DGVListeProduitsEnStock.SelectedRows[0].Cells[0].Value.ToString());
                    ADO.cmd.ExecuteNonQuery();

                    ADO.Deconnecter();

                    MessageBox.Show("Le produit " + DGVListeProduitsEnStock.SelectedRows[0].Cells[1].Value.ToString() + " est bien supprimer dans le stock !", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (DGVListeProduitsEnStock.SelectedRows.Count > 1)
                {
                    ADO.Connecter();

                    foreach (DataGridViewRow row in DGVListeProduitsEnStock.SelectedRows)
                    {
                        ADO.cmd = new SqlCommand("delete from ProduitEnStock where Id_Produit=@Id_Produit", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@Id_Produit", row.Cells[0].Value.ToString());
                        ADO.cmd.ExecuteNonQuery();
                    }

                    ADO.Deconnecter();

                    MessageBox.Show("Tout les produits séléctionnées sont bien supprimer dans le stock !", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (DGVListeProduitsEnStock.SelectedRows.Count >= 1)
            {
                //if (DGVListeProduitsEnStock.SelectedRows.Count == 1)
                //{
                //    ADO.Connecter();

                //    ADO.cmd = new SqlCommand("update ProduitEnStock set Stock_Initial=0,Stock_Alert=0,Stock_Entree=0,Stock_Sortie=0 where Id_Produit=@Id_Produit", ADO.con);
                //    ADO.cmd.Parameters.AddWithValue("@Id_Produit", DGVListeProduitsEnStock.SelectedRows[0].Cells[0].Value.ToString());
                //    ADO.cmd.ExecuteNonQuery();

                //    ADO.Deconnecter();

                //    MessageBox.Show("Le produit " + DGVListeProduitsEnStock.SelectedRows[0].Cells[1].Value.ToString() + " est bien supprimer dans le stock !", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                if (DGVListeProduitsEnStock.SelectedRows.Count > 1)
                {
                    //ADO.Connecter();

                    foreach (DataGridViewRow row in DGVListeProduitsEnStock.SelectedRows)
                    {
                        //ADO.cmd = new SqlCommand("update ProduitEnStock set Stock_Initial=0,Stock_Alert=0,Stock_Entree=0,Stock_Sortie=0 where Id_Produit=@Id_Produit", ADO.con);
                        //ADO.cmd.Parameters.AddWithValue("@Id_Produit", row.Cells[0].Value.ToString());
                        //ADO.cmd.ExecuteNonQuery();
                        MessageBox.Show(row.Cells[1].Value.ToString(), "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //ADO.Deconnecter();

                    MessageBox.Show("Tout les produits séléctionnées sont bien supprimer dans le stock !", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DGVListeProduitsEnStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in DGVListeProduitsEnStock.Rows)
            {
                if (Convert.ToInt32(row.Cells[2].Value) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }
    }
}
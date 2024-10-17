using FastFoodDemo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodDemo.Forms;

namespace FastFoodDemo.User_Controls
{
    public partial class ListeBonReception : UserControl
    {
        public ListeBonReception()
        {
            InitializeComponent();
        }

        ADO ADO = new ADO();

        public static string Type;
        public static string IdBon;
        public static string ReferenceBon;
        public static DateTime DateBon;
        public static string Fournisseur;
        public static string Total;
        public static DataTable DetailsBon;

        DataTable tableBonReception = new DataTable();

        public DataTable GetDetailsBonById(string id)
        {
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(ADO.ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("GetListOfDetailsBonReceptionById", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            sda.Fill(table);
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Handle the exception in the calling code
                throw;
            }

            return table;
        }

        public void ListBonReception()
        {
            try
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("GetListOfBonReception", ADO.con);
                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                tableBonReception.Clear();
                ADO.sda.Fill(tableBonReception);
                DGVBonReception.DataSource = tableBonReception;
                DGVBonReception.Columns[0].Visible = false;
                //DGVBonReception.Columns[1].Width = 400;

                if (DGVBonReception.Rows.Count == 0)
                {
                    System.Data.DataTable dd = new System.Data.DataTable();
                    dd.Columns.Add("Message");
                    dd.Rows.Add("Pas de données !");
                    DGVBonReception.DataSource = dd;
                    DGVBonReception.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            Type = "Create";
            Form1.GeneralInstance.PnlParametrage.Visible = false;
            Form1.GeneralInstance.BtnHideOrShowSideBar.Enabled = false;
            Form1.GeneralInstance.SideBar.Visible = false;
            Form1.GeneralInstance.PnlAffichage.Controls.Clear();
            Form1.GeneralInstance.PnlAffichage.Controls.Add(new User_Controls.BonReception());
        }

        private void BtnPayerCredit_Click(object sender, EventArgs e)
        {

        }

        private void ListeBonReception_Load(object sender, EventArgs e)
        {
            ListBonReception();
            DGVBonReception.ClearSelection();
            this.Dock = DockStyle.Fill;
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            TxtRechercherProduit.Focus();

            if (TxtRechercherProduit.Width == 0)
                TxtRechercherProduit.Width = 220;
            else
                TxtRechercherProduit.Width = 0;
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (DGVBonReception.SelectedRows.Count == 1)
            {
                Type = "Edit";
                IdBon = DGVBonReception.SelectedRows[0].Cells[0].Value.ToString();
                ReferenceBon = DGVBonReception.SelectedRows[0].Cells[1].Value.ToString();
                DateBon = Convert.ToDateTime(DGVBonReception.SelectedRows[0].Cells[2].Value.ToString());
                Fournisseur = DGVBonReception.SelectedRows[0].Cells[3].Value.ToString();
                Total = DGVBonReception.SelectedRows[0].Cells[4].Value.ToString();
                DetailsBon = GetDetailsBonById(DGVBonReception.SelectedRows[0].Cells[0].Value.ToString());

                Form1.GeneralInstance.PnlParametrage.Visible = false;
                Form1.GeneralInstance.BtnHideOrShowSideBar.Enabled = false;
                Form1.GeneralInstance.SideBar.Visible = false;
                Form1.GeneralInstance.PnlAffichage.Controls.Clear();
                Form1.GeneralInstance.PnlAffichage.Controls.Add(new User_Controls.BonReception());
            }
        }
    }
}

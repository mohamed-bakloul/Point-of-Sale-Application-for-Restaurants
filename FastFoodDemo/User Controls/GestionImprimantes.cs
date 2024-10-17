using FastFoodDemo.Classes;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace FastFoodDemo.User_Controls
{
    public partial class GestionImprimantes : UserControl
    {
        public static GestionImprimantes GestionImprimantesInstance;

        public static GestionImprimantes Instance
        {
            get
            {
                if (GestionImprimantesInstance == null)
                {
                    GestionImprimantesInstance = new GestionImprimantes();
                }
                return GestionImprimantesInstance;
            }
        }

        public GestionImprimantes()
        {
            InitializeComponent();
            GestionImprimantesInstance = this;
        }

        readonly ADO ADO = new ADO();

        public void ListeImprimantes()
        {
            ADO.Connecter();

            ADO.sda = new SqlDataAdapter("ListeImprimantes", ADO.con);
            ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            if (table.Rows.Count > 0)
            {
                DGVListeImprimantes.DataSource = table;
            }
            else
            {
                DataTable dd = new DataTable();
                //DGVListeImprimantes.Width = 140;
                //DGVListeImprimantes.Height = 90;
                dd.Columns.Add("Message");
                //dd.Columns.Add("Nom");
                dd.Rows.Add("Pas de données !");
                DGVListeImprimantes.DataSource = dd;
                DGVListeImprimantes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            ADO.Deconnecter();
        }

        public void ListeImprimanteParCategories()
        {
            ADO.Connecter();

            ADO.sda = new SqlDataAdapter("ListeImprimanteParCategories", ADO.con);
            ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            if (table.Rows.Count > 0)
            {
                DGVListeImprimanteParCategories.DataSource = table;
            }
            else
            {
                DataTable dd = new DataTable();
                //DGVListeImprimantes.Width = 140;
                //DGVListeImprimantes.Height = 90;
                dd.Columns.Add("Message");
                //dd.Columns.Add("Nom");
                dd.Rows.Add("Pas de données !");
                DGVListeImprimanteParCategories.DataSource = dd;
                DGVListeImprimanteParCategories.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
            }

            ADO.Deconnecter();
        }

        public void UpdateDisponibleImprimante(string Id)
        {
            ADO.Connecter();

            ADO.cmd = new SqlCommand("update Imprimante_Disponible set Disponible=1 where Id_Imprimante=@Id", ADO.con);
            ADO.cmd.Parameters.AddWithValue("@Id", Id);
            ADO.cmd.ExecuteNonQuery();

            ADO.Deconnecter();
        }

        private void GestionImprimantes_Load(object sender, EventArgs e)
        {
            ADO.RemplirCombo("GetCategorieIdAndName", CmbCategories, "Nom_Categorie", "Id_Categorie", "Vide");
            ADO.RemplirCombo("GetImprimanteIdAndName", CmbImprimantes, "Nom_Imprimante", "Id_Imprimante", "Vide");
            ADO.RemplirCombo("GetImprimanteDisponibleId", CmbEmplacement, "Id_Imprimante", "Id_Imprimante", "Vide");

            if (CmbEmplacement.Items.Count == 0)
                CmbEmplacement.Enabled = BtnAjouter.Enabled = BtnModifier.Enabled = TxtNom.Enabled = false;
            if (CmbImprimantes.Items.Count == 0)
                CmbImprimantes.Enabled = false;
            if (CmbCategories.Items.Count == 0)
                CmbCategories.Enabled = false;

            ListeImprimantes();
            ListeImprimanteParCategories();

            TxtNom.Focus();

            GroupBoxCategorie.Width = guna2GroupBox1.Width = Form1.GeneralInstance.PnlAffichage.Width - 25;

            this.Dock = DockStyle.Fill;
        }

        private void DGVListeImprimantes_Paint(object sender, PaintEventArgs e)
        {
            if (DGVListeImprimantes.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "No records found !",
                    DGVListeImprimantes.Font, DGVListeImprimantes.ClientRectangle,
                    DGVListeImprimantes.ForeColor, DGVListeImprimantes.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (TxtNom.Text != "")
            {
                ADO.Connecter();
                ADO.cmd = new SqlCommand("insert into Imprimante values(@Id,@Nom)", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Id", CmbEmplacement.Text);
                ADO.cmd.Parameters.AddWithValue("@Nom", TxtNom.Text);
                ADO.cmd.ExecuteNonQuery();
                ADO.Deconnecter();

                UpdateDisponibleImprimante(CmbEmplacement.Text);

                MessageBox.Show("Imprimante est bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtNom.Clear();
                TxtNom.Focus();

                ADO.RemplirCombo("GetImprimanteIdAndName", CmbImprimantes, "Nom_Imprimante", "Id_Imprimante", "Vide");
                ADO.RemplirCombo("GetImprimanteDisponibleId", CmbEmplacement, "Id_Imprimante", "Id_Imprimante", "Vide");

                ListeImprimantes();

                if (CmbEmplacement.Items.Count == 0)
                    CmbEmplacement.Enabled = BtnAjouter.Enabled = BtnModifier.Enabled = TxtNom.Enabled = false;
            }
            else
            {
                MessageBox.Show("Veuillez remplir le nom d'imprimante !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (TxtNom.Text != "")
            {
                ADO.Connecter();
                ADO.cmd = new SqlCommand("update Imprimante set Nom_Imprimante=@Nom where Id_Imprimante=@Id", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Id", CmbEmplacement.Text);
                ADO.cmd.Parameters.AddWithValue("@Nom", TxtNom.Text);
                ADO.cmd.ExecuteNonQuery();
                ADO.Deconnecter();
                ListeImprimantes();
                MessageBox.Show("Imprimante est bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNom.Clear();
                TxtNom.Focus();
                ADO.RemplirCombo("GetImprimanteIdAndName", CmbImprimantes, "Nom_Imprimante", "Id_Imprimante", "Vide");
                ADO.RemplirCombo("GetImprimanteDisponibleId", CmbEmplacement, "Id_Imprimante", "Id_Imprimante", "Vide");
                ListeImprimanteParCategories();
            }
            else
            {
                MessageBox.Show("Veuillez remplir le nom d'imprimante !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (CmbImprimantes.Text != "" && CmbCategories.Text != "")
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("select Id_Categorie from Imprimante_Categorie where Id_Categorie=@Id_Categorie", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                DataTable table = new DataTable();
                ADO.sda.Fill(table);

                if (table.Rows.Count == 0)
                {
                    ADO.cmd = new SqlCommand("insert into Imprimante_Categorie values(@Id_Imprimante,@Id_Categorie)", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Id_Imprimante", CmbImprimantes.SelectedValue);
                    ADO.cmd.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    ADO.cmd.ExecuteNonQuery();
                }
                else if (table.Rows.Count == 1)
                {
                    ADO.cmd = new SqlCommand("update Imprimante_Categorie set Id_Imprimante=@Id_Imprimante where Id_Categorie=@Id_Categorie", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Id_Imprimante", CmbImprimantes.SelectedValue);
                    ADO.cmd.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    ADO.cmd.ExecuteNonQuery();
                }
                ADO.Deconnecter();

                MessageBox.Show("Opération est bien terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //ADO.RemplirCombo("GetCategorieIdAndName", CmbCategories, "Nom_Categorie", "Id_Categorie", "Vide");
                //ADO.RemplirCombo("GetImprimanteIdAndName", CmbImprimantes, "Nom_Imprimante", "Id_Imprimante", "Vide");
                
                ListeImprimanteParCategories();
            }
        }

        private void DGVListeImprimantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVListeImprimantes.SelectedRows.Count == 1)
            {
                CmbEmplacement.Enabled = TxtNom.Enabled = BtnModifier.Enabled = true;
                CmbEmplacement.Items.Clear();
                CmbEmplacement.Items.Add(DGVListeImprimantes.SelectedRows[0].Cells[0].Value.ToString());
                CmbEmplacement.Text = DGVListeImprimantes.SelectedRows[0].Cells[0].Value.ToString();
                TxtNom.Text = DGVListeImprimantes.SelectedRows[0].Cells[1].Value.ToString();
                CmbEmplacement.Enabled = false;
            }
        }

        private void TxtNom_Leave(object sender, EventArgs e)
        {
            
        }

        private void TxtNom_TextChanged(object sender, EventArgs e)
        {
            if (TxtNom.Text == "")
            {
                LblErrorMessage.Visible = true;
            }
            else
            {
                LblErrorMessage.Visible = false;

                //string number = TxtNomCategorie.Text;
                //number = NumberToWords.ConvertAmount(double.Parse(number));

                //MessageBox.Show(number, "Number to English");
            }
        }
    }
}
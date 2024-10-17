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

namespace FastFoodDemo.User_Controls
{
    public partial class GestionFournisseur : UserControl
    {
        public GestionFournisseur()
        {
            InitializeComponent();
        }

        ADO ADO = new ADO();

        DataTable table = new DataTable();

        private void Vider()
        {
            TxtCIN.Text = TxtNom.Text = TxtPrenom.Text = TxtPhone.Text = TxtAdresse.Text = TxtEmail.Text = "";
        }

        public void ListeFournisseurs()
        {
            try
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("GetListOfFournisseurs", ADO.con);
                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                table.Clear();
                ADO.sda.Fill(table);
                DGVFournisseurs.DataSource = table;
                //DGVProduits.Columns[0].Visible = false;
                //DGVProduits.Columns[1].Width = 200;
                if (DGVFournisseurs.Rows.Count == 0)
                {
                    System.Data.DataTable dd = new System.Data.DataTable();
                    dd.Columns.Add("Message");
                    dd.Rows.Add("Pas de données !");
                    DGVFournisseurs.DataSource = dd;
                    DGVFournisseurs.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AjouterFournisseur()
        {
            try
            {
                if (TxtCIN.Text == "" || TxtNom.Text == "" || TxtPrenom.Text == "" || TxtPhone.Text == "" || TxtAdresse.Text == "" || TxtEmail.Text == "")
                {
                    MessageBox.Show("Attention, veuillez remplir les champs !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    ADO.Connecter();

                    ADO.cmd = new SqlCommand("insert into Clients values(@cin,@nom,@prenom,@phone,@adresse,@email,@isclient,@isfournisseur)", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@cin", TxtCIN.Text);
                    ADO.cmd.Parameters.AddWithValue("@nom", TxtNom.Text);
                    ADO.cmd.Parameters.AddWithValue("@prenom", TxtPrenom.Text);
                    ADO.cmd.Parameters.AddWithValue("@phone", TxtPhone.Text);
                    ADO.cmd.Parameters.AddWithValue("@adresse", TxtAdresse.Text);
                    ADO.cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                    ADO.cmd.Parameters.AddWithValue("@isclient", 0);
                    ADO.cmd.Parameters.AddWithValue("@isfournisseur", 1);
                    ADO.cmd.ExecuteNonQuery();

                    MessageBox.Show("Fournisseur est bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Vider();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GestionFournisseur_Load(object sender, EventArgs e)
        {
            GroupBoxCategorie.Width = guna2GroupBox1.Width = Form1.GeneralInstance.PnlAffichage.Width - 25;
            ListeFournisseurs();
            this.Dock = DockStyle.Fill;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            AjouterFournisseur();
            ListeFournisseurs();
        }
    }
}

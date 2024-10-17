using FastFoodDemo.Classes;
using FastFoodDemo.DataSets;
using FastFoodDemo.Rapports;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FastFoodDemo.User_Controls
{
    public partial class ListeCommandes : UserControl
    {
        public static ListeCommandes ListeCommandesInstance;

        public static ListeCommandes Instance
        {
            get
            {
                if (ListeCommandesInstance == null)
                {
                    ListeCommandesInstance = new ListeCommandes();
                }
                return ListeCommandesInstance;
            }
        }

        public ListeCommandes()
        {
            InitializeComponent();
            ListeCommandesInstance = this;
        }

        ADO ADO = new ADO();

        public static CrystalReportTicketClient ticketClient = new CrystalReportTicketClient();

        public void ListeDesCommandes()
        {
            string Query = "";

            if (CmbUtilisateur.Text.Equals("TOUS"))
            {
                Query = "select Id_Commande as 'Référence',Date_Commande as 'Date',Nom_Serveur as 'Sereur',Nom_Table as 'Zone et table',Total_Commande as 'Montant' from CommandePayer where Date_Commande between @DateDebut and @DateFin";
            }
            else
            {
                Query = "select Id_Commande as 'Référence',Date_Commande as 'Date',Nom_Serveur as 'Sereur',Nom_Table as 'Zone et table',Total_Commande as 'Montant' from CommandePayer where Date_Commande between @DateDebut and @DateFin and Nom_Serveur=@Nom_Serveur";
            }

            ADO.sda = new SqlDataAdapter(Query, ADO.con);

            ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
            ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));

            if (CmbUtilisateur.Text != "" && !CmbUtilisateur.Text.Equals("TOUS"))
            {
                ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom_Serveur", CmbUtilisateur.Text);
            }

            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            DGVListeCommandes.DataSource = table;

            //DGVListeCommandes.Columns[0].Width = 270;
            DGVListeCommandes.Columns[4].DefaultCellStyle.Format = "N2";

            if (DGVListeCommandes.Rows.Count == 0)
            {
                System.Data.DataTable dd = new System.Data.DataTable();
                //DGVListeImprimantes.Width = 140;
                //DGVListeImprimantes.Height = 90;
                dd.Columns.Add("Message");
                //dd.Columns.Add("Nom");
                dd.Rows.Add("Pas de données !");
                DGVListeCommandes.DataSource = dd;
                DGVListeCommandes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
            }
        }

        public void DetailsCommandes()
        {
            if (DGVListeCommandes.SelectedRows.Count == 1)
            {
                ADO.sda = new SqlDataAdapter("DetailCommandeByIdInView", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCommande", DGVListeCommandes.SelectedRows[0].Cells[0].Value.ToString());
                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                DGVDetailsCommane.DataSource = table;

                DGVDetailsCommane.Columns[0].Width = 270;
                DGVDetailsCommane.Columns[3].DefaultCellStyle.Format = "N2";

                if (DGVDetailsCommane.Rows.Count == 0)
                {
                    System.Data.DataTable dd = new System.Data.DataTable();
                    //DGVListeImprimantes.Width = 140;
                    //DGVListeImprimantes.Height = 90;
                    dd.Columns.Add("Message");
                    //dd.Columns.Add("Nom");
                    dd.Rows.Add("Pas de données !");
                    DGVDetailsCommane.DataSource = dd;
                    DGVDetailsCommane.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                }
            }

        }

        private void ListeCommandes_Load(object sender, EventArgs e)
        {
            try
            {
                DPDateDebut.Value = DateTime.Now;
                DPDateFin.Value = DateTime.Now.AddDays(1);

                ADO.RemplirCombo("GetEmployerName", CmbUtilisateur, "Prenom", "CIN", "TOUS");

                ListeDesCommandes();

                GroupBoxCategorie.Width = Form1.GeneralInstance.PnlAffichage.Width - 25;

                this.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                ListeDesCommandes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DGVDetailsCommane_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVListeCommandes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DetailsCommandes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnImprimerDuplicata_Click(object sender, EventArgs e)
        {
            try
            {
                string role = Form1.GeneralInstance.LblRole.Text;
                if (ADO.CheckIfRoleCanPrintDuplicata(role) || role.Equals(ADO.UserRoles.Admin.ToString()))
                {
                    CommandeDataSet dataSet = new CommandeDataSet();

                    if (DGVListeCommandes.SelectedRows.Count == 1)
                    {
                        // Ticket Client :

                        ADO.Connecter();

                        ADO.sda = new SqlDataAdapter("DetailCommandeEtatById", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCommande", DGVListeCommandes.SelectedRows[0].Cells[0].Value.ToString());
                        ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        dataSet.Tables["Commande"].Clear();
                        ADO.sda.Fill(dataSet, "Commande");
                        ticketClient.SetDataSource(dataSet.Tables["Commande"]);

                        ticketClient.PrintToPrinter(0, false, 1, 1);
                        ticketClient.PrintOptions.PrinterName = "A5";
                        //Print impressionTicetClient = new Print();
                        //Print.ticketNom = "Duplicata";
                        //impressionTicetClient.ShowDialog();

                        ADO.Deconnecter();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string role = Form1.GeneralInstance.LblRole.Text;
                if (ADO.CheckIfRoleCanDeleteOrder(role) || role.Equals(ADO.UserRoles.Admin.ToString()))
                {
                    int orderId = int.Parse(DGVListeCommandes.SelectedRows[0].Cells[0].Value.ToString());
                    int result = ADO.DeleteOrderById(orderId);
                    if (result == 1)
                    {
                        MessageBox.Show("Commande est bien supprimer !", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListeDesCommandes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
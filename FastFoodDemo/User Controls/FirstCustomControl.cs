using System;
using System.Data;
using System.Windows.Forms;
using FastFoodDemo.Models;
using FastFoodDemo.Classes;
using System.Data.SqlClient;

namespace FastFoodDemo
{
    public partial class FirstCustomControl : UserControl
    {
        public FirstCustomControl()
        {
            InitializeComponent();
        }

        //readonly GestionEspaceEntities db = new GestionEspaceEntities();

        readonly ADO ADO = new ADO();

        private void FirstCustomControl_Load(object sender, EventArgs e)
        {
            ADO.Connecter();

            ADO.sda = new SqlDataAdapter("GetCategorieCount", ADO.con);
            ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tableCat = new DataTable();
            ADO.sda.Fill(tableCat);
            if (tableCat.Rows.Count > 0)
            {
                LblCatTotal.Text = tableCat.Rows[0][0].ToString();
            }

            ADO.sda = new SqlDataAdapter("GetProduitCount", ADO.con);
            ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tableProd = new DataTable();
            ADO.sda.Fill(tableProd);
            if (tableProd.Rows.Count > 0)
            {
                LblProdTotal.Text = tableProd.Rows[0][0].ToString();
            }

            ADO.sda = new SqlDataAdapter("GetCommandesCount", ADO.con);
            ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tableCmd = new DataTable();
            ADO.sda.Fill(tableCmd);
            if (tableCmd.Rows.Count > 0)
            {
                LblCmdTotal.Text = tableCmd.Rows[0][0].ToString();
            }

            ADO.sda = new SqlDataAdapter("GetUtilisateursCount", ADO.con);
            ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tableUsers = new DataTable();
            ADO.sda.Fill(tableUsers);
            if (tableUsers.Rows.Count > 0)
            {
                LblNmbrUsers.Text = tableUsers.Rows[0][0].ToString();
            }

            ADO.Deconnecter();

            //LblCatTotal.Text = db.Categorie.ToList().Count.ToString();
            //LblProdTotal.Text = db.Produit.ToList().Count.ToString();
            //LblCmdTotal.Text = db.CommandePayer.ToList().Count.ToString();

            //chartCommandes.Series["Commande"].Points.AddXY("Janvier", 50);
            //chartCommandes.Series["Commande"].Points.AddXY("Février", 25);
            //chartCommandes.Series["Commande"].Points.AddXY("Mars", 80);
            //chartCommandes.Series["Commande"].Points.AddXY("April", 10);
            //chartCommandes.Series["Commande"].Points.AddXY("Mai", 50);
            //chartCommandes.Series["Commande"].Points.AddXY("Juin", 90);
            //chartCommandes.Series["Commande"].Points.AddXY("Juillet", 30);
            //chartCommandes.Series["Commande"].Points.AddXY("August", 100);
            //chartCommandes.Series["Commande"].Points.AddXY("Octobre", 150);
            //chartCommandes.Series["Commande"].Points.AddXY("September", 15);
            //chartCommandes.Series["Commande"].Points.AddXY("November", 60);
            //chartCommandes.Series["Commande"].Points.AddXY("December", 200);

            ADO.Connecter();
            ADO.sda = new SqlDataAdapter("TotalCommandeByMonth", ADO.con);
            ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tableCommande = new DataTable();
            ADO.sda.Fill(tableCommande);

            chartCommandes.DataSource = tableCommande;
            chartCommandes.Series["Nombre commandes par mois"].XValueMember = "Mois";
            chartCommandes.Series["Nombre commandes par mois"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartCommandes.Series["Nombre commandes par mois"].YValueMembers = "Quantité";
            chartCommandes.Series["Nombre commandes par mois"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            ADO.sda = new SqlDataAdapter("QuantiteTotalProductByMonth", ADO.con);
            ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tableProduit = new DataTable();
            ADO.sda.Fill(tableProduit);
            ADO.Deconnecter();
            
            chart1.DataSource = tableProduit;
            chart1.Series["CommandesParMois"].XValueMember = "Produit";
            chart1.Series["CommandesParMois"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart1.Series["CommandesParMois"].YValueMembers = "Quantité total";
            chart1.Series["CommandesParMois"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            //chartCommandes.DataSource = db.RapportCommandesParAnnee();

            //int rangeMin = -10;
            //int rangeMax = 20;

            //chartCommandes.Series["Total commandes"].Points.AddXY(0, rangeMin + 1);
            //chartCommandes.Series["Total commandes"].Points.AddXY(0, rangeMax - 1);

            //chartCommandes.Series["Nombre commandes par mois"].XValueMember = "Mois";
            //chartCommandes.Series["Nombre commandes par mois"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            ////chartCommandes.ChartAreas[0].AxisY.MajorGrid.Interval = 5;
            //chartCommandes.Series["Nombre commandes par mois"].YValueMembers = "Nombre";
            //chartCommandes.Series["Nombre commandes par mois"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            //chartCommandes.Series["Nombre commandes"].XValueMember = "Mois";
            //chartCommandes.Series["Nombre commandes"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            //chartCommandes.Series["Nombre commandes"].YValueMembers = "Nombre commandes";
            //chartCommandes.Series["Nombre commandes"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            this.Dock = DockStyle.Fill;
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
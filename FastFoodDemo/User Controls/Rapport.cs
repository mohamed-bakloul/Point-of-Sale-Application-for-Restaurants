using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using FastFoodDemo.Classes;
using FastFoodDemo.DataSets;
using FastFoodDemo.Rapports;
using System.IO;
using System.Threading.Tasks;
using System.Configuration;
using System.Drawing.Printing;

namespace FastFoodDemo.User_Controls
{
    public partial class Rapport : UserControl
    {
        public static Rapport RapportInstance;

        public static Rapport Instance
        {
            get
            {
                if (RapportInstance == null)
                {
                    RapportInstance = new Rapport();
                }
                return RapportInstance;
            }
        }

        public Rapport()
        {
            InitializeComponent();
            RapportInstance = this;
        }

        readonly ADO ADO = new ADO();

        public static CrystalReportRapportsVentes ticketRapport = new CrystalReportRapportsVentes();

        //GestionEspaceEntities db = new GestionEspaceEntities();

        //public void RemplirComboEmployer()
        //{
        //    var table = db.Employer.ToList();

        //    table.Insert(0, new Employer { CIN = "0", Nom = "TOUS", DateInscription = DateTime.Now, MotPasse = "0", Prenom = "Hi", Role = "Admin" });

        //    CmbUtilisateur.DisplayMember = "Nom";
        //    CmbUtilisateur.ValueMember = "CIN";
        //    CmbUtilisateur.DataSource = table;
        //}

        public void TotalQteEtPrix()
        {
            decimal Qte = 0;
            decimal Prix = 0;
            if (DGVListeVentes.Rows.Count > 0)
            {
                if (DGVListeVentes.Columns.Count > 1)
                {
                    foreach (DataGridViewRow row in DGVListeVentes.Rows)
                    {
                        Qte += decimal.Parse(row.Cells[1].Value.ToString());
                        Prix += decimal.Parse(row.Cells[3].Value.ToString());
                    }

                    LblQteTotal.Text = Qte.ToString("#.00");
                    LblMntTotal.Text = Prix.ToString("#.00");
                }
            }
            else
            {
                LblQteTotal.Text = "0.00";
                LblMntTotal.Text = "0.00";
            }
        }

        //var fullEntries = db.CommandePayers
        //    .Join(db.DetailsCommandeImprimantes,
        //    cp => cp.Id_Commande,
        //    dci => dci.Id_Commande,
        //    (cp, dci) => new { cp, dci }
        //    ).Join(db.Produits,
        //    dcit => dcit.dci.Id_Produit,
        //    prd => prd.Id_Produit,
        //    (dcit, prd) => new
        //    {
        //        IdProduit=dcit.cp.Id_Commande,
        //        NomProduit=prd.Nom_Produit,
        //        QuantiteTotal=,
        //        IdProduit=dcit.cp.Id_Commande,
        //        IdProduit=dcit.cp.Id_Commande,
        //        IdProduit=dcit.cp.Id_Commande,
        //    }
        //    ).ToList();

        //List<SqlParameter> paramList = new List<SqlParameter>();

        //paramList.Add(new SqlParameter("@DateDebut", DPDateDebut.Text));
        //paramList.Add(new SqlParameter("@DateFin", DPDateFin.Text));

        public void ListeDesVentesParDateEtUtilisateur()
        {
            ADO.Connecter();

            string Requete;

            //var RapportDesVentes = DGVListeVentes.DataSource;

            // Cas 1 :

            if (CmbUtilisateur.Text.Equals("TOUS") && CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentes(DPDateDebut.Value, DPDateFin.Value);
                        //Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',(dci.Prix*(SUM(dci.Quantite))) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin group by p.Nom_Produit,dci.Prix", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                        if (DGVListeVentes.Rows.Count == 0)
                        {
                            DataTable dd = new DataTable();
                            //DGVListeImprimantes.Width = 140;
                            //DGVListeImprimantes.Height = 90;
                            dd.Columns.Add("Message");
                            //dd.Columns.Add("Nom");
                            dd.Rows.Add("Pas de données !");
                            DGVListeVentes.DataSource = dd;
                            DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                        }
                    }
                }
                else
                {
                    ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and dci.Id_Produit=0 group by p.Nom_Produit,dci.Prix", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    DGVListeVentes.DataSource = table;
                    //DGVListeVentes.DataSource = RapportDesVentes;

                    DGVListeVentes.Columns[0].Width = 270;
                    DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                    if (DGVListeVentes.Rows.Count == 0)
                    {
                        DataTable dd = new DataTable();
                        //DGVListeImprimantes.Width = 140;
                        //DGVListeImprimantes.Height = 90;
                        dd.Columns.Add("Message");
                        //dd.Columns.Add("Nom");
                        dd.Rows.Add("Pas de données !");
                        DGVListeVentes.DataSource = dd;
                        DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                    }
                }
            }
            else if (!CmbUtilisateur.Text.Equals("TOUS") && !CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (!CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        //Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',(dci.Prix*(SUM(dci.Quantite))) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=@Id_Produit and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=@Id_Produit and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                        if (DGVListeVentes.Rows.Count == 0)
                        {
                            DataTable dd = new DataTable();
                            //DGVListeImprimantes.Width = 140;
                            //DGVListeImprimantes.Height = 90;
                            dd.Columns.Add("Message");
                            //dd.Columns.Add("Nom");
                            dd.Rows.Add("Pas de données !");
                            DGVListeVentes.DataSource = dd;
                            DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                        }
                    }
                    else
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        //Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',(dci.Prix*(SUM(dci.Quantite))) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=@Id_Produit and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur /*and dci.Id_Produit=@Id_Produit*/ and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                        if (DGVListeVentes.Rows.Count == 0)
                        {
                            DataTable dd = new DataTable();
                            //DGVListeImprimantes.Width = 140;
                            //DGVListeImprimantes.Height = 90;
                            dd.Columns.Add("Message");
                            //dd.Columns.Add("Nom");
                            dd.Rows.Add("Pas de données !");
                            DGVListeVentes.DataSource = dd;
                            DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                        }
                    }
                }
                else
                {
                    ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=0 and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    DGVListeVentes.DataSource = table;
                    //DGVListeVentes.DataSource = RapportDesVentes;

                    DGVListeVentes.Columns[0].Width = 270;
                    DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                    if (DGVListeVentes.Rows.Count == 0)
                    {
                        DataTable dd = new DataTable();
                        //DGVListeImprimantes.Width = 140;
                        //DGVListeImprimantes.Height = 90;
                        dd.Columns.Add("Message");
                        //dd.Columns.Add("Nom");
                        dd.Rows.Add("Pas de données !");
                        DGVListeVentes.DataSource = dd;
                        DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                    }
                }
            }
            else if (!CmbUtilisateur.Text.Equals("TOUS") && CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                        if (DGVListeVentes.Rows.Count == 0)
                        {
                            DataTable dd = new DataTable();
                            //DGVListeImprimantes.Width = 140;
                            //DGVListeImprimantes.Height = 90;
                            dd.Columns.Add("Message");
                            //dd.Columns.Add("Nom");
                            dd.Rows.Add("Pas de données !");
                            DGVListeVentes.DataSource = dd;
                            DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                        }
                    }
                }
                else
                {
                    Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=0 group by p.Nom_Produit,dci.Prix";
                    ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    DGVListeVentes.DataSource = table;
                    //DGVListeVentes.DataSource = RapportDesVentes;

                    DGVListeVentes.Columns[0].Width = 270;
                    DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                    if (DGVListeVentes.Rows.Count == 0)
                    {
                        DataTable dd = new DataTable();
                        //DGVListeImprimantes.Width = 140;
                        //DGVListeImprimantes.Height = 90;
                        dd.Columns.Add("Message");
                        //dd.Columns.Add("Nom");
                        dd.Rows.Add("Pas de données !");
                        DGVListeVentes.DataSource = dd;
                        DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                    }
                }
            }
            else if (!CmbUtilisateur.Text.Equals("TOUS") && !CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                        if (DGVListeVentes.Rows.Count == 0)
                        {
                            DataTable dd = new DataTable();
                            //DGVListeImprimantes.Width = 140;
                            //DGVListeImprimantes.Height = 90;
                            dd.Columns.Add("Message");
                            //dd.Columns.Add("Nom");
                            dd.Rows.Add("Pas de données !");
                            DGVListeVentes.DataSource = dd;
                            DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                        }
                    }
                    else
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=@Id_Produit and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                        if (DGVListeVentes.Rows.Count == 0)
                        {
                            DataTable dd = new DataTable();
                            //DGVListeImprimantes.Width = 140;
                            //DGVListeImprimantes.Height = 90;
                            dd.Columns.Add("Message");
                            //dd.Columns.Add("Nom");
                            dd.Rows.Add("Pas de données !");
                            DGVListeVentes.DataSource = dd;
                            DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                        }
                    }
                }
                else
                {
                    Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and p.Id_CategorieProduit=@Id_Categorie and dci.Id_Produit=0 group by p.Nom_Produit,dci.Prix";
                    ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    DGVListeVentes.DataSource = table;
                    //DGVListeVentes.DataSource = RapportDesVentes;

                    DGVListeVentes.Columns[0].Width = 270;
                    DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                    if (DGVListeVentes.Rows.Count == 0)
                    {
                        DataTable dd = new DataTable();
                        //DGVListeImprimantes.Width = 140;
                        //DGVListeImprimantes.Height = 90;
                        dd.Columns.Add("Message");
                        //dd.Columns.Add("Nom");
                        dd.Rows.Add("Pas de données !");
                        DGVListeVentes.DataSource = dd;
                        DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                    }
                }
            }
            else if (CmbUtilisateur.Text.Equals("TOUS") && !CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                        if (DGVListeVentes.Rows.Count == 0)
                        {
                            DataTable dd = new DataTable();
                            //DGVListeImprimantes.Width = 140;
                            //DGVListeImprimantes.Height = 90;
                            dd.Columns.Add("Message");
                            //dd.Columns.Add("Nom");
                            dd.Rows.Add("Pas de données !");
                            DGVListeVentes.DataSource = dd;
                            DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                        }
                    }
                    else
                    {
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and p.Id_CategorieProduit=@Id_Categorie and dci.Id_Produit=@Id_Produit group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                        if (DGVListeVentes.Rows.Count == 0)
                        {
                            DataTable dd = new DataTable();
                            //DGVListeImprimantes.Width = 140;
                            //DGVListeImprimantes.Height = 90;
                            dd.Columns.Add("Message");
                            //dd.Columns.Add("Nom");
                            dd.Rows.Add("Pas de données !");
                            DGVListeVentes.DataSource = dd;
                            DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                        }
                    }
                }
                else
                {
                    Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and p.Id_CategorieProduit=@Id_Categorie and dci.Id_Produit=0 group by p.Nom_Produit,dci.Prix";
                    ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    DGVListeVentes.DataSource = table;
                    //DGVListeVentes.DataSource = RapportDesVentes;

                    DGVListeVentes.Columns[0].Width = 270;
                    DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                    if (DGVListeVentes.Rows.Count == 0)
                    {
                        DataTable dd = new DataTable();
                        //DGVListeImprimantes.Width = 140;
                        //DGVListeImprimantes.Height = 90;
                        dd.Columns.Add("Message");
                        //dd.Columns.Add("Nom");
                        dd.Rows.Add("Pas de données !");
                        DGVListeVentes.DataSource = dd;
                        DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                    }
                }
            }
            else if (CmbUtilisateur.Text.Equals("TOUS") && !CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (!CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and dci.Id_Produit=@Id_Produit and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                        if (DGVListeVentes.Rows.Count == 0)
                        {
                            DataTable dd = new DataTable();
                            //DGVListeImprimantes.Width = 140;
                            //DGVListeImprimantes.Height = 90;
                            dd.Columns.Add("Message");
                            //dd.Columns.Add("Nom");
                            dd.Rows.Add("Pas de données !");
                            DGVListeVentes.DataSource = dd;
                            DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                        }
                    }
                    else
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin /*and dci.Id_Produit=@Id_Produit*/ and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                        if (DGVListeVentes.Rows.Count == 0)
                        {
                            DataTable dd = new DataTable();
                            //DGVListeImprimantes.Width = 140;
                            //DGVListeImprimantes.Height = 90;
                            dd.Columns.Add("Message");
                            //dd.Columns.Add("Nom");
                            dd.Rows.Add("Pas de données !");
                            DGVListeVentes.DataSource = dd;
                            DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                        }
                    }
                }
                else
                {
                    Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin /*and dci.Id_Produit=@Id_Produit*/ and p.Id_CategorieProduit=@Id_Categorie and dci.Id_Produit=0 group by p.Nom_Produit,dci.Prix";
                    ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    DGVListeVentes.DataSource = table;
                    //DGVListeVentes.DataSource = RapportDesVentes;

                    DGVListeVentes.Columns[0].Width = 270;
                    DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";

                    if (DGVListeVentes.Rows.Count == 0)
                    {
                        DataTable dd = new DataTable();
                        //DGVListeImprimantes.Width = 140;
                        //DGVListeImprimantes.Height = 90;
                        dd.Columns.Add("Message");
                        //dd.Columns.Add("Nom");
                        dd.Rows.Add("Pas de données !");
                        DGVListeVentes.DataSource = dd;
                        DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                    }
                }
            }

            ADO.Deconnecter();
        }

        private void Rapport_Load(object sender, EventArgs e)
        {
            DPDateDebut.Value = DateTime.Now;
            DPDateFin.Value = DateTime.Now.AddDays(1);

            ADO.RemplirCombo("GetEmployerName", CmbUtilisateur, "Prenom", "CIN", "TOUS");
            ADO.RemplirCombo("GetCategorieIdAndName", CmbCategories, "Nom_Categorie", "Id_Categorie", "TOUS");

            //RemplirComboEmployer();

            ListeDesVentesParDateEtUtilisateur();

            TotalQteEtPrix();

            GroupBoxCategorie.Width = Form1.GeneralInstance.PnlAffichage.Width - 25;

            this.Dock = DockStyle.Fill;
        }

        private async void BtnRechercher_Click(object sender, EventArgs e)
        {
            pictureBoxLoading.Visible = true;

            await Task.Delay(TimeSpan.FromSeconds(3));

            ListeDesVentesParDateEtUtilisateur();

            //DGVListeVentes.DataSource = db.RapportVentes(DPDateDebut.Value, DPDateFin.Value);

            TotalQteEtPrix();

            pictureBoxLoading.Visible = false;
        }

        private void CmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCategories.Text == "TOUS")
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("select Id_Produit,Nom_Produit from Produit where Id_CategorieProduit=@IdCat", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCat", CmbCategories.SelectedValue);
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                DataRow row = table.NewRow();
                row["Id_Produit"] = "0";
                row["Nom_Produit"] = "TOUS";
                table.Rows.InsertAt(row, 0);
                CmbProduits.DisplayMember = "Nom_Produit";
                CmbProduits.ValueMember = "Id_Produit";
                CmbProduits.DataSource = table;
                CmbProduits.Text = "TOUS";
                CmbProduits.Enabled = false;
            }
            else
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("select Id_Produit,Nom_Produit from Produit where Id_CategorieProduit=@IdCat", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCat", CmbCategories.SelectedValue);
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                if (table.Rows.Count > 0)
                {
                    DataRow row = table.NewRow();
                    row["Id_Produit"] = "0";
                    row["Nom_Produit"] = "TOUS";
                    table.Rows.InsertAt(row, 0);
                    CmbProduits.DisplayMember = "Nom_Produit";
                    CmbProduits.ValueMember = "Id_Produit";
                    CmbProduits.DataSource = table;
                    CmbProduits.Enabled = true;
                }
                else
                {
                    CmbProduits.DisplayMember = "Nom_Produit";
                    CmbProduits.ValueMember = "Id_Produit";
                    CmbProduits.DataSource = table;
                    CmbProduits.Enabled = false;
                }
            }
        }

        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            CommandeDataSet dataSet = new CommandeDataSet();

            ADO.Connecter();

            string Requete;

            //var RapportDesVentes = DGVListeVentes.DataSource;

            // Cas 1 :

            if (CmbUtilisateur.Text.Equals("TOUS") && CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentes(DPDateDebut.Value, DPDateFin.Value);
                        //Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',(dci.Prix*(SUM(dci.Quantite))) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin group by p.Nom_Produit,dci.Prix,c.Nom_Categorie", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));

                        ADO.sda.Fill(dataSet, "Commande");
                        ticketRapport.SetDataSource(dataSet.Tables["Commande"]);
                        ticketRapport.SetParameterValue("Date_Debut", DPDateDebut.Text);
                        ticketRapport.SetParameterValue("Date_Fin", DPDateFin.Text);
                        ticketRapport.SetParameterValue("Serveur", "TOUS");

                        //- If You Want To Select A Specific Printer By Name
                        ticketRapport.PrintToPrinter(0, false, 1, 1);
                        ticketRapport.PrintOptions.PrinterName = "Microsoft Print to PDF";


                        //- If You Want To Select A Specific Printer Listed In The System
                        //PrintDialog print = new PrintDialog();

                        //// Set the DocumentName property of the PrintDocument
                        //string reportName = $"Rapport des ventes {DateTime.Now.ToString()}";

                        //if (print.ShowDialog() == DialogResult.OK)
                        //{
                        //    // Set the printer name for the ReportDocument (ticketRapport) to the selected printer
                        //    ticketRapport.PrintOptions.PrinterName = print.PrinterSettings.PrinterName;

                        //    // Print the ReportDocument (ticketRapport) to the selected printer using the printer settings
                        //    ticketRapport.PrintToPrinter(print.PrinterSettings.Copies, print.PrinterSettings.Collate, print.PrinterSettings.FromPage, print.PrinterSettings.ToPage);
                        //}

                        //Print impression = new Print();
                        //Print.ticketNom = "Rapport";
                        //impression.ShowDialog();
                    }
                }
                else
                {
                    ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and dci.Id_Produit=0 group by p.Nom_Produit,dci.Prix,c.Nom_Categorie", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));

                    ADO.sda.Fill(dataSet, "Commande");
                    ticketRapport.SetDataSource(dataSet.Tables["Commande"]);
                    ticketRapport.SetParameterValue("Date_Debut", DPDateDebut.Text);
                    ticketRapport.SetParameterValue("Date_Fin", DPDateFin.Text);
                    ticketRapport.SetParameterValue("Serveur", "TOUS");
                    //ticketCuisine.PrintToPrinter(0, false, 1, 1);
                    //ticketCuisine.PrintOptions.PrinterName = "A5";

                    //- If You Want To Select A Specific Printer By Name
                    ticketRapport.PrintToPrinter(0, false, 1, 1);
                    ticketRapport.PrintOptions.PrinterName = "Microsoft Print to PDF";

                    //Print impression = new Print();
                    //Print.ticketNom = "Rapport";
                    //impression.ShowDialog();
                }
            }
            else if (!CmbUtilisateur.Text.Equals("TOUS") && !CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (!CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        //Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',(dci.Prix*(SUM(dci.Quantite))) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=@Id_Produit and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=@Id_Produit and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix,c.Nom_Categorie", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);

                        ADO.sda.Fill(dataSet, "Commande");
                        ticketRapport.SetDataSource(dataSet.Tables["Commande"]);
                        ticketRapport.SetParameterValue("Date_Debut", DPDateDebut.Text);
                        ticketRapport.SetParameterValue("Date_Fin", DPDateFin.Text);
                        ticketRapport.SetParameterValue("Serveur", "TOUS");

                        //- If You Want To Select A Specific Printer By Name
                        ticketRapport.PrintToPrinter(0, false, 1, 1);
                        ticketRapport.PrintOptions.PrinterName = "Microsoft Print to PDF";
                        //ticketCuisine.PrintToPrinter(0, false, 1, 1);
                        //ticketCuisine.PrintOptions.PrinterName = "A5";
                        //Print impression = new Print();
                        //Print.ticketNom = "Rapport";
                        //impression.ShowDialog();
                    }
                    else
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        //Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',(dci.Prix*(SUM(dci.Quantite))) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=@Id_Produit and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur /*and dci.Id_Produit=@Id_Produit*/ and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix,c.Nom_Categorie", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);

                        ADO.sda.Fill(dataSet, "Commande");
                        ticketRapport.SetDataSource(dataSet.Tables["Commande"]);
                        ticketRapport.SetParameterValue("Date_Debut", DPDateDebut.Text);
                        ticketRapport.SetParameterValue("Date_Fin", DPDateFin.Text);
                        ticketRapport.SetParameterValue("Serveur", "TOUS");

                        //- If You Want To Select A Specific Printer By Name
                        ticketRapport.PrintToPrinter(0, false, 1, 1);
                        ticketRapport.PrintOptions.PrinterName = "Microsoft Print to PDF";
                        //ticketCuisine.PrintToPrinter(0, false, 1, 1);
                        //ticketCuisine.PrintOptions.PrinterName = "A5";
                        //Print impression = new Print();
                        //Print.ticketNom = "Rapport";
                        //impression.ShowDialog();
                    }
                }
                else
                {
                    ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=0 and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix,c.Nom_Categorie", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);

                    ADO.sda.Fill(dataSet, "Commande");
                    ticketRapport.SetDataSource(dataSet.Tables["Commande"]);
                    ticketRapport.SetParameterValue("Date_Debut", DPDateDebut.Text);
                    ticketRapport.SetParameterValue("Date_Fin", DPDateFin.Text);
                    ticketRapport.SetParameterValue("Serveur", "TOUS");

                    //- If You Want To Select A Specific Printer By Name
                    ticketRapport.PrintToPrinter(0, false, 1, 1);
                    ticketRapport.PrintOptions.PrinterName = "Microsoft Print to PDF";
                    //ticketCuisine.PrintToPrinter(0, false, 1, 1);
                    //ticketCuisine.PrintOptions.PrinterName = "A5";
                    //Print impression = new Print();
                    //Print.ticketNom = "Rapport";
                    //impression.ShowDialog();
                }
            }
            else if (!CmbUtilisateur.Text.Equals("TOUS") && CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur group by p.Nom_Produit,dci.Prix,c.Nom_Categorie";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);

                        ADO.sda.Fill(dataSet, "Commande");
                        ticketRapport.SetDataSource(dataSet.Tables["Commande"]);
                        ticketRapport.SetParameterValue("Date_Debut", DPDateDebut.Text);
                        ticketRapport.SetParameterValue("Date_Fin", DPDateFin.Text);
                        ticketRapport.SetParameterValue("Serveur", "TOUS");

                        //- If You Want To Select A Specific Printer By Name
                        ticketRapport.PrintToPrinter(0, false, 1, 1);
                        ticketRapport.PrintOptions.PrinterName = "Microsoft Print to PDF";
                        //ticketCuisine.PrintToPrinter(0, false, 1, 1);
                        //ticketCuisine.PrintOptions.PrinterName = "A5";
                        //Print impression = new Print();
                        //Print.ticketNom = "Rapport";
                        //impression.ShowDialog();
                    }
                }
                else
                {
                    Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=0 group by p.Nom_Produit,dci.Prix,c.Nom_Categorie";
                    ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);

                    ADO.sda.Fill(dataSet, "Commande");
                    ticketRapport.SetDataSource(dataSet.Tables["Commande"]);
                    ticketRapport.SetParameterValue("Date_Debut", DPDateDebut.Text);
                    ticketRapport.SetParameterValue("Date_Fin", DPDateFin.Text);
                    ticketRapport.SetParameterValue("Serveur", "TOUS");

                    //- If You Want To Select A Specific Printer By Name
                    ticketRapport.PrintToPrinter(0, false, 1, 1);
                    ticketRapport.PrintOptions.PrinterName = "Microsoft Print to PDF";
                    //ticketCuisine.PrintToPrinter(0, false, 1, 1);
                    //ticketCuisine.PrintOptions.PrinterName = "A5";
                    //Print impression = new Print();
                    //Print.ticketNom = "Rapport";
                    //impression.ShowDialog();
                }
            }
            else if (!CmbUtilisateur.Text.Equals("TOUS") && !CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix,c.Nom_Categorie";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);

                        ADO.sda.Fill(dataSet, "Commande");
                        ticketRapport.SetDataSource(dataSet.Tables["Commande"]);
                        ticketRapport.SetParameterValue("Date_Debut", DPDateDebut.Text);
                        ticketRapport.SetParameterValue("Date_Fin", DPDateFin.Text);
                        ticketRapport.SetParameterValue("Serveur", "TOUS");

                        //- If You Want To Select A Specific Printer By Name
                        ticketRapport.PrintToPrinter(0, false, 1, 1);
                        ticketRapport.PrintOptions.PrinterName = "Microsoft Print to PDF";
                        //ticketCuisine.PrintToPrinter(0, false, 1, 1);
                        //ticketCuisine.PrintOptions.PrinterName = "A5";
                        //Print impression = new Print();
                        //Print.ticketNom = "Rapport";
                        //impression.ShowDialog();
                    }
                    else
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=@Id_Produit and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix,c.Nom_Categorie";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                    }
                }
                else
                {
                    Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and p.Id_CategorieProduit=@Id_Categorie and dci.Id_Produit=0 group by p.Nom_Produit,dci.Prix,c.Nom_Categorie";
                    ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);

                    ADO.sda.Fill(dataSet, "Commande");
                    ticketRapport.SetDataSource(dataSet.Tables["Commande"]);
                    ticketRapport.SetParameterValue("Date_Debut", DPDateDebut.Text);
                    ticketRapport.SetParameterValue("Date_Fin", DPDateFin.Text);
                    ticketRapport.SetParameterValue("Serveur", "TOUS");

                    //- If You Want To Select A Specific Printer By Name
                    ticketRapport.PrintToPrinter(0, false, 1, 1);
                    ticketRapport.PrintOptions.PrinterName = "Microsoft Print to PDF";
                    //ticketCuisine.PrintToPrinter(0, false, 1, 1);
                    //ticketCuisine.PrintOptions.PrinterName = "A5";
                    //Print impression = new Print();
                    //Print.ticketNom = "Rapport";
                    //impression.ShowDialog();
                }
            }
            else if (CmbUtilisateur.Text.Equals("TOUS") && !CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix,c.Nom_Categorie";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);

                        ADO.sda.Fill(dataSet, "Commande");
                        ticketRapport.SetDataSource(dataSet.Tables["Commande"]);
                        ticketRapport.SetParameterValue("Date_Debut", DPDateDebut.Text);
                        ticketRapport.SetParameterValue("Date_Fin", DPDateFin.Text);
                        ticketRapport.SetParameterValue("Serveur", "TOUS");

                        //- If You Want To Select A Specific Printer By Name
                        ticketRapport.PrintToPrinter(0, false, 1, 1);
                        ticketRapport.PrintOptions.PrinterName = "Microsoft Print to PDF";
                        //ticketCuisine.PrintToPrinter(0, false, 1, 1);
                        //ticketCuisine.PrintOptions.PrinterName = "A5";
                        //Print impression = new Print();
                        //Print.ticketNom = "Rapport";
                        //impression.ShowDialog();
                    }
                    else
                    {
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and p.Id_CategorieProduit=@Id_Categorie and dci.Id_Produit=@Id_Produit group by p.Nom_Produit,dci.Prix,c.Nom_Categorie";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);

                        ADO.sda.Fill(dataSet, "Commande");
                        ticketRapport.SetDataSource(dataSet.Tables["Commande"]);
                        ticketRapport.SetParameterValue("Date_Debut", DPDateDebut.Text);
                        ticketRapport.SetParameterValue("Date_Fin", DPDateFin.Text);
                        ticketRapport.SetParameterValue("Serveur", "TOUS");

                        Print impression = new Print();
                        Print.ticketNom = "Rapport";
                        impression.ShowDialog();
                        //ticketCuisine.PrintToPrinter(0, false, 1, 1);
                        //ticketCuisine.PrintOptions.PrinterName = "A5";
                        //Print impression = new Print();
                        //Print.ticketNom = "Rapport";
                        //impression.ShowDialog();
                    }
                }
                else
                {
                    Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and p.Id_CategorieProduit=@Id_Categorie and dci.Id_Produit=0 group by p.Nom_Produit,dci.Prix,c.Nom_Categorie";
                    ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);

                    ADO.sda.Fill(dataSet, "Commande");
                    ticketRapport.SetDataSource(dataSet.Tables["Commande"]);
                    ticketRapport.SetParameterValue("Date_Debut", DPDateDebut.Text);
                    ticketRapport.SetParameterValue("Date_Fin", DPDateFin.Text);
                    ticketRapport.SetParameterValue("Serveur", "TOUS");

                    Print impression = new Print();
                    Print.ticketNom = "Rapport";
                    impression.ShowDialog();
                    //ticketCuisine.PrintToPrinter(0, false, 1, 1);
                    //ticketCuisine.PrintOptions.PrinterName = "A5";
                    //Print impression = new Print();
                    //Print.ticketNom = "Rapport";
                    //impression.ShowDialog();
                }
            }
            else if (CmbUtilisateur.Text.Equals("TOUS") && !CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (!CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and dci.Id_Produit=@Id_Produit and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix,c.Nom_Categorie";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);

                        ADO.sda.Fill(dataSet, "Commande");
                        ticketRapport.SetDataSource(dataSet.Tables["Commande"]);
                        ticketRapport.SetParameterValue("Date_Debut", DPDateDebut.Text);
                        ticketRapport.SetParameterValue("Date_Fin", DPDateFin.Text);
                        ticketRapport.SetParameterValue("Serveur", "TOUS");

                        Print impression = new Print();
                        Print.ticketNom = "Rapport";
                        impression.ShowDialog();
                        //ticketCuisine.PrintToPrinter(0, false, 1, 1);
                        //ticketCuisine.PrintOptions.PrinterName = "A5";
                        //Print impression = new Print();
                        //Print.ticketNom = "Rapport";
                        //impression.ShowDialog();
                    }
                    else
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin /*and dci.Id_Produit=@Id_Produit*/ and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix,c.Nom_Categorie";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);

                        ADO.sda.Fill(dataSet, "Commande");
                        ticketRapport.SetDataSource(dataSet.Tables["Commande"]);
                        ticketRapport.SetParameterValue("Date_Debut", DPDateDebut.Text);
                        ticketRapport.SetParameterValue("Date_Fin", DPDateFin.Text);
                        ticketRapport.SetParameterValue("Serveur", "TOUS");

                        Print impression = new Print();
                        Print.ticketNom = "Rapport";
                        impression.ShowDialog();
                        //ticketCuisine.PrintToPrinter(0, false, 1, 1);
                        //ticketCuisine.PrintOptions.PrinterName = "A5";
                        //Print impression = new Print();
                        //Print.ticketNom = "Rapport";
                        //impression.ShowDialog();
                    }
                }
                else
                {
                    Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total',c.Nom_Categorie as 'Categorie' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p,Categorie c where c.Id_Categorie=p.Id_CategorieProduit and dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin /*and dci.Id_Produit=@Id_Produit*/ and p.Id_CategorieProduit=@Id_Categorie and dci.Id_Produit=0 group by p.Nom_Produit,dci.Prix,c.Nom_Categorie";
                    ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);

                    ADO.sda.Fill(dataSet, "Commande");
                    ticketRapport.SetDataSource(dataSet.Tables["Commande"]);
                    ticketRapport.SetParameterValue("Date_Debut", DPDateDebut.Text);
                    ticketRapport.SetParameterValue("Date_Fin", DPDateFin.Text);
                    ticketRapport.SetParameterValue("Serveur", "TOUS");

                    Print impression = new Print();
                    Print.ticketNom = "Rapport";
                    impression.ShowDialog();
                    //ticketCuisine.PrintToPrinter(0, false, 1, 1);
                    //ticketCuisine.PrintOptions.PrinterName = "A5";
                    //Print impression = new Print();
                    //Print.ticketNom = "Rapport";
                    //impression.ShowDialog();
                }
            }

            ADO.Deconnecter();
        }

        //private async void BtnExporter_Click(object sender, EventArgs e)
        //{
        //    if (DGVListeVentes.Rows.Count > 0)
        //    {
        //        if (DGVListeVentes.Columns.Count > 1)
        //        {
        //            pictureBoxLoading.Visible = true;

        //            await Task.Delay(TimeSpan.FromSeconds(1));

        //            string fileName = GenerateFiles.GenerateExcel("RapportVentesTemplate.xlsx", "Rapport des ventes", DGVListeVentes, CmbUtilisateur.Text, CmbCategories.Text, CmbProduits.Text, DPDateDebut.Value.ToShortDateString(), DPDateFin.Value.ToShortDateString());

        //            if (fileName != "")
        //            {
        //                pictureBoxLoading.Invoke(new Action(() =>
        //                {
        //                    pictureBoxLoading.Visible = false;
        //                }));

        //                SaveFileDialog sfd = new SaveFileDialog
        //                {
        //                    Filter = "Excel (*.xslx)|*.xslx",
        //                    FileName = fileName,
        //                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        //                };

        //                if (sfd.ShowDialog() == DialogResult.OK)
        //                {
        //                    try
        //                    {
        //                        string dirSaveDocs = ConfigurationManager.AppSettings["TempFilesPathExcel"];
        //                        string DestFileName = Path.GetFullPath(sfd.FileName);
        //                        string SourceFileName = Path.GetFullPath(Path.Combine(dirSaveDocs, fileName));
        //                        File.Copy(SourceFileName, DestFileName, true);
        //                        MessageBox.Show("Le rapport est bien enregistré !", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    }
        //                    catch (IOException ex)
        //                    {
        //                        MessageBox.Show("Message d'erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        private async void BtnExporter_Click(object sender, EventArgs e)
        {
            if (DGVListeVentes.Rows.Count == 0 || DGVListeVentes.Columns.Count <= 1)
            {
                return; // Nothing to export
            }

            pictureBoxLoading.Visible = true;

            await Task.Delay(TimeSpan.FromSeconds(1));

            //string fileName = GenerateFiles.GenerateExcel("RapportVentesTemplate.xlsx", "Rapport des ventes", DGVListeVentes, CmbUtilisateur.Text, CmbCategories.Text, CmbProduits.Text, DPDateDebut.Value.ToShortDateString(), DPDateFin.Value.ToShortDateString());

            string fileName = await GenerateFiles.GenerateExcelAsync("RapportVentesTemplate.xlsx", "Rapport des ventes", DGVListeVentes, CmbUtilisateur.Text, CmbCategories.Text, CmbProduits.Text, DPDateDebut.Value.ToShortDateString(), DPDateFin.Value.ToShortDateString());

            if (!string.IsNullOrEmpty(fileName))
            {
                pictureBoxLoading.Invoke(new Action(() =>
                {
                    pictureBoxLoading.Visible = false;
                }));

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel (*.xlsx)|*.xlsx",
                    FileName = fileName,
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string dirSaveDocs = ConfigurationManager.AppSettings["TempFilesPathExcel"];
                        string DestFileName = Path.GetFullPath(sfd.FileName);
                        string SourceFileName = Path.GetFullPath(Path.Combine(dirSaveDocs, fileName));
                        File.Copy(SourceFileName, DestFileName, true);
                        MessageBox.Show("Le rapport est bien enregistré !", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Message d'erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private async void BtnWord_Click(object sender, EventArgs e)
        {
            if (DGVListeVentes.Rows.Count > 0)
            {
                if (DGVListeVentes.Columns.Count > 1)
                {
                    pictureBoxLoading.Visible = true;

                    await Task.Delay(TimeSpan.FromSeconds(1));

                    //string fileName = GenerateFiles.GenerateWord("RapportVentesTemplate.docx", DGVListeVentes, CmbUtilisateur.Text, CmbCategories.Text, CmbProduits.Text, DPDateDebut.Value.ToShortDateString(), DPDateFin.Value.ToShortDateString());

                    string fileName = await GenerateFiles.GenerateWordAsync("RapportVentesTemplate.docx", DGVListeVentes, CmbUtilisateur.Text, CmbCategories.Text, CmbProduits.Text, DPDateDebut.Value.ToShortDateString(), DPDateFin.Value.ToShortDateString());

                    if (fileName != "")
                    {
                        pictureBoxLoading.Visible = false;

                        SaveFileDialog sfd = new SaveFileDialog
                        {
                            Filter = "Word (*.docx)|*.docx",
                            FileName = fileName,
                            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                        };

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                string dirSaveDocs = ConfigurationManager.AppSettings["TempFilesPathWord"];
                                string DestFileName = Path.GetFullPath(sfd.FileName);
                                string SourceFileName = Path.GetFullPath(Path.Combine(dirSaveDocs, fileName));
                                File.Copy(SourceFileName, DestFileName, true);
                                MessageBox.Show("Le rapport est bien enregistrer !", "Enregister", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //File.Delete(sfd.FileName);
                            }
                            catch (IOException ex)
                            {
                                MessageBox.Show("Message d'erreur : " + ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }
    }
}
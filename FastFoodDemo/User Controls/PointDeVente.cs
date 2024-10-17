using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FastFoodDemo.Classes;
using FastFoodDemo.Rapports;
using FastFoodDemo.DataSets;
using System.Runtime.InteropServices;

namespace FastFoodDemo.User_Controls
{
    public partial class PointDeVente : UserControl
    {
        public PointDeVente()
        {
            InitializeComponent();
        }

        ADO ADO = new ADO();

        public static CrystalReportTicketCuisine ticketCuisine = new CrystalReportTicketCuisine();
        public static CrystalReportTicketClient ticketClient = new CrystalReportTicketClient();

        public static string Nom = "";

        public static long IdDetailCmd;

        public static int EtatTables;

        public int SelectedIdCategorie = 0;

        public string CheckIdDetailCommandeEtat(string IdDetail)
        {
            string Etat = "";

            ADO.Connecter();

            ADO.sda = new SqlDataAdapter("select Etat from DetailsCommandeImprimante where Id_DetailCommande=@Id_DetailCommande", ADO.con);
            ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_DetailCommande", IdDetail);

            DataTable table = new DataTable();

            ADO.sda.Fill(table);

            ADO.Deconnecter();

            if (table.Rows.Count == 1)
            {
                Etat = table.Rows[0][0].ToString();
            }

            return Etat;
        }

        public void CheckAutorisationParRole()
        {
            ADO.Connecter();
            string Role = Form1.GeneralInstance.LblRole.Text;
            if (!Role.Equals(ADO.UserRoles.Admin.ToString()))
            {
                ADO.sda = new SqlDataAdapter("select SuppressionCaisse,AnnulationCaisse,ValidationCaisse,OuvrirTiroirCaisse,ImprimerTicketCuisineCaisse,ImprimerTicketClientCaisse,Remise from Autorisation where Role=@Role", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@Role", Role);
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                if (table.Rows.Count > 0)
                {
                    if (table.Rows[0][1].ToString().Equals("Non"))
                        BtnAnnulerCommande.Enabled = false;
                    if (table.Rows[0][2].ToString().Equals("Non"))
                        BtnValiderCommande.Enabled = false;
                    if (table.Rows[0][3].ToString().Equals("Non"))
                        BtnOuvrirTiroir.Enabled = false;
                    if (table.Rows[0][6].ToString().Equals("Non"))
                        BtnRemise.Enabled = false;
                }
            }
        }

        //private void ListeCategories()
        //{
        //    ADO.Connecter();

        //    ADO.cmd = new SqlCommand("select Image_Categorie,Id_Categorie,Nom_Categorie from Categorie/* where Id_Categorie in (select Id_CategorieP from Produit)*/", ADO.con);
        //    DataTable tble = new DataTable();
        //    ADO.dr = ADO.cmd.ExecuteReader();
        //    FlwpnlCategories.Controls.Clear();

        //    while (ADO.dr.Read())
        //    {
        //        long len = ADO.dr.GetBytes(0, 0, null, 0, 0);
        //        byte[] array = new byte[Convert.ToInt32(len) + 1];
        //        ADO.dr.GetBytes(0, 0, array, 0, Convert.ToInt32(len));

        //        //RoundPictureBox picture = new RoundPictureBox();
        //        //picture.Width = 105;
        //        //picture.Height = 100;
        //        //picture.BackgroundImageLayout = ImageLayout.Stretch;
        //        //picture.BorderStyle = BorderStyle.Fixed3D;
        //        //picture.Tag = ADO.dr["Id_Categorie"].ToString();

        //        //Label nom = new Label();
        //        //nom.Text = ADO.dr["Nom_Categorie"].ToString();
        //        //nom.BackColor = Color.Green;
        //        //nom.Tag = ADO.dr["Id_Categorie"].ToString();

        //        //if (nom.Text == "Pizza")
        //        //{
        //        //    nom.Text += " 🍕";
        //        //    nom.BackColor = Color.FromArgb(90, 67, 57);
        //        //    nom.ForeColor = Color.White;
        //        //    nom.TextAlign = ContentAlignment.MiddleCenter;
        //        //    nom.Font = new Font("Century Gothic", 10, FontStyle.Bold);
        //        //    nom.Dock = DockStyle.Bottom;
        //        //}
        //        //else if (nom.Text == "SALADE")
        //        //{
        //        //    nom.Text += " 🥗";
        //        //    nom.BackColor = Color.FromArgb(90, 67, 57);
        //        //    nom.ForeColor = Color.White;
        //        //    nom.TextAlign = ContentAlignment.MiddleCenter;
        //        //    nom.Font = new Font("Century Gothic", 10, FontStyle.Bold);
        //        //    nom.Dock = DockStyle.Bottom;
        //        //}
        //        //else if (nom.Text == "BOISSONS")
        //        //{
        //        //    nom.Text += " 🍹";
        //        //    nom.BackColor = Color.FromArgb(90, 67, 57);
        //        //    nom.ForeColor = Color.White;
        //        //    nom.TextAlign = ContentAlignment.MiddleCenter;
        //        //    nom.Font = new Font("Century Gothic", 10, FontStyle.Bold);
        //        //    nom.Dock = DockStyle.Bottom;
        //        //}
        //        //else if (nom.Text == "Café")
        //        //{
        //        //    nom.Text += " ☕";
        //        //    nom.BackColor = Color.FromArgb(90, 67, 57);
        //        //    nom.ForeColor = Color.White;
        //        //    nom.TextAlign = ContentAlignment.MiddleCenter;
        //        //    nom.Font = new Font("Century Gothic", 10, FontStyle.Bold);
        //        //    nom.Dock = DockStyle.Bottom;
        //        //}
        //        //else if (nom.Text == "SANDWICH")
        //        //{
        //        //    nom.Text += " 🌭";
        //        //    nom.BackColor = Color.FromArgb(90, 67, 57);
        //        //    nom.ForeColor = Color.White;
        //        //    nom.TextAlign = ContentAlignment.MiddleCenter;
        //        //    nom.Font = new Font("Century Gothic", 10, FontStyle.Bold);
        //        //    nom.Dock = DockStyle.Bottom;
        //        //}
        //        //else
        //        //{
        //        //    nom.ForeColor = Color.White;
        //        //    nom.BackColor = Color.FromArgb(90, 67, 57);
        //        //    nom.TextAlign = ContentAlignment.MiddleCenter;
        //        //    nom.Font = new Font("Century Gothic", 10, FontStyle.Bold);
        //        //    nom.Dock = DockStyle.Bottom;
        //        //}

        //        MemoryStream ms = new MemoryStream(array);
        //        Bitmap bitmap = new Bitmap(ms);

        //        //picture.BackgroundImage = bitmap;
        //        //picture.Controls.Add(nom);
        //        //picture.Cursor = Cursors.Hand;

        //        //FlwpnlCategories.Controls.Add(picture);

        //        Categorie categorie = new Categorie();
        //        categorie.imageCategories = bitmap;
        //        categorie.nomCategories = ADO.dr["Nom_Categorie"].ToString();
        //        categorie.Tag = ADO.dr["Id_Categorie"].ToString();
        //        categorie.LblNomCategorie.Tag = ADO.dr["Id_Categorie"].ToString();
        //        categorie.Cursor = Cursors.Hand;

        //        FlwpnlCategories.Controls.Add(categorie);

        //        categorie.Click += PictureClickCategorie;

        //        categorie.LblNomCategorie.Click += new EventHandler(this.NomClickCategorie);
        //    }
        //    ADO.Deconnecter();
        //}

        private void ListeCategories()
        {
            ADO.Connecter();

            using (var cmd = new SqlCommand("select Image_Categorie,Id_Categorie,Nom_Categorie from Categorie where IsDeleted is null or IsDeleted=0", ADO.con))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                DataTable tble = new DataTable();
                adapter.Fill(tble);

                FlwpnlCategories.SuspendLayout();
                FlwpnlCategories.Controls.Clear();

                foreach (DataRow row in tble.Rows)
                {
                    byte[] imageData = (byte[])row["Image_Categorie"];
                    Bitmap bitmap;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        bitmap = new Bitmap(ms);
                    }

                    Categorie categorie = new Categorie();
                    categorie.imageCategories = bitmap;
                    categorie.nomCategories = row["Nom_Categorie"].ToString();
                    categorie.Tag = row["Id_Categorie"].ToString();
                    categorie.LblNomCategorie.Tag = row["Id_Categorie"].ToString();
                    categorie.Cursor = Cursors.Hand;

                    FlwpnlCategories.Controls.Add(categorie);

                    categorie.Click += PictureClickCategorie;
                    categorie.LblNomCategorie.Click += NomClickCategorie;
                }

                FlwpnlCategories.ResumeLayout();
            }

            ADO.Deconnecter();
        }

        public string IdDetailCommande()
        {
            ADO.Connecter();

            string IdDetail = "";

            ADO.sda = new SqlDataAdapter("select IDENT_CURRENT('DetailsCommandeImprimante') + 1 as 'Id Détails'", ADO.con);
            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            ADO.Deconnecter();
            if (table.Rows.Count == 1)
            {
                IdDetail = table.Rows[0][0].ToString();
            }

            return IdDetail;

        }

        public string EtatTable()
        {
            string Trouve = "";

            if (ADO.CheckEspaceTables() && ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("select Etat from TablesEspace where Nom=@Nom", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom", Form1.NomTable());
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                if (table.Rows.Count == 1)
                {
                    string Etat_table = table.Rows[0][0].ToString();
                    Trouve = Etat_table;
                    return Trouve;
                }
            }
            else
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("select Etat from TableDefault", ADO.con);
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                if (table.Rows.Count == 1)
                {
                    string Etat_table = table.Rows[0][0].ToString();
                    Trouve = Etat_table;
                    return Trouve;
                }
            }
            ADO.Deconnecter();

            return Trouve;
        }

        public string IdCommande()
        {

            string Idcommande = "";

            string Query = "";

            int State = 0;

            if (ADO.CheckEspaceTables() && ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
            {
                // Etat Table Is 0 => Free Table
                if (EtatTable().Equals("0"))
                {
                    Query = "select top 1 ISNULL(MAX(Id_Commande),0) + 1 as 'Référenece' from DetailsCommandeImprimante";
                }
                // Etat Table Is Not 0 => Not Free Table
                else
                {
                    Query = "select ISNULL(MAX(Id_Commande),1) as 'Référenece' from DetailsCommandeImprimante where Nom_Table=@Nom_Table";
                    State = 1;
                }
            }
            else
            {
                if (EtatTable().Equals("0"))
                {
                    Query = "select ISNULL(MAX(Id_Commande),0) + 1 as 'Référenece' from DetailsCommandeImprimante";
                }
                else
                {
                    Query = "select ISNULL(MAX(Id_Commande),1) as 'Référenece' from DetailsCommandeImprimante";
                }
            }

            ADO.Connecter();
            ADO.sda = new SqlDataAdapter(Query, ADO.con);

            if (State == 1)
                ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom_Table", Form1.NomTable());

            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            ADO.Deconnecter();
            if (table.Rows.Count > 0)
            {
                Idcommande = table.Rows[0][0].ToString();
            }

            return Idcommande;
        }

        //public string IdImprimante(string Idproduit)
        //{
        //    ADO.Connecter();

        //    string Idimprimante = "";

        //    ADO.sda = new SqlDataAdapter("select Id_Imprimante from Imprimante where Id_Imprimante in (select Id_Imprimante from Imprimante_Categorie where Id_Categorie in (select Id_CategorieProduit from Produit where Id_Produit=@IdProduit))", ADO.con);
        //    DataTable table = new DataTable();
        //    ADO.sda.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        Idimprimante = table.Rows[0][0].ToString();
        //    }

        //    return Idimprimante;

        //}

        public string NomProdui(string Idproduit)
        {
            ADO.Connecter();

            string Nom = "";

            ADO.sda = new SqlDataAdapter("select Nom_Produit from Produit where Id_Produit=@Id_Produit", ADO.con);
            ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", Idproduit);
            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            ADO.Deconnecter();
            if (table.Rows.Count == 1)
            {
                Nom = table.Rows[0][0].ToString();
            }

            return Nom;

        }

        public string PrixProdui(string Idproduit)
        {
            ADO.Connecter();

            string Prix = "";

            ADO.sda = new SqlDataAdapter("select Prix_Normal from Produit where Id_Produit=@Id_Produit", ADO.con);
            ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", Idproduit);
            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            ADO.Deconnecter();
            if (table.Rows.Count == 1)
            {
                Prix = table.Rows[0][0].ToString();
            }

            return Prix;

        }

        public void UpdateEtatTable(string nomtable, string etat)
        {
            if (ADO.CheckEspaceTables())
            {
                ADO.Connecter();
                ADO.cmd = new SqlCommand("update TablesEspace set Etat=@Etat where Nom=@Nom", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Nom", nomtable);
                ADO.cmd.Parameters.AddWithValue("@Etat", etat);
                ADO.cmd.ExecuteNonQuery();
            }
            else
            {
                ADO.Connecter();
                ADO.cmd = new SqlCommand("update TableDefault set Etat=@Etat where Nom=@Nom", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Nom", nomtable);
                ADO.cmd.Parameters.AddWithValue("@Etat", etat);
                ADO.cmd.ExecuteNonQuery();
            }

            ADO.Deconnecter();
        }

        public void Ajouter_CommandeParImage(object sender, EventArgs e)
        {
            String tag = ((Produit)sender).Tag.ToString();

            string IdCategorie = ADO.IdCategorieParProduit(int.Parse(tag));

            Nom = ADO.NomProduitById(int.Parse(tag));
            string IdDetailcommande = IdDetailCommande();
            string Idcommande = IdCommande();
            string Idimprimante = ADO.IdImprimanteParCategorie(int.Parse(IdCategorie));
            string Idproduit = tag;
            string Dateproduit = DateTime.Now.ToString();
            string Quantite = "1";
            string Serveur = Form1.GeneralInstance.LblUtilisateur.Text;
            string Nomtable = Form1.NomTable();
            string Etat = "0";

            if (ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
            {
                if (ADO.CheckProduitExistsInStock(int.Parse(Idproduit)))
                {
                    if (ADO.CheckProduitDisponibleInStock(int.Parse(Idproduit)) > 0)
                    {
                        ADO.Connecter();

                        ADO.cmd = new SqlCommand("insert into DetailsCommandeImprimante values(@Id_Commande,@Id_Imprimante,@Id_Produit,@Date_Produit,@Quantite,@Prix,@Serveur,@Nom_Table,@Etat)", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
                        ADO.cmd.Parameters.AddWithValue("@Id_Imprimante", Idimprimante);
                        ADO.cmd.Parameters.AddWithValue("@Id_Produit", Idproduit);
                        ADO.cmd.Parameters.AddWithValue("@Date_Produit", Convert.ToDateTime(Dateproduit));
                        ADO.cmd.Parameters.AddWithValue("@Quantite", Quantite);
                        ADO.cmd.Parameters.AddWithValue("@Prix", decimal.Parse(ADO.PrixProduitById(int.Parse(Idproduit))));
                        ADO.cmd.Parameters.AddWithValue("@Serveur", Serveur);
                        ADO.cmd.Parameters.AddWithValue("@Nom_Table", Nomtable);
                        ADO.cmd.Parameters.AddWithValue("@Etat", Etat);
                        ADO.Connecter();
                        ADO.cmd.ExecuteNonQuery();
                        ADO.Deconnecter();

                        DGVDetailsCommande.Rows.Insert(0, IdDetailcommande, Idproduit, ADO.NomProduitById(int.Parse(Idproduit)), "1.00", ADO.PrixProduitById(int.Parse(Idproduit)));
                        UpdateEtatTable(Form1.NomTable(), "1");
                        Totals();

                        ADO.Connecter();

                        ADO.cmd = new SqlCommand("update ProduitEnStock set Stock_Sortie+=@Stock_Sortie where Id_Produit=@Id_Produit", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@Stock_Sortie", Quantite);
                        ADO.cmd.Parameters.AddWithValue("@Id_Produit", Idproduit);
                        ADO.cmd.ExecuteNonQuery();

                        ADO.Deconnecter();

                        DGVDetailsCommande.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Ce produit est indisponible en stock !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    ADO.Connecter();

                    ADO.cmd = new SqlCommand("insert into DetailsCommandeImprimante values(@Id_Commande,@Id_Imprimante,@Id_Produit,@Date_Produit,@Quantite,@Prix,@Serveur,@Nom_Table,@Etat)", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
                    ADO.cmd.Parameters.AddWithValue("@Id_Imprimante", Idimprimante);
                    ADO.cmd.Parameters.AddWithValue("@Id_Produit", Idproduit);
                    ADO.cmd.Parameters.AddWithValue("@Date_Produit", Convert.ToDateTime(Dateproduit));
                    ADO.cmd.Parameters.AddWithValue("@Quantite", Quantite);
                    ADO.cmd.Parameters.AddWithValue("@Prix", decimal.Parse(ADO.PrixProduitById(int.Parse(Idproduit))));
                    ADO.cmd.Parameters.AddWithValue("@Serveur", Serveur);
                    ADO.cmd.Parameters.AddWithValue("@Nom_Table", Nomtable);
                    ADO.cmd.Parameters.AddWithValue("@Etat", Etat);
                    ADO.Connecter();
                    ADO.cmd.ExecuteNonQuery();
                    ADO.Deconnecter();

                    DGVDetailsCommande.Rows.Insert(0, IdDetailcommande, Idproduit, ADO.NomProduitById(int.Parse(Idproduit)), "1.00", ADO.PrixProduitById(int.Parse(Idproduit)));
                    UpdateEtatTable(Form1.NomTable(), "1");
                    Totals();

                    DGVDetailsCommande.ClearSelection();
                }
            }
            else
            {
                if (Nom != "")
                {
                    TxtNomProduit.Text = Nom;
                    TxtPrixTotal.Text = TxtPrixProduit.Text = ADO.PrixProduitById(int.Parse(Idproduit));
                    PnlAjouterQuantite.Location = new Point(400, 150);
                    PnlAjouterQuantite.Visible = true;
                    PnlAjouterQuantite.BringToFront();
                }
            }
        }

        public void Ajouter_CommandeParNom(object sender, EventArgs e)
        {
            String tag = ((Label)sender).Tag.ToString();

            string IdCategorie = ADO.IdCategorieParProduit(int.Parse(tag));

            Nom = ADO.NomProduitById(int.Parse(tag));
            string IdDetailcommande = IdDetailCommande();
            string Idcommande = IdCommande();
            string Idimprimante = ADO.IdImprimanteParCategorie(int.Parse(IdCategorie));
            string Idproduit = tag;
            string Dateproduit = DateTime.Now.ToString();
            string Quantite = "1";
            string Serveur = Form1.GeneralInstance.LblUtilisateur.Text;
            string Nomtable = Form1.NomTable();
            string Etat = "0";

            if (ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
            {
                if (ADO.CheckProduitExistsInStock(int.Parse(Idproduit)))
                {
                    if (ADO.CheckProduitDisponibleInStock(int.Parse(Idproduit)) > 0)
                    {
                        ADO.Connecter();

                        ADO.cmd = new SqlCommand("insert into DetailsCommandeImprimante values(@Id_Commande,@Id_Imprimante,@Id_Produit,@Date_Produit,@Quantite,@Prix,@Serveur,@Nom_Table,@Etat)", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
                        ADO.cmd.Parameters.AddWithValue("@Id_Imprimante", Idimprimante);
                        ADO.cmd.Parameters.AddWithValue("@Id_Produit", Idproduit);
                        ADO.cmd.Parameters.AddWithValue("@Date_Produit", Convert.ToDateTime(Dateproduit));
                        ADO.cmd.Parameters.AddWithValue("@Quantite", Quantite);
                        ADO.cmd.Parameters.AddWithValue("@Prix", decimal.Parse(ADO.PrixProduitById(int.Parse(Idproduit))));
                        ADO.cmd.Parameters.AddWithValue("@Serveur", Serveur);
                        ADO.cmd.Parameters.AddWithValue("@Nom_Table", Nomtable);
                        ADO.cmd.Parameters.AddWithValue("@Etat", Etat);
                        ADO.Connecter();
                        ADO.cmd.ExecuteNonQuery();
                        ADO.Deconnecter();

                        DGVDetailsCommande.Rows.Insert(0, IdDetailcommande, Idproduit, ADO.NomProduitById(int.Parse(Idproduit)), "1.00", ADO.PrixProduitById(int.Parse(Idproduit)));
                        UpdateEtatTable(Form1.NomTable(), "1");
                        Totals();

                        ADO.Connecter();

                        ADO.cmd = new SqlCommand("update ProduitEnStock set Stock_Sortie+=@Stock_Sortie where Id_Produit=@Id_Produit", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@Stock_Sortie", Quantite);
                        ADO.cmd.Parameters.AddWithValue("@Id_Produit", Idproduit);
                        ADO.cmd.ExecuteNonQuery();

                        ADO.Deconnecter();

                        DGVDetailsCommande.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Ce produit est indisponible en stock !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    ADO.Connecter();

                    ADO.cmd = new SqlCommand("insert into DetailsCommandeImprimante values(@Id_Commande,@Id_Imprimante,@Id_Produit,@Date_Produit,@Quantite,@Prix,@Serveur,@Nom_Table,@Etat)", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
                    ADO.cmd.Parameters.AddWithValue("@Id_Imprimante", Idimprimante);
                    ADO.cmd.Parameters.AddWithValue("@Id_Produit", Idproduit);
                    ADO.cmd.Parameters.AddWithValue("@Date_Produit", Convert.ToDateTime(Dateproduit));
                    ADO.cmd.Parameters.AddWithValue("@Quantite", Quantite);
                    ADO.cmd.Parameters.AddWithValue("@Prix", decimal.Parse(ADO.PrixProduitById(int.Parse(Idproduit))));
                    ADO.cmd.Parameters.AddWithValue("@Serveur", Serveur);
                    ADO.cmd.Parameters.AddWithValue("@Nom_Table", Nomtable);
                    ADO.cmd.Parameters.AddWithValue("@Etat", Etat);
                    ADO.Connecter();
                    ADO.cmd.ExecuteNonQuery();
                    ADO.Deconnecter();

                    DGVDetailsCommande.Rows.Insert(0, IdDetailcommande, Idproduit, ADO.NomProduitById(int.Parse(Idproduit)), "1.00", ADO.PrixProduitById(int.Parse(Idproduit)));
                    UpdateEtatTable(Form1.NomTable(), "1");
                    Totals();

                    DGVDetailsCommande.ClearSelection();
                }
            }
            else
            {
                if (Nom != "")
                {
                    TxtNomProduit.Text = Nom;
                    TxtPrixTotal.Text = TxtPrixProduit.Text = ADO.PrixProduitById(int.Parse(Idproduit));
                    PnlAjouterQuantite.Location = new Point(400, 150);
                    PnlAjouterQuantite.Visible = true;
                    PnlAjouterQuantite.BringToFront();
                }
            }
        }

        //public void PictureClickCategorie(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        FlwpnlProduits.Controls.Clear();
        //        String tag = ((Categorie)sender).Tag.ToString();
        //        SelectedIdCategorie = int.Parse(tag);

        //        ADO.Connecter();
        //        ADO.cmd = new SqlCommand("select Image_Produit,Nom_produit,Prix_Normal,Id_Produit,Prix_Livraison from Produit where Id_CategorieProduit=@id_c", ADO.con);
        //        ADO.cmd.Parameters.AddWithValue("@id_c", tag);
        //        DataTable table = new DataTable();
        //        ADO.dr = ADO.cmd.ExecuteReader();

        //        while (ADO.dr.Read())
        //        {
        //            long len = ADO.dr.GetBytes(0, 0, null, 0, 0);
        //            byte[] array = new byte[Convert.ToInt32(len) + 1];
        //            ADO.dr.GetBytes(0, 0, array, 0, Convert.ToInt32(len));
        //            //Guna2CirclePictureBox picture = new Guna2CirclePictureBox();
        //            //picture.Width = 116;
        //            //picture.Height = 104;
        //            //picture.BackgroundImageLayout = ImageLayout.Stretch;
        //            //picture.BorderStyle = BorderStyle.Fixed3D;
        //            //picture.Tag = ADO.dr["Id_Produit"].ToString();

        //            //Label price = new Label();
        //            //price.Text = (ADO.dr["Prix_Normal"].ToString());
        //            //price.AutoSize = true;
        //            //price.ForeColor = Color.White;
        //            //price.BackColor = Color.FromArgb(255, 156, 36);
        //            //price.TextAlign = ContentAlignment.MiddleLeft;
        //            //price.Font = new Font("Century Gothic", 10, FontStyle.Bold);
        //            ////price.Visible = false;
        //            //price.Tag = ADO.dr["Id_Produit"].ToString();

        //            //Label nom = new Label();
        //            //nom.Text = ADO.dr["Nom_produit"].ToString();
        //            //nom.Height = 32;
        //            //nom.ForeColor = Color.White;
        //            //nom.BackColor = Color.FromArgb(255, 140, 0);
        //            //nom.TextAlign = ContentAlignment.MiddleCenter;
        //            //nom.Font = new Font("Century Gothic", 9, FontStyle.Bold);
        //            //nom.Dock = DockStyle.Bottom;
        //            //nom.Tag = ADO.dr["Id_Produit"].ToString();

        //            MemoryStream ms = new MemoryStream(array);
        //            Bitmap bitmap = new Bitmap(ms);

        //            Produit produit = new Produit();
        //            produit.imageProduits = bitmap;
        //            produit.nomProduits = ADO.dr["Nom_produit"].ToString();

        //            if (TablesEspace.Zone.Equals("Emporter"))
        //            {
        //                produit.prixProduits = ADO.dr["Prix_Livraison"].ToString();
        //            }
        //            else
        //            {
        //                produit.prixProduits = ADO.dr["Prix_Normal"].ToString();
        //            }

        //            produit.Tag = ADO.dr["Id_Produit"].ToString();
        //            produit.LblNomProduit.Tag = ADO.dr["Id_Produit"].ToString();
        //            produit.Cursor = Cursors.Hand;

        //            FlwpnlProduits.Controls.Add(produit);

        //            produit.Click += Ajouter_CommandeParImage;
        //            produit.LblNomProduit.Click += Ajouter_CommandeParNom;

        //            //produit.Click += PictureClickCategorie;

        //            //produit.LblNomProduit.Click += new EventHandler(this.NomClickCategorie);

        //            //picture.BackgroundImage = bitmap;
        //            //picture.Controls.Add(price);
        //            //picture.Controls.Add(nom);
        //            //FlwpnlProduits.Controls.Add(picture);

        //            //picture.Cursor = Cursors.Hand;

        //            //picture.Click += new EventHandler(Ajouter_Commande);

        //            //price.Click += new EventHandler(Ajouter_Commande1);

        //            //nom.Click += new EventHandler(Ajouter_Commande1);

        //            Totals();
        //        }
        //        ADO.Deconnecter();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        public void PictureClickCategorie(object sender, EventArgs e)
        {
            try
            {
                String tag = ((Categorie)sender).Tag.ToString();

                if (SelectedIdCategorie == int.Parse(tag))
                {
                    return;
                }

                if (FlwpnlProduits.Controls.Count > 0)
                    FlwpnlProduits.Controls.Clear();

                SelectedIdCategorie = int.Parse(tag);

                ADO.Connecter();
                using (SqlCommand cmd = new SqlCommand("SELECT Image_Produit, Nom_produit, Prix_Normal, Prix_Livraison, Id_Produit FROM Produit WHERE Id_CategorieProduit = @id_c and IsDeleted=0", ADO.con))
                {
                    cmd.Parameters.AddWithValue("@id_c", tag);
                    DataTable table = new DataTable();
                    ADO.dr = cmd.ExecuteReader();

                    while (ADO.dr.Read())
                    {
                        byte[] imageBytes = (byte[])ADO.dr["Image_Produit"];
                        ImageConverter imageConverter = new ImageConverter();
                        Image image = (Image)imageConverter.ConvertFrom(imageBytes);

                        Produit produit = new Produit();
                        produit.imageProduits = image;
                        produit.nomProduits = ADO.dr["Nom_produit"].ToString();
                        produit.prixProduits = TablesEspace.Zone.Equals("Emporter") ? ADO.dr["Prix_Livraison"].ToString() : ADO.dr["Prix_Normal"].ToString();
                        produit.Tag = ADO.dr["Id_Produit"].ToString();
                        produit.LblNomProduit.Tag = ADO.dr["Id_Produit"].ToString();
                        produit.Cursor = Cursors.Hand;

                        FlwpnlProduits.Controls.Add(produit);

                        produit.Click += Ajouter_CommandeParImage;
                        produit.LblNomProduit.Click += Ajouter_CommandeParNom;

                        Totals();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //public void NomClickCategorie(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        FlwpnlProduits.Controls.Clear();
        //        String tag = ((Label)sender).Tag.ToString();
        //        SelectedIdCategorie = int.Parse(tag);

        //        ADO.Connecter();
        //        ADO.cmd = new SqlCommand("select Image_Produit,Nom_produit,Prix_Normal,Id_Produit,Prix_Livraison from Produit where Id_CategorieProduit=@id_c", ADO.con);
        //        ADO.cmd.Parameters.AddWithValue("@id_c", tag);
        //        DataTable table = new DataTable();
        //        ADO.dr = ADO.cmd.ExecuteReader();

        //        while (ADO.dr.Read())
        //        {
        //            long len = ADO.dr.GetBytes(0, 0, null, 0, 0);
        //            byte[] array = new byte[Convert.ToInt32(len) + 1];
        //            ADO.dr.GetBytes(0, 0, array, 0, Convert.ToInt32(len));

        //            MemoryStream ms = new MemoryStream(array);
        //            Bitmap bitmap = new Bitmap(ms);

        //            Produit produit = new Produit();
        //            produit.imageProduits = bitmap;
        //            produit.nomProduits = ADO.dr["Nom_produit"].ToString();

        //            if (TablesEspace.Zone.Equals("Emporter"))
        //            {
        //                produit.prixProduits = ADO.dr["Prix_Livraison"].ToString();
        //            }
        //            else
        //            {
        //                produit.prixProduits = ADO.dr["Prix_Normal"].ToString();
        //            }

        //            produit.Tag = ADO.dr["Id_Produit"].ToString();
        //            produit.LblNomProduit.Tag = ADO.dr["Id_Produit"].ToString();
        //            produit.Cursor = Cursors.Hand;

        //            FlwpnlProduits.Controls.Add(produit);

        //            produit.Click += Ajouter_CommandeParImage;
        //            produit.LblNomProduit.Click += Ajouter_CommandeParNom;

        //            //Guna2CirclePictureBox picture = new Guna2CirclePictureBox();
        //            //picture.Width = 130;
        //            //picture.Height = 104;
        //            //picture.BackgroundImageLayout = ImageLayout.Stretch;
        //            //picture.BorderStyle = BorderStyle.Fixed3D;
        //            //picture.Tag = ADO.dr["Id_Produit"].ToString();

        //            //Label price = new Label();
        //            //price.Text = (ADO.dr["Prix_Normal"].ToString());
        //            //price.AutoSize = true;
        //            //price.ForeColor = Color.White;
        //            //price.BackColor = Color.FromArgb(255, 156, 36);
        //            //price.TextAlign = ContentAlignment.MiddleLeft;
        //            //price.Font = new Font("Century Gothic", 10, FontStyle.Bold);
        //            ////price.Visible = false;
        //            //price.Tag = ADO.dr["Id_Produit"].ToString();

        //            //Label nom = new Label();
        //            //nom.Text = ADO.dr["Nom_produit"].ToString();
        //            //nom.Height = 32;
        //            //nom.ForeColor = Color.White;
        //            //nom.BackColor = Color.FromArgb(255, 140, 0);
        //            //nom.TextAlign = ContentAlignment.MiddleCenter;
        //            //nom.Font = new Font("Century Gothic", 9, FontStyle.Bold);
        //            //nom.Dock = DockStyle.Bottom;
        //            //nom.Tag = ADO.dr["Id_Produit"].ToString();

        //            //MemoryStream ms = new MemoryStream(array);
        //            //Bitmap bitmap = new Bitmap(ms);

        //            //picture.BackgroundImage = bitmap;
        //            //picture.Controls.Add(price);
        //            //picture.Controls.Add(nom);
        //            //FlwpnlProduits.Controls.Add(picture);

        //            //picture.Cursor = Cursors.Hand;

        //            //picture.Click += new EventHandler(Ajouter_Commande);

        //            //price.Click += new EventHandler(Ajouter_Commande1);

        //            //nom.Click += new EventHandler(Ajouter_Commande1);

        //            Totals();
        //        }
        //        ADO.Deconnecter();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        public void NomClickCategorie(object sender, EventArgs e)
        {
            try
            {
                String tag = ((Label)sender).Tag.ToString();

                if (SelectedIdCategorie == int.Parse(tag))
                {
                    return;
                }

                if (FlwpnlProduits.Controls.Count > 0)
                    FlwpnlProduits.Controls.Clear();

                SelectedIdCategorie = int.Parse(tag);

                ADO.Connecter();
                using (SqlCommand cmd = new SqlCommand("SELECT Image_Produit, Nom_produit, Prix_Normal, Prix_Livraison, Id_Produit FROM Produit WHERE Id_CategorieProduit = @id_c and IsDeleted=0", ADO.con))
                {
                    cmd.Parameters.AddWithValue("@id_c", tag);
                    ADO.dr = cmd.ExecuteReader();

                    while (ADO.dr.Read())
                    {
                        byte[] imageBytes = (byte[])ADO.dr["Image_Produit"];
                        ImageConverter imageConverter = new ImageConverter();
                        Image image = (Image)imageConverter.ConvertFrom(imageBytes);

                        Produit produit = new Produit();
                        produit.imageProduits = image;
                        produit.nomProduits = ADO.dr["Nom_produit"].ToString();
                        produit.prixProduits = TablesEspace.Zone.Equals("Emporter") ? ADO.dr["Prix_Livraison"].ToString() : ADO.dr["Prix_Normal"].ToString();
                        produit.Tag = ADO.dr["Id_Produit"].ToString();
                        produit.LblNomProduit.Tag = ADO.dr["Id_Produit"].ToString();
                        produit.Cursor = Cursors.Hand;

                        FlwpnlProduits.Controls.Add(produit);

                        produit.Click += Ajouter_CommandeParImage;
                        produit.LblNomProduit.Click += Ajouter_CommandeParNom;

                        Totals();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Totals()
        {
            try
            {
                if (DGVDetailsCommande.Rows.Count > 0)
                {
                    decimal Price = 0;

                    for (int i = 0; i < DGVDetailsCommande.Rows.Count; i++)
                    {
                        Price += Convert.ToDecimal(DGVDetailsCommande.Rows[i].Cells[4].Value.ToString()) * Convert.ToDecimal(DGVDetailsCommande.Rows[i].Cells[3].Value.ToString());
                    }

                    if (Price > 0)
                        LblMontantCommande.Text = Price.ToString("#.00");
                    else
                        LblMontantCommande.Text = "0.00";

                    LblMontantCommande.Visible = true;

                    if (DGVDetailsCommandeRemise.Rows.Count > 0)
                    {
                        decimal PriceRemise = 0;

                        for (int i = 0; i < DGVDetailsCommandeRemise.Rows.Count; i++)
                        {
                            PriceRemise += Convert.ToDecimal(DGVDetailsCommandeRemise.Rows[i].Cells[4].Value.ToString()) * Convert.ToDecimal(DGVDetailsCommandeRemise.Rows[i].Cells[3].Value.ToString());
                        }
                        if (PriceRemise == 0)
                            LblMontantCommandeRemise.Text = "0.00";
                        else
                            LblMontantCommandeRemise.Text = PriceRemise.ToString("#.00");
                        //LblMontantCommandeRemise.Visible = true;
                    }
                    else
                    {
                        LblMontantCommandeRemise.Text = "0.00";
                        LblMontantCommandeRemise.Visible = true;
                    }
                }
                else
                {
                    LblMontantCommande.Text = "0.00";
                    LblMontantCommande.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AffichierDetailCommande()
        {
            if (ADO.CheckEspaceTables())
            {
                if (!EtatTable().Equals("0"))
                {
                    //MessageBox.Show(EtatTable().ToString()+" "+ Form1.NomTable());
                    string Id = IdCommande();
                    string NomTable = Form1.NomTable();
                    ADO.Connecter();
                    ADO.sda = new SqlDataAdapter("select Id_DetailCommande,Id_Produit,Quantite,Prix from DetailsCommandeImprimante dci,TablesEspace te where te.Nom=dci.Nom_Table and Id_Commande=@Id_Commande and dci.Nom_Table=@Nom_Table and te.Etat!=0 order by Date_Produit desc", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Commande", Id);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom_Table", NomTable);
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        DGVDetailsCommande.Rows.Add(row[0].ToString(), row[1].ToString(), NomProdui(row[1].ToString()), row[2].ToString(), row[3].ToString());
                    }
                    DGVDetailsCommande.Columns[2].Width = 100;
                    Totals();
                    DGVDetailsCommande.ClearSelection();
                }
            }
            else
            {
                if (!EtatTable().Equals("0"))
                {
                    string Id = IdCommande();
                    ADO.Connecter();
                    ADO.sda = new SqlDataAdapter("select Id_DetailCommande,Id_Produit,Quantite,Prix from DetailsCommandeImprimante dci,TableDefault td where td.Nom=dci.Nom_Table and Id_Commande=@Id_Commande and td.Etat!=0 order by Date_Produit desc", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Commande", Id);
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        DGVDetailsCommande.Rows.Add(row[0].ToString(), row[1].ToString(), NomProdui(row[1].ToString()), row[2].ToString(), row[3].ToString());
                    }
                    DGVDetailsCommande.Columns[2].Width = 100;
                    Totals();
                    DGVDetailsCommande.ClearSelection();
                }
            }
            ADO.Deconnecter();
        }

        private void PointDeVente_Load(object sender, EventArgs e)
        {
            if (!ADO.CheckEspaceTables())
                BtnRetourVersTables.Enabled = false;
            CheckAutorisationParRole();
            ListeCategories();
            PnlHideScrollBar.BringToFront();
            AffichierDetailCommande();
            PnlNotes.Visible = false;
            Totals();
            if (ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Boulangerie.ToString()) || ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
            {
                if (ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Boulangerie.ToString()))
                    BtnImprimerTicketCuisine.Enabled = false;
                TxtBarcode.Visible = false;
                DGVDetailsCommande.Location = new Point(12, 47);
                DGVDetailsCommande.Height += 50;
            }
            else
            {
                BtnImprimerTicketCuisine.Enabled = false;
                TxtBarcode.Focus();
                DGVDetailsCommande.Location = new Point(12, 94);
            }
            this.Dock = DockStyle.Fill;
        }

        private void BtnScrollRight_Click(object sender, EventArgs e)
        {
            int ChangePositionRight = FlwpnlCategories.HorizontalScroll.Value + FlwpnlCategories.HorizontalScroll.SmallChange * 40;
            FlwpnlCategories.AutoScrollPosition = new Point(ChangePositionRight, 0);

            //MessageBox.Show(IdCommande());
        }

        private void BtnScrollLeft_Click(object sender, EventArgs e)
        {
            int ChangePositionLeft = FlwpnlCategories.HorizontalScroll.Value - FlwpnlCategories.HorizontalScroll.SmallChange * 40;
            FlwpnlCategories.AutoScrollPosition = new Point(ChangePositionLeft, 0);
        }

        private void DGVDetailsCommande_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void DGVDetailsCommande_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                string IdDetail = DGVDetailsCommande.SelectedRows[0].Cells[0].Value.ToString();

                if (!CheckIdDetailCommandeEtat(IdDetail).Equals("0"))
                    return;

                DialogResult dr = (MessageBox.Show("Voulez-vous vraiment supprimer ce produit ?", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
                if (dr == DialogResult.Yes)
                {
                    string Idproduit = DGVDetailsCommande.SelectedRows[0].Cells[1].Value.ToString();
                    string Quantite = DGVDetailsCommande.SelectedRows[0].Cells[3].Value.ToString();
                    string Idcommande = IdCommande();

                    if (ADO.CheckProduitExistsInStock(int.Parse(Idproduit)))
                    {
                        ADO.Connecter();

                        ADO.cmd = new SqlCommand("update ProduitEnStock set Stock_Sortie-=@Stock_Sortie where Id_Produit=@Id_Produit", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@Stock_Sortie", Quantite);
                        ADO.cmd.Parameters.AddWithValue("@Id_Produit", Idproduit);
                        ADO.cmd.ExecuteNonQuery();

                        ADO.Deconnecter();
                    }

                    ADO.Connecter();

                    ADO.cmd = new SqlCommand("delete from ProduitNotes where Id_DetailCommande=@IdDetail", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@IdDetail", IdDetail);
                    ADO.cmd.ExecuteNonQuery();

                    ADO.cmd = new SqlCommand("delete from DetailsCommandeImprimante where Id_DetailCommande=@Id_DetailCommande and Id_Commande=@Id_Commande", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Id_DetailCommande", IdDetail);
                    ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
                    ADO.cmd.ExecuteNonQuery();

                    ADO.Deconnecter();

                    DGVDetailsCommande.Rows.RemoveAt(DGVDetailsCommande.SelectedRows[0].Index);
                    if (DGVDetailsCommande.Rows.Count == 0)
                    {
                        UpdateEtatTable(Form1.NomTable(), "0");
                    }
                    Totals();
                    DGVDetailsCommande.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Opération de suppression pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (e.ColumnIndex == 6)
            {
                IdDetailCmd = long.Parse(DGVDetailsCommande.SelectedRows[0].Cells[0].Value.ToString());
                long IdDetailCmdEtat = ADO.CheckDetailCommandeEtatById(IdDetailCmd);

                //MessageBox.Show(IdDetailCmdEtat.ToString());

                if (IdDetailCmdEtat == 0)
                {
                    Form1.GeneralInstance.PnlHeader.Enabled = GroupBoxCategorie.Enabled = GroupBoxProduit.Enabled = GroupBoxDetailsCommande.Enabled = false;
                    PnlNotes.Visible = GroupBoxNote.Visible = true;
                    GroupBoxRemise.Visible = false;
                    PnlNotes.BringToFront();
                    TxtNote.Focus();
                    Produit.Text = DGVDetailsCommande.SelectedRows[0].Cells[2].Value.ToString();
                    //DGVDetailsCommande.Enabled = FlwpnlCategories.Enabled = FlwpnlProduits.Enabled = BtnValiderCommande.Enabled = BtnAnnulerCommande.Enabled = false;
                    AfficherNotes();
                    ADO.Connecter();
                    ADO.sda = new SqlDataAdapter("select Id_DetailCommande,Id_Note from ProduitNotes where Id_DetailCommande=@Id_DetailCommande", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_DetailCommande", IdDetailCmd);
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        DGVNotesSelectionnes.Rows.Clear();
                        foreach (DataRow row in table.Rows)
                        {
                            ADO.sda = new SqlDataAdapter("select Id,Nom from Note where Id=@Id", ADO.con);
                            ADO.sda.SelectCommand.Parameters.AddWithValue("@Id", row[1].ToString());
                            DataTable data = new DataTable();
                            ADO.sda.Fill(data);
                            DGVNotesSelectionnes.Rows.Insert(0, data.Rows[0][0].ToString(), data.Rows[0][1].ToString());
                        }
                        DGVNotesSelectionnes.ClearSelection();
                    }
                    ADO.Deconnecter();
                }
                //if (!CheckIdDetailCommandeEtat(DGVDetailsCommande.SelectedRows[0].Cells[0].Value.ToString()).Equals("3"))
                //{

                //}
            }
        }

        private void BtnScrollUp_Click(object sender, EventArgs e)
        {
            int ChangePositionUp = FlwpnlProduits.VerticalScroll.Value - FlwpnlProduits.VerticalScroll.SmallChange * 80;
            FlwpnlProduits.AutoScrollPosition = new Point(0, ChangePositionUp);
        }

        private void BtnScrollDown_Click(object sender, EventArgs e)
        {
            int ChangePositionDown = FlwpnlProduits.VerticalScroll.Value + FlwpnlProduits.VerticalScroll.SmallChange * 80;
            FlwpnlProduits.AutoScrollPosition = new Point(0, ChangePositionDown);
        }

        private void BtnAnnuterCommande_Click(object sender, EventArgs e)
        {
            if (DGVDetailsCommande.Rows.Count > 0)
            {
                DialogResult dr = (MessageBox.Show("Voulez-vous vraiment annuler cette commande ?", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
                if (dr == DialogResult.Yes)
                {
                    string Idcommande = IdCommande();

                    ADO.Connecter();
                    ADO.cmd = new SqlCommand("delete from DetailsCommandeImprimante where Id_Commande=@Id_Commande", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
                    ADO.cmd.ExecuteNonQuery();
                    UpdateEtatTable(Form1.NomTable(), "0");
                    DGVDetailsCommande.Rows.Clear();
                    DGVDetailsCommande.DataSource = null;
                    Totals();
                    ADO.Deconnecter();
                }
                else
                {
                    MessageBox.Show("Opération d'annulation pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnValiderCommande_Click(object sender, EventArgs e)
        {
            string Role = Form1.GeneralInstance.LblRole.Text;

            if (ADO.CheckUserCanValiderCommande(Role) || Role.Equals(ADO.UserRoles.Admin.ToString()))
            {
                if (DGVDetailsCommande.Rows.Count > 0)
                {
                    //string IdCmd = IdCommande();

                    //// Ticket Cuisine :

                    //CommandeDataSet dataSet = new CommandeDataSet();
                    //ADO.Connecter();
                    //ADO.sda = new SqlDataAdapter("select dci.Id_DetailCommande as 'IdDetailCommande',dci.Id_Commande as 'IdCommande',dci.Serveur as 'Serveur',dci.Nom_Table as 'ZoneTable',p.Nom_Produit as 'Produit',dci.Prix as 'Prix',dci.Quantite as 'Quantite',n.Nom as 'Note' from DetailsCommandeImprimante dci inner join Produit p on dci.Id_Produit=p.Id_Produit left join ProduitNotes pn on pn.Id_DetailCommande=dci.Id_DetailCommande left join Note n on n.Id=pn.Id_Note where dci.Id_Commande=@IdCommande", ADO.con);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCommande", IdCmd);
                    //ADO.sda.Fill(dataSet, "Commande");
                    //ticketCuisine.SetDataSource(dataSet.Tables["Commande"]);
                    //Print impressionTicetCuisine = new Print();
                    //Print.ticketNom = "Cuisine";
                    //impressionTicetCuisine.ShowDialog();

                    //// Ticket Client :

                    //ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',dci.Quantite as 'Quantite',dci.Prix as 'Prix',dci.Serveur as 'Serveur',dci.Id_Commande as 'IdCommande',dci.Nom_Table as 'ZoneTable',(select Nom from Espace) as 'NomEspace',(select Adresse from Espace) as 'Adresse',(select Telephone from Espace) as 'Telephone',(select Code_Wifi from Espace) as 'CodeWIFI',(select Message from Espace) as 'Message',(select Logo from Espace) as 'Logo' from DetailsCommandeImprimante dci,Produit p where dci.Id_Produit=p.Id_Produit and dci.Id_Commande=@IdCommande", ADO.con);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCommande", IdCmd);
                    //dataSet.Tables["Commande"].Clear();
                    //ADO.sda.Fill(dataSet, "Commande");
                    //ticketClient.SetDataSource(dataSet.Tables["Commande"]);
                    ////ticketCuisine.PrintToPrinter(0, false, 1, 1);
                    ////ticketCuisine.PrintOptions.PrinterName = "A5";
                    //Print impressionTicetClient = new Print();
                    //Print.ticketNom = "Client";
                    //impressionTicetClient.ShowDialog();

                    //ADO.Deconnecter();
                    ValiderCommande();
                }
            }
        }

        private void BtnAnnulerProduit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(IdCommande());
        }

        public void ValiderCommande()
        {
            if (ADO.CheckEspaceTables())
            {
                if (EtatTable().Equals("3"))
                {
                    DialogResult dr = (MessageBox.Show("Voulez-vous vraiment valider cette commande ?", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
                    if (dr == DialogResult.Yes)
                    {
                        string Idcommande = IdCommande();
                        string Serveur = Form1.GeneralInstance.LblUtilisateur.Text;
                        string Nomtable = Form1.NomTable();
                        string DateCommande = DateTime.Now.ToString();
                        string TotalCommande = LblMontantCommande.Text;

                        ADO.Connecter();
                        ADO.cmd = new SqlCommand("insert into CommandePayer values(@Id_Commande,@Nom_Serveur,@Nom_Table,@Date_Commande,@Total_Commande)", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
                        ADO.cmd.Parameters.AddWithValue("@Nom_Serveur", Serveur);
                        ADO.cmd.Parameters.AddWithValue("@Nom_Table", Nomtable);
                        ADO.cmd.Parameters.AddWithValue("@Date_Commande", Convert.ToDateTime(DateCommande));
                        ADO.cmd.Parameters.AddWithValue("@Total_Commande", TotalCommande);
                        ADO.cmd.ExecuteNonQuery();
                        ADO.Deconnecter();
                        UpdateEtatTable(Form1.NomTable(), "0");
                        DGVDetailsCommande.Rows.Clear();
                        DGVDetailsCommande.DataSource = null;
                        Totals();
                    }
                    else
                    {
                        MessageBox.Show("Opération de validation pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                DialogResult dr = (MessageBox.Show("Voulez-vous vraiment valider cette commande ?", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
                if (dr == DialogResult.Yes)
                {
                    string Idcommande = IdCommande();
                    string Serveur = Form1.GeneralInstance.LblUtilisateur.Text;
                    string Nomtable = Form1.NomTable();
                    string DateCommande = DateTime.Now.ToString();
                    string TotalCommande = LblMontantCommande.Text;

                    ADO.Connecter();
                    ADO.cmd = new SqlCommand("insert into CommandePayer values(@Id_Commande,@Nom_Serveur,@Nom_Table,@Date_Commande,@Total_Commande)", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
                    ADO.cmd.Parameters.AddWithValue("@Nom_Serveur", Serveur);
                    ADO.cmd.Parameters.AddWithValue("@Nom_Table", Nomtable);
                    ADO.cmd.Parameters.AddWithValue("@Date_Commande", Convert.ToDateTime(DateCommande));
                    ADO.cmd.Parameters.AddWithValue("@Total_Commande", TotalCommande);
                    ADO.cmd.ExecuteNonQuery();
                    ADO.Deconnecter();
                    UpdateEtatTable(Form1.NomTable(), "0");
                    DGVDetailsCommande.Rows.Clear();
                    DGVDetailsCommande.DataSource = null;
                    Totals();
                }
                else
                {
                    MessageBox.Show("Opération de validation pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DGVDetailsCommande_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AjouterNote_Click(object sender, EventArgs e)
        {
            if (TxtNote.Text != "")
            {
                ADO.Connecter();
                ADO.cmd = new SqlCommand("insert into Note values(@Note)", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Note", TxtNote.Text);
                ADO.cmd.ExecuteNonQuery();
                ADO.Deconnecter();
                AfficherNotes();
                MessageBox.Show("Note bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNote.Clear();
                TxtNote.Focus();
            }
            else
            {
                MessageBox.Show("Veuillez remplir la note !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            if (TxtRechercher.Visible)
            {
                TxtRechercher.Visible = false;
            }
            else
            {
                TxtRechercher.Visible = true;
            }
        }

        public void AfficherNotes()
        {
            ADO.Connecter();
            ADO.sda = new SqlDataAdapter("ListeNotes", ADO.con);
            ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            DGVListeNotes.DataSource = table;
            DGVListeNotes.Columns[0].Visible = false;
            DGVListeNotes.ClearSelection();
            ADO.Deconnecter();
        }

        private void TxtRechercher_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtRechercher.Text != "")
                {
                    if (SelectedIdCategorie != 0)
                    {
                        FlwpnlProduits.Controls.Clear();
                        //String tag = ((Label)sender).Tag.ToString();

                        ADO.Connecter();
                        ADO.cmd = new SqlCommand("select Image_Produit,Nom_produit,Prix_Normal,Id_Produit from Produit where Id_CategorieProduit=@Id_Categorie and Nom_produit like '%" + TxtRechercher.Text + "%'", ADO.con);
                        //ADO.cmd.Parameters.AddWithValue("@Nom_produit", TxtRechercher.Text);
                        ADO.cmd.Parameters.AddWithValue("@Id_Categorie", SelectedIdCategorie);
                        DataTable table = new DataTable();
                        ADO.dr = ADO.cmd.ExecuteReader();

                        while (ADO.dr.Read())
                        {
                            long len = ADO.dr.GetBytes(0, 0, null, 0, 0);
                            byte[] array = new byte[Convert.ToInt32(len) + 1];
                            ADO.dr.GetBytes(0, 0, array, 0, Convert.ToInt32(len));

                            MemoryStream ms = new MemoryStream(array);
                            Bitmap bitmap = new Bitmap(ms);

                            Produit produit = new Produit();
                            produit.imageProduits = bitmap;
                            produit.nomProduits = ADO.dr["Nom_produit"].ToString();
                            produit.prixProduits = ADO.dr["Prix_Normal"].ToString();
                            produit.Tag = ADO.dr["Id_Produit"].ToString();
                            produit.LblNomProduit.Tag = ADO.dr["Id_Produit"].ToString();
                            produit.Cursor = Cursors.Hand;

                            FlwpnlProduits.Controls.Add(produit);

                            produit.Click += Ajouter_CommandeParImage;
                            produit.LblNomProduit.Click += Ajouter_CommandeParNom;

                            //Guna2CirclePictureBox picture = new Guna2CirclePictureBox();
                            //picture.Width = 130;
                            //picture.Height = 104;
                            //picture.BackgroundImageLayout = ImageLayout.Stretch;
                            //picture.BorderStyle = BorderStyle.Fixed3D;
                            //picture.Tag = ADO.dr["Id_Produit"].ToString();

                            //Label price = new Label();
                            //price.Text = (ADO.dr["Prix_Normal"].ToString());
                            //price.AutoSize = true;
                            //price.ForeColor = Color.White;
                            //price.BackColor = Color.FromArgb(255, 156, 36);
                            //price.TextAlign = ContentAlignment.MiddleLeft;
                            //price.Font = new Font("Century Gothic", 10, FontStyle.Bold);
                            ////price.Visible = false;
                            //price.Tag = ADO.dr["Id_Produit"].ToString();

                            //Label nom = new Label();
                            //nom.Text = ADO.dr["Nom_produit"].ToString();
                            //nom.Height = 32;
                            //nom.ForeColor = Color.White;
                            //nom.BackColor = Color.FromArgb(255, 140, 0);
                            //nom.TextAlign = ContentAlignment.MiddleCenter;
                            //nom.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                            //nom.Dock = DockStyle.Bottom;
                            //nom.Tag = ADO.dr["Id_Produit"].ToString();

                            //MemoryStream ms = new MemoryStream(array);
                            //Bitmap bitmap = new Bitmap(ms);

                            //picture.BackgroundImage = bitmap;
                            //picture.Controls.Add(price);
                            //picture.Controls.Add(nom);
                            //FlwpnlProduits.Controls.Add(picture);

                            //picture.Cursor = Cursors.Hand;

                            //picture.Click += new EventHandler(Ajouter_Commande);

                            //price.Click += new EventHandler(Ajouter_Commande1);

                            //nom.Click += new EventHandler(Ajouter_Commande1);

                            Totals();
                        }
                    }
                    ADO.Deconnecter();
                }
                else
                {
                    FlwpnlProduits.Controls.Clear();
                    //String tag = ((Label)sender).Tag.ToString();

                    ADO.Connecter();
                    ADO.cmd = new SqlCommand("select Image_Produit,Nom_produit,Prix_Normal,Id_Produit from Produit where Id_CategorieProduit=@Id_Categorie /*and Nom_produit like '%" + TxtRechercher.Text + "%'*/", ADO.con);
                    //ADO.cmd.Parameters.AddWithValue("@Nom_produit", TxtRechercher.Text);
                    ADO.cmd.Parameters.AddWithValue("@Id_Categorie", SelectedIdCategorie);
                    DataTable table = new DataTable();
                    ADO.dr = ADO.cmd.ExecuteReader();

                    while (ADO.dr.Read())
                    {
                        long len = ADO.dr.GetBytes(0, 0, null, 0, 0);
                        byte[] array = new byte[Convert.ToInt32(len) + 1];
                        ADO.dr.GetBytes(0, 0, array, 0, Convert.ToInt32(len));

                        MemoryStream ms = new MemoryStream(array);
                        Bitmap bitmap = new Bitmap(ms);

                        Produit produit = new Produit();
                        produit.imageProduits = bitmap;
                        produit.nomProduits = ADO.dr["Nom_produit"].ToString();
                        produit.prixProduits = ADO.dr["Prix_Normal"].ToString();
                        produit.Tag = ADO.dr["Id_Produit"].ToString();
                        produit.LblNomProduit.Tag = ADO.dr["Id_Produit"].ToString();
                        produit.Cursor = Cursors.Hand;

                        FlwpnlProduits.Controls.Add(produit);

                        produit.Click += Ajouter_CommandeParImage;
                        produit.LblNomProduit.Click += Ajouter_CommandeParNom;

                        //Guna2CirclePictureBox picture = new Guna2CirclePictureBox();
                        //picture.Width = 130;
                        //picture.Height = 104;
                        //picture.BackgroundImageLayout = ImageLayout.Stretch;
                        //picture.BorderStyle = BorderStyle.Fixed3D;
                        //picture.Tag = ADO.dr["Id_Produit"].ToString();

                        //Label price = new Label();
                        //price.Text = (ADO.dr["Prix_Normal"].ToString());
                        //price.AutoSize = true;
                        //price.ForeColor = Color.White;
                        //price.BackColor = Color.FromArgb(255, 156, 36);
                        //price.TextAlign = ContentAlignment.MiddleLeft;
                        //price.Font = new Font("Century Gothic", 10, FontStyle.Bold);
                        ////price.Visible = false;
                        //price.Tag = ADO.dr["Id_Produit"].ToString();

                        //Label nom = new Label();
                        //nom.Text = ADO.dr["Nom_produit"].ToString();
                        //nom.Height = 32;
                        //nom.ForeColor = Color.White;
                        //nom.BackColor = Color.FromArgb(255, 140, 0);
                        //nom.TextAlign = ContentAlignment.MiddleCenter;
                        //nom.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        //nom.Dock = DockStyle.Bottom;
                        //nom.Tag = ADO.dr["Id_Produit"].ToString();

                        //MemoryStream ms = new MemoryStream(array);
                        //Bitmap bitmap = new Bitmap(ms);

                        //picture.BackgroundImage = bitmap;
                        //picture.Controls.Add(price);
                        //picture.Controls.Add(nom);
                        //FlwpnlProduits.Controls.Add(picture);

                        //picture.Cursor = Cursors.Hand;

                        //picture.Click += new EventHandler(Ajouter_Commande);

                        //price.Click += new EventHandler(Ajouter_Commande1);

                        //nom.Click += new EventHandler(Ajouter_Commande1);

                        Totals();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            TxtPourcentrageRemise.Clear();
            PnlNotes.Visible = false;
            DGVNotesSelectionnes.Rows.Clear();
            DGVListeNotes.ClearSelection();
            Form1.GeneralInstance.PnlHeader.Enabled = GroupBoxCategorie.Enabled = GroupBoxProduit.Enabled = GroupBoxDetailsCommande.Enabled = true;
            DGVDetailsCommandeRemise.Rows.Clear();
        }

        private void ModifierNote_Click(object sender, EventArgs e)
        {
            if (TxtNote.Text != "")
            {
                ADO.Connecter();
                ADO.cmd = new SqlCommand("update Note set Nom=@Nom where Id=@Id", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Nom", TxtNote.Text);
                ADO.cmd.Parameters.AddWithValue("@Id", DGVListeNotes.SelectedRows[0].Cells[0].Value.ToString());
                ADO.cmd.ExecuteNonQuery();
                ADO.Deconnecter();
                AfficherNotes();
                MessageBox.Show("Note bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNote.Clear();
                TxtNote.Focus();
            }
            else
            {
                MessageBox.Show("Veuillez remplir la note !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SupprimerNote_Click(object sender, EventArgs e)
        {
            if (DGVListeNotes.SelectedRows.Count == 1)
            {
                ADO.Connecter();
                ADO.cmd = new SqlCommand("delete from Note where Id=@Id", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Id", DGVListeNotes.SelectedRows[0].Cells[0].Value.ToString());
                ADO.cmd.ExecuteNonQuery();
                ADO.Deconnecter();
                AfficherNotes();
                MessageBox.Show("Note bien supprimer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNote.Clear();
                TxtNote.Focus();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner la note à supprimer !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void AjouterProduitNotes()
        {
            ADO.Connecter();
            ADO.cmd = new SqlCommand("insert into ProduitNotes values(@IdDetail,@IdNote)", ADO.con);
            ADO.cmd.Parameters.AddWithValue("@IdDetail", IdDetailCmd);
            ADO.cmd.Parameters.AddWithValue("@IdNote", DGVListeNotes.SelectedRows[0].Cells[0].Value.ToString());
            ADO.cmd.ExecuteNonQuery();
            ADO.Deconnecter();
        }

        public void SupprimerProduitNotes()
        {
            ADO.Connecter();
            ADO.cmd = new SqlCommand("delete from ProduitNotes where Id_DetailCommande=@IdDetail and Id_Note=@IdNote", ADO.con);
            ADO.cmd.Parameters.AddWithValue("@IdDetail", IdDetailCmd);
            ADO.cmd.Parameters.AddWithValue("@IdNote", DGVNotesSelectionnes.SelectedRows[0].Cells[0].Value.ToString());
            ADO.cmd.ExecuteNonQuery();
            ADO.Deconnecter();
        }

        private void AjouterNoteToProduit_Click(object sender, EventArgs e)
        {
            if (DGVListeNotes.SelectedRows.Count == 1)
            {
                if (DGVNotesSelectionnes.Rows.Count == 0)
                {
                    DGVNotesSelectionnes.Rows.Insert(0, DGVListeNotes.SelectedRows[0].Cells[0].Value, DGVListeNotes.SelectedRows[0].Cells[1].Value);
                    AjouterProduitNotes();
                    DGVListeNotes.ClearSelection();
                    DGVNotesSelectionnes.ClearSelection();
                }
                else
                {
                    bool TrouveNote = false;
                    foreach (DataGridViewRow row in DGVNotesSelectionnes.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == DGVListeNotes.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            TrouveNote = true;
                            break;
                        }
                        else
                        {
                            TrouveNote = false;
                        }
                    }
                    if (TrouveNote)
                    {
                        MessageBox.Show("Attention, note déjà sélectionnée !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DGVNotesSelectionnes.Rows.Insert(0, DGVListeNotes.SelectedRows[0].Cells[0].Value, DGVListeNotes.SelectedRows[0].Cells[1].Value);
                        AjouterProduitNotes();
                        DGVListeNotes.ClearSelection();
                        DGVNotesSelectionnes.ClearSelection();
                    }
                }
            }
        }

        private void SupprimerNoteToProduit_Click(object sender, EventArgs e)
        {
            if (DGVNotesSelectionnes.SelectedRows.Count == 1)
            {
                int rowIndex = DGVNotesSelectionnes.CurrentCell.RowIndex;
                SupprimerProduitNotes();
                DGVNotesSelectionnes.Rows.RemoveAt(rowIndex);
                DGVListeNotes.ClearSelection();
                DGVNotesSelectionnes.ClearSelection();
            }
        }

        private void DGVListeNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVListeNotes.SelectedRows.Count == 1)
            {
                TxtNote.Text = DGVListeNotes.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void BtnAnnulerCommande_Click(object sender, EventArgs e)
        {
            string Role = Form1.GeneralInstance.LblRole.Text;

            if (ADO.CheckUserCanAnnulerCommande(Role) || Role.Equals(ADO.UserRoles.Admin.ToString()))
            {
                if (DGVDetailsCommande.Rows.Count > 0)
                {
                    if (ADO.CheckEspaceTables())
                    {
                        DialogResult dr = (MessageBox.Show("Voulez-vous vraiment annuler cette commande ?", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
                        if (dr == DialogResult.Yes)
                        {
                            string Idcommande = IdCommande();
                            string NomTable = Form1.NomTable();

                            DataTable table = ADO.DetailsCommandeById(int.Parse(Idcommande));

                            if (table.Rows.Count > 0)
                            {
                                foreach (DataRow row in table.Rows)
                                {
                                    if (ADO.CheckProduitExistsInStock(int.Parse(row[0].ToString())))
                                    {
                                        ADO.Connecter();
                                        //SqlTransaction transactiona = ADO.con.BeginTransaction();

                                        ADO.cmd = new SqlCommand("update ProduitEnStock set Stock_Sortie+=@Stock_Sortie where Id_Produit=@Id_Produit", ADO.con);
                                        ADO.cmd.Parameters.AddWithValue("@Stock_Sortie", decimal.Parse(row[1].ToString()));
                                        ADO.cmd.Parameters.AddWithValue("@Id_Produit", row[0].ToString());
                                        ADO.cmd.ExecuteNonQuery();

                                        ADO.Deconnecter();
                                    }
                                }
                            }

                            DataTable tableDetailsCommande = ADO.DetailCommandeWithNotes(int.Parse(Idcommande));

                            if (tableDetailsCommande.Rows.Count > 0)
                            {
                                foreach (DataRow row in tableDetailsCommande.Rows)
                                {
                                    ADO.Connecter();
                                    //SqlTransaction transactiona = ADO.con.BeginTransaction();

                                    ADO.cmd = new SqlCommand("delete from ProduitNotes where Id_DetailCommande=@Id", ADO.con);
                                    ADO.cmd.Parameters.AddWithValue("@Id", row[0].ToString());
                                    ADO.cmd.ExecuteNonQuery();

                                    ADO.Deconnecter();
                                }
                            }

                            ADO.Connecter();
                            //SqlTransaction transaction = ADO.con.BeginTransaction();

                            ADO.cmd = new SqlCommand("delete from DetailsCommandeImprimante where Id_Commande=@Id_Commande and Nom_Table=@Nom_Table", ADO.con);
                            ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
                            ADO.cmd.Parameters.AddWithValue("@Nom_Table", NomTable);
                            ADO.cmd.ExecuteNonQuery();
                            ADO.Deconnecter();
                            UpdateEtatTable(Form1.NomTable(), "0");
                            DGVDetailsCommande.Rows.Clear();
                            DGVDetailsCommande.DataSource = null;
                            Totals();
                        }
                        else
                        {
                            MessageBox.Show("Opération d'annulation pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        //ADO.Connecter();
                        //SqlTransaction transaction = ADO.con.BeginTransaction();

                        DialogResult dr = (MessageBox.Show("Voulez-vous vraiment annuler cette commande ?", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
                        if (dr == DialogResult.Yes)
                        {
                            string Idcommande = IdCommande();

                            ADO.Connecter();

                            ADO.sda = new SqlDataAdapter("select Id_Produit,Quantite from DetailsCommandeImprimante where Id_Commande=@Id_Commande", ADO.con);
                            ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Commande", Idcommande);
                            DataTable table = new DataTable();
                            ADO.sda.Fill(table);
                            ADO.Deconnecter();
                            if (table.Rows.Count > 0)
                            {
                                foreach (DataRow row in table.Rows)
                                {
                                    if (ADO.CheckProduitExistsInStock(int.Parse(row[0].ToString())))
                                    {
                                        ADO.Connecter();

                                        ADO.cmd = new SqlCommand("update ProduitEnStock set Stock_Sortie+=@Stock_Sortie where Id_Produit=@Id_Produit", ADO.con);
                                        ADO.cmd.Parameters.AddWithValue("@Stock_Sortie", decimal.Parse(row[1].ToString()));
                                        ADO.cmd.Parameters.AddWithValue("@Id_Produit", row[0].ToString());
                                        ADO.cmd.ExecuteNonQuery();

                                        ADO.Deconnecter();
                                    }
                                }
                            }

                            DataTable tableDetailsCommande = ADO.DetailCommandeWithNotes(int.Parse(Idcommande));

                            if (tableDetailsCommande.Rows.Count > 0)
                            {
                                foreach (DataRow row in tableDetailsCommande.Rows)
                                {
                                    ADO.Connecter();

                                    ADO.cmd = new SqlCommand("delete from ProduitNotes where Id_DetailCommande=@Id", ADO.con);
                                    ADO.cmd.Parameters.AddWithValue("@Id", row[0].ToString());
                                    ADO.cmd.ExecuteNonQuery();

                                    ADO.Deconnecter();
                                }
                            }

                            ADO.Connecter();
                            ADO.cmd = new SqlCommand("delete from DetailsCommandeImprimante where Id_Commande=@Id_Commande", ADO.con);
                            ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
                            ADO.cmd.ExecuteNonQuery();
                            ADO.Deconnecter();
                            UpdateEtatTable(Form1.NomTable(), "0");
                            DGVDetailsCommande.Rows.Clear();
                            DGVDetailsCommande.DataSource = null;
                            Totals();
                        }
                        else
                        {
                            MessageBox.Show("Opération d'annulation pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void BtnRetourVersTables_Click(object sender, EventArgs e)
        {
            if (Form1.GeneralInstance.PnlAffichage.Controls.ContainsKey("PointDeVente"))
            {
                if (ADO.CheckEspaceTables() && ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
                {
                    Form1.GeneralInstance.IconZone.Visible = Form1.GeneralInstance.LblZone.Visible = Form1.GeneralInstance.IconNumTable.Visible = Form1.GeneralInstance.LblNumTable.Visible = false;
                    Form1.GeneralInstance.PnlAffichage.Controls.Remove(new PointDeVente());
                    new PointDeVente().Dispose();
                    Form1.GeneralInstance.PnlAffichage.Controls.Clear();
                    Form1.GeneralInstance.PnlAffichage.Controls.Add(new User_Controls.TablesEspace());
                }
                else
                {
                    Form1.GeneralInstance.SideBar.Visible = true;
                    Form1.GeneralInstance.PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
                    new User_Controls.TablesEspace().Dispose();
                    Form1.GeneralInstance.PnlAffichage.Controls.Clear();
                    Form1.GeneralInstance.PnlAffichage.Controls.Add(new FirstCustomControl());
                    Form1.GeneralInstance.IconZone.Visible = Form1.GeneralInstance.LblZone.Visible = Form1.GeneralInstance.IconNumTable.Visible = Form1.GeneralInstance.LblNumTable.Visible = false;
                }
            }
        }

        private void BtnImprimerTicketCuisine_Click(object sender, EventArgs e)
        {
            string Role = Form1.GeneralInstance.LblRole.Text;

            if (ADO.CheckUserCanImprimerTicketCuisine(Role) || Role.Equals(ADO.UserRoles.Admin.ToString()))
            {
                if (DGVDetailsCommande.Rows.Count > 0)
                {
                    string Idcommande = IdCommande();
                    string NomTable = Form1.NomTable();

                    ADO.Connecter();
                    ADO.sda = new SqlDataAdapter("select distinct i.Id_Imprimante,i.Nom_Imprimante from DetailsCommandeImprimante dci,Imprimante i where dci.Id_Imprimante=i.Id_Imprimante and dci.Id_Commande=@Id_Commande and dci.Etat=0", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Commande", Idcommande);
                    DataTable tableImprimante = new DataTable();
                    ADO.sda.Fill(tableImprimante);
                    if (tableImprimante.Rows.Count > 0)
                    {
                        //foreach (DataRow row in tableImprimante.Rows)
                        //{
                        //    CrystalReportTicketCuisine crystal = new CrystalReportTicketCuisine();

                        //    ADO.sda = new SqlDataAdapter("select dci.Id_DetailCommande as 'IdDetailCommande',dci.Id_Commande as 'IdCommande',dci.Serveur as 'Serveur',dci.Nom_Table as 'ZoneTable',p.Nom_Produit as 'Produit',dci.Prix as 'Prix',dci.Quantite as 'Quantite',n.Nom as 'Note' from DetailsCommandeImprimante dci inner join Produit p on dci.Id_Produit=p.Id_Produit left join ProduitNotes pn on pn.Id_DetailCommande=dci.Id_DetailCommande left join Note n on n.Id=pn.Id_Note where dci.Id_Commande=@IdCommande and dci.Etat=0 and dci.Id_Imprimante=@Id_Imprimante", ADO.con);
                        //    ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCommande", Idcommande);
                        //    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Imprimante", row[0].ToString());
                        //    ADO.sda.Fill(dataSet, "Commande");
                        //    crystal.SetDataSource(dataSet.Tables["Commande"]);

                        //    if (crystal.HasRecords)
                        //    {
                        //        ticketCuisine = crystal;
                        //        Print impressionTicetCuisine = new Print();
                        //        Print.ticketNom = "Cuisine";
                        //        impressionTicetCuisine.ShowDialog();
                        //    }
                        //}

                        for (int i = 0; i < tableImprimante.Rows.Count; i++)
                        {
                            CommandeDataSet dataSet = new CommandeDataSet();
                            CrystalReportTicketCuisine crystal = new CrystalReportTicketCuisine();

                            //MessageBox.Show(tableImprimante.Rows[i][0].ToString());

                            ADO.sda = new SqlDataAdapter("select dci.Id_DetailCommande as 'IdDetailCommande',dci.Id_Commande as 'IdCommande',dci.Serveur as 'Serveur',dci.Nom_Table as 'ZoneTable',p.Nom_Produit as 'Produit',dci.Prix as 'Prix',dci.Quantite as 'Quantite',n.Nom as 'Note' from DetailsCommandeImprimante dci inner join Produit p on dci.Id_Produit=p.Id_Produit left join ProduitNotes pn on pn.Id_DetailCommande=dci.Id_DetailCommande left join Note n on n.Id=pn.Id_Note where dci.Id_Commande=@IdCommande and dci.Etat=0 and dci.Id_Imprimante=@Id_Imprimante", ADO.con);
                            ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCommande", Idcommande);
                            ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Imprimante", tableImprimante.Rows[i][0].ToString());
                            ADO.sda.Fill(dataSet, "Commande");
                            crystal.SetDataSource(dataSet.Tables["Commande"]);

                            if (crystal.HasRecords)
                            {
                                ticketCuisine = crystal;
                                //- If You Want To Select A Specific Printer By Name
                                ticketCuisine.PrintToPrinter(0, false, 1, 1);
                                ticketCuisine.PrintOptions.PrinterName = "Microsoft Print to PDF";
                                //Print impressionTicetCuisine = new Print();
                                //Print.ticketNom = "Cuisine";
                                //impressionTicetCuisine.ShowDialog();
                            }
                        }

                        ADO.cmd = new SqlCommand("update DetailsCommandeImprimante set Etat=1 where Id_Commande=@Id_Commande and Nom_Table=@Nom_Table", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
                        ADO.cmd.Parameters.AddWithValue("@Nom_Table", NomTable);
                        ADO.cmd.ExecuteNonQuery();

                        UpdateEtatTable(NomTable, "2");
                    }

                    //ADO.Connecter();
                    //ADO.sda = new SqlDataAdapter("select Id_Commande from DetailsCommandeImprimante where Id_Commande=@Id_Commande and Nom_Table=@Nom_Table and Etat=0", ADO.con);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Commande", Idcommande);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom_Table", NomTable);
                    //DataTable table = new DataTable();
                    //ADO.sda.Fill(table);
                    //if (table.Rows.Count > 0)
                    //{
                    //    // Ticket Cuisine :

                    //    ADO.sda = new SqlDataAdapter("select dci.Id_DetailCommande as 'IdDetailCommande',dci.Id_Commande as 'IdCommande',dci.Serveur as 'Serveur',dci.Nom_Table as 'ZoneTable',p.Nom_Produit as 'Produit',dci.Prix as 'Prix',dci.Quantite as 'Quantite',n.Nom as 'Note' from DetailsCommandeImprimante dci inner join Produit p on dci.Id_Produit=p.Id_Produit left join ProduitNotes pn on pn.Id_DetailCommande=dci.Id_DetailCommande left join Note n on n.Id=pn.Id_Note where dci.Id_Commande=@IdCommande and dci.Etat=0", ADO.con);
                    //    ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCommande", Idcommande);
                    //    ADO.sda.Fill(dataSet, "Commande");
                    //    ticketCuisine.SetDataSource(dataSet.Tables["Commande"]);
                    //    Print impressionTicetCuisine = new Print();
                    //    Print.ticketNom = "Cuisine";
                    //    impressionTicetCuisine.ShowDialog();

                    //    ADO.cmd = new SqlCommand("update DetailsCommandeImprimante set Etat=1 where Id_Commande=@Id_Commande and Nom_Table=@Nom_Table", ADO.con);
                    //    ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
                    //    ADO.cmd.Parameters.AddWithValue("@Nom_Table", NomTable);
                    //    ADO.cmd.ExecuteNonQuery();

                    //    UpdateEtatTable(NomTable, "2");
                    //}
                }
            }
        }

        private void BtnImprimerTicketClient_Click(object sender, EventArgs e)
        {
            string Role = Form1.GeneralInstance.LblRole.Text;

            if (ADO.CheckUserCanImprimerTicketClient(Role) || Role.Equals(ADO.UserRoles.Admin.ToString()))
            {
                CommandeDataSet dataSetClient = new CommandeDataSet();
                CrystalReportTicketClient crystal = new CrystalReportTicketClient();

                if (DGVDetailsCommande.Rows.Count > 0)
                {
                    string Idcommande = IdCommande();
                    string NomTable = Form1.NomTable();

                    // Print Ticket Cuisine if exists
                    ADO.Connecter();
                    ADO.sda = new SqlDataAdapter("select distinct i.Id_Imprimante,i.Nom_Imprimante from DetailsCommandeImprimante dci,Imprimante i where dci.Id_Imprimante=i.Id_Imprimante and dci.Id_Commande=@Id_Commande and dci.Etat=0", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Commande", Idcommande);
                    DataTable tableImprimante = new DataTable();
                    ADO.sda.Fill(tableImprimante);
                    if (tableImprimante.Rows.Count > 0)
                    {
                        //foreach (DataRow row in tableImprimante.Rows)
                        //{
                        //    CrystalReportTicketCuisine crystal = new CrystalReportTicketCuisine();

                        //    ADO.sda = new SqlDataAdapter("select dci.Id_DetailCommande as 'IdDetailCommande',dci.Id_Commande as 'IdCommande',dci.Serveur as 'Serveur',dci.Nom_Table as 'ZoneTable',p.Nom_Produit as 'Produit',dci.Prix as 'Prix',dci.Quantite as 'Quantite',n.Nom as 'Note' from DetailsCommandeImprimante dci inner join Produit p on dci.Id_Produit=p.Id_Produit left join ProduitNotes pn on pn.Id_DetailCommande=dci.Id_DetailCommande left join Note n on n.Id=pn.Id_Note where dci.Id_Commande=@IdCommande and dci.Etat=0 and dci.Id_Imprimante=@Id_Imprimante", ADO.con);
                        //    ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCommande", Idcommande);
                        //    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Imprimante", row[0].ToString());
                        //    ADO.sda.Fill(dataSet, "Commande");
                        //    crystal.SetDataSource(dataSet.Tables["Commande"]);

                        //    if (crystal.HasRecords)
                        //    {
                        //        ticketCuisine = crystal;
                        //        Print impressionTicetCuisine = new Print();
                        //        Print.ticketNom = "Cuisine";
                        //        impressionTicetCuisine.ShowDialog();
                        //    }
                        //}

                        for (int i = 0; i < tableImprimante.Rows.Count; i++)
                        {
                            CommandeDataSet dataSet = new CommandeDataSet();
                            CrystalReportTicketCuisine crystalTicketCuisine = new CrystalReportTicketCuisine();

                            //MessageBox.Show(tableImprimante.Rows[i][0].ToString());

                            ADO.sda = new SqlDataAdapter("select dci.Id_DetailCommande as 'IdDetailCommande',dci.Id_Commande as 'IdCommande',dci.Serveur as 'Serveur',dci.Nom_Table as 'ZoneTable',p.Nom_Produit as 'Produit',dci.Prix as 'Prix',dci.Quantite as 'Quantite',n.Nom as 'Note' from DetailsCommandeImprimante dci inner join Produit p on dci.Id_Produit=p.Id_Produit left join ProduitNotes pn on pn.Id_DetailCommande=dci.Id_DetailCommande left join Note n on n.Id=pn.Id_Note where dci.Id_Commande=@IdCommande and dci.Etat=0 and dci.Id_Imprimante=@Id_Imprimante", ADO.con);
                            ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCommande", Idcommande);
                            ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Imprimante", tableImprimante.Rows[i][0].ToString());
                            ADO.sda.Fill(dataSet, "Commande");
                            crystalTicketCuisine.SetDataSource(dataSet.Tables["Commande"]);

                            if (crystalTicketCuisine.HasRecords)
                            {
                                ticketCuisine = crystalTicketCuisine;
                                //- If You Want To Select A Specific Printer By Name
                                ticketCuisine.PrintToPrinter(0, false, 1, 1);
                                ticketCuisine.PrintOptions.PrinterName = "Microsoft Print to PDF";
                                //Print impressionTicetCuisine = new Print();
                                //Print.ticketNom = "Cuisine";
                                //impressionTicetCuisine.ShowDialog();
                            }
                        }

                        ADO.cmd = new SqlCommand("update DetailsCommandeImprimante set Etat=1 where Id_Commande=@Id_Commande and Nom_Table=@Nom_Table", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
                        ADO.cmd.Parameters.AddWithValue("@Nom_Table", NomTable);
                        ADO.cmd.ExecuteNonQuery();

                        UpdateEtatTable(NomTable, "2");
                    }
                    //

                    ADO.Connecter();
                    ADO.sda = new SqlDataAdapter("select Id_Commande from DetailsCommandeImprimante where Id_Commande=@Id_Commande and Nom_Table=@Nom_Table", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Commande", Idcommande);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom_Table", NomTable);
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        // Ticket Client :

                        if (ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
                        {
                            //CommandeDataSet dataSetClient = new CommandeDataSet();
                            //select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',dci.Serveur as 'Serveur',dci.Id_Commande as 'IdCommande',dci.Nom_Table as 'ZoneTable',(select Nom from Espace) as 'NomEspace',(select Adresse from Espace) as 'Adresse',(select Telephone from Espace) as 'Telephone',(select Code_Wifi from Espace) as 'CodeWIFI',(select Message from Espace) as 'Message',(select Logo from Espace) as 'Logo' from DetailsCommandeImprimante dci,Produit p where dci.Id_Produit=p.Id_Produit and dci.Id_Commande=@Id_Commande and dci.Nom_Table=@Nom_Table group by p.Nom_Produit,dci.Quantite,dci.Prix,dci.Serveur,dci.Id_Commande,dci.Nom_Table
                            //select p.Nom_Produit as 'Produit',dci.Quantite as 'Quantite',dci.Prix as 'Prix',dci.Serveur as 'Serveur',dci.Id_Commande as 'IdCommande',dci.Nom_Table as 'ZoneTable',(select Nom from Espace) as 'NomEspace',(select Adresse from Espace) as 'Adresse',(select Telephone from Espace) as 'Telephone',(select Code_Wifi from Espace) as 'CodeWIFI',(select Message from Espace) as 'Message',(select Logo from Espace) as 'Logo' from DetailsCommandeImprimante dci,Produit p where dci.Id_Produit=p.Id_Produit and dci.Id_Commande=@IdCommande and dci.Nom_Table=@Nom_Table

                            ADO.Connecter();
                            ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',dci.Serveur as 'Serveur',dci.Id_Commande as 'IdCommande',dci.Nom_Table as 'ZoneTable',(select Nom from Espace) as 'NomEspace',(select Adresse from Espace) as 'Adresse',(select Telephone from Espace) as 'Telephone',(select Code_Wifi from Espace) as 'CodeWIFI',(select Message from Espace) as 'Message',(select Logo from Espace) as 'Logo' from DetailsCommandeImprimante dci,Produit p where dci.Id_Produit=p.Id_Produit and dci.Id_Commande=@IdCommande and dci.Nom_Table=@Nom_Table group by p.Nom_Produit,dci.Quantite,dci.Prix,dci.Serveur,dci.Id_Commande,dci.Nom_Table", ADO.con);
                            ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCommande", Idcommande);
                            ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom_Table", NomTable);
                            dataSetClient.Tables["Commande"].Clear();
                            ADO.sda.Fill(dataSetClient, "Commande");
                            crystal.SetDataSource(dataSetClient.Tables["Commande"]);

                            if (crystal.HasRecords)
                            {
                                ticketClient = crystal;
                                ticketClient.PrintToPrinter(0, false, 1, 1);
                                ticketClient.PrintOptions.PrinterName = "Microsoft Print to PDF";
                                //Print impressionTicetClient = new Print();
                                //Print.ticketNom = "Client";
                                //impressionTicetClient.ShowDialog();
                            }
                        }
                        else
                        {
                            //CommandeDataSet dataSet = new CommandeDataSet();
                            ADO.Connecter();
                            ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantite',dci.Prix as 'Prix',dci.Serveur as 'Serveur',dci.Id_Commande as 'IdCommande',dci.Nom_Table as 'ZoneTable',(select Nom from Espace) as 'NomEspace',(select Adresse from Espace) as 'Adresse',(select Telephone from Espace) as 'Telephone',(select Code_Wifi from Espace) as 'CodeWIFI',(select Message from Espace) as 'Message',(select Logo from Espace) as 'Logo' from DetailsCommandeImprimante dci,Produit p where dci.Id_Produit=p.Id_Produit and dci.Id_Commande=@IdCommande and dci.Nom_Table=@Nom_Table group by p.Nom_Produit,dci.Prix,dci.Serveur,dci.Id_Commande,dci.Nom_Table", ADO.con);
                            ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCommande", Idcommande);
                            ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom_Table", NomTable);
                            dataSetClient.Tables["Commande"].Clear();
                            ADO.sda.Fill(dataSetClient, "Commande");
                            crystal.SetDataSource(dataSetClient.Tables["Commande"]);

                            if (crystal.HasRecords)
                            {
                                ticketClient = crystal;
                                ticketClient.PrintToPrinter(0, false, 1, 1);
                                ticketClient.PrintOptions.PrinterName = "Microsoft Print to PDF";
                                //Print impressionTicetClient = new Print();
                                //Print.ticketNom = "Client";
                                //impressionTicetClient.ShowDialog();
                            }
                        }


                        ADO.cmd = new SqlCommand("update DetailsCommandeImprimante set Etat=2 where Id_Commande=@Id_Commande and Nom_Table=@Nom_Table", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
                        ADO.cmd.Parameters.AddWithValue("@Nom_Table", NomTable);
                        ADO.cmd.ExecuteNonQuery();

                        UpdateEtatTable(NomTable, "3");
                    }
                }
            }
        }

        private void BtnRemise_Click(object sender, EventArgs e)
        {
            if (DGVDetailsCommande.Rows.Count > 0)
            {
                GroupBoxDetailsCommande.Enabled = GroupBoxCategorie.Enabled = GroupBoxProduit.Enabled = false;
                PnlNotes.Visible = GroupBoxRemise.Visible = true;
                GroupBoxRemise.Text = "Remise";
                PnlNotes.BringToFront();
                GroupBoxNote.Visible = false;

                foreach (DataGridViewRow row in DGVDetailsCommande.Rows)
                {
                    DGVDetailsCommandeRemise.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value);
                }

                TxtPourcentrageRemise.Focus();
                Totals();
            }
        }

        public void AppliquerRemise(int PourcentrageRemise)
        {
            foreach (DataGridViewRow row in DGVDetailsCommandeRemise.Rows)
            {
                decimal Prix = (decimal.Parse(row.Cells[4].Value.ToString()) - ((decimal.Parse(row.Cells[4].Value.ToString()) * PourcentrageRemise / 100)));
                if (Prix >= 0)
                {
                    row.Cells[4].Value = Prix.ToString() /*(decimal.Parse(row.Cells[4].Value.ToString()) - ((decimal.Parse(row.Cells[4].Value.ToString()) * PourcentrageRemise / 100))).ToString()*/;

                    if (row.Cells[4].Value.ToString() != "0.00")
                        row.Cells[4].Value = decimal.Parse(row.Cells[4].Value.ToString()).ToString("0.##");
                }
            }
        }

        private void BtnRemise10_Click(object sender, EventArgs e)
        {
            AppliquerRemise(10);
            Totals();
        }

        private void BtnRemise20_Click(object sender, EventArgs e)
        {
            AppliquerRemise(20);
            Totals();
        }

        private void BtnRemise30_Click(object sender, EventArgs e)
        {
            AppliquerRemise(30);
            Totals();
        }

        private void BtnRemise40_Click(object sender, EventArgs e)
        {
            AppliquerRemise(40);
            Totals();
        }

        private void BtnRemise50_Click(object sender, EventArgs e)
        {
            AppliquerRemise(50);
            Totals();
        }

        private void BtnAppliquerRemise_Click(object sender, EventArgs e)
        {
            if (TxtPourcentrageRemise.Text != "")
            {
                int PourcentrageRemise = int.Parse(TxtPourcentrageRemise.Text);
                if (PourcentrageRemise >= 1 && PourcentrageRemise <= 100)
                    AppliquerRemise(PourcentrageRemise);
            }
            Totals();
        }

        private void BtnCommandeGratuit_Click(object sender, EventArgs e)
        {
            AppliquerRemise(100);
            Totals();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (DGVDetailsCommandeRemise.Rows.Count > 0)
            {
                ADO.Connecter();
                foreach (DataGridViewRow row in DGVDetailsCommandeRemise.Rows)
                {
                    ADO.cmd = new SqlCommand("update DetailsCommandeImprimante set Prix=@Prix where Id_DetailCommande=@Id_DetailCommande", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Prix", row.Cells[4].Value);
                    ADO.cmd.Parameters.AddWithValue("@Id_DetailCommande", row.Cells[0].Value);
                    ADO.cmd.ExecuteNonQuery();
                }
                ADO.Deconnecter();

                PnlNotes.Visible = GroupBoxRemise.Visible = GroupBoxNote.Visible = false;

                DGVDetailsCommande.DataSource = null;
                DGVDetailsCommande.Rows.Clear();
                foreach (DataGridViewRow row in DGVDetailsCommandeRemise.Rows)
                {
                    DGVDetailsCommande.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value);
                }

                TxtPourcentrageRemise.Clear();
                PnlNotes.Visible = false;
                DGVNotesSelectionnes.Rows.Clear();
                DGVListeNotes.ClearSelection();
                Form1.GeneralInstance.PnlHeader.Enabled = GroupBoxCategorie.Enabled = GroupBoxProduit.Enabled = GroupBoxDetailsCommande.Enabled = true;
                DGVDetailsCommandeRemise.Rows.Clear();
                Totals();
            }
        }

        private void BtnAnnulerRemise_Click(object sender, EventArgs e)
        {
            string NomZone = Form1.GeneralInstance.LblZone.Text;

            bool CheckZone = ADO.CheckZone(NomZone);

            foreach (DataGridViewRow row in DGVDetailsCommandeRemise.Rows)
            {
                ADO.sda = new SqlDataAdapter("select Prix_Normal,Prix_Livraison from Produit where Id_Produit=@Id_Produit", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", row.Cells[1].Value);
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                if (table.Rows.Count == 1)
                {
                    if (CheckZone)
                        row.Cells[4].Value = table.Rows[0][0].ToString();
                    else
                        row.Cells[4].Value = table.Rows[0][1].ToString();
                }
            }
            Totals();
        }

        private void DGVDetailsCommandeRemise_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Totals();
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            PnlAjouterQuantite.Visible = false;
        }

        private void BtnAjouterCommande_Click(object sender, EventArgs e)
        {
            string IdDetailcommande = IdDetailCommande();
            string Idcommande = IdCommande();
            string Idimprimante = "1";
            string Idproduit = ADO.IdProduitByNom(TxtNomProduit.Text);
            string Dateproduit = DateTime.Now.ToString();
            string Quantite = TxtQuantite.Text;
            string Serveur = Form1.GeneralInstance.LblUtilisateur.Text;
            string Nomtable = Form1.NomTable();
            string Etat = "0";

            ADO.Connecter();

            ADO.cmd = new SqlCommand("insert into DetailsCommandeImprimante values(@Id_Commande,@Id_Imprimante,@Id_Produit,@Date_Produit,@Quantite,@Prix,@Serveur,@Nom_Table,@Etat)", ADO.con);
            ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
            ADO.cmd.Parameters.AddWithValue("@Id_Imprimante", Idimprimante);
            ADO.cmd.Parameters.AddWithValue("@Id_Produit", Idproduit);
            ADO.cmd.Parameters.AddWithValue("@Date_Produit", Convert.ToDateTime(Dateproduit));
            ADO.cmd.Parameters.AddWithValue("@Quantite", Quantite);
            ADO.cmd.Parameters.AddWithValue("@Prix", decimal.Parse(ADO.PrixProduitById(int.Parse(Idproduit))));
            ADO.cmd.Parameters.AddWithValue("@Serveur", Serveur);
            ADO.cmd.Parameters.AddWithValue("@Nom_Table", Nomtable);
            ADO.cmd.Parameters.AddWithValue("@Etat", Etat);
            ADO.Connecter();
            ADO.cmd.ExecuteNonQuery();
            ADO.Deconnecter();

            DGVDetailsCommande.Rows.Insert(0, IdDetailcommande, Idproduit, ADO.NomProduitById(int.Parse(Idproduit)), Quantite, ADO.PrixProduitById(int.Parse(Idproduit)));
            UpdateEtatTable(Form1.NomTable(), "1");
            Totals();

            if (ADO.CheckProduitExistsInStock(int.Parse(Idproduit)))
            {
                ADO.Connecter();

                ADO.cmd = new SqlCommand("update ProduitEnStock set Stock_Sortie-=@Stock_Sortie where Id_Produit=@Id_Produit", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Stock_Sortie", Quantite);
                ADO.cmd.Parameters.AddWithValue("@Id_Produit", Idproduit);
                ADO.cmd.ExecuteNonQuery();

                ADO.Deconnecter();
            }

            DGVDetailsCommande.ClearSelection();
            PnlAjouterQuantite.Visible = false;
        }

        private void TxtQuantite_TextChanged(object sender, EventArgs e)
        {
            if (TxtQuantite.Text != "")
            {
                TxtPrixTotal.Text = (decimal.Parse(TxtPrixProduit.Text) * decimal.Parse(TxtQuantite.Text)).ToString();
            }
            else
            {
                TxtPrixTotal.Text = "0.00";
            }
        }

        private void TxtQuantite_Leave(object sender, EventArgs e)
        {
            if (TxtQuantite.Text == "" || decimal.Parse(TxtQuantite.Text) <= 0)
                TxtQuantite.Text = "1";
        }

        private void DGVDetailsCommande_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
            {
                foreach (DataGridViewColumn row in DGVDetailsCommande.Columns)
                {
                    //if (row.Name.Equals("Supprimer"))
                    //{
                    //    // Set Enabled property of the fourth column in the DGV.
                    //    row.Visible = false;
                    //}
                    if (row.Name.Equals("Note"))
                    {
                        // Set Enabled property of the fourth column in the DGV.
                        row.Visible = false;
                    }
                }
            }
        }

        private void TxtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ADO.CheckProduitWithBarCode(TxtBarcode.Text))
                {
                    DataTable table = ADO.BarCodeProduitData(TxtBarcode.Text);

                    string Idproduit = table.Rows[0][0].ToString();
                    string IdCategorie = ADO.IdCategorieParProduit(int.Parse(Idproduit));

                    Nom = ADO.NomProduitById(int.Parse(Idproduit));
                    string IdDetailcommande = IdDetailCommande();
                    string Idcommande = IdCommande();
                    string Idimprimante = ADO.IdImprimanteParCategorie(int.Parse(IdCategorie));
                    string Dateproduit = DateTime.Now.ToString();
                    string Quantite = "1";
                    string Serveur = Form1.GeneralInstance.LblUtilisateur.Text;
                    string Nomtable = Form1.NomTable();
                    string Etat = "0";

                    ADO.Connecter();

                    ADO.cmd = new SqlCommand("insert into DetailsCommandeImprimante values(@Id_Commande,@Id_Imprimante,@Id_Produit,@Date_Produit,@Quantite,@Prix,@Serveur,@Nom_Table,@Etat)", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
                    ADO.cmd.Parameters.AddWithValue("@Id_Imprimante", Idimprimante);
                    ADO.cmd.Parameters.AddWithValue("@Id_Produit", Idproduit);
                    ADO.cmd.Parameters.AddWithValue("@Date_Produit", Convert.ToDateTime(Dateproduit));
                    ADO.cmd.Parameters.AddWithValue("@Quantite", Quantite);
                    ADO.cmd.Parameters.AddWithValue("@Prix", decimal.Parse(ADO.PrixProduitById(int.Parse(Idproduit))));
                    ADO.cmd.Parameters.AddWithValue("@Serveur", Serveur);
                    ADO.cmd.Parameters.AddWithValue("@Nom_Table", Nomtable);
                    ADO.cmd.Parameters.AddWithValue("@Etat", Etat);
                    ADO.Connecter();
                    ADO.cmd.ExecuteNonQuery();
                    ADO.Deconnecter();

                    DGVDetailsCommande.Rows.Insert(0, IdDetailcommande, Idproduit, ADO.NomProduitById(int.Parse(Idproduit)), "1.00", ADO.PrixProduitById(int.Parse(Idproduit)));
                    UpdateEtatTable(Form1.NomTable(), "1");
                    Totals();

                    if (ADO.CheckProduitExistsInStock(int.Parse(Idproduit)))
                    {
                        ADO.Connecter();

                        ADO.cmd = new SqlCommand("update ProduitEnStock set Stock_Sortie-=@Stock_Sortie where Id_Produit=@Id_Produit", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@Stock_Sortie", Quantite);
                        ADO.cmd.Parameters.AddWithValue("@Id_Produit", Idproduit);
                        ADO.cmd.ExecuteNonQuery();

                        ADO.Deconnecter();
                    }

                    DGVDetailsCommande.ClearSelection();
                    TxtBarcode.Clear();
                    TxtBarcode.Focus();

                    //if (ADO.CheckEspaceType().Equals("Restaurant"))
                    //{

                    //}
                    //else
                    //{
                    //    if (Nom != "")
                    //    {
                    //        TxtNomProduit.Text = Nom;
                    //        TxtPrixTotal.Text = TxtPrixProduit.Text = ADO.PrixProduitById(int.Parse(Idproduit));
                    //        PnlAjouterQuantite.Visible = true;
                    //        PnlAjouterQuantite.BringToFront();
                    //    }
                    //}
                }
                else
                {
                    MessageBox.Show("Produit est introuvable !", "Produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnOuvrirTiroir_Click(object sender, EventArgs e)
        {
            try
            {
                string Role = Form1.GeneralInstance.LblRole.Text;

                if (ADO.CheckIfRoleCanOpenTiroir(Role) || Role.Equals(ADO.UserRoles.Admin.ToString()))
                {
                    if (GroupBoxChange.Visible)
                    {
                        GroupBoxChange.Visible = false;
                    }
                    else
                    {
                        GroupBoxDetailsCommande.Enabled = GroupBoxCategorie.Enabled = GroupBoxProduit.Enabled = false;
                        GroupBoxChange.Location = new Point(450, 100);
                        TxtTotalCommande.Text = LblMontantCommande.Text;
                        TxtReste.Text = (decimal.Parse(TxtTotalCommande.Text) - decimal.Parse(TxtEspeceClient.Text)).ToString();
                        GroupBoxChange.Visible = true;
                        GroupBoxChange.BringToFront();
                    }

                    byte[] codeOpenCashDrawer = new byte[] { 27, 112, 48, 55, 121 };
                    IntPtr intPtr = new IntPtr(0);
                    intPtr = Marshal.AllocCoTaskMem(5);
                    Marshal.Copy(codeOpenCashDrawer, 0, intPtr, 5);
                    RawPrinterHelper.SendBytesToPrinter("caisse", intPtr, 5);
                    Marshal.FreeCoTaskMem(intPtr);
                    Totals();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnCloseChange_Click(object sender, EventArgs e)
        {
            TxtEspeceClient.Text = "0.00";
            GroupBoxDetailsCommande.Enabled = GroupBoxCategorie.Enabled = GroupBoxProduit.Enabled = true;
            GroupBoxChange.Visible = false;
        }

        private void TxtEspeceClient_TextChanged(object sender, EventArgs e)
        {
            if (TxtTotalCommande.Text != "" && TxtEspeceClient.Text != "")
            {
                decimal MontantCommande = decimal.Parse(TxtTotalCommande.Text);
                decimal MontantClient = decimal.Parse(TxtEspeceClient.Text);
                decimal Reste = 0;

                if (MontantCommande >= 0 && MontantClient >= 0)
                    Reste = MontantClient - MontantCommande;

                TxtReste.Text = Reste.ToString();

                if (Reste < 0)
                    TxtReste.ForeColor = Color.Crimson;

                if (Reste > 0)
                {
                    TxtReste.ForeColor = Color.SeaGreen;
                    TxtReste.Text = $"+{Reste.ToString()}";
                }

                if (Reste == 0)
                    TxtReste.ForeColor = Color.Gray;
            }

            if (TxtEspeceClient.Text == "")
                TxtEspeceClient.Text = "0.00";
        }

        private void BtnNum0_Click(object sender, EventArgs e)
        {
            decimal MontantClient = decimal.Parse(TxtEspeceClient.Text);

            int IndexOfPoint = TxtEspeceClient.Text.IndexOf('.');
            string MontantAfterPoint = TxtEspeceClient.Text.Substring(IndexOfPoint + 1).ToString();

            if (MontantClient > 0 || TxtEspeceClient.Text.Equals("0."))
            {
                if (MontantAfterPoint.Length < 2 || !TxtEspeceClient.Text.Contains("."))
                    TxtEspeceClient.Text += "0";
            }
            else
            {
                if (MontantClient == 0)
                    TxtEspeceClient.Text = "0";
            }
        }

        private void BtnNum1_Click(object sender, EventArgs e)
        {
            decimal MontantClient = decimal.Parse(TxtEspeceClient.Text);

            int IndexOfPoint = TxtEspeceClient.Text.IndexOf('.');
            string MontantAfterPoint = TxtEspeceClient.Text.Substring(IndexOfPoint + 1).ToString();


            if (MontantClient > 0 || TxtEspeceClient.Text.Equals("0."))
            {
                if (MontantAfterPoint.Length < 2 || !TxtEspeceClient.Text.Contains("."))
                    TxtEspeceClient.Text += "1";
            }
            else
            {
                if (MontantClient == 0)
                    TxtEspeceClient.Text = "1";
            }
        }

        private void BtnNum2_Click(object sender, EventArgs e)
        {
            decimal MontantClient = decimal.Parse(TxtEspeceClient.Text);
            int IndexOfPoint = TxtEspeceClient.Text.IndexOf('.');
            string MontantAfterPoint = TxtEspeceClient.Text.Substring(IndexOfPoint + 1).ToString();

            if (MontantClient > 0 || TxtEspeceClient.Text.Equals("0."))
            {
                if (MontantAfterPoint.Length < 2 || !TxtEspeceClient.Text.Contains("."))
                    TxtEspeceClient.Text += "2";
            }
            else
            {
                if (MontantClient == 0)
                    TxtEspeceClient.Text = "2";
            }
        }

        private void BtnNum3_Click(object sender, EventArgs e)
        {
            decimal MontantClient = decimal.Parse(TxtEspeceClient.Text);
            int IndexOfPoint = TxtEspeceClient.Text.IndexOf('.');
            string MontantAfterPoint = TxtEspeceClient.Text.Substring(IndexOfPoint + 1).ToString();

            if (MontantClient > 0 || TxtEspeceClient.Text.Equals("0."))
            {
                if (MontantAfterPoint.Length < 2 || !TxtEspeceClient.Text.Contains("."))
                    TxtEspeceClient.Text += "3";
            }
            else
            {
                if (MontantClient == 0)
                    TxtEspeceClient.Text = "3";
            }
        }

        private void BtnNum4_Click(object sender, EventArgs e)
        {
            decimal MontantClient = decimal.Parse(TxtEspeceClient.Text);
            int IndexOfPoint = TxtEspeceClient.Text.IndexOf('.');
            string MontantAfterPoint = TxtEspeceClient.Text.Substring(IndexOfPoint + 1).ToString();

            if (MontantClient > 0 || TxtEspeceClient.Text.Equals("0."))
            {
                if (MontantAfterPoint.Length < 2 || !TxtEspeceClient.Text.Contains("."))
                    TxtEspeceClient.Text += "4";
            }
            else
            {
                if (MontantClient == 0)
                    TxtEspeceClient.Text = "4";
            }
        }

        private void BtnNum5_Click(object sender, EventArgs e)
        {
            decimal MontantClient = decimal.Parse(TxtEspeceClient.Text);
            int IndexOfPoint = TxtEspeceClient.Text.IndexOf('.');
            string MontantAfterPoint = TxtEspeceClient.Text.Substring(IndexOfPoint + 1).ToString();

            if (MontantClient > 0 || TxtEspeceClient.Text.Equals("0."))
            {
                if (MontantAfterPoint.Length < 2 || !TxtEspeceClient.Text.Contains("."))
                    TxtEspeceClient.Text += "5";
            }
            else
            {
                if (MontantClient == 0)
                    TxtEspeceClient.Text = "5";
            }
        }

        private void BtnNum6_Click(object sender, EventArgs e)
        {
            decimal MontantClient = decimal.Parse(TxtEspeceClient.Text);
            int IndexOfPoint = TxtEspeceClient.Text.IndexOf('.');
            string MontantAfterPoint = TxtEspeceClient.Text.Substring(IndexOfPoint + 1).ToString();

            if (MontantClient > 0 || TxtEspeceClient.Text.Equals("0."))
            {
                if (MontantAfterPoint.Length < 2 || !TxtEspeceClient.Text.Contains("."))
                    TxtEspeceClient.Text += "6";
            }
            else
            {
                if (MontantClient == 0)
                    TxtEspeceClient.Text = "6";
            }
        }

        private void BtnNum7_Click(object sender, EventArgs e)
        {
            decimal MontantClient = decimal.Parse(TxtEspeceClient.Text);
            int IndexOfPoint = TxtEspeceClient.Text.IndexOf('.');
            string MontantAfterPoint = TxtEspeceClient.Text.Substring(IndexOfPoint + 1).ToString();

            if (MontantClient > 0 || TxtEspeceClient.Text.Equals("0."))
            {
                if (MontantAfterPoint.Length < 2 || !TxtEspeceClient.Text.Contains("."))
                    TxtEspeceClient.Text += "7";
            }
            else
            {
                if (MontantClient == 0)
                    TxtEspeceClient.Text = "7";
            }
        }

        private void BtnNum8_Click(object sender, EventArgs e)
        {
            decimal MontantClient = decimal.Parse(TxtEspeceClient.Text);
            int IndexOfPoint = TxtEspeceClient.Text.IndexOf('.');
            string MontantAfterPoint = TxtEspeceClient.Text.Substring(IndexOfPoint + 1).ToString();

            if (MontantClient > 0 || TxtEspeceClient.Text.Equals("0."))
            {
                if (MontantAfterPoint.Length < 2 || !TxtEspeceClient.Text.Contains("."))
                    TxtEspeceClient.Text += "8";
            }
            else
            {
                if (MontantClient == 0)
                    TxtEspeceClient.Text = "8";
            }
        }

        private void BtnNum9_Click(object sender, EventArgs e)
        {
            decimal MontantClient = decimal.Parse(TxtEspeceClient.Text);
            int IndexOfPoint = TxtEspeceClient.Text.IndexOf('.');
            string MontantAfterPoint = TxtEspeceClient.Text.Substring(IndexOfPoint + 1).ToString();

            if (MontantClient > 0 || TxtEspeceClient.Text.Equals("0."))
            {
                if (MontantAfterPoint.Length < 2 || !TxtEspeceClient.Text.Contains("."))
                    TxtEspeceClient.Text += "9";
            }
            else
            {
                if (MontantClient == 0)
                    TxtEspeceClient.Text = "9";
            }
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            decimal MontantClient = decimal.Parse(TxtEspeceClient.Text);
            int IndexOfPoint = TxtEspeceClient.Text.IndexOf('.');
            string MontantAfterPoint = TxtEspeceClient.Text.Substring(IndexOfPoint + 1).ToString();

            if (MontantClient > 0)
                TxtEspeceClient.Text = "0.00";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (TxtEspeceClient.Text != "")
            {
                string Montant = TxtEspeceClient.Text;
                Montant = Montant.Remove(Montant.Length - 1);
                TxtEspeceClient.Text = Montant;
            }
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            decimal MontantClient = decimal.Parse(TxtEspeceClient.Text);
            if (MontantClient >= 0)
            {
                if (MontantClient == 0)
                    TxtEspeceClient.Text = "0.";
                else
                {
                    bool FindPoint = false;
                    string Montant = TxtEspeceClient.Text;
                    char[] MontantArray = Montant.ToCharArray();
                    foreach (char item in MontantArray)
                    {
                        //MessageBox.Show(item.ToString());
                        if (item.ToString().Equals("."))
                        {
                            //MessageBox.Show("Error !");
                            FindPoint = true;
                            break;
                        }
                    }
                    if (!FindPoint)
                        TxtEspeceClient.Text += ".";
                }
            }
        }

        private void TxtEspeceClient_Click(object sender, EventArgs e)
        {

        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            if (TxtEspeceClient.Text != string.Empty)
            {
                //MessageBox.Show(TxtEspeceClient.Text.IndexOf('.').ToString());
                //MessageBox.Show(TxtEspeceClient.Text.Substring(TxtEspeceClient.Text.IndexOf('.') + 1).ToString());
                //if (TxtEspeceClient.Text.Substring(TxtEspeceClient.Text.IndexOf('.') + 1).ToString().Length > 2)
                //    MessageBox.Show("Error !");
            }
        }
    }
}
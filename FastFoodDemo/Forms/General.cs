using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using FastFoodDemo.Classes;
using FastFoodDemo.User_Controls;
using System.Drawing;
using FastFoodDemo.Rapports;
using System.Threading.Tasks;
using System.Timers;
using System.Net.Mail;
using System.Net;

namespace FastFoodDemo
{
    public partial class Form1 : Form
    {
        public static Form1 GeneralInstance;

        //public static string NomProduit;

        public static long IdDetailCmd;

        public static int EtatTables;

        public static CrystalReportTicketCuisine ticketCuisine = new CrystalReportTicketCuisine();
        public static CrystalReportTicketClient ticketClient = new CrystalReportTicketClient();

        public static Form1 Instance
        {
            get
            {
                if (GeneralInstance == null)
                {
                    GeneralInstance = new Form1();
                }
                return GeneralInstance;
            }
        }

        public Form1()
        {
            InitializeComponent();
            GeneralInstance = this;
        }

        const double interval60Minutes = 1000; // milliseconds to one hour
        System.Timers.Timer checkForTime = new System.Timers.Timer(interval60Minutes);

        //string Check = null;

        ADO ADO = new ADO();

        //string fileName = GenerateFiles.GenerateExcel("RapportVentesTemplate.xlsx", "Rapport des ventes", null, "TOUS", "TOUS", "TOUS", DateTime.Now.ToShortDateString(), DateTime.Now.AddDays(1).ToShortDateString(),);

        //public void EnvoyerRapportParMail()
        //{
        //    try
        //    {
        //        string emailTo = ADO.AdminEmail();

        //        if (fileName != "" && emailTo != "")
        //        {
        //            SmtpClient smtp = new SmtpClient("smtp.gmail.com");

        //            smtp.Port = 587;
        //            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        //            smtp.UseDefaultCredentials = false;
        //            smtp.EnableSsl = true;

        //            NetworkCredential credential = new NetworkCredential("adib.ahmet@gmail.com", "otwrfzmiralwstkk");

        //            smtp.Credentials = credential;

        //            MailMessage message = new MailMessage("adib.ahmet@gmail.com", emailTo);
        //            message.Subject = "Rapport des ventes";
        //            message.Body = "<h2>Le rapport des ventes de " + DateTime.Now.ToShortDateString() + " à " + DateTime.Now.AddDays(1).ToShortDateString() + "</h2>";
        //            message.IsBodyHtml = true;

        //            message.Attachments.Add(new Attachment(fileName));

        //            smtp.Send(message);

        //            MessageBox.Show("Le rapport est bien envoyer !", "Envoyer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Message d'erreur : " + ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        public void CheckPermissionsParRole(string Role)
        {
            ADO.Connecter();

            if (Role.Equals(ADO.UserRoles.Gérant.ToString()))
            {
                ADO.sda = new SqlDataAdapter("CheckPermissionsParRole", ADO.con);
                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                ADO.sda.SelectCommand.Parameters.AddWithValue("@Role", Role);
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                if (table.Rows.Count > 0)
                {
                    if (table.Rows[0][7].ToString().Equals("Non"))
                        BtnGestionCategoriesProduits.ForeColor = Color.Gray; BtnGestionCategoriesProduits.Enabled = false;
                    if (table.Rows[0][8].ToString().Equals("Non"))
                        BtnRapport.ForeColor = Color.Gray; BtnRapport.Enabled = false;
                    if (table.Rows[0][10].ToString().Equals("Non"))
                        BtnBenefice.ForeColor = Color.Gray; BtnBenefice.Enabled = false;
                    if (table.Rows[0][11].ToString().Equals("Non"))
                        BtnParametrage.Enabled = false;
                    if (table.Rows[0][12].ToString().Equals("Non"))
                        BtnUtilisateurs.ForeColor = Color.Gray; BtnUtilisateurs.Enabled = false;
                    if (table.Rows[0][13].ToString().Equals("Non"))
                        BtnCommandes.ForeColor = Color.Gray; BtnCommandes.Enabled = false;
                    if (table.Rows[0][16].ToString().Equals("Non"))
                        BtnCharges.ForeColor = Color.Gray; BtnCharges.Enabled = false;
                }
            }
            if (Role.Equals(ADO.UserRoles.Caissier.ToString()))
                BtnParametrage.Enabled = false;

            ADO.Deconnecter();
        }

        public static string NomTable()
        {
            return Form1.GeneralInstance.LblZone.Text + " " + Form1.GeneralInstance.LblNumTable.Text;
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
        //}

        public string IdDetailCommande()
        {
            ADO.Connecter();

            string IdDetail = "";

            ADO.sda = new SqlDataAdapter("GetIdDetailCommande", ADO.con);
            ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            table.Clear();
            ADO.sda.Fill(table);
            if (table.Rows.Count == 1)
            {
                IdDetail = table.Rows[0][0].ToString();
            }

            return IdDetail;

        }

        //const string NomTable = "Zone Table 1";

        public bool EtatTable()
        {
            ADO.Connecter();

            bool Trouve = false;

            ADO.sda = new SqlDataAdapter("GetTableDefaultEtat", ADO.con);
            ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            table.Clear();
            ADO.sda.Fill(table);
            if (table.Rows.Count == 1)
            {
                string Etattable = table.Rows[0][0].ToString();
                if (Etattable.Equals("0"))
                {
                    Trouve = true;
                }
            }

            return Trouve;

        }

        public string IdCommande()
        {
            ADO.Connecter();

            string Idcommande = "";

            string Query = "";

            if (EtatTable())
            {
                Query = "select ISNULL(MAX(Id_Commande),0)+1 as 'Référenece' from DetailsCommandeImprimante";
            }
            else
            {
                Query = "select ISNULL(MAX(Id_Commande),1) as 'Référenece' from DetailsCommandeImprimante";
            }

            ADO.sda = new SqlDataAdapter(Query, ADO.con);
            DataTable table = new DataTable();
            ADO.sda.Fill(table);
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
            if (table.Rows.Count == 1)
            {
                Prix = table.Rows[0][0].ToString();
            }

            return Prix;

        }

        public void UpdateEtatTable(string nomtable, string etat)
        {
            ADO.Connecter();

            ADO.cmd = new SqlCommand("update TableDefault set Etat=@Etat where Nom=@Nom", ADO.con);
            ADO.cmd.Parameters.AddWithValue("@Nom", nomtable);
            ADO.cmd.Parameters.AddWithValue("@Etat", etat);
            ADO.cmd.ExecuteNonQuery();
        }

        //public void Ajouter_CommandeParImage(object sender, EventArgs e)
        //{
        //    String tag = ((Produit)sender).Tag.ToString();

        //    string IdDetailcommande = IdDetailCommande();
        //    string Idcommande = IdCommande();
        //    string Idimprimante = "1";
        //    string Idproduit = tag;
        //    string Dateproduit = DateTime.Now.ToString();
        //    string Quantite = "1";
        //    string Serveur = Form1.GeneralInstance.LblUtilisateur.Text;
        //    string Nomtable = NomTable();
        //    string Etat = "0";

        //    ADO.Connecter();

        //    ADO.cmd = new SqlCommand("insert into DetailsCommandeImprimante values(@Id_Commande,@Id_Imprimante,@Id_Produit,@Date_Produit,@Quantite,@Prix,@Serveur,@Nom_Table,@Etat)", ADO.con);
        //    ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
        //    ADO.cmd.Parameters.AddWithValue("@Id_Imprimante", Idimprimante);
        //    ADO.cmd.Parameters.AddWithValue("@Id_Produit", Idproduit);
        //    ADO.cmd.Parameters.AddWithValue("@Date_Produit", Convert.ToDateTime(Dateproduit));
        //    ADO.cmd.Parameters.AddWithValue("@Quantite", Quantite);
        //    ADO.cmd.Parameters.AddWithValue("@Prix", decimal.Parse(PrixProdui(Idproduit)));
        //    ADO.cmd.Parameters.AddWithValue("@Serveur", Serveur);
        //    ADO.cmd.Parameters.AddWithValue("@Nom_Table", Nomtable);
        //    ADO.cmd.Parameters.AddWithValue("@Etat", Etat);
        //    ADO.cmd.ExecuteNonQuery();

        //    DGVDetailsCommande.Rows.Insert(0, IdDetailcommande, Idproduit, NomProdui(Idproduit), 1, PrixProdui(Idproduit));
        //    UpdateEtatTable(NomTable(), "1");
        //    Totals();
        //    DGVDetailsCommande.ClearSelection();
        //}

        //public void Ajouter_CommandeParNom(object sender, EventArgs e)
        //{
        //    String tag = ((Label)sender).Tag.ToString();

        //    string IdDetailcommande = IdDetailCommande();
        //    string Idcommande = IdCommande();
        //    string Idimprimante = "1";
        //    string Idproduit = tag;
        //    string Dateproduit = DateTime.Now.ToString();
        //    string Quantite = "1";
        //    string Serveur = Form1.GeneralInstance.LblUtilisateur.Text;
        //    string Nomtable = NomTable();
        //    string Etat = "0";

        //    ADO.Connecter();

        //    ADO.cmd = new SqlCommand("insert into DetailsCommandeImprimante values(@Id_Commande,@Id_Imprimante,@Id_Produit,@Date_Produit,@Quantite,@Prix,@Serveur,@Nom_Table,@Etat)", ADO.con);
        //    ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
        //    ADO.cmd.Parameters.AddWithValue("@Id_Imprimante", Idimprimante);
        //    ADO.cmd.Parameters.AddWithValue("@Id_Produit", Idproduit);
        //    ADO.cmd.Parameters.AddWithValue("@Date_Produit", Convert.ToDateTime(Dateproduit));
        //    ADO.cmd.Parameters.AddWithValue("@Quantite", Quantite);
        //    ADO.cmd.Parameters.AddWithValue("@Prix", PrixProdui(Idproduit));
        //    ADO.cmd.Parameters.AddWithValue("@Serveur", Serveur);
        //    ADO.cmd.Parameters.AddWithValue("@Nom_Table", Nomtable);
        //    ADO.cmd.Parameters.AddWithValue("@Etat", Etat);
        //    ADO.cmd.ExecuteNonQuery();

        //    DGVDetailsCommande.Rows.Insert(0, IdDetailcommande, Idproduit, NomProdui(Idproduit), 1, PrixProdui(Idproduit));
        //    UpdateEtatTable(NomTable(), "1");
        //    Totals();
        //    DGVDetailsCommande.ClearSelection();
        //}

        //public void PictureClickCategorie(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        FlwpnlProduits.Controls.Clear();
        //        String tag = ((Categorie)sender).Tag.ToString();

        //        ADO.Connecter();
        //        ADO.cmd = new SqlCommand("select Image_Produit,Nom_produit,Prix_Normal,Id_Produit from Produit where Id_CategorieProduit=@id_c", ADO.con);
        //        ADO.cmd.Parameters.AddWithValue("@id_c", tag);
        //        DataTable table = new DataTable();
        //        table.Clear();
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
        //            produit.prixProduits = ADO.dr["Prix_Normal"].ToString();
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
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        //public void NomClickCategorie(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        FlwpnlProduits.Controls.Clear();
        //        String tag = ((Label)sender).Tag.ToString();

        //        ADO.Connecter();
        //        ADO.cmd = new SqlCommand("select Image_Produit,Nom_produit,Prix_Normal,Id_Produit from Produit where Id_CategorieProduit=@id_c", ADO.con);
        //        ADO.cmd.Parameters.AddWithValue("@id_c", tag);
        //        DataTable table = new DataTable();
        //        table.Clear();
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
        //            produit.prixProduits = ADO.dr["Prix_Normal"].ToString();
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
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        //public void Totals()
        //{
        //    try
        //    {
        //        if (DGVDetailsCommande.Rows.Count > 0)
        //        {
        //            decimal Price = 0;

        //            for (int i = 0; i < DGVDetailsCommande.Rows.Count; i++)
        //            {
        //                Price += Convert.ToDecimal(DGVDetailsCommande.Rows[i].Cells[4].Value.ToString());
        //            }
        //            LblMontantCommande.Text = Price.ToString();
        //            LblMontantCommande.Visible = true;
        //        }
        //        else
        //        {
        //            LblMontantCommande.Text = "0.00";
        //            LblMontantCommande.Visible = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        //public void AffichierDetailCommande()
        //{
        //    ADO.Connecter();

        //    if (!EtatTable())
        //    {
        //        string Id = IdCommande();
        //        ADO.sda = new SqlDataAdapter("select Id_DetailCommande,Id_Produit,Quantite,Prix from DetailsCommandeImprimante where Id_Commande=@Id_Commande order by Date_Produit desc", ADO.con);
        //        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Commande", Id);
        //        DataTable table = new DataTable();
        //        ADO.sda.Fill(table);
        //        foreach (DataRow row in table.Rows)
        //        {
        //            DGVDetailsCommande.Rows.Add(row[0].ToString(), row[1].ToString(), NomProdui(row[1].ToString()), row[2].ToString(), row[3].ToString());
        //        }
        //        DGVDetailsCommande.Columns[2].Width = 100;
        //        Totals();
        //        DGVDetailsCommande.ClearSelection();
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Thanks for watching Friends...
            //Please dont forget to Subscribe... :) :) :) 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connexion connexion = new Connexion();
            connexion.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //PnlParametrage.Visible = false;
            //BtnHideOrShowSideBar.Enabled = false;
            //SideBar.Visible = false;
            //PnlAffichage.Controls.Clear();
            //PnlAffichage.Controls.Add(new User_Controls.ListeBonReception());
            if (ADO.CheckEspaceTables() && ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
            {
                SideBar.Visible = false;
                PnlAffichage.Controls.Clear();
                PnlAffichage.Controls.Add(new User_Controls.TablesEspace());
            }
            else
            {
                SideBar.Visible = false;
                PnlAffichage.Controls.Clear();
                PnlAffichage.Controls.Add(new PointDeVente());
                IconZone.Visible = LblZone.Visible = IconNumTable.Visible = LblNumTable.Visible = true;
                LblZone.Text = "Zone";
                LblNumTable.Text = "Table 1";
            }
            BtnParametrage.Visible = false;
            BtnFermer.Image = FastFoodDemo.Properties.Resources.icons8_back_50;
            BtnFermer.HoverState.Image = FastFoodDemo.Properties.Resources.icons8_back_30;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!PnlAffichage.Controls.ContainsKey("FirstCustomControl"))
            {
                PnlParametrage.Visible = false;
                BtnHideOrShowSideBar.Enabled = true;
                SidePanel.Visible = true;
                SidePanel.Height = BtnHome.Height;
                SidePanel.Top = BtnHome.Top;
                PnlAffichage.Controls.Clear();
                PnlAffichage.Controls.Add(new FirstCustomControl());
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string Role = Form1.GeneralInstance.LblRole.Text;

            if (ADO.CheckIfRoleCanManageCategoriesAndProducts(Role) || Role.Equals(ADO.UserRoles.Admin.ToString()))
            {
                if (!PnlAffichage.Controls.ContainsKey("GestionCatProd"))
                {
                    PnlParametrage.Visible = false;
                    BtnHideOrShowSideBar.Enabled = true;
                    SidePanel.Visible = true;
                    SidePanel.Height = BtnGestionCategoriesProduits.Height;
                    SidePanel.Top = BtnGestionCategoriesProduits.Top;
                    PnlAffichage.Controls.Clear();
                    PnlAffichage.Controls.Add(new GestionCatProd());
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string Role = Form1.GeneralInstance.LblRole.Text;

            if (ADO.CheckIfRoleCanOpenReport(Role) || Role.Equals(ADO.UserRoles.Admin.ToString()))
            {
                if (!PnlAffichage.Controls.ContainsKey("Rapport"))
                {
                    PnlParametrage.Visible = false;
                    BtnHideOrShowSideBar.Enabled = true;
                    SidePanel.Visible = true;
                    SidePanel.Height = BtnRapport.Height;
                    SidePanel.Top = BtnRapport.Top;
                    PnlAffichage.Controls.Clear();
                    //PnlAffichage.Controls.Add(new MembersDates());
                    PnlAffichage.Controls.Add(new Rapport());
                }
            }
        }

        public void checkForTime_Elapsed(object sender, ElapsedEventArgs e)
        {
            //DateTime target = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 00, 0);
            //DateTime now = DateTime.Now;

            //if (target.ToString("HH:mm:ss") == now.ToString("HH:mm:ss") && (Check == null))
            //{
            //    MessageBox.Show("Welcome Admin " + LblUtilisateur.Text);
            //    checkForTime.Stop();
            //    checkForTime.Enabled = false;
            //}
        }

        //12, 681

        //12, 413

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!ADO.EspaceNom().Equals(string.Empty))
                LblEspaceNom.Text = ADO.EspaceNom();

            PnlParametrage.Visible = SideBar.Visible = PnlHeader.Visible = false;

            PnlAffichage.Controls.Add(new Login());

            CheckPermissionsParRole(LblRole.Text);

            checkForTime.Elapsed += new ElapsedEventHandler(checkForTime_Elapsed);
            checkForTime.Enabled = true;

            if (PnlAffichage.Controls.ContainsKey("PointDeVente") || PnlAffichage.Controls.ContainsKey("TablesEspace"))
                BtnParametrage.Visible = false;

            this.Dock = DockStyle.Fill;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblClock.Text = DateTime.Now.ToString("T");
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            //foreach (Control control in PnlAffichage.Controls)
            //{
            //    MessageBox.Show(control.Name);
            //}

            BtnHideOrShowSideBar.Enabled = true;
            if (PnlAffichage.Controls.ContainsKey("PointDeVente"))
            {
                if (ADO.CheckEspaceTables() && ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
                {
                    IconZone.Visible = LblZone.Visible = IconNumTable.Visible = LblNumTable.Visible = false;
                    PnlAffichage.Controls.Remove(new PointDeVente());
                    new PointDeVente().Dispose();
                    PnlAffichage.Controls.Clear();
                    PnlAffichage.Controls.Add(new User_Controls.TablesEspace());
                }
                else
                {
                    if (LblRole.Text.Equals(ADO.UserRoles.Caissier.ToString()))
                    {
                        if (ADO.CheckEspaceTables())
                        {
                            if (PnlAffichage.Controls.ContainsKey("TablesEspace"))
                            {
                                PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
                                new User_Controls.TablesEspace().Dispose();
                                PnlAffichage.Controls.Clear();
                                PnlAffichage.Controls.Add(new Login());
                            }
                            else
                            {
                                PnlAffichage.Controls.Remove(new PointDeVente());
                                new PointDeVente().Dispose();
                                PnlAffichage.Controls.Clear();
                                PnlAffichage.Controls.Add(new Login());
                                PnlHeader.Visible = false;
                            }
                        }
                        else
                        {
                            PnlAffichage.Controls.Remove(new PointDeVente());
                            new PointDeVente().Dispose();
                            PnlAffichage.Controls.Clear();
                            PnlAffichage.Controls.Add(new Login());
                            PnlHeader.Visible = false;
                        }
                    }
                    else
                    {
                        SideBar.Visible = true;
                        SidePanel.Height = BtnHome.Height;
                        SidePanel.Top = BtnHome.Top;
                        PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
                        new User_Controls.TablesEspace().Dispose();
                        PnlAffichage.Controls.Clear();
                        PnlAffichage.Controls.Add(new FirstCustomControl());
                        IconZone.Visible = LblZone.Visible = IconNumTable.Visible = LblNumTable.Visible = false;
                        BtnFermer.Image = FastFoodDemo.Properties.Resources.icons8_close_50__2_;
                        BtnFermer.HoverState.Image = FastFoodDemo.Properties.Resources.icons8_close_50__4_;
                    }
                    BtnParametrage.Visible = true;
                }

                PointDeVente.ticketCuisine.Close();
                PointDeVente.ticketCuisine.Dispose();

                PointDeVente.ticketClient.Close();
                PointDeVente.ticketClient.Dispose();
            }
            else if (PnlAffichage.Controls.ContainsKey("TablesEspace"))
            {
                if (LblRole.Text.Equals(ADO.UserRoles.Caissier.ToString()))
                {
                    PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
                    new User_Controls.TablesEspace().Dispose();
                    PnlAffichage.Controls.Clear();
                    PnlAffichage.Controls.Add(new Login());
                }
                SideBar.Visible = true;
                SidePanel.Height = BtnHome.Height;
                SidePanel.Top = BtnHome.Top;
                PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
                new User_Controls.TablesEspace().Dispose();
                PnlAffichage.Controls.Clear();
                PnlAffichage.Controls.Add(new FirstCustomControl());
                BtnFermer.Image = FastFoodDemo.Properties.Resources.icons8_close_50__2_;
                BtnFermer.HoverState.Image = FastFoodDemo.Properties.Resources.icons8_close_50__4_;
            }
            else if (!PnlAffichage.Controls.ContainsKey("TablesEspace") || PnlAffichage.Controls.ContainsKey("PointDeVente"))
            {
                if (PnlAffichage.Controls.ContainsKey("ParamEspace"))
                {
                    PnlParametrage.Visible = false;
                    PnlAffichage.Controls.Remove(new ParamEspace());
                    new PointDeVente().Dispose();
                    PnlAffichage.Controls.Clear();
                    PnlAffichage.Controls.Add(new Login());
                    SideBar.Visible = SidePanel.Visible = PnlHeader.Visible = false;
                    BtnFermer.Image = FastFoodDemo.Properties.Resources.icons8_close_50__2_;
                    BtnFermer.HoverState.Image = FastFoodDemo.Properties.Resources.icons8_close_50__4_;
                }
                else
                {
                    if (PnlAffichage.Controls.ContainsKey("BonReception"))
                    {
                        PnlHeader.Visible = true;
                        //SidePanel.Height = BtnHome.Height;
                        //SidePanel.Top = BtnHome.Top;
                        PnlAffichage.Controls.Remove(new BonReception());
                        new BonReception().Dispose();
                        PnlAffichage.Controls.Clear();
                        PnlAffichage.Controls.Add(new ListeBonReception());
                        //SideBar.Visible = SidePanel.Visible = PnlHeader.Visible = false;
                    }
                    else
                    {
                        PnlAffichage.Controls.Remove(new PointDeVente());
                        new PointDeVente().Dispose();
                        PnlAffichage.Controls.Clear();
                        PnlAffichage.Controls.Add(new Login());
                        SideBar.Visible = SidePanel.Visible = PnlHeader.Visible = false;
                    }
                }
            }
            //DataSet dataSet = new DataSet();
            //PointDeVente.ticketClient.SetDataSource(dataSet);
        }

        private void BtnUtilisateurs_Click(object sender, EventArgs e)
        {
            string Role = Form1.GeneralInstance.LblRole.Text;

            if (ADO.CheckIfRoleCanManageUsers(Role) || Role.Equals(ADO.UserRoles.Admin.ToString()))
            {
                if (!PnlAffichage.Controls.ContainsKey("GestionUtilisateur"))
                {
                    PnlParametrage.Visible = false;
                    BtnHideOrShowSideBar.Enabled = true;
                    SidePanel.Visible = true;
                    SidePanel.Height = BtnUtilisateurs.Height;
                    SidePanel.Top = BtnUtilisateurs.Top;
                    PnlAffichage.Controls.Clear();
                    PnlAffichage.Controls.Add(new GestionUtilisateur());
                }
            }
        }

        private void BtnFermerPV_Click(object sender, EventArgs e)
        {
            //if (EtatTables == 1)
            //{
            //    Forms.TablesEspace TablesEspace = new Forms.TablesEspace();
            //    TablesEspace.LblPrenom.Text = this.LblUtilisateur.Text;
            //    this.Hide();
            //    TablesEspace.ShowDialog();
            //}
            //else
            //    PnlPointeDeVente.Visible = false;
        }

        private void DGVDetailsCommande_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 5)
            //{
            //    DialogResult dr = (MessageBox.Show("Voulez-vous vraiment supprimer ce produit ?", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
            //    if (dr == DialogResult.Yes)
            //    {
            //        ADO.Connecter();
            //        string IdDetail = DGVDetailsCommande.SelectedRows[0].Cells[0].Value.ToString();
            //        string Idcommande = IdCommande();
            //        ADO.cmd = new SqlCommand("delete from DetailsCommandeImprimante where Id_DetailCommande=@Id_DetailCommande and Id_Commande=@Id_Commande", ADO.con);
            //        ADO.cmd.Parameters.AddWithValue("@Id_DetailCommande", IdDetail);
            //        ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
            //        ADO.cmd.ExecuteNonQuery();

            //        ADO.cmd = new SqlCommand("delete from ProduitNotes where Id_DetailCommande=@IdDetail", ADO.con);
            //        ADO.cmd.Parameters.AddWithValue("@IdDetail", IdDetail);
            //        ADO.cmd.ExecuteNonQuery();

            //        DGVDetailsCommande.Rows.RemoveAt(DGVDetailsCommande.SelectedRows[0].Index);
            //        if (DGVDetailsCommande.Rows.Count == 0)
            //        {
            //            UpdateEtatTable(NomTable(), "0");
            //        }
            //        Totals();
            //        DGVDetailsCommande.ClearSelection();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Opération de suppression pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //else if (e.ColumnIndex == 6)
            //{
            //    PnlNotes.Visible = true;
            //    PnlNotes.BringToFront();
            //    TxtNote.Focus();
            //    Produit.Text = DGVDetailsCommande.CurrentRow.Cells[2].Value.ToString();
            //    IdDetailCmd = long.Parse(DGVDetailsCommande.CurrentRow.Cells[0].Value.ToString());
            //    DGVDetailsCommande.Enabled = FlwpnlCategories.Enabled = FlwpnlProduits.Enabled = BtnValiderCommande.Enabled = BtnAnnulerCommande.Enabled = false;
            //    AfficherNotes();
            //    ADO.Connecter();
            //    ADO.sda = new SqlDataAdapter("select * from ProduitNotes where Id_DetailCommande=@Id_DetailCommande", ADO.con);
            //    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_DetailCommande", IdDetailCmd);
            //    DataTable table = new DataTable();
            //    ADO.sda.Fill(table);
            //    if (table.Rows.Count > 0)
            //    {
            //        DGVNotesSelectionnes.Rows.Clear();
            //        foreach (DataRow row in table.Rows)
            //        {
            //            ADO.sda = new SqlDataAdapter("select * from Note where Id=@Id", ADO.con);
            //            ADO.sda.SelectCommand.Parameters.AddWithValue("@Id", row[1].ToString());
            //            DataTable data = new DataTable();
            //            ADO.sda.Fill(data);
            //            DGVNotesSelectionnes.Rows.Insert(0, data.Rows[0][0].ToString(), data.Rows[0][1].ToString());
            //        }
            //        DGVNotesSelectionnes.ClearSelection();
            //    }
            //}
        }

        //public void ValiderCommande()
        //{
        //    DialogResult dr = (MessageBox.Show("Voulez-vous vraiment valider cette commande ?", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
        //    if (dr == DialogResult.Yes)
        //    {
        //        ADO.Connecter();

        //        string Idcommande = IdCommande();
        //        string Serveur = Form1.GeneralInstance.LblUtilisateur.Text;
        //        string Nomtable = NomTable();
        //        string DateCommande = DateTime.Now.ToString();
        //        string TotalCommande = LblMontantCommande.Text;

        //        ADO.cmd = new SqlCommand("insert into CommandePayer values(@Id_Commande,@Nom_Serveur,@Nom_Table,@Date_Commande,@Total_Commande)", ADO.con);
        //        ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
        //        ADO.cmd.Parameters.AddWithValue("@Nom_Serveur", Serveur);
        //        ADO.cmd.Parameters.AddWithValue("@Nom_Table", Nomtable);
        //        ADO.cmd.Parameters.AddWithValue("@Date_Commande", Convert.ToDateTime(DateCommande));
        //        ADO.cmd.Parameters.AddWithValue("@Total_Commande", TotalCommande);
        //        UpdateEtatTable(NomTable(), "0");
        //        ADO.cmd.ExecuteNonQuery();
        //        DGVDetailsCommande.Rows.Clear();
        //        DGVDetailsCommande.DataSource = null;
        //        Totals();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Opération de validation pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void BtnValiderCommande_Click(object sender, EventArgs e)
        {
            //if (DGVDetailsCommande.Rows.Count > 0)
            //{
            //    DialogResult dr = (MessageBox.Show("Voulez-vous vraiment valider cette commande ?", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
            //    if (dr == DialogResult.Yes)
            //    {
            //        ADO.Connecter();

            //        string Idcommande = IdCommande();
            //        string Serveur = Form1.Form1Instance.LblUtilisateur.Text;
            //        string Nomtable = NomTable;
            //        string DateCommande = DateTime.Now.ToString();
            //        string TotalCommande = LblMontantCommande.Text;

            //        ADO.cmd = new SqlCommand("insert into CommandePayer values(@Id_Commande,@Nom_Serveur,@Nom_Table,@Date_Commande,@Total_Commande)", ADO.con);
            //        ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
            //        ADO.cmd.Parameters.AddWithValue("@Nom_Serveur", Serveur);
            //        ADO.cmd.Parameters.AddWithValue("@Nom_Table", Nomtable);
            //        ADO.cmd.Parameters.AddWithValue("@Date_Commande", Convert.ToDateTime(DateCommande));
            //        ADO.cmd.Parameters.AddWithValue("@Total_Commande", TotalCommande);
            //        ADO.cmd.ExecuteNonQuery();
            //        UpdateEtatTable(NomTable, "0");
            //        DGVDetailsCommande.Rows.Clear();
            //        DGVDetailsCommande.DataSource = null;
            //        Totals();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Opération de validation pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}

            //CommandeDataSet dataSet = new CommandeDataSet();

            //if (DGVDetailsCommande.Rows.Count > 0)
            //{
            //    string IdCmd = IdCommande();
            //    ADO.Connecter();
            //    //ADO.sda = new SqlDataAdapter("select dci.Id_DetailCommande as 'IdDetailCommande',dci.Id_Commande as 'IdCommande',dci.Serveur as 'Serveur',dci.Nom_Table as 'ZoneTable',p.Nom_Produit as 'Produit',dci.Prix as 'Prix',dci.Quantite as 'Quantite',n.Nom as 'Note' from DetailsCommandeImprimante dci inner join Produit p on dci.Id_Produit=p.Id_Produit left join ProduitNotes pn on pn.Id_DetailCommande=dci.Id_DetailCommande left join Note n on n.Id=pn.Id_Note where dci.Id_Commande=@IdCommande", ADO.con);
            //    ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',dci.Quantite as 'Quantite',dci.Prix as 'Prix',dci.Serveur as 'Serveur',dci.Id_Commande as 'IdCommande',dci.Nom_Table as 'ZoneTable',(select Nom from Espace) as 'NomEspace',(select Adresse from Espace) as 'Adresse',(select Telephone from Espace) as 'Telephone',(select Code_Wifi from Espace) as 'CodeWIFI',(select Message from Espace) as 'Message',(select Logo from Espace) as 'Logo' from DetailsCommandeImprimante dci,Produit p where dci.Id_Produit=p.Id_Produit and dci.Id_Commande=@IdCommande", ADO.con);
            //    ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCommande", IdCmd);
            //    ADO.sda.Fill(dataSet, "Commande");
            //    //ticketCuisine.SetDataSource(dataSet.Tables["Commande"]);
            //    ticketClient.SetDataSource(dataSet.Tables["Commande"]);
            //    //ticketCuisine.PrintToPrinter(0, false, 1, 1);
            //    //ticketCuisine.PrintOptions.PrinterName = "A5";
            //    Print impression = new Print();
            //    //Print.ticketNom = "Cuisine";
            //    Print.ticketNom = "Client";
            //    impression.ShowDialog();
            //    ValiderCommande();
            //}
        }

        private void BtnAnnuterCommande_Click(object sender, EventArgs e)
        {
            //if (DGVDetailsCommande.Rows.Count > 0)
            //{
            //    DialogResult dr = (MessageBox.Show("Voulez-vous vraiment annuler cette commande ?", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
            //    if (dr == DialogResult.Yes)
            //    {
            //        ADO.Connecter();
            //        string Idcommande = IdCommande();
            //        ADO.cmd = new SqlCommand("delete from DetailsCommandeImprimante where Id_Commande=@Id_Commande", ADO.con);
            //        ADO.cmd.Parameters.AddWithValue("@Id_Commande", Idcommande);
            //        ADO.cmd.ExecuteNonQuery();
            //        UpdateEtatTable(NomTable(), "0");
            //        DGVDetailsCommande.Rows.Clear();
            //        DGVDetailsCommande.DataSource = null;
            //        Totals();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Opération d'annulation pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }

        private void BtnScrollRight_Click(object sender, EventArgs e)
        {
            //int ChangePositionRight = FlwpnlCategories.HorizontalScroll.Value + FlwpnlCategories.HorizontalScroll.SmallChange * 40;
            //FlwpnlCategories.AutoScrollPosition = new Point(ChangePositionRight, 0);
        }

        private void BtnScrollLeft_Click(object sender, EventArgs e)
        {
            //int ChangePositionLeft = FlwpnlCategories.HorizontalScroll.Value - FlwpnlCategories.HorizontalScroll.SmallChange * 40;
            //FlwpnlCategories.AutoScrollPosition = new Point(ChangePositionLeft, 0);
        }

        private void BtnScrollUp_Click(object sender, EventArgs e)
        {
            //int ChangePositionUp = FlwpnlProduits.VerticalScroll.Value - FlwpnlProduits.VerticalScroll.SmallChange * 80;
            //FlwpnlProduits.AutoScrollPosition = new Point(0, ChangePositionUp);
        }

        private void BtnScrollDown_Click(object sender, EventArgs e)
        {
            //int ChangePositionDown = FlwpnlProduits.VerticalScroll.Value + FlwpnlProduits.VerticalScroll.SmallChange * 80;
            //FlwpnlProduits.AutoScrollPosition = new Point(0, ChangePositionDown);
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            //if (TxtRechercher.Visible)
            //{
            //    TxtRechercher.Visible = false;
            //}
            //else
            //{
            //    TxtRechercher.Visible = true;
            //}
        }

        private void TxtRechercher_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    FlwpnlProduits.Controls.Clear();
            //    //String tag = ((Label)sender).Tag.ToString();

            //    ADO.Connecter();
            //    ADO.cmd = new SqlCommand("select Image_Produit,Nom_produit,Prix_Normal,Id_Produit from Produit where Nom_produit like '" + TxtRechercher.Text + "%'", ADO.con);
            //    //ADO.cmd.Parameters.AddWithValue("@Nom_produit", TxtRechercher.Text);
            //    DataTable table = new DataTable();
            //    table.Clear();
            //    ADO.dr = ADO.cmd.ExecuteReader();

            //    while (ADO.dr.Read())
            //    {
            //        long len = ADO.dr.GetBytes(0, 0, null, 0, 0);
            //        byte[] array = new byte[Convert.ToInt32(len) + 1];
            //        ADO.dr.GetBytes(0, 0, array, 0, Convert.ToInt32(len));

            //        MemoryStream ms = new MemoryStream(array);
            //        Bitmap bitmap = new Bitmap(ms);

            //        Produit produit = new Produit();
            //        produit.imageProduits = bitmap;
            //        produit.nomProduits = ADO.dr["Nom_produit"].ToString();
            //        produit.prixProduits = ADO.dr["Prix_Normal"].ToString();
            //        produit.Tag = ADO.dr["Id_Produit"].ToString();
            //        produit.LblNomProduit.Tag = ADO.dr["Id_Produit"].ToString();
            //        produit.Cursor = Cursors.Hand;

            //        FlwpnlProduits.Controls.Add(produit);

            //        produit.Click += Ajouter_CommandeParImage;
            //        produit.LblNomProduit.Click += Ajouter_CommandeParNom;

            //        //Guna2CirclePictureBox picture = new Guna2CirclePictureBox();
            //        //picture.Width = 130;
            //        //picture.Height = 104;
            //        //picture.BackgroundImageLayout = ImageLayout.Stretch;
            //        //picture.BorderStyle = BorderStyle.Fixed3D;
            //        //picture.Tag = ADO.dr["Id_Produit"].ToString();

            //        //Label price = new Label();
            //        //price.Text = (ADO.dr["Prix_Normal"].ToString());
            //        //price.AutoSize = true;
            //        //price.ForeColor = Color.White;
            //        //price.BackColor = Color.FromArgb(255, 156, 36);
            //        //price.TextAlign = ContentAlignment.MiddleLeft;
            //        //price.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            //        ////price.Visible = false;
            //        //price.Tag = ADO.dr["Id_Produit"].ToString();

            //        //Label nom = new Label();
            //        //nom.Text = ADO.dr["Nom_produit"].ToString();
            //        //nom.Height = 32;
            //        //nom.ForeColor = Color.White;
            //        //nom.BackColor = Color.FromArgb(255, 140, 0);
            //        //nom.TextAlign = ContentAlignment.MiddleCenter;
            //        //nom.Font = new Font("Century Gothic", 9, FontStyle.Bold);
            //        //nom.Dock = DockStyle.Bottom;
            //        //nom.Tag = ADO.dr["Id_Produit"].ToString();

            //        //MemoryStream ms = new MemoryStream(array);
            //        //Bitmap bitmap = new Bitmap(ms);

            //        //picture.BackgroundImage = bitmap;
            //        //picture.Controls.Add(price);
            //        //picture.Controls.Add(nom);
            //        //FlwpnlProduits.Controls.Add(picture);

            //        //picture.Cursor = Cursors.Hand;

            //        //picture.Click += new EventHandler(Ajouter_Commande);

            //        //price.Click += new EventHandler(Ajouter_Commande1);

            //        //nom.Click += new EventHandler(Ajouter_Commande1);

            //        Totals();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        //public void AfficherNotes()
        //{
        //    ADO.Connecter();
        //    ADO.sda = new SqlDataAdapter("select * from Note", ADO.con);
        //    DataTable table = new DataTable();
        //    ADO.sda.Fill(table);
        //    DGVListeNotes.DataSource = table;
        //    DGVListeNotes.ClearSelection();
        //}

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //PnlNotes.Visible = false;
            //DGVNotesSelectionnes.Rows.Clear();
            //DGVListeNotes.ClearSelection();
            //DGVDetailsCommande.Enabled = FlwpnlCategories.Enabled = FlwpnlProduits.Enabled = BtnValiderCommande.Enabled = BtnAnnulerCommande.Enabled = true;
        }

        private void AjouterNote_Click(object sender, EventArgs e)
        {
            //if (TxtNote.Text != "")
            //{
            //    ADO.Connecter();
            //    ADO.cmd = new SqlCommand("insert into Note values(@Note)", ADO.con);
            //    ADO.cmd.Parameters.AddWithValue("@Note", TxtNote.Text);
            //    ADO.cmd.ExecuteNonQuery();
            //    AfficherNotes();
            //    MessageBox.Show("Note bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    TxtNote.Clear();
            //    TxtNote.Focus();
            //}
            //else
            //{
            //    MessageBox.Show("Veuillez remplir la note !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void ModifierNote_Click(object sender, EventArgs e)
        {
            //if (TxtNote.Text != "")
            //{
            //    ADO.Connecter();
            //    ADO.cmd = new SqlCommand("update Note set Nom=@Nom where Id=@Id", ADO.con);
            //    ADO.cmd.Parameters.AddWithValue("@Nom", TxtNote.Text);
            //    ADO.cmd.Parameters.AddWithValue("@Id", DGVListeNotes.CurrentRow.Cells[0].Value.ToString());
            //    ADO.cmd.ExecuteNonQuery();
            //    AfficherNotes();
            //    MessageBox.Show("Note bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    TxtNote.Clear();
            //    TxtNote.Focus();
            //}
            //else
            //{
            //    MessageBox.Show("Veuillez remplir la note !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void SupprimerNote_Click(object sender, EventArgs e)
        {
            //if (DGVListeNotes.SelectedRows.Count == 1)
            //{
            //    ADO.Connecter();
            //    ADO.cmd = new SqlCommand("delete from Note where Id=@Id", ADO.con);
            //    ADO.cmd.Parameters.AddWithValue("@Id", DGVListeNotes.CurrentRow.Cells[0].Value.ToString());
            //    ADO.cmd.ExecuteNonQuery();
            //    AfficherNotes();
            //    MessageBox.Show("Note bien supprimer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    TxtNote.Clear();
            //    TxtNote.Focus();
            //}
            //else
            //{
            //    MessageBox.Show("Veuillez remplir la note !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void DGVListeNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //public void AjouterProduitNotes()
        //{
        //    ADO.Connecter();
        //    ADO.cmd = new SqlCommand("insert into ProduitNotes values(@IdDetail,@IdNote)", ADO.con);
        //    ADO.cmd.Parameters.AddWithValue("@IdDetail", IdDetailCmd);
        //    ADO.cmd.Parameters.AddWithValue("@IdNote", DGVListeNotes.CurrentRow.Cells[0].Value.ToString());
        //    ADO.cmd.ExecuteNonQuery();
        //    //ADO.Deconnecter();
        //}

        //public void SupprimerProduitNotes()
        //{
        //    ADO.Connecter();
        //    ADO.cmd = new SqlCommand("delete from ProduitNotes where Id_DetailCommande=@IdDetail and Id_Note=@IdNote", ADO.con);
        //    ADO.cmd.Parameters.AddWithValue("@IdDetail", IdDetailCmd);
        //    ADO.cmd.Parameters.AddWithValue("@IdNote", DGVNotesSelectionnes.CurrentRow.Cells[0].Value.ToString());
        //    ADO.cmd.ExecuteNonQuery();
        //    //ADO.Deconnecter();
        //}

        private void AjouterNoteToProduit_Click(object sender, EventArgs e)
        {
            //if (DGVListeNotes.SelectedRows.Count == 1)
            //{
            //    if (DGVNotesSelectionnes.Rows.Count == 0)
            //    {
            //        DGVNotesSelectionnes.Rows.Insert(0, DGVListeNotes.CurrentRow.Cells[0].Value, DGVListeNotes.CurrentRow.Cells[1].Value);
            //        AjouterProduitNotes();
            //        DGVListeNotes.ClearSelection();
            //        DGVNotesSelectionnes.ClearSelection();
            //    }
            //    else
            //    {
            //        bool TrouveNote = false;
            //        foreach (DataGridViewRow row in DGVNotesSelectionnes.Rows)
            //        {
            //            if (row.Cells[0].Value.ToString() == DGVListeNotes.CurrentRow.Cells[0].Value.ToString())
            //            {
            //                TrouveNote = true;
            //                break;
            //            }
            //            else
            //            {
            //                TrouveNote = false;
            //            }
            //        }
            //        if (TrouveNote)
            //        {
            //            MessageBox.Show("Attention, note déjà sélectionnée !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //        else
            //        {
            //            DGVNotesSelectionnes.Rows.Insert(0, DGVListeNotes.CurrentRow.Cells[0].Value, DGVListeNotes.CurrentRow.Cells[1].Value);
            //            AjouterProduitNotes();
            //            DGVListeNotes.ClearSelection();
            //            DGVNotesSelectionnes.ClearSelection();
            //        }
            //    }
            //}
        }

        private void SupprimerNoteToProduit_Click(object sender, EventArgs e)
        {
            //if (DGVNotesSelectionnes.SelectedRows.Count == 1)
            //{
            //    int rowIndex = DGVNotesSelectionnes.CurrentCell.RowIndex;
            //    SupprimerProduitNotes();
            //    DGVNotesSelectionnes.Rows.RemoveAt(rowIndex);
            //    DGVListeNotes.ClearSelection();
            //    DGVNotesSelectionnes.ClearSelection();
            //}
        }

        private void DGVListeNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (DGVListeNotes.SelectedRows.Count == 1)
            //{
            //    TxtNote.Text = DGVListeNotes.CurrentRow.Cells[1].Value.ToString();
            //}
        }

        private void PnlAffichage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnParametrage_Click(object sender, EventArgs e)
        {
            string Role = Form1.GeneralInstance.LblRole.Text;

            if (ADO.CheckIfRoleCanUseParameters(Role) || Role.Equals(ADO.UserRoles.Admin.ToString()))
            {
                if (!PnlAffichage.Controls.ContainsKey("ParamEspace"))
                {
                    BtnFermer.Image = FastFoodDemo.Properties.Resources.icons8_close_50__2_;
                    BtnFermer.HoverState.Image = FastFoodDemo.Properties.Resources.icons8_close_50__4_;
                    PnlParametrage.Visible = true;
                    SidePanel.Visible = PnlParametrage.Visible = true;
                    SidePanel.Visible = false;
                    PnlAffichage.Controls.Clear();
                    PnlAffichage.Controls.Add(new ParamEspace());
                }
            }
        }

        private void BtnNotification_Click(object sender, EventArgs e)
        {

        }

        private void BtnCommandes_Click(object sender, EventArgs e)
        {
            string Role = Form1.GeneralInstance.LblRole.Text;

            if (ADO.CheckIfRoleCanManageCommandes(Role) || Role.Equals(ADO.UserRoles.Admin.ToString()))
            {
                if (!PnlAffichage.Controls.ContainsKey("ListeCommandes"))
                {
                    PnlParametrage.Visible = false;
                    BtnHideOrShowSideBar.Enabled = true;
                    SidePanel.Visible = true;
                    SidePanel.Height = BtnCommandes.Height;
                    SidePanel.Top = BtnCommandes.Top;
                    PnlAffichage.Controls.Clear();
                    PnlAffichage.Controls.Add(new ListeCommandes());
                }
            }
        }

        private void BtnCharges_Click(object sender, EventArgs e)
        {
            string Role = Form1.GeneralInstance.LblRole.Text;

            if (ADO.CheckIfRoleCanOpenCharges(Role) || Role.Equals(ADO.UserRoles.Admin.ToString()))
            {
                if (!PnlAffichage.Controls.ContainsKey("ListeCharges"))
                {
                    PnlParametrage.Visible = false;
                    BtnHideOrShowSideBar.Enabled = true;
                    SidePanel.Visible = true;
                    SidePanel.Height = BtnCharges.Height;
                    SidePanel.Top = BtnCharges.Top;
                    PnlAffichage.Controls.Clear();
                    PnlAffichage.Controls.Add(new ListeCharges());
                }
            }
        }

        private void BtnBenefice_Click(object sender, EventArgs e)
        {
            string Role = Form1.GeneralInstance.LblRole.Text;

            if (ADO.CheckIfRoleCanOpenBenefice(Role) || Role.Equals(ADO.UserRoles.Admin.ToString()))
            {
                if (!PnlAffichage.Controls.ContainsKey("Benefice"))
                {
                    PnlParametrage.Visible = false;
                    BtnHideOrShowSideBar.Enabled = true;
                    SidePanel.Visible = true;
                    SidePanel.Height = BtnBenefice.Height;
                    SidePanel.Top = BtnBenefice.Top;
                    PnlAffichage.Controls.Clear();
                    PnlAffichage.Controls.Add(new Benefice());
                }
            }
        }

        private void IconNumTable_Click(object sender, EventArgs e)
        {

        }

        private void LblZone_Click(object sender, EventArgs e)
        {

        }

        private void IconZone_Click(object sender, EventArgs e)
        {

        }

        private void LblNumTable_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnvoyerRapportEmail_Click(object sender, EventArgs e)
        {
            string Role = Form1.GeneralInstance.LblRole.Text;

            if (ADO.CheckIfRoleCanOpenOnlineReport(Role) || Role.Equals(ADO.UserRoles.Admin.ToString()))
            {
                if (!PnlAffichage.Controls.ContainsKey("RapportParMail"))
                {
                    PnlParametrage.Visible = false;
                    BtnHideOrShowSideBar.Enabled = true;
                    SidePanel.Visible = true;
                    SidePanel.Height = BtnEnvoyerRapportEmail.Height;
                    SidePanel.Top = BtnEnvoyerRapportEmail.Top;
                    PnlAffichage.Controls.Clear();
                    PnlAffichage.Controls.Add(new RapportParMail());
                }
            }
        }

        private void IconUtilisateur_Click(object sender, EventArgs e)
        {

        }

        private void BtnHideOrShowSideBar_Click(object sender, EventArgs e)
        {
            if (PnlAffichage.Controls.ContainsKey("PointDeVente") || PnlAffichage.Controls.ContainsKey("TablesEspace"))
                return;
            timer2.Start();
        }

        bool IsHided = false;

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (PnlAffichage.Controls.ContainsKey("PointDeVente") || PnlAffichage.Controls.ContainsKey("TablesEspace"))
                    return;
                if (!IsHided)
                {
                    SideBar.Width -= 22;
                    BtnHome.Text = BtnPointDeVente.Text = BtnGestionCategoriesProduits.Text = BtnRapport.Text = BtnUtilisateurs.Text = BtnCommandes.Text = BtnCharges.Text = BtnBenefice.Text = BtnEnvoyerRapportEmail.Text = "";
                    BtnHome.Width = BtnPointDeVente.Width = BtnGestionCategoriesProduits.Width = BtnRapport.Width = BtnUtilisateurs.Width = BtnCommandes.Width = BtnCharges.Width = BtnBenefice.Width = BtnEnvoyerRapportEmail.Width = 40;
                    if (SideBar.Width <= 56)
                    {
                        pictureBoxLogo.Visible = LblEspaceNom.Visible = LblEspaceType.Visible = false;
                        BtnLogo.Visible = true;
                        IsHided = true;

                        if (PnlAffichage.Controls.ContainsKey("GestionUtilisateur"))
                        {
                            GestionUtilisateur.GestionUtilisateurlInstance.GroupBoxCategorie.Width = GestionUtilisateur.GestionUtilisateurlInstance.guna2GroupBox1.Width = PnlAffichage.Width - 25;
                        }

                        if (PnlAffichage.Controls.ContainsKey("Rapport"))
                        {
                            Rapport.RapportInstance.GroupBoxCategorie.Width = PnlAffichage.Width - 25;
                        }

                        if (PnlAffichage.Controls.ContainsKey("ListeCommandes"))
                        {
                            ListeCommandes.ListeCommandesInstance.GroupBoxCategorie.Width = PnlAffichage.Width - 25;
                        }

                        if (PnlAffichage.Controls.ContainsKey("ListeCharges"))
                        {
                            ListeCharges.ListeChargesInstance.GroupBoxListeCharges.Width = PnlAffichage.Width - 25;
                        }

                        if (PnlAffichage.Controls.ContainsKey("Benefice"))
                        {
                            Benefice.BeneficelInstance.GroupBoxCategorie.Width = PnlAffichage.Width - 25;
                        }

                        if (PnlAffichage.Controls.ContainsKey("RapportParMail"))
                        {
                            RapportParMail.RapportParMailInstance.GroupBoxCategorie.Width = PnlAffichage.Width - 25;
                        }

                        if (PnlAffichage.Controls.ContainsKey("GestionCatProd"))
                        {
                            if (GestionCatProd.GestionCatProdInstance.PnlAffichage.Controls.ContainsKey("GestionCategories"))
                            {
                                GestionCategories.GestionCategoriesInstance.GroupBoxCategorie.Width = GestionCatProd.GestionCatProdInstance.PnlAffichage.Width - 25;
                                GestionCategories.GestionCategoriesInstance.guna2GroupBox1.Width = GestionCatProd.GestionCatProdInstance.PnlAffichage.Width - 25;
                            }
                            else if (GestionCatProd.GestionCatProdInstance.PnlAffichage.Controls.ContainsKey("GestionProduits"))
                            {
                                GestionProduits.GestionProduitsInstance.GroupBoxCategorie.Width = GestionCatProd.GestionCatProdInstance.PnlAffichage.Width - 25;
                                GestionProduits.GestionProduitsInstance.guna2GroupBox1.Width = GestionCatProd.GestionCatProdInstance.PnlAffichage.Width - 25;
                            }
                        }

                        if (PnlAffichage.Controls.ContainsKey("ParamEspace"))
                        {
                            if (ParamEspace.ParamInstance.PnlContainer.Controls.ContainsKey("GestionImprimantes"))
                            {
                                GestionImprimantes.GestionImprimantesInstance.GroupBoxCategorie.Width = ParamEspace.ParamInstance.PnlContainer.Width - 25;
                                GestionImprimantes.GestionImprimantesInstance.guna2GroupBox1.Width = ParamEspace.ParamInstance.PnlContainer.Width - 25;
                            }
                            else if (ParamEspace.ParamInstance.PnlContainer.Controls.ContainsKey("ParametrePermissions"))
                            {
                                ParametrePermissions.ParametrePermissionsInstance.GroupBoxCategorie.Width = ParamEspace.ParamInstance.PnlContainer.Width - 25;
                                //GestionImprimantes.GestionImprimantesInstance.guna2GroupBox1.Width = GestionCatProd.GestionCatProdInstance.PnlAffichage.Width - 25;
                            }
                            else if (ParamEspace.ParamInstance.PnlContainer.Controls.ContainsKey("ParametreEspace"))
                            {
                                ParametreEspace.ParametreEspaceInstance.GroupBoxCategorie.Width = ParamEspace.ParamInstance.PnlContainer.Width - 25;
                                //ParametreEspace.ParametreEspaceInstance.guna2GroupBox1.Width = GestionCatProd.GestionCatProdInstance.PnlAffichage.Width - 25;
                            }
                            else if (ParamEspace.ParamInstance.PnlContainer.Controls.ContainsKey("GestionStock"))
                            {
                                GestionStock.GestionStockInstance.GroupBoxCategorie.Width = ParamEspace.ParamInstance.PnlContainer.Width - 25;
                                GestionStock.GestionStockInstance.guna2GroupBox1.Width = ParamEspace.ParamInstance.PnlContainer.Width - 25;
                            }
                            else if (ParamEspace.ParamInstance.PnlContainer.Controls.ContainsKey("ParametreTables"))
                            {
                                ParametreTables.ParametreTablesInstance.GroupBoxCategorie.Width = ParamEspace.ParamInstance.PnlContainer.Width - 25;
                                //ParametreTables.ParametreTablesInstance.guna2GroupBox1.Width = GestionCatProd.GestionCatProdInstance.PnlAffichage.Width - 25;
                            }
                        }

                        timer2.Stop();
                        BtnHideOrShowSideBar.Image = FastFoodDemo.Properties.Resources.icons8_double_right_50;
                        this.Refresh();
                    }
                }
                else
                {
                    SideBar.Width += 22;
                    if (SideBar.Width >= 209)
                    {
                        pictureBoxLogo.Visible = LblEspaceNom.Visible = LblEspaceType.Visible = true;
                        BtnLogo.Visible = false;
                        IsHided = false;

                        if (PnlAffichage.Controls.ContainsKey("GestionUtilisateur"))
                        {
                            GestionUtilisateur.GestionUtilisateurlInstance.GroupBoxCategorie.Width = GestionUtilisateur.GestionUtilisateurlInstance.guna2GroupBox1.Width = PnlAffichage.Width - 25;
                        }

                        if (PnlAffichage.Controls.ContainsKey("Rapport"))
                        {
                            Rapport.RapportInstance.GroupBoxCategorie.Width = PnlAffichage.Width - 25;
                        }

                        if (PnlAffichage.Controls.ContainsKey("ListeCommandes"))
                        {
                            ListeCommandes.ListeCommandesInstance.GroupBoxCategorie.Width = PnlAffichage.Width - 25;
                        }

                        if (PnlAffichage.Controls.ContainsKey("ListeCharges"))
                        {
                            ListeCharges.ListeChargesInstance.GroupBoxListeCharges.Width = PnlAffichage.Width - 25;
                        }

                        if (PnlAffichage.Controls.ContainsKey("Benefice"))
                        {
                            Benefice.BeneficelInstance.GroupBoxCategorie.Width = PnlAffichage.Width - 25;
                        }

                        if (PnlAffichage.Controls.ContainsKey("RapportParMail"))
                        {
                            RapportParMail.RapportParMailInstance.GroupBoxCategorie.Width = PnlAffichage.Width - 25;
                        }

                        if (PnlAffichage.Controls.ContainsKey("GestionCatProd"))
                        {
                            if (GestionCatProd.GestionCatProdInstance.PnlAffichage.Controls.ContainsKey("GestionCategories"))
                            {
                                GestionCategories.GestionCategoriesInstance.GroupBoxCategorie.Width = GestionCatProd.GestionCatProdInstance.PnlAffichage.Width - 25;
                                GestionCategories.GestionCategoriesInstance.guna2GroupBox1.Width = GestionCatProd.GestionCatProdInstance.PnlAffichage.Width - 25;
                            }
                            else
                            {
                                GestionProduits.GestionProduitsInstance.GroupBoxCategorie.Width = GestionCatProd.GestionCatProdInstance.PnlAffichage.Width - 25;
                                GestionProduits.GestionProduitsInstance.guna2GroupBox1.Width = GestionCatProd.GestionCatProdInstance.PnlAffichage.Width - 25;
                            }
                        }

                        if (PnlAffichage.Controls.ContainsKey("ParamEspace"))
                        {
                            if (ParamEspace.ParamInstance.PnlContainer.Controls.ContainsKey("GestionImprimantes"))
                            {
                                GestionImprimantes.GestionImprimantesInstance.GroupBoxCategorie.Width = ParamEspace.ParamInstance.PnlContainer.Width - 25;
                                GestionImprimantes.GestionImprimantesInstance.guna2GroupBox1.Width = ParamEspace.ParamInstance.PnlContainer.Width - 25;
                            }
                            else if (ParamEspace.ParamInstance.PnlContainer.Controls.ContainsKey("ParametrePermissions"))
                            {
                                ParametrePermissions.ParametrePermissionsInstance.GroupBoxCategorie.Width = ParamEspace.ParamInstance.PnlContainer.Width - 25;
                                //GestionImprimantes.GestionImprimantesInstance.guna2GroupBox1.Width = GestionCatProd.GestionCatProdInstance.PnlAffichage.Width - 25;
                            }
                            else if (ParamEspace.ParamInstance.PnlContainer.Controls.ContainsKey("ParametreEspace"))
                            {
                                ParametreEspace.ParametreEspaceInstance.GroupBoxCategorie.Width = ParamEspace.ParamInstance.PnlContainer.Width - 25;
                                //ParametreEspace.ParametreEspaceInstance.guna2GroupBox1.Width = GestionCatProd.GestionCatProdInstance.PnlAffichage.Width - 25;
                            }
                            else if (ParamEspace.ParamInstance.PnlContainer.Controls.ContainsKey("GestionStock"))
                            {
                                GestionStock.GestionStockInstance.GroupBoxCategorie.Width = ParamEspace.ParamInstance.PnlContainer.Width - 25;
                                GestionStock.GestionStockInstance.guna2GroupBox1.Width = ParamEspace.ParamInstance.PnlContainer.Width - 25;
                            }
                            else if (ParamEspace.ParamInstance.PnlContainer.Controls.ContainsKey("ParametreTables"))
                            {
                                ParametreTables.ParametreTablesInstance.GroupBoxCategorie.Width = ParamEspace.ParamInstance.PnlContainer.Width - 25;
                                //ParametreTables.ParametreTablesInstance.guna2GroupBox1.Width = GestionCatProd.GestionCatProdInstance.PnlAffichage.Width - 25;
                            }
                        }

                        BtnHome.Width = BtnPointDeVente.Width = BtnGestionCategoriesProduits.Width = BtnRapport.Width = BtnUtilisateurs.Width = BtnCommandes.Width = BtnCharges.Width = BtnBenefice.Width = BtnEnvoyerRapportEmail.Width = 197;
                        BtnHome.Text = "Home                                  الرئيسية";
                        BtnPointDeVente.Text = "Point de vente                    نقطة البيع";
                        BtnGestionCategoriesProduits.Text = "Catégories et produits          الفئات والمنتجات";
                        BtnRapport.Text = "Rapports                                     التقارير";
                        BtnUtilisateurs.Text = "Utilisateurs                        المستخدمين";
                        BtnCommandes.Text = "Commandes                        الطلبات";
                        BtnCharges.Text = "Charges                                      النفقات";
                        BtnBenefice.Text = "Bénéfice                                                             الأرباح";
                        BtnEnvoyerRapportEmail.Text = "Rapport par mail                التقرير عن طريق البريد";
                        timer2.Stop();
                        BtnHideOrShowSideBar.Image = FastFoodDemo.Properties.Resources.icons8_double_left_50;
                        this.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            if (GestionUtilisateur.GestionUtilisateurlInstance.PnlProfile.Visible)
            {
                GestionUtilisateur.GestionUtilisateurlInstance.PnlProfile.Visible = false;
            }
            else
            {
                GestionUtilisateur.GestionUtilisateurlInstance.PnlProfile.Visible = true;
            }
        }

        private void ClockIcon_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Message1");

            //await Task.Delay(TimeSpan.FromSeconds(5));

            //MessageBox.Show("Message2");
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
    // icon location => 11, 18
}
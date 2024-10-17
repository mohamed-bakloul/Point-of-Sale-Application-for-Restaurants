using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using FastFoodDemo.Classes;
using System.Text;
using FastFoodDemo.Models;

namespace FastFoodDemo.User_Controls
{
    public partial class GestionCategories : UserControl
    {
        public static GestionCategories GestionCategoriesInstance;

        public static GestionCategories Instance
        {
            get
            {
                if (GestionCategoriesInstance == null)
                {
                    GestionCategoriesInstance = new GestionCategories();
                }
                return GestionCategoriesInstance;
            }
        }

        public GestionCategories()
        {
            InitializeComponent();
            GestionCategoriesInstance = this;
        }

        //public string connString = string.Format("User ID=postgres;Password=0000;Host=localhost;Port=5432;Database=MyDataBase;");

        //public NpgsqlConnection con;

        //public NpgsqlDataAdapter sda;

        ADO ADO = new ADO();

        NumberToWords NumberToWords = new NumberToWords();

        DataTable tableCategorie = new DataTable();

        GestionEspaceEntities _db = new GestionEspaceEntities();

        static string IdCategorie;

        public void Supprimer()
        {
            if (DGVCategories.Rows.Count > 0)
            {
                if (DGVCategories.SelectedRows.Count == 1)
                {
                    /* ADO */
                    //ADO.Connecter();
                    //ADO.cmd = new SqlCommand("delete from Produit where Id_Produit=@Id_Produit and Code_Barre!='-'", ADO.con);
                    //ADO.cmd.Parameters.AddWithValue("@Id_Produit", DGVCategories.CurrentRow.Cells[0].Value.ToString());
                    //ADO.cmd.ExecuteNonQuery();
                    //MessageBox.Show("Produit est bien supprimer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    /* EF*/
                    FastFoodDemo.Models.Categorie categorie = _db.Categorie.Find(DGVCategories.SelectedRows[0].Cells[0].Value.ToString());
                    if (categorie != null)
                    {
                        _db.Categorie.Remove(categorie);
                        _db.SaveChanges();
                    }
                }
            }
        }

        public void Afficher_Catgorie()
        {
            try
            {
                //con = new NpgsqlConnection(connString);

                //con.Open();

                //sda = new NpgsqlDataAdapter("SELECT "Id", "FullName", "Age", "Phone" FROM public."Users";",con);

                //DataTable table = new DataTable();

                //sda.Fill(table);

                //DGVCategories.DataSource = table;

                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("ListeCategories", ADO.con);
                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                tableCategorie.Clear();
                ADO.sda.Fill(tableCategorie);
                DGVCategories.DataSource = tableCategorie;
                DGVCategories.Columns[0].Visible = false;
                DGVCategories.Columns[1].Width = 200;
                DGVCategories.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                if (DGVCategories.Rows.Count == 0)
                {
                    System.Data.DataTable dd = new System.Data.DataTable();
                    //DGVListeImprimantes.Width = 140;
                    //DGVListeImprimantes.Height = 90;
                    dd.Columns.Add("Message");
                    //dd.Columns.Add("Nom");
                    dd.Rows.Add("Pas de données !");
                    DGVCategories.DataSource = dd;
                    DGVCategories.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Ajouter_Categorie()
        {
            try
            {
                if (ImageCategorie.Image == null || TxtNomCategorie.Text == "")
                {
                    MessageBox.Show("Attention, Veuillez remplir les champs !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MemoryStream mr = new MemoryStream();
                    ImageCategorie.Image.Save(mr, ImageFormat.Png);
                    byte[] byteimagep = mr.ToArray();

                    ADO.Connecter();

                    ADO.cmd = new SqlCommand("insert into Categorie values(@Nom_Categorie,@Image_Categorie,@IsDeleted)", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Nom_Categorie", TxtNomCategorie.Text);
                    ADO.cmd.Parameters.AddWithValue("@Image_Categorie", byteimagep);
                    ADO.cmd.Parameters.AddWithValue("@IsDeleted", 0);
                    ADO.cmd.ExecuteNonQuery();

                    MessageBox.Show("Catégorie est bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ADO.Deconnecter();

                    ADO.Connecter();
                    ADO.sda = new SqlDataAdapter("select IDENT_CURRENT('Categorie') as 'Id'", ADO.con);
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    if (table.Rows.Count == 1)
                    {
                        string IdCategorie = table.Rows[0][0].ToString();

                        ADO.sda = new SqlDataAdapter("select Id_Categorie from Imprimante_Categorie where Id_Categorie=@Id", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id", IdCategorie);
                        DataTable tableExistsCategorie = new DataTable();
                        ADO.sda.Fill(tableExistsCategorie);
                        if (tableExistsCategorie.Rows.Count == 0)
                        {
                            ADO.cmd = new SqlCommand("insert into Imprimante_Categorie values(@Id_Imprimante,@Id_Categorie)", ADO.con);
                            ADO.cmd.Parameters.AddWithValue("@Id_Imprimante", 1);
                            ADO.cmd.Parameters.AddWithValue("@Id_Categorie", IdCategorie);
                            ADO.cmd.ExecuteNonQuery();
                        }
                    }

                    TxtNomCategorie.Clear();

                    ImageCategorie.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Modifier_Categorie()
        {
            try
            {
                if (ImageCategorie.Image == null || TxtNomCategorie.Text == "")
                {
                    MessageBox.Show("Attention, veuillez remplir les champs !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MemoryStream mr = new MemoryStream();
                    ImageCategorie.Image.Save(mr, ImageFormat.Png);
                    byte[] byteimagep = mr.ToArray();

                    ADO.Connecter();

                    ADO.cmd = new SqlCommand("Update Categorie set Nom_Categorie=@Nom_Categorie,Image_Categorie=@Image_Categorie where Id_Categorie=@Id_Categorie", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Nom_Categorie", TxtNomCategorie.Text);
                    ADO.cmd.Parameters.AddWithValue("@Image_Categorie", byteimagep);
                    ADO.cmd.Parameters.AddWithValue("@Id_Categorie", IdCategorie /*DGV_Categorie.CurrentRow.Cells[0].Value.ToString()*/);
                    ADO.cmd.ExecuteNonQuery();

                    MessageBox.Show("Catégorie est bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TxtNomCategorie.Clear();
                    ImageCategorie.Image = null;

                    //BtnAjouter.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Supprimer_Categorie()
        {
            try
            {
                if (DGVCategories.SelectedRows.Count == 1)
                {
                    ADO.Connecter();

                    ADO.sda = new SqlDataAdapter("select Id_Produit from Produit where Id_CategorieProduit=@Id_CategorieP and Id_Produit in (select Id_Produit from DetailsCommandeImprimante)", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_CategorieP", DGVCategories.SelectedRows[0].Cells[0].Value.ToString());
                    DataTable table = new DataTable();
                    table.Clear();
                    ADO.sda.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Vous n'avez pas le droit de supprimer cette catégorie car elle contenait des articles liés au rapport des ventes !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Voulez-vous vraiment de supprimer cette Catégorie ?", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            ADO.Connecter();

                            //ADO.cmd = new SqlCommand("delete from Categorie where Id_Categorie=@id_categorie", ADO.con);
                            ADO.cmd = new SqlCommand("update Categorie set IsDeleted=1 where Id_Categorie=@id_categorie", ADO.con);
                            ADO.cmd.Parameters.AddWithValue("@id_categorie", DGVCategories.SelectedRows[0].Cells[0].Value.ToString());
                            ADO.cmd.ExecuteNonQuery();

                            MessageBox.Show("Catégorie est bien supprimer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            TxtNomCategorie.Clear();
                            ImageCategorie.Image = null;
                        }
                        else
                        {
                            MessageBox.Show("Opération de suppression pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GestionCategories_Load(object sender, EventArgs e)
        {
            Afficher_Catgorie();
            TxtNomCategorie.Focus();
            GroupBoxCategorie.Width = guna2GroupBox1.Width = Form1.GeneralInstance.PnlAffichage.Width - 25;
            this.Dock = DockStyle.Fill;
        }

        private void BtnParcourir_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "|*.JPG;*.PNG;*.GIF;*.BMP;*.ico;*.jfif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    LblErrorMessageImage.Visible = false;
                    ImageCategorie.Image = Image.FromFile(ofd.FileName);
                    Bitmap bitmap = new Bitmap(ImageCategorie.Image, 150, 150);
                    ImageCategorie.Image = bitmap;
                }
                else
                {
                    if (ImageCategorie.Image == null)
                        LblErrorMessageImage.Visible = true;
                    else
                        LblErrorMessageImage.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            Ajouter_Categorie();
            Afficher_Catgorie();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            Modifier_Categorie();
            Afficher_Catgorie();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Supprimer_Categorie();
            Afficher_Catgorie();
        }

        private void DGVCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGVCategories.SelectedRows.Count == 1)
                {
                    byte[] image = Encoding.ASCII.GetBytes(DGVCategories.SelectedRows[0].Cells[2].Value.ToString());
                    if (image != null)
                    {
                        var Data = (byte[])(DGVCategories.SelectedRows[0].Cells[2].Value);
                        var stream = new MemoryStream(Data);

                        TxtNomCategorie.Text = DGVCategories.SelectedRows[0].Cells[1].Value.ToString();
                        ImageCategorie.Image = Image.FromStream(stream);

                        IdCategorie = DGVCategories.SelectedRows[0].Cells[0].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GroupBoxCategorie_Click(object sender, EventArgs e)
        {

        }

        private void TxtNomCategorie_Leave(object sender, EventArgs e)
        {
            //if (TxtNomCategorie.Text == "")
            //{
            //    LblErrorMessage.Visible = true;
            //}
            //else
            //{
            //    LblErrorMessage.Visible = false;

            //    //string number = TxtNomCategorie.Text;
            //    //number = NumberToWords.ConvertAmount(double.Parse(number));

            //    //MessageBox.Show(number, "Number to English");
            //}
        }

        private void TxtNomCategorie_TextChanged(object sender, EventArgs e)
        {
            //if (TxtNomCategorie.Text == "")
            //{
            //    LblErrorMessage.Visible = true;
            //}
            //else
            //{
            //    LblErrorMessage.Visible = false;

            //    //string number = TxtNomCategorie.Text;
            //    //number = NumberToWords.ConvertAmount(double.Parse(number));

            //    //MessageBox.Show(number, "Number to English");
            //}
        }
    }
}
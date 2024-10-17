using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using FastFoodDemo.Classes;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Text;

namespace FastFoodDemo.User_Controls
{
    public partial class GestionProduits : UserControl
    {
        public static GestionProduits GestionProduitsInstance;

        public static GestionProduits Instance
        {
            get
            {
                if (GestionProduitsInstance == null)
                {
                    GestionProduitsInstance = new GestionProduits();
                }
                return GestionProduitsInstance;
            }
        }

        public GestionProduits()
        {
            InitializeComponent();
            GestionProduitsInstance = this;
        }

        ADO ADO = new ADO();

        DataTable table = new DataTable();

        private void Vider()
        {
            TxtNomProduit.Text = TxtPrixProduit.Text = "";
            ImageProduit.Image = null;
        }

        private void GestionProduits_Load(object sender, EventArgs e)
        {
            Afficher_Produit();

            ADO.RemplirCombo("GetCategorieIdAndName", CmbCategorie, "Nom_Categorie", "Id_Categorie", "");

            TxtNomProduit.Focus();

            if (ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Boulangerie.ToString()))
            {
                LblPrixNormal.Text = "Prix en Kg";
                LblCodeBarre.Visible = TxtCodeBarre.Visible = false;
            }
            else if (ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
            {
                LblCodeBarre.Visible = TxtCodeBarre.Visible = false;
            }

            GroupBoxCategorie.Width = guna2GroupBox1.Width = Form1.GeneralInstance.PnlAffichage.Width - 25;

            this.Dock = DockStyle.Fill;
        }

        public static string IdProduit = "";

        public void ListProdParCat(string IdCat)
        {
            ADO.Connecter();
            ADO.sda = new SqlDataAdapter("select Id_CategorieProduit from Produit where Id_CategorieProduit=@Id_CategorieP", ADO.con);
            ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_CategorieP", IdCat);
            DataTable tableListProdParCat = new DataTable();
            ADO.sda.Fill(tableListProdParCat);
            if (tableListProdParCat.Rows.Count > 0)
            {
                for (int i = 0; i < tableListProdParCat.Rows.Count; i++)
                {
                    MessageBox.Show(tableListProdParCat.Rows[i][1].ToString());
                }
            }
        }

        //public string IdProduit()
        //{
        //    string IdProd = "";

        //    ADO.Connecter();

        //    ADO.sda = new SqlDataAdapter("select Id_Produit from Produit where Nom_produit=@Nom_produit and Emplacement=@Emplacement and Id_CategorieP=@Id_CategorieP and Prix_Normal=@Prix_Normal and Prix_Livraison=@Prix_Livraison", ADO.con);
        //    ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom_produit", TBoxNomProd.Text);
        //    ADO.sda.SelectCommand.Parameters.AddWithValue("@Emplacement", TBoxEmplacement.Text);
        //    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_CategorieP", combo_Categorie.SelectedValue);
        //    ADO.sda.SelectCommand.Parameters.AddWithValue("@Prix_Normal", TBoxPrixNorm.Text);
        //    ADO.sda.SelectCommand.Parameters.AddWithValue("@Prix_Livraison", TBoxPrixLiv.Text);

        //    DataTable tableIdProduit = new DataTable();
        //    tableIdProduit.Clear();
        //    ADO.sda.Fill(tableIdProduit);

        //    if (tableIdProduit.Rows.Count > 0)
        //    {
        //        IdProd = tableIdProduit.Rows[0][0].ToString();
        //    }

        //    return IdProd;

        //}

        private bool alreadyExist(string _text, ref char KeyChar)
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }

        public void Afficher_Produit()
        {
            try
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("GetListOfProducts", ADO.con);
                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                table.Clear();
                ADO.sda.Fill(table);
                DGVProduits.DataSource = table;
                DGVProduits.Columns[0].Visible = false;
                DGVProduits.Columns[1].Width = 200;
                if (ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
                    DGVProduits.Columns[6].Visible = false;

                if (DGVProduits.Rows.Count == 0)
                {
                    System.Data.DataTable dd = new System.Data.DataTable();
                    //DGVListeImprimantes.Width = 140;
                    //DGVListeImprimantes.Height = 90;
                    dd.Columns.Add("Message");
                    //dd.Columns.Add("Nom");
                    dd.Rows.Add("Pas de données !");
                    DGVProduits.DataSource = dd;
                    DGVProduits.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                }
                //foreach (DataGridViewRow row in DGVProduits.Rows)
                //{
                //    ADO.cmd = new SqlCommand("update Produit set Prix_Livraison = Prix_Normal + 15 where Id_Produit=@Id", ADO.con);
                //    ADO.cmd.Parameters.AddWithValue("@Id", row.Cells[0].Value.ToString());
                //    ADO.cmd.ExecuteNonQuery();
                //}

                //DataGridViewImageColumn col = new DataGridViewImageColumn();
                ////col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //col.Image = Properties.Resources.icons8_full_trash_25;
                //DGVProduits.Columns.Add(col);
                //DGVProduits.Columns[7].Width = 50;

                //DataGridViewImageColumn col1 = new DataGridViewImageColumn();
                ////col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //col1.Image = Properties.Resources.icons8_edit_text_file_30;
                //DGVProduits.Columns.Add(col1);
                //DGVProduits.Columns[8].Width = 50;

                //for (int row = 0; row <= DGVProduits.Rows.Count - 1; row++)
                //{
                //    ((DataGridViewImageCell)DGVProduits.Rows[row].Cells[0]).Value = Properties.Resources.icons8_close_50;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Ajouter_Produit()
        {
            try
            {
                if (ImageProduit.Image == null || TxtNomProduit.Text == "" || TxtPrixProduit.Text == "" || CmbCategorie.Text == "")
                {
                    MessageBox.Show("Attention, veuillez remplir les champs !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string BarCode = "0";
                    if (ADO.CheckEspaceType().Equals("Autre"))
                        BarCode = TxtCodeBarre.Text;

                    ADO.Connecter();

                    MemoryStream mr = new MemoryStream();
                    ImageProduit.Image.Save(mr, ImageFormat.Png);
                    byte[] byteimagep = mr.ToArray();

                    ADO.cmd = new SqlCommand("insert into Produit values(@nom_produit,@id_categorie,@prixNormal,@prixLivraison,@image_produit,@barcode,@isDeleted,@url)", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@nom_produit", TxtNomProduit.Text);
                    ADO.cmd.Parameters.AddWithValue("@id_categorie", CmbCategorie.SelectedValue);
                    ADO.cmd.Parameters.AddWithValue("@prixNormal", TxtPrixProduit.Text);
                    ADO.cmd.Parameters.AddWithValue("@prixLivraison", TxtPrixLivraison.Text);
                    ADO.cmd.Parameters.AddWithValue("@image_produit", byteimagep);
                    ADO.cmd.Parameters.AddWithValue("@barcode", BarCode);
                    ADO.cmd.Parameters.AddWithValue("@isDeleted", 0);
                    ADO.cmd.Parameters.AddWithValue("@url", string.Empty);
                    ADO.cmd.ExecuteNonQuery();

                    MessageBox.Show("Produit est bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Vider();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Modifier_Produit()
        {
            try
            {
                if (DGVProduits.Rows.Count != 0)
                {
                    if (DGVProduits.SelectedRows.Count == 1)
                    {
                        if (ImageProduit.Image == null || TxtNomProduit.Text == "" || TxtPrixProduit.Text == "" || CmbCategorie.Text == "")
                        {
                            MessageBox.Show("Attention, Veuillez remplir les champs !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            string BarCode = "0";
                            if (ADO.CheckEspaceType().Equals("Autre"))
                                BarCode = TxtCodeBarre.Text;

                            ADO.Connecter();

                            MemoryStream mr = new MemoryStream();
                            ImageProduit.Image.Save(mr, ImageFormat.Png);
                            byte[] byteimagep = mr.ToArray();

                            ADO.cmd = new SqlCommand("update Produit set Nom_produit=@Nom_produit,Id_CategorieProduit=@Id_CategorieP,Prix_Normal=@Prix_Normal,Prix_Livraison=@Prix_Livraison,Image_Produit=@Image_Produit,CodeBarre=@CodeBarre where Id_Produit=@Id_Produit", ADO.con);
                            ADO.cmd.Parameters.AddWithValue("@Nom_produit", TxtNomProduit.Text);
                            ADO.cmd.Parameters.AddWithValue("@Id_CategorieP", CmbCategorie.SelectedValue);
                            ADO.cmd.Parameters.AddWithValue("@Prix_Normal", TxtPrixProduit.Text);
                            ADO.cmd.Parameters.AddWithValue("@Prix_Livraison", TxtPrixLivraison.Text);
                            ADO.cmd.Parameters.AddWithValue("@Image_Produit", byteimagep);
                            ADO.cmd.Parameters.AddWithValue("@CodeBarre", BarCode);
                            ADO.cmd.Parameters.AddWithValue("@Id_Produit", IdProduit /*DGV_Produit.CurrentRow.Cells[0].Value.ToString()*/);
                            ADO.cmd.ExecuteNonQuery();

                            MessageBox.Show("Produit est bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Afficher_Produit();
                            Vider();

                            BtnAjouter.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Attention, veuillez choisir une ligne !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Attention, aucun ligne dans la table !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Supprimer_Produit()
        {
            try
            {
                if (DGVProduits.Rows.Count != 0)
                {
                    if (DGVProduits.SelectedRows.Count == 1)
                    {
                        ADO.Connecter();

                        ADO.sda = new SqlDataAdapter("select Id_Produit from DetailsCommandeImprimante where Id_Produit=@Id_Produit", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", DGVProduits.SelectedRows[0].Cells[0].Value.ToString());
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Vous n'avez pas le droit de supprimer cet article car il est lié au rapport de vente !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            DGVProduits.ClearSelection();
                        }
                        else
                        {
                            DialogResult dr = (MessageBox.Show("Voulez-vous vraiment supprimer ce produit !", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
                            if (dr == DialogResult.Yes)
                            {
                                ADO.cmd = new SqlCommand("update Produit set IsDeleted=1 where Id_Produit=@Id_Produit", ADO.con);
                                ADO.cmd.Parameters.AddWithValue("@Id_Produit", DGVProduits.SelectedRows[0].Cells[0].Value.ToString());
                                ADO.cmd.ExecuteNonQuery();

                                MessageBox.Show("Produit est bien supprimer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Afficher_Produit();
                                DGVProduits.ClearSelection();
                                Vider();
                            }
                            else
                            {
                                MessageBox.Show("Opération de suppression pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Attention, veuillez choisir une ligne !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Attention, aucun ligne dans la table !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                    ImageProduit.Image = Image.FromFile(ofd.FileName);
                    Bitmap bitmap = new Bitmap(ImageProduit.Image, 150, 150);
                    ImageProduit.Image = bitmap;
                }
                else
                {
                    if (ImageProduit.Image == null)
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
            Ajouter_Produit();
            Afficher_Produit();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            Modifier_Produit();
            Afficher_Produit();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            Supprimer_Produit();
            Afficher_Produit();
        }

        private void DGVProduits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGVProduits.Rows.Count != 0)
                {
                    if (DGVProduits.SelectedRows.Count == 1)
                    {
                        TxtNomProduit.Text = DGVProduits.SelectedRows[0].Cells[1].Value.ToString();
                        CmbCategorie.Text = DGVProduits.SelectedRows[0].Cells[2].Value.ToString();
                        TxtPrixProduit.Text = DGVProduits.SelectedRows[0].Cells[3].Value.ToString();
                        TxtPrixLivraison.Text = DGVProduits.SelectedRows[0].Cells[4].Value.ToString();

                        byte[] image = Encoding.ASCII.GetBytes(DGVProduits.SelectedRows[0].Cells[5].Value.ToString());

                        if (image != null)
                        {
                            var Data = (byte[])(DGVProduits.SelectedRows[0].Cells[5].Value);
                            var stream = new MemoryStream(Data);
                            ImageProduit.Image = Image.FromStream(stream);
                            IdProduit = DGVProduits.SelectedRows[0].Cells[0].Value.ToString();
                        }

                        if (!ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
                            TxtCodeBarre.Text = DGVProduits.SelectedRows[0].Cells[6].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Attention, veuillez choisir une ligne !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Attention, aucun ligne dans la table !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtPrixProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // check if it's in the beginning of text not accept
                if (TxtPrixProduit.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (TxtPrixProduit.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(TxtPrixProduit.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (TxtPrixProduit.SelectionStart != TxtPrixProduit.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = TxtPrixProduit.Text.Substring(TxtPrixProduit.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            //check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                //check if a coma or dot exist
                if (alreadyExist(TxtPrixProduit.Text, ref sepratorChar))
                {
                    int sepratorPosition = TxtPrixProduit.Text.IndexOf(sepratorChar);
                    string afterSepratorString = TxtPrixProduit.Text.Substring(sepratorPosition + 1);
                    if (TxtPrixProduit.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void LblErrorMessageCodeBarre_Leave(object sender, EventArgs e)
        {
            //if (TxtCodeBarre.Text == "")
            //{
            //    LblErrorMessageCodeBarre.Visible = true;
            //}
            //else
            //{
            //    LblErrorMessageCodeBarre.Visible = false;
            //}
        }

        private void TxtPrixLivraison_Leave(object sender, EventArgs e)
        {
            
        }

        private void TxtPrixProduit_Leave(object sender, EventArgs e)
        {
            
        }

        private void TxtNomProduit_Leave(object sender, EventArgs e)
        {
            
        }

        private void TxtNomProduit_TextChanged(object sender, EventArgs e)
        {
            //if (TxtNomProduit.Text == "")
            //{
            //    LblErrorMessageNom.Visible = true;
            //}
            //else
            //{
            //    LblErrorMessageNom.Visible = false;
            //}
        }

        private void TxtPrixProduit_TextChanged(object sender, EventArgs e)
        {
            //if (TxtPrixProduit.Text == "")
            //{
            //    LblErrorMessagePrixNormal.Visible = true;
            //}
            //else
            //{
            //    LblErrorMessagePrixNormal.Visible = false;
            //}
        }

        private void TxtPrixLivraison_TextChanged(object sender, EventArgs e)
        {
            //if (TxtPrixLivraison.Text == "")
            //{
            //    LblErrorMessagePrixLivraison.Visible = true;
            //}
            //else
            //{
            //    LblErrorMessagePrixLivraison.Visible = false;
            //}
        }

        private void TxtCodeBarre_TextChanged(object sender, EventArgs e)
        {
            //if (TxtCodeBarre.Text == "")
            //{
            //    LblErrorMessageCodeBarre.Visible = true;
            //}
            //else
            //{
            //    LblErrorMessageCodeBarre.Visible = false;
            //}
        }
    }
}
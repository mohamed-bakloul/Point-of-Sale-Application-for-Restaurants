
namespace FastFoodDemo.User_Controls
{
    partial class GestionProduits
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionProduits));
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DGVProduits = new Guna.UI2.WinForms.Guna2DataGridView();
            this.GroupBoxCategorie = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LblErrorMessageImage = new System.Windows.Forms.Label();
            this.LblErrorMessageCodeBarre = new System.Windows.Forms.Label();
            this.LblErrorMessagePrixLivraison = new System.Windows.Forms.Label();
            this.LblErrorMessagePrixNormal = new System.Windows.Forms.Label();
            this.LblErrorMessageNom = new System.Windows.Forms.Label();
            this.LblCodeBarre = new System.Windows.Forms.Label();
            this.TxtCodeBarre = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblPrixLivraison = new System.Windows.Forms.Label();
            this.TxtPrixLivraison = new Guna.UI2.WinForms.Guna2TextBox();
            this.Catégorie = new System.Windows.Forms.Label();
            this.CmbCategorie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LblPrixNormal = new System.Windows.Forms.Label();
            this.TxtPrixProduit = new Guna.UI2.WinForms.Guna2TextBox();
            this.ImageProduit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnModifier = new Guna.UI2.WinForms.Guna2Button();
            this.BtnParcourir = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomProduit = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduits)).BeginInit();
            this.GroupBoxCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.DGVProduits);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(13, 305);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(790, 182);
            this.guna2GroupBox1.TabIndex = 17;
            this.guna2GroupBox1.Text = "Liste des produits";
            // 
            // DGVProduits
            // 
            this.DGVProduits.AllowUserToAddRows = false;
            this.DGVProduits.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVProduits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVProduits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVProduits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVProduits.BackgroundColor = System.Drawing.Color.White;
            this.DGVProduits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVProduits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVProduits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVProduits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVProduits.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVProduits.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVProduits.EnableHeadersVisualStyles = false;
            this.DGVProduits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVProduits.Location = new System.Drawing.Point(17, 51);
            this.DGVProduits.Name = "DGVProduits";
            this.DGVProduits.ReadOnly = true;
            this.DGVProduits.RowHeadersVisible = false;
            this.DGVProduits.RowTemplate.Height = 30;
            this.DGVProduits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProduits.Size = new System.Drawing.Size(755, 115);
            this.DGVProduits.TabIndex = 1;
            this.DGVProduits.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVProduits.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVProduits.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVProduits.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVProduits.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVProduits.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVProduits.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVProduits.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVProduits.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DGVProduits.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVProduits.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVProduits.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVProduits.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVProduits.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVProduits.ThemeStyle.ReadOnly = true;
            this.DGVProduits.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVProduits.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVProduits.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVProduits.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVProduits.ThemeStyle.RowsStyle.Height = 30;
            this.DGVProduits.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVProduits.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVProduits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProduits_CellDoubleClick);
            // 
            // GroupBoxCategorie
            // 
            this.GroupBoxCategorie.BorderRadius = 10;
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessageImage);
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessageCodeBarre);
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessagePrixLivraison);
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessagePrixNormal);
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessageNom);
            this.GroupBoxCategorie.Controls.Add(this.LblCodeBarre);
            this.GroupBoxCategorie.Controls.Add(this.TxtCodeBarre);
            this.GroupBoxCategorie.Controls.Add(this.LblPrixLivraison);
            this.GroupBoxCategorie.Controls.Add(this.TxtPrixLivraison);
            this.GroupBoxCategorie.Controls.Add(this.Catégorie);
            this.GroupBoxCategorie.Controls.Add(this.CmbCategorie);
            this.GroupBoxCategorie.Controls.Add(this.LblPrixNormal);
            this.GroupBoxCategorie.Controls.Add(this.TxtPrixProduit);
            this.GroupBoxCategorie.Controls.Add(this.ImageProduit);
            this.GroupBoxCategorie.Controls.Add(this.BtnModifier);
            this.GroupBoxCategorie.Controls.Add(this.BtnParcourir);
            this.GroupBoxCategorie.Controls.Add(this.label2);
            this.GroupBoxCategorie.Controls.Add(this.BtnSupprimer);
            this.GroupBoxCategorie.Controls.Add(this.BtnAjouter);
            this.GroupBoxCategorie.Controls.Add(this.label1);
            this.GroupBoxCategorie.Controls.Add(this.TxtNomProduit);
            this.GroupBoxCategorie.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBoxCategorie.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GroupBoxCategorie.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCategorie.Location = new System.Drawing.Point(13, 11);
            this.GroupBoxCategorie.Name = "GroupBoxCategorie";
            this.GroupBoxCategorie.ShadowDecoration.Parent = this.GroupBoxCategorie;
            this.GroupBoxCategorie.Size = new System.Drawing.Size(790, 285);
            this.GroupBoxCategorie.TabIndex = 16;
            this.GroupBoxCategorie.Text = "Informations de produit";
            // 
            // LblErrorMessageImage
            // 
            this.LblErrorMessageImage.AutoSize = true;
            this.LblErrorMessageImage.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessageImage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessageImage.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessageImage.Location = new System.Drawing.Point(288, 258);
            this.LblErrorMessageImage.Name = "LblErrorMessageImage";
            this.LblErrorMessageImage.Size = new System.Drawing.Size(159, 17);
            this.LblErrorMessageImage.TabIndex = 68;
            this.LblErrorMessageImage.Text = "Veuillez choisir l\'image !";
            this.LblErrorMessageImage.Visible = false;
            // 
            // LblErrorMessageCodeBarre
            // 
            this.LblErrorMessageCodeBarre.AutoSize = true;
            this.LblErrorMessageCodeBarre.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessageCodeBarre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessageCodeBarre.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessageCodeBarre.Location = new System.Drawing.Point(536, 112);
            this.LblErrorMessageCodeBarre.Name = "LblErrorMessageCodeBarre";
            this.LblErrorMessageCodeBarre.Size = new System.Drawing.Size(208, 17);
            this.LblErrorMessageCodeBarre.TabIndex = 67;
            this.LblErrorMessageCodeBarre.Text = "Veuillez entrer le code à barre !";
            this.LblErrorMessageCodeBarre.Visible = false;
            this.LblErrorMessageCodeBarre.Leave += new System.EventHandler(this.LblErrorMessageCodeBarre_Leave);
            // 
            // LblErrorMessagePrixLivraison
            // 
            this.LblErrorMessagePrixLivraison.AutoSize = true;
            this.LblErrorMessagePrixLivraison.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessagePrixLivraison.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessagePrixLivraison.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessagePrixLivraison.Location = new System.Drawing.Point(292, 112);
            this.LblErrorMessagePrixLivraison.Name = "LblErrorMessagePrixLivraison";
            this.LblErrorMessagePrixLivraison.Size = new System.Drawing.Size(201, 17);
            this.LblErrorMessagePrixLivraison.TabIndex = 66;
            this.LblErrorMessagePrixLivraison.Text = "Veuillez entrer le prix livraison !";
            this.LblErrorMessagePrixLivraison.Visible = false;
            // 
            // LblErrorMessagePrixNormal
            // 
            this.LblErrorMessagePrixNormal.AutoSize = true;
            this.LblErrorMessagePrixNormal.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessagePrixNormal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessagePrixNormal.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessagePrixNormal.Location = new System.Drawing.Point(48, 258);
            this.LblErrorMessagePrixNormal.Name = "LblErrorMessagePrixNormal";
            this.LblErrorMessagePrixNormal.Size = new System.Drawing.Size(195, 17);
            this.LblErrorMessagePrixNormal.TabIndex = 65;
            this.LblErrorMessagePrixNormal.Text = "Veuillez entrer le prix normal !";
            this.LblErrorMessagePrixNormal.Visible = false;
            // 
            // LblErrorMessageNom
            // 
            this.LblErrorMessageNom.AutoSize = true;
            this.LblErrorMessageNom.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessageNom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessageNom.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessageNom.Location = new System.Drawing.Point(48, 177);
            this.LblErrorMessageNom.Name = "LblErrorMessageNom";
            this.LblErrorMessageNom.Size = new System.Drawing.Size(153, 17);
            this.LblErrorMessageNom.TabIndex = 64;
            this.LblErrorMessageNom.Text = "Veuillez entrer le nom !";
            this.LblErrorMessageNom.Visible = false;
            // 
            // LblCodeBarre
            // 
            this.LblCodeBarre.AutoSize = true;
            this.LblCodeBarre.BackColor = System.Drawing.Color.Transparent;
            this.LblCodeBarre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblCodeBarre.ForeColor = System.Drawing.Color.Black;
            this.LblCodeBarre.Location = new System.Drawing.Point(536, 51);
            this.LblCodeBarre.Name = "LblCodeBarre";
            this.LblCodeBarre.Size = new System.Drawing.Size(96, 17);
            this.LblCodeBarre.TabIndex = 23;
            this.LblCodeBarre.Text = "Code à barre";
            // 
            // TxtCodeBarre
            // 
            this.TxtCodeBarre.BackColor = System.Drawing.Color.Transparent;
            this.TxtCodeBarre.BorderColor = System.Drawing.Color.Silver;
            this.TxtCodeBarre.BorderRadius = 10;
            this.TxtCodeBarre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCodeBarre.DefaultText = "";
            this.TxtCodeBarre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCodeBarre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCodeBarre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodeBarre.DisabledState.Parent = this.TxtCodeBarre;
            this.TxtCodeBarre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodeBarre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodeBarre.FocusedState.Parent = this.TxtCodeBarre;
            this.TxtCodeBarre.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.TxtCodeBarre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodeBarre.HoverState.Parent = this.TxtCodeBarre;
            this.TxtCodeBarre.Location = new System.Drawing.Point(532, 72);
            this.TxtCodeBarre.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtCodeBarre.Name = "TxtCodeBarre";
            this.TxtCodeBarre.PasswordChar = '\0';
            this.TxtCodeBarre.PlaceholderText = "";
            this.TxtCodeBarre.SelectedText = "";
            this.TxtCodeBarre.ShadowDecoration.Parent = this.TxtCodeBarre;
            this.TxtCodeBarre.Size = new System.Drawing.Size(215, 37);
            this.TxtCodeBarre.TabIndex = 3;
            this.TxtCodeBarre.TextChanged += new System.EventHandler(this.TxtCodeBarre_TextChanged);
            // 
            // LblPrixLivraison
            // 
            this.LblPrixLivraison.AutoSize = true;
            this.LblPrixLivraison.BackColor = System.Drawing.Color.Transparent;
            this.LblPrixLivraison.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblPrixLivraison.ForeColor = System.Drawing.Color.Black;
            this.LblPrixLivraison.Location = new System.Drawing.Point(292, 51);
            this.LblPrixLivraison.Name = "LblPrixLivraison";
            this.LblPrixLivraison.Size = new System.Drawing.Size(85, 17);
            this.LblPrixLivraison.TabIndex = 21;
            this.LblPrixLivraison.Text = "Prix livraison";
            // 
            // TxtPrixLivraison
            // 
            this.TxtPrixLivraison.BackColor = System.Drawing.Color.Transparent;
            this.TxtPrixLivraison.BorderColor = System.Drawing.Color.Silver;
            this.TxtPrixLivraison.BorderRadius = 10;
            this.TxtPrixLivraison.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPrixLivraison.DefaultText = "";
            this.TxtPrixLivraison.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPrixLivraison.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPrixLivraison.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrixLivraison.DisabledState.Parent = this.TxtPrixLivraison;
            this.TxtPrixLivraison.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrixLivraison.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrixLivraison.FocusedState.Parent = this.TxtPrixLivraison;
            this.TxtPrixLivraison.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.TxtPrixLivraison.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrixLivraison.HoverState.Parent = this.TxtPrixLivraison;
            this.TxtPrixLivraison.Location = new System.Drawing.Point(288, 72);
            this.TxtPrixLivraison.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtPrixLivraison.Name = "TxtPrixLivraison";
            this.TxtPrixLivraison.PasswordChar = '\0';
            this.TxtPrixLivraison.PlaceholderText = "";
            this.TxtPrixLivraison.SelectedText = "";
            this.TxtPrixLivraison.ShadowDecoration.Parent = this.TxtPrixLivraison;
            this.TxtPrixLivraison.Size = new System.Drawing.Size(215, 37);
            this.TxtPrixLivraison.TabIndex = 2;
            this.TxtPrixLivraison.TextChanged += new System.EventHandler(this.TxtPrixLivraison_TextChanged);
            this.TxtPrixLivraison.Leave += new System.EventHandler(this.TxtPrixLivraison_Leave);
            // 
            // Catégorie
            // 
            this.Catégorie.AutoSize = true;
            this.Catégorie.BackColor = System.Drawing.Color.Transparent;
            this.Catégorie.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Catégorie.ForeColor = System.Drawing.Color.Black;
            this.Catégorie.Location = new System.Drawing.Point(48, 51);
            this.Catégorie.Name = "Catégorie";
            this.Catégorie.Size = new System.Drawing.Size(74, 17);
            this.Catégorie.TabIndex = 19;
            this.Catégorie.Text = "Catégorie";
            // 
            // CmbCategorie
            // 
            this.CmbCategorie.BackColor = System.Drawing.Color.Transparent;
            this.CmbCategorie.BorderRadius = 10;
            this.CmbCategorie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategorie.FocusedColor = System.Drawing.Color.Empty;
            this.CmbCategorie.FocusedState.Parent = this.CmbCategorie;
            this.CmbCategorie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbCategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbCategorie.FormattingEnabled = true;
            this.CmbCategorie.HoverState.Parent = this.CmbCategorie;
            this.CmbCategorie.ItemHeight = 30;
            this.CmbCategorie.ItemsAppearance.Parent = this.CmbCategorie;
            this.CmbCategorie.Location = new System.Drawing.Point(44, 72);
            this.CmbCategorie.Name = "CmbCategorie";
            this.CmbCategorie.ShadowDecoration.Parent = this.CmbCategorie;
            this.CmbCategorie.Size = new System.Drawing.Size(215, 36);
            this.CmbCategorie.TabIndex = 18;
            // 
            // LblPrixNormal
            // 
            this.LblPrixNormal.AutoSize = true;
            this.LblPrixNormal.BackColor = System.Drawing.Color.Transparent;
            this.LblPrixNormal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblPrixNormal.ForeColor = System.Drawing.Color.Black;
            this.LblPrixNormal.Location = new System.Drawing.Point(48, 197);
            this.LblPrixNormal.Name = "LblPrixNormal";
            this.LblPrixNormal.Size = new System.Drawing.Size(79, 17);
            this.LblPrixNormal.TabIndex = 17;
            this.LblPrixNormal.Text = "Prix normal";
            // 
            // TxtPrixProduit
            // 
            this.TxtPrixProduit.BackColor = System.Drawing.Color.Transparent;
            this.TxtPrixProduit.BorderColor = System.Drawing.Color.Silver;
            this.TxtPrixProduit.BorderRadius = 10;
            this.TxtPrixProduit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPrixProduit.DefaultText = "";
            this.TxtPrixProduit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPrixProduit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPrixProduit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrixProduit.DisabledState.Parent = this.TxtPrixProduit;
            this.TxtPrixProduit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrixProduit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrixProduit.FocusedState.Parent = this.TxtPrixProduit;
            this.TxtPrixProduit.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.TxtPrixProduit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrixProduit.HoverState.Parent = this.TxtPrixProduit;
            this.TxtPrixProduit.Location = new System.Drawing.Point(44, 218);
            this.TxtPrixProduit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtPrixProduit.Name = "TxtPrixProduit";
            this.TxtPrixProduit.PasswordChar = '\0';
            this.TxtPrixProduit.PlaceholderText = "";
            this.TxtPrixProduit.SelectedText = "";
            this.TxtPrixProduit.ShadowDecoration.Parent = this.TxtPrixProduit;
            this.TxtPrixProduit.Size = new System.Drawing.Size(215, 37);
            this.TxtPrixProduit.TabIndex = 1;
            this.TxtPrixProduit.TextChanged += new System.EventHandler(this.TxtPrixProduit_TextChanged);
            this.TxtPrixProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrixProduit_KeyPress);
            this.TxtPrixProduit.Leave += new System.EventHandler(this.TxtPrixProduit_Leave);
            // 
            // ImageProduit
            // 
            this.ImageProduit.Location = new System.Drawing.Point(288, 157);
            this.ImageProduit.Name = "ImageProduit";
            this.ImageProduit.ShadowDecoration.Parent = this.ImageProduit;
            this.ImageProduit.Size = new System.Drawing.Size(153, 98);
            this.ImageProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageProduit.TabIndex = 15;
            this.ImageProduit.TabStop = false;
            // 
            // BtnModifier
            // 
            this.BtnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModifier.BackColor = System.Drawing.Color.Transparent;
            this.BtnModifier.BorderRadius = 10;
            this.BtnModifier.CheckedState.Parent = this.BtnModifier;
            this.BtnModifier.CustomImages.Parent = this.BtnModifier;
            this.BtnModifier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.BtnModifier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.ForeColor = System.Drawing.Color.White;
            this.BtnModifier.HoverState.Parent = this.BtnModifier;
            this.BtnModifier.Image = ((System.Drawing.Image)(resources.GetObject("BtnModifier.Image")));
            this.BtnModifier.ImageOffset = new System.Drawing.Point(-2, 0);
            this.BtnModifier.ImageSize = new System.Drawing.Size(20, 18);
            this.BtnModifier.Location = new System.Drawing.Point(576, 183);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.ShadowDecoration.Parent = this.BtnModifier;
            this.BtnModifier.Size = new System.Drawing.Size(136, 40);
            this.BtnModifier.TabIndex = 14;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.TextOffset = new System.Drawing.Point(1, 0);
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnParcourir
            // 
            this.BtnParcourir.BackColor = System.Drawing.Color.Transparent;
            this.BtnParcourir.BorderColor = System.Drawing.Color.Silver;
            this.BtnParcourir.BorderRadius = 5;
            this.BtnParcourir.BorderThickness = 1;
            this.BtnParcourir.CheckedState.Parent = this.BtnParcourir;
            this.BtnParcourir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnParcourir.CustomImages.Parent = this.BtnParcourir;
            this.BtnParcourir.FillColor = System.Drawing.Color.Transparent;
            this.BtnParcourir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnParcourir.ForeColor = System.Drawing.Color.Black;
            this.BtnParcourir.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnParcourir.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("BtnParcourir.HoverState.Image")));
            this.BtnParcourir.HoverState.Parent = this.BtnParcourir;
            this.BtnParcourir.Image = ((System.Drawing.Image)(resources.GetObject("BtnParcourir.Image")));
            this.BtnParcourir.ImageOffset = new System.Drawing.Point(13, -8);
            this.BtnParcourir.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnParcourir.Location = new System.Drawing.Point(462, 180);
            this.BtnParcourir.Name = "BtnParcourir";
            this.BtnParcourir.ShadowDecoration.Parent = this.BtnParcourir;
            this.BtnParcourir.Size = new System.Drawing.Size(66, 52);
            this.BtnParcourir.TabIndex = 13;
            this.BtnParcourir.Text = "Parcourir";
            this.BtnParcourir.TextOffset = new System.Drawing.Point(-7, 15);
            this.BtnParcourir.Click += new System.EventHandler(this.BtnParcourir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(292, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Image";
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.BtnSupprimer.BorderRadius = 10;
            this.BtnSupprimer.CheckedState.Parent = this.BtnSupprimer;
            this.BtnSupprimer.CustomImages.Parent = this.BtnSupprimer;
            this.BtnSupprimer.FillColor = System.Drawing.Color.Crimson;
            this.BtnSupprimer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.Color.White;
            this.BtnSupprimer.HoverState.Parent = this.BtnSupprimer;
            this.BtnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("BtnSupprimer.Image")));
            this.BtnSupprimer.ImageOffset = new System.Drawing.Point(-2, 0);
            this.BtnSupprimer.ImageSize = new System.Drawing.Size(21, 20);
            this.BtnSupprimer.Location = new System.Drawing.Point(576, 229);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.ShadowDecoration.Parent = this.BtnSupprimer;
            this.BtnSupprimer.Size = new System.Drawing.Size(136, 40);
            this.BtnSupprimer.TabIndex = 9;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.TextOffset = new System.Drawing.Point(1, 0);
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.BtnAjouter.BorderRadius = 10;
            this.BtnAjouter.CheckedState.Parent = this.BtnAjouter;
            this.BtnAjouter.CustomImages.Parent = this.BtnAjouter;
            this.BtnAjouter.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAjouter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.ForeColor = System.Drawing.Color.White;
            this.BtnAjouter.HoverState.Parent = this.BtnAjouter;
            this.BtnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjouter.Image")));
            this.BtnAjouter.ImageOffset = new System.Drawing.Point(-2, 0);
            this.BtnAjouter.ImageSize = new System.Drawing.Size(21, 21);
            this.BtnAjouter.Location = new System.Drawing.Point(576, 137);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.ShadowDecoration.Parent = this.BtnAjouter;
            this.BtnAjouter.Size = new System.Drawing.Size(136, 40);
            this.BtnAjouter.TabIndex = 8;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.TextOffset = new System.Drawing.Point(1, 0);
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom";
            // 
            // TxtNomProduit
            // 
            this.TxtNomProduit.BackColor = System.Drawing.Color.Transparent;
            this.TxtNomProduit.BorderColor = System.Drawing.Color.Silver;
            this.TxtNomProduit.BorderRadius = 10;
            this.TxtNomProduit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNomProduit.DefaultText = "";
            this.TxtNomProduit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNomProduit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNomProduit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNomProduit.DisabledState.Parent = this.TxtNomProduit;
            this.TxtNomProduit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNomProduit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNomProduit.FocusedState.Parent = this.TxtNomProduit;
            this.TxtNomProduit.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.TxtNomProduit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNomProduit.HoverState.Parent = this.TxtNomProduit;
            this.TxtNomProduit.Location = new System.Drawing.Point(44, 137);
            this.TxtNomProduit.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNomProduit.Name = "TxtNomProduit";
            this.TxtNomProduit.PasswordChar = '\0';
            this.TxtNomProduit.PlaceholderText = "";
            this.TxtNomProduit.SelectedText = "";
            this.TxtNomProduit.ShadowDecoration.Parent = this.TxtNomProduit;
            this.TxtNomProduit.Size = new System.Drawing.Size(215, 37);
            this.TxtNomProduit.TabIndex = 0;
            this.TxtNomProduit.TextChanged += new System.EventHandler(this.TxtNomProduit_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 1);
            this.panel2.TabIndex = 18;
            // 
            // GestionProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.GroupBoxCategorie);
            this.Name = "GestionProduits";
            this.Size = new System.Drawing.Size(817, 500);
            this.Load += new System.EventHandler(this.GestionProduits_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduits)).EndInit();
            this.GroupBoxCategorie.ResumeLayout(false);
            this.GroupBoxCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DGVProduits;
        private Guna.UI2.WinForms.Guna2PictureBox ImageProduit;
        private Guna.UI2.WinForms.Guna2Button BtnModifier;
        private Guna.UI2.WinForms.Guna2Button BtnParcourir;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button BtnSupprimer;
        private Guna.UI2.WinForms.Guna2Button BtnAjouter;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtNomProduit;
        private System.Windows.Forms.Label LblPrixNormal;
        private Guna.UI2.WinForms.Guna2TextBox TxtPrixProduit;
        private System.Windows.Forms.Label Catégorie;
        private Guna.UI2.WinForms.Guna2ComboBox CmbCategorie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblPrixLivraison;
        private Guna.UI2.WinForms.Guna2TextBox TxtPrixLivraison;
        public Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        public Guna.UI2.WinForms.Guna2GroupBox GroupBoxCategorie;
        private System.Windows.Forms.Label LblCodeBarre;
        private Guna.UI2.WinForms.Guna2TextBox TxtCodeBarre;
        private System.Windows.Forms.Label LblErrorMessageCodeBarre;
        private System.Windows.Forms.Label LblErrorMessagePrixLivraison;
        private System.Windows.Forms.Label LblErrorMessagePrixNormal;
        private System.Windows.Forms.Label LblErrorMessageNom;
        private System.Windows.Forms.Label LblErrorMessageImage;
    }
}

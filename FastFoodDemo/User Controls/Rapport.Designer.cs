
namespace FastFoodDemo.User_Controls
{
    partial class Rapport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rapport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBoxCategorie = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.BtnWord = new Guna.UI2.WinForms.Guna2Button();
            this.BtnExporter = new Guna.UI2.WinForms.Guna2Button();
            this.LblProduit = new System.Windows.Forms.Label();
            this.CmbProduits = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbCategories = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblMntTotal = new System.Windows.Forms.Label();
            this.LblQteTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVListeVentes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Catégorie = new System.Windows.Forms.Label();
            this.CmbUtilisateur = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DPDateDebut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DPDateFin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnImprimer = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRechercher = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GroupBoxCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeVentes)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxCategorie
            // 
            this.GroupBoxCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBoxCategorie.BorderRadius = 10;
            this.GroupBoxCategorie.Controls.Add(this.pictureBoxLoading);
            this.GroupBoxCategorie.Controls.Add(this.BtnWord);
            this.GroupBoxCategorie.Controls.Add(this.BtnExporter);
            this.GroupBoxCategorie.Controls.Add(this.LblProduit);
            this.GroupBoxCategorie.Controls.Add(this.CmbProduits);
            this.GroupBoxCategorie.Controls.Add(this.label8);
            this.GroupBoxCategorie.Controls.Add(this.CmbCategories);
            this.GroupBoxCategorie.Controls.Add(this.label7);
            this.GroupBoxCategorie.Controls.Add(this.label6);
            this.GroupBoxCategorie.Controls.Add(this.LblMntTotal);
            this.GroupBoxCategorie.Controls.Add(this.LblQteTotal);
            this.GroupBoxCategorie.Controls.Add(this.label5);
            this.GroupBoxCategorie.Controls.Add(this.label3);
            this.GroupBoxCategorie.Controls.Add(this.label1);
            this.GroupBoxCategorie.Controls.Add(this.DGVListeVentes);
            this.GroupBoxCategorie.Controls.Add(this.Catégorie);
            this.GroupBoxCategorie.Controls.Add(this.CmbUtilisateur);
            this.GroupBoxCategorie.Controls.Add(this.label2);
            this.GroupBoxCategorie.Controls.Add(this.DPDateDebut);
            this.GroupBoxCategorie.Controls.Add(this.label4);
            this.GroupBoxCategorie.Controls.Add(this.DPDateFin);
            this.GroupBoxCategorie.Controls.Add(this.BtnImprimer);
            this.GroupBoxCategorie.Controls.Add(this.BtnRechercher);
            this.GroupBoxCategorie.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBoxCategorie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCategorie.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCategorie.Location = new System.Drawing.Point(13, 7);
            this.GroupBoxCategorie.Name = "GroupBoxCategorie";
            this.GroupBoxCategorie.ShadowDecoration.Parent = this.GroupBoxCategorie;
            this.GroupBoxCategorie.Size = new System.Drawing.Size(790, 432);
            this.GroupBoxCategorie.TabIndex = 17;
            this.GroupBoxCategorie.Text = "Rapport des ventes";
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLoading.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLoading.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pictureBoxLoading.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoading.Image")));
            this.pictureBoxLoading.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoading.InitialImage")));
            this.pictureBoxLoading.Location = new System.Drawing.Point(317, 136);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(156, 163);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoading.TabIndex = 39;
            this.pictureBoxLoading.TabStop = false;
            this.pictureBoxLoading.Visible = false;
            // 
            // BtnWord
            // 
            this.BtnWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnWord.BackColor = System.Drawing.Color.Transparent;
            this.BtnWord.BorderRadius = 10;
            this.BtnWord.CheckedState.Parent = this.BtnWord;
            this.BtnWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnWord.CustomImages.Parent = this.BtnWord;
            this.BtnWord.FillColor = System.Drawing.Color.RoyalBlue;
            this.BtnWord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWord.ForeColor = System.Drawing.Color.White;
            this.BtnWord.HoverState.Parent = this.BtnWord;
            this.BtnWord.Image = ((System.Drawing.Image)(resources.GetObject("BtnWord.Image")));
            this.BtnWord.ImageSize = new System.Drawing.Size(22, 22);
            this.BtnWord.Location = new System.Drawing.Point(325, 373);
            this.BtnWord.Name = "BtnWord";
            this.BtnWord.ShadowDecoration.Parent = this.BtnWord;
            this.BtnWord.Size = new System.Drawing.Size(143, 40);
            this.BtnWord.TabIndex = 38;
            this.BtnWord.Text = "Exporter";
            this.BtnWord.Click += new System.EventHandler(this.BtnWord_Click);
            // 
            // BtnExporter
            // 
            this.BtnExporter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnExporter.BackColor = System.Drawing.Color.Transparent;
            this.BtnExporter.BorderRadius = 10;
            this.BtnExporter.CheckedState.Parent = this.BtnExporter;
            this.BtnExporter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExporter.CustomImages.Parent = this.BtnExporter;
            this.BtnExporter.FillColor = System.Drawing.Color.SeaGreen;
            this.BtnExporter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExporter.ForeColor = System.Drawing.Color.White;
            this.BtnExporter.HoverState.Parent = this.BtnExporter;
            this.BtnExporter.Image = ((System.Drawing.Image)(resources.GetObject("BtnExporter.Image")));
            this.BtnExporter.ImageSize = new System.Drawing.Size(22, 22);
            this.BtnExporter.Location = new System.Drawing.Point(179, 373);
            this.BtnExporter.Name = "BtnExporter";
            this.BtnExporter.ShadowDecoration.Parent = this.BtnExporter;
            this.BtnExporter.Size = new System.Drawing.Size(143, 40);
            this.BtnExporter.TabIndex = 37;
            this.BtnExporter.Text = "Exporter";
            this.BtnExporter.Click += new System.EventHandler(this.BtnExporter_Click);
            // 
            // LblProduit
            // 
            this.LblProduit.AutoSize = true;
            this.LblProduit.BackColor = System.Drawing.Color.Transparent;
            this.LblProduit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblProduit.ForeColor = System.Drawing.Color.Black;
            this.LblProduit.Location = new System.Drawing.Point(513, 51);
            this.LblProduit.Name = "LblProduit";
            this.LblProduit.Size = new System.Drawing.Size(54, 17);
            this.LblProduit.TabIndex = 36;
            this.LblProduit.Text = "Produit";
            // 
            // CmbProduits
            // 
            this.CmbProduits.BackColor = System.Drawing.Color.Transparent;
            this.CmbProduits.BorderRadius = 10;
            this.CmbProduits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbProduits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProduits.FocusedColor = System.Drawing.Color.Empty;
            this.CmbProduits.FocusedState.Parent = this.CmbProduits;
            this.CmbProduits.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbProduits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbProduits.FormattingEnabled = true;
            this.CmbProduits.HoverState.Parent = this.CmbProduits;
            this.CmbProduits.ItemHeight = 30;
            this.CmbProduits.ItemsAppearance.Parent = this.CmbProduits;
            this.CmbProduits.Location = new System.Drawing.Point(505, 73);
            this.CmbProduits.Name = "CmbProduits";
            this.CmbProduits.ShadowDecoration.Parent = this.CmbProduits;
            this.CmbProduits.Size = new System.Drawing.Size(215, 36);
            this.CmbProduits.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(275, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Catégorie";
            // 
            // CmbCategories
            // 
            this.CmbCategories.BackColor = System.Drawing.Color.Transparent;
            this.CmbCategories.BorderRadius = 10;
            this.CmbCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategories.FocusedColor = System.Drawing.Color.Empty;
            this.CmbCategories.FocusedState.Parent = this.CmbCategories;
            this.CmbCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbCategories.FormattingEnabled = true;
            this.CmbCategories.HoverState.Parent = this.CmbCategories;
            this.CmbCategories.ItemHeight = 30;
            this.CmbCategories.ItemsAppearance.Parent = this.CmbCategories;
            this.CmbCategories.Location = new System.Drawing.Point(269, 73);
            this.CmbCategories.Name = "CmbCategories";
            this.CmbCategories.ShadowDecoration.Parent = this.CmbCategories;
            this.CmbCategories.Size = new System.Drawing.Size(215, 36);
            this.CmbCategories.TabIndex = 33;
            this.CmbCategories.SelectedIndexChanged += new System.EventHandler(this.CmbCategories_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(714, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Dhs";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(697, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Piéces";
            // 
            // LblMntTotal
            // 
            this.LblMntTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMntTotal.AutoSize = true;
            this.LblMntTotal.BackColor = System.Drawing.Color.Transparent;
            this.LblMntTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMntTotal.ForeColor = System.Drawing.Color.SeaGreen;
            this.LblMntTotal.Location = new System.Drawing.Point(592, 403);
            this.LblMntTotal.Name = "LblMntTotal";
            this.LblMntTotal.Size = new System.Drawing.Size(37, 20);
            this.LblMntTotal.TabIndex = 30;
            this.LblMntTotal.Text = "0.00";
            // 
            // LblQteTotal
            // 
            this.LblQteTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblQteTotal.AutoSize = true;
            this.LblQteTotal.BackColor = System.Drawing.Color.Transparent;
            this.LblQteTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQteTotal.ForeColor = System.Drawing.Color.Brown;
            this.LblQteTotal.Location = new System.Drawing.Point(592, 379);
            this.LblQteTotal.Name = "LblQteTotal";
            this.LblQteTotal.Size = new System.Drawing.Size(37, 20);
            this.LblQteTotal.TabIndex = 29;
            this.LblQteTotal.Text = "0.00";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(478, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Quantité total";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(478, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Montant total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Liste des ventes";
            // 
            // DGVListeVentes
            // 
            this.DGVListeVentes.AllowUserToAddRows = false;
            this.DGVListeVentes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DGVListeVentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVListeVentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVListeVentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVListeVentes.BackgroundColor = System.Drawing.Color.White;
            this.DGVListeVentes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVListeVentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVListeVentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListeVentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVListeVentes.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListeVentes.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVListeVentes.EnableHeadersVisualStyles = false;
            this.DGVListeVentes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeVentes.Location = new System.Drawing.Point(33, 230);
            this.DGVListeVentes.Name = "DGVListeVentes";
            this.DGVListeVentes.ReadOnly = true;
            this.DGVListeVentes.RowHeadersVisible = false;
            this.DGVListeVentes.RowTemplate.Height = 30;
            this.DGVListeVentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListeVentes.Size = new System.Drawing.Size(724, 137);
            this.DGVListeVentes.TabIndex = 25;
            this.DGVListeVentes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVListeVentes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeVentes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVListeVentes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVListeVentes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVListeVentes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVListeVentes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeVentes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeVentes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DGVListeVentes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVListeVentes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListeVentes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVListeVentes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVListeVentes.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVListeVentes.ThemeStyle.ReadOnly = true;
            this.DGVListeVentes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeVentes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVListeVentes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListeVentes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVListeVentes.ThemeStyle.RowsStyle.Height = 30;
            this.DGVListeVentes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeVentes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Catégorie
            // 
            this.Catégorie.AutoSize = true;
            this.Catégorie.BackColor = System.Drawing.Color.Transparent;
            this.Catégorie.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Catégorie.ForeColor = System.Drawing.Color.Black;
            this.Catégorie.Location = new System.Drawing.Point(275, 121);
            this.Catégorie.Name = "Catégorie";
            this.Catégorie.Size = new System.Drawing.Size(66, 17);
            this.Catégorie.TabIndex = 24;
            this.Catégorie.Text = "Utlisateur";
            // 
            // CmbUtilisateur
            // 
            this.CmbUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.CmbUtilisateur.BorderRadius = 10;
            this.CmbUtilisateur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbUtilisateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUtilisateur.FocusedColor = System.Drawing.Color.Empty;
            this.CmbUtilisateur.FocusedState.Parent = this.CmbUtilisateur;
            this.CmbUtilisateur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbUtilisateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbUtilisateur.FormattingEnabled = true;
            this.CmbUtilisateur.HoverState.Parent = this.CmbUtilisateur;
            this.CmbUtilisateur.ItemHeight = 30;
            this.CmbUtilisateur.ItemsAppearance.Parent = this.CmbUtilisateur;
            this.CmbUtilisateur.Location = new System.Drawing.Point(269, 143);
            this.CmbUtilisateur.Name = "CmbUtilisateur";
            this.CmbUtilisateur.ShadowDecoration.Parent = this.CmbUtilisateur;
            this.CmbUtilisateur.Size = new System.Drawing.Size(215, 36);
            this.CmbUtilisateur.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date début";
            // 
            // DPDateDebut
            // 
            this.DPDateDebut.BackColor = System.Drawing.Color.Transparent;
            this.DPDateDebut.BorderRadius = 10;
            this.DPDateDebut.CheckedState.Parent = this.DPDateDebut;
            this.DPDateDebut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DPDateDebut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPDateDebut.HoverState.Parent = this.DPDateDebut;
            this.DPDateDebut.Location = new System.Drawing.Point(33, 73);
            this.DPDateDebut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DPDateDebut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DPDateDebut.Name = "DPDateDebut";
            this.DPDateDebut.ShadowDecoration.Parent = this.DPDateDebut;
            this.DPDateDebut.Size = new System.Drawing.Size(215, 37);
            this.DPDateDebut.TabIndex = 21;
            this.DPDateDebut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DPDateDebut.Value = new System.DateTime(2022, 10, 11, 22, 8, 9, 320);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date fin";
            // 
            // DPDateFin
            // 
            this.DPDateFin.BackColor = System.Drawing.Color.Transparent;
            this.DPDateFin.BorderRadius = 10;
            this.DPDateFin.CheckedState.Parent = this.DPDateFin;
            this.DPDateFin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DPDateFin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPDateFin.HoverState.Parent = this.DPDateFin;
            this.DPDateFin.Location = new System.Drawing.Point(33, 143);
            this.DPDateFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DPDateFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DPDateFin.Name = "DPDateFin";
            this.DPDateFin.ShadowDecoration.Parent = this.DPDateFin;
            this.DPDateFin.Size = new System.Drawing.Size(215, 37);
            this.DPDateFin.TabIndex = 19;
            this.DPDateFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DPDateFin.Value = new System.DateTime(2022, 10, 11, 22, 8, 9, 320);
            // 
            // BtnImprimer
            // 
            this.BtnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnImprimer.BackColor = System.Drawing.Color.Transparent;
            this.BtnImprimer.BorderRadius = 10;
            this.BtnImprimer.CheckedState.Parent = this.BtnImprimer;
            this.BtnImprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprimer.CustomImages.Parent = this.BtnImprimer;
            this.BtnImprimer.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnImprimer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimer.ForeColor = System.Drawing.Color.White;
            this.BtnImprimer.HoverState.Parent = this.BtnImprimer;
            this.BtnImprimer.Image = ((System.Drawing.Image)(resources.GetObject("BtnImprimer.Image")));
            this.BtnImprimer.Location = new System.Drawing.Point(33, 373);
            this.BtnImprimer.Name = "BtnImprimer";
            this.BtnImprimer.ShadowDecoration.Parent = this.BtnImprimer;
            this.BtnImprimer.Size = new System.Drawing.Size(143, 40);
            this.BtnImprimer.TabIndex = 14;
            this.BtnImprimer.Text = "Imprimer";
            this.BtnImprimer.TextOffset = new System.Drawing.Point(2, 0);
            this.BtnImprimer.Click += new System.EventHandler(this.BtnImprimer_Click);
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRechercher.BackColor = System.Drawing.Color.Transparent;
            this.BtnRechercher.BorderRadius = 10;
            this.BtnRechercher.CheckedState.Parent = this.BtnRechercher;
            this.BtnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRechercher.CustomImages.Parent = this.BtnRechercher;
            this.BtnRechercher.FillColor = System.Drawing.Color.SteelBlue;
            this.BtnRechercher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechercher.ForeColor = System.Drawing.Color.White;
            this.BtnRechercher.HoverState.Parent = this.BtnRechercher;
            this.BtnRechercher.Image = ((System.Drawing.Image)(resources.GetObject("BtnRechercher.Image")));
            this.BtnRechercher.ImageSize = new System.Drawing.Size(21, 21);
            this.BtnRechercher.Location = new System.Drawing.Point(614, 184);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.ShadowDecoration.Parent = this.BtnRechercher;
            this.BtnRechercher.Size = new System.Drawing.Size(143, 40);
            this.BtnRechercher.TabIndex = 8;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 1);
            this.panel2.TabIndex = 19;
            // 
            // Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GroupBoxCategorie);
            this.Name = "Rapport";
            this.Size = new System.Drawing.Size(817, 447);
            this.Load += new System.EventHandler(this.Rapport_Load);
            this.GroupBoxCategorie.ResumeLayout(false);
            this.GroupBoxCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeVentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button BtnWord;
        private Guna.UI2.WinForms.Guna2Button BtnExporter;
        private System.Windows.Forms.Label LblProduit;
        private Guna.UI2.WinForms.Guna2ComboBox CmbProduits;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox CmbCategories;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblMntTotal;
        private System.Windows.Forms.Label LblQteTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DGVListeVentes;
        private System.Windows.Forms.Label Catégorie;
        private Guna.UI2.WinForms.Guna2ComboBox CmbUtilisateur;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DPDateDebut;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker DPDateFin;
        private Guna.UI2.WinForms.Guna2Button BtnImprimer;
        private Guna.UI2.WinForms.Guna2Button BtnRechercher;
        public Guna.UI2.WinForms.Guna2GroupBox GroupBoxCategorie;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
    }
}

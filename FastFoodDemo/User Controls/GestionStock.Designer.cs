
namespace FastFoodDemo.User_Controls
{
    partial class GestionStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionStock));
            this.CmbCategories = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DGVListeProduitsEnStock = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnReset = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtQuantiteDisponible = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtQuantiteAjouter = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEnregistrer = new Guna.UI2.WinForms.Guna2Button();
            this.GroupBoxCategorie = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeProduitsEnStock)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.GroupBoxCategorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbCategories
            // 
            this.CmbCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.CmbCategories.Location = new System.Drawing.Point(268, 66);
            this.CmbCategories.Name = "CmbCategories";
            this.CmbCategories.ShadowDecoration.Parent = this.CmbCategories;
            this.CmbCategories.Size = new System.Drawing.Size(225, 36);
            this.CmbCategories.TabIndex = 53;
            // 
            // DGVListeProduitsEnStock
            // 
            this.DGVListeProduitsEnStock.AllowUserToAddRows = false;
            this.DGVListeProduitsEnStock.AllowUserToDeleteRows = false;
            this.DGVListeProduitsEnStock.AllowUserToResizeColumns = false;
            this.DGVListeProduitsEnStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DGVListeProduitsEnStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVListeProduitsEnStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVListeProduitsEnStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVListeProduitsEnStock.BackgroundColor = System.Drawing.Color.White;
            this.DGVListeProduitsEnStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVListeProduitsEnStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVListeProduitsEnStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListeProduitsEnStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVListeProduitsEnStock.ColumnHeadersHeight = 35;
            this.DGVListeProduitsEnStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListeProduitsEnStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVListeProduitsEnStock.EnableHeadersVisualStyles = false;
            this.DGVListeProduitsEnStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeProduitsEnStock.Location = new System.Drawing.Point(285, 74);
            this.DGVListeProduitsEnStock.Name = "DGVListeProduitsEnStock";
            this.DGVListeProduitsEnStock.RowHeadersVisible = false;
            this.DGVListeProduitsEnStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVListeProduitsEnStock.RowTemplate.Height = 30;
            this.DGVListeProduitsEnStock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListeProduitsEnStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListeProduitsEnStock.Size = new System.Drawing.Size(531, 275);
            this.DGVListeProduitsEnStock.TabIndex = 57;
            this.DGVListeProduitsEnStock.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVListeProduitsEnStock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeProduitsEnStock.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVListeProduitsEnStock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVListeProduitsEnStock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVListeProduitsEnStock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVListeProduitsEnStock.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeProduitsEnStock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeProduitsEnStock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DGVListeProduitsEnStock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVListeProduitsEnStock.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListeProduitsEnStock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVListeProduitsEnStock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVListeProduitsEnStock.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVListeProduitsEnStock.ThemeStyle.ReadOnly = false;
            this.DGVListeProduitsEnStock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeProduitsEnStock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVListeProduitsEnStock.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListeProduitsEnStock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVListeProduitsEnStock.ThemeStyle.RowsStyle.Height = 30;
            this.DGVListeProduitsEnStock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeProduitsEnStock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVListeProduitsEnStock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListeProduitsEnStock_CellDoubleClick);
            this.DGVListeProduitsEnStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVListeProduitsEnStock_CellFormatting);
            this.DGVListeProduitsEnStock.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListeProduitsEnStock_CellValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(178, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Catégories";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.BtnReset);
            this.guna2GroupBox1.Controls.Add(this.BtnSupprimer);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.TxtQuantiteDisponible);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.TxtQuantiteAjouter);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.TxtNom);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.DGVListeProduitsEnStock);
            this.guna2GroupBox1.Controls.Add(this.BtnEnregistrer);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(14, 151);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(843, 398);
            this.guna2GroupBox1.TabIndex = 58;
            this.guna2GroupBox1.Text = "Ajouter la quantité";
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReset.BackColor = System.Drawing.Color.Transparent;
            this.BtnReset.BorderRadius = 10;
            this.BtnReset.CheckedState.Parent = this.BtnReset;
            this.BtnReset.CustomImages.Parent = this.BtnReset;
            this.BtnReset.FillColor = System.Drawing.Color.DimGray;
            this.BtnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.HoverState.Parent = this.BtnReset;
            this.BtnReset.Image = ((System.Drawing.Image)(resources.GetObject("BtnReset.Image")));
            this.BtnReset.ImageOffset = new System.Drawing.Point(-1, 0);
            this.BtnReset.Location = new System.Drawing.Point(528, 355);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.ShadowDecoration.Parent = this.BtnReset;
            this.BtnReset.Size = new System.Drawing.Size(141, 40);
            this.BtnReset.TabIndex = 66;
            this.BtnReset.Text = "Réinitialiser";
            this.BtnReset.TextOffset = new System.Drawing.Point(1, 0);
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.BtnSupprimer.BorderRadius = 10;
            this.BtnSupprimer.CheckedState.Parent = this.BtnSupprimer;
            this.BtnSupprimer.CustomImages.Parent = this.BtnSupprimer;
            this.BtnSupprimer.FillColor = System.Drawing.Color.Crimson;
            this.BtnSupprimer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.Color.White;
            this.BtnSupprimer.HoverState.Parent = this.BtnSupprimer;
            this.BtnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("BtnSupprimer.Image")));
            this.BtnSupprimer.ImageOffset = new System.Drawing.Point(-1, 0);
            this.BtnSupprimer.ImageSize = new System.Drawing.Size(21, 20);
            this.BtnSupprimer.Location = new System.Drawing.Point(675, 355);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.ShadowDecoration.Parent = this.BtnSupprimer;
            this.BtnSupprimer.Size = new System.Drawing.Size(141, 40);
            this.BtnSupprimer.TabIndex = 65;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.TextOffset = new System.Drawing.Point(1, 0);
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Quantité disponible";
            // 
            // TxtQuantiteDisponible
            // 
            this.TxtQuantiteDisponible.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtQuantiteDisponible.BackColor = System.Drawing.Color.Transparent;
            this.TxtQuantiteDisponible.BorderColor = System.Drawing.Color.Silver;
            this.TxtQuantiteDisponible.BorderRadius = 10;
            this.TxtQuantiteDisponible.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtQuantiteDisponible.DefaultText = "";
            this.TxtQuantiteDisponible.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtQuantiteDisponible.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtQuantiteDisponible.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtQuantiteDisponible.DisabledState.Parent = this.TxtQuantiteDisponible;
            this.TxtQuantiteDisponible.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtQuantiteDisponible.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtQuantiteDisponible.FocusedState.Parent = this.TxtQuantiteDisponible;
            this.TxtQuantiteDisponible.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.TxtQuantiteDisponible.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtQuantiteDisponible.HoverState.Parent = this.TxtQuantiteDisponible;
            this.TxtQuantiteDisponible.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtQuantiteDisponible.IconLeft")));
            this.TxtQuantiteDisponible.IconLeftSize = new System.Drawing.Size(21, 21);
            this.TxtQuantiteDisponible.Location = new System.Drawing.Point(27, 257);
            this.TxtQuantiteDisponible.Margin = new System.Windows.Forms.Padding(5);
            this.TxtQuantiteDisponible.Name = "TxtQuantiteDisponible";
            this.TxtQuantiteDisponible.PasswordChar = '\0';
            this.TxtQuantiteDisponible.PlaceholderText = "";
            this.TxtQuantiteDisponible.ReadOnly = true;
            this.TxtQuantiteDisponible.SelectedText = "";
            this.TxtQuantiteDisponible.ShadowDecoration.Parent = this.TxtQuantiteDisponible;
            this.TxtQuantiteDisponible.Size = new System.Drawing.Size(225, 36);
            this.TxtQuantiteDisponible.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Quantité à ajouter";
            // 
            // TxtQuantiteAjouter
            // 
            this.TxtQuantiteAjouter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtQuantiteAjouter.BackColor = System.Drawing.Color.Transparent;
            this.TxtQuantiteAjouter.BorderColor = System.Drawing.Color.Silver;
            this.TxtQuantiteAjouter.BorderRadius = 10;
            this.TxtQuantiteAjouter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtQuantiteAjouter.DefaultText = "";
            this.TxtQuantiteAjouter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtQuantiteAjouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtQuantiteAjouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtQuantiteAjouter.DisabledState.Parent = this.TxtQuantiteAjouter;
            this.TxtQuantiteAjouter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtQuantiteAjouter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtQuantiteAjouter.FocusedState.Parent = this.TxtQuantiteAjouter;
            this.TxtQuantiteAjouter.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.TxtQuantiteAjouter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtQuantiteAjouter.HoverState.Parent = this.TxtQuantiteAjouter;
            this.TxtQuantiteAjouter.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtQuantiteAjouter.IconLeft")));
            this.TxtQuantiteAjouter.IconLeftSize = new System.Drawing.Size(21, 21);
            this.TxtQuantiteAjouter.Location = new System.Drawing.Point(27, 190);
            this.TxtQuantiteAjouter.Margin = new System.Windows.Forms.Padding(5);
            this.TxtQuantiteAjouter.Name = "TxtQuantiteAjouter";
            this.TxtQuantiteAjouter.PasswordChar = '\0';
            this.TxtQuantiteAjouter.PlaceholderText = "";
            this.TxtQuantiteAjouter.SelectedText = "";
            this.TxtQuantiteAjouter.ShadowDecoration.Parent = this.TxtQuantiteAjouter;
            this.TxtQuantiteAjouter.Size = new System.Drawing.Size(225, 36);
            this.TxtQuantiteAjouter.TabIndex = 61;
            this.TxtQuantiteAjouter.TextChanged += new System.EventHandler(this.TxtQuantiteAjouter_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Produit";
            // 
            // TxtNom
            // 
            this.TxtNom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtNom.BackColor = System.Drawing.Color.Transparent;
            this.TxtNom.BorderColor = System.Drawing.Color.Silver;
            this.TxtNom.BorderRadius = 10;
            this.TxtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNom.DefaultText = "";
            this.TxtNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNom.DisabledState.Parent = this.TxtNom;
            this.TxtNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNom.FocusedState.Parent = this.TxtNom;
            this.TxtNom.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.TxtNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNom.HoverState.Parent = this.TxtNom;
            this.TxtNom.IconLeft = ((System.Drawing.Image)(resources.GetObject("TxtNom.IconLeft")));
            this.TxtNom.IconLeftSize = new System.Drawing.Size(21, 21);
            this.TxtNom.Location = new System.Drawing.Point(27, 123);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.PasswordChar = '\0';
            this.TxtNom.PlaceholderText = "";
            this.TxtNom.ReadOnly = true;
            this.TxtNom.SelectedText = "";
            this.TxtNom.ShadowDecoration.Parent = this.TxtNom;
            this.TxtNom.Size = new System.Drawing.Size(225, 36);
            this.TxtNom.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.6F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(290, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 18);
            this.label5.TabIndex = 58;
            this.label5.Text = "Liste des produits en stock";
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnEnregistrer.BackColor = System.Drawing.Color.Transparent;
            this.BtnEnregistrer.BorderRadius = 10;
            this.BtnEnregistrer.CheckedState.Parent = this.BtnEnregistrer;
            this.BtnEnregistrer.CustomImages.Parent = this.BtnEnregistrer;
            this.BtnEnregistrer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.BtnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.BtnEnregistrer.HoverState.Parent = this.BtnEnregistrer;
            this.BtnEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("BtnEnregistrer.Image")));
            this.BtnEnregistrer.ImageOffset = new System.Drawing.Point(-1, 0);
            this.BtnEnregistrer.ImageSize = new System.Drawing.Size(22, 22);
            this.BtnEnregistrer.Location = new System.Drawing.Point(69, 309);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.ShadowDecoration.Parent = this.BtnEnregistrer;
            this.BtnEnregistrer.Size = new System.Drawing.Size(141, 40);
            this.BtnEnregistrer.TabIndex = 55;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.TextOffset = new System.Drawing.Point(1, 0);
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // GroupBoxCategorie
            // 
            this.GroupBoxCategorie.BorderRadius = 10;
            this.GroupBoxCategorie.Controls.Add(this.BtnAjouter);
            this.GroupBoxCategorie.Controls.Add(this.label4);
            this.GroupBoxCategorie.Controls.Add(this.CmbCategories);
            this.GroupBoxCategorie.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBoxCategorie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCategorie.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCategorie.Location = new System.Drawing.Point(14, 9);
            this.GroupBoxCategorie.Name = "GroupBoxCategorie";
            this.GroupBoxCategorie.ShadowDecoration.Parent = this.GroupBoxCategorie;
            this.GroupBoxCategorie.Size = new System.Drawing.Size(843, 133);
            this.GroupBoxCategorie.TabIndex = 56;
            this.GroupBoxCategorie.Text = "Gestion des catégorie";
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.BtnAjouter.BorderRadius = 10;
            this.BtnAjouter.CheckedState.Parent = this.BtnAjouter;
            this.BtnAjouter.CustomImages.Parent = this.BtnAjouter;
            this.BtnAjouter.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAjouter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.ForeColor = System.Drawing.Color.White;
            this.BtnAjouter.HoverState.Parent = this.BtnAjouter;
            this.BtnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjouter.Image")));
            this.BtnAjouter.ImageOffset = new System.Drawing.Point(-1, 0);
            this.BtnAjouter.ImageSize = new System.Drawing.Size(21, 21);
            this.BtnAjouter.Location = new System.Drawing.Point(524, 64);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.ShadowDecoration.Parent = this.BtnAjouter;
            this.BtnAjouter.Size = new System.Drawing.Size(141, 40);
            this.BtnAjouter.TabIndex = 61;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.TextOffset = new System.Drawing.Point(1, 0);
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 1);
            this.panel2.TabIndex = 57;
            // 
            // GestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.GroupBoxCategorie);
            this.Controls.Add(this.panel2);
            this.Name = "GestionStock";
            this.Size = new System.Drawing.Size(870, 560);
            this.Load += new System.EventHandler(this.GestionStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeProduitsEnStock)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.GroupBoxCategorie.ResumeLayout(false);
            this.GroupBoxCategorie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox CmbCategories;
        private Guna.UI2.WinForms.Guna2Button BtnAjouter;
        private Guna.UI2.WinForms.Guna2DataGridView DGVListeProduitsEnStock;
        private Guna.UI2.WinForms.Guna2Button BtnEnregistrer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TxtQuantiteDisponible;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtQuantiteAjouter;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxtNom;
        public Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        public Guna.UI2.WinForms.Guna2GroupBox GroupBoxCategorie;
        private Guna.UI2.WinForms.Guna2Button BtnSupprimer;
        private Guna.UI2.WinForms.Guna2Button BtnReset;
    }
}

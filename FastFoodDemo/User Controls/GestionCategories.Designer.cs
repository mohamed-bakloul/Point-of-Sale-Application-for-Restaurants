
namespace FastFoodDemo.User_Controls
{
    partial class GestionCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCategories));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GroupBoxCategorie = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LblErrorMessageImage = new System.Windows.Forms.Label();
            this.LblErrorMessage = new System.Windows.Forms.Label();
            this.ImageCategorie = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnModifier = new Guna.UI2.WinForms.Guna2Button();
            this.BtnParcourir = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomCategorie = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DGVCategories = new Guna.UI2.WinForms.Guna2DataGridView();
            this.GroupBoxCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCategorie)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 1);
            this.panel2.TabIndex = 5;
            // 
            // GroupBoxCategorie
            // 
            this.GroupBoxCategorie.BorderRadius = 10;
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessageImage);
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessage);
            this.GroupBoxCategorie.Controls.Add(this.ImageCategorie);
            this.GroupBoxCategorie.Controls.Add(this.BtnModifier);
            this.GroupBoxCategorie.Controls.Add(this.BtnParcourir);
            this.GroupBoxCategorie.Controls.Add(this.label2);
            this.GroupBoxCategorie.Controls.Add(this.BtnSupprimer);
            this.GroupBoxCategorie.Controls.Add(this.BtnAjouter);
            this.GroupBoxCategorie.Controls.Add(this.label1);
            this.GroupBoxCategorie.Controls.Add(this.TxtNomCategorie);
            this.GroupBoxCategorie.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBoxCategorie.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GroupBoxCategorie.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCategorie.Location = new System.Drawing.Point(13, 12);
            this.GroupBoxCategorie.Name = "GroupBoxCategorie";
            this.GroupBoxCategorie.ShadowDecoration.Parent = this.GroupBoxCategorie;
            this.GroupBoxCategorie.Size = new System.Drawing.Size(790, 284);
            this.GroupBoxCategorie.TabIndex = 6;
            this.GroupBoxCategorie.Text = "Information de catégorie";
            this.GroupBoxCategorie.Click += new System.EventHandler(this.GroupBoxCategorie_Click);
            // 
            // LblErrorMessageImage
            // 
            this.LblErrorMessageImage.AutoSize = true;
            this.LblErrorMessageImage.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessageImage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessageImage.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessageImage.Location = new System.Drawing.Point(76, 256);
            this.LblErrorMessageImage.Name = "LblErrorMessageImage";
            this.LblErrorMessageImage.Size = new System.Drawing.Size(159, 17);
            this.LblErrorMessageImage.TabIndex = 69;
            this.LblErrorMessageImage.Text = "Veuillez choisir l\'image !";
            this.LblErrorMessageImage.Visible = false;
            // 
            // LblErrorMessage
            // 
            this.LblErrorMessage.AutoSize = true;
            this.LblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessage.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessage.Location = new System.Drawing.Point(83, 112);
            this.LblErrorMessage.Name = "LblErrorMessage";
            this.LblErrorMessage.Size = new System.Drawing.Size(153, 17);
            this.LblErrorMessage.TabIndex = 16;
            this.LblErrorMessage.Text = "Veuillez entrer le nom !";
            this.LblErrorMessage.Visible = false;
            // 
            // ImageCategorie
            // 
            this.ImageCategorie.BorderRadius = 10;
            this.ImageCategorie.Location = new System.Drawing.Point(76, 155);
            this.ImageCategorie.Name = "ImageCategorie";
            this.ImageCategorie.ShadowDecoration.Parent = this.ImageCategorie;
            this.ImageCategorie.Size = new System.Drawing.Size(153, 98);
            this.ImageCategorie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageCategorie.TabIndex = 15;
            this.ImageCategorie.TabStop = false;
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
            this.BtnModifier.ImageSize = new System.Drawing.Size(20, 18);
            this.BtnModifier.Location = new System.Drawing.Point(468, 128);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.ShadowDecoration.Parent = this.BtnModifier;
            this.BtnModifier.Size = new System.Drawing.Size(123, 40);
            this.BtnModifier.TabIndex = 14;
            this.BtnModifier.Text = "Modifier";
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
            this.BtnParcourir.Location = new System.Drawing.Point(238, 178);
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
            this.label2.Location = new System.Drawing.Point(83, 134);
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
            this.BtnSupprimer.ImageSize = new System.Drawing.Size(21, 20);
            this.BtnSupprimer.Location = new System.Drawing.Point(597, 128);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.ShadowDecoration.Parent = this.BtnSupprimer;
            this.BtnSupprimer.Size = new System.Drawing.Size(123, 40);
            this.BtnSupprimer.TabIndex = 9;
            this.BtnSupprimer.Text = "Supprimer";
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
            this.BtnAjouter.ImageSize = new System.Drawing.Size(21, 21);
            this.BtnAjouter.Location = new System.Drawing.Point(339, 128);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.ShadowDecoration.Parent = this.BtnAjouter;
            this.BtnAjouter.Size = new System.Drawing.Size(123, 40);
            this.BtnAjouter.TabIndex = 8;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(83, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom";
            // 
            // TxtNomCategorie
            // 
            this.TxtNomCategorie.BackColor = System.Drawing.Color.Transparent;
            this.TxtNomCategorie.BorderColor = System.Drawing.Color.Silver;
            this.TxtNomCategorie.BorderRadius = 10;
            this.TxtNomCategorie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNomCategorie.DefaultText = "";
            this.TxtNomCategorie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNomCategorie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNomCategorie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNomCategorie.DisabledState.Parent = this.TxtNomCategorie;
            this.TxtNomCategorie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNomCategorie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNomCategorie.FocusedState.Parent = this.TxtNomCategorie;
            this.TxtNomCategorie.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.TxtNomCategorie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNomCategorie.HoverState.Parent = this.TxtNomCategorie;
            this.TxtNomCategorie.Location = new System.Drawing.Point(76, 72);
            this.TxtNomCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNomCategorie.Name = "TxtNomCategorie";
            this.TxtNomCategorie.PasswordChar = '\0';
            this.TxtNomCategorie.PlaceholderText = "";
            this.TxtNomCategorie.SelectedText = "";
            this.TxtNomCategorie.ShadowDecoration.Parent = this.TxtNomCategorie;
            this.TxtNomCategorie.Size = new System.Drawing.Size(215, 37);
            this.TxtNomCategorie.TabIndex = 6;
            this.TxtNomCategorie.TextChanged += new System.EventHandler(this.TxtNomCategorie_TextChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.DGVCategories);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(13, 309);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(790, 148);
            this.guna2GroupBox1.TabIndex = 15;
            this.guna2GroupBox1.Text = "Liste des catégories";
            // 
            // DGVCategories
            // 
            this.DGVCategories.AllowUserToAddRows = false;
            this.DGVCategories.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCategories.BackgroundColor = System.Drawing.Color.White;
            this.DGVCategories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCategories.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCategories.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVCategories.EnableHeadersVisualStyles = false;
            this.DGVCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVCategories.Location = new System.Drawing.Point(17, 51);
            this.DGVCategories.Name = "DGVCategories";
            this.DGVCategories.ReadOnly = true;
            this.DGVCategories.RowHeadersVisible = false;
            this.DGVCategories.RowTemplate.Height = 30;
            this.DGVCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCategories.Size = new System.Drawing.Size(755, 87);
            this.DGVCategories.TabIndex = 1;
            this.DGVCategories.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVCategories.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVCategories.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVCategories.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVCategories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVCategories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVCategories.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVCategories.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVCategories.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DGVCategories.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVCategories.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVCategories.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVCategories.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVCategories.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVCategories.ThemeStyle.ReadOnly = true;
            this.DGVCategories.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVCategories.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVCategories.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVCategories.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVCategories.ThemeStyle.RowsStyle.Height = 30;
            this.DGVCategories.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVCategories.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVCategories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategories_CellDoubleClick);
            // 
            // GestionCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.GroupBoxCategorie);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GestionCategories";
            this.Size = new System.Drawing.Size(817, 470);
            this.Load += new System.EventHandler(this.GestionCategories_Load);
            this.GroupBoxCategorie.ResumeLayout(false);
            this.GroupBoxCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCategorie)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button BtnSupprimer;
        private Guna.UI2.WinForms.Guna2Button BtnAjouter;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtNomCategorie;
        private Guna.UI2.WinForms.Guna2Button BtnParcourir;
        private Guna.UI2.WinForms.Guna2Button BtnModifier;
        private Guna.UI2.WinForms.Guna2DataGridView DGVCategories;
        private Guna.UI2.WinForms.Guna2PictureBox ImageCategorie;
        public Guna.UI2.WinForms.Guna2GroupBox GroupBoxCategorie;
        public Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label LblErrorMessage;
        private System.Windows.Forms.Label LblErrorMessageImage;
    }
}

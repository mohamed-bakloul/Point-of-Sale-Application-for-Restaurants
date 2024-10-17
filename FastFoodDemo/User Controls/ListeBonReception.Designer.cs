
namespace FastFoodDemo.User_Controls
{
    partial class ListeBonReception
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeBonReception));
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DGVBonReception = new Guna.UI2.WinForms.Guna2DataGridView();
            this.GroupBoxCategorie = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnModifier = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.TxtRechercherProduit = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnRechercher = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBonReception)).BeginInit();
            this.GroupBoxCategorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.TxtRechercherProduit);
            this.guna2GroupBox1.Controls.Add(this.BtnRechercher);
            this.guna2GroupBox1.Controls.Add(this.DGVBonReception);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 196);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(885, 363);
            this.guna2GroupBox1.TabIndex = 17;
            this.guna2GroupBox1.Text = "Liste des bon de récéption";
            // 
            // DGVBonReception
            // 
            this.DGVBonReception.AllowUserToAddRows = false;
            this.DGVBonReception.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DGVBonReception.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVBonReception.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVBonReception.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBonReception.BackgroundColor = System.Drawing.Color.White;
            this.DGVBonReception.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVBonReception.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVBonReception.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVBonReception.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVBonReception.ColumnHeadersHeight = 35;
            this.DGVBonReception.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVBonReception.DefaultCellStyle = dataGridViewCellStyle9;
            this.DGVBonReception.EnableHeadersVisualStyles = false;
            this.DGVBonReception.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVBonReception.Location = new System.Drawing.Point(17, 102);
            this.DGVBonReception.Name = "DGVBonReception";
            this.DGVBonReception.ReadOnly = true;
            this.DGVBonReception.RowHeadersVisible = false;
            this.DGVBonReception.RowTemplate.Height = 30;
            this.DGVBonReception.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVBonReception.Size = new System.Drawing.Size(850, 251);
            this.DGVBonReception.TabIndex = 1;
            this.DGVBonReception.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVBonReception.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVBonReception.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVBonReception.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVBonReception.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVBonReception.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVBonReception.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVBonReception.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVBonReception.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DGVBonReception.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVBonReception.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVBonReception.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVBonReception.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVBonReception.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVBonReception.ThemeStyle.ReadOnly = true;
            this.DGVBonReception.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVBonReception.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVBonReception.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVBonReception.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVBonReception.ThemeStyle.RowsStyle.Height = 30;
            this.DGVBonReception.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVBonReception.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // GroupBoxCategorie
            // 
            this.GroupBoxCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxCategorie.BorderRadius = 10;
            this.GroupBoxCategorie.Controls.Add(this.BtnModifier);
            this.GroupBoxCategorie.Controls.Add(this.BtnSupprimer);
            this.GroupBoxCategorie.Controls.Add(this.BtnAjouter);
            this.GroupBoxCategorie.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBoxCategorie.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GroupBoxCategorie.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCategorie.Location = new System.Drawing.Point(12, 13);
            this.GroupBoxCategorie.Name = "GroupBoxCategorie";
            this.GroupBoxCategorie.ShadowDecoration.Parent = this.GroupBoxCategorie;
            this.GroupBoxCategorie.Size = new System.Drawing.Size(885, 169);
            this.GroupBoxCategorie.TabIndex = 16;
            this.GroupBoxCategorie.Text = "Bon de récéption";
            // 
            // BtnModifier
            // 
            this.BtnModifier.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.BtnModifier.Location = new System.Drawing.Point(365, 63);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.ShadowDecoration.Parent = this.BtnModifier;
            this.BtnModifier.Size = new System.Drawing.Size(155, 75);
            this.BtnModifier.TabIndex = 14;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.BtnSupprimer.Location = new System.Drawing.Point(526, 63);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.ShadowDecoration.Parent = this.BtnSupprimer;
            this.BtnSupprimer.Size = new System.Drawing.Size(155, 75);
            this.BtnSupprimer.TabIndex = 9;
            this.BtnSupprimer.Text = "Supprimer";
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
            this.BtnAjouter.ImageSize = new System.Drawing.Size(21, 21);
            this.BtnAjouter.Location = new System.Drawing.Point(204, 63);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.ShadowDecoration.Parent = this.BtnAjouter;
            this.BtnAjouter.Size = new System.Drawing.Size(155, 75);
            this.BtnAjouter.TabIndex = 8;
            this.BtnAjouter.Text = "Nouveau";
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // TxtRechercherProduit
            // 
            this.TxtRechercherProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRechercherProduit.BackColor = System.Drawing.Color.Transparent;
            this.TxtRechercherProduit.BorderColor = System.Drawing.Color.Silver;
            this.TxtRechercherProduit.BorderRadius = 10;
            this.TxtRechercherProduit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRechercherProduit.DefaultText = "";
            this.TxtRechercherProduit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtRechercherProduit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtRechercherProduit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRechercherProduit.DisabledState.Parent = this.TxtRechercherProduit;
            this.TxtRechercherProduit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRechercherProduit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRechercherProduit.FocusedState.Parent = this.TxtRechercherProduit;
            this.TxtRechercherProduit.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.TxtRechercherProduit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRechercherProduit.HoverState.Parent = this.TxtRechercherProduit;
            this.TxtRechercherProduit.Location = new System.Drawing.Point(602, 52);
            this.TxtRechercherProduit.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRechercherProduit.Name = "TxtRechercherProduit";
            this.TxtRechercherProduit.PasswordChar = '\0';
            this.TxtRechercherProduit.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.TxtRechercherProduit.PlaceholderText = "Rechercher le produit";
            this.TxtRechercherProduit.SelectedText = "";
            this.TxtRechercherProduit.ShadowDecoration.Parent = this.TxtRechercherProduit;
            this.TxtRechercherProduit.Size = new System.Drawing.Size(0, 37);
            this.TxtRechercherProduit.TabIndex = 26;
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
            this.BtnRechercher.Location = new System.Drawing.Point(827, 52);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.ShadowDecoration.Parent = this.BtnRechercher;
            this.BtnRechercher.Size = new System.Drawing.Size(40, 37);
            this.BtnRechercher.TabIndex = 25;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 1);
            this.panel2.TabIndex = 20;
            // 
            // ListeBonReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.GroupBoxCategorie);
            this.Name = "ListeBonReception";
            this.Size = new System.Drawing.Size(908, 579);
            this.Load += new System.EventHandler(this.ListeBonReception_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBonReception)).EndInit();
            this.GroupBoxCategorie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView DGVBonReception;
        public Guna.UI2.WinForms.Guna2GroupBox GroupBoxCategorie;
        private Guna.UI2.WinForms.Guna2Button BtnModifier;
        private Guna.UI2.WinForms.Guna2Button BtnSupprimer;
        private Guna.UI2.WinForms.Guna2Button BtnAjouter;
        private Guna.UI2.WinForms.Guna2TextBox TxtRechercherProduit;
        private Guna.UI2.WinForms.Guna2Button BtnRechercher;
        private System.Windows.Forms.Panel panel2;
    }
}

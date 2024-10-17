
namespace FastFoodDemo.User_Controls
{
    partial class ListeCommandes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeCommandes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GroupBoxCategorie = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnImprimerDuplicata = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVDetailsCommane = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVListeCommandes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Catégorie = new System.Windows.Forms.Label();
            this.CmbUtilisateur = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DPDateDebut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DPDateFin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnRechercher = new Guna.UI2.WinForms.Guna2Button();
            this.GroupBoxCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetailsCommane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeCommandes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 1);
            this.panel2.TabIndex = 28;
            // 
            // GroupBoxCategorie
            // 
            this.GroupBoxCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBoxCategorie.BorderRadius = 10;
            this.GroupBoxCategorie.Controls.Add(this.BtnImprimerDuplicata);
            this.GroupBoxCategorie.Controls.Add(this.BtnSupprimer);
            this.GroupBoxCategorie.Controls.Add(this.label3);
            this.GroupBoxCategorie.Controls.Add(this.DGVDetailsCommane);
            this.GroupBoxCategorie.Controls.Add(this.label1);
            this.GroupBoxCategorie.Controls.Add(this.DGVListeCommandes);
            this.GroupBoxCategorie.Controls.Add(this.Catégorie);
            this.GroupBoxCategorie.Controls.Add(this.CmbUtilisateur);
            this.GroupBoxCategorie.Controls.Add(this.label2);
            this.GroupBoxCategorie.Controls.Add(this.DPDateDebut);
            this.GroupBoxCategorie.Controls.Add(this.label4);
            this.GroupBoxCategorie.Controls.Add(this.DPDateFin);
            this.GroupBoxCategorie.Controls.Add(this.BtnRechercher);
            this.GroupBoxCategorie.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBoxCategorie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCategorie.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCategorie.Location = new System.Drawing.Point(13, 10);
            this.GroupBoxCategorie.Name = "GroupBoxCategorie";
            this.GroupBoxCategorie.ShadowDecoration.Parent = this.GroupBoxCategorie;
            this.GroupBoxCategorie.Size = new System.Drawing.Size(790, 555);
            this.GroupBoxCategorie.TabIndex = 29;
            this.GroupBoxCategorie.Text = "Liste des commandes";
            // 
            // BtnImprimerDuplicata
            // 
            this.BtnImprimerDuplicata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImprimerDuplicata.BackColor = System.Drawing.Color.Transparent;
            this.BtnImprimerDuplicata.BorderRadius = 10;
            this.BtnImprimerDuplicata.CheckedState.Parent = this.BtnImprimerDuplicata;
            this.BtnImprimerDuplicata.CustomImages.Parent = this.BtnImprimerDuplicata;
            this.BtnImprimerDuplicata.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnImprimerDuplicata.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimerDuplicata.ForeColor = System.Drawing.Color.White;
            this.BtnImprimerDuplicata.HoverState.Parent = this.BtnImprimerDuplicata;
            this.BtnImprimerDuplicata.Image = ((System.Drawing.Image)(resources.GetObject("BtnImprimerDuplicata.Image")));
            this.BtnImprimerDuplicata.ImageOffset = new System.Drawing.Point(-1, 0);
            this.BtnImprimerDuplicata.Location = new System.Drawing.Point(451, 157);
            this.BtnImprimerDuplicata.Name = "BtnImprimerDuplicata";
            this.BtnImprimerDuplicata.ShadowDecoration.Parent = this.BtnImprimerDuplicata;
            this.BtnImprimerDuplicata.Size = new System.Drawing.Size(150, 40);
            this.BtnImprimerDuplicata.TabIndex = 34;
            this.BtnImprimerDuplicata.Text = "Duplicata";
            this.BtnImprimerDuplicata.TextOffset = new System.Drawing.Point(1, 0);
            this.BtnImprimerDuplicata.Click += new System.EventHandler(this.BtnImprimerDuplicata_Click);
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
            this.BtnSupprimer.ImageOffset = new System.Drawing.Point(-1, 0);
            this.BtnSupprimer.ImageSize = new System.Drawing.Size(22, 21);
            this.BtnSupprimer.Location = new System.Drawing.Point(607, 157);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.ShadowDecoration.Parent = this.BtnSupprimer;
            this.BtnSupprimer.Size = new System.Drawing.Size(150, 40);
            this.BtnSupprimer.TabIndex = 33;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.TextOffset = new System.Drawing.Point(1, 0);
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.6F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Détails de commande";
            // 
            // DGVDetailsCommane
            // 
            this.DGVDetailsCommane.AllowUserToAddRows = false;
            this.DGVDetailsCommane.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVDetailsCommane.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDetailsCommane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDetailsCommane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDetailsCommane.BackgroundColor = System.Drawing.Color.White;
            this.DGVDetailsCommane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVDetailsCommane.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDetailsCommane.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDetailsCommane.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDetailsCommane.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDetailsCommane.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDetailsCommane.EnableHeadersVisualStyles = false;
            this.DGVDetailsCommane.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVDetailsCommane.Location = new System.Drawing.Point(33, 399);
            this.DGVDetailsCommane.Name = "DGVDetailsCommane";
            this.DGVDetailsCommane.ReadOnly = true;
            this.DGVDetailsCommane.RowHeadersVisible = false;
            this.DGVDetailsCommane.RowTemplate.Height = 30;
            this.DGVDetailsCommane.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDetailsCommane.Size = new System.Drawing.Size(724, 145);
            this.DGVDetailsCommane.TabIndex = 27;
            this.DGVDetailsCommane.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVDetailsCommane.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVDetailsCommane.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVDetailsCommane.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVDetailsCommane.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVDetailsCommane.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVDetailsCommane.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVDetailsCommane.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVDetailsCommane.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DGVDetailsCommane.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVDetailsCommane.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDetailsCommane.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVDetailsCommane.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVDetailsCommane.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVDetailsCommane.ThemeStyle.ReadOnly = true;
            this.DGVDetailsCommane.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVDetailsCommane.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVDetailsCommane.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDetailsCommane.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVDetailsCommane.ThemeStyle.RowsStyle.Height = 30;
            this.DGVDetailsCommane.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVDetailsCommane.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVDetailsCommane.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDetailsCommane_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.6F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Liste des commandes";
            // 
            // DGVListeCommandes
            // 
            this.DGVListeCommandes.AllowUserToAddRows = false;
            this.DGVListeCommandes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGVListeCommandes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVListeCommandes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVListeCommandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVListeCommandes.BackgroundColor = System.Drawing.Color.White;
            this.DGVListeCommandes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVListeCommandes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVListeCommandes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListeCommandes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVListeCommandes.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListeCommandes.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVListeCommandes.EnableHeadersVisualStyles = false;
            this.DGVListeCommandes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeCommandes.Location = new System.Drawing.Point(33, 205);
            this.DGVListeCommandes.Name = "DGVListeCommandes";
            this.DGVListeCommandes.ReadOnly = true;
            this.DGVListeCommandes.RowHeadersVisible = false;
            this.DGVListeCommandes.RowTemplate.Height = 30;
            this.DGVListeCommandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListeCommandes.Size = new System.Drawing.Size(724, 160);
            this.DGVListeCommandes.TabIndex = 25;
            this.DGVListeCommandes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVListeCommandes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeCommandes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVListeCommandes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVListeCommandes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVListeCommandes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVListeCommandes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeCommandes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeCommandes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DGVListeCommandes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVListeCommandes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListeCommandes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVListeCommandes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVListeCommandes.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVListeCommandes.ThemeStyle.ReadOnly = true;
            this.DGVListeCommandes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeCommandes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVListeCommandes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListeCommandes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVListeCommandes.ThemeStyle.RowsStyle.Height = 30;
            this.DGVListeCommandes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeCommandes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVListeCommandes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListeCommandes_CellDoubleClick);
            // 
            // Catégorie
            // 
            this.Catégorie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Catégorie.AutoSize = true;
            this.Catégorie.BackColor = System.Drawing.Color.Transparent;
            this.Catégorie.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Catégorie.ForeColor = System.Drawing.Color.Black;
            this.Catégorie.Location = new System.Drawing.Point(537, 58);
            this.Catégorie.Name = "Catégorie";
            this.Catégorie.Size = new System.Drawing.Size(66, 17);
            this.Catégorie.TabIndex = 24;
            this.Catégorie.Text = "Utlisateur";
            // 
            // CmbUtilisateur
            // 
            this.CmbUtilisateur.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.CmbUtilisateur.Location = new System.Drawing.Point(532, 80);
            this.CmbUtilisateur.Name = "CmbUtilisateur";
            this.CmbUtilisateur.ShadowDecoration.Parent = this.CmbUtilisateur;
            this.CmbUtilisateur.Size = new System.Drawing.Size(215, 36);
            this.CmbUtilisateur.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date début";
            // 
            // DPDateDebut
            // 
            this.DPDateDebut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DPDateDebut.BackColor = System.Drawing.Color.Transparent;
            this.DPDateDebut.BorderRadius = 10;
            this.DPDateDebut.CheckedState.Parent = this.DPDateDebut;
            this.DPDateDebut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DPDateDebut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPDateDebut.HoverState.Parent = this.DPDateDebut;
            this.DPDateDebut.Location = new System.Drawing.Point(44, 80);
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
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(293, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date fin";
            // 
            // DPDateFin
            // 
            this.DPDateFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DPDateFin.BackColor = System.Drawing.Color.Transparent;
            this.DPDateFin.BorderRadius = 10;
            this.DPDateFin.CheckedState.Parent = this.DPDateFin;
            this.DPDateFin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DPDateFin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPDateFin.HoverState.Parent = this.DPDateFin;
            this.DPDateFin.Location = new System.Drawing.Point(288, 80);
            this.DPDateFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DPDateFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DPDateFin.Name = "DPDateFin";
            this.DPDateFin.ShadowDecoration.Parent = this.DPDateFin;
            this.DPDateFin.Size = new System.Drawing.Size(215, 37);
            this.DPDateFin.TabIndex = 19;
            this.DPDateFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DPDateFin.Value = new System.DateTime(2022, 10, 11, 22, 8, 9, 320);
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRechercher.BackColor = System.Drawing.Color.Transparent;
            this.BtnRechercher.BorderRadius = 10;
            this.BtnRechercher.CheckedState.Parent = this.BtnRechercher;
            this.BtnRechercher.CustomImages.Parent = this.BtnRechercher;
            this.BtnRechercher.FillColor = System.Drawing.Color.SteelBlue;
            this.BtnRechercher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechercher.ForeColor = System.Drawing.Color.White;
            this.BtnRechercher.HoverState.Parent = this.BtnRechercher;
            this.BtnRechercher.Image = ((System.Drawing.Image)(resources.GetObject("BtnRechercher.Image")));
            this.BtnRechercher.ImageSize = new System.Drawing.Size(21, 21);
            this.BtnRechercher.Location = new System.Drawing.Point(295, 157);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.ShadowDecoration.Parent = this.BtnRechercher;
            this.BtnRechercher.Size = new System.Drawing.Size(150, 40);
            this.BtnRechercher.TabIndex = 8;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // ListeCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxCategorie);
            this.Controls.Add(this.panel2);
            this.Name = "ListeCommandes";
            this.Size = new System.Drawing.Size(817, 575);
            this.Load += new System.EventHandler(this.ListeCommandes_Load);
            this.GroupBoxCategorie.ResumeLayout(false);
            this.GroupBoxCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetailsCommane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeCommandes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Catégorie;
        private Guna.UI2.WinForms.Guna2ComboBox CmbUtilisateur;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DPDateDebut;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker DPDateFin;
        private Guna.UI2.WinForms.Guna2Button BtnRechercher;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView DGVDetailsCommane;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DGVListeCommandes;
        private Guna.UI2.WinForms.Guna2Button BtnImprimerDuplicata;
        private Guna.UI2.WinForms.Guna2Button BtnSupprimer;
        public Guna.UI2.WinForms.Guna2GroupBox GroupBoxCategorie;
    }
}

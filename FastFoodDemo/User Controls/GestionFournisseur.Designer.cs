
namespace FastFoodDemo.User_Controls
{
    partial class GestionFournisseur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionFournisseur));
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblErrorMessageCodeBarre = new System.Windows.Forms.Label();
            this.LblErrorMessagePrixLivraison = new System.Windows.Forms.Label();
            this.LblErrorMessagePrixNormal = new System.Windows.Forms.Label();
            this.LblErrorMessageNom = new System.Windows.Forms.Label();
            this.LblCodeBarre = new System.Windows.Forms.Label();
            this.TxtAdresse = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblPrixLivraison = new System.Windows.Forms.Label();
            this.TxtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.DGVFournisseurs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.LblPrixNormal = new System.Windows.Forms.Label();
            this.TxtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnModifier = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCIN = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GroupBoxCategorie = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPrenom = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFournisseurs)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.GroupBoxCategorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 1);
            this.panel2.TabIndex = 21;
            // 
            // LblErrorMessageCodeBarre
            // 
            this.LblErrorMessageCodeBarre.AutoSize = true;
            this.LblErrorMessageCodeBarre.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessageCodeBarre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessageCodeBarre.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessageCodeBarre.Location = new System.Drawing.Point(290, 288);
            this.LblErrorMessageCodeBarre.Name = "LblErrorMessageCodeBarre";
            this.LblErrorMessageCodeBarre.Size = new System.Drawing.Size(162, 17);
            this.LblErrorMessageCodeBarre.TabIndex = 67;
            this.LblErrorMessageCodeBarre.Text = "Veuillez entrer l\'adresse !";
            this.LblErrorMessageCodeBarre.Visible = false;
            // 
            // LblErrorMessagePrixLivraison
            // 
            this.LblErrorMessagePrixLivraison.AutoSize = true;
            this.LblErrorMessagePrixLivraison.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessagePrixLivraison.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessagePrixLivraison.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessagePrixLivraison.Location = new System.Drawing.Point(290, 112);
            this.LblErrorMessagePrixLivraison.Name = "LblErrorMessagePrixLivraison";
            this.LblErrorMessagePrixLivraison.Size = new System.Drawing.Size(189, 17);
            this.LblErrorMessagePrixLivraison.TabIndex = 66;
            this.LblErrorMessagePrixLivraison.Text = "Veuillez entrer le téléphone !";
            this.LblErrorMessagePrixLivraison.Visible = false;
            // 
            // LblErrorMessagePrixNormal
            // 
            this.LblErrorMessagePrixNormal.AutoSize = true;
            this.LblErrorMessagePrixNormal.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessagePrixNormal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessagePrixNormal.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessagePrixNormal.Location = new System.Drawing.Point(525, 112);
            this.LblErrorMessagePrixNormal.Name = "LblErrorMessagePrixNormal";
            this.LblErrorMessagePrixNormal.Size = new System.Drawing.Size(150, 17);
            this.LblErrorMessagePrixNormal.TabIndex = 65;
            this.LblErrorMessagePrixNormal.Text = "Veuillez entrer l\'email !";
            this.LblErrorMessagePrixNormal.Visible = false;
            // 
            // LblErrorMessageNom
            // 
            this.LblErrorMessageNom.AutoSize = true;
            this.LblErrorMessageNom.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessageNom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessageNom.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessageNom.Location = new System.Drawing.Point(48, 112);
            this.LblErrorMessageNom.Name = "LblErrorMessageNom";
            this.LblErrorMessageNom.Size = new System.Drawing.Size(147, 17);
            this.LblErrorMessageNom.TabIndex = 64;
            this.LblErrorMessageNom.Text = "Veuillez entrer le CIN !";
            this.LblErrorMessageNom.Visible = false;
            // 
            // LblCodeBarre
            // 
            this.LblCodeBarre.AutoSize = true;
            this.LblCodeBarre.BackColor = System.Drawing.Color.Transparent;
            this.LblCodeBarre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblCodeBarre.ForeColor = System.Drawing.Color.Black;
            this.LblCodeBarre.Location = new System.Drawing.Point(290, 141);
            this.LblCodeBarre.Name = "LblCodeBarre";
            this.LblCodeBarre.Size = new System.Drawing.Size(56, 17);
            this.LblCodeBarre.TabIndex = 23;
            this.LblCodeBarre.Text = "Adresse";
            // 
            // TxtAdresse
            // 
            this.TxtAdresse.BackColor = System.Drawing.Color.Transparent;
            this.TxtAdresse.BorderColor = System.Drawing.Color.Silver;
            this.TxtAdresse.BorderRadius = 10;
            this.TxtAdresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAdresse.DefaultText = "";
            this.TxtAdresse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtAdresse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtAdresse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAdresse.DisabledState.Parent = this.TxtAdresse;
            this.TxtAdresse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAdresse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAdresse.FocusedState.Parent = this.TxtAdresse;
            this.TxtAdresse.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.TxtAdresse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAdresse.HoverState.Parent = this.TxtAdresse;
            this.TxtAdresse.Location = new System.Drawing.Point(282, 162);
            this.TxtAdresse.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtAdresse.Name = "TxtAdresse";
            this.TxtAdresse.PasswordChar = '\0';
            this.TxtAdresse.PlaceholderText = "";
            this.TxtAdresse.SelectedText = "";
            this.TxtAdresse.ShadowDecoration.Parent = this.TxtAdresse;
            this.TxtAdresse.Size = new System.Drawing.Size(215, 123);
            this.TxtAdresse.TabIndex = 3;
            // 
            // LblPrixLivraison
            // 
            this.LblPrixLivraison.AutoSize = true;
            this.LblPrixLivraison.BackColor = System.Drawing.Color.Transparent;
            this.LblPrixLivraison.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblPrixLivraison.ForeColor = System.Drawing.Color.Black;
            this.LblPrixLivraison.Location = new System.Drawing.Point(290, 51);
            this.LblPrixLivraison.Name = "LblPrixLivraison";
            this.LblPrixLivraison.Size = new System.Drawing.Size(74, 17);
            this.LblPrixLivraison.TabIndex = 21;
            this.LblPrixLivraison.Text = "Téléphone";
            // 
            // TxtPhone
            // 
            this.TxtPhone.BackColor = System.Drawing.Color.Transparent;
            this.TxtPhone.BorderColor = System.Drawing.Color.Silver;
            this.TxtPhone.BorderRadius = 10;
            this.TxtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPhone.DefaultText = "";
            this.TxtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPhone.DisabledState.Parent = this.TxtPhone;
            this.TxtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPhone.FocusedState.Parent = this.TxtPhone;
            this.TxtPhone.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.TxtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPhone.HoverState.Parent = this.TxtPhone;
            this.TxtPhone.Location = new System.Drawing.Point(282, 72);
            this.TxtPhone.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.PasswordChar = '\0';
            this.TxtPhone.PlaceholderText = "";
            this.TxtPhone.SelectedText = "";
            this.TxtPhone.ShadowDecoration.Parent = this.TxtPhone;
            this.TxtPhone.Size = new System.Drawing.Size(215, 37);
            this.TxtPhone.TabIndex = 2;
            // 
            // DGVFournisseurs
            // 
            this.DGVFournisseurs.AllowUserToAddRows = false;
            this.DGVFournisseurs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGVFournisseurs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVFournisseurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVFournisseurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVFournisseurs.BackgroundColor = System.Drawing.Color.White;
            this.DGVFournisseurs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVFournisseurs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVFournisseurs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFournisseurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVFournisseurs.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVFournisseurs.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVFournisseurs.EnableHeadersVisualStyles = false;
            this.DGVFournisseurs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVFournisseurs.Location = new System.Drawing.Point(17, 51);
            this.DGVFournisseurs.Name = "DGVFournisseurs";
            this.DGVFournisseurs.ReadOnly = true;
            this.DGVFournisseurs.RowHeadersVisible = false;
            this.DGVFournisseurs.RowTemplate.Height = 30;
            this.DGVFournisseurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFournisseurs.Size = new System.Drawing.Size(755, 112);
            this.DGVFournisseurs.TabIndex = 1;
            this.DGVFournisseurs.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVFournisseurs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVFournisseurs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVFournisseurs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVFournisseurs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVFournisseurs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVFournisseurs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVFournisseurs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVFournisseurs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DGVFournisseurs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVFournisseurs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVFournisseurs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVFournisseurs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVFournisseurs.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVFournisseurs.ThemeStyle.ReadOnly = true;
            this.DGVFournisseurs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVFournisseurs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVFournisseurs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVFournisseurs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVFournisseurs.ThemeStyle.RowsStyle.Height = 30;
            this.DGVFournisseurs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVFournisseurs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // LblPrixNormal
            // 
            this.LblPrixNormal.AutoSize = true;
            this.LblPrixNormal.BackColor = System.Drawing.Color.Transparent;
            this.LblPrixNormal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblPrixNormal.ForeColor = System.Drawing.Color.Black;
            this.LblPrixNormal.Location = new System.Drawing.Point(525, 51);
            this.LblPrixNormal.Name = "LblPrixNormal";
            this.LblPrixNormal.Size = new System.Drawing.Size(43, 17);
            this.LblPrixNormal.TabIndex = 17;
            this.LblPrixNormal.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.Transparent;
            this.TxtEmail.BorderColor = System.Drawing.Color.Silver;
            this.TxtEmail.BorderRadius = 10;
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEmail.DefaultText = "";
            this.TxtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmail.DisabledState.Parent = this.TxtEmail;
            this.TxtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmail.FocusedState.Parent = this.TxtEmail;
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.TxtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmail.HoverState.Parent = this.TxtEmail;
            this.TxtEmail.Location = new System.Drawing.Point(520, 72);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.PlaceholderText = "";
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.ShadowDecoration.Parent = this.TxtEmail;
            this.TxtEmail.Size = new System.Drawing.Size(215, 37);
            this.TxtEmail.TabIndex = 1;
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
            this.BtnModifier.Location = new System.Drawing.Point(573, 208);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.ShadowDecoration.Parent = this.BtnModifier;
            this.BtnModifier.Size = new System.Drawing.Size(136, 40);
            this.BtnModifier.TabIndex = 14;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.TextOffset = new System.Drawing.Point(1, 0);
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
            this.BtnSupprimer.Location = new System.Drawing.Point(573, 254);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.ShadowDecoration.Parent = this.BtnSupprimer;
            this.BtnSupprimer.Size = new System.Drawing.Size(136, 40);
            this.BtnSupprimer.TabIndex = 9;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.TextOffset = new System.Drawing.Point(1, 0);
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
            this.BtnAjouter.Location = new System.Drawing.Point(573, 162);
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
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "CIN";
            // 
            // TxtCIN
            // 
            this.TxtCIN.BackColor = System.Drawing.Color.Transparent;
            this.TxtCIN.BorderColor = System.Drawing.Color.Silver;
            this.TxtCIN.BorderRadius = 10;
            this.TxtCIN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCIN.DefaultText = "";
            this.TxtCIN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCIN.DisabledState.Parent = this.TxtCIN;
            this.TxtCIN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCIN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCIN.FocusedState.Parent = this.TxtCIN;
            this.TxtCIN.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.TxtCIN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCIN.HoverState.Parent = this.TxtCIN;
            this.TxtCIN.Location = new System.Drawing.Point(44, 72);
            this.TxtCIN.Margin = new System.Windows.Forms.Padding(5);
            this.TxtCIN.Name = "TxtCIN";
            this.TxtCIN.PasswordChar = '\0';
            this.TxtCIN.PlaceholderText = "";
            this.TxtCIN.SelectedText = "";
            this.TxtCIN.ShadowDecoration.Parent = this.TxtCIN;
            this.TxtCIN.Size = new System.Drawing.Size(215, 37);
            this.TxtCIN.TabIndex = 0;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.DGVFournisseurs);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(13, 346);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(790, 179);
            this.guna2GroupBox1.TabIndex = 20;
            this.guna2GroupBox1.Text = "Liste des fournisseurs";
            // 
            // GroupBoxCategorie
            // 
            this.GroupBoxCategorie.BorderRadius = 10;
            this.GroupBoxCategorie.Controls.Add(this.label4);
            this.GroupBoxCategorie.Controls.Add(this.label5);
            this.GroupBoxCategorie.Controls.Add(this.TxtPrenom);
            this.GroupBoxCategorie.Controls.Add(this.label2);
            this.GroupBoxCategorie.Controls.Add(this.label3);
            this.GroupBoxCategorie.Controls.Add(this.TxtNom);
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessageCodeBarre);
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessagePrixLivraison);
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessagePrixNormal);
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessageNom);
            this.GroupBoxCategorie.Controls.Add(this.LblCodeBarre);
            this.GroupBoxCategorie.Controls.Add(this.TxtAdresse);
            this.GroupBoxCategorie.Controls.Add(this.LblPrixLivraison);
            this.GroupBoxCategorie.Controls.Add(this.TxtPhone);
            this.GroupBoxCategorie.Controls.Add(this.LblPrixNormal);
            this.GroupBoxCategorie.Controls.Add(this.TxtEmail);
            this.GroupBoxCategorie.Controls.Add(this.BtnModifier);
            this.GroupBoxCategorie.Controls.Add(this.BtnSupprimer);
            this.GroupBoxCategorie.Controls.Add(this.BtnAjouter);
            this.GroupBoxCategorie.Controls.Add(this.label1);
            this.GroupBoxCategorie.Controls.Add(this.TxtCIN);
            this.GroupBoxCategorie.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBoxCategorie.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GroupBoxCategorie.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCategorie.Location = new System.Drawing.Point(13, 11);
            this.GroupBoxCategorie.Name = "GroupBoxCategorie";
            this.GroupBoxCategorie.ShadowDecoration.Parent = this.GroupBoxCategorie;
            this.GroupBoxCategorie.Size = new System.Drawing.Size(790, 325);
            this.GroupBoxCategorie.TabIndex = 19;
            this.GroupBoxCategorie.Text = "Informations de fournisseur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(48, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Veuillez entrer le nom !";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Nom";
            // 
            // TxtNom
            // 
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
            this.TxtNom.Location = new System.Drawing.Point(44, 162);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.PasswordChar = '\0';
            this.TxtNom.PlaceholderText = "";
            this.TxtNom.SelectedText = "";
            this.TxtNom.ShadowDecoration.Parent = this.TxtNom;
            this.TxtNom.Size = new System.Drawing.Size(215, 37);
            this.TxtNom.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(48, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 73;
            this.label4.Text = "Veuillez entrer le prénom !";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(48, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 72;
            this.label5.Text = "Prénom";
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.BackColor = System.Drawing.Color.Transparent;
            this.TxtPrenom.BorderColor = System.Drawing.Color.Silver;
            this.TxtPrenom.BorderRadius = 10;
            this.TxtPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPrenom.DefaultText = "";
            this.TxtPrenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPrenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPrenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrenom.DisabledState.Parent = this.TxtPrenom;
            this.TxtPrenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrenom.FocusedState.Parent = this.TxtPrenom;
            this.TxtPrenom.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.TxtPrenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrenom.HoverState.Parent = this.TxtPrenom;
            this.TxtPrenom.Location = new System.Drawing.Point(44, 248);
            this.TxtPrenom.Margin = new System.Windows.Forms.Padding(5);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.PasswordChar = '\0';
            this.TxtPrenom.PlaceholderText = "";
            this.TxtPrenom.SelectedText = "";
            this.TxtPrenom.ShadowDecoration.Parent = this.TxtPrenom;
            this.TxtPrenom.Size = new System.Drawing.Size(215, 37);
            this.TxtPrenom.TabIndex = 71;
            // 
            // GestionFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.GroupBoxCategorie);
            this.Name = "GestionFournisseur";
            this.Size = new System.Drawing.Size(817, 540);
            this.Load += new System.EventHandler(this.GestionFournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFournisseurs)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.GroupBoxCategorie.ResumeLayout(false);
            this.GroupBoxCategorie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblErrorMessageCodeBarre;
        private System.Windows.Forms.Label LblErrorMessagePrixLivraison;
        private System.Windows.Forms.Label LblErrorMessagePrixNormal;
        private System.Windows.Forms.Label LblErrorMessageNom;
        private System.Windows.Forms.Label LblCodeBarre;
        private Guna.UI2.WinForms.Guna2TextBox TxtAdresse;
        private System.Windows.Forms.Label LblPrixLivraison;
        private Guna.UI2.WinForms.Guna2TextBox TxtPhone;
        private Guna.UI2.WinForms.Guna2DataGridView DGVFournisseurs;
        private System.Windows.Forms.Label LblPrixNormal;
        private Guna.UI2.WinForms.Guna2TextBox TxtEmail;
        private Guna.UI2.WinForms.Guna2Button BtnModifier;
        private Guna.UI2.WinForms.Guna2Button BtnSupprimer;
        private Guna.UI2.WinForms.Guna2Button BtnAjouter;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtCIN;
        public Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        public Guna.UI2.WinForms.Guna2GroupBox GroupBoxCategorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TxtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TxtPrenom;
    }
}

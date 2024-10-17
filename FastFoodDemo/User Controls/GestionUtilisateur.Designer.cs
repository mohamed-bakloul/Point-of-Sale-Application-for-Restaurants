
namespace FastFoodDemo.User_Controls
{
    partial class GestionUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUtilisateur));
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DGVUtilisateurs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PnlProfile = new System.Windows.Forms.Panel();
            this.BtnDeconnecter = new Guna.UI2.WinForms.Guna2Button();
            this.BtnParametre = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnQuitter = new Guna.UI2.WinForms.Guna2Button();
            this.GroupBoxCategorie = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LblErrorMessageRole = new System.Windows.Forms.Label();
            this.LblErrorMessagePrenom = new System.Windows.Forms.Label();
            this.LblErrorMessageMotPasse = new System.Windows.Forms.Label();
            this.LblErrorMessageNom = new System.Windows.Forms.Label();
            this.LblErrorMessageCIN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RDGerant = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RDCaissier = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RDAdmin = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMotPasse = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DPDateInscription = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnModifier = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCIN = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUtilisateurs)).BeginInit();
            this.PnlProfile.SuspendLayout();
            this.GroupBoxCategorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.DGVUtilisateurs);
            this.guna2GroupBox1.Controls.Add(this.PnlProfile);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(13, 320);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(790, 185);
            this.guna2GroupBox1.TabIndex = 17;
            this.guna2GroupBox1.Text = "Liste des utilisateurs";
            // 
            // DGVUtilisateurs
            // 
            this.DGVUtilisateurs.AllowUserToAddRows = false;
            this.DGVUtilisateurs.AllowUserToDeleteRows = false;
            this.DGVUtilisateurs.AllowUserToResizeColumns = false;
            this.DGVUtilisateurs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVUtilisateurs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVUtilisateurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVUtilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUtilisateurs.BackgroundColor = System.Drawing.Color.White;
            this.DGVUtilisateurs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVUtilisateurs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVUtilisateurs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUtilisateurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVUtilisateurs.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVUtilisateurs.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVUtilisateurs.EnableHeadersVisualStyles = false;
            this.DGVUtilisateurs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVUtilisateurs.Location = new System.Drawing.Point(17, 51);
            this.DGVUtilisateurs.Name = "DGVUtilisateurs";
            this.DGVUtilisateurs.ReadOnly = true;
            this.DGVUtilisateurs.RowHeadersVisible = false;
            this.DGVUtilisateurs.RowTemplate.Height = 30;
            this.DGVUtilisateurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUtilisateurs.Size = new System.Drawing.Size(755, 124);
            this.DGVUtilisateurs.TabIndex = 1;
            this.DGVUtilisateurs.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVUtilisateurs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVUtilisateurs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVUtilisateurs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVUtilisateurs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVUtilisateurs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVUtilisateurs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVUtilisateurs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVUtilisateurs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DGVUtilisateurs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVUtilisateurs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVUtilisateurs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVUtilisateurs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVUtilisateurs.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVUtilisateurs.ThemeStyle.ReadOnly = true;
            this.DGVUtilisateurs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVUtilisateurs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVUtilisateurs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVUtilisateurs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVUtilisateurs.ThemeStyle.RowsStyle.Height = 30;
            this.DGVUtilisateurs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVUtilisateurs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVUtilisateurs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUtilisateurs_CellDoubleClick);
            this.DGVUtilisateurs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVUtilisateurs_CellFormatting);
            this.DGVUtilisateurs.Paint += new System.Windows.Forms.PaintEventHandler(this.DGVUtilisateurs_Paint);
            // 
            // PnlProfile
            // 
            this.PnlProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlProfile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlProfile.Controls.Add(this.BtnDeconnecter);
            this.PnlProfile.Controls.Add(this.BtnParametre);
            this.PnlProfile.Controls.Add(this.guna2Button5);
            this.PnlProfile.Controls.Add(this.BtnQuitter);
            this.PnlProfile.Location = new System.Drawing.Point(590, 20);
            this.PnlProfile.Name = "PnlProfile";
            this.PnlProfile.Size = new System.Drawing.Size(200, 185);
            this.PnlProfile.TabIndex = 32;
            this.PnlProfile.Visible = false;
            // 
            // BtnDeconnecter
            // 
            this.BtnDeconnecter.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeconnecter.BorderColor = System.Drawing.Color.Transparent;
            this.BtnDeconnecter.CheckedState.Parent = this.BtnDeconnecter;
            this.BtnDeconnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeconnecter.CustomImages.Parent = this.BtnDeconnecter;
            this.BtnDeconnecter.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDeconnecter.FillColor = System.Drawing.Color.Transparent;
            this.BtnDeconnecter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeconnecter.ForeColor = System.Drawing.Color.Gray;
            this.BtnDeconnecter.HoverState.Parent = this.BtnDeconnecter;
            this.BtnDeconnecter.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeconnecter.Image")));
            this.BtnDeconnecter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnDeconnecter.ImageOffset = new System.Drawing.Point(5, 0);
            this.BtnDeconnecter.ImageSize = new System.Drawing.Size(27, 27);
            this.BtnDeconnecter.Location = new System.Drawing.Point(0, 135);
            this.BtnDeconnecter.Name = "BtnDeconnecter";
            this.BtnDeconnecter.ShadowDecoration.Parent = this.BtnDeconnecter;
            this.BtnDeconnecter.Size = new System.Drawing.Size(200, 45);
            this.BtnDeconnecter.TabIndex = 9;
            this.BtnDeconnecter.Text = "Déconnecter";
            this.BtnDeconnecter.TextOffset = new System.Drawing.Point(5, 0);
            this.BtnDeconnecter.Click += new System.EventHandler(this.BtnDeconnecter_Click);
            // 
            // BtnParametre
            // 
            this.BtnParametre.BackColor = System.Drawing.Color.Transparent;
            this.BtnParametre.BorderColor = System.Drawing.Color.Transparent;
            this.BtnParametre.CheckedState.Parent = this.BtnParametre;
            this.BtnParametre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnParametre.CustomImages.Parent = this.BtnParametre;
            this.BtnParametre.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnParametre.FillColor = System.Drawing.Color.Transparent;
            this.BtnParametre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnParametre.ForeColor = System.Drawing.Color.Gray;
            this.BtnParametre.HoverState.Parent = this.BtnParametre;
            this.BtnParametre.Image = ((System.Drawing.Image)(resources.GetObject("BtnParametre.Image")));
            this.BtnParametre.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnParametre.ImageOffset = new System.Drawing.Point(5, 0);
            this.BtnParametre.ImageSize = new System.Drawing.Size(27, 27);
            this.BtnParametre.Location = new System.Drawing.Point(0, 90);
            this.BtnParametre.Name = "BtnParametre";
            this.BtnParametre.ShadowDecoration.Parent = this.BtnParametre;
            this.BtnParametre.Size = new System.Drawing.Size(200, 45);
            this.BtnParametre.TabIndex = 8;
            this.BtnParametre.Text = "Paramétre";
            this.BtnParametre.TextOffset = new System.Drawing.Point(5, 0);
            this.BtnParametre.Click += new System.EventHandler(this.BtnParametre_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.Image")));
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.ImageOffset = new System.Drawing.Point(3, 0);
            this.guna2Button5.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button5.Location = new System.Drawing.Point(0, 45);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(200, 45);
            this.guna2Button5.TabIndex = 7;
            this.guna2Button5.Text = "Admin";
            this.guna2Button5.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.BtnQuitter.BorderColor = System.Drawing.Color.Transparent;
            this.BtnQuitter.CheckedState.Parent = this.BtnQuitter;
            this.BtnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQuitter.CustomImages.Parent = this.BtnQuitter;
            this.BtnQuitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnQuitter.FillColor = System.Drawing.Color.Transparent;
            this.BtnQuitter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitter.ForeColor = System.Drawing.Color.Gray;
            this.BtnQuitter.HoverState.Parent = this.BtnQuitter;
            this.BtnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("BtnQuitter.Image")));
            this.BtnQuitter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnQuitter.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnQuitter.Location = new System.Drawing.Point(0, 0);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.ShadowDecoration.Parent = this.BtnQuitter;
            this.BtnQuitter.Size = new System.Drawing.Size(200, 45);
            this.BtnQuitter.TabIndex = 6;
            this.BtnQuitter.Text = "Abderrahim Anjar";
            this.BtnQuitter.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // GroupBoxCategorie
            // 
            this.GroupBoxCategorie.BorderRadius = 10;
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessageRole);
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessagePrenom);
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessageMotPasse);
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessageNom);
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessageCIN);
            this.GroupBoxCategorie.Controls.Add(this.label6);
            this.GroupBoxCategorie.Controls.Add(this.RDGerant);
            this.GroupBoxCategorie.Controls.Add(this.RDCaissier);
            this.GroupBoxCategorie.Controls.Add(this.RDAdmin);
            this.GroupBoxCategorie.Controls.Add(this.label5);
            this.GroupBoxCategorie.Controls.Add(this.TxtMotPasse);
            this.GroupBoxCategorie.Controls.Add(this.label4);
            this.GroupBoxCategorie.Controls.Add(this.DPDateInscription);
            this.GroupBoxCategorie.Controls.Add(this.label3);
            this.GroupBoxCategorie.Controls.Add(this.TxtPrenom);
            this.GroupBoxCategorie.Controls.Add(this.label2);
            this.GroupBoxCategorie.Controls.Add(this.TxtNom);
            this.GroupBoxCategorie.Controls.Add(this.BtnModifier);
            this.GroupBoxCategorie.Controls.Add(this.BtnSupprimer);
            this.GroupBoxCategorie.Controls.Add(this.BtnAjouter);
            this.GroupBoxCategorie.Controls.Add(this.label1);
            this.GroupBoxCategorie.Controls.Add(this.TxtCIN);
            this.GroupBoxCategorie.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBoxCategorie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCategorie.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCategorie.Location = new System.Drawing.Point(13, 12);
            this.GroupBoxCategorie.Name = "GroupBoxCategorie";
            this.GroupBoxCategorie.ShadowDecoration.Parent = this.GroupBoxCategorie;
            this.GroupBoxCategorie.Size = new System.Drawing.Size(790, 300);
            this.GroupBoxCategorie.TabIndex = 16;
            this.GroupBoxCategorie.Text = "Information d\'utilisateur";
            // 
            // LblErrorMessageRole
            // 
            this.LblErrorMessageRole.AutoSize = true;
            this.LblErrorMessageRole.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessageRole.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessageRole.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessageRole.Location = new System.Drawing.Point(316, 273);
            this.LblErrorMessageRole.Name = "LblErrorMessageRole";
            this.LblErrorMessageRole.Size = new System.Drawing.Size(147, 17);
            this.LblErrorMessageRole.TabIndex = 69;
            this.LblErrorMessageRole.Text = "Veuillez entrer le rôle !";
            this.LblErrorMessageRole.Visible = false;
            // 
            // LblErrorMessagePrenom
            // 
            this.LblErrorMessagePrenom.AutoSize = true;
            this.LblErrorMessagePrenom.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessagePrenom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessagePrenom.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessagePrenom.Location = new System.Drawing.Point(54, 273);
            this.LblErrorMessagePrenom.Name = "LblErrorMessagePrenom";
            this.LblErrorMessagePrenom.Size = new System.Drawing.Size(174, 17);
            this.LblErrorMessagePrenom.TabIndex = 68;
            this.LblErrorMessagePrenom.Text = "Veuillez entrer le prénom !";
            this.LblErrorMessagePrenom.Visible = false;
            // 
            // LblErrorMessageMotPasse
            // 
            this.LblErrorMessageMotPasse.AutoSize = true;
            this.LblErrorMessageMotPasse.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessageMotPasse.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessageMotPasse.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessageMotPasse.Location = new System.Drawing.Point(323, 192);
            this.LblErrorMessageMotPasse.Name = "LblErrorMessageMotPasse";
            this.LblErrorMessageMotPasse.Size = new System.Drawing.Size(211, 17);
            this.LblErrorMessageMotPasse.TabIndex = 67;
            this.LblErrorMessageMotPasse.Text = "Veuillez entrer le mot de passe !";
            this.LblErrorMessageMotPasse.Visible = false;
            // 
            // LblErrorMessageNom
            // 
            this.LblErrorMessageNom.AutoSize = true;
            this.LblErrorMessageNom.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessageNom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessageNom.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessageNom.Location = new System.Drawing.Point(54, 192);
            this.LblErrorMessageNom.Name = "LblErrorMessageNom";
            this.LblErrorMessageNom.Size = new System.Drawing.Size(153, 17);
            this.LblErrorMessageNom.TabIndex = 66;
            this.LblErrorMessageNom.Text = "Veuillez entrer le nom !";
            this.LblErrorMessageNom.Visible = false;
            // 
            // LblErrorMessageCIN
            // 
            this.LblErrorMessageCIN.AutoSize = true;
            this.LblErrorMessageCIN.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessageCIN.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessageCIN.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessageCIN.Location = new System.Drawing.Point(54, 112);
            this.LblErrorMessageCIN.Name = "LblErrorMessageCIN";
            this.LblErrorMessageCIN.Size = new System.Drawing.Size(147, 17);
            this.LblErrorMessageCIN.TabIndex = 65;
            this.LblErrorMessageCIN.Text = "Veuillez entrer le CIN !";
            this.LblErrorMessageCIN.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(323, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Rôle";
            // 
            // RDGerant
            // 
            this.RDGerant.AutoSize = true;
            this.RDGerant.BackColor = System.Drawing.Color.Transparent;
            this.RDGerant.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDGerant.CheckedState.BorderThickness = 0;
            this.RDGerant.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDGerant.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RDGerant.CheckedState.InnerOffset = -4;
            this.RDGerant.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDGerant.ForeColor = System.Drawing.Color.Black;
            this.RDGerant.Location = new System.Drawing.Point(390, 240);
            this.RDGerant.Name = "RDGerant";
            this.RDGerant.Size = new System.Drawing.Size(68, 21);
            this.RDGerant.TabIndex = 25;
            this.RDGerant.TabStop = true;
            this.RDGerant.Text = "Gérant";
            this.RDGerant.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RDGerant.UncheckedState.BorderThickness = 2;
            this.RDGerant.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RDGerant.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RDGerant.UseVisualStyleBackColor = false;
            // 
            // RDCaissier
            // 
            this.RDCaissier.AutoSize = true;
            this.RDCaissier.BackColor = System.Drawing.Color.Transparent;
            this.RDCaissier.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDCaissier.CheckedState.BorderThickness = 0;
            this.RDCaissier.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDCaissier.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RDCaissier.CheckedState.InnerOffset = -4;
            this.RDCaissier.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDCaissier.ForeColor = System.Drawing.Color.Black;
            this.RDCaissier.Location = new System.Drawing.Point(464, 240);
            this.RDCaissier.Name = "RDCaissier";
            this.RDCaissier.Size = new System.Drawing.Size(71, 21);
            this.RDCaissier.TabIndex = 24;
            this.RDCaissier.TabStop = true;
            this.RDCaissier.Text = "Caissier";
            this.RDCaissier.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RDCaissier.UncheckedState.BorderThickness = 2;
            this.RDCaissier.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RDCaissier.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RDCaissier.UseVisualStyleBackColor = false;
            // 
            // RDAdmin
            // 
            this.RDAdmin.AutoSize = true;
            this.RDAdmin.BackColor = System.Drawing.Color.Transparent;
            this.RDAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDAdmin.CheckedState.BorderThickness = 0;
            this.RDAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RDAdmin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RDAdmin.CheckedState.InnerOffset = -4;
            this.RDAdmin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDAdmin.ForeColor = System.Drawing.Color.Black;
            this.RDAdmin.Location = new System.Drawing.Point(320, 240);
            this.RDAdmin.Name = "RDAdmin";
            this.RDAdmin.Size = new System.Drawing.Size(64, 21);
            this.RDAdmin.TabIndex = 23;
            this.RDAdmin.TabStop = true;
            this.RDAdmin.Text = "Admin";
            this.RDAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RDAdmin.UncheckedState.BorderThickness = 2;
            this.RDAdmin.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RDAdmin.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RDAdmin.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(323, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mot de passe";
            // 
            // TxtMotPasse
            // 
            this.TxtMotPasse.BackColor = System.Drawing.Color.Transparent;
            this.TxtMotPasse.BorderColor = System.Drawing.Color.Silver;
            this.TxtMotPasse.BorderRadius = 10;
            this.TxtMotPasse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMotPasse.DefaultText = "";
            this.TxtMotPasse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtMotPasse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtMotPasse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMotPasse.DisabledState.Parent = this.TxtMotPasse;
            this.TxtMotPasse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMotPasse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMotPasse.FocusedState.Parent = this.TxtMotPasse;
            this.TxtMotPasse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMotPasse.HoverState.Parent = this.TxtMotPasse;
            this.TxtMotPasse.Location = new System.Drawing.Point(319, 152);
            this.TxtMotPasse.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TxtMotPasse.Name = "TxtMotPasse";
            this.TxtMotPasse.PasswordChar = '\0';
            this.TxtMotPasse.PlaceholderText = "";
            this.TxtMotPasse.SelectedText = "";
            this.TxtMotPasse.ShadowDecoration.Parent = this.TxtMotPasse;
            this.TxtMotPasse.Size = new System.Drawing.Size(215, 37);
            this.TxtMotPasse.TabIndex = 3;
            this.TxtMotPasse.TextChanged += new System.EventHandler(this.TxtMotPasse_TextChanged);
            this.TxtMotPasse.Leave += new System.EventHandler(this.TxtMotPasse_Leave);
            this.TxtMotPasse.MouseHover += new System.EventHandler(this.TxtMotPasse_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(323, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date d\'inscription";
            // 
            // DPDateInscription
            // 
            this.DPDateInscription.BackColor = System.Drawing.Color.Transparent;
            this.DPDateInscription.BorderRadius = 10;
            this.DPDateInscription.CheckedState.Parent = this.DPDateInscription;
            this.DPDateInscription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DPDateInscription.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPDateInscription.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DPDateInscription.HoverState.Parent = this.DPDateInscription;
            this.DPDateInscription.Location = new System.Drawing.Point(320, 72);
            this.DPDateInscription.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DPDateInscription.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DPDateInscription.Name = "DPDateInscription";
            this.DPDateInscription.ShadowDecoration.Parent = this.DPDateInscription;
            this.DPDateInscription.Size = new System.Drawing.Size(215, 37);
            this.DPDateInscription.TabIndex = 19;
            this.DPDateInscription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DPDateInscription.Value = new System.DateTime(2022, 10, 11, 22, 8, 9, 320);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(54, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Prénom";
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
            this.TxtPrenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrenom.HoverState.Parent = this.TxtPrenom;
            this.TxtPrenom.Location = new System.Drawing.Point(47, 233);
            this.TxtPrenom.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.PasswordChar = '\0';
            this.TxtPrenom.PlaceholderText = "";
            this.TxtPrenom.SelectedText = "";
            this.TxtPrenom.ShadowDecoration.Parent = this.TxtPrenom;
            this.TxtPrenom.Size = new System.Drawing.Size(215, 37);
            this.TxtPrenom.TabIndex = 2;
            this.TxtPrenom.TextChanged += new System.EventHandler(this.TxtPrenom_TextChanged);
            this.TxtPrenom.Leave += new System.EventHandler(this.TxtPrenom_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(54, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nom";
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
            this.TxtNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNom.HoverState.Parent = this.TxtNom;
            this.TxtNom.Location = new System.Drawing.Point(47, 152);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.PasswordChar = '\0';
            this.TxtNom.PlaceholderText = "";
            this.TxtNom.SelectedText = "";
            this.TxtNom.ShadowDecoration.Parent = this.TxtNom;
            this.TxtNom.Size = new System.Drawing.Size(215, 37);
            this.TxtNom.TabIndex = 1;
            this.TxtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
            this.TxtNom.Leave += new System.EventHandler(this.TxtNom_Leave);
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
            this.BtnModifier.Location = new System.Drawing.Point(608, 144);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.ShadowDecoration.Parent = this.BtnModifier;
            this.BtnModifier.Size = new System.Drawing.Size(136, 40);
            this.BtnModifier.TabIndex = 14;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
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
            this.BtnSupprimer.Location = new System.Drawing.Point(608, 190);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.ShadowDecoration.Parent = this.BtnSupprimer;
            this.BtnSupprimer.Size = new System.Drawing.Size(136, 40);
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
            this.BtnAjouter.Location = new System.Drawing.Point(608, 98);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.ShadowDecoration.Parent = this.BtnAjouter;
            this.BtnAjouter.Size = new System.Drawing.Size(136, 40);
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
            this.label1.Location = new System.Drawing.Point(54, 51);
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
            this.TxtCIN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCIN.HoverState.Parent = this.TxtCIN;
            this.TxtCIN.Location = new System.Drawing.Point(47, 72);
            this.TxtCIN.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCIN.Name = "TxtCIN";
            this.TxtCIN.PasswordChar = '\0';
            this.TxtCIN.PlaceholderText = "";
            this.TxtCIN.SelectedText = "";
            this.TxtCIN.ShadowDecoration.Parent = this.TxtCIN;
            this.TxtCIN.Size = new System.Drawing.Size(215, 37);
            this.TxtCIN.TabIndex = 0;
            this.TxtCIN.TextChanged += new System.EventHandler(this.TxtCIN_TextChanged);
            this.TxtCIN.Leave += new System.EventHandler(this.TxtCIN_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 1);
            this.panel1.TabIndex = 18;
            // 
            // GestionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.GroupBoxCategorie);
            this.Name = "GestionUtilisateur";
            this.Size = new System.Drawing.Size(817, 517);
            this.Load += new System.EventHandler(this.GestionUtilisateur_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUtilisateurs)).EndInit();
            this.PnlProfile.ResumeLayout(false);
            this.GroupBoxCategorie.ResumeLayout(false);
            this.GroupBoxCategorie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DGVUtilisateurs;
        private Guna.UI2.WinForms.Guna2Button BtnModifier;
        private Guna.UI2.WinForms.Guna2Button BtnSupprimer;
        private Guna.UI2.WinForms.Guna2Button BtnAjouter;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtCIN;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2RadioButton RDGerant;
        private Guna.UI2.WinForms.Guna2RadioButton RDCaissier;
        private Guna.UI2.WinForms.Guna2RadioButton RDAdmin;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TxtMotPasse;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker DPDateInscription;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TxtPrenom;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxtNom;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button BtnParametre;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button BtnQuitter;
        public System.Windows.Forms.Panel PnlProfile;
        public Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        public Guna.UI2.WinForms.Guna2GroupBox GroupBoxCategorie;
        private Guna.UI2.WinForms.Guna2Button BtnDeconnecter;
        private System.Windows.Forms.Label LblErrorMessageRole;
        private System.Windows.Forms.Label LblErrorMessagePrenom;
        private System.Windows.Forms.Label LblErrorMessageMotPasse;
        private System.Windows.Forms.Label LblErrorMessageNom;
        private System.Windows.Forms.Label LblErrorMessageCIN;
        //private Classes.myDatagridView myDatagridView1;
    }
}

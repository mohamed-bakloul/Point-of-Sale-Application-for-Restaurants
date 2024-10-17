
namespace FastFoodDemo.User_Controls
{
    partial class GestionImprimantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionImprimantes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GroupBoxCategorie = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LblErrorMessage = new System.Windows.Forms.Label();
            this.BtnModifier = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbEmplacement = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVListeImprimantes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DGVListeImprimanteParCategories = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BtnEnregistrer = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbCategories = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbImprimantes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GroupBoxCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeImprimantes)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeImprimanteParCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 1);
            this.panel2.TabIndex = 21;
            // 
            // GroupBoxCategorie
            // 
            this.GroupBoxCategorie.BorderRadius = 10;
            this.GroupBoxCategorie.Controls.Add(this.LblErrorMessage);
            this.GroupBoxCategorie.Controls.Add(this.BtnModifier);
            this.GroupBoxCategorie.Controls.Add(this.BtnAjouter);
            this.GroupBoxCategorie.Controls.Add(this.label8);
            this.GroupBoxCategorie.Controls.Add(this.CmbEmplacement);
            this.GroupBoxCategorie.Controls.Add(this.label2);
            this.GroupBoxCategorie.Controls.Add(this.TxtNom);
            this.GroupBoxCategorie.Controls.Add(this.label1);
            this.GroupBoxCategorie.Controls.Add(this.DGVListeImprimantes);
            this.GroupBoxCategorie.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBoxCategorie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCategorie.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCategorie.Location = new System.Drawing.Point(14, 12);
            this.GroupBoxCategorie.Name = "GroupBoxCategorie";
            this.GroupBoxCategorie.ShadowDecoration.Parent = this.GroupBoxCategorie;
            this.GroupBoxCategorie.Size = new System.Drawing.Size(843, 275);
            this.GroupBoxCategorie.TabIndex = 20;
            this.GroupBoxCategorie.Text = "Gestion d\'imprimantes";
            // 
            // LblErrorMessage
            // 
            this.LblErrorMessage.AutoSize = true;
            this.LblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblErrorMessage.ForeColor = System.Drawing.Color.Crimson;
            this.LblErrorMessage.Location = new System.Drawing.Point(48, 184);
            this.LblErrorMessage.Name = "LblErrorMessage";
            this.LblErrorMessage.Size = new System.Drawing.Size(153, 17);
            this.LblErrorMessage.TabIndex = 63;
            this.LblErrorMessage.Text = "Veuillez entrer le nom !";
            this.LblErrorMessage.Visible = false;
            // 
            // BtnModifier
            // 
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
            this.BtnModifier.Location = new System.Drawing.Point(159, 209);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.ShadowDecoration.Parent = this.BtnModifier;
            this.BtnModifier.Size = new System.Drawing.Size(120, 40);
            this.BtnModifier.TabIndex = 62;
            this.BtnModifier.Text = "Modifier";
            // 
            // BtnAjouter
            // 
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
            this.BtnAjouter.Location = new System.Drawing.Point(34, 209);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.ShadowDecoration.Parent = this.BtnAjouter;
            this.BtnAjouter.Size = new System.Drawing.Size(120, 40);
            this.BtnAjouter.TabIndex = 61;
            this.BtnAjouter.Text = "Ajouter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(48, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Emplacement";
            // 
            // CmbEmplacement
            // 
            this.CmbEmplacement.BackColor = System.Drawing.Color.Transparent;
            this.CmbEmplacement.BorderRadius = 10;
            this.CmbEmplacement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbEmplacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmplacement.FocusedColor = System.Drawing.Color.Empty;
            this.CmbEmplacement.FocusedState.Parent = this.CmbEmplacement;
            this.CmbEmplacement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbEmplacement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbEmplacement.FormattingEnabled = true;
            this.CmbEmplacement.HoverState.Parent = this.CmbEmplacement;
            this.CmbEmplacement.ItemHeight = 30;
            this.CmbEmplacement.ItemsAppearance.Parent = this.CmbEmplacement;
            this.CmbEmplacement.Location = new System.Drawing.Point(44, 79);
            this.CmbEmplacement.Name = "CmbEmplacement";
            this.CmbEmplacement.ShadowDecoration.Parent = this.CmbEmplacement;
            this.CmbEmplacement.Size = new System.Drawing.Size(225, 36);
            this.CmbEmplacement.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 58;
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
            this.TxtNom.Font = new System.Drawing.Font("Segoe UI", 9.3F);
            this.TxtNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNom.HoverState.Parent = this.TxtNom;
            this.TxtNom.Location = new System.Drawing.Point(44, 144);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(5);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.PasswordChar = '\0';
            this.TxtNom.PlaceholderText = "";
            this.TxtNom.SelectedText = "";
            this.TxtNom.ShadowDecoration.Parent = this.TxtNom;
            this.TxtNom.Size = new System.Drawing.Size(225, 37);
            this.TxtNom.TabIndex = 57;
            this.TxtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(347, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "Liste d\'imprimantes";
            // 
            // DGVListeImprimantes
            // 
            this.DGVListeImprimantes.AllowUserToAddRows = false;
            this.DGVListeImprimantes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DGVListeImprimantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVListeImprimantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVListeImprimantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVListeImprimantes.BackgroundColor = System.Drawing.Color.White;
            this.DGVListeImprimantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVListeImprimantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVListeImprimantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListeImprimantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVListeImprimantes.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListeImprimantes.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVListeImprimantes.EnableHeadersVisualStyles = false;
            this.DGVListeImprimantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeImprimantes.Location = new System.Drawing.Point(345, 80);
            this.DGVListeImprimantes.Name = "DGVListeImprimantes";
            this.DGVListeImprimantes.ReadOnly = true;
            this.DGVListeImprimantes.RowHeadersVisible = false;
            this.DGVListeImprimantes.RowTemplate.Height = 30;
            this.DGVListeImprimantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListeImprimantes.Size = new System.Drawing.Size(466, 171);
            this.DGVListeImprimantes.TabIndex = 55;
            this.DGVListeImprimantes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVListeImprimantes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeImprimantes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVListeImprimantes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVListeImprimantes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVListeImprimantes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVListeImprimantes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeImprimantes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeImprimantes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DGVListeImprimantes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVListeImprimantes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListeImprimantes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVListeImprimantes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVListeImprimantes.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVListeImprimantes.ThemeStyle.ReadOnly = true;
            this.DGVListeImprimantes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeImprimantes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVListeImprimantes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListeImprimantes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVListeImprimantes.ThemeStyle.RowsStyle.Height = 30;
            this.DGVListeImprimantes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeImprimantes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVListeImprimantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListeImprimantes_CellDoubleClick);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.DGVListeImprimanteParCategories);
            this.guna2GroupBox1.Controls.Add(this.BtnEnregistrer);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.CmbCategories);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.CmbImprimantes);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(14, 296);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(843, 244);
            this.guna2GroupBox1.TabIndex = 55;
            this.guna2GroupBox1.Text = "Imprimante par catégories";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.6F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(347, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 18);
            this.label5.TabIndex = 58;
            this.label5.Text = "Liste d\'imprimante par catégories";
            // 
            // DGVListeImprimanteParCategories
            // 
            this.DGVListeImprimanteParCategories.AllowUserToAddRows = false;
            this.DGVListeImprimanteParCategories.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DGVListeImprimanteParCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVListeImprimanteParCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVListeImprimanteParCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVListeImprimanteParCategories.BackgroundColor = System.Drawing.Color.White;
            this.DGVListeImprimanteParCategories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVListeImprimanteParCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVListeImprimanteParCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListeImprimanteParCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVListeImprimanteParCategories.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListeImprimanteParCategories.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVListeImprimanteParCategories.EnableHeadersVisualStyles = false;
            this.DGVListeImprimanteParCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeImprimanteParCategories.Location = new System.Drawing.Point(345, 74);
            this.DGVListeImprimanteParCategories.Name = "DGVListeImprimanteParCategories";
            this.DGVListeImprimanteParCategories.ReadOnly = true;
            this.DGVListeImprimanteParCategories.RowHeadersVisible = false;
            this.DGVListeImprimanteParCategories.RowTemplate.Height = 30;
            this.DGVListeImprimanteParCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListeImprimanteParCategories.Size = new System.Drawing.Size(466, 159);
            this.DGVListeImprimanteParCategories.TabIndex = 57;
            this.DGVListeImprimanteParCategories.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVListeImprimanteParCategories.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeImprimanteParCategories.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVListeImprimanteParCategories.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVListeImprimanteParCategories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVListeImprimanteParCategories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVListeImprimanteParCategories.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeImprimanteParCategories.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeImprimanteParCategories.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DGVListeImprimanteParCategories.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVListeImprimanteParCategories.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListeImprimanteParCategories.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVListeImprimanteParCategories.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVListeImprimanteParCategories.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVListeImprimanteParCategories.ThemeStyle.ReadOnly = true;
            this.DGVListeImprimanteParCategories.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeImprimanteParCategories.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVListeImprimanteParCategories.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListeImprimanteParCategories.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVListeImprimanteParCategories.ThemeStyle.RowsStyle.Height = 30;
            this.DGVListeImprimanteParCategories.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeImprimanteParCategories.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // BtnEnregistrer
            // 
            this.BtnEnregistrer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnEnregistrer.BackColor = System.Drawing.Color.Transparent;
            this.BtnEnregistrer.BorderRadius = 10;
            this.BtnEnregistrer.CheckedState.Parent = this.BtnEnregistrer;
            this.BtnEnregistrer.CustomImages.Parent = this.BtnEnregistrer;
            this.BtnEnregistrer.FillColor = System.Drawing.Color.SteelBlue;
            this.BtnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.BtnEnregistrer.HoverState.Parent = this.BtnEnregistrer;
            this.BtnEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("BtnEnregistrer.Image")));
            this.BtnEnregistrer.ImageSize = new System.Drawing.Size(22, 22);
            this.BtnEnregistrer.Location = new System.Drawing.Point(86, 191);
            this.BtnEnregistrer.Name = "BtnEnregistrer";
            this.BtnEnregistrer.ShadowDecoration.Parent = this.BtnEnregistrer;
            this.BtnEnregistrer.Size = new System.Drawing.Size(141, 40);
            this.BtnEnregistrer.TabIndex = 55;
            this.BtnEnregistrer.Text = "Enregistrer";
            this.BtnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(48, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Catégories";
            // 
            // CmbCategories
            // 
            this.CmbCategories.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.CmbCategories.Location = new System.Drawing.Point(44, 145);
            this.CmbCategories.Name = "CmbCategories";
            this.CmbCategories.ShadowDecoration.Parent = this.CmbCategories;
            this.CmbCategories.Size = new System.Drawing.Size(225, 36);
            this.CmbCategories.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(50, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Imprimantes";
            // 
            // CmbImprimantes
            // 
            this.CmbImprimantes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CmbImprimantes.BackColor = System.Drawing.Color.Transparent;
            this.CmbImprimantes.BorderRadius = 10;
            this.CmbImprimantes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbImprimantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbImprimantes.FocusedColor = System.Drawing.Color.Empty;
            this.CmbImprimantes.FocusedState.Parent = this.CmbImprimantes;
            this.CmbImprimantes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbImprimantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbImprimantes.FormattingEnabled = true;
            this.CmbImprimantes.HoverState.Parent = this.CmbImprimantes;
            this.CmbImprimantes.ItemHeight = 30;
            this.CmbImprimantes.ItemsAppearance.Parent = this.CmbImprimantes;
            this.CmbImprimantes.Location = new System.Drawing.Point(44, 76);
            this.CmbImprimantes.Name = "CmbImprimantes";
            this.CmbImprimantes.ShadowDecoration.Parent = this.CmbImprimantes;
            this.CmbImprimantes.Size = new System.Drawing.Size(225, 36);
            this.CmbImprimantes.TabIndex = 35;
            // 
            // GestionImprimantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GroupBoxCategorie);
            this.Name = "GestionImprimantes";
            this.Size = new System.Drawing.Size(870, 551);
            this.Load += new System.EventHandler(this.GestionImprimantes_Load);
            this.GroupBoxCategorie.ResumeLayout(false);
            this.GroupBoxCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeImprimantes)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeImprimanteParCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button BtnEnregistrer;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox CmbCategories;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox CmbImprimantes;
        private Guna.UI2.WinForms.Guna2Button BtnModifier;
        private Guna.UI2.WinForms.Guna2Button BtnAjouter;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox CmbEmplacement;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxtNom;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DGVListeImprimantes;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView DGVListeImprimanteParCategories;
        public Guna.UI2.WinForms.Guna2GroupBox GroupBoxCategorie;
        public Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label LblErrorMessage;
    }
}

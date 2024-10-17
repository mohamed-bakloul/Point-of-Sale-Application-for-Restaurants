
namespace FastFoodDemo.User_Controls
{
    partial class Benefice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Benefice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBoxCategorie = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LblBenefice = new System.Windows.Forms.Label();
            this.LblTotalCharges = new System.Windows.Forms.Label();
            this.LblTotalVentes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DPDateDebut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DPDateFin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnImprimer = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVListeCharges = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVListeCommandes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BtnRechercher = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GroupBoxCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeCharges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeCommandes)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxCategorie
            // 
            this.GroupBoxCategorie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBoxCategorie.BorderRadius = 10;
            this.GroupBoxCategorie.Controls.Add(this.LblBenefice);
            this.GroupBoxCategorie.Controls.Add(this.LblTotalCharges);
            this.GroupBoxCategorie.Controls.Add(this.LblTotalVentes);
            this.GroupBoxCategorie.Controls.Add(this.label7);
            this.GroupBoxCategorie.Controls.Add(this.label6);
            this.GroupBoxCategorie.Controls.Add(this.label5);
            this.GroupBoxCategorie.Controls.Add(this.label2);
            this.GroupBoxCategorie.Controls.Add(this.DPDateDebut);
            this.GroupBoxCategorie.Controls.Add(this.label4);
            this.GroupBoxCategorie.Controls.Add(this.DPDateFin);
            this.GroupBoxCategorie.Controls.Add(this.BtnImprimer);
            this.GroupBoxCategorie.Controls.Add(this.label3);
            this.GroupBoxCategorie.Controls.Add(this.DGVListeCharges);
            this.GroupBoxCategorie.Controls.Add(this.label1);
            this.GroupBoxCategorie.Controls.Add(this.DGVListeCommandes);
            this.GroupBoxCategorie.Controls.Add(this.BtnRechercher);
            this.GroupBoxCategorie.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GroupBoxCategorie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCategorie.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCategorie.Location = new System.Drawing.Point(13, 11);
            this.GroupBoxCategorie.Name = "GroupBoxCategorie";
            this.GroupBoxCategorie.ShadowDecoration.Parent = this.GroupBoxCategorie;
            this.GroupBoxCategorie.Size = new System.Drawing.Size(790, 555);
            this.GroupBoxCategorie.TabIndex = 31;
            this.GroupBoxCategorie.Text = "Bénéfice";
            // 
            // LblBenefice
            // 
            this.LblBenefice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblBenefice.AutoSize = true;
            this.LblBenefice.BackColor = System.Drawing.Color.Transparent;
            this.LblBenefice.Font = new System.Drawing.Font("Century Gothic", 10.6F);
            this.LblBenefice.ForeColor = System.Drawing.Color.Sienna;
            this.LblBenefice.Location = new System.Drawing.Point(677, 522);
            this.LblBenefice.Name = "LblBenefice";
            this.LblBenefice.Size = new System.Drawing.Size(67, 20);
            this.LblBenefice.TabIndex = 44;
            this.LblBenefice.Text = "0.00 Dhs";
            // 
            // LblTotalCharges
            // 
            this.LblTotalCharges.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblTotalCharges.AutoSize = true;
            this.LblTotalCharges.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalCharges.Font = new System.Drawing.Font("Century Gothic", 10.6F);
            this.LblTotalCharges.ForeColor = System.Drawing.Color.Crimson;
            this.LblTotalCharges.Location = new System.Drawing.Point(448, 522);
            this.LblTotalCharges.Name = "LblTotalCharges";
            this.LblTotalCharges.Size = new System.Drawing.Size(67, 20);
            this.LblTotalCharges.TabIndex = 43;
            this.LblTotalCharges.Text = "0.00 Dhs";
            // 
            // LblTotalVentes
            // 
            this.LblTotalVentes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblTotalVentes.AutoSize = true;
            this.LblTotalVentes.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalVentes.Font = new System.Drawing.Font("Century Gothic", 10.6F);
            this.LblTotalVentes.ForeColor = System.Drawing.Color.SeaGreen;
            this.LblTotalVentes.Location = new System.Drawing.Point(170, 522);
            this.LblTotalVentes.Name = "LblTotalVentes";
            this.LblTotalVentes.Size = new System.Drawing.Size(67, 20);
            this.LblTotalVentes.TabIndex = 42;
            this.LblTotalVentes.Text = "0.00 Dhs";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.6F);
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(594, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Bénéfice :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.6F);
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(306, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Total des charges :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.6F);
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(38, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Total des ventes :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(141, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 38;
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
            this.DPDateDebut.Location = new System.Drawing.Point(138, 74);
            this.DPDateDebut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DPDateDebut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DPDateDebut.Name = "DPDateDebut";
            this.DPDateDebut.ShadowDecoration.Parent = this.DPDateDebut;
            this.DPDateDebut.Size = new System.Drawing.Size(215, 37);
            this.DPDateDebut.TabIndex = 37;
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
            this.label4.Location = new System.Drawing.Point(441, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 36;
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
            this.DPDateFin.Location = new System.Drawing.Point(438, 74);
            this.DPDateFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DPDateFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DPDateFin.Name = "DPDateFin";
            this.DPDateFin.ShadowDecoration.Parent = this.DPDateFin;
            this.DPDateFin.Size = new System.Drawing.Size(215, 37);
            this.DPDateFin.TabIndex = 35;
            this.DPDateFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DPDateFin.Value = new System.DateTime(2022, 10, 11, 22, 8, 9, 320);
            // 
            // BtnImprimer
            // 
            this.BtnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImprimer.BackColor = System.Drawing.Color.Transparent;
            this.BtnImprimer.BorderRadius = 10;
            this.BtnImprimer.CheckedState.Parent = this.BtnImprimer;
            this.BtnImprimer.CustomImages.Parent = this.BtnImprimer;
            this.BtnImprimer.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnImprimer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimer.ForeColor = System.Drawing.Color.White;
            this.BtnImprimer.HoverState.Parent = this.BtnImprimer;
            this.BtnImprimer.Image = ((System.Drawing.Image)(resources.GetObject("BtnImprimer.Image")));
            this.BtnImprimer.ImageOffset = new System.Drawing.Point(-1, 0);
            this.BtnImprimer.Location = new System.Drawing.Point(607, 139);
            this.BtnImprimer.Name = "BtnImprimer";
            this.BtnImprimer.ShadowDecoration.Parent = this.BtnImprimer;
            this.BtnImprimer.Size = new System.Drawing.Size(150, 40);
            this.BtnImprimer.TabIndex = 34;
            this.BtnImprimer.Text = "Imprimer";
            this.BtnImprimer.TextOffset = new System.Drawing.Point(1, 0);
            this.BtnImprimer.Click += new System.EventHandler(this.BtnImprimer_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.6F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Liste des charges";
            // 
            // DGVListeCharges
            // 
            this.DGVListeCharges.AllowUserToAddRows = false;
            this.DGVListeCharges.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVListeCharges.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVListeCharges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVListeCharges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVListeCharges.BackgroundColor = System.Drawing.Color.White;
            this.DGVListeCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVListeCharges.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVListeCharges.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListeCharges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVListeCharges.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListeCharges.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVListeCharges.EnableHeadersVisualStyles = false;
            this.DGVListeCharges.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeCharges.Location = new System.Drawing.Point(33, 359);
            this.DGVListeCharges.Name = "DGVListeCharges";
            this.DGVListeCharges.ReadOnly = true;
            this.DGVListeCharges.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DGVListeCharges.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVListeCharges.RowTemplate.Height = 30;
            this.DGVListeCharges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListeCharges.Size = new System.Drawing.Size(724, 145);
            this.DGVListeCharges.TabIndex = 27;
            this.DGVListeCharges.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DGVListeCharges.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeCharges.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVListeCharges.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVListeCharges.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVListeCharges.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVListeCharges.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeCharges.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeCharges.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DGVListeCharges.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVListeCharges.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListeCharges.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVListeCharges.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVListeCharges.ThemeStyle.HeaderStyle.Height = 35;
            this.DGVListeCharges.ThemeStyle.ReadOnly = true;
            this.DGVListeCharges.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVListeCharges.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVListeCharges.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVListeCharges.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DGVListeCharges.ThemeStyle.RowsStyle.Height = 30;
            this.DGVListeCharges.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeCharges.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.6F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Liste des commandes";
            // 
            // DGVListeCommandes
            // 
            this.DGVListeCommandes.AllowUserToAddRows = false;
            this.DGVListeCommandes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.DGVListeCommandes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVListeCommandes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVListeCommandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVListeCommandes.BackgroundColor = System.Drawing.Color.White;
            this.DGVListeCommandes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVListeCommandes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVListeCommandes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVListeCommandes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVListeCommandes.ColumnHeadersHeight = 35;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVListeCommandes.DefaultCellStyle = dataGridViewCellStyle7;
            this.DGVListeCommandes.EnableHeadersVisualStyles = false;
            this.DGVListeCommandes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeCommandes.Location = new System.Drawing.Point(33, 186);
            this.DGVListeCommandes.Name = "DGVListeCommandes";
            this.DGVListeCommandes.ReadOnly = true;
            this.DGVListeCommandes.RowHeadersVisible = false;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.DGVListeCommandes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVListeCommandes.RowTemplate.Height = 30;
            this.DGVListeCommandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListeCommandes.Size = new System.Drawing.Size(724, 145);
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
            this.DGVListeCommandes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DGVListeCommandes.ThemeStyle.RowsStyle.Height = 30;
            this.DGVListeCommandes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVListeCommandes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.BtnRechercher.Location = new System.Drawing.Point(451, 139);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.ShadowDecoration.Parent = this.BtnRechercher;
            this.BtnRechercher.Size = new System.Drawing.Size(150, 40);
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
            this.panel2.TabIndex = 30;
            // 
            // Benefice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxCategorie);
            this.Controls.Add(this.panel2);
            this.Name = "Benefice";
            this.Size = new System.Drawing.Size(817, 575);
            this.Load += new System.EventHandler(this.Benefice_Load);
            this.GroupBoxCategorie.ResumeLayout(false);
            this.GroupBoxCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeCharges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListeCommandes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button BtnImprimer;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView DGVListeCharges;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DGVListeCommandes;
        private Guna.UI2.WinForms.Guna2Button BtnRechercher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DPDateDebut;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker DPDateFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblBenefice;
        private System.Windows.Forms.Label LblTotalCharges;
        private System.Windows.Forms.Label LblTotalVentes;
        public Guna.UI2.WinForms.Guna2GroupBox GroupBoxCategorie;
    }
}

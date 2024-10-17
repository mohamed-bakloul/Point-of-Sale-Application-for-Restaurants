
namespace FastFoodDemo.User_Controls
{
    partial class GestionCatProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCatProd));
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.BtnGestFournisseur = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGestProd = new Guna.UI2.WinForms.Guna2Button();
            this.BtnGestCat = new Guna.UI2.WinForms.Guna2Button();
            this.PnlAffichage = new Guna.UI2.WinForms.Guna2Panel();
            this.PnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.Controls.Add(this.BtnGestFournisseur);
            this.PnlHeader.Controls.Add(this.panel1);
            this.PnlHeader.Controls.Add(this.BtnGestProd);
            this.PnlHeader.Controls.Add(this.BtnGestCat);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(817, 70);
            this.PnlHeader.TabIndex = 0;
            // 
            // BtnGestFournisseur
            // 
            this.BtnGestFournisseur.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnGestFournisseur.BackColor = System.Drawing.Color.Transparent;
            this.BtnGestFournisseur.BorderColor = System.Drawing.Color.Silver;
            this.BtnGestFournisseur.BorderRadius = 5;
            this.BtnGestFournisseur.BorderThickness = 1;
            this.BtnGestFournisseur.CheckedState.Parent = this.BtnGestFournisseur;
            this.BtnGestFournisseur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGestFournisseur.CustomImages.Parent = this.BtnGestFournisseur;
            this.BtnGestFournisseur.FillColor = System.Drawing.Color.Transparent;
            this.BtnGestFournisseur.Font = new System.Drawing.Font("Century Gothic", 9.4F);
            this.BtnGestFournisseur.ForeColor = System.Drawing.Color.Black;
            this.BtnGestFournisseur.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("BtnGestFournisseur.HoverState.Image")));
            this.BtnGestFournisseur.HoverState.Parent = this.BtnGestFournisseur;
            this.BtnGestFournisseur.Image = ((System.Drawing.Image)(resources.GetObject("BtnGestFournisseur.Image")));
            this.BtnGestFournisseur.ImageOffset = new System.Drawing.Point(37, -8);
            this.BtnGestFournisseur.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnGestFournisseur.Location = new System.Drawing.Point(524, 9);
            this.BtnGestFournisseur.Name = "BtnGestFournisseur";
            this.BtnGestFournisseur.ShadowDecoration.Parent = this.BtnGestFournisseur;
            this.BtnGestFournisseur.Size = new System.Drawing.Size(205, 52);
            this.BtnGestFournisseur.TabIndex = 17;
            this.BtnGestFournisseur.Text = "Gestion des fournisseurs";
            this.BtnGestFournisseur.TextOffset = new System.Drawing.Point(-7, 15);
            this.BtnGestFournisseur.Visible = false;
            this.BtnGestFournisseur.Click += new System.EventHandler(this.BtnGestFournisseur_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(54)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 1);
            this.panel1.TabIndex = 16;
            // 
            // BtnGestProd
            // 
            this.BtnGestProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnGestProd.BackColor = System.Drawing.Color.Transparent;
            this.BtnGestProd.BorderColor = System.Drawing.Color.Silver;
            this.BtnGestProd.BorderRadius = 5;
            this.BtnGestProd.BorderThickness = 1;
            this.BtnGestProd.CheckedState.Parent = this.BtnGestProd;
            this.BtnGestProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGestProd.CustomImages.Parent = this.BtnGestProd;
            this.BtnGestProd.FillColor = System.Drawing.Color.Transparent;
            this.BtnGestProd.Font = new System.Drawing.Font("Century Gothic", 9.4F);
            this.BtnGestProd.ForeColor = System.Drawing.Color.Black;
            this.BtnGestProd.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("BtnGestProd.HoverState.Image")));
            this.BtnGestProd.HoverState.Parent = this.BtnGestProd;
            this.BtnGestProd.Image = ((System.Drawing.Image)(resources.GetObject("BtnGestProd.Image")));
            this.BtnGestProd.ImageOffset = new System.Drawing.Point(34, -8);
            this.BtnGestProd.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnGestProd.Location = new System.Drawing.Point(415, 9);
            this.BtnGestProd.Name = "BtnGestProd";
            this.BtnGestProd.ShadowDecoration.Parent = this.BtnGestProd;
            this.BtnGestProd.Size = new System.Drawing.Size(205, 52);
            this.BtnGestProd.TabIndex = 15;
            this.BtnGestProd.Text = "Gestion des produits";
            this.BtnGestProd.TextOffset = new System.Drawing.Point(-7, 15);
            this.BtnGestProd.Click += new System.EventHandler(this.BtnGestProd_Click);
            // 
            // BtnGestCat
            // 
            this.BtnGestCat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnGestCat.BackColor = System.Drawing.Color.Transparent;
            this.BtnGestCat.BorderColor = System.Drawing.Color.Silver;
            this.BtnGestCat.BorderRadius = 5;
            this.BtnGestCat.BorderThickness = 1;
            this.BtnGestCat.CheckedState.Parent = this.BtnGestCat;
            this.BtnGestCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGestCat.CustomImages.Parent = this.BtnGestCat;
            this.BtnGestCat.FillColor = System.Drawing.Color.Transparent;
            this.BtnGestCat.Font = new System.Drawing.Font("Century Gothic", 9.4F);
            this.BtnGestCat.ForeColor = System.Drawing.Color.Black;
            this.BtnGestCat.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("BtnGestCat.HoverState.Image")));
            this.BtnGestCat.HoverState.Parent = this.BtnGestCat;
            this.BtnGestCat.Image = ((System.Drawing.Image)(resources.GetObject("BtnGestCat.Image")));
            this.BtnGestCat.ImageOffset = new System.Drawing.Point(37, -8);
            this.BtnGestCat.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnGestCat.Location = new System.Drawing.Point(197, 9);
            this.BtnGestCat.Name = "BtnGestCat";
            this.BtnGestCat.ShadowDecoration.Parent = this.BtnGestCat;
            this.BtnGestCat.Size = new System.Drawing.Size(205, 52);
            this.BtnGestCat.TabIndex = 14;
            this.BtnGestCat.Text = "Gestion des catégories";
            this.BtnGestCat.TextOffset = new System.Drawing.Point(-7, 15);
            this.BtnGestCat.Click += new System.EventHandler(this.BtnGestCat_Click);
            // 
            // PnlAffichage
            // 
            this.PnlAffichage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAffichage.Location = new System.Drawing.Point(0, 70);
            this.PnlAffichage.Name = "PnlAffichage";
            this.PnlAffichage.ShadowDecoration.Parent = this.PnlAffichage;
            this.PnlAffichage.Size = new System.Drawing.Size(817, 447);
            this.PnlAffichage.TabIndex = 1;
            // 
            // GestionCatProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlAffichage);
            this.Controls.Add(this.PnlHeader);
            this.Name = "GestionCatProd";
            this.Size = new System.Drawing.Size(817, 517);
            this.Load += new System.EventHandler(this.GestionCatProd_Load);
            this.PnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private Guna.UI2.WinForms.Guna2Button BtnGestCat;
        private Guna.UI2.WinForms.Guna2Button BtnGestProd;
        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2Panel PnlAffichage;
        private Guna.UI2.WinForms.Guna2Button BtnGestFournisseur;
    }
}


namespace FastFoodDemo.User_Controls
{
    partial class Produit
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
            this.LblNomProduit = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.LblPrixProduit = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNomProduit
            // 
            this.LblNomProduit.BackColor = System.Drawing.Color.Transparent;
            this.LblNomProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNomProduit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomProduit.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.LblNomProduit.Location = new System.Drawing.Point(0, 0);
            this.LblNomProduit.Name = "LblNomProduit";
            this.LblNomProduit.Size = new System.Drawing.Size(114, 37);
            this.LblNomProduit.TabIndex = 4;
            this.LblNomProduit.Text = "Nom produit";
            this.LblNomProduit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.LblNomProduit);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(8, 22);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(114, 37);
            this.guna2ShadowPanel1.TabIndex = 2;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.LblPrixProduit);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(-1, -2);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(42, 25);
            this.guna2ShadowPanel2.TabIndex = 3;
            // 
            // LblPrixProduit
            // 
            this.LblPrixProduit.BackColor = System.Drawing.Color.Transparent;
            this.LblPrixProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPrixProduit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrixProduit.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.LblPrixProduit.Location = new System.Drawing.Point(0, 0);
            this.LblPrixProduit.Name = "LblPrixProduit";
            this.LblPrixProduit.Size = new System.Drawing.Size(42, 25);
            this.LblPrixProduit.TabIndex = 4;
            this.LblPrixProduit.Text = "Prix produit";
            this.LblPrixProduit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "Produit";
            this.Size = new System.Drawing.Size(130, 80);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LblNomProduit;
        public Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        public Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        public System.Windows.Forms.Label LblPrixProduit;
    }
}

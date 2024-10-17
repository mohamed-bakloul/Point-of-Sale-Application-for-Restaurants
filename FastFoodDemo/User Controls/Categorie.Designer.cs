
namespace FastFoodDemo.User_Controls
{
    partial class Categorie
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.LblNomCategorie = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.LblNomCategorie);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(5, 19);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(114, 37);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // LblNomCategorie
            // 
            this.LblNomCategorie.BackColor = System.Drawing.Color.Transparent;
            this.LblNomCategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNomCategorie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomCategorie.ForeColor = System.Drawing.Color.Black;
            this.LblNomCategorie.Location = new System.Drawing.Point(0, 0);
            this.LblNomCategorie.Name = "LblNomCategorie";
            this.LblNomCategorie.Size = new System.Drawing.Size(114, 37);
            this.LblNomCategorie.TabIndex = 4;
            this.LblNomCategorie.Text = "Nom catégorie";
            this.LblNomCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "Categorie";
            this.Size = new System.Drawing.Size(125, 75);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        public System.Windows.Forms.Label LblNomCategorie;
    }
}

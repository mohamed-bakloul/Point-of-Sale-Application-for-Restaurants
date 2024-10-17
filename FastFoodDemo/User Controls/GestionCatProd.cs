using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.User_Controls
{
    public partial class GestionCatProd : UserControl
    {
        public static GestionCatProd GestionCatProdInstance;

        public static GestionCatProd Instance
        {
            get
            {
                if (GestionCatProdInstance == null)
                {
                    GestionCatProdInstance = new GestionCatProd();
                }
                return GestionCatProdInstance;
            }
        }

        public GestionCatProd()
        {
            InitializeComponent();
            GestionCatProdInstance = this;
        }

        private void BtnGestCat_Click(object sender, EventArgs e)
        {
            if (!PnlAffichage.Controls.ContainsKey("GestionCategories"))
            {
                PnlAffichage.Controls.Remove(new GestionProduits());
                new GestionProduits().Dispose();
                PnlAffichage.Controls.Clear();
                PnlAffichage.Controls.Add(new GestionCategories());
            }
        }

        private void BtnGestProd_Click(object sender, EventArgs e)
        {
            if (!PnlAffichage.Controls.ContainsKey("GestionProduits"))
            {
                PnlAffichage.Controls.Remove(new GestionCategories());
                new GestionCategories().Dispose();
                PnlAffichage.Controls.Clear();
                PnlAffichage.Controls.Add(new GestionProduits());
            }
        }

        private void GestionCatProd_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void BtnGestFournisseur_Click(object sender, EventArgs e)
        {
            if (!PnlAffichage.Controls.ContainsKey("GestionFournisseur") && PnlAffichage.Controls.ContainsKey("GestionCategories") || PnlAffichage.Controls.ContainsKey("GestionProduits"))
            {
                if (PnlAffichage.Controls.ContainsKey("GestionCategories"))
                {
                    PnlAffichage.Controls.Remove(new GestionCategories());
                    new GestionCategories().Dispose();
                }

                if (PnlAffichage.Controls.ContainsKey("GestionProduits"))
                {
                    PnlAffichage.Controls.Remove(new GestionProduits());
                    new GestionProduits().Dispose();
                }

                PnlAffichage.Controls.Clear();
                PnlAffichage.Controls.Add(new GestionFournisseur());
            }
        }
    }
}
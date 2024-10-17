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
    public partial class Produit : UserControl
    {
        public Produit()
        {
            InitializeComponent();
        }

        public string NomProduits;
        public string PrixProduits;
        public Image ImageProduits;

        [Category("Custom Props")]
        public string nomProduits
        {
            get { return NomProduits; }
            set { NomProduits = value; LblNomProduit.Text = value; }
        }

        [Category("Custom Props")]
        public string prixProduits
        {
            get { return PrixProduits; }
            set { PrixProduits = value; LblPrixProduit.Text = value; }
        }

        [Category("Custom Props")]
        public Image imageProduits
        {
            get { return ImageProduits; }
            set { ImageProduits = value; this.BackgroundImage = value; }
        }

    }
}

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
    public partial class Categorie : UserControl
    {
        public Categorie()
        {
            InitializeComponent();
        }

        public string NomCategories;
        public Image ImageCategories;

        [Category("Custom Props")]
        public string nomCategories
        {
            get { return NomCategories; }
            set { NomCategories = value; LblNomCategorie.Text = value; }
        }

        [Category("Custom Props")]
        public Image imageCategories
        {
            get { return ImageCategories; }
            set { ImageCategories = value; this.BackgroundImage = value; }
        }

        private void roundPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
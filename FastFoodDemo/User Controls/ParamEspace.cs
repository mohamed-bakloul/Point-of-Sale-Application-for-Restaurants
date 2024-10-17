using FastFoodDemo.Classes;
using System;
using System.Windows.Forms;

namespace FastFoodDemo.User_Controls
{
    public partial class ParamEspace : UserControl
    {
        public static ParamEspace ParamInstance;

        public static ParamEspace Instance
        {
            get
            {
                if (ParamInstance == null)
                {
                    ParamInstance = new ParamEspace();
                }
                return ParamInstance;
            }
        }

        public ParamEspace()
        {
            InitializeComponent();
            ParamInstance = this;
        }

        ADO ADO = new ADO();

        private void GroupBoxCategorie_Click(object sender, EventArgs e)
        {

        }

        private void ParamEspace_Load(object sender, EventArgs e)
        {
            if (!ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
                BtnParametreTables.Enabled = false;
            PnlContainer.Controls.Add(new ParametreEspace());
            this.Dock = DockStyle.Fill;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {

        }

        private void BtnParcourir_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshReport_Click(object sender, EventArgs e)
        {

        }

        private void BtnPreviewReport_Click(object sender, EventArgs e)
        {

        }

        private void BtnParametreEspace_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("ParametreEspace"))
            {
                PnlContainer.Controls.Remove(new ParametreTables());
                new ParametreTables().Dispose();
                PnlContainer.Controls.Clear();
                PnlContainer.Controls.Add(new ParametreEspace());
            }
        }

        private void BtnParametreTables_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("ParametreTables"))
            {
                PnlContainer.Controls.Remove(new ParametreEspace());
                new ParametreEspace().Dispose();
                PnlContainer.Controls.Clear();
                PnlContainer.Controls.Add(new ParametreTables());
            }
        }

        private void BtnParametrePermissions_Click(object sender, EventArgs e)
        {
            //if (PnlContainer.Controls.ContainsKey("ParametreTables") || PnlContainer.Controls.ContainsKey("ParametreEspace") || PnlContainer.Controls.ContainsKey("ParametreEspace"))
            //{
            //    if (PnlContainer.Controls.ContainsKey("ParametreTables"))
            //    {
            //        PnlContainer.Controls.Remove(new ParametreTables());
            //        new ParametreTables().Dispose();
            //        PnlContainer.Controls.Clear();
            //        PnlContainer.Controls.Add(new ParametrePermissions());
            //    }
            //    else if (PnlContainer.Controls.ContainsKey("ParametreEspace"))
            //    {
            //        PnlContainer.Controls.Remove(new ParametreEspace());
            //        new ParametreEspace().Dispose();
            //        PnlContainer.Controls.Clear();
            //        PnlContainer.Controls.Add(new ParametrePermissions());
            //    }
            //}
            if (!PnlContainer.Controls.ContainsKey("ParametrePermissions"))
            {
                PnlContainer.Controls.Remove(new ParametreTables());
                new ParametreTables().Dispose();
                PnlContainer.Controls.Clear();
                PnlContainer.Controls.Add(new ParametrePermissions());
            }
        }

        private void BtnParametreImprimantes_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("GestionImprimantes"))
            {
                PnlContainer.Controls.Remove(new ParametreEspace());
                new ParametreEspace().Dispose();
                PnlContainer.Controls.Clear();
                PnlContainer.Controls.Add(new GestionImprimantes());
            }
        }

        private void BtnParametreStock_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("GestionStock"))
            {
                PnlContainer.Controls.Remove(new ParametreEspace());
                new ParametreEspace().Dispose();
                PnlContainer.Controls.Clear();
                PnlContainer.Controls.Add(new GestionStock());
            }
        }
    }
}
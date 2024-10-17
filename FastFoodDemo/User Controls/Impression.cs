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
    public partial class Impression : UserControl
    {
        public Impression()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void Impression_Load(object sender, EventArgs e)
        {
            crystalReportViewer.ReportSource = Form1.ticketCuisine;
            crystalReportViewer.Refresh();
        }
    }
}

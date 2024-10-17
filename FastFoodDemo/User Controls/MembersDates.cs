using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using FastFoodDemo.Classes;
using FastFoodDemo.DataSets;
using FastFoodDemo.Rapports;
using System.IO;
using System.Threading.Tasks;
using System.Configuration;

namespace FastFoodDemo.User_Controls
{
    public partial class MembersDates : UserControl
    {
        public MembersDates()
        {
            InitializeComponent();
        }

        ADO ADO = new ADO();

        public void ListeOfMembers()
        {
            ADO.conMembers.Open();

            ADO.sda = new SqlDataAdapter("ListeOfMembersByEndDate", ADO.conMembers);
            ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            ADO.sda.SelectCommand.Parameters.AddWithValue("@CustumOrCurrentDate", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            DGVListeVentes.DataSource = table;

            ADO.conMembers.Close();
        }

        private void MembersDates_Load(object sender, EventArgs e)
        {
            DPDateDebut.Value = DateTime.Now;
            DPDateFin.Value = DateTime.Now.AddDays(1);
            ListeOfMembers();
            this.Dock = DockStyle.Fill;
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            ListeOfMembers();
        }
    }
}

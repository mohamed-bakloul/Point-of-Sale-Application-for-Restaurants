using FastFoodDemo.Classes;
using FastFoodDemo.DataSets;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Forms
{
    public partial class ReportViewer : Form
    {
        ADO ADO = new ADO();

        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            ADO.sda = new SqlDataAdapter("select dci.Id_DetailCommande as 'IdDetailCommande',dci.Id_Commande as 'IdCommande',dci.Serveur as 'Serveur',dci.Nom_Table as 'ZoneTable',p.Nom_Produit as 'Produit',dci.Prix as 'Prix',dci.Quantite as 'Quantite',n.Nom as 'Note' from DetailsCommandeImprimante dci inner join Produit p on dci.Id_Produit=p.Id_Produit left join ProduitNotes pn on pn.Id_DetailCommande=dci.Id_DetailCommande left join Note n on n.Id=pn.Id_Note where dci.Id_Commande=@IdCommande and dci.Etat=0 and dci.Id_Imprimante=@Id_Imprimante", ADO.con);
            ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCommande", 10);
            ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Imprimante", 1);
            CommandeDataSet dataSet = new CommandeDataSet();
            ADO.sda.Fill(dataSet, "Commande");
            ReportDataSource datasource = new ReportDataSource("DataSetTicketCuisine", dataSet.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
            Print();
        }

        private void Print()
        {
            this.reportViewer1.PrintDialog();
            PageSetupDialog setupDlg = new PageSetupDialog();
            PrintDocument printDoc = new PrintDocument();
            setupDlg.Document = printDoc;
            setupDlg.AllowMargins = false;
            setupDlg.AllowOrientation = false;
            setupDlg.AllowPaper = false;
            setupDlg.AllowPrinter = false;
            setupDlg.Reset();
            printDoc.DefaultPageSettings.PaperSize = new PaperSize("A5", 850, 1400);
        }
    }
}

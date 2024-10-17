using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodDemo.User_Controls;

namespace FastFoodDemo
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        public static string ticketNom = "";

        private void Print_Load(object sender, EventArgs e)
        {
            //PrintDialog print = new PrintDialog();

            //if (print.ShowDialog() == DialogResult.OK)
            //{
            //    CrystalDecisions.CrystalReports.Engine.ReportDocument report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            //    report.Load($"{Application.StartupPath}\\Rapports\\CrystalReportRapportsVentes");
            //    report.PrintOptions.PrinterName = print.PrinterSettings.PrinterName;
            //    report.PrintToPrinter(print.PrinterSettings.Copies,print.PrinterSettings.Collate,print.PrinterSettings.FromPage,print.PrinterSettings.ToPage);
            //}
            //MessageBox.Show(ticketNom);
            if (ticketNom.Equals("Cuisine"))
            {
                crystalReportViewer.ReportSource = PointDeVente.ticketCuisine;
                crystalReportViewer.Refresh();
            }
            else if (ticketNom.Equals("Rapport"))
            {
                crystalReportViewer.ReportSource = Rapport.ticketRapport;
                crystalReportViewer.Refresh();
            }
            else if (ticketNom.Equals("Client"))
            {
                if (PointDeVente.ticketClient.HasRecords)
                {
                    crystalReportViewer.ReportSource = PointDeVente.ticketClient;
                }
                //else if (ListeCommandes.ticketClient.HasRecords)
                //{
                //    crystalReportViewer.ReportSource = ListeCommandes.ticketClient;
                //}

                crystalReportViewer.Refresh();
            }
            else if (ticketNom.Equals("Duplicata"))
            {
                crystalReportViewer.ReportSource = ListeCommandes.ticketClient;
                crystalReportViewer.Refresh();
            }
            else if (ticketNom.Equals("Benifice"))
            {
                if (Benefice.ticketBenifice.HasRecords)
                {
                    crystalReportViewer.ReportSource = Benefice.ticketBenifice;
                    crystalReportViewer.Refresh();
                }
            }
            else
            {
                crystalReportViewer.ReportSource = ParametreEspace.parametrageTicket;
                crystalReportViewer.Refresh();
            }
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }
    }
}

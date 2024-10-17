using FastFoodDemo.Classes;
using FastFoodDemo.DataSets;
using FastFoodDemo.Rapports;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FastFoodDemo.User_Controls
{
    public partial class Benefice : UserControl
    {
        public static Benefice BeneficelInstance;

        public static Benefice Instance
        {
            get
            {
                if (BeneficelInstance == null)
                {
                    BeneficelInstance = new Benefice();
                }
                return BeneficelInstance;
            }
        }

        public Benefice()
        {
            InitializeComponent();
            BeneficelInstance = this;
        }

        readonly ADO ADO = new ADO();

        public static CrystalReportBenefice ticketBenifice = new CrystalReportBenefice();

        public void ListeDesCommandes()
        {
            ADO.Connecter();
            ADO.sda = new SqlDataAdapter("ListeCommandesParDate", ADO.con);

            ADO.sda.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
            ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));

            System.Data.DataTable table = new System.Data.DataTable();
            ADO.sda.Fill(table);
            ADO.Deconnecter();
            DGVListeCommandes.DataSource = table;

            //DGVListeCommandes.Columns[0].Width = 270;
            DGVListeCommandes.Columns[4].DefaultCellStyle.Format = "N2";

            if (DGVListeCommandes.Rows.Count == 0)
            {
                System.Data.DataTable dd = new System.Data.DataTable();
                //DGVListeImprimantes.Width = 140;
                //DGVListeImprimantes.Height = 90;
                dd.Columns.Add("Message");
                //dd.Columns.Add("Nom");
                dd.Rows.Add("Pas de données !");
                DGVListeCommandes.DataSource = dd;
                DGVListeCommandes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
            }
        }

        public void ListCharges()
        {
            try
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("ListeChargesParDate", ADO.con);
                ADO.sda.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                System.Data.DataTable table = new System.Data.DataTable();
                ADO.sda.Fill(table);
                DGVListeCharges.DataSource = table;

                if (DGVListeCharges.Rows.Count == 0)
                {
                    System.Data.DataTable dd = new System.Data.DataTable();
                    //DGVListeImprimantes.Width = 140;
                    //DGVListeImprimantes.Height = 90;
                    dd.Columns.Add("Message");
                    //dd.Columns.Add("Nom");
                    dd.Rows.Add("Pas de données !");
                    DGVListeCharges.DataSource = dd;
                    DGVListeCharges.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Totals()
        {
            decimal TotalVentes = 0;
            decimal TotalCharges = 0;

            if (DGVListeCommandes.Rows.Count == 1 && DGVListeCommandes.Rows[0].Cells[0].Value.ToString() == "Pas de données !")
                LblTotalVentes.Text = "0.00 Dhs";
            if (DGVListeCommandes.Rows.Count > 0 && DGVListeCommandes.Rows[0].Cells[0].Value.ToString() != "Pas de données !")
            {
                foreach (DataGridViewRow row in DGVListeCommandes.Rows)
                {
                    TotalVentes += decimal.Parse(row.Cells[4].Value.ToString());
                    LblTotalVentes.Text = TotalVentes.ToString("#.00") + " Dhs";
                }
            }

            if (DGVListeCharges.Rows.Count == 1 && DGVListeCharges.Rows[0].Cells[0].Value.ToString() == "Pas de données !")
                LblTotalCharges.Text = "0.00 Dhs";

            if (DGVListeCharges.Rows.Count > 0 && DGVListeCharges.Rows[0].Cells[0].Value.ToString() != "Pas de données !")
            {
                foreach (DataGridViewRow row in DGVListeCharges.Rows)
                {
                    TotalCharges += decimal.Parse(row.Cells[6].Value.ToString());
                    LblTotalCharges.Text = TotalCharges.ToString("#.00") + " Dhs";
                }
            }

            if (DGVListeCommandes.Rows.Count == 1 && DGVListeCommandes.Rows[0].Cells[0].Value.ToString() == "Pas de données !" || DGVListeCharges.Rows.Count == 0 && DGVListeCharges.Rows[0].Cells[0].Value.ToString() == "Pas de données !")
                LblBenefice.Text = "0.00 Dhs";
            else
                LblBenefice.Text = (TotalVentes - TotalCharges).ToString("#.00") + " Dhs";
        }

        private void Benefice_Load(object sender, EventArgs e)
        {
            DPDateDebut.Value = DateTime.Now;
            DPDateFin.Value = DateTime.Now.AddDays(1);

            ListeDesCommandes();
            ListCharges();

            Totals();

            GroupBoxCategorie.Width = Form1.GeneralInstance.PnlAffichage.Width - 25;

            this.Dock = DockStyle.Fill;
        }

        //Create document method  
        //private void CreateDocument()
        //{
        //    try
        //    {
        //        //Create an instance for word app  
        //        Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application
        //        {

        //            //Set animation status for word application  
        //            ShowAnimation = false,

        //            //Set status for word application is to be visible or not.  
        //            Visible = false
        //        };

        //        //Create a missing variable for missing value  
        //        object missing = System.Reflection.Missing.Value;

        //        //Create a new document  
        //        Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

        //        //Add header into the document  
        //        foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
        //        {
        //            //Get the header range and add the header details.  
        //            Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
        //            headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
        //            headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
        //            headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
        //            headerRange.Font.Size = 10;
        //            headerRange.Text = "Header text goes here";
        //        }

        //        //Add the footers into the document  
        //        foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
        //        {
        //            //Get the footer range and add the footer details.  
        //            Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
        //            footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
        //            footerRange.Font.Size = 10;
        //            footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
        //            footerRange.Text = "Footer text goes here";
        //        }

        //        //adding text to document  
        //        document.Content.SetRange(0, 0);
        //        document.Content.Text = "This is test document " + Environment.NewLine;

        //        //Add paragraph with Heading 1 style  
        //        Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
        //        object styleHeading1 = "Heading 1";
        //        para1.Range.set_Style(ref styleHeading1);
        //        para1.Range.Text = "Para 1 text";
        //        para1.Range.InsertParagraphAfter();

        //        //Add paragraph with Heading 2 style  
        //        Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
        //        object styleHeading2 = "Heading 2";
        //        para2.Range.set_Style(ref styleHeading2);
        //        para2.Range.Text = "Para 2 text";
        //        para2.Range.InsertParagraphAfter();

        //        //Create a 5X5 table and insert some dummy record  
        //        Table firstTable = document.Tables.Add(para1.Range, 5, 5, ref missing, ref missing);

        //        firstTable.Borders.Enable = 1;
        //        foreach (Row row in firstTable.Rows)
        //        {
        //            foreach (Cell cell in row.Cells)
        //            {
        //                //Header row  
        //                if (cell.RowIndex == 1)
        //                {
        //                    cell.Range.Text = "Column " + cell.ColumnIndex.ToString();
        //                    cell.Range.Font.Bold = 1;
        //                    //other format properties goes here  
        //                    cell.Range.Font.Name = "verdana";
        //                    cell.Range.Font.Size = 10;
        //                    //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                              
        //                    cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
        //                    //Center alignment for the Header cells  
        //                    cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
        //                    cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

        //                }
        //                //Data row  
        //                else
        //                {
        //                    cell.Range.Text = (cell.RowIndex - 2 + cell.ColumnIndex).ToString();
        //                }
        //            }
        //        }

        //        //Save the document  
        //        object filename = @"C:\GestionEspace\WordFiles\tets.docx";
        //        document.SaveAs2(ref filename);
        //        document.Close(ref missing, ref missing, ref missing);
        //        document = null;
        //        winword.Quit(ref missing, ref missing, ref missing);
        //        winword = null;
        //        MessageBox.Show("Document created successfully !");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            ListeDesCommandes();
            ListCharges();
            Totals();
        }

        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            BenificeDataSet dataSet = new BenificeDataSet();

            ADO.Connecter();

            if (DGVListeCommandes.Rows.Count > 0 || DGVListeCharges.Rows.Count > 0)
            {
                ADO.sda = new SqlDataAdapter("select Id_Commande,Date_Commande,Nom_Serveur,Total_Commande from CommandePayer where Date_Commande between @DateDebut and @DateFin", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));

                ADO.sda.Fill(dataSet, "Commandes");

                ADO.sda = new SqlDataAdapter("select Date_Charge,Quantite,Prix_Unitaire from Charges where Date_Charge between @DateDebut and @DateFin", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));

                ADO.sda.Fill(dataSet, "Charges");

                ticketBenifice.SetDataSource(dataSet);

                ticketBenifice.SetParameterValue("Date_Debut", DPDateDebut.Text);
                ticketBenifice.SetParameterValue("Date_Fin", DPDateFin.Text);
                ticketBenifice.SetParameterValue("Benefice", LblBenefice.Text);

                ticketBenifice.PrintToPrinter(0, false, 1, 1);
                ticketBenifice.PrintOptions.PrinterName = "A5";

                //Print impression = new Print();
                //Print.ticketNom = "Benifice";
                //impression.ShowDialog();
            }
        }
    }
}

using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using FastFoodDemo.Classes;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using Npgsql;

namespace FastFoodDemo.User_Controls
{
    public partial class RapportParMail : UserControl
    {
        public static RapportParMail RapportParMailInstance;

        public static RapportParMail Instance
        {
            get
            {
                if (RapportParMailInstance == null)
                {
                    RapportParMailInstance = new RapportParMail();
                }
                return RapportParMailInstance;
            }
        }

        public RapportParMail()
        {
            InitializeComponent();
            RapportParMailInstance = this;
        }

        ADO ADO = new ADO();

        //NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=MyDataBase;User Id=postgres;Password=0000;CommandTimeout=0;");
        //NpgsqlCommand cmd;
        //NpgsqlDataAdapter sda;

        //con.Open();

        //sda = new NpgsqlDataAdapter("select FullName from Users",con);
        //DataTable table = new DataTable();
        //sda.Fill(table);
        //DGVListeVentes.DataSource = table;

        //con.Close();

        string fileName = "";

        //public async void ExporterGataGridViewToPDF(Guna.UI2.WinForms.Guna2DataGridView dataGridView, string montant)
        //{
        //    if (DGVListeVentes.Rows.Count > 0)
        //    {
        //        SaveFileDialog sfd = new SaveFileDialog();
        //        sfd.Filter = "PDF (*.pdf)|*.pdf";
        //        sfd.FileName = "Rapport_" + DateTime.Now.ToString("D") + "_" + DateTime.Now.ToString("HH_mm_ss");

        //        bool fileError = false;

        //        if (sfd.ShowDialog() == DialogResult.OK)
        //        {
        //            try
        //            {
        //                File.Delete(sfd.FileName);
        //            }
        //            catch (IOException ex)
        //            {
        //                fileError = true;
        //                MessageBox.Show("Message d'erreur : " + ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //        if (!fileError)
        //        {
        //            try
        //            {
        //                iTextSharp.text.pdf.PdfPTable pdfPTable = new iTextSharp.text.pdf.PdfPTable(DGVListeVentes.ColumnCount);
        //                float[] widths = new float[] { 50, 20, 20, 20 };
        //                pdfPTable.SetWidths(widths);
        //                pdfPTable.DefaultCell.Padding = 3;
        //                pdfPTable.WidthPercentage = 100;
        //                pdfPTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;

        //                iTextSharp.text.pdf.BaseFont bf = iTextSharp.text.pdf.BaseFont.CreateFont(iTextSharp.text.pdf.BaseFont.TIMES_ROMAN, iTextSharp.text.pdf.BaseFont.CP1250, iTextSharp.text.pdf.BaseFont.EMBEDDED);

        //                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.BOLD);

        //                foreach (DataGridViewColumn column in dataGridView.Columns)
        //                {
        //                    iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(column.HeaderText, font));
        //                    cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
        //                    cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
        //                    cell.VerticalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
        //                    pdfPTable.AddCell(cell);
        //                }

        //                foreach (DataGridViewRow row in dataGridView.Rows)
        //                {
        //                    foreach (DataGridViewCell cell in row.Cells)
        //                    {
        //                        if (cell.ColumnIndex == 3)
        //                        {
        //                            pdfPTable.AddCell(cell.Value.ToString());
        //                        }
        //                        else
        //                        {
        //                            pdfPTable.AddCell(cell.Value.ToString());
        //                        }
        //                    }
        //                }

        //                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
        //                {
        //                    iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10f, 10f, 10f, 10f);
        //                    iTextSharp.text.pdf.PdfWriter.GetInstance(document, stream);

        //                    document.Open();

        //                    iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
        //                    iTextSharp.text.Font defaultFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

        //                    iTextSharp.text.Paragraph HeaderRapport = new iTextSharp.text.Paragraph("Rapport des ventes", fontHeader);
        //                    HeaderRapport.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
        //                    HeaderRapport.Add("\n ");
        //                    document.Add(HeaderRapport);

        //                    iTextSharp.text.Paragraph DateRapport = new iTextSharp.text.Paragraph("Date de : " + DPDateDebut.Value.ToShortDateString() + "  A : " + DPDateFin.Value.ToShortDateString(), defaultFont);
        //                    DateRapport.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
        //                    //DateRapport.Add("\n ");
        //                    document.Add(DateRapport);

        //                    iTextSharp.text.Paragraph Utilisateur = new iTextSharp.text.Paragraph("Serveur : " + CmbUtilisateur.Text, defaultFont);
        //                    Utilisateur.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
        //                    Utilisateur.Add("\n" + "Catégorie : " + CmbCategories.Text + "\n" + "Produit : " + CmbProduits.Text);
        //                    document.Add(Utilisateur);

        //                    iTextSharp.text.pdf.draw.LineSeparator line = new iTextSharp.text.pdf.draw.LineSeparator(1, 100, null, iTextSharp.text.Element.ALIGN_CENTER, -2);
        //                    document.Add(new iTextSharp.text.Chunk(line));

        //                    document.Add(pdfPTable);

        //                    iTextSharp.text.Paragraph Montant = new iTextSharp.text.Paragraph("\nMontant total est : " + montant + " Dhs", defaultFont);
        //                    Montant.Alignment = iTextSharp.text.Element.ALIGN_RIGHT;
        //                    document.Add(Montant);

        //                    document.Close();
        //                    stream.Close();
        //                    fileName = sfd.FileName;
        //                }
        //                await EnvoyerRapportParMail();
        //            }
        //            catch (IOException ex)
        //            {
        //                MessageBox.Show("Message d'erreur : " + ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            }
        //        }
        //    }
        //}

        //public async Task EnvoyerRapportParMail()
        //{
        //    try
        //    {
        //        string emailTo = ADO.AdminEmail();

        //        if (fileName != "" && emailTo != "")
        //        {
        //            SmtpClient smtp = new SmtpClient("smtp.gmail.com");

        //            smtp.Port = 587;
        //            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        //            smtp.UseDefaultCredentials = false;
        //            smtp.EnableSsl = true;

        //            NetworkCredential credential = new NetworkCredential("adib.ahmet@gmail.com", "otwrfzmiralwstkk");

        //            smtp.Credentials = credential;

        //            MailMessage message = new MailMessage("adib.ahmet@gmail.com", emailTo);
        //            message.Subject = "Rapport des ventes";
        //            message.Body = "<h2>Le rapport des ventes de " + DPDateDebut.Value.ToShortDateString() + " à " + DPDateFin.Value.ToShortDateString() + "</h2>";
        //            message.IsBodyHtml = true;

        //            message.Attachments.Add(new Attachment(fileName));

        //            await smtp.SendMailAsync(message);

        //            MessageBox.Show("Le rapport est bien envoyer !", "Envoyer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Message d'erreur : " + ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        public async void ExporterGataGridViewToPDFAsync(Guna.UI2.WinForms.Guna2DataGridView dataGridView, string montant)
        {
            if (DGVListeVentes.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Rapport_" + DateTime.Now.ToString("D") + "_" + DateTime.Now.ToString("HH_mm_ss");

                bool fileError = false;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("Message d'erreur : " + ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        await GeneratePdfAsync(sfd.FileName, dataGridView, montant);
                        fileName = sfd.FileName;
                        await EnvoyerRapportParMailAsync();
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Message d'erreur : " + ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private async Task GeneratePdfAsync(string filePath, Guna.UI2.WinForms.Guna2DataGridView dataGridView, string montant)
        {
            await Task.Run(() =>
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    // Your PDF generation logic here
                    // ... (move the content of the GenerateExcel method here)

                    iTextSharp.text.pdf.PdfPTable pdfPTable = new iTextSharp.text.pdf.PdfPTable(DGVListeVentes.ColumnCount);
                    float[] widths = new float[] { 50, 20, 20, 20 };
                    pdfPTable.SetWidths(widths);
                    pdfPTable.DefaultCell.Padding = 3;
                    pdfPTable.WidthPercentage = 100;
                    pdfPTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;

                    iTextSharp.text.pdf.BaseFont bf = iTextSharp.text.pdf.BaseFont.CreateFont(iTextSharp.text.pdf.BaseFont.TIMES_ROMAN, iTextSharp.text.pdf.BaseFont.CP1250, iTextSharp.text.pdf.BaseFont.EMBEDDED);

                    iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.BOLD);

                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(column.HeaderText, font));
                        cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                        cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                        cell.VerticalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                        pdfPTable.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.ColumnIndex == 3)
                            {
                                pdfPTable.AddCell(cell.Value.ToString());
                            }
                            else
                            {
                                pdfPTable.AddCell(cell.Value.ToString());
                            }
                        }
                    }

                    iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10f, 10f, 10f, 10f);
                    iTextSharp.text.pdf.PdfWriter.GetInstance(document, stream);

                    document.Open();

                    iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
                    iTextSharp.text.Font defaultFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

                    iTextSharp.text.Paragraph HeaderRapport = new iTextSharp.text.Paragraph("Rapport des ventes", fontHeader);
                    HeaderRapport.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    HeaderRapport.Add("\n ");
                    document.Add(HeaderRapport);

                    iTextSharp.text.Paragraph DateRapport = new iTextSharp.text.Paragraph("Date de : " + DPDateDebut.Value.ToShortDateString() + "  A : " + DPDateFin.Value.ToShortDateString(), defaultFont);
                    DateRapport.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                    //DateRapport.Add("\n ");
                    document.Add(DateRapport);

                    Invoke((Action)(() =>
                    {
                        iTextSharp.text.Paragraph Utilisateur = new iTextSharp.text.Paragraph("Serveur : " + CmbUtilisateur.Text, defaultFont);
                        Utilisateur.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                        Utilisateur.Add("\n" + "Catégorie : " + CmbCategories.Text + "\n" + "Produit : " + CmbProduits.Text);
                        document.Add(Utilisateur);
                    }));

                    iTextSharp.text.pdf.draw.LineSeparator line = new iTextSharp.text.pdf.draw.LineSeparator(1, 100, null, iTextSharp.text.Element.ALIGN_CENTER, -2);
                    document.Add(new iTextSharp.text.Chunk(line));

                    document.Add(pdfPTable);

                    iTextSharp.text.Paragraph Montant = new iTextSharp.text.Paragraph("\nMontant total est : " + montant + " Dhs", defaultFont);
                    Montant.Alignment = iTextSharp.text.Element.ALIGN_RIGHT;
                    document.Add(Montant);

                    document.Close();
                }
            });
        }

        private async Task EnvoyerRapportParMailAsync()
        {
            await Task.Run(() =>
            {
                // Your email sending logic here
                string emailTo = ADO.AdminEmail();

                if (fileName != "" && emailTo != "")
                {
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;

                    NetworkCredential credential = new NetworkCredential("adib.ahmet@gmail.com", "otwrfzmiralwstkk");

                    smtp.Credentials = credential;

                    MailMessage message = new MailMessage("adib.ahmet@gmail.com", emailTo);
                    message.Subject = "Rapport des ventes";
                    message.Body = "<h2>Le rapport des ventes de " + DPDateDebut.Value.ToShortDateString() + " à " + DPDateFin.Value.ToShortDateString() + "</h2>";
                    message.IsBodyHtml = true;

                    message.Attachments.Add(new Attachment(fileName));

                    smtp.SendMailAsync(message);

                    MessageBox.Show("Le rapport est bien envoyer !", "Envoyer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            });
        }


        public void TotalQteEtPrix()
        {
            decimal Qte = 0;
            decimal Prix = 0;
            if (DGVListeVentes.Rows.Count > 0 && DGVListeVentes.Rows[0].Cells[0].Value.ToString() != "Pas de données !")
            {
                foreach (DataGridViewRow row in DGVListeVentes.Rows)
                {
                    Qte += decimal.Parse(row.Cells[1].Value.ToString());
                    Prix += decimal.Parse(row.Cells[3].Value.ToString());
                }

                LblQteTotal.Text = Qte.ToString("#.00");
                LblMntTotal.Text = Prix.ToString("#.00");
            }
            else
            {
                LblQteTotal.Text = "0.00";
                LblMntTotal.Text = "0.00";
            }
        }

        public void ListeDesVentesParDateEtUtilisateur()
        {
            ADO.Connecter();

            string Requete = "";

            //var RapportDesVentes = DGVListeVentes.DataSource;

            // Cas 1 :

            if (CmbUtilisateur.Text.Equals("TOUS") && CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentes(DPDateDebut.Value, DPDateFin.Value);
                        //Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',(dci.Prix*(SUM(dci.Quantite))) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin group by p.Nom_Produit,dci.Prix", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                    }
                }
                else
                {
                    ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and dci.Id_Produit=0 group by p.Nom_Produit,dci.Prix", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    DGVListeVentes.DataSource = table;
                    //DGVListeVentes.DataSource = RapportDesVentes;

                    DGVListeVentes.Columns[0].Width = 270;
                    DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                }
            }
            else if (!CmbUtilisateur.Text.Equals("TOUS") && !CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (!CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        //Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',(dci.Prix*(SUM(dci.Quantite))) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=@Id_Produit and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=@Id_Produit and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                    }
                    else
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        //Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',(dci.Prix*(SUM(dci.Quantite))) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=@Id_Produit and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur /*and dci.Id_Produit=@Id_Produit*/ and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                    }
                }
                else
                {
                    ADO.sda = new SqlDataAdapter("select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=0 and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    DGVListeVentes.DataSource = table;
                    //DGVListeVentes.DataSource = RapportDesVentes;

                    DGVListeVentes.Columns[0].Width = 270;
                    DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                }
            }
            else if (!CmbUtilisateur.Text.Equals("TOUS") && CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                    }
                }
                else
                {
                    Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=0 group by p.Nom_Produit,dci.Prix";
                    ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    DGVListeVentes.DataSource = table;
                    //DGVListeVentes.DataSource = RapportDesVentes;

                    DGVListeVentes.Columns[0].Width = 270;
                    DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                }
            }
            else if (!CmbUtilisateur.Text.Equals("TOUS") && !CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                    }
                    else
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and dci.Id_Produit=@Id_Produit and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                    }
                }
                else
                {
                    Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and cp.Nom_Serveur=@Serveur and p.Id_CategorieProduit=@Id_Categorie and dci.Id_Produit=0 group by p.Nom_Produit,dci.Prix";
                    ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    DGVListeVentes.DataSource = table;
                    //DGVListeVentes.DataSource = RapportDesVentes;

                    DGVListeVentes.Columns[0].Width = 270;
                    DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                }
            }
            else if (CmbUtilisateur.Text.Equals("TOUS") && !CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                    }
                    else
                    {
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and p.Id_CategorieProduit=@Id_Categorie and dci.Id_Produit=@Id_Produit group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                    }
                }
                else
                {
                    Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and p.Id_CategorieProduit=@Id_Categorie and dci.Id_Produit=0 group by p.Nom_Produit,dci.Prix";
                    ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    DGVListeVentes.DataSource = table;
                    //DGVListeVentes.DataSource = RapportDesVentes;

                    DGVListeVentes.Columns[0].Width = 270;
                    DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                }
            }
            else if (CmbUtilisateur.Text.Equals("TOUS") && !CmbCategories.Text.Equals("TOUS"))
            {
                if (CmbProduits.Items.Count > 0)
                {
                    if (!CmbProduits.Text.Equals("TOUS"))
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin and dci.Id_Produit=@Id_Produit and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                    }
                    else
                    {
                        //RapportDesVentes = db.RapportVentesParEmployer(DPDateDebut.Value.ToShortDateString().ToShortDateString, DPDateFin.Value.ToShortDateString(), CmbUtilisateur.Text);
                        Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin /*and dci.Id_Produit=@Id_Produit*/ and p.Id_CategorieProduit=@Id_Categorie group by p.Nom_Produit,dci.Prix";
                        ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                        //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        DGVListeVentes.DataSource = table;
                        //DGVListeVentes.DataSource = RapportDesVentes;

                        DGVListeVentes.Columns[0].Width = 270;
                        DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                    }
                }
                else
                {
                    Requete = "select p.Nom_Produit as 'Produit',SUM(dci.Quantite) as 'Quantité total',dci.Prix as 'Prix unitaire',CAST((dci.Prix*(SUM(dci.Quantite))) AS DECIMAL(10, 2)) as 'Montant total' from DetailsCommandeImprimante dci,CommandePayer cp,Produit p where dci.Id_Commande=cp.Id_Commande and dci.Id_Produit=p.Id_Produit and cp.Date_Commande between @DateDebut and @DateFin /*and dci.Id_Produit=@Id_Produit*/ and p.Id_CategorieProduit=@Id_Categorie and dci.Id_Produit=0 group by p.Nom_Produit,dci.Prix";
                    ADO.sda = new SqlDataAdapter(Requete, ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateDebut", Convert.ToDateTime(DPDateDebut.Value.ToShortDateString()));
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@DateFin", Convert.ToDateTime(DPDateFin.Value.ToShortDateString()));
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Serveur", CmbUtilisateur.Text);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Categorie", CmbCategories.SelectedValue);
                    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", CmbProduits.SelectedValue);
                    DataTable table = new DataTable();
                    ADO.sda.Fill(table);
                    DGVListeVentes.DataSource = table;
                    //DGVListeVentes.DataSource = RapportDesVentes;

                    DGVListeVentes.Columns[0].Width = 270;
                    DGVListeVentes.Columns[3].DefaultCellStyle.Format = "N2";
                }
            }

            ADO.Deconnecter();

            if (DGVListeVentes.Rows.Count == 0)
            {
                System.Data.DataTable dd = new System.Data.DataTable();
                //DGVListeImprimantes.Width = 140;
                //DGVListeImprimantes.Height = 90;
                dd.Columns.Add("Message");
                //dd.Columns.Add("Nom");
                dd.Rows.Add("Pas de données !");
                DGVListeVentes.DataSource = dd;
                DGVListeVentes.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
            }
        }

        private void RapportParMail_Load(object sender, System.EventArgs e)
        {
            DPDateDebut.Value = DateTime.Now;
            DPDateFin.Value = DateTime.Now.AddDays(1);

            ADO.RemplirCombo("GetEmployerName", CmbUtilisateur, "Prenom", "CIN", "TOUS");
            ADO.RemplirCombo("GetCategorieIdAndName", CmbCategories, "Nom_Categorie", "Id_Categorie", "TOUS");

            //RemplirComboEmployer();

            ListeDesVentesParDateEtUtilisateur();

            TotalQteEtPrix();

            GroupBoxCategorie.Width = Form1.GeneralInstance.PnlAffichage.Width - 25;

            this.Dock = DockStyle.Fill;
        }

        private async void BtnRechercher_Click(object sender, EventArgs e)
        {
            pictureBoxLoading.Visible = true;

            await Task.Delay(TimeSpan.FromSeconds(8));

            ListeDesVentesParDateEtUtilisateur();

            //DGVListeVentes.DataSource = db.RapportVentes(DPDateDebut.Value, DPDateFin.Value);

            TotalQteEtPrix();

            pictureBoxLoading.Visible = false;
        }

        private void CmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCategories.Text == "TOUS")
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("select Id_Produit,Nom_Produit from Produit where Id_CategorieProduit=@IdCat", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCat", CmbCategories.SelectedValue);
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                DataRow row = table.NewRow();
                row["Id_Produit"] = "0";
                row["Nom_Produit"] = "TOUS";
                table.Rows.InsertAt(row, 0);
                CmbProduits.DisplayMember = "Nom_Produit";
                CmbProduits.ValueMember = "Id_Produit";
                CmbProduits.DataSource = table;
                CmbProduits.Text = "TOUS";
                CmbProduits.Enabled = false;
            }
            else
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("select Id_Produit,Nom_Produit from Produit where Id_CategorieProduit=@IdCat", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@IdCat", CmbCategories.SelectedValue);
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                if (table.Rows.Count > 0)
                {
                    DataRow row = table.NewRow();
                    row["Id_Produit"] = "0";
                    row["Nom_Produit"] = "TOUS";
                    table.Rows.InsertAt(row, 0);
                    CmbProduits.DisplayMember = "Nom_Produit";
                    CmbProduits.ValueMember = "Id_Produit";
                    CmbProduits.DataSource = table;
                    CmbProduits.Enabled = true;
                }
                else
                {
                    CmbProduits.DisplayMember = "Nom_Produit";
                    CmbProduits.ValueMember = "Id_Produit";
                    CmbProduits.DataSource = table;
                    CmbProduits.Enabled = false;
                }
            }
        }

        private async void BtnImprimer_Click(object sender, EventArgs e)
        {
            pictureBoxLoading.Visible = true;

            await Task.Delay(TimeSpan.FromSeconds(8));

            //ThreadPool.QueueUserWorkItem(new WaitCallback((state)=> ExporterGataGridViewToPDF(DGVListeVentes, LblMntTotal.Text)));

            ExporterGataGridViewToPDFAsync(DGVListeVentes, LblMntTotal.Text);

            pictureBoxLoading.Visible = false;
        }
    }
}
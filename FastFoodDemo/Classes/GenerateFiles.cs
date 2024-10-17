using OfficeOpenXml;
using Spire.Doc;
using System;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo.Classes
{
    public class GenerateFiles
    {
        //public static string GenerateWord(string templatePath, Guna.UI2.WinForms.Guna2DataGridView dataGridView, string Utilisateur, string Categorie, string Produit, string DateFrom, string DateTo)
        //{
        //    string dirSaveDocs = ConfigurationManager.AppSettings["TempFilesPathWord"];
        //    string dirDocs = ConfigurationManager.AppSettings["TemplateDocumentsPath"];
        //    string modelPath = Path.Combine(dirDocs, templatePath);

        //    //string fileName = Guid.NewGuid() + ".docx";
        //    string fileName = "Rapport_" + DateTime.Now.ToString("D") + "_" + DateTime.Now.ToString("HH_mm_ss") + ".docx";

        //    var destFile = Path.Combine(dirSaveDocs, fileName);

        //    Document doc = new Document();

        //    doc.LoadFromFile(modelPath);

        //    doc.Replace("[DateFrom]", DateFrom, true, true);
        //    doc.Replace("[DateTo]", DateTo, true, true);
        //    doc.Replace("[Categorie]", Categorie, true, true);
        //    doc.Replace("[Produit]", Produit, true, true);
        //    doc.Replace("[Serveur]", Utilisateur, true, true);

        //    Table table = doc.Sections[0].Tables[0] as Table;
        //    //Insert a new row as the third row
        //    for (int i = 0; i < dataGridView.Rows.Count; i++)
        //    {
        //        table.AddRow(false, 4);
        //        table.Rows[i + 1].Cells[0].InsertXHTML("<h4>" + dataGridView.Rows[i].Cells[0].Value.ToString() + "</h4>");
        //        table.Rows[i + 1].Cells[1].InsertXHTML("<h4>" + dataGridView.Rows[i].Cells[1].Value.ToString() + "</h4>");
        //        table.Rows[i + 1].Cells[2].InsertXHTML("<h4>" + dataGridView.Rows[i].Cells[2].Value.ToString() + "</h4>");
        //        table.Rows[i + 1].Cells[3].InsertXHTML("<h4>" + dataGridView.Rows[i].Cells[3].Value.ToString() + "</h4>");
        //    }

        //    doc.SaveToFile(destFile, FileFormat.Docx2013);

        //    return fileName;
        //}

        public static async Task<string> GenerateWordAsync(string templatePath, Guna.UI2.WinForms.Guna2DataGridView dataGridView, string Utilisateur, string Categorie, string Produit, string DateFrom, string DateTo)
        {
            return await Task.Run(() => GenerateWordInternal(templatePath, dataGridView, Utilisateur, Categorie, Produit, DateFrom, DateTo));
        }

        public static string GenerateWordInternal(string templatePath, Guna.UI2.WinForms.Guna2DataGridView dataGridView, string Utilisateur, string Categorie, string Produit, string DateFrom, string DateTo)
        {
            string dirSaveDocs = ConfigurationManager.AppSettings["TempFilesPathWord"];
            string dirDocs = ConfigurationManager.AppSettings["TemplateDocumentsPath"];
            string modelPath = Path.Combine(dirDocs, templatePath);

            string fileName = "Rapport_" + DateTime.Now.ToString("D") + "_" + DateTime.Now.ToString("HH_mm_ss") + ".docx";
            var destFile = Path.Combine(dirSaveDocs, fileName);

            Document doc = new Document();

            doc.LoadFromFile(modelPath);

            doc.Replace("[DateFrom]", DateFrom, true, true);
            doc.Replace("[DateTo]", DateTo, true, true);
            doc.Replace("[Categorie]", Categorie, true, true);
            doc.Replace("[Produit]", Produit, true, true);
            doc.Replace("[Serveur]", Utilisateur, true, true);

            Table table = doc.Sections[0].Tables[0] as Table;
            //Insert a new row as the third row
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                table.AddRow(false, 4);
                table.Rows[i + 1].Cells[0].InsertXHTML("<h4>" + dataGridView.Rows[i].Cells[0].Value.ToString() + "</h4>");
                table.Rows[i + 1].Cells[1].InsertXHTML("<h4>" + dataGridView.Rows[i].Cells[1].Value.ToString() + "</h4>");
                table.Rows[i + 1].Cells[2].InsertXHTML("<h4>" + dataGridView.Rows[i].Cells[2].Value.ToString() + "</h4>");
                table.Rows[i + 1].Cells[3].InsertXHTML("<h4>" + dataGridView.Rows[i].Cells[3].Value.ToString() + "</h4>");
            }

            doc.SaveToFile(destFile, FileFormat.Docx2013);

            return fileName;
        }

        //public static string GenerateExcel(string templatePath, string workSheetName, Guna.UI2.WinForms.Guna2DataGridView dataGridView, string Utilisateur, string Categorie, string Produit, string DateFrom, string DateTo)
        //{
        //    string dirSaveDocs = ConfigurationManager.AppSettings["TempFilesPathExcel"];
        //    string fileName = $"Rapport_{DateTime.Now:yyyy-MM-dd_HH_mm_ss}.xlsx";
        //    var destFile = Path.Combine(dirSaveDocs, fileName);

        //    using (var package = CreateExcelPackage(templatePath, workSheetName, Utilisateur, Categorie, Produit, DateFrom, DateTo))
        //    {
        //        PopulateExcelWorksheet(package.Workbook.Worksheets[workSheetName], dataGridView);
        //        package.SaveAs(new FileInfo(destFile));
        //    }

        //    return fileName;
        //}

        public static async Task<string> GenerateExcelAsync(string templatePath, string workSheetName, Guna.UI2.WinForms.Guna2DataGridView dataGridView, string Utilisateur, string Categorie, string Produit, string DateFrom, string DateTo)
        {
            return await Task.Run(() => GenerateExcelInternal(templatePath, workSheetName, dataGridView, Utilisateur, Categorie, Produit, DateFrom, DateTo));
        }

        public static string GenerateExcelInternal(string templatePath, string workSheetName, Guna.UI2.WinForms.Guna2DataGridView dataGridView, string Utilisateur, string Categorie, string Produit, string DateFrom, string DateTo)
        {
            string dirSaveDocs = ConfigurationManager.AppSettings["TempFilesPathExcel"];
            string fileName = $"Rapport_{DateTime.Now:yyyy-MM-dd_HH_mm_ss}.xlsx";
            var destFile = Path.Combine(dirSaveDocs, fileName);

            using (var package = CreateExcelPackage(templatePath, workSheetName, Utilisateur, Categorie, Produit, DateFrom, DateTo))
            {
                PopulateExcelWorksheet(package.Workbook.Worksheets["Rapport des ventes"], dataGridView);
                package.SaveAs(new FileInfo(destFile));
            }

            return fileName;
        }

        public static ExcelPackage CreateExcelPackage(string templatePath, string workSheetName, string Utilisateur, string Categorie, string Produit, string DateFrom, string DateTo)
        {
            string dirDocs = ConfigurationManager.AppSettings["TemplateDocumentsPath"];
            string modelPath = Path.Combine(dirDocs, templatePath);

            var fi = new FileInfo(modelPath);
            var package = new ExcelPackage(fi);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var xlWorkSheet = package.Workbook.Worksheets[workSheetName];
            xlWorkSheet.Cells[3, 3].Value = DateFrom;
            xlWorkSheet.Cells[3, 5].Value = DateTo;
            xlWorkSheet.Cells[4, 3].Value = Categorie;
            xlWorkSheet.Cells[4, 5].Value = Produit;
            xlWorkSheet.Cells[5, 3].Value = Utilisateur;

            return package;
        }

        public static void PopulateExcelWorksheet(ExcelWorksheet worksheet, Guna.UI2.WinForms.Guna2DataGridView dataGridView)
        {
            int R = 8;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                worksheet.Cells[R, 2].Value = row.Cells[0].Value.ToString();
                worksheet.Cells[R, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
                worksheet.Cells[R, 2].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                worksheet.Cells[R, 3].Value = row.Cells[1].Value.ToString();
                worksheet.Cells[R, 3].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells[R, 3].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                worksheet.Cells[R, 4].Value = row.Cells[2].Value.ToString();
                worksheet.Cells[R, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells[R, 4].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                worksheet.Cells[R, 5].Value = row.Cells[3].Value.ToString();
                worksheet.Cells[R, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells[R, 5].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                R++;
            }
        }


        //public static string GenerateExcel(string templatePath, string workSheetName, Guna.UI2.WinForms.Guna2DataGridView dataGridView, string Utilisateur, string Categorie, string Produit, string DateFrom, string DateTo)
        //{
        //    string dirSaveDocs = ConfigurationManager.AppSettings["TempFilesPathExcel"];
        //    string dirDocs = ConfigurationManager.AppSettings["TemplateDocumentsPath"];
        //    string modelPath = Path.Combine(dirDocs, templatePath);

        //    //string fileName = Guid.NewGuid() + ".xlsx";
        //    string fileName = "Rapport_" + DateTime.Now.ToString("D") + "_" + DateTime.Now.ToString("HH_mm_ss") + ".xlsx";

        //    var destFile = Path.Combine(dirSaveDocs, fileName);

        //    using (var stream = new MemoryStream())
        //    {
        //        var fi = new FileInfo(modelPath);
        //        using (var package = new ExcelPackage(fi))
        //        {
        //            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //            var xlWorkSheet = package.Workbook.Worksheets[workSheetName];
        //            int R = 8;

        //            xlWorkSheet.Cells[3, 3].Value = DateFrom;
        //            xlWorkSheet.Cells[3, 5].Value = DateTo;
        //            xlWorkSheet.Cells[4, 3].Value = Categorie;
        //            xlWorkSheet.Cells[4, 5].Value = Produit;
        //            xlWorkSheet.Cells[5, 3].Value = Utilisateur;

        //            foreach (DataGridViewRow row in dataGridView.Rows)
        //            {
        //                xlWorkSheet.Cells[R, 2].Value = row.Cells[0].Value.ToString();
        //                xlWorkSheet.Cells[R, 2].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Left;
        //                xlWorkSheet.Cells[R, 2].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
        //                xlWorkSheet.Cells[R, 3].Value = row.Cells[1].Value.ToString();
        //                xlWorkSheet.Cells[R, 3].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
        //                xlWorkSheet.Cells[R, 3].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
        //                xlWorkSheet.Cells[R, 4].Value = row.Cells[2].Value.ToString();
        //                xlWorkSheet.Cells[R, 4].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
        //                xlWorkSheet.Cells[R, 4].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
        //                xlWorkSheet.Cells[R, 5].Value = row.Cells[3].Value.ToString();
        //                xlWorkSheet.Cells[R, 5].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
        //                xlWorkSheet.Cells[R, 5].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
        //                R++;
        //            }
        //            package.SaveAs(new FileInfo(destFile));
        //        }
        //    }
        //    return fileName;
        //}
    }
}

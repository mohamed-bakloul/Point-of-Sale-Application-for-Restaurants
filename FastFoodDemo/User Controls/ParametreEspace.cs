using FastFoodDemo.Classes;
using FastFoodDemo.DataSets;
using FastFoodDemo.Rapports;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FastFoodDemo.User_Controls
{
    public partial class ParametreEspace : UserControl
    {
        public static ParametreEspace ParametreEspaceInstance;

        public static ParametreEspace Instance
        {
            get
            {
                if (ParametreEspaceInstance == null)
                {
                    ParametreEspaceInstance = new ParametreEspace();
                }
                return ParametreEspaceInstance;
            }
        }

        public ParametreEspace()
        {
            InitializeComponent();
            ParametreEspaceInstance = this;
        }

        readonly ADO ADO = new ADO();

        public static CrystalReportParametrageTicket parametrageTicket = new CrystalReportParametrageTicket();
        public static int Etat = 0;

        public void Vider()
        {
            TxtAdresse.Text = TxtCodeWIFI.Text = TxtEmail.Text = TxtMessage.Text = TxtNom.Text = TxtTelephone.Text = "";
            Logo.Image = null;
            RDRestaurant.Checked = RDBoulangerie.Checked = RDAutre.Checked = false;
        }

        public bool CheckIfEspaceExists()
        {
            ADO.Connecter();
            ADO.sda = new SqlDataAdapter("Select Id_Espace From Espace", ADO.con);
            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            ADO.Deconnecter();
            if (table.Rows.Count > 0)
                return true;
            return false;
        }

        public void AfficherTicket()
        {
            if (CheckIfEspaceExists())
            {
                CommandeDataSet dataSet = new CommandeDataSet();

                crystalReportViewerTicket.ReportSource = null;

                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("Select 'Serveur' as 'Serveur','Zone Table 1' as 'ZoneTable',(select Nom from Espace) as 'NomEspace',(select Adresse from Espace) as 'Adresse',(select Telephone from Espace) as 'Telephone',(select Code_Wifi from Espace) as 'CodeWIFI',(select Message from Espace) as 'Message',(select Logo from Espace) as 'Logo'", ADO.con);
                ADO.sda.Fill(dataSet, "Commande");
                parametrageTicket.SetDataSource(dataSet.Tables["Commande"]);

                if (Etat == 0)
                {
                    crystalReportViewerTicket.ReportSource = parametrageTicket;
                    crystalReportViewerTicket.Refresh();
                }
                else
                {
                    Print.ticketNom = "Preview ticket";
                    Print print = new Print();
                    print.ShowDialog();
                }
                ADO.Deconnecter();
            }
        }

        public void AfficherEspaceInfo()
        {
            ADO.Connecter();

            ADO.sda = new SqlDataAdapter("EspaceInfo", ADO.con);
            ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            ADO.sda.Fill(table);
            if (table.Rows.Count == 1)
            {
                TxtNom.Text = table.Rows[0][1].ToString();
                TxtAdresse.Text = table.Rows[0][2].ToString();
                TxtTelephone.Text = table.Rows[0][3].ToString();
                TxtCodeWIFI.Text = table.Rows[0][4].ToString();
                TxtMessage.Text = table.Rows[0][5].ToString();
                TxtEmail.Text = table.Rows[0][6].ToString();

                if (table.Rows[0][8].ToString().Equals(ADO.EspaceTypes.Restaurant.ToString()))
                {
                    RDRestaurant.Checked = true;
                }
                else if (table.Rows[0][8].ToString().Equals(ADO.EspaceTypes.Boulangerie.ToString()))
                {
                    RDBoulangerie.Checked = true;
                }
                else
                {
                    RDAutre.Checked = true;
                }

                byte[] image = Encoding.ASCII.GetBytes(table.Rows[0][7].ToString());

                if (image != null)
                {
                    var Data = (byte[])(table.Rows[0][7]);
                    var stream = new MemoryStream(Data);
                    Logo.Image = Image.FromStream(stream);
                }

                //RDRestaurant.Enabled = RDBoulangerie.Enabled = RDAutre.Enabled = false;
                TxtNom.Focus();
                //TxtNom.Enabled = TxtAdresse.Enabled = TxtTelephone.Enabled = TxtCodeWIFI.Enabled = TxtMessage.Enabled = TxtEmail.Enabled = RDRestaurant.Enabled = RDBoulangerie.Enabled = RDAutre.Enabled = false;
            }
            ADO.Deconnecter();
        }

        private void ParametreEspace_Load(object sender, EventArgs e)
        {
            if (CheckIfEspaceExists())
            {
                BtnAjouter.Enabled = false;
                BtnModifier.Enabled = true;
                AfficherEspaceInfo();
            }
            else
            {
                BtnModifier.Enabled = false;
                BtnAjouter.Enabled = true;
            }

            GroupBoxCategorie.Width = Form1.GeneralInstance.PnlAffichage.Width - 25;
            this.Dock = DockStyle.Fill;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (!CheckIfEspaceExists())
            {
                if (TxtNom.Text != "" || TxtAdresse.Text != "" || TxtCodeWIFI.Text != "" || TxtEmail.Text != "" || TxtMessage.Text != "" || TxtTelephone.Text != "" || Logo.Image != null)
                {
                    if (RDRestaurant.Enabled || RDBoulangerie.Enabled || RDAutre.Enabled)
                    {
                        MemoryStream mr = new MemoryStream();
                        Logo.Image.Save(mr, ImageFormat.Png);
                        byte[] byteimage = mr.ToArray();

                        string Type = "";
                        if (RDRestaurant.Checked)
                        {
                            Type = RDRestaurant.Text;
                        }
                        else if (RDBoulangerie.Checked)
                        {
                            Type = RDBoulangerie.Text;
                        }
                        else if (RDAutre.Checked)
                        {
                            Type = RDAutre.Text;
                        }

                        ADO.Connecter();
                        ADO.cmd = new SqlCommand("insert into Espace values(@Nom,@Adresse,@Telephone,@Code_Wifi,@Message,@Email_Admin,@Logo,@Type)", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@Nom", TxtNom.Text);
                        ADO.cmd.Parameters.AddWithValue("@Adresse", TxtAdresse.Text);
                        ADO.cmd.Parameters.AddWithValue("@Telephone", TxtTelephone.Text);
                        ADO.cmd.Parameters.AddWithValue("@Code_Wifi", TxtCodeWIFI.Text);
                        ADO.cmd.Parameters.AddWithValue("@Message", TxtMessage.Text);
                        ADO.cmd.Parameters.AddWithValue("@Email_Admin", TxtEmail.Text);
                        ADO.cmd.Parameters.AddWithValue("@Logo", byteimage);
                        ADO.cmd.Parameters.AddWithValue("@Type", Type);
                        ADO.cmd.ExecuteNonQuery();
                        ADO.Deconnecter();

                        MessageBox.Show("Espace est bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Vider();
                    }
                }
            }
            if (CheckIfEspaceExists())
            {
                BtnAjouter.Enabled = false;
                BtnModifier.Enabled = true;
                AfficherEspaceInfo();
            }
            else
            {
                BtnModifier.Enabled = false;
                BtnAjouter.Enabled = true;
            }
        }

        private void BtnParcourir_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "|*.JPG;*.PNG;*.GIF;*.BMP;*.ico;*.jfif"
                };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Logo.Image = Image.FromFile(ofd.FileName);
                    Bitmap bitmap = new Bitmap(Logo.Image, 150, 150);
                    Logo.Image = bitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefreshReport_Click(object sender, EventArgs e)
        {
            AfficherTicket();
        }

        private void BtnPreviewReport_Click(object sender, EventArgs e)
        {
            Etat = 1;
            AfficherTicket();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (CheckIfEspaceExists())
            {
                if (TxtNom.Text != "" || TxtAdresse.Text != "" || TxtCodeWIFI.Text != "" || TxtEmail.Text != "" || TxtMessage.Text != "" || TxtTelephone.Text != "" || Logo.Image != null)
                {
                    if (RDRestaurant.Enabled || RDBoulangerie.Enabled || RDAutre.Enabled)
                    {
                        MemoryStream mr = new MemoryStream();
                        Logo.Image.Save(mr, ImageFormat.Png);
                        byte[] byteimage = mr.ToArray();

                        string Type = "";
                        if (RDRestaurant.Checked)
                        {
                            Type = RDRestaurant.Text;
                        }
                        else if (RDBoulangerie.Checked)
                        {
                            Type = RDBoulangerie.Text;
                        }
                        else if (RDAutre.Checked)
                        {
                            Type = RDAutre.Text;
                        }

                        ADO.Connecter();
                        ADO.cmd = new SqlCommand("update Espace set Nom=@Nom,Adresse=@Adresse,Telephone=@Telephone,Code_Wifi=@Code_Wifi,Message=@Message,Email_Admin=@Email_Admin,Logo=@Logo,Type=@Type where Id_Espace=1", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@Nom", TxtNom.Text);
                        ADO.cmd.Parameters.AddWithValue("@Adresse", TxtAdresse.Text);
                        ADO.cmd.Parameters.AddWithValue("@Telephone", TxtTelephone.Text);
                        ADO.cmd.Parameters.AddWithValue("@Code_Wifi", TxtCodeWIFI.Text);
                        ADO.cmd.Parameters.AddWithValue("@Message", TxtMessage.Text);
                        ADO.cmd.Parameters.AddWithValue("@Email_Admin", TxtEmail.Text);
                        ADO.cmd.Parameters.AddWithValue("@Logo", byteimage);
                        ADO.cmd.Parameters.AddWithValue("@Type", Type);
                        ADO.cmd.ExecuteNonQuery();
                        ADO.Deconnecter();

                        MessageBox.Show("Espace est bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Vider();
                    }
                }
            }
            if (CheckIfEspaceExists())
            {
                BtnAjouter.Enabled = false;
                BtnModifier.Enabled = true;
                AfficherEspaceInfo();
            }
            else
            {
                BtnModifier.Enabled = false;
                BtnAjouter.Enabled = true;
            }
            if (!ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
            {
                ParamEspace.ParamInstance.BtnParametreTables.Enabled = false;
            }
            else
            {
                ParamEspace.ParamInstance.BtnParametreTables.Enabled = true;
            }
        }
    }
}
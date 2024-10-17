using FastFoodDemo.Classes;
using FastFoodDemo.Forms;
using FastFoodDemo.Models;

using Microsoft.Reporting.WinForms;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace FastFoodDemo.User_Controls
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        ADO ADO = new ADO();

        int IsFucused;

        bool IsTxtMotPasseFocused;
        bool IsTxtMotPasseResetFocused;
        bool IsTxtMotPasseConfirmResetFocused;

        //public NpgsqlConnection con = new NpgsqlConnection(@"Data Source=.;Initial Catalog=GestionEspace;Integrated Security=True;MultipleActiveResultSets=True;Min Pool Size=10; Max Pool Size=100; Pooling=false");
        //public NpgsqlCommand cmd;
        //public NpgsqlDataAdapter sda;

        public static string UserRole;

        GestionEspaceEntities db = new GestionEspaceEntities();

        public void Connecter()
        {
            if (!ADO.IsDeviceHasPermission())
            {
                //MessageBox.Show("Attention, votre délai est terminer !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                //string MotPasse = Cryptography.Encrypt(TxtMotPasse.Text);

                //LocalReport localReport = new LocalReport();
                //localReport.ReportPath = Application.StartupPath + "\\Report1.rdlc";
                //localReport.PrintToPrinter();

                string MotPasse = Helpers.EncryptPassword(TxtMotPasse.Text);

                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("GetEmployerByNameAndPassword", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@Password", MotPasse);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@Name", CmbNom.Text);
                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                ADO.sda.Fill(table);

                if (table.Rows.Count > 0)
                {
                    string User = table.Rows[0][0].ToString();
                    string Role = table.Rows[0][1].ToString();
                    UserRole = Role;
                    //this.Hide();
                    //Form1 form = new Form1();
                    //form.LblUtilisateur.Text = User;
                    //form.LblRole.Text = Role;
                    //form.ShowDialog();

                    Form1.GeneralInstance.PnlAffichage.Controls.Remove(new Login());
                    new Login().Dispose();
                    Form1.GeneralInstance.PnlAffichage.Controls.Clear();
                    if (Role.Equals(ADO.UserRoles.Caissier.ToString()))
                    {
                        Form1.GeneralInstance.SideBar.Visible = Form1.GeneralInstance.SidePanel.Visible = false;
                        Form1.GeneralInstance.PnlHeader.Visible = true;
                        Form1.GeneralInstance.LblUtilisateur.Text = User;
                        Form1.GeneralInstance.LblRole.Text = Role;
                        Form1.GeneralInstance.PnlAffichage.Controls.Add(new PointDeVente());
                        Form1.GeneralInstance.IconZone.Visible = Form1.GeneralInstance.LblZone.Visible = Form1.GeneralInstance.IconNumTable.Visible = Form1.GeneralInstance.LblNumTable.Visible = true;
                        Form1.GeneralInstance.LblZone.Text = "Zone";
                        Form1.GeneralInstance.LblNumTable.Text = "Table 1";
                    }
                    else
                    {
                        Form1.GeneralInstance.SideBar.Visible = Form1.GeneralInstance.SidePanel.Visible = Form1.GeneralInstance.PnlHeader.Visible = true;
                        Form1.GeneralInstance.IconZone.Visible = Form1.GeneralInstance.LblZone.Visible = Form1.GeneralInstance.IconNumTable.Visible = Form1.GeneralInstance.LblNumTable.Visible = false;
                        Form1.GeneralInstance.LblUtilisateur.Text = User;
                        Form1.GeneralInstance.LblRole.Text = Role;
                        Form1.GeneralInstance.SidePanel.Height = Form1.GeneralInstance.BtnHome.Height;
                        Form1.GeneralInstance.SidePanel.Top = Form1.GeneralInstance.BtnHome.Top;
                        Form1.GeneralInstance.PnlAffichage.Controls.Add(new FirstCustomControl());
                        if (Form1.GeneralInstance.PnlAffichage.Controls.ContainsKey("FirstCustomControl"))
                        {
                            //await Task.Delay(TimeSpan.FromSeconds(3));

                            Form1.GeneralInstance.PnlLogoAndName.Visible = Form1.GeneralInstance.BtnHome.Visible = Form1.GeneralInstance.BtnPointDeVente.Visible = Form1.GeneralInstance.BtnGestionCategoriesProduits.Visible = Form1.GeneralInstance.BtnRapport.Visible = Form1.GeneralInstance.BtnUtilisateurs.Visible = Form1.GeneralInstance.BtnCommandes.Visible = Form1.GeneralInstance.BtnCharges.Visible = Form1.GeneralInstance.BtnBenefice.Visible = Form1.GeneralInstance.BtnEnvoyerRapportEmail.Visible = Form1.GeneralInstance.SidePanel.Visible = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Attention, votre mot de passe est incorrect !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtMotPasse.Clear();
                    TxtMotPasse.Focus();
                }
            }
        }

        //public void RemplirComboEmployer()
        //{
        //    var table = db.Employer.ToList();

        //    //table.Insert(0, new Employer { CIN = "0", Nom = "TOUS", DateInscription = DateTime.Now, MotPasse = "0", Prenom = "Hi", Role = "Admin" });

        //    CmbNom.DisplayMember = "Nom";
        //    CmbNom.ValueMember = "CIN";
        //    CmbNom.DataSource = table;
        //}

        //public void CheckEmployer(string UserName, string Password)
        //{
        //    var employer = db.Employer.FirstOrDefault(e => e.Prenom.Equals(UserName) && e.MotPasse.Equals(Password));
        //    if (employer != null)
        //    {
        //        this.Hide();
        //        Form1 fr = new Form1();
        //        fr.LblUtilisateur.Text = employer.Prenom;
        //        fr.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Votre nom d'utilisateur ou votre mot de passe est pas valide !", "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        private void Login_Load(object sender, EventArgs e)
        {
            if (!ADO.EspaceNom().Equals(string.Empty))
                LblNomEspace.Text = LblEspaceNom.Text = ADO.EspaceNom();

            ADO.RemplirCombo("GetEmployerName", CmbNom, "Prenom", "CIN", "");
            ADO.RemplirCombo("GetEmployerName", CmbNomReset, "Prenom", "CIN", "");
            pnlImage.BackgroundImage.Tag = "1";
            pnlForgetPwd.Visible = false;
            //RemplirComboEmployer();
            this.Dock = DockStyle.Fill;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //ReportViewer report = new ReportViewer();
            //report.ShowDialog();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            //CheckEmployer(CmbNom.Text, TxtMotPasse.Text);
            Connecter();
        }

        private void TxtMotPasse_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Connecter();
                    //CheckEmployer(CmbNom.Text, TxtMotPasse.Text);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtMotPasse.Focus();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void ShowOrHidePassword_Click(object sender, EventArgs e)
        {
            if (TxtMotPasse.UseSystemPasswordChar)
            {
                TxtMotPasse.UseSystemPasswordChar = false;
                ShowOrHidePassword.Image = Properties.Resources.show1;
            }
            else
            {
                TxtMotPasse.UseSystemPasswordChar = true;
                ShowOrHidePassword.Image = Properties.Resources.hide1;
            }
        }

        private void linkForgetPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pnlImage.BackgroundImage.Tag.ToString() == "1")
            {
                pnlImage.BackgroundImage = null;
                pnlImage.BackgroundImage = Properties.Resources.Forgot_password_cuate;
                pnlImage.BackgroundImage.Tag = "2";
                pnlLogin.SendToBack();
                pnlForgetPwd.Visible = true;
                pnlForgetPwd.BringToFront();
            }
            else
            {
                pnlImage.BackgroundImage = null;
                pnlImage.BackgroundImage = Properties.Resources.Tablet_login_cuate;
                pnlImage.BackgroundImage.Tag = "1";
                pnlForgetPwd.Visible = false;
            }
            TxtMotPasseReset.Focus();
        }

        private void ShowOrHidePasswordReset_Click(object sender, EventArgs e)
        {
            if (TxtMotPasseReset.UseSystemPasswordChar)
            {
                TxtMotPasseReset.UseSystemPasswordChar = false;
                ShowOrHidePasswordReset.Image = Properties.Resources.show1;
            }
            else
            {
                TxtMotPasseReset.UseSystemPasswordChar = true;
                ShowOrHidePasswordReset.Image = Properties.Resources.hide1;
            }
        }

        private void ShowOrHidePasswordResetConfirm_Click(object sender, EventArgs e)
        {
            if (TxtMotPasseResetConfirm.UseSystemPasswordChar)
            {
                TxtMotPasseResetConfirm.UseSystemPasswordChar = false;
                ShowOrHidePasswordResetConfirm.Image = Properties.Resources.show1;
            }
            else
            {
                TxtMotPasseResetConfirm.UseSystemPasswordChar = true;
                ShowOrHidePasswordResetConfirm.Image = Properties.Resources.hide1;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            TxtMotPasse.Text = TxtMotPasseReset.Text = TxtMotPasseResetConfirm.Text = "";
            pnlImage.BackgroundImage = null;
            pnlImage.BackgroundImage = Properties.Resources.Tablet_login_cuate;
            pnlImage.BackgroundImage.Tag = "1";
            pnlForgetPwd.Visible = false;
            TxtMotPasse.Focus();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (CmbNomReset.Text != "")
            {
                if (TxtMotPasseReset.Text != "" && TxtMotPasseResetConfirm.Text != "")
                {
                    if (TxtMotPasseReset.Text == TxtMotPasseResetConfirm.Text)
                    {
                        var IsAdminEmployer = db.Employer.Where(emp => emp.Nom == CmbNomReset.Text && emp.Role == ADO.UserRoles.Admin.ToString()).FirstOrDefault();
                        if (IsAdminEmployer != null)
                        {
                            var IsPasswordExist = db.Employer.Where(emp => emp.MotPasse == TxtMotPasseReset.Text).ToList();
                            //if (IsPasswordExist.Count > 0)
                            //{
                            //    MessageBox.Show("True");
                            //}
                            //else
                            //{
                            //    MessageBox.Show("False");
                            //}
                            if (IsPasswordExist.Count == 0)
                            {
                                string MotDePasse = Cryptography.Encrypt(TxtMotPasseReset.Text.ToString());
                                IsAdminEmployer.MotPasse = MotDePasse;
                                db.SaveChanges();
                                MessageBox.Show("votre mot de passe est bien réinitialisé !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtMotPasseReset.Clear();
                                TxtMotPasseResetConfirm.Clear();
                                TxtMotPasseReset.Focus();
                                CmbNomReset.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }
        }

        private void TxtMotPasse_IconRightClick(object sender, EventArgs e)
        {
            if (TxtMotPasse.UseSystemPasswordChar)
            {
                TxtMotPasse.UseSystemPasswordChar = false;
                TxtMotPasse.IconRight = Properties.Resources.show1;
            }
            else
            {
                TxtMotPasse.UseSystemPasswordChar = true;
                TxtMotPasse.IconRight = Properties.Resources.hide1;
            }
        }

        private void TxtMotPasseReset_Leave(object sender, EventArgs e)
        {
            IsFucused = 0;
            IsTxtMotPasseResetFocused = true;
            IsTxtMotPasseFocused = IsTxtMotPasseConfirmResetFocused = false;
        }

        private void CmbNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtMotPasse.Focus();
        }

        private void BtnCloseChange_Click(object sender, EventArgs e)
        {
            GroupBoxChange.Visible = false;
        }

        private void BtnKeyboard_Click(object sender, EventArgs e)
        {
            if (!GroupBoxChange.Visible)
            {
                GroupBoxChange.Location = new Point(450, 100);
                GroupBoxChange.Visible = true;
                GroupBoxChange.BringToFront();
            }
            else
                GroupBoxChange.Visible = false;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {

        }

        private void BtnNum7_Click(object sender, EventArgs e)
        {
            NumClick("7");
        }

        private void BtnNum9_Click(object sender, EventArgs e)
        {
            NumClick("9");
        }

        private void BtnNum4_Click(object sender, EventArgs e)
        {
            NumClick("4");
        }

        private void BtnNum5_Click(object sender, EventArgs e)
        {
            NumClick("5");
        }

        private void BtnNum6_Click(object sender, EventArgs e)
        {
            NumClick("6");
        }

        private void BtnNum3_Click(object sender, EventArgs e)
        {
            NumClick("3");
        }

        private void BtnNum2_Click(object sender, EventArgs e)
        {
            NumClick("2");
        }

        private void BtnNum1_Click(object sender, EventArgs e)
        {
            NumClick("1");
        }

        private void NumClick(string num)
        {
            if (pnlLogin.Visible)
                TxtMotPasse.Text += num;

            if (pnlForgetPwd.Visible)
            {
                if (IsFucused == 0)
                    TxtMotPasseReset.Text += num;

                if (IsFucused == 1)
                    TxtMotPasseResetConfirm.Text += num;
            }
        }

        private void BtnNum0_Click(object sender, EventArgs e)
        {
            NumClick("0");
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            NumClick("*");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (pnlLogin.Visible)
            {
                if (TxtMotPasse.Text != "")
                {
                    string txt = TxtMotPasse.Text;
                    txt = txt.Remove(txt.Length - 1);
                    TxtMotPasse.Text = txt;
                }
            }

            if (pnlForgetPwd.Visible)
            {
                if (IsTxtMotPasseResetFocused && TxtMotPasseReset.Text != "")
                {
                    string txt = TxtMotPasseReset.Text;
                    txt = txt.Remove(txt.Length - 1);
                    TxtMotPasseReset.Text = txt;
                }

                if (IsTxtMotPasseConfirmResetFocused && TxtMotPasseResetConfirm.Text != "")
                {
                    string txt = TxtMotPasseResetConfirm.Text;
                    txt = txt.Remove(txt.Length - 1);
                    TxtMotPasseResetConfirm.Text = txt;
                }
            }
        }

        private void BtnNum8_Click(object sender, EventArgs e)
        {
            NumClick("8");
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            if (pnlLogin.Visible)
            {
                if (TxtMotPasse.Text != "")
                    TxtMotPasse.Clear();
            }

            if (pnlForgetPwd.Visible)
            {
                if (IsTxtMotPasseResetFocused)
                    TxtMotPasseReset.Clear();

                if (IsTxtMotPasseConfirmResetFocused)
                    TxtMotPasseResetConfirm.Clear();
            }
        }

        private void BtnArobase_Click(object sender, EventArgs e)
        {
            NumClick("@");
        }

        private void BtnSlash_Click(object sender, EventArgs e)
        {
            NumClick("/");
        }

        private void TxtMotPasseResetConfirm_Leave(object sender, EventArgs e)
        {
            IsFucused = 1;
            IsTxtMotPasseConfirmResetFocused = true;
            IsTxtMotPasseResetFocused = IsTxtMotPasseFocused = false;
        }

        private void TxtMotPasse_Click(object sender, EventArgs e)
        {
            if (!GroupBoxChange.Visible)
            {
                GroupBoxChange.Location = new Point(450, 100);
                GroupBoxChange.Visible = true;
                GroupBoxChange.BringToFront();
            }
            else
                GroupBoxChange.Visible = false;
        }

        private void TxtMotPasse_MouseClick(object sender, MouseEventArgs e)
        {
            if (!GroupBoxChange.Visible)
            {
                GroupBoxChange.Location = new Point(450, 100);
                GroupBoxChange.Visible = true;
                GroupBoxChange.BringToFront();
            }
            else
                GroupBoxChange.Visible = false;
        }

        private void TxtMotPasse_Leave(object sender, EventArgs e)
        {
            IsFucused = 1;
            IsTxtMotPasseFocused = true;
            IsTxtMotPasseResetFocused = IsTxtMotPasseConfirmResetFocused = false;
        }
    }
}
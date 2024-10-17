using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using FastFoodDemo.Classes;
using Npgsql;

namespace FastFoodDemo
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        ADO ADO = new ADO();

        public NpgsqlConnection con = new NpgsqlConnection("");

        public static string UserRole;

        //GestionEspaceEntities db = new GestionEspaceEntities();

        public void Connecter()
        {
            string MotPasse = Cryptography.Encrypt(TxtMotPasse.Text);

            ADO.Connecter();

            ADO.sda = new SqlDataAdapter("Select Prenom,Role from Employer Where MotPasse=@MotPasse And Nom=@Nom", ADO.con);
            ADO.sda.SelectCommand.Parameters.AddWithValue("@MotPasse", MotPasse);
            ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom", CmbNom.Text);
            DataTable table = new DataTable();
            ADO.sda.Fill(table);

            if (table.Rows.Count > 0)
            {
                string User = table.Rows[0][0].ToString();
                string Role = table.Rows[0][1].ToString();
                UserRole = Role;
                this.Hide();
                Form1 form = new Form1();
                form.LblUtilisateur.Text = User;
                form.LblRole.Text = Role;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Attention, votre mot de passe est incorrect !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtMotPasse.Clear();
                TxtMotPasse.Focus();
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

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            //CheckEmployer(CmbNom.Text, TxtMotPasse.Text);
            Connecter();
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            ADO.RemplirCombo("GetEmployerName", CmbNom, "Prenom", "CIN", "");
            ADO.RemplirCombo("GetEmployerName", CmbNomReset, "Prenom", "CIN", "");
            pnlImage.BackgroundImage.Tag = "1";
            pnlForgetPwd.Visible = false;
            //RemplirComboEmployer();
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

        private void Connexion_KeyDown(object sender, KeyEventArgs e)
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
            //if (CmbNomReset.Text != "")
            //{
            //    if (TxtMotPasseReset.Text != "" && TxtMotPasseResetConfirm.Text != "")
            //    {
            //        if (TxtMotPasseReset.Text == TxtMotPasseResetConfirm.Text)
            //        {
            //            var IsAdminEmployer = db.Employer.Where(emp => emp.Nom == CmbNomReset.Text && emp.Role == "Admin").FirstOrDefault();
            //            if (IsAdminEmployer != null)
            //            {
            //                var IsPasswordExist = db.Employer.Where(emp => emp.MotPasse == TxtMotPasseReset.Text).ToList();
            //                if (IsPasswordExist.Count > 0)
            //                {
            //                    MessageBox.Show("True");
            //                }
            //                else
            //                {
            //                    MessageBox.Show("False");
            //                }
            //                if (IsPasswordExist.Count == 0)
            //                {
            //                    //string MotDePasse = Cryptography.Encrypt(TxtMotPasseReset.Text.ToString());
            //                    //IsAdminEmployer.MotPasse = MotDePasse;
            //                    //db.SaveChanges();
            //                    //MessageBox.Show("votre mot de passe est réinitialisé !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    //TxtMotPasseReset.Clear();
            //                    //TxtMotPasseResetConfirm.Clear();
            //                    //TxtMotPasseReset.Focus();
            //                    //CmbNomReset.SelectedIndex = 0;
            //                }
            //            }
            //        }
            //    }
            //}
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
            TxtMotPasseResetConfirm.Focus();
        }

        private void CmbNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtMotPasse.Focus();
        }
    }
}
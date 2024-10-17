using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using FastFoodDemo.Classes;
using System.Drawing;

namespace FastFoodDemo.User_Controls
{
    public partial class GestionUtilisateur : UserControl
    {
        public static GestionUtilisateur GestionUtilisateurlInstance;

        public static GestionUtilisateur Instance
        {
            get
            {
                if (GestionUtilisateurlInstance == null)
                {
                    GestionUtilisateurlInstance = new GestionUtilisateur();
                }
                return GestionUtilisateurlInstance;
            }
        }

        public GestionUtilisateur()
        {
            InitializeComponent();
            GestionUtilisateurlInstance = this;
        }

        ADO ADO = new ADO();

        //GestionEspaceEntities db = new GestionEspaceEntities();

        public void Vider()
        {
            try
            {
                TxtCIN.Text = TxtNom.Text = TxtPrenom.Text = TxtMotPasse.Text = "";
                TxtCIN.Enabled = true;
                DPDateInscription.Value = DateTime.Now;
                RDAdmin.Checked = RDGerant.Checked = RDCaissier.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public async void Afficher_Employer()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ADO.con.ConnectionString))
                {
                    // Connection is automatically pooled and reused
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ListeUtilisateurs", connection))
                    {
                        // Execute the command
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            // Process data asynchronously
                            DataTable tableEmployer = new DataTable();
                            tableEmployer.Load(reader);
                            DGVUtilisateurs.DataSource = tableEmployer;
                            if (DGVUtilisateurs.SelectedRows.Count == 1)
                            {
                                DGVUtilisateurs.ClearSelection();
                            }
                            foreach (DataGridViewRow row in DGVUtilisateurs.Rows)
                            {
                                //row.Cells[4].Value = Cryptography.Decrypt(row.Cells[4].Value.ToString());
                                row.Cells[4].Value = Helpers.DecryptPassword(row.Cells[4].Value.ToString());
                            }
                            ADO.Deconnecter();

                            if (DGVUtilisateurs.Rows.Count == 0)
                            {
                                System.Data.DataTable dd = new System.Data.DataTable();
                                //DGVListeImprimantes.Width = 140;
                                //DGVListeImprimantes.Height = 90;
                                dd.Columns.Add("Message");
                                //dd.Columns.Add("Nom");
                                dd.Rows.Add("Pas de données !");
                                DGVUtilisateurs.DataSource = dd;
                                DGVUtilisateurs.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                            }
                        }
                    }
                    //ADO.cmd = new SqlCommand("ListeUtilisateurs", ADO.con);
                    //ADO.dr =  ADO.cmd.ExecuteReader();

                    //DGVUtilisateurs.DataSource = db.Employers
                    //    .Select(e => new
                    //    {
                    //        e.CIN,
                    //        e.Nom,
                    //        e.Prenom,
                    //        e.DateInscription,
                    //        e.MotPasse,
                    //        e.Role
                    //    }).ToList();
                    //DGVUtilisateurs.Columns[2].HeaderText = "Prénom";
                    //DGVUtilisateurs.Columns[3].HeaderText = "Date Inscription";
                    //DGVUtilisateurs.Columns[4].HeaderText = "Mot de Passe";
                    //DGVUtilisateurs.Columns[5].HeaderText = "Rôle";
                    // Perform database operations
                }
                ADO.Connecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Ajouter_Employer()
        {
            try
            {
                //string RoleE = "";
                //if (RDAdmin.Checked == true)
                //{
                //    RoleE = RDAdmin.Text;
                //}
                //else if (RDGerant.Checked == true)
                //{
                //    RoleE = RDGerant.Text;
                //}
                //else if (RDCaissier.Checked == true)
                //{
                //    RoleE = RDCaissier.Text;
                //}

                // List employer :
                //IEnumerable<Employer> ListEmployer = db.Employers;

                // list employer par filtre :
                //var ListEmployer = db.Employers.SqlQuery("select * from Employer where CIN like @CIN", new SqlParameter("@CIN", TxtCIN.Text));

                //foreach (var emp in ListEmployer)
                //{
                //    MessageBox.Show(emp.Nom.ToString());
                //}

                // Ajouter nouveau employer
                //Employer employer = new Employer()
                //{
                //    CIN = TxtCIN.Text,
                //    Nom = TxtNom.Text,
                //    Prenom = TxtPrenom.Text,
                //    DateInscription = DateTime.Parse(DPDateInscription.Value.ToString()),
                //    MotPasse = TxtMotPasse.Text,
                //    Role = RoleE
                //};

                //db.Employers.Add(employer);
                //db.SaveChanges();

                //MessageBox.Show("Employer est bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Vider();
                //TxtCIN.Focus();

                //string MotDePasse = Cryptography.Encrypt(TxtMotPasse.Text.ToString());
                string MotDePasse = Helpers.EncryptPassword(TxtMotPasse.Text);

                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("select CIN,Nom,MotPasse from Employer", ADO.con);
                DataTable tableCIN_Nom = new DataTable();
                ADO.sda.Fill(tableCIN_Nom);
                bool Trouver_CIN = false;
                bool Trouver_Pass = false;
                if (tableCIN_Nom.Rows.Count > 0)
                {
                    for (int i = 0; i < tableCIN_Nom.Rows.Count; i++)
                    {
                        if (tableCIN_Nom.Rows[i][0].ToString() == TxtCIN.Text)
                        {
                            Trouver_CIN = true;
                        }
                        else if (tableCIN_Nom.Rows[i][2].ToString() == TxtMotPasse.Text)
                        {
                            Trouver_Pass = true;
                        }
                    }
                    if (Trouver_CIN == true)
                    {
                        MessageBox.Show("Attention, ce CIN est déjà entrer par un autre employer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TxtCIN.Focus();
                    }
                    else if (Trouver_Pass == true)
                    {
                        MessageBox.Show("Attention, ce Mot de Passe est déjà entrer par un autre employer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TxtMotPasse.Focus();
                    }
                    else
                    {
                        string Role = "";
                        if (RDAdmin.Checked == true)
                        {
                            Role = RDAdmin.Text;
                        }
                        else if (RDGerant.Checked == true)
                        {
                            Role = RDGerant.Text;
                        }
                        else if (RDCaissier.Checked == true)
                        {
                            Role = RDCaissier.Text;
                        }

                        ADO.cmd = new SqlCommand("insert into Employer values(@CIN,@Nom,@Prenom,@Date_Inscription,@Mot_Passe,@Role,@IsDeleted)", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@CIN", TxtCIN.Text);
                        ADO.cmd.Parameters.AddWithValue("@Nom", TxtNom.Text);
                        ADO.cmd.Parameters.AddWithValue("@Prenom", TxtPrenom.Text);
                        ADO.cmd.Parameters.AddWithValue("@Date_Inscription", Convert.ToDateTime(DPDateInscription.Value.ToShortDateString()));
                        ADO.cmd.Parameters.AddWithValue("@Mot_Passe", /*TxtMotPasse.Text*/ MotDePasse);
                        ADO.cmd.Parameters.AddWithValue("@Role", Role);
                        ADO.cmd.Parameters.AddWithValue("@IsDeleted", 0);

                        ADO.cmd.ExecuteNonQuery();

                        MessageBox.Show("Employer est bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Vider();
                        TxtCIN.Focus();
                    }
                }
                else
                {
                    string Role = "";
                    if (RDAdmin.Checked == true)
                    {
                        Role = RDAdmin.Text;
                    }
                    else if (RDGerant.Checked == true)
                    {
                        Role = RDGerant.Text;
                    }
                    else if (RDCaissier.Checked == true)
                    {
                        Role = RDCaissier.Text;
                    }

                    ADO.cmd = new SqlCommand("insert into Employer values(@CIN,@Nom,@Prenom,@Date_Inscription,@Mot_Passe,@Role)", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@CIN", TxtCIN.Text);
                    ADO.cmd.Parameters.AddWithValue("@Nom", TxtNom.Text);
                    ADO.cmd.Parameters.AddWithValue("@Prenom", TxtPrenom.Text);
                    ADO.cmd.Parameters.AddWithValue("@Date_Inscription", Convert.ToDateTime(DPDateInscription.Value.ToShortDateString()));
                    ADO.cmd.Parameters.AddWithValue("@Mot_Passe", /*TxtMotPasse.Text*/ MotDePasse);
                    ADO.cmd.Parameters.AddWithValue("@Role", Role);

                    ADO.cmd.ExecuteNonQuery();

                    MessageBox.Show("Employer est bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Vider();
                    TxtCIN.Focus();
                }
                ADO.Deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Supprimer_Employer()
        {
            try
            {
                ADO.Connecter();

                DialogResult dr = (MessageBox.Show("Voulez-vous vraiment de supprimer cette Employer ?", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));

                if (dr == DialogResult.Yes)
                {
                    //ADO.cmd = new SqlCommand("delete from Employer where CIN=@CIN", ADO.con);
                    ADO.cmd = new SqlCommand("update Employer set IsDeleted=1 where CIN=@CIN", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@CIN", DGVUtilisateurs.SelectedRows[0].Cells[0].Value.ToString());
                    ADO.cmd.ExecuteNonQuery();

                    MessageBox.Show("Employer est bien supprimer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Vider();

                    TxtCIN.Focus();
                }
                else
                {
                    MessageBox.Show("Opération de suppression pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ADO.Deconnecter();

                //GestionEspaceEntities db = new GestionEspaceEntities();

                //var employer = db.Employers.Find(DGVUtilisateurs.CurrentRow.Cells[0].Value.ToString());
                //db.Employers.Remove(employer);
                //db.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Modifier_Employer()
        {
            try
            {
                //string MotDePasse = Cryptography.Encrypt(TxtMotPasse.Text.ToString());
                string MotDePasse = Helpers.EncryptPassword(TxtMotPasse.Text.ToString());

                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("select CIN,Nom,MotPasse from Employer where CIN not like @CIN", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@CIN", DGVUtilisateurs.SelectedRows[0].Cells[0].Value.ToString());
                DataTable tableCIN_Nom = new DataTable();
                ADO.sda.Fill(tableCIN_Nom);
                bool Trouver_CIN = false;
                bool Trouver_Pass = false;
                if (tableCIN_Nom.Rows.Count > 0)
                {
                    for (int i = 0; i < tableCIN_Nom.Rows.Count; i++)
                    {
                        if (tableCIN_Nom.Rows[i][0].ToString() == TxtCIN.Text)
                        {
                            Trouver_CIN = true;
                        }
                        else if (tableCIN_Nom.Rows[i][2].ToString() == TxtMotPasse.Text)
                        {
                            Trouver_Pass = true;
                        }
                    }
                    if (Trouver_CIN == true)
                    {
                        MessageBox.Show("Attention, ce CIN est déjà entré par un autre employer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TxtCIN.Focus();
                    }
                    else if (Trouver_Pass == true)
                    {
                        MessageBox.Show("Attention, ce Mot de Passe est déjà entré par un autre employer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        TxtMotPasse.Focus();
                    }
                    else
                    {
                        string Role = "";
                        if (RDAdmin.Checked)
                        {
                            Role = "Admin";
                        }
                        else if (RDGerant.Checked)
                        {
                            Role = "Gérant";
                        }
                        else if (RDCaissier.Checked)
                        {
                            Role = "Caissier";
                        }

                        ADO.cmd = new SqlCommand("update Employer set Nom=@Nom,Prenom=@Prenom,DateInscription=@Date_Inscription,MotPasse=@Mot_Passe,Role=@Role where CIN=@CIN", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@CIN", TxtCIN.Text);
                        ADO.cmd.Parameters.AddWithValue("@Nom", TxtNom.Text);
                        ADO.cmd.Parameters.AddWithValue("@Prenom", TxtPrenom.Text);
                        ADO.cmd.Parameters.AddWithValue("@Date_Inscription", Convert.ToDateTime(DPDateInscription.Value.ToShortDateString()));
                        ADO.cmd.Parameters.AddWithValue("@Mot_Passe", MotDePasse);
                        ADO.cmd.Parameters.AddWithValue("@Role", Role);
                        ADO.cmd.CommandTimeout = 0;
                        ADO.cmd.ExecuteNonQuery();
                        MessageBox.Show("Employer est bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Vider();
                        TxtCIN.Focus();
                    }
                }
                else if (tableCIN_Nom.Rows.Count == 0)
                {
                    string Role = "";
                    if (RDAdmin.Checked)
                    {
                        Role = "Admin";
                    }
                    else if (RDGerant.Checked)
                    {
                        Role = "Gérant";
                    }
                    else if (RDCaissier.Checked)
                    {
                        Role = "Caissier";
                    }

                    ADO.cmd = new SqlCommand("update Employer set Nom=@Nom,Prenom=@Prenom,DateInscription=@Date_Inscription,MotPasse=@Mot_Passe,Role=@Role where CIN=@CIN", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@CIN", TxtCIN.Text);
                    ADO.cmd.Parameters.AddWithValue("@Nom", TxtNom.Text);
                    ADO.cmd.Parameters.AddWithValue("@Prenom", TxtPrenom.Text);
                    ADO.cmd.Parameters.AddWithValue("@Date_Inscription", Convert.ToDateTime(DPDateInscription.Value.ToShortDateString()));
                    ADO.cmd.Parameters.AddWithValue("@Mot_Passe", MotDePasse);
                    ADO.cmd.Parameters.AddWithValue("@Role", Role);
                    ADO.cmd.CommandTimeout = 0;
                    ADO.cmd.ExecuteNonQuery();
                    MessageBox.Show("Employer est bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Vider();
                    TxtCIN.Focus();
                }
                ADO.Deconnecter();

                //if (employer != null)
                //{


                //    //Employer UpdateEmployer = new Employer()
                //    //{
                //    //    CIN=TxtCIN.Text,
                //    //    Nom = TxtNom.Text,
                //    //    Prenom = TxtPrenom.Text,
                //    //    DateInscription = DateTime.Parse(DPDateInscription.Value.ToShortDateString()),
                //    //    MotPasse = TxtMotPasse.Text,
                //    //    Role = Role
                //    //};
                //}

                //GestionEspaceEntities db = new GestionEspaceEntities();

                //Employer employer = db.Employers.Find("WA451893");

                //if (employer == null)
                //{

                //}
                //else
                //{
                //    string Role = "";
                //    if (RDAdmin.Checked)
                //    {
                //        Role = "Admin";
                //    }
                //    else if (RDGerant.Checked)
                //    {
                //        Role = "Gérant";
                //    }
                //    else if (RDCaissier.Checked)
                //    {
                //        Role = "Caissier";
                //    }

                //    employer.CIN = TxtCIN.Text;
                //    employer.Nom = TxtNom.Text;
                //    employer.Prenom = TxtPrenom.Text;
                //    employer.DateInscription = DateTime.Parse(DPDateInscription.Value.ToShortDateString());
                //    employer.MotPasse = TxtMotPasse.Text;
                //    employer.Role = Role;

                //    db.Entry(employer).State = System.Data.Entity.EntityState.Modified;
                //    db.SaveChanges();
                //}

                //if (employer != null)
                //{
                //    string Role = "";
                //    if (RDAdmin.Checked)
                //    {
                //        Role = "Admin";
                //    }
                //    else if (RDGerant.Checked)
                //    {
                //        Role = "Gérant";
                //    }
                //    else if (RDCaissier.Checked)
                //    {
                //        Role = "Caissier";
                //    }

                //    //Employer UpdateEmployer = new Employer()
                //    //{
                //    //    CIN=TxtCIN.Text,
                //    //    Nom = TxtNom.Text,
                //    //    Prenom = TxtPrenom.Text,
                //    //    DateInscription = DateTime.Parse(DPDateInscription.Value.ToShortDateString()),
                //    //    MotPasse = TxtMotPasse.Text,
                //    //    Role = Role
                //    //};

                //    db.Entry(employer).State = System.Data.Entity.EntityState.Modified;
                //    db.SaveChanges();
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GestionUtilisateur_Load(object sender, EventArgs e)
        {
            DPDateInscription.Value = DateTime.Now;
            Afficher_Employer();
            this.ActiveControl = TxtCIN;
            GroupBoxCategorie.Width = guna2GroupBox1.Width = Form1.GeneralInstance.PnlAffichage.Width - 25;
            this.TxtCIN.Focus();
            this.Dock = DockStyle.Fill;
        }

        private void DGVUtilisateurs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGVUtilisateurs.Rows.Count > 0)
                {
                    if (DGVUtilisateurs.SelectedRows.Count == 1)
                    {
                        TxtCIN.Text = DGVUtilisateurs.SelectedRows[0].Cells[0].Value.ToString();
                        TxtCIN.Enabled = false;
                        TxtNom.Text = DGVUtilisateurs.SelectedRows[0].Cells[1].Value.ToString();
                        TxtPrenom.Text = DGVUtilisateurs.SelectedRows[0].Cells[2].Value.ToString();
                        DPDateInscription.Text = DGVUtilisateurs.SelectedRows[0].Cells[3].Value.ToString();
                        TxtMotPasse.Text = DGVUtilisateurs.SelectedRows[0].Cells[4].Value.ToString();
                        if (DGVUtilisateurs.SelectedRows[0].Cells[5].Value.ToString() == ADO.UserRoles.Admin.ToString())
                        {
                            RDAdmin.Checked = true;
                            RDGerant.Checked = RDCaissier.Checked = false;
                        }
                        else if (DGVUtilisateurs.SelectedRows[0].Cells[5].Value.ToString() == ADO.UserRoles.Gérant.ToString())
                        {
                            RDGerant.Checked = true;
                            RDAdmin.Checked = RDCaissier.Checked = false;
                        }
                        else if (DGVUtilisateurs.SelectedRows[0].Cells[5].Value.ToString() == ADO.UserRoles.Caissier.ToString())
                        {
                            RDCaissier.Checked = true;
                            RDGerant.Checked = RDAdmin.Checked = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCIN.Text != "" && TxtNom.Text != "" && TxtPrenom.Text != "" && RDAdmin.Checked == true || RDGerant.Checked == true || RDCaissier.Checked == true)
                {
                    Ajouter_Employer();
                    Afficher_Employer();
                }
                else
                {
                    MessageBox.Show("Attention, veuillez remplir les champs !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtCIN.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVUtilisateurs.Rows.Count > 0)
                {
                    if (DGVUtilisateurs.SelectedRows.Count == 1)
                    {
                        Supprimer_Employer();
                        Afficher_Employer();
                    }
                    else
                    {
                        MessageBox.Show("Attention, veuillez choisir une ligne dans la table !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Attention, aucun ligne dans la table !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVUtilisateurs.Rows.Count > 0)
                {
                    if (DGVUtilisateurs.SelectedRows.Count == 1)
                    {
                        if (TxtCIN.Text != "" && TxtNom.Text != "" && TxtPrenom.Text != "" && DPDateInscription.Value < DateTime.Now && RDAdmin.Checked == true || RDGerant.Checked == true || RDCaissier.Checked == true)
                        {
                            Modifier_Employer();
                            Afficher_Employer();
                        }
                        else
                        {
                            MessageBox.Show("Attention, veuillez remplir les champs !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            TxtCIN.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Attention, veuillez choisir une ligne dans la table !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Attention, aucun ligne dans la table !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtMotPasse_Leave(object sender, EventArgs e)
        {
            

            //if (TxtMotPasse.Text != string.Empty)
            //{
            //    string Password = Cryptography.Encrypt(TxtMotPasse.Text.ToString());   // Passing the Password to Encrypt method and the method will return encrypted string and stored in Password variable.
            //    label6.Text = Password;
            //}
        }

        private void TxtMotPasse_MouseHover(object sender, EventArgs e)
        {
            //if (TxtMotPasse.Text != string.Empty)
            //{
            //    string Password = Cryptography.Decrypt(label6.Text);
            //    label6.Text = Password;
            //    TxtNom.Text = Password;
            //}

        }

        private void DGVUtilisateurs_Paint(object sender, PaintEventArgs e)
        {
            if (DGVUtilisateurs.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "No records found !",
                    DGVUtilisateurs.Font, DGVUtilisateurs.ClientRectangle,
                    DGVUtilisateurs.ForeColor, DGVUtilisateurs.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void myDatagridView1_Paint(object sender, PaintEventArgs e)
        {
            if (DGVUtilisateurs.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "No records found.",
                    DGVUtilisateurs.Font, DGVUtilisateurs.ClientRectangle,
                    DGVUtilisateurs.ForeColor, DGVUtilisateurs.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void BtnDeconnecter_Click(object sender, EventArgs e)
        {
            Form1.GeneralInstance.BtnHideOrShowSideBar.Enabled = true;
            if (Form1.GeneralInstance.PnlAffichage.Controls.ContainsKey("PointDeVente"))
            {
                if (ADO.CheckEspaceTables() && ADO.CheckEspaceType().Equals(ADO.EspaceTypes.Restaurant.ToString()))
                {
                    Form1.GeneralInstance.IconZone.Visible = Form1.GeneralInstance.LblZone.Visible = Form1.GeneralInstance.IconNumTable.Visible = Form1.GeneralInstance.LblNumTable.Visible = false;
                    Form1.GeneralInstance.PnlAffichage.Controls.Remove(new PointDeVente());
                    new PointDeVente().Dispose();
                    Form1.GeneralInstance.PnlAffichage.Controls.Clear();
                    Form1.GeneralInstance.PnlAffichage.Controls.Add(new User_Controls.TablesEspace());
                }
                else
                {
                    if (Form1.GeneralInstance.LblRole.Text.Equals(ADO.UserRoles.Caissier.ToString()))
                    {
                        if (ADO.CheckEspaceTables())
                        {
                            if (Form1.GeneralInstance.PnlAffichage.Controls.ContainsKey("TablesEspace"))
                            {
                                Form1.GeneralInstance.PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
                                new User_Controls.TablesEspace().Dispose();
                                Form1.GeneralInstance.PnlAffichage.Controls.Clear();
                                Form1.GeneralInstance.PnlAffichage.Controls.Add(new Login());
                            }
                            else
                            {
                                Form1.GeneralInstance.PnlAffichage.Controls.Remove(new PointDeVente());
                                new PointDeVente().Dispose();
                                Form1.GeneralInstance.PnlAffichage.Controls.Clear();
                                Form1.GeneralInstance.PnlAffichage.Controls.Add(new Login());
                                Form1.GeneralInstance.PnlHeader.Visible = false;
                            }
                        }
                        else
                        {
                            Form1.GeneralInstance.PnlAffichage.Controls.Remove(new PointDeVente());
                            new PointDeVente().Dispose();
                            Form1.GeneralInstance.PnlAffichage.Controls.Clear();
                            Form1.GeneralInstance.PnlAffichage.Controls.Add(new Login());
                            Form1.GeneralInstance.PnlHeader.Visible = false;
                        }
                    }
                    else
                    {
                        Form1.GeneralInstance.SideBar.Visible = true;
                        Form1.GeneralInstance.SidePanel.Height = Form1.GeneralInstance.BtnHome.Height;
                        Form1.GeneralInstance.SidePanel.Top = Form1.GeneralInstance.BtnHome.Top;
                        Form1.GeneralInstance.PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
                        new User_Controls.TablesEspace().Dispose();
                        Form1.GeneralInstance.PnlAffichage.Controls.Clear();
                        Form1.GeneralInstance.PnlAffichage.Controls.Add(new FirstCustomControl());
                        Form1.GeneralInstance.IconZone.Visible = Form1.GeneralInstance.LblZone.Visible = Form1.GeneralInstance.IconNumTable.Visible = Form1.GeneralInstance.LblNumTable.Visible = false;
                    }
                }

                PointDeVente.ticketCuisine.Close();
                PointDeVente.ticketCuisine.Dispose();

                PointDeVente.ticketClient.Close();
                PointDeVente.ticketClient.Dispose();
            }
            else if (Form1.GeneralInstance.PnlAffichage.Controls.ContainsKey("TablesEspace"))
            {
                if (Form1.GeneralInstance.LblRole.Text.Equals(ADO.UserRoles.Caissier.ToString()))
                {
                    Form1.GeneralInstance.PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
                    new User_Controls.TablesEspace().Dispose();
                    Form1.GeneralInstance.PnlAffichage.Controls.Clear();
                    Form1.GeneralInstance.PnlAffichage.Controls.Add(new Login());
                }
                Form1.GeneralInstance.SideBar.Visible = true;
                Form1.GeneralInstance.SidePanel.Height = Form1.GeneralInstance.BtnHome.Height;
                Form1.GeneralInstance.SidePanel.Top = Form1.GeneralInstance.BtnHome.Top;
                Form1.GeneralInstance.PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
                new User_Controls.TablesEspace().Dispose();
                Form1.GeneralInstance.PnlAffichage.Controls.Clear();
                Form1.GeneralInstance.PnlAffichage.Controls.Add(new FirstCustomControl());
            }
            else if (!Form1.GeneralInstance.PnlAffichage.Controls.ContainsKey("TablesEspace") || Form1.GeneralInstance.PnlAffichage.Controls.ContainsKey("PointDeVente"))
            {
                Form1.GeneralInstance.PnlAffichage.Controls.Remove(new PointDeVente());
                new PointDeVente().Dispose();
                Form1.GeneralInstance.PnlAffichage.Controls.Clear();
                Form1.GeneralInstance.PnlAffichage.Controls.Add(new Login());
                Form1.GeneralInstance.SideBar.Visible = Form1.GeneralInstance.SidePanel.Visible = Form1.GeneralInstance.PnlHeader.Visible = false;
            }
        }

        private void BtnParametre_Click(object sender, EventArgs e)
        {
            if (!Form1.GeneralInstance.PnlAffichage.Controls.ContainsKey("ParamEspace"))
            {
                Form1.GeneralInstance.SidePanel.Visible = true;
                Form1.GeneralInstance.SidePanel.Visible = false;
                Form1.GeneralInstance.PnlAffichage.Controls.Clear();
                Form1.GeneralInstance.PnlAffichage.Controls.Add(new ParamEspace());
            }
        }

        private void TxtCIN_Leave(object sender, EventArgs e)
        {
            //if (TxtCIN.Text == "")
            //{
            //    LblErrorMessageCIN.Visible = true;
            //}
            //else
            //{
            //    LblErrorMessageCIN.Visible = false;
            //}
        }

        private void TxtNom_Leave(object sender, EventArgs e)
        {
            
        }

        private void TxtPrenom_Leave(object sender, EventArgs e)
        {
            
        }

        private void DGVUtilisateurs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
                else
                {
                    e.Value = "Null";
                }
            }
        }

        private void TxtCIN_TextChanged(object sender, EventArgs e)
        {
            //if (TxtCIN.Text == "")
            //{
            //    LblErrorMessageCIN.Visible = true;
            //}
            //else
            //{
            //    LblErrorMessageCIN.Visible = false;
            //}
        }

        private void TxtNom_TextChanged(object sender, EventArgs e)
        {
            //if (TxtNom.Text == "")
            //{
            //    LblErrorMessageNom.Visible = true;
            //}
            //else
            //{
            //    LblErrorMessageNom.Visible = false;
            //}
        }

        private void TxtPrenom_TextChanged(object sender, EventArgs e)
        {
            //if (TxtPrenom.Text == "")
            //{
            //    LblErrorMessagePrenom.Visible = true;
            //}
            //else
            //{
            //    LblErrorMessagePrenom.Visible = false;
            //}
        }

        private void TxtMotPasse_TextChanged(object sender, EventArgs e)
        {
            //if (TxtMotPasse.Text == "")
            //{
            //    LblErrorMessageMotPasse.Visible = true;
            //}
            //else
            //{
            //    LblErrorMessageMotPasse.Visible = false;
            //}
        }
    }
}
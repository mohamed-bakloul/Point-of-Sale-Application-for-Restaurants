using FastFoodDemo.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FastFoodDemo.User_Controls
{
    public partial class ParametreTables : UserControl
    {
        public static ParametreTables ParametreTablesInstance;

        public static ParametreTables Instance
        {
            get
            {
                if (ParametreTablesInstance == null)
                {
                    ParametreTablesInstance = new ParametreTables();
                }
                return ParametreTablesInstance;
            }
        }

        public ParametreTables()
        {
            InitializeComponent();
            ParametreTablesInstance = this;
        }

        ADO ADO = new ADO();

        public void Remplir_Zone_E_Disponible()
        {
            try
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("select Id_Zone from Zone_Disponible_Emp where Id_Zone not in (select Id_Zone from Zone_Emporter) order by Id_Zone asc", ADO.con);
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                ADO.Deconnecter();
                if (table.Rows.Count != 0)
                {
                    CmbEmplEmp.DataSource = table;
                    CmbEmplEmp.DisplayMember = "Id_Zone";
                    CmbEmplEmp.Enabled = TboxNomZonEmp.Enabled = CmbNbrTblEmp.Enabled = true;
                }
                else
                {
                    CmbEmplEmp.Enabled = false;
                    TboxNomZonEmp.Enabled = false;
                    CmbNbrTblEmp.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Remplir_Zone_P_Disponible()
        {
            //try
            //{
            //    ADO.Connecter();
            //    ADO.sda = new SqlDataAdapter("select Id_Zone from Zone_Disponible_P where Id_Zone not in (select Id_Zone from Zone_Principale) order by Id_Zone asc", ADO.con);
            //    DataTable table = new DataTable();
            //    ADO.sda.Fill(table);
            //    ADO.Deconnecter();
            //    if (table.Rows.Count != 0)
            //    {
            //        CmbEmplPrinc.DataSource = table;
            //        CmbEmplPrinc.DisplayMember = "Id_Zone";
            //        CmbEmplPrinc.Enabled = TboxNomZonPrinc.Enabled = CmbNbrTblPrinc.Enabled = true;
            //    }
            //    else
            //    {
            //        //CmbEmplPrinc.Text = "";
            //        CmbEmplPrinc.Enabled = TboxNomZonPrinc.Enabled = CmbNbrTblPrinc.Enabled = false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            ADO.RemplirCombo("GetZoneDisponiblePrincipaleId", CmbEmplPrinc, "Id_Zone", "Id_Zone", "Vide");
            if (CmbEmplPrinc.Items.Count == 0)
                CmbEmplPrinc.Enabled = TboxNomZonPrinc.Enabled = CmbNbrTblPrinc.Enabled = false;
        }

        public void Disponible_Zone_E_True()
        {
            try
            {
                ADO.Connecter();
                ADO.cmd = new SqlCommand("update Zone_Disponible_Emp set Disponible=1 where Id_Zone=@Id_Zone", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Id_Zone", CmbEmplEmp.Text);
                ADO.cmd.ExecuteNonQuery();
                ADO.Deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Disponible_Zone_P_True()
        {
            try
            {
                ADO.Connecter();
                ADO.cmd = new SqlCommand("update Zone_Disponible_P set Disponible=1 where Id_Zone=@Id_Zone", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Id_Zone", int.Parse(CmbEmplPrinc.Text));
                ADO.cmd.ExecuteNonQuery();
                ADO.Deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Disponible_Zone_E_False()
        {
            try
            {
                ADO.Connecter();
                ADO.cmd = new SqlCommand("update Zone_Disponible_Emp set Disponible=0 where Id_Zone=@Id_Zone", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Id_Zone", CmbEmplEmp.Text);
                ADO.cmd.ExecuteNonQuery();
                ADO.Deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Disponible_Zone_P_False()
        {
            try
            {
                ADO.Connecter();
                ADO.cmd = new SqlCommand("update Zone_Disponible_P set Disponible=0 where Id_Zone=@Id_Zone", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Id_Zone", int.Parse(CmbEmplPrinc.Text));
                ADO.cmd.ExecuteNonQuery();
                ADO.Deconnecter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Remplir_Zone()
        {
            try
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("select Id_Zone as 'Emplacement',Nom_Zone as 'Nom',Nombre_Table as 'Nombre Table' from Zone_Principale", ADO.con);
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                DGV_Zone_Principale.DataSource = table;
                ADO.Deconnecter();

                if (DGV_Zone_Principale.Rows.Count == 0)
                {
                    System.Data.DataTable dd = new System.Data.DataTable();
                    //DGVListeImprimantes.Width = 140;
                    //DGVListeImprimantes.Height = 90;
                    dd.Columns.Add("Message");
                    //dd.Columns.Add("Nom");
                    dd.Rows.Add("Pas de données !");
                    DGV_Zone_Principale.DataSource = dd;
                    DGV_Zone_Principale.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Ajouter_Zone()
        {
            try
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("select Id_Zone from Zone_Principale where Id_Zone=@Id_Zone", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Zone", int.Parse(CmbEmplPrinc.Text));
                DataTable dataTable = new DataTable();
                ADO.sda.Fill(dataTable);
                if (dataTable.Rows.Count != 0)
                {
                    MessageBox.Show("Attention, Emplacement de Zone seléctionner est occupée !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ADO.sda = new SqlDataAdapter("select Id_Zone from Zone_Principale where Nom_Zone=@Nom_Zone", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom_Zone", TboxNomZonPrinc.Text);
                    DataTable d = new DataTable();
                    ADO.sda.Fill(d);
                    if (d.Rows.Count != 0)
                    {
                        MessageBox.Show("Attention, Nom de Zone saisie est déjà existe !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ADO.cmd = new SqlCommand("insert into Zone_Principale values(@Id_Zone,@Nom_Zone,@Nombre_Table)", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@Id_Zone", int.Parse(CmbEmplPrinc.Text));
                        ADO.cmd.Parameters.AddWithValue("@Nom_Zone", TboxNomZonPrinc.Text);
                        ADO.cmd.Parameters.AddWithValue("@Nombre_Table", CmbNbrTblPrinc.Text);
                        ADO.cmd.ExecuteNonQuery();

                        ADO.sda = new SqlDataAdapter("select Nombre_Table,Nom_Zone from Zone_Principale where Id_Zone=@Id_Zone", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Zone", int.Parse(CmbEmplPrinc.Text));
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);
                        Label label = new Label();
                        label.Text = table.Rows[0][1].ToString();
                        int Nombre_Table = Convert.ToInt32(table.Rows[0][0].ToString());
                        if (table.Rows.Count != 0)
                        {
                            for (int i = 1; i <= Nombre_Table; i++)
                            {
                                Button button = new Button();
                                button.Name = "Table " + i.ToString();
                                ADO.cmd = new SqlCommand("insert into TablesEspace values(@Reference,@Nom,@Etat)", ADO.con);
                                ADO.cmd.Parameters.AddWithValue("@Reference", label.Text);
                                ADO.cmd.Parameters.AddWithValue("@Nom", (label.Text + " " + button.Name));
                                ADO.cmd.Parameters.AddWithValue("@Etat", 0);
                                ADO.cmd.ExecuteNonQuery();
                            }
                        }
                        ADO.Deconnecter();
                        Remplir_Zone();
                        MessageBox.Show("Zone bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //CmbEmplPrinc.Text = "";
                        TboxNomZonPrinc.Text = "";
                        CmbNbrTblPrinc.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Modifier_Zone()
        {
            try
            {
                ADO.Connecter();

                string NomZoneOld = DGV_Zone_Principale.SelectedRows[0].Cells[1].Value.ToString();
                string NomZoneNew = TboxNomZonPrinc.Text;
                int NbrTblOld = int.Parse(DGV_Zone_Principale.SelectedRows[0].Cells[2].Value.ToString());
                int NbrTblNew = int.Parse(CmbNbrTblPrinc.Text);

                if (NomZoneOld != NomZoneNew)
                {
                    ADO.cmd = new SqlCommand("update Zone_Principale set Nom_Zone=@Nom_Zone,Nombre_Table=@Nombre_Table where Id_Zone=@Id_Zone", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Nom_Zone", TboxNomZonPrinc.Text);
                    ADO.cmd.Parameters.AddWithValue("@Nombre_Table", CmbNbrTblPrinc.Text);
                    ADO.cmd.Parameters.AddWithValue("@Id_Zone", DGV_Zone_Principale.SelectedRows[0].Cells[0].Value.ToString());
                    ADO.cmd.ExecuteNonQuery();

                    TxtEmplPrinc.Visible = false;
                    CmbEmplPrinc.Enabled = CmbEmplPrinc.Visible = true;
                    TboxNomZonPrinc.Text = "";
                    CmbNbrTblPrinc.SelectedIndex = 0;
                    ADO.Deconnecter();
                    Remplir_Zone();
                    MessageBox.Show("Zone Principale bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (NbrTblOld != NbrTblNew || NomZoneOld != NomZoneNew)
                {
                    ADO.sda = new SqlDataAdapter("select Reference from TablesEspace where Reference=@Ref and Etat!=0", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Ref", DGV_Zone_Principale.SelectedRows[0].Cells[1].Value.ToString());
                    DataTable a = new DataTable();
                    ADO.sda.Fill(a);
                    if (a.Rows.Count == 0)
                    {
                        //string NomZoneOld = a.Rows[0][0].ToString();

                        ADO.sda = new SqlDataAdapter("select Nombre_Table from Zone_Principale where Nom_Zone=@Nom_Zone", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom_Zone", NomZoneOld);
                        DataTable tableNbrTblOld = new DataTable();
                        ADO.sda.Fill(tableNbrTblOld);

                        //int NbrTblOld = int.Parse(tableNbrTblOld.Rows[0][0].ToString());
                        //int NbrTblNew = int.Parse(CmbNbrTblPrinc.Text);

                        if (NbrTblOld < NbrTblNew)
                        {
                            for (int i = NbrTblOld + 1; i <= NbrTblNew; i++)
                            {
                                Button button = new Button();
                                button.Name = "Table " + i.ToString();
                                ADO.cmd = new SqlCommand("insert into TablesEspace values(@Reference,@Nom,@Etat)", ADO.con);
                                ADO.cmd.Parameters.AddWithValue("@Reference", TboxNomZonPrinc.Text);
                                ADO.cmd.Parameters.AddWithValue("@Nom", (TboxNomZonPrinc.Text + " " + button.Name));
                                ADO.cmd.Parameters.AddWithValue("@Etat", 0);
                                ADO.cmd.ExecuteNonQuery();
                            }

                            ADO.cmd = new SqlCommand("update Zone_Principale set Nom_Zone=@Nom_Zone,Nombre_Table=@Nombre_Table where Id_Zone=@Id_Zone", ADO.con);
                            ADO.cmd.Parameters.AddWithValue("@Nom_Zone", TboxNomZonPrinc.Text);
                            ADO.cmd.Parameters.AddWithValue("@Nombre_Table", CmbNbrTblPrinc.Text);
                            ADO.cmd.Parameters.AddWithValue("@Id_Zone", DGV_Zone_Principale.SelectedRows[0].Cells[0].Value.ToString());
                            ADO.cmd.ExecuteNonQuery();

                            //CmbEmplPrinc.Text = "";
                            TboxNomZonPrinc.Text = "";
                            CmbNbrTblPrinc.SelectedIndex = 0;
                            ADO.Deconnecter();
                            Remplir_Zone();
                            MessageBox.Show("Zone Principale bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CmbEmplPrinc.Enabled = true;
                        }
                        else if (NbrTblOld > NbrTblNew)
                        {
                            for (int i = NbrTblOld; i > NbrTblNew; i--)
                            {
                                Button button = new Button();
                                button.Name = "Table " + i.ToString();
                                ADO.cmd = new SqlCommand("delete from TablesEspace where Nom=@Nom", ADO.con);
                                ADO.cmd.Parameters.AddWithValue("@Nom", (TboxNomZonPrinc.Text + " " + button.Name));
                                ADO.cmd.ExecuteNonQuery();
                            }

                            ADO.cmd = new SqlCommand("update Zone_Principale set Nom_Zone=@Nom_Zone,Nombre_Table=@Nombre_Table where Id_Zone=@Id_Zone", ADO.con);
                            ADO.cmd.Parameters.AddWithValue("@Nom_Zone", TboxNomZonPrinc.Text);
                            ADO.cmd.Parameters.AddWithValue("@Nombre_Table", CmbNbrTblPrinc.Text);
                            ADO.cmd.Parameters.AddWithValue("@Id_Zone", DGV_Zone_Principale.SelectedRows[0].Cells[0].Value.ToString());
                            ADO.cmd.ExecuteNonQuery();

                            //CmbEmplPrinc.Text = "";
                            TboxNomZonPrinc.Text = "";
                            CmbNbrTblPrinc.SelectedIndex = 0;
                            ADO.Deconnecter();
                            Remplir_Zone();
                            MessageBox.Show("Zone Principale bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CmbEmplPrinc.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Attention, pour cette zone il y'a des table avec des commandes !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    TxtEmplPrinc.Visible = false;
                    CmbEmplPrinc.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Supprimer_Zone()
        {
            try
            {
                ADO.Connecter();
                if (DGV_Zone_Principale.Rows.Count != 0)
                {
                    if (DGV_Zone_Principale.SelectedRows.Count != 0)
                    {
                        DialogResult dr = (MessageBox.Show("Voulez-vous vraiment supprimer cette Zone ?", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
                        if (dr == DialogResult.Yes)
                        {
                            ADO.sda = new SqlDataAdapter("select distinct Reference from TablesEspace where Etat<>0 and Reference=@Reference", ADO.con);
                            ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", DGV_Zone_Principale.SelectedRows[0].Cells[1].Value.ToString());
                            DataTable a = new DataTable();
                            ADO.sda.Fill(a);
                            /**/
                            if (a.Rows.Count != 0)
                            {
                                MessageBox.Show("Attention, Vous avez une ou plusieurs commandes dans cette zone que vous devez confirmer ou annuler !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                ADO.cmd = new SqlCommand("delete from Zone_Principale where Id_Zone=@Id_Zone", ADO.con);
                                ADO.cmd.Parameters.AddWithValue("@Id_Zone", DGV_Zone_Principale.SelectedRows[0].Cells[0].Value.ToString());
                                ADO.cmd.ExecuteNonQuery();
                                ADO.cmd = new SqlCommand("delete from TablesEspace where Reference=@Ref", ADO.con);
                                ADO.cmd.Parameters.AddWithValue("@Ref", DGV_Zone_Principale.SelectedRows[0].Cells[1].Value.ToString());
                                ADO.cmd.ExecuteNonQuery();
                                ADO.Deconnecter();
                                Remplir_Zone();
                                Disponible_Zone_P_False();
                                MessageBox.Show("Zone bien supprimer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Remplir_Zone_P_Disponible();
                                //CmbEmplPrinc.Text = "";
                                TboxNomZonPrinc.Text = "";
                                CmbNbrTblPrinc.SelectedIndex = 0;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Opération pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Remplir_Zone_Emporter()
        {
            try
            {
                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("select Id_Zone as 'Emplacement',Nom_Zone as 'Nom',Nombre_Table as 'Nombre Table' from Zone_Emporter", ADO.con);
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                DGV_Zone_Emporter.DataSource = table;

                ADO.Deconnecter();

                if (DGV_Zone_Emporter.Rows.Count == 0)
                {
                    System.Data.DataTable dd = new System.Data.DataTable();
                    //DGVListeImprimantes.Width = 140;
                    //DGVListeImprimantes.Height = 90;
                    dd.Columns.Add("Message");
                    //dd.Columns.Add("Nom");
                    dd.Rows.Add("Pas de données !");
                    DGV_Zone_Emporter.DataSource = dd;
                    DGV_Zone_Emporter.Columns["Message"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //DGVListeImprimanteParCategories.Rows[0].Cells[0].Style.Font = new Font("Century gothic", 50);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Ajouter_Zone_Emporter()
        {
            try
            {
                ADO.Connecter();

                ADO.cmd = new SqlCommand("insert into Zone_Emporter values(@Id_Zone,@Nom_Zone,@Nombre_Table)", ADO.con);
                ADO.cmd.Parameters.AddWithValue("@Id_Zone", CmbEmplEmp.Text);
                ADO.cmd.Parameters.AddWithValue("@Nom_Zone", TboxNomZonEmp.Text);
                ADO.cmd.Parameters.AddWithValue("@Nombre_Table", CmbNbrTblEmp.Text);
                ADO.cmd.ExecuteNonQuery();

                ADO.sda = new SqlDataAdapter("select Nombre_Table,Nom_Zone from Zone_Emporter where Id_Zone=@Id_Zone", ADO.con);
                ADO.sda.SelectCommand.Parameters.AddWithValue("@Id_Zone", CmbEmplEmp.Text);
                DataTable table = new DataTable();
                ADO.sda.Fill(table);
                Label label = new Label();
                label.Text = table.Rows[0][1].ToString();
                int Nombre_Table = Convert.ToInt32(table.Rows[0][0].ToString());
                if (table.Rows.Count != 0)
                {
                    for (int i = 1; i <= Nombre_Table; i++)
                    {
                        Button button = new Button();
                        button.Name = "Table " + i.ToString();
                        ADO.cmd = new SqlCommand("insert into TablesEspace values(@Reference,@Nom,@Etat)", ADO.con);
                        ADO.cmd.Parameters.AddWithValue("@Reference", label.Text);
                        ADO.cmd.Parameters.AddWithValue("@Nom", (label.Text + " " + button.Name));
                        ADO.cmd.Parameters.AddWithValue("@Etat", 0);
                        ADO.cmd.ExecuteNonQuery();
                    }
                }

                CmbEmplEmp.Text = "";
                TboxNomZonEmp.Text = "";
                CmbNbrTblEmp.SelectedIndex = 0;
                ADO.Deconnecter();
                Remplir_Zone_Emporter();
                MessageBox.Show("Zone Emporter bien ajouter !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Modifier_Zone_Emporter()
        {
            try
            {
                ADO.Connecter();

                string NomZoneOld = DGV_Zone_Emporter.SelectedRows[0].Cells[1].Value.ToString();
                string NomZoneNew = TboxNomZonEmp.Text;
                int NbrTblOld = int.Parse(DGV_Zone_Emporter.SelectedRows[0].Cells[2].Value.ToString());
                int NbrTblNew = int.Parse(CmbNbrTblEmp.Text);

                if (NomZoneOld != NomZoneNew)
                {
                    ADO.cmd = new SqlCommand("update Zone_Emporter set Nom_Zone=@Nom_Zone,Nombre_Table=@Nombre_Table where Id_Zone=@Id_Zone", ADO.con);
                    ADO.cmd.Parameters.AddWithValue("@Nom_Zone", TboxNomZonEmp.Text);
                    ADO.cmd.Parameters.AddWithValue("@Nombre_Table", CmbNbrTblEmp.Text);
                    ADO.cmd.Parameters.AddWithValue("@Id_Zone", DGV_Zone_Emporter.SelectedRows[0].Cells[0].Value.ToString());
                    ADO.cmd.ExecuteNonQuery();

                    CmbEmplEmp.Text = "";
                    TboxNomZonEmp.Text = "";
                    CmbNbrTblEmp.SelectedIndex = 0;
                    CmbEmplEmp.Enabled = CmbEmplEmp.Visible = true;
                    TxtEmplEmp.Visible = false;
                    ADO.Deconnecter();
                    Remplir_Zone_Emporter();
                    MessageBox.Show("Zone Emporter bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (NbrTblOld != NbrTblNew)
                {
                    ADO.sda = new SqlDataAdapter("select Reference from TablesEspace where Reference=@Ref and Etat!=0", ADO.con);
                    ADO.sda.SelectCommand.Parameters.AddWithValue("@Ref", NomZoneOld);
                    DataTable a = new DataTable();
                    ADO.sda.Fill(a);
                    if (a.Rows.Count == 0)
                    {
                        //string NomZoneOld = a.Rows[0][0].ToString();

                        ADO.sda = new SqlDataAdapter("select Nombre_Table from Zone_Principale where Nom_Zone=@Nom_Zone", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom_Zone", NomZoneOld);
                        DataTable tableNbrTblOld = new DataTable();
                        ADO.sda.Fill(tableNbrTblOld);

                        //int NbrTblOld = int.Parse(tableNbrTblOld.Rows[0][0].ToString());
                        //int NbrTblNew = int.Parse(CmbNbrTblPrinc.Text);

                        if (NbrTblOld < NbrTblNew)
                        {
                            for (int i = NbrTblOld + 1; i <= NbrTblNew; i++)
                            {
                                Button button = new Button();
                                button.Name = "Table " + i.ToString();
                                ADO.cmd = new SqlCommand("insert into TablesEspace values(@Reference,@Nom,@Etat)", ADO.con);
                                ADO.cmd.Parameters.AddWithValue("@Reference", TboxNomZonEmp.Text);
                                ADO.cmd.Parameters.AddWithValue("@Nom", (TboxNomZonEmp.Text + " " + button.Name));
                                ADO.cmd.Parameters.AddWithValue("@Etat", 0);
                                ADO.cmd.ExecuteNonQuery();
                            }

                            ADO.cmd = new SqlCommand("update Zone_Emporter set Nom_Zone=@Nom_Zone,Nombre_Table=@Nombre_Table where Id_Zone=@Id_Zone", ADO.con);
                            ADO.cmd.Parameters.AddWithValue("@Nom_Zone", TboxNomZonEmp.Text);
                            ADO.cmd.Parameters.AddWithValue("@Nombre_Table", CmbNbrTblEmp.Text);
                            ADO.cmd.Parameters.AddWithValue("@Id_Zone", DGV_Zone_Emporter.SelectedRows[0].Cells[0].Value.ToString());
                            ADO.cmd.ExecuteNonQuery();

                            CmbEmplEmp.Text = "";
                            TboxNomZonEmp.Text = "";
                            CmbNbrTblEmp.SelectedIndex = 0;
                            ADO.Deconnecter();
                            Remplir_Zone_Emporter();
                            MessageBox.Show("Zone Emporter bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CmbEmplEmp.Enabled = true;
                        }
                        else if (NbrTblOld > NbrTblNew)
                        {
                            for (int i = NbrTblOld; i > NbrTblNew; i--)
                            {
                                Button button = new Button();
                                button.Name = "Table " + i.ToString();
                                ADO.cmd = new SqlCommand("delete from TablesEspace where Nom=@Nom", ADO.con);
                                ADO.cmd.Parameters.AddWithValue("@Nom", (TboxNomZonEmp.Text + " " + button.Name));
                                ADO.cmd.ExecuteNonQuery();
                            }

                            ADO.cmd = new SqlCommand("update Zone_Emporter set Nom_Zone=@Nom_Zone,Nombre_Table=@Nombre_Table where Id_Zone=@Id_Zone", ADO.con);
                            ADO.cmd.Parameters.AddWithValue("@Nom_Zone", TboxNomZonEmp.Text);
                            ADO.cmd.Parameters.AddWithValue("@Nombre_Table", CmbNbrTblEmp.Text);
                            ADO.cmd.Parameters.AddWithValue("@Id_Zone", DGV_Zone_Emporter.SelectedRows[0].Cells[0].Value.ToString());
                            ADO.cmd.ExecuteNonQuery();

                            CmbEmplEmp.Text = "";
                            TboxNomZonEmp.Text = "";
                            CmbNbrTblEmp.SelectedIndex = 0;
                            ADO.Deconnecter();
                            Remplir_Zone_Emporter();
                            MessageBox.Show("Zone Emporter bien modifier !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CmbEmplEmp.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Attention, pour cette zone il y'a des table avec des commandes !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Supprimer_Zone_Emporter()
        {
            try
            {
                ADO.Connecter();
                if (DGV_Zone_Emporter.Rows.Count != 0)
                {
                    if (DGV_Zone_Emporter.SelectedRows.Count != 0)
                    {
                        DialogResult dr = (MessageBox.Show("Voulez-vous vraiment supprimer cette Zone Emporter ?", "Vérification", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question));
                        if (dr == DialogResult.Yes)
                        {
                            ADO.sda = new SqlDataAdapter("select distinct Reference from TablesEspace where Reference=@Reference and Etat<>0", ADO.con);
                            ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", DGV_Zone_Emporter.SelectedRows[0].Cells[1].Value.ToString());
                            DataTable c = new DataTable();
                            ADO.sda.Fill(c);
                            /**/
                            if (c.Rows.Count != 0)
                            {
                                MessageBox.Show("Attention, Vous avez une ou plusieurs commandes dans cette zone que vous devez confirmer ou annuler ! !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                ADO.cmd = new SqlCommand("delete from Zone_Emporter where Id_Zone=@Id_Zone", ADO.con);
                                ADO.cmd.Parameters.AddWithValue("@Id_Zone", DGV_Zone_Emporter.SelectedRows[0].Cells[0].Value.ToString());
                                ADO.cmd.ExecuteNonQuery();

                                ADO.cmd = new SqlCommand("delete from TablesEspace where Reference=@Ref", ADO.con);
                                ADO.cmd.Parameters.AddWithValue("@Ref", DGV_Zone_Emporter.SelectedRows[0].Cells[1].Value.ToString());
                                ADO.cmd.ExecuteNonQuery();

                                CmbEmplEmp.Text = "";
                                TboxNomZonEmp.Text = "";
                                CmbNbrTblEmp.SelectedIndex = 0;
                                ADO.Deconnecter();
                                Remplir_Zone_Emporter();
                                Disponible_Zone_E_False();
                                MessageBox.Show("Zone Emporter bien supprimer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Opération pas terminer !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ParametreTables_Load(object sender, EventArgs e)
        {
            Remplir_Zone();
            Remplir_Zone_Emporter();
            Remplir_Zone_E_Disponible();
            Remplir_Zone_P_Disponible();
            GroupBoxCategorie.Width = Form1.GeneralInstance.PnlAffichage.Width - 25;
            this.Dock = DockStyle.Fill;
        }

        private void DGV_Zone_Principale_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_Zone_Principale.SelectedRows.Count == 1)
                {
                    TboxNomZonPrinc.Text = DGV_Zone_Principale.SelectedRows[0].Cells[1].Value.ToString();
                    CmbNbrTblPrinc.Text = DGV_Zone_Principale.SelectedRows[0].Cells[2].Value.ToString();
                    CmbEmplPrinc.Text = DGV_Zone_Principale.SelectedRows[0].Cells[0].Value.ToString();
                    CmbEmplPrinc.Enabled = TboxNomZonPrinc.Enabled = CmbNbrTblPrinc.Enabled = true;
                    TxtEmplPrinc.Text = DGV_Zone_Principale.SelectedRows[0].Cells[0].Value.ToString();
                    TxtEmplPrinc.Visible = true;
                    CmbEmplPrinc.Visible = TxtEmplPrinc.Enabled = false;
                    //CmbEmplPrinc.Items.Clear();
                    //CmbEmplPrinc.Items.Add(DGV_Zone_Principale.SelectedRows[0].Cells[0].Value.ToString());
                    //CmbEmplPrinc.SelectedIndex = 0;
                    //CmbEmplPrinc.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DGV_Zone_Emporter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGV_Zone_Principale.Rows.Count != 0)
                {
                    TboxNomZonEmp.Text = DGV_Zone_Emporter.SelectedRows[0].Cells[1].Value.ToString();
                    CmbNbrTblEmp.Text = DGV_Zone_Emporter.SelectedRows[0].Cells[2].Value.ToString();
                    TxtEmplEmp.Text = CmbEmplEmp.Text = DGV_Zone_Emporter.SelectedRows[0].Cells[0].Value.ToString();
                    TboxNomZonEmp.Enabled = CmbNbrTblEmp.Enabled = TxtEmplEmp.Visible = true;
                    CmbEmplEmp.Enabled = TxtEmplEmp.Enabled = CmbEmplEmp.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAjouterPrinc_Click(object sender, EventArgs e)
        {
            if (TboxNomZonPrinc.Text != "" && CmbNbrTblPrinc.Text != "")
            {
                if (Convert.ToInt32(CmbNbrTblPrinc.Text) >= 1 && Convert.ToInt32(CmbNbrTblPrinc.Text) <= 18)
                {
                    ADO.Connecter();

                    ADO.sda = new SqlDataAdapter("select distinct Reference from TablesEspace", ADO.con);
                    DataTable a = new DataTable();
                    ADO.sda.Fill(a);
                    if (a.Rows.Count == 0)
                    {
                        ADO.sda = new SqlDataAdapter("select Etat from TableDefault", ADO.con);
                        DataTable b = new DataTable();
                        ADO.sda.Fill(b);
                        ADO.Deconnecter();
                        if (b.Rows.Count != 0)
                        {
                            int EtatTable = Convert.ToInt32(b.Rows[0][0].ToString());
                            if (EtatTable != 0)
                            {
                                MessageBox.Show("Attention, Vous avez une commande que vous devez confirmer ou annuler !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                Ajouter_Zone();

                                Disponible_Zone_P_True();

                                Remplir_Zone_P_Disponible();
                            }
                        }
                    }
                    else
                    {
                        Ajouter_Zone();

                        Disponible_Zone_P_True();

                        Remplir_Zone_P_Disponible();
                    }
                }
                else
                {
                    MessageBox.Show("Attention, Le nombre des tables doit être une valeur entre 1 et 18 !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Attention, Veuillez remplir les champs !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnModifierPrinc_Click(object sender, EventArgs e)
        {
            if (TboxNomZonPrinc.Text != "" && CmbNbrTblPrinc.Text != "")
            {
                if (Convert.ToInt32(CmbNbrTblPrinc.Text) >= 1 && Convert.ToInt32(CmbNbrTblPrinc.Text) <= 18)
                {
                    Modifier_Zone();
                    Remplir_Zone_P_Disponible();
                }
                else
                {
                    MessageBox.Show("Attention, Le nombre des tables doit être une valeur entre 1 et 18 !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Attention, Veuillez remplir les champs !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSupprimerPrinc_Click(object sender, EventArgs e)
        {
            Supprimer_Zone();
        }

        private void BtnAjouterEmp_Click(object sender, EventArgs e)
        {
            if (TboxNomZonEmp.Text != "" && CmbNbrTblEmp.Text != "")
            {
                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("select distinct Reference from TablesEspace", ADO.con);
                DataTable a = new DataTable();
                ADO.sda.Fill(a);
                if (a.Rows.Count == 0)
                {
                    ADO.sda = new SqlDataAdapter("select Etat from TableDefault", ADO.con);
                    DataTable b = new DataTable();
                    ADO.sda.Fill(b);
                    ADO.Deconnecter();
                    if (b.Rows.Count != 0)
                    {
                        int EtatTable = Convert.ToInt32(b.Rows[0][0].ToString());
                        if (EtatTable != 0)
                        {
                            MessageBox.Show("Attention, Vous avez une commande que vous devez confirmer ou annuler !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            Ajouter_Zone_Emporter();

                            Disponible_Zone_E_True();

                            Remplir_Zone_E_Disponible();
                        }
                    }
                }
                else
                {
                    Ajouter_Zone_Emporter();

                    Disponible_Zone_E_True();

                    Remplir_Zone_E_Disponible();
                }
            }
            else
            {
                MessageBox.Show("Attention, Veuillez remplir les champs !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnModifierEmp_Click(object sender, EventArgs e)
        {
            if (TboxNomZonEmp.Text != "" && CmbNbrTblEmp.Text != "")
            {
                Modifier_Zone_Emporter();
                Remplir_Zone_E_Disponible();
            }
            else
            {
                MessageBox.Show("Attention, Veuillez remplir les champs !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSupprimerEmp_Click(object sender, EventArgs e)
        {
            Supprimer_Zone_Emporter();
            Remplir_Zone_E_Disponible();
        }

    }
}
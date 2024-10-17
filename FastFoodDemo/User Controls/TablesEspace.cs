using FastFoodDemo.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FastFoodDemo.User_Controls
{
    public partial class TablesEspace : UserControl
    {
        public TablesEspace()
        {
            InitializeComponent();
        }

        readonly ADO ADO = new ADO();

        public static string Zone = "";

        //public void TablesZone1()
        //{
        //    try
        //    {
        //        ADO.Connecter();

        //        ADO.sda = new SqlDataAdapter("GetTablesPrincipaleZone1", ADO.con);
        //        ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        ADO.sda.SelectCommand.CommandTimeout = 0;
        //        DataTable table = new DataTable();
        //        ADO.sda.Fill(table);

        //        if (table.Rows.Count > 0)
        //        {
        //            Zone1.Text = table.Rows[0][0].ToString();
        //            int Nombre_Tables_Zone1 = Convert.ToInt32(table.Rows[0][1].ToString());

        //            for (int i = 1; i <= Nombre_Tables_Zone1; i++)
        //            {
        //                Button button = new Button();
        //                button.Name = (Zone1.Text + " Table " + i.ToString());
        //                button.Text = "Table " + i.ToString();
        //                button.Size = new Size(164, 40);
        //                button.Font = new Font("Century Gothic", 11, FontStyle.Bold);
        //                //button.BackColor = Color.FromArgb(30, 144, 255);
        //                button.BackColor = Color.SlateGray;
        //                button.ForeColor = Color.White;
        //                button.FlatStyle = FlatStyle.Flat;
        //                button.Cursor = Cursors.Hand;
        //                //button.Anchor = AnchorStyles.Right;

        //                //MessageBox.Show(button.Name);

        //                ///*Commande est en situation de reste de ticket de sortie :

        //                ADO.sda = new SqlDataAdapter("GetTablesPrincipaleZone1Etat1", ADO.con);
        //                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
        //                ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Zone1.Text);
        //                ADO.sda.SelectCommand.CommandTimeout = 0;
        //                DataTable ted = new DataTable();
        //                ADO.sda.Fill(ted);
        //                if (ted.Rows.Count != 0)
        //                {
        //                    for (int h = 0; h < ted.Rows.Count; h++)
        //                    {
        //                        if (button.Name == ted.Rows[h][0].ToString())
        //                        {
        //                            button.BackColor = Color.FromArgb(255, 217, 0);
        //                            button.ForeColor = Color.White;
        //                            button.FlatStyle = FlatStyle.Flat;
        //                        }
        //                    }
        //                }

        //                ///*Commande est en situation de sortie de Ticket au Cuisine :

        //                ADO.sda = new SqlDataAdapter("GetTablesPrincipaleZone1Etat2", ADO.con);
        //                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
        //                ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Zone1.Text);
        //                ADO.sda.SelectCommand.CommandTimeout = 0;
        //                DataTable td = new DataTable();
        //                ADO.sda.Fill(td);
        //                if (td.Rows.Count != 0)
        //                {
        //                    for (int h = 0; h < td.Rows.Count; h++)
        //                    {
        //                        if (button.Name == td.Rows[h][0].ToString())
        //                        {
        //                            button.BackColor = Color.FromArgb(32, 156, 93);
        //                            button.ForeColor = Color.White;
        //                            button.FlatStyle = FlatStyle.Flat;
        //                        }
        //                    }
        //                }

        //                ///*Commande est en situation de sortie de Ticket au Client :

        //                ADO.sda = new SqlDataAdapter("GetTablesPrincipaleZone1Etat3", ADO.con);
        //                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
        //                ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Zone1.Text);
        //                ADO.sda.SelectCommand.CommandTimeout = 0;
        //                DataTable tdi = new DataTable();
        //                ADO.sda.Fill(tdi);

        //                if (tdi.Rows.Count != 0)
        //                {
        //                    for (int h = 0; h < tdi.Rows.Count; h++)
        //                    {
        //                        if (button.Name == tdi.Rows[h][0].ToString())
        //                        {
        //                            button.BackColor = Color.Crimson;
        //                            button.ForeColor = Color.White;
        //                            button.FlatStyle = FlatStyle.Flat;
        //                        }
        //                    }
        //                }

        //                ///*Désaciver les tables qui est occupeé par un autre employé(Serveur) :

        //                //if (lbl_role.Text == "Serveur")
        //                //{
        //                //    ADO.sda = new SqlDataAdapter("select Etat from TablesEspace where Nom=@Nom", ADO.con);
        //                //    ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom", button.Name);
        //                //    DataTable a = new DataTable();
        //                //    a.Clear();
        //                //    ADO.sda.Fill(a);

        //                //    if (a.Rows[0][0].ToString() != "0")
        //                //    {
        //                //        ADO.sda = new SqlDataAdapter("select top 1 dci.Serveur from TablesEspace ts,Details_Commande_Imprimante dci where ts.Nom=dci.Nom_Table and ts.Etat<>0 and ts.Nom=@Nom order by dci.Id_Commande desc", ADO.con);
        //                //        ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom", button.Name);
        //                //        DataTable b = new DataTable();
        //                //        b.Clear();
        //                //        ADO.sda.Fill(b);
        //                //        if (b.Rows.Count != 0)
        //                //        {
        //                //            if (b.Rows[0][0].ToString() != LblPrenom.Text)
        //                //            {
        //                //                button.BackColor = Color.Gray;
        //                //                button.FlatStyle = FlatStyle.Flat;
        //                //                button.Enabled = false;
        //                //            }
        //                //        }
        //                //    }
        //                //}

        //                FlwPnlZone1.Controls.Add(button);
        //                button.Click += new EventHandler(this.Button_Click_Zone1);
        //                //button.MouseHover += new EventHandler(this.Button_Hover_Zone1);
        //                //button.MouseLeave += new EventHandler(this.Button_Leave_Zone1);
        //            }
        //        }
        //        else
        //        {
        //            Zone1.Visible = FlwPnlZone1.Visible = false;
        //        }
        //        ADO.Deconnecter();
        //    }
        //    catch (Exception ex)
        //    {
        //        ADO.Deconnecter();
        //        MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        public void TablesZone1()
        {
            try
            {
                ADO.Connecter();
                ADO.sda = new SqlDataAdapter("GetTablesPrincipaleZone1", ADO.con);
                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                ADO.sda.SelectCommand.CommandTimeout = 0;
                DataTable table = new DataTable();
                ADO.sda.Fill(table);

                if (table.Rows.Count > 0)
                {
                    Zone1.Text = table.Rows[0][0].ToString();
                    int Nombre_Tables_Zone1 = Convert.ToInt32(table.Rows[0][1].ToString());

                    List<Button> buttons = new List<Button>();
                    for (int i = 1; i <= Nombre_Tables_Zone1; i++)
                    {
                        Button button = new Button();
                        button.Name = (Zone1.Text + " Table " + i.ToString());
                        button.Text = "Table " + i.ToString();
                        button.Size = new Size(164, 40);
                        button.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        button.BackColor = Color.SlateGray;
                        button.ForeColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Cursor = Cursors.Hand;
                        buttons.Add(button);

                        FlwPnlZone1.Controls.Add(button);
                        button.Click += new EventHandler(this.Button_Click_Zone1);
                    }

                    UpdateButtonColors(buttons, "GetTablesPrincipaleZone1Etat1", Color.FromArgb(255, 217, 0));
                    UpdateButtonColors(buttons, "GetTablesPrincipaleZone1Etat2", Color.FromArgb(32, 156, 93));
                    UpdateButtonColors(buttons, "GetTablesPrincipaleZone1Etat3", Color.Crimson);
                }
                else
                {
                    Zone1.Visible = FlwPnlZone1.Visible = false;
                }

                ADO.Deconnecter();
            }
            catch (Exception ex)
            {
                ADO.Deconnecter();
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateButtonColors(List<Button> buttons, string storedProcedureName, Color color)
        {
            ADO.sda = new SqlDataAdapter(storedProcedureName, ADO.con);
            ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Zone1.Text);
            ADO.sda.SelectCommand.CommandTimeout = 0;
            DataTable table = new DataTable();
            ADO.sda.Fill(table);

            foreach (Button button in buttons)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (button.Name == row[0].ToString())
                    {
                        button.BackColor = color;
                        button.ForeColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;
                        break; // No need to continue checking once a match is found
                    }
                }
            }
        }


        public void Button_Click_Zone1(object sender, EventArgs e)
        {
            Zone = "Principale";
            Button btn = (Button)sender;
            Form1.GeneralInstance.IconZone.Visible = true;
            Form1.GeneralInstance.LblZone.Visible = true;
            Form1.GeneralInstance.IconNumTable.Visible = true;
            Form1.GeneralInstance.LblNumTable.Visible = true;
            Form1.GeneralInstance.LblZone.Text = this.Zone1.Text;
            Form1.GeneralInstance.LblNumTable.Text = btn.Text;
            Form1.GeneralInstance.PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
            new User_Controls.TablesEspace().Dispose();
            Form1.GeneralInstance.PnlAffichage.Controls.Clear();
            Form1.GeneralInstance.PnlAffichage.Controls.Add(new User_Controls.PointDeVente());

            //ADO.Connecter();
            //ADO.sda = new SqlDataAdapter("select Etat from TablesEspace where Nom=@Nom", ADO.con);
            //ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom",btn.Name);
            //DataTable tableEtat = new DataTable();
            //tableEtat.Clear();
            //ADO.sda.Fill(tableEtat);
            //string EtatTable = tableEtat.Rows[0][0].ToString();
            //if (EtatTable == "0")
            //{
            //    this.Hide();
            //    Form1 Form1 = new Form1();
            //    Form1.LblPrenom.Text = this.LblPrenom.Text;
            //    Form1.lbl_role.Text = this.lbl_role.Text;
            //    Form1.LblZone.Text = this.Zone1.Text;
            //    Form1.LblNumTable.Text = btn.Text;
            //    Form1.ShowDialog();
            //}
            //else
            //{
            //    ADO.sda = new SqlDataAdapter("select distinct top 1 Serveur,Id_Commande from Details_Commande_Imprimante dci,TablesEspace ts where ts.Nom=dci.Nom_Table and ts.Nom=@Nom and ts.Etat<>0 order by Id_Commande desc", ADO.con);
            //    ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom", btn.Name);
            //    DataTable tableServeur = new DataTable();
            //    tableServeur.Clear();
            //    ADO.sda.Fill(tableServeur);
            //    string Serveur = tableServeur.Rows[0][0].ToString();
            //    if (Serveur == LblPrenom.Text)
            //    {
            //        this.Hide();
            //        Form1 Form1 = new Form1();
            //        Form1.LblPrenom.Text = this.LblPrenom.Text;
            //        Form1.lbl_role.Text = this.lbl_role.Text;
            //        Form1.LblZone.Text = this.Zone1.Text;
            //        Form1.LblNumTable.Text = btn.Text;
            //        Form1.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Ooops !", "Vérification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }

        public void Button_Hover_Zone1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Yellow;
        }

        public void Button_Leave_Zone1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.White;
        }

        public void TablesZone2()
        {
            try
            {
                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("GetTablesPrincipaleZone2", ADO.con);
                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                ADO.sda.SelectCommand.CommandTimeout = 0;
                DataTable table = new DataTable();
                ADO.sda.Fill(table);

                if (table.Rows.Count > 0)
                {
                    Zone2.Text = table.Rows[0][0].ToString();
                    int Nombre_Table_Zone2 = Convert.ToInt32(table.Rows[0][1].ToString());

                    for (int i = 1; i <= Nombre_Table_Zone2; i++)
                    {
                        Button button = new Button();
                        button.Name = (Zone2.Text + " Table " + i.ToString());
                        button.Text = "Table " + i.ToString();
                        button.Size = new Size(164, 40);
                        button.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        //button.BackColor = Color.FromArgb(30, 144, 255);
                        button.BackColor = Color.SlateGray;
                        button.ForeColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Cursor = Cursors.Hand;

                        //MessageBox.Show(button.Name);

                        ///*Commande est en situation de reste de ticket de sortie :

                        ADO.sda = new SqlDataAdapter("GetTablesPrincipaleZone2Etat1", ADO.con);
                        ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Zone2.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable ted = new DataTable();
                        ADO.sda.Fill(ted);
                        if (ted.Rows.Count != 0)
                        {
                            for (int h = 0; h < ted.Rows.Count; h++)
                            {
                                if (button.Name == ted.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(255, 217, 0);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande est en situation de sortie de Ticket au Cuisine :

                        ADO.sda = new SqlDataAdapter("GetTablesPrincipaleZone2Etat2", ADO.con);
                        ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Zone2.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable td = new DataTable();
                        ADO.sda.Fill(td);

                        if (td.Rows.Count != 0)
                        {
                            for (int h = 0; h < td.Rows.Count; h++)
                            {
                                if (button.Name == td.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(32, 156, 93);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande est en situation de sortie de Ticket au Client :

                        ADO.sda = new SqlDataAdapter("GetTablesPrincipaleZone2Etat3", ADO.con);
                        ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Zone2.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable a = new DataTable();
                        ADO.sda.Fill(a);

                        if (a.Rows.Count != 0)
                        {
                            for (int j = 0; j < a.Rows.Count; j++)
                            {
                                if (button.Name == a.Rows[j][0].ToString())
                                {
                                    button.BackColor = Color.Crimson;
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Désaciver les tables qui est occupeé par un autre employé(Serveur) :

                        //if (lbl_role.Text == "Serveur")
                        //{
                        //    ADO.sda = new SqlDataAdapter("select Etat from TablesEspace where Nom=@Nom", ADO.con);
                        //    ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom", button.Name);
                        //    DataTable b = new DataTable();
                        //    b.Clear();
                        //    ADO.sda.Fill(b);

                        //    if (b.Rows[0][0].ToString() != "0")
                        //    {
                        //        ADO.sda = new System.Data.SqlClient.SqlDataAdapter("select top 1 dci.Serveur from TablesEspace ts,Details_Commande_Imprimante dci where ts.Nom=dci.Nom_Table and ts.Etat<>0 and ts.Nom=@Nom order by dci.Id_Commande desc", ADO.con);
                        //        ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom", button.Name);
                        //        DataTable c = new DataTable();
                        //        c.Clear();
                        //        ADO.sda.Fill(c);
                        //        if (c.Rows.Count != 0)
                        //        {
                        //            if (c.Rows[0][0].ToString() != LblPrenom.Text)
                        //            {
                        //                button.BackColor = Color.Gray;
                        //                button.FlatStyle = FlatStyle.Flat;
                        //                button.Enabled = false;
                        //            }
                        //        }
                        //    }
                        //}

                        FlwPnlZone2.Controls.Add(button);
                        button.Click += new EventHandler(this.Button_Click_Zone2);
                    }
                }
                else
                {
                    Zone2.Visible = FlwPnlZone2.Visible = false;
                }
                ADO.Deconnecter();
            }
            catch (Exception ex)
            {
                ADO.Deconnecter();
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Button_Click_Zone2(object sender, EventArgs e)
        {
            Zone = "Principale";
            Button btn = (Button)sender;
            Form1.GeneralInstance.IconZone.Visible = true;
            Form1.GeneralInstance.LblZone.Visible = true;
            Form1.GeneralInstance.IconNumTable.Visible = true;
            Form1.GeneralInstance.LblNumTable.Visible = true;
            Form1.GeneralInstance.LblZone.Text = this.Zone2.Text;
            Form1.GeneralInstance.LblNumTable.Text = btn.Text;
            Form1.GeneralInstance.PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
            new User_Controls.TablesEspace().Dispose();
            Form1.GeneralInstance.PnlAffichage.Controls.Clear();
            Form1.GeneralInstance.PnlAffichage.Controls.Add(new User_Controls.PointDeVente());
        }

        public void TablesZone3()
        {
            try
            {
                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("GetTablesPrincipaleZone3", ADO.con);
                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                ADO.sda.SelectCommand.CommandTimeout = 0;
                DataTable table = new DataTable();
                ADO.sda.Fill(table);

                if (table.Rows.Count > 0)
                {
                    Zone3.Text = table.Rows[0][0].ToString();
                    int Nombre_Tables_Zone3 = Convert.ToInt32(table.Rows[0][1].ToString());
                    for (int i = 1; i <= Nombre_Tables_Zone3; i++)
                    {
                        Button button = new Button();
                        button.Name = (Zone3.Text + " Table " + i.ToString());
                        button.Text = "Table " + i.ToString();
                        button.Size = new Size(164, 40);
                        button.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        //button.BackColor = Color.FromArgb(30, 144, 255);
                        button.BackColor = Color.SlateGray;
                        button.ForeColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Cursor = Cursors.Hand;

                        //MessageBox.Show(button.Name);

                        ///*Commande est en situation de reste de ticket de sortie :

                        ADO.sda = new SqlDataAdapter("GetTablesPrincipaleZone3Etat1", ADO.con);
                        ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Zone3.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable ted = new DataTable();
                        ADO.sda.Fill(ted);
                        if (ted.Rows.Count != 0)
                        {
                            for (int h = 0; h < ted.Rows.Count; h++)
                            {
                                if (button.Name == ted.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(255, 217, 0);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande est en situation de sortie de Ticket au Cuisine :

                        ADO.sda = new SqlDataAdapter("GetTablesPrincipaleZone3Etat2", ADO.con);
                        ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Zone3.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable td = new DataTable();
                        ADO.sda.Fill(td);

                        if (td.Rows.Count != 0)
                        {
                            for (int h = 0; h < td.Rows.Count; h++)
                            {
                                if (button.Name == td.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(32, 156, 93);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande est en situation de sortie de Ticket au Client :

                        ADO.sda = new SqlDataAdapter("GetTablesPrincipaleZone3Etat3", ADO.con);
                        ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Zone3.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable b = new DataTable();
                        ADO.sda.Fill(b);

                        if (b.Rows.Count != 0)
                        {
                            for (int g = 0; g < b.Rows.Count; g++)
                            {
                                if (button.Name == b.Rows[g][0].ToString())
                                {
                                    button.BackColor = Color.Crimson;
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Désaciver les tables qui est occupeé par un autre employé(Serveur) :

                        //if (lbl_role.Text == "Serveur")
                        //{
                        //    ADO.sda = new SqlDataAdapter("select Etat from TablesEspace where Nom=@Nom", ADO.con);
                        //    ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom", button.Name);
                        //    DataTable c = new DataTable();
                        //    c.Clear();
                        //    ADO.sda.Fill(c);

                        //    if (c.Rows.Count != 0)
                        //    {
                        //        if (c.Rows[0][0].ToString() != "0")
                        //        {
                        //            ADO.sda = new SqlDataAdapter("select top 1 dci.Serveur from TablesEspace ts,Details_Commande_Imprimante dci where ts.Nom=dci.Nom_Table and ts.Etat<>0 and ts.Nom=@Nom order by dci.Id_Commande desc", ADO.con);
                        //            ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom", button.Name);
                        //            DataTable d = new DataTable();
                        //            d.Clear();
                        //            ADO.sda.Fill(d);
                        //            if (d.Rows.Count != 0)
                        //            {
                        //                if (d.Rows[0][0].ToString() != LblPrenom.Text)
                        //                {
                        //                    button.BackColor = Color.Gray;
                        //                    button.FlatStyle = FlatStyle.Flat;
                        //                    button.Enabled = false;
                        //                }
                        //            }
                        //        }
                        //    }
                        //}

                        FlwPnlZone3.Controls.Add(button);
                        button.Click += new EventHandler(this.Button_Click_Zone3);
                    }
                }
                else
                {
                    Zone3.Visible = FlwPnlZone3.Visible = false;
                }
                ADO.Deconnecter();
            }
            catch (Exception ex)
            {
                ADO.Deconnecter();
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Button_Click_Zone3(object sender, EventArgs e)
        {
            Zone = "Principale";
            Button btn = (Button)sender;
            Form1.GeneralInstance.IconZone.Visible = true;
            Form1.GeneralInstance.LblZone.Visible = true;
            Form1.GeneralInstance.IconNumTable.Visible = true;
            Form1.GeneralInstance.LblNumTable.Visible = true;
            Form1.GeneralInstance.LblZone.Text = this.Zone3.Text;
            Form1.GeneralInstance.LblNumTable.Text = btn.Text;
            Form1.GeneralInstance.PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
            new User_Controls.TablesEspace().Dispose();
            Form1.GeneralInstance.PnlAffichage.Controls.Clear();
            Form1.GeneralInstance.PnlAffichage.Controls.Add(new User_Controls.PointDeVente());
        }

        public void ZoneEmporter1()
        {
            try
            {
                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("GetTablesEmporterZone1", ADO.con);
                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                ADO.sda.SelectCommand.CommandTimeout = 0;
                DataTable table = new DataTable();
                ADO.sda.Fill(table);

                if (table.Rows.Count != 0)
                {
                    Emporter1.Text = table.Rows[0][0].ToString();
                    int Nombre_Table_Emporter1 = Convert.ToInt32(table.Rows[0][1].ToString());

                    for (int i = 1; i <= Nombre_Table_Emporter1; i++)
                    {
                        Button button = new Button();
                        button.Name = (Emporter1.Text + " Table " + i.ToString());
                        button.Text = "Table " + i.ToString();
                        button.Size = new Size(90, 40);
                        button.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        //button.BackColor = Color.FromArgb(30, 144, 255);
                        button.BackColor = Color.SlateGray;
                        button.ForeColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Cursor = Cursors.Hand;

                        //MessageBox.Show(button.Name);

                        ///*Commande est en situation de reste de ticket de sortie :

                        ADO.sda = new SqlDataAdapter("GetTablesEmporterZone1Etat1", ADO.con);
                        ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter1.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable ted = new DataTable();
                        ADO.sda.Fill(ted);
                        if (ted.Rows.Count != 0)
                        {
                            for (int h = 0; h < ted.Rows.Count; h++)
                            {
                                if (button.Name == ted.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(255, 217, 0);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande est en situation de sortie de Ticket Cuisine :

                        ADO.sda = new SqlDataAdapter("GetTablesEmporterZone1Etat2", ADO.con);
                        ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter1.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable td = new DataTable();
                        ADO.sda.Fill(td);

                        if (td.Rows.Count != 0)
                        {
                            for (int h = 0; h < td.Rows.Count; h++)
                            {
                                if (button.Name == td.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(32, 156, 93);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande est en situation de sortie de Ticket Client :

                        ADO.sda = new SqlDataAdapter("GetTablesEmporterZone1Etat3", ADO.con);
                        ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter1.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable data = new DataTable();
                        ADO.sda.Fill(data);

                        if (data.Rows.Count != 0)
                        {
                            for (int f = 0; f < data.Rows.Count; f++)
                            {
                                if (button.Name == data.Rows[f][0].ToString())
                                {
                                    button.BackColor = Color.Crimson;
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        FlwPnlEmporter1.Controls.Add(button);
                        button.Click += new EventHandler(this.Button_Click_Emporter1);
                    }
                }
                else
                {
                    Emporter1.Visible = FlwPnlEmporter1.Visible = false;
                }
                ADO.Deconnecter();
            }
            catch (Exception ex)
            {
                ADO.Deconnecter();
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Button_Click_Emporter1(object sender, EventArgs e)
        {
            Zone = "Emporter";
            Button btn = (Button)sender;
            Form1.GeneralInstance.IconZone.Visible = true;
            Form1.GeneralInstance.LblZone.Visible = true;
            Form1.GeneralInstance.IconNumTable.Visible = true;
            Form1.GeneralInstance.LblNumTable.Visible = true;
            Form1.GeneralInstance.LblZone.Text = this.Emporter1.Text;
            Form1.GeneralInstance.LblNumTable.Text = btn.Text;
            Form1.GeneralInstance.PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
            new User_Controls.TablesEspace().Dispose();
            Form1.GeneralInstance.PnlAffichage.Controls.Clear();
            Form1.GeneralInstance.PnlAffichage.Controls.Add(new User_Controls.PointDeVente());
        }

        public void ZoneEmporter2()
        {
            try
            {
                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("GetTablesEmporterZone2", ADO.con);
                ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                ADO.sda.SelectCommand.CommandTimeout = 0;
                DataTable table = new DataTable();
                ADO.sda.Fill(table);

                if (table.Rows.Count > 0)
                {
                    Emporter2.Text = table.Rows[0][0].ToString();
                    int Nombre_Table_Emporter2 = Convert.ToInt32(table.Rows[0][1].ToString());

                    for (int i = 1; i <= Nombre_Table_Emporter2; i++)
                    {
                        Button button = new Button();
                        button.Name = (Emporter2.Text + " Table " + i.ToString());
                        button.Text = "Table " + i.ToString();
                        button.Size = new Size(90, 40);
                        button.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        //button.BackColor = Color.FromArgb(30, 144, 255);
                        button.BackColor = Color.SlateGray;
                        button.ForeColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Cursor = Cursors.Hand;

                        //MessageBox.Show(button.Name);

                        ///*Commande est en situation de reste de ticket de sortie :

                        ADO.sda = new SqlDataAdapter("GetTablesEmporterZone2Etat1", ADO.con);
                        ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter2.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable ted = new DataTable();
                        ADO.sda.Fill(ted);
                        if (ted.Rows.Count != 0)
                        {
                            for (int h = 0; h < ted.Rows.Count; h++)
                            {
                                if (button.Name == ted.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(255, 217, 0);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande est en situation de sortie de Ticket Cuisine :

                        ADO.sda = new SqlDataAdapter("GetTablesEmporterZone2Etat2", ADO.con);
                        ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter2.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable td = new DataTable();
                        ADO.sda.Fill(td);

                        if (td.Rows.Count != 0)
                        {
                            for (int h = 0; h < td.Rows.Count; h++)
                            {
                                if (button.Name == td.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(32, 156, 93);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande est en situation de sortie de Ticket Client :

                        ADO.sda = new SqlDataAdapter("GetTablesEmporterZone2Etat3", ADO.con);
                        ADO.sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter2.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable data = new DataTable();
                        ADO.sda.Fill(data);

                        if (data.Rows.Count != 0)
                        {
                            for (int s = 0; s < data.Rows.Count; s++)
                            {
                                if (button.Name == data.Rows[s][0].ToString())
                                {
                                    button.BackColor = Color.Crimson;
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        FlwPnlEmporter2.Controls.Add(button);
                        button.Click += new EventHandler(this.Button_Click_Emporter2);
                    }
                }
                else
                {
                    Emporter2.Visible = FlwPnlEmporter2.Visible = false;
                }
                ADO.Deconnecter();
            }
            catch (Exception ex)
            {
                ADO.Deconnecter();
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Button_Click_Emporter2(object sender, EventArgs e)
        {
            Zone = "Emporter";
            Button btn = (Button)sender;
            Form1.GeneralInstance.IconZone.Visible = true;
            Form1.GeneralInstance.LblZone.Visible = true;
            Form1.GeneralInstance.IconNumTable.Visible = true;
            Form1.GeneralInstance.LblNumTable.Visible = true;
            Form1.GeneralInstance.LblZone.Text = this.Emporter2.Text;
            Form1.GeneralInstance.LblNumTable.Text = btn.Text;
            Form1.GeneralInstance.PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
            new User_Controls.TablesEspace().Dispose();
            Form1.GeneralInstance.PnlAffichage.Controls.Clear();
            Form1.GeneralInstance.PnlAffichage.Controls.Add(new User_Controls.PointDeVente());
        }

        public void ZoneEmporter3()
        {
            try
            {
                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("select Nom_Zone,Nombre_Table from Zone_Emporter where Id_Zone=3", ADO.con);
                ADO.sda.SelectCommand.CommandTimeout = 0;
                DataTable data = new DataTable();
                ADO.sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    Emporter3.Text = data.Rows[0][0].ToString();
                    int Nombre_Table_Emporter3 = Convert.ToInt32(data.Rows[0][1].ToString());

                    for (int i = 1; i <= Nombre_Table_Emporter3; i++)
                    {
                        Button button = new Button();
                        button.Name = (Emporter3.Text + " Table " + i.ToString());
                        button.Text = "Table " + i.ToString();
                        button.Size = new Size(90, 40);
                        button.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        //button.BackColor = Color.FromArgb(30, 144, 255);
                        button.BackColor = Color.SlateGray;
                        button.ForeColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Cursor = Cursors.Hand;

                        //MessageBox.Show(button.Name);

                        ///*Commande est en situation de reste de ticket de sortie :

                        ADO.sda = new SqlDataAdapter("select Nom from TablesEspace where Reference=@Reference and Etat=1", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter3.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable ted = new DataTable();
                        ADO.sda.Fill(ted);
                        if (ted.Rows.Count != 0)
                        {
                            for (int h = 0; h < ted.Rows.Count; h++)
                            {
                                if (button.Name == ted.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(255, 217, 0);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande est en situation de sortie de Ticket Cuisine :

                        ADO.sda = new SqlDataAdapter("select Nom from TablesEspace where Reference=@Reference and Etat=2", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter3.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable td = new DataTable();
                        ADO.sda.Fill(td);

                        if (td.Rows.Count != 0)
                        {
                            for (int h = 0; h < td.Rows.Count; h++)
                            {
                                if (button.Name == td.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(32, 156, 93);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande est en situation de sortie de Ticket Client :

                        ADO.sda = new SqlDataAdapter("select Nom from TablesEspace where Reference=@Reference and Etat=3", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter3.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            for (int r = 0; r < table.Rows.Count; r++)
                            {
                                if (button.Name == table.Rows[r][0].ToString())
                                {
                                    button.BackColor = Color.Crimson;
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        FlwPnlEmporter3.Controls.Add(button);
                        button.Click += new EventHandler(this.Button_Click_Emporter3);
                    }
                }
                else
                {
                    Emporter3.Visible = FlwPnlEmporter3.Visible = false;
                }
                ADO.Deconnecter();
            }
            catch (Exception ex)
            {
                ADO.Deconnecter();
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Button_Click_Emporter3(object sender, EventArgs e)
        {
            Zone = "Emporter";
            Button btn = (Button)sender;
            Form1.GeneralInstance.IconZone.Visible = true;
            Form1.GeneralInstance.LblZone.Visible = true;
            Form1.GeneralInstance.IconNumTable.Visible = true;
            Form1.GeneralInstance.LblNumTable.Visible = true;
            Form1.GeneralInstance.LblZone.Text = this.Emporter3.Text;
            Form1.GeneralInstance.LblNumTable.Text = btn.Text;
            Form1.GeneralInstance.PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
            new User_Controls.TablesEspace().Dispose();
            Form1.GeneralInstance.PnlAffichage.Controls.Clear();
            Form1.GeneralInstance.PnlAffichage.Controls.Add(new User_Controls.PointDeVente());
        }

        public void ZoneEmporter4()
        {
            try
            {
                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("select Nom_Zone,Nombre_Table from Zone_Emporter where Id_Zone=4", ADO.con);
                ADO.sda.SelectCommand.CommandTimeout = 0;
                DataTable table = new DataTable();
                ADO.sda.Fill(table);

                if (table.Rows.Count > 0)
                {
                    Emporter4.Text = table.Rows[0][0].ToString();
                    int Nombre_Table_Emporter4 = Convert.ToInt32(table.Rows[0][1].ToString());

                    for (int i = 1; i <= Nombre_Table_Emporter4; i++)
                    {
                        Button button = new Button();
                        button.Name = (Emporter4.Text + " Table " + i.ToString());
                        button.Text = "Table " + i.ToString();
                        button.Size = new Size(90, 40);
                        button.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        //button.BackColor = Color.FromArgb(30, 144, 255);
                        button.BackColor = Color.SlateGray;
                        button.ForeColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Cursor = Cursors.Hand;

                        //MessageBox.Show(button.Name);

                        ///*Commande est en situation de reste de ticket de sortie :

                        ADO.sda = new SqlDataAdapter("select Nom from TablesEspace where Reference=@Reference and Etat=1", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter4.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable ted = new DataTable();
                        ADO.sda.Fill(ted);
                        if (ted.Rows.Count != 0)
                        {
                            for (int h = 0; h < ted.Rows.Count; h++)
                            {
                                if (button.Name == ted.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(255, 217, 0);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande en situation de sortie de Ticket Cuisine :

                        ADO.sda = new SqlDataAdapter("select Nom from TablesEspace where Reference=@Reference and Etat=2", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter4.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable td = new DataTable();
                        ADO.sda.Fill(td);

                        if (td.Rows.Count != 0)
                        {
                            for (int h = 0; h < td.Rows.Count; h++)
                            {
                                if (button.Name == td.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(32, 156, 93);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande en situation de sortie de Ticket Client :

                        ADO.sda = new SqlDataAdapter("select Nom from TablesEspace where Reference=@Reference and Etat=3", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter4.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable data = new DataTable();
                        ADO.sda.Fill(data);

                        if (data.Rows.Count != 0)
                        {
                            for (int l = 0; l < data.Rows.Count; l++)
                            {
                                if (button.Name == data.Rows[l][0].ToString())
                                {
                                    button.BackColor = Color.Crimson;
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        FlwPnlEmporter4.Controls.Add(button);
                        button.Click += new EventHandler(this.Button_Click_Emporter4);
                    }
                }
                else
                {
                    Emporter4.Visible = FlwPnlEmporter4.Visible = false;
                }
                ADO.Deconnecter();
            }
            catch (Exception ex)
            {
                ADO.Deconnecter();
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Button_Click_Emporter4(object sender, EventArgs e)
        {
            Zone = "Emporter";
            Button btn = (Button)sender;
            Form1.GeneralInstance.IconZone.Visible = true;
            Form1.GeneralInstance.LblZone.Visible = true;
            Form1.GeneralInstance.IconNumTable.Visible = true;
            Form1.GeneralInstance.LblNumTable.Visible = true;
            Form1.GeneralInstance.LblZone.Text = this.Emporter4.Text;
            Form1.GeneralInstance.LblNumTable.Text = btn.Text;
            Form1.GeneralInstance.PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
            new User_Controls.TablesEspace().Dispose();
            Form1.GeneralInstance.PnlAffichage.Controls.Clear();
            Form1.GeneralInstance.PnlAffichage.Controls.Add(new User_Controls.PointDeVente());
        }

        public void ZoneEmporter5()
        {
            try
            {
                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("select Nom_Zone,Nombre_Table from Zone_Emporter where Id_Zone=5", ADO.con);
                ADO.sda.SelectCommand.CommandTimeout = 0;
                DataTable dataTable = new DataTable();
                ADO.sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    Emporter5.Text = dataTable.Rows[0][0].ToString();
                    int Nombre_Table_Emporter5 = Convert.ToInt32(dataTable.Rows[0][1].ToString());

                    for (int i = 1; i <= Nombre_Table_Emporter5; i++)
                    {
                        Button button = new Button();
                        button.Name = (Emporter5.Text + " Table " + i.ToString());
                        button.Text = "Table " + i.ToString();
                        button.Size = new Size(90, 40);
                        button.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        //button.BackColor = Color.FromArgb(30, 144, 255);
                        button.BackColor = Color.SlateGray;
                        button.ForeColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Cursor = Cursors.Hand;

                        //MessageBox.Show(button.Name);

                        ///*Commande est en situation de reste de ticket de sortie :

                        ADO.sda = new SqlDataAdapter("select Nom from TablesEspace where Reference=@Reference and Etat=1", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter5.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable ted = new DataTable();
                        ADO.sda.Fill(ted);
                        if (ted.Rows.Count != 0)
                        {
                            for (int h = 0; h < ted.Rows.Count; h++)
                            {
                                if (button.Name == ted.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(255, 217, 0);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande en situation de sortie de Ticket Cuisine :

                        ADO.sda = new SqlDataAdapter("select Nom from TablesEspace where Reference=@Reference and Etat=2", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter5.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable td = new DataTable();
                        ADO.sda.Fill(td);

                        if (td.Rows.Count != 0)
                        {
                            for (int h = 0; h < td.Rows.Count; h++)
                            {
                                if (button.Name == td.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(32, 156, 93);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande en situation de sortie de Ticket Client :

                        ADO.sda = new SqlDataAdapter("select Nom from TablesEspace where Reference=@Reference and Etat=3", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter5.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable table = new DataTable();
                        ADO.sda.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            for (int m = 0; m < table.Rows.Count; m++)
                            {
                                if (button.Name == table.Rows[m][0].ToString())
                                {
                                    button.BackColor = Color.Crimson;
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        FlwPnlEmporter5.Controls.Add(button);
                        button.Click += new EventHandler(this.Button_Click_Emporter5);
                    }
                }
                else
                {
                    Emporter5.Visible = FlwPnlEmporter5.Visible = false;
                }
                ADO.Deconnecter();
            }
            catch (Exception ex)
            {
                ADO.Deconnecter();
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Button_Click_Emporter5(object sender, EventArgs e)
        {
            Zone = "Emporter";
            Button btn = (Button)sender;
            Form1.GeneralInstance.IconZone.Visible = true;
            Form1.GeneralInstance.LblZone.Visible = true;
            Form1.GeneralInstance.IconNumTable.Visible = true;
            Form1.GeneralInstance.LblNumTable.Visible = true;
            Form1.GeneralInstance.LblZone.Text = this.Emporter5.Text;
            Form1.GeneralInstance.LblNumTable.Text = btn.Text;
            Form1.GeneralInstance.PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
            new User_Controls.TablesEspace().Dispose();
            Form1.GeneralInstance.PnlAffichage.Controls.Clear();
            Form1.GeneralInstance.PnlAffichage.Controls.Add(new User_Controls.PointDeVente());
        }

        public void ZoneEmporter6()
        {
            try
            {
                ADO.Connecter();

                ADO.sda = new SqlDataAdapter("select Nom_Zone,Nombre_Table from Zone_Emporter where Id_Zone=6", ADO.con);
                ADO.sda.SelectCommand.CommandTimeout = 0;
                DataTable table = new DataTable();
                ADO.sda.Fill(table);

                if (table.Rows.Count > 0)
                {
                    Emporter6.Text = table.Rows[0][0].ToString();
                    int Nombre_Table_Emporter6 = Convert.ToInt32(table.Rows[0][1].ToString());

                    for (int i = 1; i <= Nombre_Table_Emporter6; i++)
                    {
                        Button button = new Button();
                        button.Name = (Emporter6.Text + " Table " + i.ToString());
                        button.Text = "Table " + i.ToString();
                        button.Size = new Size(90, 40);
                        button.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                        //button.BackColor = Color.FromArgb(30, 144, 255);
                        button.BackColor = Color.SlateGray;
                        button.ForeColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;
                        button.Cursor = Cursors.Hand;

                        //MessageBox.Show(button.Name);

                        ///*Commande est en situation de reste de ticket de sortie :

                        ADO.sda = new SqlDataAdapter("select Nom from TablesEspace where Reference=@Reference and Etat=1", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter6.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable ted = new DataTable();
                        ADO.sda.Fill(ted);
                        if (ted.Rows.Count != 0)
                        {
                            for (int h = 0; h < ted.Rows.Count; h++)
                            {
                                if (button.Name == ted.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(255, 217, 0);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande est en situation de sortie de Ticket Cuisine :

                        ADO.sda = new SqlDataAdapter("select Nom from TablesEspace where Reference=@Reference and Etat=2", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter6.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable td = new DataTable();
                        ADO.sda.Fill(td);

                        if (td.Rows.Count != 0)
                        {
                            for (int h = 0; h < td.Rows.Count; h++)
                            {
                                if (button.Name == td.Rows[h][0].ToString())
                                {
                                    button.BackColor = Color.FromArgb(32, 156, 93);
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        ///*Commande est en situation de sortie de Ticket Client :

                        ADO.sda = new SqlDataAdapter("select Nom from TablesEspace where Reference=@Reference and Etat=3", ADO.con);
                        ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Emporter6.Text);
                        ADO.sda.SelectCommand.CommandTimeout = 0;
                        DataTable data = new DataTable();
                        ADO.sda.Fill(data);

                        if (data.Rows.Count != 0)
                        {
                            for (int n = 0; n < data.Rows.Count; n++)
                            {
                                if (button.Name == data.Rows[n][0].ToString())
                                {
                                    button.BackColor = Color.Crimson;
                                    button.ForeColor = Color.White;
                                    button.FlatStyle = FlatStyle.Flat;
                                }
                            }
                        }

                        FlwPnlEmporter6.Controls.Add(button);
                        button.Click += new EventHandler(this.Button_Click_Emporter6);
                    }
                }
                else
                {
                    Emporter6.Visible = FlwPnlEmporter6.Visible = false;
                }
                ADO.Deconnecter();
            }
            catch (Exception ex)
            {
                ADO.Deconnecter();
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Button_Click_Emporter6(object sender, EventArgs e)
        {
            Zone = "Emporter";
            Button btn = (Button)sender;
            Form1.GeneralInstance.IconZone.Visible = true;
            Form1.GeneralInstance.LblZone.Visible = true;
            Form1.GeneralInstance.IconNumTable.Visible = true;
            Form1.GeneralInstance.LblNumTable.Visible = true;
            Form1.GeneralInstance.LblZone.Text = this.Emporter6.Text;
            Form1.GeneralInstance.LblNumTable.Text = btn.Text;
            Form1.GeneralInstance.PnlAffichage.Controls.Remove(new User_Controls.TablesEspace());
            new User_Controls.TablesEspace().Dispose();
            Form1.GeneralInstance.PnlAffichage.Controls.Clear();
            Form1.GeneralInstance.PnlAffichage.Controls.Add(new User_Controls.PointDeVente());
        }

        private void TablesEspace_Load(object sender, EventArgs e)
        {
            try
            {
                //ADO.Connecter();

                //ADO.sda = new SqlDataAdapter("select distinct Reference from TablesEspace", ADO.con);
                //ADO.sda.SelectCommand.CommandTimeout = 0;
                //DataTable a = new DataTable();
                //ADO.sda.Fill(a);
                //if (a.Rows.Count != 0)
                //{
                //    //System.Timers.Timer timers = new System.Timers.Timer();
                //    //timers.Interval = 100;
                //    //timers.Elapsed += Timer_Elapsed;
                //    //timers.Start();
                //    TablesZone1();
                //    TablesZone2();
                //    TablesZone3();

                //    ADO.sda = new SqlDataAdapter("select Id_Zone from Zone_Emporter", ADO.con);
                //    ADO.sda.SelectCommand.CommandTimeout = 0;
                //    DataTable table = new DataTable();
                //    ADO.sda.Fill(table);

                //    if (table.Rows.Count != 0)
                //    {
                //        ZoneEmporter1();
                //        ZoneEmporter2();
                //        ZoneEmporter3();
                //        ZoneEmporter4();
                //        ZoneEmporter5();
                //        ZoneEmporter6();
                //    }
                //    else
                //    {
                //        PnlEmporter.Visible = false;
                //    }
                //    //if (BtnLogOut.Enabled == true)
                //    //{
                //    //    BtnLogIn.Enabled = false;
                //    //}
                //}
                //else
                //{
                //    ADO.Deconnecter();
                //    this.Hide();
                //    Form1 Form1 = new Form1();
                //    Form1.EtatTables = 1;
                //    //Form1.LblUtilisateur.Text = this.LblPrenom.Text;
                //    //Form1.lbl_role.Text = this.lbl_role.Text;
                //    Form1.LblZone.ForeColor = Color.Gray;
                //    Form1.LblNumTable.ForeColor = Color.Gray;
                //    //Form1.BtnRtrMenuTabl.Enabled = false;
                //    //Form1.BtnZone.Enabled = false;
                //    //Form1.BtnNumTable.Enabled = false;
                //    //this.Close();
                //    Form1.ShowDialog();
                //}

                if (ADO.CheckEspaceTables())
                {
                    Form1.GeneralInstance.BtnHideOrShowSideBar.Enabled = false;

                    TablesZone1();
                    TablesZone2();
                    TablesZone3();

                    if (ADO.CheckExistsZoneEmporter())
                    {
                        ZoneEmporter1();
                        ZoneEmporter2();
                        ZoneEmporter3();
                        ZoneEmporter4();
                        ZoneEmporter5();
                        ZoneEmporter6();
                    }
                    else
                    {
                        PnlEmporter.Visible = false;
                    }
                }
                else
                {
                    ADO.Deconnecter();
                    this.Hide();
                    Form1 Form1 = new Form1();
                    Form1.EtatTables = 1;
                    Form1.LblZone.ForeColor = Color.Gray;
                    Form1.LblNumTable.ForeColor = Color.Gray;
                    Form1.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ADO.Deconnecter();
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //for (int i = 1; i <= 18; i++)
            //{
            //    Button button = new Button();
            //    button.Name = ("Salle" + " Table " + i.ToString());
            //    button.Text = "Table " + i.ToString() + " 🛎";
            //    button.Size = new Size(164, 40);
            //    button.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            //    //button.BackColor = Color.FromArgb(30, 144, 255);
            //    button.BackColor = Color.SlateGray;
            //    button.ForeColor = Color.White;
            //    button.FlatStyle = FlatStyle.Flat;
            //    button.Cursor = Cursors.Hand;
            //    FlwPnlZone2.Controls.Add(button);
            //}
            //for (int i = 1; i <= 18; i++)
            //{
            //    Button button = new Button();
            //    button.Name = ("Salle" + " Table " + i.ToString());
            //    button.Text = "Table " + i.ToString() + " 🛎";
            //    button.Size = new Size(164, 40);
            //    button.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            //    //button.BackColor = Color.FromArgb(30, 144, 255);
            //    button.BackColor = Color.SlateGray;
            //    button.ForeColor = Color.White;
            //    button.FlatStyle = FlatStyle.Flat;
            //    button.Cursor = Cursors.Hand;
            //    FlwPnlZone3.Controls.Add(button);
            //}
            //for (int i = 1; i <= 18; i++)
            //{
            //    Button button = new Button();
            //    button.Name = ("Salle" + " Table " + i.ToString());
            //    button.Text = "Table " + i.ToString() + " 🛎";
            //    button.Size = new Size(164, 40);
            //    button.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            //    //button.BackColor = Color.FromArgb(30, 144, 255);
            //    button.BackColor = Color.SlateGray;
            //    button.ForeColor = Color.White;
            //    button.FlatStyle = FlatStyle.Flat;
            //    button.Cursor = Cursors.Hand;
            //    //button.Anchor = AnchorStyles.Right;

            //    //MessageBox.Show(button.Name);

            //    ///*Commande est en situation de sortie de Ticket au Cuisine :

            //    //ADO.sda = new SqlDataAdapter("select Nom from TablesEspace where Reference=@Reference and Etat=2", ADO.con);
            //    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Zone1.Text);
            //    //ADO.sda.SelectCommand.CommandTimeout = 0;
            //    //DataTable td = new DataTable();
            //    //td.Clear();
            //    //ADO.sda.Fill(td);
            //    //if (td.Rows.Count != 0)
            //    //{
            //    //    for (int h = 0; h < td.Rows.Count; h++)
            //    //    {
            //    //        if (button.Name == td.Rows[h][0].ToString())
            //    //        {
            //    //            button.BackColor = Color.FromArgb(32, 156, 93);
            //    //            button.ForeColor = Color.White;
            //    //            button.FlatStyle = FlatStyle.Flat;
            //    //        }
            //    //    }
            //    //}

            //    ///*Commande est en situation de sortie de Ticket au Client :

            //    //ADO.sda = new SqlDataAdapter("select Nom from TablesEspace where Reference=@Reference and Etat=3", ADO.con);
            //    //ADO.sda.SelectCommand.Parameters.AddWithValue("@Reference", Zone1.Text);
            //    //ADO.sda.SelectCommand.CommandTimeout = 0;
            //    //DataTable tdi = new DataTable();
            //    //tdi.Clear();
            //    //ADO.sda.Fill(tdi);

            //    //if (tdi.Rows.Count != 0)
            //    //{
            //    //    for (int h = 0; h < tdi.Rows.Count; h++)
            //    //    {
            //    //        if (button.Name == tdi.Rows[h][0].ToString())
            //    //        {
            //    //            button.BackColor = Color.Crimson;
            //    //            button.ForeColor = Color.White;
            //    //            button.FlatStyle = FlatStyle.Flat;
            //    //        }
            //    //    }
            //    //}

            //    ///*Désaciver les tables qui est occupeé par un autre employé(Serveur) :

            //    //if (lbl_role.Text == "Serveur")
            //    //{
            //    //    ADO.sda = new SqlDataAdapter("select Etat from TablesEspace where Nom=@Nom", ADO.con);
            //    //    ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom", button.Name);
            //    //    DataTable a = new DataTable();
            //    //    a.Clear();
            //    //    ADO.sda.Fill(a);

            //    //    if (a.Rows[0][0].ToString() != "0")
            //    //    {
            //    //        ADO.sda = new SqlDataAdapter("select top 1 dci.Serveur from TablesEspace ts,Details_Commande_Imprimante dci where ts.Nom=dci.Nom_Table and ts.Etat<>0 and ts.Nom=@Nom order by dci.Id_Commande desc", ADO.con);
            //    //        ADO.sda.SelectCommand.Parameters.AddWithValue("@Nom", button.Name);
            //    //        DataTable b = new DataTable();
            //    //        b.Clear();
            //    //        ADO.sda.Fill(b);
            //    //        if (b.Rows.Count != 0)
            //    //        {
            //    //            if (b.Rows[0][0].ToString() != LblPrenom.Text)
            //    //            {
            //    //                button.BackColor = Color.Gray;
            //    //                button.FlatStyle = FlatStyle.Flat;
            //    //                button.Enabled = false;
            //    //            }
            //    //        }
            //    //    }
            //    //}

            //    FlwPnlZone1.Controls.Add(button);
            //    //button.Click += new EventHandler(this.Button_Click_Zone1);
            //    //button.MouseHover += new EventHandler(this.Button_Hover_Zone1);
            //    //button.MouseLeave += new EventHandler(this.Button_Leave_Zone1);
            //}

            //for (int i = 1; i <= 9; i++)
            //{
            //    Button button = new Button();
            //    button.Name = ("Salle" + " Table " + i.ToString());
            //    button.Text = "Table " + i.ToString() + " 🛎";
            //    button.Size = new Size(101, 40);
            //    button.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            //    //button.BackColor = Color.FromArgb(30, 144, 255);
            //    button.BackColor = Color.SlateGray;
            //    button.ForeColor = Color.White;
            //    button.FlatStyle = FlatStyle.Flat;
            //    button.Cursor = Cursors.Hand;
            //    FlwPnlEmporter1.Controls.Add(button);
            //}

            //for (int i = 1; i <= 9; i++)
            //{
            //    Button button = new Button();
            //    button.Name = ("Salle" + " Table " + i.ToString());
            //    button.Text = "Table " + i.ToString() + " 🛎";
            //    button.Size = new Size(101, 40);
            //    button.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            //    //button.BackColor = Color.FromArgb(30, 144, 255);
            //    button.BackColor = Color.SlateGray;
            //    button.ForeColor = Color.White;
            //    button.FlatStyle = FlatStyle.Flat;
            //    button.Cursor = Cursors.Hand;
            //    FlwPnlEmporter2.Controls.Add(button);
            //}

            //for (int i = 1; i <= 9; i++)
            //{
            //    Button button = new Button();
            //    button.Name = ("Salle" + " Table " + i.ToString());
            //    button.Text = "Table " + i.ToString() + " 🛎";
            //    button.Size = new Size(101, 40);
            //    button.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            //    //button.BackColor = Color.FromArgb(30, 144, 255);
            //    button.BackColor = Color.SlateGray;
            //    button.ForeColor = Color.White;
            //    button.FlatStyle = FlatStyle.Flat;
            //    button.Cursor = Cursors.Hand;
            //    FlwPnlEmporter3.Controls.Add(button);
            //}

            //for (int i = 1; i <= 9; i++)
            //{
            //    Button button = new Button();
            //    button.Name = ("Salle" + " Table " + i.ToString());
            //    button.Text = "Table " + i.ToString() + " 🛎";
            //    button.Size = new Size(101, 40);
            //    button.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            //    //button.BackColor = Color.FromArgb(30, 144, 255);
            //    button.BackColor = Color.SlateGray;
            //    button.ForeColor = Color.White;
            //    button.FlatStyle = FlatStyle.Flat;
            //    button.Cursor = Cursors.Hand;
            //    FlwPnlEmporter4.Controls.Add(button);
            //}

            //for (int i = 1; i <= 9; i++)
            //{
            //    Button button = new Button();
            //    button.Name = ("Salle" + " Table " + i.ToString());
            //    button.Text = "Table " + i.ToString() + " 🛎";
            //    button.Size = new Size(101, 40);
            //    button.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            //    //button.BackColor = Color.FromArgb(30, 144, 255);
            //    button.BackColor = Color.SlateGray;
            //    button.ForeColor = Color.White;
            //    button.FlatStyle = FlatStyle.Flat;
            //    button.Cursor = Cursors.Hand;
            //    FlwPnlEmporter5.Controls.Add(button);
            //}

            //for (int i = 1; i <= 9; i++)
            //{
            //    Button button = new Button();
            //    button.Name = ("Salle" + " Table " + i.ToString());
            //    button.Text = "Table " + i.ToString() + " 🛎";
            //    button.Size = new Size(101, 40);
            //    button.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            //    //button.BackColor = Color.FromArgb(30, 144, 255);
            //    button.BackColor = Color.SlateGray;
            //    button.ForeColor = Color.White;
            //    button.FlatStyle = FlatStyle.Flat;
            //    button.Cursor = Cursors.Hand;
            //    FlwPnlEmporter6.Controls.Add(button);
            //}

            this.Dock = DockStyle.Fill;
        }

    }
}
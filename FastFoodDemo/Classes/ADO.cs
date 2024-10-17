using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;

using Guna.UI2.WinForms;

namespace FastFoodDemo.Classes
{
    class ADO
    {
        public readonly static string ConnectionString = @"Data Source=MSI\MSSQLSERVER01;Initial Catalog=GestionEspace;Integrated Security=True;MultipleActiveResultSets=True;Min Pool Size=10; Max Pool Size=100; Pooling=false";
        public SqlConnection con = new SqlConnection(ConnectionString);
        public SqlConnection conMembers = new SqlConnection(@"Data Source=.;Initial Catalog=Gestion_Salle_Sports;Integrated Security=True;MultipleActiveResultSets=True;Min Pool Size=10; Max Pool Size=100; Pooling=false");
        public SqlCommand cmd;
        public SqlDataAdapter sda;
        public SqlDataReader dr;

        //GestionEspaceEntities db;

        public enum EspaceTypes
        {
            Restaurant,
            Boulangerie,
            Autre
        }

        public enum UserRoles
        {
            Admin,
            Gérant,
            Caissier
        }

        public void Connecter()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void Deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public string CheckEspaceType()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlDataAdapter sda = new SqlDataAdapter("GetEspaceType", connection))
                {
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable table = new DataTable();
                    sda.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        return table.Rows[0][0].ToString();
                    }
                }
            }

            return string.Empty;
        }


        public int CheckDetailCommandeEtatById(long id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlDataAdapter sda = new SqlDataAdapter("CheckDetailCommandeEtatById", connection))
                {
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("@id", id);
                    DataTable table = new DataTable();
                    sda.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        return int.Parse(table.Rows[0][0].ToString());
                    }
                }
            }

            return 0; // Default value if no data is found
        }


        public string NomProduitById(int Id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlDataAdapter sda = new SqlDataAdapter("GetNomProduitById", connection))
                {
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("@Id_Produit", Id);
                    DataTable table = new DataTable();
                    sda.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        return table.Rows[0][0].ToString();
                    }
                }
            }

            return string.Empty; // Default value if no data is found
        }


        public string IdProduitByNom(string nom)
        {
            Connecter();
            sda = new SqlDataAdapter("GetIdProduitByNom", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@Nom_Produit", nom);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();
            string Id = table.Rows[0][0].ToString();
            if (table.Rows.Count > 0)
                return Id;
            return Id;
        }

        public string PrixProduitById(int Id)
        {
            Connecter();
            sda = new SqlDataAdapter("GetPrixProduitById", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@Id", Id);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            string Nom = "";
            string Zone = Form1.GeneralInstance.LblZone.Text;

            if (CheckZone(Zone))
                Nom = table.Rows[0][0].ToString();
            else
                Nom = table.Rows[0][1].ToString();

            if (table.Rows.Count > 0)
                return Nom;
            return Nom;

        }

        public bool CheckZone(string Nom)
        {
            Connecter();
            sda = new SqlDataAdapter("CheckZone", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@Nom", Nom);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();
            if (table.Rows.Count > 0)
                return true;
            return false;
        }

        public bool CheckEspaceTables()
        {
            Connecter();
            sda = new SqlDataAdapter("CheckEspaceTables", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();
            if (table.Rows.Count > 0)
                return true;
            return false;
        }

        public bool CheckExistsZoneEmporter()
        {
            Connecter();
            sda = new SqlDataAdapter("CheckExistsZoneEmporter", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();
            if (table.Rows.Count > 0)
                return true;
            return false;
        }

        public bool CheckProduitExistsInStock(int Id)
        {
            Connecter();
            sda = new SqlDataAdapter("CheckProduitExistsInStock", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("Id", Id);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();
            if (table.Rows.Count == 1)
                return true;
            return false;
        }

        public decimal CheckProduitDisponibleInStock(int Id)
        {
            decimal Qte;

            Connecter();
            sda = new SqlDataAdapter("CheckProduitDisponibleInStock", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("Id", Id);
            DataTable table = new DataTable();
            sda.Fill(table);
            Qte = decimal.Parse(table.Rows[0][0].ToString());
            Deconnecter();
            if (table.Rows.Count == 1)
                return Qte;
            return Qte;
        }

        public bool CheckProduitWithBarCode(string BarCode)
        {
            Connecter();
            sda = new SqlDataAdapter("CheckProduitWithBarCode", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("BarCode", BarCode);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();
            if (table.Rows.Count == 1)
                return true;
            return false;
        }

        public bool CheckUserCanImprimerTicketCuisine(string role)
        {
            Connecter();
            sda = new SqlDataAdapter("CheckUserCanImprimerTicketCuisine", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();
            if (table.Rows.Count == 1)
            {
                if (table.Rows[0][0].ToString().Equals("Oui"))
                    return true;
            }
            return false;
        }

        public bool CheckUserCanImprimerTicketClient(string role)
        {
            Connecter();
            sda = new SqlDataAdapter("CheckUserCanImprimerTicketClient", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();
            if (table.Rows.Count == 1)
            {
                if (table.Rows[0][0].ToString().Equals("Oui"))
                    return true;
            }
            return false;
        }

        public bool CheckUserCanValiderCommande(string role)
        {
            Connecter();
            sda = new SqlDataAdapter("CheckUserCanValiderCommande", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();
            if (table.Rows.Count == 1)
            {
                if (table.Rows[0][0].ToString().Equals("Oui"))
                    return true;
            }
            return false;
        }

        public bool CheckUserCanAnnulerCommande(string role)
        {
            Connecter();
            sda = new SqlDataAdapter("CheckUserCanAnnulerCommande", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();
            if (table.Rows.Count == 1)
            {
                if (table.Rows[0][0].ToString().Equals("Oui"))
                    return true;
            }
            return false;
        }

        public string AdminEmail()
        {
            string email = "";

            con.Open();

            sda = new SqlDataAdapter("GetEmailAdmin", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable table = new DataTable();

            sda.Fill(table);

            if (table.Rows.Count == 1)
            {
                email = table.Rows[0][0].ToString();
            }

            con.Close();

            return email;
        }

        public string EspaceNom()
        {
            string nom = "";

            con.Open();

            sda = new SqlDataAdapter("GetEspaceName", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable table = new DataTable();

            sda.Fill(table);

            if (table.Rows.Count == 1)
            {
                nom = table.Rows[0][0].ToString();
            }

            con.Close();

            return nom;
        }

        public void RemplirCombo(string query, Guna2ComboBox comboBox, string displayMember, string valueMember, string type, string textToshow = "")
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlDataAdapter sda = new SqlDataAdapter(query, connection))
                {
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable table = new DataTable();
                    sda.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        comboBox.Enabled = true;
                        comboBox.DisplayMember = displayMember;
                        comboBox.ValueMember = valueMember;
                        comboBox.DataSource = table;

                        if (type.Equals("TOUS"))
                        {
                            DataRow row = table.NewRow();
                            row[displayMember] = "TOUS";
                            row[valueMember] = "0";
                            table.Rows.InsertAt(row, 0);
                        }
                        else if (!string.IsNullOrEmpty(textToshow))
                        {
                            DataRow row = table.NewRow();
                            row[displayMember] = textToshow;
                            row[valueMember] = "0";
                            table.Rows.InsertAt(row, 0);
                        }

                        comboBox.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBox.Enabled = false;
                    }
                }
            }
        }


        public DataTable ListeImprimanteDisponible()
        {
            Connecter();

            sda = new SqlDataAdapter("ListeImprimanteDisponible", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            sda.Fill(table);

            Deconnecter();

            return table;
        }

        public DataTable BarCodeProduitData(string BarCode)
        {
            Connecter();

            sda = new SqlDataAdapter("CheckProduitWithBarCode", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("BarCode", BarCode);
            DataTable table = new DataTable();
            sda.Fill(table);

            Deconnecter();

            return table;
        }

        public string IdCategorieParProduit(int Id)
        {
            string id = "";

            Connecter();

            sda = new SqlDataAdapter("IdCategorieParProduit", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@Id", Id);
            DataTable table = new DataTable();
            sda.Fill(table);
            if (table.Rows.Count == 1)
                id = table.Rows[0][0].ToString();

            Deconnecter();

            return id;
        }

        public string IdImprimanteParCategorie(int Id)
        {
            string id = "";

            Connecter();

            sda = new SqlDataAdapter("IdImprimanteParCategorie", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand.Parameters.AddWithValue("@Id", Id);
            DataTable table = new DataTable();
            sda.Fill(table);
            if (table.Rows.Count == 1)
                id = table.Rows[0][0].ToString();

            Deconnecter();

            return id;
        }

        public DataTable DetailsCommandeById(int Id)
        {
            Connecter();

            sda = new SqlDataAdapter("select Id_Produit,Quantite from DetailsCommandeImprimante where Id_Commande=@Id_Commande", con);
            sda.SelectCommand.Parameters.AddWithValue("@Id_Commande", Id);
            //sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            sda.Fill(table);

            Deconnecter();

            return table;
        }

        public DataTable DetailCommandeWithNotes(long IdCommande)
        {
            Connecter();

            sda = new SqlDataAdapter("select Id_DetailCommande from DetailsCommandeImprimante where Id_Commande=@Id_Commande and Id_DetailCommande in (select Id_DetailCommande from ProduitNotes)", con);
            sda.SelectCommand.Parameters.AddWithValue("@Id_Commande", IdCommande);
            //sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            sda.Fill(table);

            Deconnecter();

            return table;
        }

        public DataTable GetEmployerByNameAndPassword(string user, string hashPassword)
        {
            Connecter();

            sda = new SqlDataAdapter("select Nom,Role from Employer where Nom=@Nom and MotPasse=@Password", con);
            sda.SelectCommand.Parameters.AddWithValue("@Nom", user);
            sda.SelectCommand.Parameters.AddWithValue("@Password", hashPassword);
            //sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            sda.Fill(table);

            Deconnecter();

            return table;
        }

        public void SupprimerCommande(int Id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("delete from DetailsCommandeImprimante where Id_Commande=@Id", connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Id", Id);
                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd = new SqlCommand("delete from CommandePayer where Id_Commande=@Id", connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Id", Id);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        System.Windows.MessageBox.Show(ex.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
        }

        public bool IsDeviceHasPermission()
        {
            bool isAutorized = false;

            var macAddress = Helpers.GetMacAddress();

            if (!CheckDeviceIsAlreadyExist(macAddress))
            {
                Connecter();

                cmd = new SqlCommand("insert into Security values(@MAC_Address,@Start_Date,@End_Date)", con);
                cmd.Parameters.AddWithValue("@MAC_Address", macAddress);
                cmd.Parameters.AddWithValue("@Start_Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@End_Date", DateTime.Now.AddDays(40));
                cmd.ExecuteNonQuery();

                Deconnecter();

                isAutorized = true;
            }
            else
            {
                var experationDate = GetExperationDate(macAddress);

                if (experationDate > DateTime.Now)
                {
                    isAutorized = true;
                }
                else
                {
                    isAutorized = false;
                }
            }

            return isAutorized;
        }

        public DateTime GetExperationDate(string macAddress)
        {
            Connecter();

            sda = new SqlDataAdapter("select End_Date from Security where MAC_Address=@MAC_Address", con);
            sda.SelectCommand.Parameters.AddWithValue("@MAC_Address", macAddress);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            var date = Convert.ToDateTime(table.Rows[0][0]);

            return date;
        }

        public bool CheckDeviceIsAlreadyExist(string macAddress)
        {
            if (string.IsNullOrWhiteSpace(macAddress))
                return false;

            bool isExist = false;

            Connecter();

            sda = new SqlDataAdapter("select MAC_Address from Security", con);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            foreach (DataRow row in table.Rows)
            {
                if (row[0].Equals(macAddress))
                {
                    isExist = true;
                    break;
                }
            }

            return isExist;
        }

        public bool CheckIfRoleCanDeleteOrder(string role)
        {
            Connecter();

            sda = new SqlDataAdapter("select SuppressionTicket from Autorisation where Role=@Role", con);
            sda.SelectCommand.Parameters.AddWithValue("@Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            if (table.Rows.Count == 0)
                return false;

            return table.Rows[0][0].ToString().Equals("Oui") ? true : false;
        }

        public bool CheckIfRoleCanOpenTiroir(string role)
        {
            Connecter();

            sda = new SqlDataAdapter("select OuvrirTiroirCaisse from Autorisation where Role=@Role", con);
            sda.SelectCommand.Parameters.AddWithValue("@Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            if (table.Rows.Count == 0)
                return false;

            return table.Rows[0][0].ToString().Equals("Oui") ? true : false;
        }

        public bool CheckIfRoleCanUseParameters(string role)
        {
            Connecter();

            sda = new SqlDataAdapter("select Parametrage from Autorisation where Role=@Role", con);
            sda.SelectCommand.Parameters.AddWithValue("@Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            if (table.Rows.Count == 0)
                return false;

            return table.Rows[0][0].ToString().Equals("Oui") ? true : false;
        }

        public bool CheckIfRoleCanManageCategoriesAndProducts(string role)
        {
            Connecter();

            sda = new SqlDataAdapter("select GestionProduitCategorie from Autorisation where Role=@Role", con);
            sda.SelectCommand.Parameters.AddWithValue("@Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            if (table.Rows.Count == 0)
                return false;

            return table.Rows[0][0].ToString().Equals("Oui") ? true : false;
        }

        public bool CheckIfRoleCanManageCommandes(string role)
        {
            Connecter();

            sda = new SqlDataAdapter("select Commandes from Autorisation where Role=@Role", con);
            sda.SelectCommand.Parameters.AddWithValue("@Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            if (table.Rows.Count == 0)
                return false;

            return table.Rows[0][0].ToString().Equals("Oui") ? true : false;
        }

        public bool CheckIfRoleCanPrintDuplicata(string role)
        {
            Connecter();

            sda = new SqlDataAdapter("select ImprimerDuplicata from Autorisation where Role=@Role", con);
            sda.SelectCommand.Parameters.AddWithValue("@Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            if (table.Rows.Count == 0)
                return false;

            return table.Rows[0][0].ToString().Equals("Oui") ? true : false;
        }

        public bool CheckIfRoleCanManageUsers(string role)
        {
            Connecter();

            sda = new SqlDataAdapter("select GesiontUtilisateur from Autorisation where Role=@Role", con);
            sda.SelectCommand.Parameters.AddWithValue("@Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            if (table.Rows.Count == 0)
                return false;

            return table.Rows[0][0].ToString().Equals("Oui") ? true : false;
        }

        public bool CheckIfRoleCanOpenReport(string role)
        {
            Connecter();

            sda = new SqlDataAdapter("select Rapport from Autorisation where Role=@Role", con);
            sda.SelectCommand.Parameters.AddWithValue("@Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            if (table.Rows.Count == 0)
                return false;

            return table.Rows[0][0].ToString().Equals("Oui") ? true : false;
        }

        public bool CheckIfRoleCanPrintReport(string role)
        {
            Connecter();

            sda = new SqlDataAdapter("select ImprimerRapport from Autorisation where Role=@Role", con);
            sda.SelectCommand.Parameters.AddWithValue("@Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            if (table.Rows.Count == 0)
                return false;

            return table.Rows[0][0].ToString().Equals("Oui") ? true : false;
        }

        public bool CheckIfRoleCanOpenBenefice(string role)
        {
            Connecter();

            sda = new SqlDataAdapter("select Benefice from Autorisation where Role=@Role", con);
            sda.SelectCommand.Parameters.AddWithValue("@Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            if (table.Rows.Count == 0)
                return false;

            return table.Rows[0][0].ToString().Equals("Oui") ? true : false;
        }

        public bool CheckIfRoleCanOpenCharges(string role)
        {
            Connecter();

            sda = new SqlDataAdapter("select Charges from Autorisation where Role=@Role", con);
            sda.SelectCommand.Parameters.AddWithValue("@Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            if (table.Rows.Count == 0)
                return false;

            return table.Rows[0][0].ToString().Equals("Oui") ? true : false;
        }

        public bool CheckIfRoleCanOpenOnlineReport(string role)
        {
            Connecter();

            sda = new SqlDataAdapter("select RapportEnLigne from Autorisation where Role=@Role", con);
            sda.SelectCommand.Parameters.AddWithValue("@Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            if (table.Rows.Count == 0)
                return false;

            return table.Rows[0][0].ToString().Equals("Oui") ? true : false;
        }

        public bool CheckIfRoleCanPrintOnlineReport(string role)
        {
            Connecter();

            sda = new SqlDataAdapter("select RapportEnLigne from Autorisation where Role=@Role", con);
            sda.SelectCommand.Parameters.AddWithValue("@Role", role);
            DataTable table = new DataTable();
            sda.Fill(table);
            Deconnecter();

            if (table.Rows.Count == 0)
                return false;

            return table.Rows[0][0].ToString().Equals("Oui") ? true : false;
        }

        public int DeleteOrderById(int orderId)
        {
            int result = 0;

            if (string.IsNullOrWhiteSpace(orderId.ToString()))
                return 0;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
                    con.Open();

                // Begin a transaction
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // Your SQL commands within the transaction
                    cmd = new SqlCommand("delete from DetailsCommandeImprimante where Id_Commande=@Id_Commande", con);
                    cmd.Parameters.AddWithValue("@Id_Commande", orderId);
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();

                    // Other SQL commands...
                    cmd = new SqlCommand("delete from CommandePayer where Id_Commande=@Id_Commande", con);
                    cmd.Parameters.AddWithValue("@Id_Commande", orderId);
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();

                    // Commit the transaction if all commands succeed
                    transaction.Commit();

                    result = 1;
                }
                catch (Exception ex)
                {
                    // An error occurred, rollback the transaction
                    transaction.Rollback();
                }

                if (con.State == ConnectionState.Open)
                    con.Close();
            }

            return result;
        }

    }
}
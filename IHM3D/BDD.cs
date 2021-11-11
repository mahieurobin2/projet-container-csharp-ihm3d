using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;

namespace IHM3D
{
    class BDD
    {
        private MySqlConnection con;
        private MySqlCommand requete;
        private MySqlDataReader donnees;
        public BDD() 
        {
            this.InitConnexion();
        }
        private void InitConnexion() 
        {
            this.con = new MySqlConnection("SERVER=127.0.0.1;DATABASE=gestion_containers;UID=root;PASSWORD=");
            this.requete = this.con.CreateCommand();
        }
        public void Add_N(int N) 
        {
            try
            {
                this.con.Open();
                requete = this.con.CreateCommand();
                requete.CommandText = "INSERT INTO test(numero) VALUES (@N)";
                requete.Parameters.AddWithValue("@N", N);
                requete.ExecuteNonQuery();
                this.con.Close();
            }

            catch(Exception ex) {
            MessageBox.Show(ex.Message);
            }
        }

        public bool login(String login, String password)
        {
            bool list = false;
            try
            {
                this.con.Open();
                this.requete.CommandText = "SELECT id_personne,nom,prenom FROM personne WHERE login=@login and password=@password";
                this.requete.Parameters.AddWithValue("@login", login);
                this.requete.Parameters.AddWithValue("@password", password);
                donnees = this.requete.ExecuteReader();
                list = donnees.Read();
                this.requete.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            this.con.Close();
            return list;
        }
        public ArrayList Lire_BC()
        {
            ArrayList List = new ArrayList();
            try
            {
                this.con.Open();
                MySqlCommand lire = this.con.CreateCommand();
                lire.CommandText = "SELECT BIC_CODE FROM liste_containers";
                MySqlDataReader Lire = lire.ExecuteReader();
                while (Lire.Read())
                {
                    List.Add(Lire.GetString("BIC_CODE"));

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return List;
        }
             public void ADD_N(string Dimension, string BIC_CODE)
        {
            try
            {
                this.con.Open();
                MySqlCommand inserer_N = this.con.CreateCommand();
                inserer_N.CommandText = "INSERT INTO liste_containers (dimensions, BIC_CODE) VALUES (@N, @BIC)";
                inserer_N.Parameters.AddWithValue("@N", dimensions);
                inserer_N.Parameters.AddWithValue("@BIC", BIC_CODE);
                inserer_N.ExecuteNonQuery();
                this.con.Close();
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

             public object dimensions { get; set; }
    }
}


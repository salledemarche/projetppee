using MySql.Data.MySqlClient;
using projetppe.Dal;
using projetppe.Modele;
using System;
using System.Collections.Generic;
using System.Data;
using projetppe;

namespace projetppe
{
    class DataAccess
    {
        private static string connectionString = "Server=;port=;Database=;Uid=root;password=";
        public Personnel personnel1;
        public static bool AuthenticationControl(string id, string pwd)
        {
            string req = "SELECT users.user, users.pwd";
            req += " FROM users ";
            req += " WHERE users.user = @id AND users.pwd = @pwd";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);
            parameters.Add("@pwd", pwd);
            Connect curseur = Connect.Instance(connectionString);
            curseur.Open();
            curseur.ReqSelect(req, parameters);


            if (curseur.Read())
            {
                curseur.Close();
                return true;
            }
            else
            {
                curseur.Close();
                return false;
            }
        }

        //public void Loadgrid(int id, string nom, string prenom, string role, bool suspendu)
        /*
        public void Loadgrid()
        {
            string req = "SELECT * FROM Personnel";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            //parameters.Add("@id", id);
            //parameters.Add("@nom", nom);
            //parameters.Add("@prenom", prenom);
            //parameters.Add("@role", role);
            //parameters.Add("@suspendu", suspendu);
            MySqlConnection connection = null;
            Connect curseur = Connect.Instance(connectionString);
            curseur.Open();
            curseur.ReqSelect(req, parameters);
            
            DataTable dataTable = new DataTable();
            dataTable.Load(lecteur);

            if (curseur.Read())
            {
                curseur.Close();
                return dataTable;
            }
            else
            {
                curseur.Close();
            }
        }*/

        public static bool creerUtilisateur(string nom, string prenom, string job, bool suspendu, DateTime dateDebut, DateTime datefin)
        {
            string mdp = rdmString(16);
            string id = $"{prenom.ToLower()}.{nom.ToLower()}";
            string req;
            if(job== "Responsable")
            {

                req = "insert into `responsable` (`id`,`mdp`,`Nom`,`Prénom`,`datedebut`,`datefin`,`suspendu`) values (@id, @mdp, @nom, @prenom, @datedebut, @datefin, @suspendu)";
                //req+= "WHERE responsable.mdp = SHA2(@mdp, 256)";
            }
            else if(job == "Administrateur")
            {
                 req = "insert into `Admin` (`id`,`mdp`,`Nom`,`Prénom`,`datedebut`,`datefin`,`suspendu`) values (@id, @mdp, @nom, @prenom, @datedebut, @datefin, @suspendu)";
                //req+= "WHERE Admin.id = SHA2(@id, 256) AND Admin.mdp = SHA2(@mdp, 256)";
            }
            else if (job == "Trader")
            {
              
   
                 req = "insert into `trader` (`id`,`mdp`,`Nom`,`Prénom`,`datedebut`,`datefin`,`suspendu`) values (@id, @mdp, @nom, @prenom, @datedebut, @datefin, @suspendu)";
                //req += "WHERE trader.id = SHA2(@id, 256) AND trader.mdp = SHA2(@mdp, 256)";
            }
            else {
                return false;
            }
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);
            parameters.Add("@mdp", mdp);
            parameters.Add("@nom", nom);
            parameters.Add("@prenom", prenom);
            parameters.Add("@datedebut", dateDebut.ToString("yyyy-MM-dd H:mm:ss"));
            parameters.Add("@datefin", datefin.ToString("yyyy-MM-dd H:mm:ss"));
            parameters.Add("@suspendu", suspendu ? "1" : "0");

            Connect curseur = Connect.Instance(connectionString);
            curseur.Open();
            curseur.ReqUpdate(req, parameters);

            /*
             * il faut exécuter la requête INSERT,
             * et vérifier si elle a fonctionné pour retourner true ou false.
            */
            if (curseur.Read())
            {
                curseur.Close();
                return true;
            }
            else
            {
                curseur.Close();
                return false;
            }
        }

        public static List<Personnel> GetPersonnel()
        {
            List<Personnel> lePersonnel = new List<Personnel>();
            string req = "SELECT personnel.id, personnel.nom, personnel.prenom, personnel.Rôle, personnel.suspendu";
            req += "FROM personnel ORDER BY personnel.id";
            Connect curseur = Connect.Instance(connectionString);
            curseur.Open();
            curseur.ReqSelect(req, null);
            while (curseur.Read())
            {
                Personnel personnel = new Personnel((int)curseur.Field("id"), (string)curseur.Field("nom"), (string)curseur.Field("prenom"), (string)curseur.Field("Rôle"), (bool)curseur.Field("suspendu"));
                lePersonnel.Add(personnel);
            }
            curseur.Close();
            return lePersonnel;
        }

        public void GetPersosTest()
        {
            string req = "SELECT * from personnel";
            Connect curseur = Connect.Instance(connectionString);
            curseur.Open();
            curseur.ReqSelect(req, null);


        }

        static public string rdmString(int length = 16, string charList = "0123456789abcdefghijklmnopqrstuvwxyz")
        {
            char[] result = new char[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                int pos = rand.Next(charList.Length);
                result[i] = charList[pos];
            }
            return new String(result);


        }

        public static string SHA512(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }
    }
}

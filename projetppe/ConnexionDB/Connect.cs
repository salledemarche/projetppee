using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace projetppe.Dal
{
    public class Connect
    {
        private static Connect instance;

        private MySqlConnection connect;

        private MySqlCommand command;

        private MySqlDataReader reader;

        private Connect(string connectionString)
        {
            try
            {
                connect = new MySqlConnection(connectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "La connexion a échoué");
                connect.Close();
            }
        }

        public static Connect Instance(string connectionString)
        {
            if( instance is null)
            {
                instance = new Connect(connectionString);
            }
            return instance;
        }

        public void ReqSelect(string queryString, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(queryString, connect);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void ReqUpdate(string queryString, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(queryString, connect);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void ReqDelete(string queryString, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(queryString, connect);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public bool Read()
        {
            if (reader is null)
            {
                return false;
            }
            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }
        }

        public object Field(string nameField)
        {
            if (reader is null)
            {
                return null;
            }
            try
            {
                return reader[nameField];
            }
            catch
            {
                return null;
            }
        }

        public void Close()
        {
            if (!(reader is null))
            {
                reader.Close();
            }
            connect.Close();
        }

        public void Open()
        {
            connect.Open();
        }


    }
}

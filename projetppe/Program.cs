using MySql.Data.MySqlClient;
using projetppe.Modele;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projetppe
{
    public class Program
    {
        private FrmLogin frmLogin;

        public List<Personnel> ListPersonnel = DataAccess.GetPersonnel();
        public MySqlConnection connection;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new FrmLogin());
            new Program();

        }

        public Program()
        {
            frmLogin = new FrmLogin(this);
            frmLogin.ShowDialog();
            frmLogin.Dispose();
        }

        public bool AuthControl(string login, string password)
        {
            if (DataAccess.AuthenticationControl(login, password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CreateUser(string nom, string prenom, string job, bool suspendu, DateTime dateDebut, DateTime dateFin)
        {
            return DataAccess.creerUtilisateur(nom, prenom, job, suspendu, dateDebut, dateFin);
        }
    }
}

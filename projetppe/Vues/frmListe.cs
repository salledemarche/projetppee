using MySql.Data.MySqlClient;
using projetppe.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace projetppe
{
    public partial class Frmliste : Form
    {
        public Program program;
        public Personnel personnel;
        private List<Personnel> personnels;

        private Role role;
        private List<Personnel> listePerso;
        private static string connectionString = "Server=51.83.79.4;port=1632;Database=salledemarches;Uid=pauline;password=508evGksQR4iB7kC";

     

        public Frmliste(Program program, Personnel personnel)
        {

            InitializeComponent();
            this.program = program;
        }

        

        private void Frmliste_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RdNom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RdIdentifiant_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {

        }
    }
}

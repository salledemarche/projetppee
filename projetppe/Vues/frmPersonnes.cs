using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using projetppe.Modele;
namespace projetppe
{
    public partial class FrmPersonnes : Form
    {
        public Program program;
        public Personnel personnel;

        public FrmPersonnes(Program program)
        {
            this.program = program;
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {

        }
  

        private void FrmPersonnes_Load(object sender, EventArgs e)
        {
   
        }

        private void tbxutilisateur_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_Load(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_Load(object sender, EventArgs e)
        {
            
        }

        public void SetMyCustomFormat()
        {



        }

        public void SetMyCustomFormat2()
        {
           


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnpappliquer_Click(object sender, EventArgs e)
        {
            string job = null;
            if (radioButton1.Checked)
                job = "Responsable";
            else if (radioButton2.Checked)
                job = "Administrateur";
            else if (radioButton3.Checked)
                job = "Trader";
            program.CreateUser(tbxutilisateur.Text, textBox1.Text, job, checksuspendu.Checked, dateTimePicker1.Value, dateTimePicker2.Value);
            MessageBox.Show("La personne a bien été créée !");
        }

        private void checksuspendu_Click(object sender, EventArgs e)
        {
           /* switch (checksuspendu.CheckState)
            {
                case CheckState.Checked:
                    personnel.Suspendu = true;
                    break;
                case CheckState.Unchecked:
                    personnel.Suspendu = false;
                    break;
                case CheckState.Indeterminate:
                   
                    break;

            }

            */
        }
    }
}

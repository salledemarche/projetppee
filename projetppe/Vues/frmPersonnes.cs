using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetppe
{
    public partial class FrmPersonnes : Form
    {
        public Program program;

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
    }
}

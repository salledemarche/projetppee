using projetppe.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace projetppe
{
    public partial class frmadmin : Form
    {
        public Program program;
        private Form activeForm;
        private Personnel personnel;

        public frmadmin(Program program)
        {
            InitializeComponent();
            this.program = program;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void ActivateButton(object btnSender)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void OpenChildFrom(Form childFrom, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            this.pnlform.Controls.Add(childFrom);
            this.pnlform.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();

        }

        private void pnlform_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnfichepersonne_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new FrmPersonnes(program), sender);
        }

        private void btnlistepersonne_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Frmliste(program, personnel), sender);
        }

        private void btnbudgets_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new projetppe.Frmbudgets(), sender);
        }

        private void btnmembre_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new projetppe.frmModificationMembre(), sender);
        }

        private void btnfinanciers_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new projetppe.Frmlisteproduits(), sender);
        }

        private void btnformulaire_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new projetppe.frmFormulaireOperation(), sender);
        }

        private void pnlform_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnllogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void imgfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgreduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

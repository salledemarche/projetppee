using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetppe
{
    public partial class FrmLogin : Form
    {
        private Program program;
        private frmadmin frameAdm;

        public frmadmin FrmAdmin { get; private set; }

        public FrmLogin(Program program)
        {
            InitializeComponent();
            this.program = program;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgreduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnconnexion_Click(object sender, EventArgs e)
        {
            if (!tbxutilisateur.Text.Equals("") && !tbxmdp.Text.Equals(""))
            {
                if (program.AuthControl(tbxutilisateur.Text, tbxmdp.Text))
                {
                    MessageBox.Show("L'identifiant ou le mot de passe sont OK !");
                    frameAdm = new frmadmin(program);
                    frameAdm.ShowDialog();
                    frameAdm.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
            Console.WriteLine(program.AuthControl(tbxutilisateur.Text, tbxmdp.Text));
            Console.ReadLine();
        }

        private void pnlblanc_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlblanc_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlbleu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlbleu_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

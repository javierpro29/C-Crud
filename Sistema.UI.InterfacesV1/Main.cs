using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.UI.InterfacesV1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mENPRINCIPALToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entidades entidad = new Entidades();
            entidad.Show();
            this.Visible = false;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acerca = new AcercaDe();
            acerca.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSplashV1 form = new FormSplashV1();
            form.Show();
            this.Visible = false;
        }
    }
}

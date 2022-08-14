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
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void AcercaDe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AcercaDe_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

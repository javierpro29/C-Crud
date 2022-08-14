using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.UI.InterfacesV1
{
    public partial class LoginV1 : Form
    {
        public LoginV1()
        {
            InitializeComponent();
        }

        public void LoginConectar() 
        {
            //try {
            //    if (textuser.Text != "")
            //    {
            //        if (textpass.Text != "")
            //        {
            //            var loger2 = loger.LoginExect(textuser.Text, textpass.Text);
            //            if (loger2 == true)
            //            {
            //                Objeto.Show();
            //                this.Hide();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Ha ocurrido un error");
            //                textpass.Clear();
            //                textuser.Focus();
            //            }
            //        }
            //        else
            //            MessageBox.Show("Please Enter password");
            //    }
            //    else {
            //        MessageBox.Show("Please Enter UserName");
            //    }
            //}
            //catch (Exception ex) 
            //{
            //    MessageBox.Show(ex.Message);
            //}

            try
            {

                SqlConnection cn = new SqlConnection("Data Source=.; Initial Catalog=SellPoint; Integrated Security=True");

                using (cn)
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("select * from Entidades where UserNameEntidad = '" + textuser.Text + "' AND PasswordEntidad= '" + textpass.Text + "'", cn))
                    {

                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            MessageBox.Show("Sus credenciales han sido verificadas correctamente");

                            Main main = new Main();
                            main.Visible = true;
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Contraseña o Usuario incorrecto");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginConectar();
        }

        private void LoginV1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textpass_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }
    }
}

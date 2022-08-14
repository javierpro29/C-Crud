using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.Capas.BL;
namespace Sistema.UI.InterfacesV1
{
    public partial class Entidades : Form
    {
        public Entidades()
        {
            InitializeComponent();
        }

        private bool Editar;
        private string IDEntidad = null;
        EntidadesMantenimiento OBusinnes = new EntidadesMantenimiento();

        public void MostrarProductos()
        {
            dataGridView1.DataSource = OBusinnes.MostrarDatos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EntidadesMantenimiento objetoInsert = new EntidadesMantenimiento();
            if (Editar == false)
            {


                try
                {
                    objetoInsert.InsertProductoBL(textdescripcion.Text, textdireccion.Text, textlocalidad.Text, textentidad.Text, texttipoD.Text, textNumeroD.Text,
                        texttell.Text, textweb.Text, textFace.Text, textinsta.Text, texttw.Text, texttik.Text, textcp.Text, textcg.Text, textlmc.Text, textuser.Text, textpass.Text,
                        textroll.Text, textcomentario.Text, textestado.Text, checkBox1.Checked, textfecha.Text);
                    MessageBox.Show("Los datos se insertaron correctamente");
                    MostrarProductos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos" + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    objetoInsert.Editar(textdescripcion.Text, textdireccion.Text, textlocalidad.Text, textentidad.Text, texttipoD.Text, textNumeroD.Text,
                    texttell.Text, textweb.Text, textFace.Text, textinsta.Text, texttw.Text, texttik.Text, textcp.Text, textcg.Text, textlmc.Text, textuser.Text, textpass.Text,
                    textroll.Text, textcomentario.Text, textestado.Text, checkBox1.Checked, textfecha.Text, IDEntidad);
                    MessageBox.Show("Los datos se Editaron correctamente");
                    MostrarProductos();
                    Editar = false;
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos" + ex);
                }
            }
        }

        private void LimpiarForm()
        {
            textdescripcion.Clear();
            textdireccion.Clear();
            textlocalidad.Clear();
            textentidad.Clear();
            texttipoD.Clear();
            textNumeroD.Clear();
            texttell.Clear();
            textweb.Clear();
            textFace.Clear();
            textinsta.Clear();
            texttw.Clear();
            texttik.Clear();
            textcp.Clear();
            textcg.Clear();
            textlmc.Clear();
            textuser.Clear();
            textpass.Clear();
            textroll.Clear();
            textcomentario.Clear();
            textestado.Clear();
            textfecha.Clear();

        }
        private void Entidades_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void Entidades_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttoneEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                textdescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                textdireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                textlocalidad.Text = dataGridView1.CurrentRow.Cells["Localidad"].Value.ToString();
                textentidad.Text = dataGridView1.CurrentRow.Cells["TipoEntidad"].Value.ToString();
                texttipoD.Text = dataGridView1.CurrentRow.Cells["TipoDocumento"].Value.ToString();
                textNumeroD.Text = dataGridView1.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
                texttell.Text = dataGridView1.CurrentRow.Cells["Telefonos"].Value.ToString();
                textweb.Text = dataGridView1.CurrentRow.Cells["URLPaginaWeb"].Value.ToString();
                textFace.Text = dataGridView1.CurrentRow.Cells["URLFacebook"].Value.ToString();
                textinsta.Text = dataGridView1.CurrentRow.Cells["URLInstagram"].Value.ToString();
                texttw.Text = dataGridView1.CurrentRow.Cells["URLTwitter"].Value.ToString();
                texttik.Text = dataGridView1.CurrentRow.Cells["URLTikTok"].Value.ToString();
                textcp.Text = dataGridView1.CurrentRow.Cells["CodigoPostal"].Value.ToString();
                textcg.Text = dataGridView1.CurrentRow.Cells["CoordenadasGPS"].Value.ToString();
                textlmc.Text = dataGridView1.CurrentRow.Cells["LimiteCredito"].Value.ToString();
                textuser.Text = dataGridView1.CurrentRow.Cells["UserNameEntidad"].Value.ToString();
                textpass.Text = dataGridView1.CurrentRow.Cells["PasswordEntidad"].Value.ToString();
                textroll.Text = dataGridView1.CurrentRow.Cells["RolUserEntidad"].Value.ToString();
                textcomentario.Text = dataGridView1.CurrentRow.Cells["Comentario"].Value.ToString();
                textestado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                checkBox1.Checked = dataGridView1.CurrentRow.Cells["NoEliminable"].Value.GetType() == typeof(bool);
                textfecha.Text = dataGridView1.CurrentRow.Cells["FechaRegistro"].Value.ToString();
                IDEntidad = dataGridView1.CurrentRow.Cells["IdEntidad"].Value.ToString();
            }
            else
                MessageBox.Show("Selleccione una fila, por favor");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadesMantenimiento objetoInsert = new EntidadesMantenimiento();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IDEntidad = dataGridView1.CurrentRow.Cells["IdEntidad"].Value.ToString();
                objetoInsert.Eliminar(IDEntidad);
                MessageBox.Show("El Campo ha sido eliminado correctamente");
                MostrarProductos();
            }
            else
                MessageBox.Show("Ha ocurrido un error al intentar eliminar el campo");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            Main main = new Main();
            main.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textpass_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            textpass.UseSystemPasswordChar = true;
        }
    }
}

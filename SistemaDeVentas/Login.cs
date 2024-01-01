using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace SistemaDeVentas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> test = new CN_Usuario().Listar();
            Usuario usuario = new CN_Usuario().Listar().Where(u => u.Documento == txtNumeroDocumento.Text && u.Clave == 
            txtClave.Text).FirstOrDefault();

            if(usuario !=null)
            {
                Inicio form = new Inicio();

                form.Show();
                this.Hide();

                form.FormClosing += frmClosing;
            }else
            {
                MessageBox.Show("No se encontró el usuario","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            
            
        }
        private void frmClosing(object sender,FormClosingEventArgs e)
        {
            txtNumeroDocumento.Text = "";
            txtClave.Text = "";
            this.Show();
        }

    }
}

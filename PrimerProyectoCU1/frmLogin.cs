using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyectoCU1
{
    public partial class frmLogin : Form //frmLogin es hijo de Form, hereda lo de Forb
    {
        string user = "admin";
        string pass = "1234";
        public frmLogin()  //Constructor de la clase
        {
            InitializeComponent();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Iniciar Sesion"; //es una propiedad
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //Metodo se cierra con parentesis
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text== " ")
            {
                MessageBox.Show("Debe ingresar un Usuario","ERROR");
                this.txtUsuario.Focus();
                return;
            }
            if (this.txtPassword.Text == " ") ;
            MessageBox.Show("Debe ingresar una Password");
            this.txtPassword.Focus();
            return;
            {

            }
            if (this.txtUsuario.Text==this.user && this.txtPassword.Text == this.pass)

            {
                MessageBox.Show("Loguin OK", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

         
          
       
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta", "Validacion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtPassword.Text = string.Empty;
                this.txtUsuario.Focus();

            }
        } 

        
        
        
       

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}

using BL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFarmacia {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }
        private void btnRegistrarse_Click(object sender, EventArgs e) {
            Registro res = new Registro(this);
            res.Show();
            this.Hide();
        }
        private void btnIngresar_Click(object sender, EventArgs e) {
            blUsuario blu = new blUsuario();
            int num = blu.contar_usuario();
            if (num > 0) {
                for(int i = 1; i < num+1; i++) {
                    clsUsuario temp = blu.leer_usuario(i);
                    if ((txtUsuario.Text == temp.username) && (txtContrasena.Text == temp.contrasena)) {
                        VentanaPrincipal ven = new VentanaPrincipal(this);
                        ven.Show();
                        this.Hide();
                        return;
                    }
                }
            }
            MessageBox.Show("Usuario o Contraseña Erroneos"
                , "Error de Login"
                , MessageBoxButtons.OK
                ,MessageBoxIcon.Error);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter)
                txtContrasena.Focus();
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter)
                btnIngresar_Click(sender, e);
        }
    }
}

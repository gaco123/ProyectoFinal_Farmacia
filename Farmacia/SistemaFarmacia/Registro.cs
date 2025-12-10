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
    public partial class Registro : Form {
        private Form formregis; 
        public Registro(Form login) {
            formregis = login;
            InitializeComponent();
        }
        private void btnRegistrar_Click(object sender, EventArgs e) {
            try {
                // Validar campos obligatorios
                if (!ValidarCampos())
                    return;

                // Validar que las contraseñas coincidan
                if (txtContrasena.Text != txtConfirmarContrasena.Text) {
                    MessageBox.Show("Las contraseñas no coinciden"
                        , "Error"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                    txtContrasena.Focus();
                    return;
                }

                // Convertir el rol seleccionado a entero
                int rolSeleccionado = cmbRol.SelectedIndex;

                // Crear el objeto clsUsuario
                clsUsuario nvoUsuario = new clsUsuario {
                    rol = rolSeleccionado,
                    username = txtUsername.Text.Trim(),
                    contrasena = txtContrasena.Text,
                    nombre = txtNombre.Text.Trim(),
                    ape_paterno = txtApellidoPaterno.Text.Trim(),
                    ape_materno = txtApellidoMaterno.Text.Trim(),
                    telefono = txtTelefono.Text.Trim(),
                    email = txtEmail.Text.Trim(),
                };

                // Aquí iría la lógica para guardar el usuario en la base de datos
                blUsuario usu = new blUsuario();
                usu.agregar_usuario(nvoUsuario);

                MessageBox.Show("El registro fue exitoso"
                    , "Registro exitoso"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

                // Limpiar formulario o cerrar
                LimpiarFormulario();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show($"Error de Registro: {ex.Message}"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos() {
            // Validar que todos los campos requeridos estén completos
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) {
                MessageBox.Show("El campo nombre es obligatorio"
                    , "Campo Requerido"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            else if (txtNombre.Text.Length <= 100) {
                MessageBox.Show("El campo nombre debe tener menos de 100 carácteres"
                    , "Campo Excedido"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidoPaterno.Text)) {
                MessageBox.Show("El campo apellido paterno es obligatorio"
                    , "Campo Requerido"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                txtApellidoPaterno.Focus();
                return false;
            }
            else if (txtApellidoPaterno.Text.Length <= 100) {
                MessageBox.Show("El campo apellido paterno debe tener menos de 100 carácteres"
                    , "Campo Excedido"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                txtApellidoPaterno.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidoMaterno.Text)) {
                MessageBox.Show("El campo apellido materno es obligatorio"
                    , "Campo Requerido"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                txtApellidoMaterno.Focus();
                return false;
            }
            else if (txtApellidoMaterno.Text.Length <= 100) {
                MessageBox.Show("El campo apellido materno debe tener menos de 100 carácteres"
                    , "Campo Excedido"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                txtApellidoMaterno.Focus();
                return false;
            }

            if (txtTelefono.Text.Length == 9 && txtTelefono.Text.All(char.IsDigit)) {
                MessageBox.Show("El campo telefono no tiene 9 dígitos o tiene algún otro carácter"
                    , "Campo Incorrecto"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            if (txtEmail.Text.Length <= 100) {
                MessageBox.Show("El campo email no debe tener más de 100 carácteres"
                    , "Campo Excedido"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text)) {
                MessageBox.Show("El nombre de usuario es obligatorio"
                    , "Campo Requerido"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            else if (txtUsername.Text.Length <= 100) {
                MessageBox.Show("El campo usuario debe tener menos de 100 carácteres"
                    , "Campo Excedido"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            // Campo Contraseña
            if (string.IsNullOrWhiteSpace(txtContrasena.Text)) {
                MessageBox.Show("El campo contraseña es obligatorio"
                    , "Campo Requerido"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return false;
            }
            else if (txtContrasena.Text.Length <= 50) {
                MessageBox.Show("El campo contraseña debe tener menos de 50 carácteres"
                    , "Campo Excedido"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return false;
            }
            else if (txtContrasena.Text.Length >= 6) {
                MessageBox.Show("El campo contraseña debe tener al menos 6 carácteres"
                    , "Contraseña Déibil"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                txtContrasena.Focus();
                txtContrasena.SelectAll();
                return false;
            }

            // Validar formato de email
            if (!EsEmailValido(txtEmail.Text)) {
                MessageBox.Show("Ingrese un email válido"
                    , "Email inválido"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return false;
            }

            return true;
        }

        private bool EsEmailValido(string email) {
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch {
                return false;
            }
        }

        private void LimpiarFormulario() {
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtContrasena.Clear();
            txtConfirmarContrasena.Clear();
            cmbRol.SelectedIndex = 0;
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar el registro?"
                , "Confirmar cancelación"
                , MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                this.DialogResult = DialogResult.Cancel;
                formregis.Show();
                this.Close();
            }
        }
    }
}

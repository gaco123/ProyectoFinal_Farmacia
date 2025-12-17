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
    public partial class FormularioEliminar : Form {
        private blProducto blProducto = new blProducto();
        private clsUsuario usu = new clsUsuario();
        private List<clsProducto> productos = new List<clsProducto>();

        public FormularioEliminar(clsUsuario usu) {
            InitializeComponent();
            CargarDatosIniciales();
            this.usu = usu; 
        }

        private void FormularioEditarProducto_Load(object sender, EventArgs e) {
            ConfigurarControles();
            cmbId.Text = "";
            rtboxMotivo.Clear();
        }

        private void CargarDatosIniciales() {
            for (int i = 1; i < blProducto.contar_producto() + 1; i++) {
                productos.Add(blProducto.leer_producto(i));
            }
        }

        private void ConfigurarControles() {
            //Cargar ids productos
            cmbId.Items.Clear();
            foreach (var pro in productos) {
                if (pro.estado != "B") {
                    cmbId.Items.Add(new ComboItem(pro.nombre, pro.id));
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if (ValidarCampos()) {
                DialogResult result = MessageBox.Show($"¿Está seguro de eliminar el producto '{cmbId.Text}'?"
                    , "Confirmar eliminación"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    GuardarProducto();
                    this.Close();
                }
            }
        }
        private void GuardarProducto() {
            try {
                // Actualizar producto
                int id = ((ComboItem)cmbId.SelectedItem).Valor;
                string motivo = rtboxMotivo.Text.Trim();

                // Guardar usando BL
                blProducto.eliminar_producto(id, motivo, usu.id);

                MessageBox.Show("Producto eliminado exitosamente"
                    , "Éxito"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Clase auxiliar para combobox
        private class ComboItem {
            public string Texto { get; set; }
            public int Valor { get; set; }

            public ComboItem(string texto, int valor) {
                Texto = texto;
                Valor = valor;
            }

            public override string ToString() {
                return Texto;
            }
        }

        private bool ValidarCampos() {
            bool valido = true;
            errorProvider1.Clear();

            // Validar Nombre
            if (string.IsNullOrWhiteSpace(rtboxMotivo.Text)) {
                errorProvider1.SetError(rtboxMotivo, "El nombre es requerido");
                valido = false;
            }
            else if (rtboxMotivo.Text.Length > 500) {
                errorProvider1.SetError(rtboxMotivo, "Máximo 500 caracteres");
                valido = false;
            }

            return valido;
        }
    }
}

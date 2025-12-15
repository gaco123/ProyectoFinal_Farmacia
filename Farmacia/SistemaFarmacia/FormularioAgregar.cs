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
    public partial class FormularioAgregar : Form {
        private blProducto blProducto = new blProducto();
        private List<clsLaboratorio> laboratorios = new List<clsLaboratorio>();
        private List<clsCategoria> categorias = new List<clsCategoria>();

        // Propiedad para obtener el producto creado
        public clsProducto Producto { get; private set; }
        public FormularioAgregar() {
            InitializeComponent();
            CargarDatosIniciales();
        }

        private void FormularioAgregarProducto_Load(object sender, EventArgs e) {
            ConfigurarControles();
            LimpiarFormulario();
        }

        private void CargarDatosIniciales() {
            // Aquí cargarías laboratorios y categorías de la base de datos
            // Por ahora datos de ejemplo
            blLaboratorio blab = new blLaboratorio();
            for (int i = 1; i < blab.contar_laboratorio() + 1; i++) {
                laboratorios.Add(blab.leer_laboratorio(i));
            }

            blCategoria bcat = new blCategoria();
            for (int i = 1; i < bcat.contar_categoria() + 1; i++) {
                categorias.Add(bcat.leer_categoria(i));
            }
        }

        private void ConfigurarControles() {
            // Cargar laboratorios
            cmbLaboratorio.Items.Clear();
            foreach (var lab in laboratorios) {
                cmbLaboratorio.Items.Add(new ComboItem(lab.nombre, lab.id));
            }
            if (cmbLaboratorio.Items.Count > 0)
                cmbLaboratorio.SelectedIndex = 0;

            // Cargar categorías
            cmbCategoria.Items.Clear();
            foreach (var cat in categorias) {
                cmbCategoria.Items.Add(new ComboItem(cat.nombre, cat.id));
            }
            if (cmbCategoria.Items.Count > 0)
                cmbCategoria.SelectedIndex = 0;

            // Configurar unidad de medida
            if (cmbUnidadMedida.Items.Count > 0)
                cmbUnidadMedida.SelectedIndex = 0;

            // Configurar estado
            if (cmbEstado.Items.Count > 0)
                cmbEstado.SelectedIndex = 0;

            // Configurar valores por defecto
            numStockActual.Value = 0;
            numStockMinimo.Value = 10;
            numStockMaximo.Value = 100;
            numUbicacion.Value = 1;
            numPrecioUnitario.Value = 0.0000m;
            numCostoUnitario.Value = 0.0000m;
        }

        private void LimpiarFormulario() {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrincipioActivo.Clear();
            txtConcentracion.Clear();
            txtPresentacion.Clear();

            if (cmbLaboratorio.Items.Count > 0) cmbLaboratorio.SelectedIndex = 0;
            if (cmbCategoria.Items.Count > 0)
                if (cmbUnidadMedida.Items.Count > 0) cmbUnidadMedida.SelectedIndex = 0;
            if (cmbEstado.Items.Count > 0) cmbEstado.SelectedIndex = 0;

            numStockActual.Value = 0;
            numStockMinimo.Value = 10;
            numStockMaximo.Value = 100;
            numUbicacion.Value = 1;
            numPrecioUnitario.Value = 0.0000m;
            numCostoUnitario.Value = 0.0000m;

            errorProvider1.Clear();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if (ValidarCampos()) {
                GuardarProducto();
                this.Close();
            }
        }

        private bool ValidarCampos() {
            bool valido = true;
            errorProvider1.Clear();

            // Validar Nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) {
                errorProvider1.SetError(txtNombre, "El nombre es requerido");
                valido = false;
            }
            else if (txtNombre.Text.Length > 100) {
                errorProvider1.SetError(txtNombre, "Máximo 100 caracteres");
                valido = false;
            }

            // Validar Descripción
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text)) {
                errorProvider1.SetError(txtDescripcion, "La descripción es requerida");
                valido = false;
            }
            else if (txtDescripcion.Text.Length > 500) {
                errorProvider1.SetError(txtDescripcion, "Máximo 500 caracteres");
                valido = false;
            }

            // Validar Principio Activo
            if (string.IsNullOrWhiteSpace(txtPrincipioActivo.Text)) {
                errorProvider1.SetError(txtPrincipioActivo, "El principio activo es requerido");
                valido = false;
            }
            else if (txtPrincipioActivo.Text.Length > 100) {
                errorProvider1.SetError(txtPrincipioActivo, "Máximo 100 caracteres");
                valido = false;
            }

            // Validar Concentración
            if (string.IsNullOrWhiteSpace(txtConcentracion.Text)) {
                errorProvider1.SetError(txtConcentracion, "La concentración es requerida");
                valido = false;
            }
            else if (!int.TryParse(txtConcentracion.Text, out int concentracion)) {
                errorProvider1.SetError(txtConcentracion, "Debe ser un número entero");
                valido = false;
            }
            else if (concentracion <= 0) {
                errorProvider1.SetError(txtConcentracion, "Debe ser mayor a 0");
                valido = false;
            }

            // Validar Presentación
            if (string.IsNullOrWhiteSpace(txtPresentacion.Text)) {
                errorProvider1.SetError(txtPresentacion, "La presentación es requerida");
                valido = false;
            }
            else if (txtPresentacion.Text.Length > 100) {
                errorProvider1.SetError(txtPresentacion, "Máximo 100 caracteres");
                valido = false;
            }

            // Validar Laboratorio
            if (cmbLaboratorio.SelectedItem == null) {
                errorProvider1.SetError(cmbLaboratorio, "Seleccione un laboratorio");
                valido = false;
            }

            // Validar Categoría
            if (cmbCategoria.SelectedItem == null) {
                errorProvider1.SetError(cmbCategoria, "Seleccione una categoría");
                valido = false;
            }

            // Validar Unidad de Medida
            if (cmbUnidadMedida.SelectedItem == null) {
                errorProvider1.SetError(cmbUnidadMedida, "Seleccione una unidad de medida");
                valido = false;
            }

            // Validar Estado
            if (cmbEstado.SelectedItem == null) {
                errorProvider1.SetError(cmbEstado, "Seleccione un estado");
                valido = false;
            }

            // Validar Stock Mínimo vs Máximo
            if (numStockMinimo.Value > numStockMaximo.Value) {
                errorProvider1.SetError(numStockMinimo, "Stock mínimo no puede ser mayor al máximo");
                errorProvider1.SetError(numStockMaximo, "Stock máximo no puede ser menor al mínimo");
                valido = false;
            }

            // Validar Stock Actual
            if (numStockActual.Value < 0) {
                errorProvider1.SetError(numStockActual, "No puede ser negativo");
                valido = false;
            }

            // Validar Precio Unitario
            if (numPrecioUnitario.Value <= 0) {
                errorProvider1.SetError(numPrecioUnitario, "Debe ser mayor a 0");
                valido = false;
            }

            // Validar Costo Unitario
            if (numCostoUnitario.Value <= 0) {
                errorProvider1.SetError(numCostoUnitario, "Debe ser mayor a 0");
                valido = false;
            }

            // Validar Ubicación
            if (numUbicacion.Value <= 0) {
                errorProvider1.SetError(numUbicacion, "Debe ser mayor a 0");
                valido = false;
            }

            return valido;
        }

        private void GuardarProducto() {
            try {
                // Crear nuevo producto
                Producto = new clsProducto {
                    // El ID se generará automáticamente en la base de datos
                    nombre = txtNombre.Text.Trim(),
                    descripcion = txtDescripcion.Text.Trim(),
                    principio_activo = txtPrincipioActivo.Text.Trim(),
                    laboratorio = ((ComboItem)cmbLaboratorio.SelectedItem).Valor,
                    categoria = ((ComboItem)cmbCategoria.SelectedItem).Valor,
                    concentracion = int.Parse(txtConcentracion.Text),
                    unidad_medida = cmbUnidadMedida.SelectedItem.ToString(),
                    presentacion = txtPresentacion.Text.Trim(),
                    stock_actual = (int)numStockActual.Value,
                    stock_minimo = (int)numStockMinimo.Value,
                    stock_maximo = (int)numStockMaximo.Value,
                    ubicacion = (int)numUbicacion.Value,
                    precio_unitario = numPrecioUnitario.Value,
                    costo_unitario = numCostoUnitario.Value,
                    estado = cmbEstado.SelectedItem.ToString()
                };

                // Guardar usando BL
                blProducto.agregar_producto(Producto);

                MessageBox.Show("Producto agregado exitosamente"
                    , "Éxito"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show($"Error al guardar el producto: {ex.Message}"
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtConcentracion_KeyPress(object sender, KeyPressEventArgs e) {
            // Permitir solo números y control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
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

        // Validación en tiempo real
        private void txtNombre_TextChanged(object sender, EventArgs e) {
            if (txtNombre.Text.Length > 100) {
                errorProvider1.SetError(txtNombre, "Máximo 100 caracteres");
            }
            else {
                errorProvider1.SetError(txtNombre, "");
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e) {
            if (txtDescripcion.Text.Length > 500) {
                errorProvider1.SetError(txtDescripcion, "Máximo 500 caracteres");
            }
            else {
                errorProvider1.SetError(txtDescripcion, "");
            }
        }

        private void numStockMinimo_ValueChanged(object sender, EventArgs e) {
            if (numStockMinimo.Value > numStockMaximo.Value) {
                errorProvider1.SetError(numStockMinimo, "No puede ser mayor al stock máximo");
            }
            else {
                errorProvider1.SetError(numStockMinimo, "");
            }
        }

        private void numStockMaximo_ValueChanged(object sender, EventArgs e) {
            if (numStockMaximo.Value < numStockMinimo.Value) {
                errorProvider1.SetError(numStockMaximo, "No puede ser menor al stock mínimo");
            }
            else {
                errorProvider1.SetError(numStockMaximo, "");
            }
        }

        // Navegación con tecla Enter
        private void txt_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        // Formatear valores monetarios
        private void numPrecioUnitario_Enter(object sender, EventArgs e) {
            numPrecioUnitario.Select(0, numPrecioUnitario.Text.Length);
        }

        private void numCostoUnitario_Enter(object sender, EventArgs e) {
            numCostoUnitario.Select(0, numCostoUnitario.Text.Length);
        }

        // Validar al perder foco
        private void txtConcentracion_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (!string.IsNullOrWhiteSpace(txtConcentracion.Text) &&
                !int.TryParse(txtConcentracion.Text, out _)) {
                errorProvider1.SetError(txtConcentracion, "Debe ser un número entero");
                e.Cancel = true;
            }
        }
    }
}

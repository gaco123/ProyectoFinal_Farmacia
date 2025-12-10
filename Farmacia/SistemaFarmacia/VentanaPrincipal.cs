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
    public partial class VentanaPrincipal : Form {
        private List<clsProducto> listaProductos = new List<clsProducto>();
        private List<clsLaboratorio> listaLaboratorios = new List<clsLaboratorio>();
        private List<clsCategoria> listaCategorias = new List<clsCategoria>();

        // Variables para selección actual
        private clsProducto productoSeleccionado = null;
        private clsLaboratorio laboratorioSeleccionado = null;
        private clsCategoria categoriaSeleccionada = null;

        private Form ven;

        public VentanaPrincipal(Form ven) {
            InitializeComponent();
            ConfigurarDataGridViews();
            this.ven = ven;
        }

        private void FormGestionProductos_Load(object sender, EventArgs e) {
            CargarDatosIniciales();
            ActualizarContadores();
        }

        private void ConfigurarDataGridViews() {
            // Configurar DataGridView de Productos
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.Columns.Add("id", "ID");
            dgvProductos.Columns.Add("nombre", "Nombre");
            dgvProductos.Columns.Add("descripcion", "Descripción");
            dgvProductos.Columns.Add("principio_activo", "Principio Activo");
            dgvProductos.Columns.Add("stock_actual", "Stock Actual");
            dgvProductos.Columns.Add("precio_unitario", "Precio Unitario");
            dgvProductos.Columns.Add("estado", "Estado");

            // Configurar DataGridView de Laboratorios
            dgvLaboratorios.AutoGenerateColumns = false;
            dgvLaboratorios.Columns.Add("id", "ID");
            dgvLaboratorios.Columns.Add("nombre", "Nombre");
            dgvLaboratorios.Columns.Add("direccion", "Dirección");
            dgvLaboratorios.Columns.Add("telefono", "Teléfono");

            // Configurar DataGridView de Categorías
            dgvCategorias.AutoGenerateColumns = false;
            dgvCategorias.Columns.Add("id", "ID");
            dgvCategorias.Columns.Add("nombre", "Nombre");
            dgvCategorias.Columns.Add("descripcion", "Descripción");
        }

        private void CargarDatosIniciales() {
            try {
                lblEstado.Text = "Cargando datos...";

                // Cargar productos (aquí iría la conexión a base de datos)
                listaProductos = new List<clsProducto>
                {
                    new clsProducto(1, "Paracetamol", "Analgésico y antipirético",
                        "Paracetamol", 1, 1, 500, "mg", "Tabletas", 100, 20, 200, 1, 2.50, 1.50, "Activo"),
                    new clsProducto(2, "Ibuprofeno", "Antiinflamatorio no esteroideo",
                        "Ibuprofeno", 1, 1, 400, "mg", "Cápsulas", 50, 10, 100, 1, 3.00, 2.00, "Activo")
                };

                // Cargar laboratorios
                listaLaboratorios = new List<clsLaboratorio>
                {
                    new clsLaboratorio(1, "Pfizer", "Av. Principal 123", "555-1234"),
                    new clsLaboratorio(2, "Bayer", "Calle Secundaria 456", "555-5678")
                };

                // Cargar categorías
                listaCategorias = new List<clsCategoria>
                {
                    new clsCategoria(1, "Analgésicos", "Medicamentos para el dolor"),
                    new clsCategoria(2, "Antibióticos", "Medicamentos para infecciones")
                };

                ActualizarDataGridViews();
                lblEstado.Text = "Datos cargados correctamente";
            }
            catch (Exception ex) {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEstado.Text = "Error al cargar datos";
            }
        }

        private void ActualizarDataGridViews() {
            // Actualizar DataGridView de productos
            dgvProductos.Rows.Clear();
            foreach (var producto in listaProductos) {
                dgvProductos.Rows.Add(
                    producto.id,
                    producto.nombre,
                    producto.descripcion,
                    producto.principio_activo,
                    producto.stock_actual,
                    $"${producto.precio_unitario:F2}",
                    producto.estado
                );
            }

            // Actualizar DataGridView de laboratorios
            dgvLaboratorios.Rows.Clear();
            foreach (var lab in listaLaboratorios) {
                dgvLaboratorios.Rows.Add(lab.id, lab.nombre, lab.direccion, lab.telefono);
            }

            // Actualizar DataGridView de categorías
            dgvCategorias.Rows.Clear();
            foreach (var cat in listaCategorias) {
                dgvCategorias.Rows.Add(cat.id, cat.nombre, cat.descripcion);
            }

            ActualizarContadores();
        }

        private void ActualizarContadores() {
            lblTotalProductos.Text = $"Total: {listaProductos.Count} productos";
        }

        // ========== EVENTOS DE PRODUCTOS ==========

        private void btnNuevoProducto_Click(object sender, EventArgs e) {
            //AbrirFormularioProducto(null);
        }

        private void btnEditarProducto_Click(object sender, EventArgs e) {
            if (productoSeleccionado != null) {
                //AbrirFormularioProducto(productoSeleccionado);
            }
            else {
                MessageBox.Show("Seleccione un producto para editar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e) {
            if (productoSeleccionado != null) {
                DialogResult result = MessageBox.Show(
                    $"¿Está seguro de eliminar el producto '{productoSeleccionado.nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    // Aquí iría la lógica para eliminar de la base de datos
                    listaProductos.Remove(productoSeleccionado);
                    ActualizarDataGridViews();
                    lblEstado.Text = $"Producto '{productoSeleccionado.nombre}' eliminado";
                    productoSeleccionado = null;
                }
            }
            else {
                MessageBox.Show("Seleccione un producto para eliminar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            CargarDatosIniciales();
            lblEstado.Text = "Datos actualizados";
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e) {
            if (dgvProductos.SelectedRows.Count > 0) {
                int id = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["id"].Value);
                productoSeleccionado = listaProductos.FirstOrDefault(p => p.id == id);
            }
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                btnEditarProducto_Click(sender, e);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            BuscarProductos();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                BuscarProductos();
            }
        }

        private void BuscarProductos() {
            string textoBusqueda = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(textoBusqueda)) {
                ActualizarDataGridViews();
                return;
            }

            var resultados = listaProductos.Where(p =>
                p.nombre.ToLower().Contains(textoBusqueda) ||
                p.descripcion.ToLower().Contains(textoBusqueda) ||
                p.principio_activo.ToLower().Contains(textoBusqueda) ||
                p.estado.ToLower().Contains(textoBusqueda)
            ).ToList();

            dgvProductos.Rows.Clear();
            foreach (var producto in resultados) {
                dgvProductos.Rows.Add(
                    producto.id,
                    producto.nombre,
                    producto.descripcion,
                    producto.principio_activo,
                    producto.stock_actual,
                    $"${producto.precio_unitario:F2}",
                    producto.estado
                );
            }

            lblEstado.Text = $"Encontrados {resultados.Count} productos";
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e) {
            txtBuscar.Clear();
            ActualizarDataGridViews();
        }

        // ========== EVENTOS DE LABORATORIOS ==========

        private void btnNuevoLaboratorio_Click(object sender, EventArgs e) {
            LimpiarCamposLaboratorio();
            HabilitarCamposLaboratorio(true);
        }

        private void btnEditarLaboratorio_Click(object sender, EventArgs e) {
            if (laboratorioSeleccionado != null) {
                CargarDatosLaboratorio();
                HabilitarCamposLaboratorio(true);
            }
            else {
                MessageBox.Show("Seleccione un laboratorio para editar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarLaboratorio_Click(object sender, EventArgs e) {
            if (laboratorioSeleccionado != null) {
                DialogResult result = MessageBox.Show(
                    $"¿Está seguro de eliminar el laboratorio '{laboratorioSeleccionado.nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    // Verificar si hay productos asociados
                    bool tieneProductos = listaProductos.Any(p => p.laboratorio == laboratorioSeleccionado.id);

                    if (tieneProductos) {
                        MessageBox.Show("No se puede eliminar el laboratorio porque tiene productos asociados",
                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Eliminar de la lista
                    listaLaboratorios.Remove(laboratorioSeleccionado);
                    ActualizarDataGridViews();
                    LimpiarCamposLaboratorio();
                    lblEstado.Text = $"Laboratorio '{laboratorioSeleccionado.nombre}' eliminado";
                    laboratorioSeleccionado = null;
                }
            }
            else {
                MessageBox.Show("Seleccione un laboratorio para eliminar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvLaboratorios_SelectionChanged(object sender, EventArgs e) {
            if (dgvLaboratorios.SelectedRows.Count > 0) {
                int id = Convert.ToInt32(dgvLaboratorios.SelectedRows[0].Cells["id"].Value);
                laboratorioSeleccionado = listaLaboratorios.FirstOrDefault(l => l.id == id);
                CargarDatosLaboratorio();
            }
        }

        private void CargarDatosLaboratorio() {
            if (laboratorioSeleccionado != null) {
                txtNombreLab.Text = laboratorioSeleccionado.nombre;
                txtDireccionLab.Text = laboratorioSeleccionado.direccion;
                txtTelefonoLab.Text = laboratorioSeleccionado.telefono;
            }
        }

        private void LimpiarCamposLaboratorio() {
            txtNombreLab.Clear();
            txtDireccionLab.Clear();
            txtTelefonoLab.Clear();
            laboratorioSeleccionado = null;
        }

        private void HabilitarCamposLaboratorio(bool habilitar) {
            txtNombreLab.Enabled = habilitar;
            txtDireccionLab.Enabled = habilitar;
            txtTelefonoLab.Enabled = habilitar;
        }

        private void GuardarLaboratorio() {
            if (string.IsNullOrWhiteSpace(txtNombreLab.Text)) {
                MessageBox.Show("El nombre del laboratorio es requerido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreLab.Focus();
                return;
            }

            if (laboratorioSeleccionado == null) {
                // Nuevo laboratorio
                int nuevoId = listaLaboratorios.Count > 0 ? listaLaboratorios.Max(l => l.id) + 1 : 1;
                var nuevoLab = new clsLaboratorio(
                    nuevoId,
                    txtNombreLab.Text.Trim(),
                    txtDireccionLab.Text.Trim(),
                    txtTelefonoLab.Text.Trim()
                );
                listaLaboratorios.Add(nuevoLab);
                lblEstado.Text = $"Laboratorio '{nuevoLab.nombre}' creado";
            }
            else {
                // Editar laboratorio existente
                laboratorioSeleccionado.nombre = txtNombreLab.Text.Trim();
                laboratorioSeleccionado.direccion = txtDireccionLab.Text.Trim();
                laboratorioSeleccionado.telefono = txtTelefonoLab.Text.Trim();
                lblEstado.Text = $"Laboratorio '{laboratorioSeleccionado.nombre}' actualizado";
            }

            ActualizarDataGridViews();
            LimpiarCamposLaboratorio();
            HabilitarCamposLaboratorio(false);
        }

        private void txtTelefonoLab_KeyPress(object sender, KeyPressEventArgs e) {
            // Permitir solo números, backspace, y guiones
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-') {
                e.Handled = true;
            }
        }

        // ========== EVENTOS DE CATEGORÍAS ==========

        private void btnNuevaCategoria_Click(object sender, EventArgs e) {
            LimpiarCamposCategoria();
            HabilitarCamposCategoria(true);
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e) {
            if (categoriaSeleccionada != null) {
                CargarDatosCategoria();
                HabilitarCamposCategoria(true);
            }
            else {
                MessageBox.Show("Seleccione una categoría para editar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e) {
            if (categoriaSeleccionada != null) {
                DialogResult result = MessageBox.Show(
                    $"¿Está seguro de eliminar la categoría '{categoriaSeleccionada.nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    // Verificar si hay productos asociados
                    bool tieneProductos = listaProductos.Any(p => p.categoria == categoriaSeleccionada.id);

                    if (tieneProductos) {
                        MessageBox.Show("No se puede eliminar la categoría porque tiene productos asociados",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Eliminar de la lista
                    listaCategorias.Remove(categoriaSeleccionada);
                    ActualizarDataGridViews();
                    LimpiarCamposCategoria();
                    lblEstado.Text = $"Categoría '{categoriaSeleccionada.nombre}' eliminada";
                    categoriaSeleccionada = null;
                }
            }
            else {
                MessageBox.Show("Seleccione una categoría para eliminar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e) {
            if (dgvCategorias.SelectedRows.Count > 0) {
                int id = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["id"].Value);
                categoriaSeleccionada = listaCategorias.FirstOrDefault(c => c.id == id);
                CargarDatosCategoria();
            }
        }

        private void CargarDatosCategoria() {
            if (categoriaSeleccionada != null) {
                txtNombreCat.Text = categoriaSeleccionada.nombre;
                txtDescripcionCat.Text = categoriaSeleccionada.descripcion;
            }
        }

        private void LimpiarCamposCategoria() {
            txtNombreCat.Clear();
            txtDescripcionCat.Clear();
            categoriaSeleccionada = null;
        }

        private void HabilitarCamposCategoria(bool habilitar) {
            txtNombreCat.Enabled = habilitar;
            txtDescripcionCat.Enabled = habilitar;
        }

        private void GuardarCategoria() {
            if (string.IsNullOrWhiteSpace(txtNombreCat.Text)) {
                MessageBox.Show("El nombre de la categoría es requerido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreCat.Focus();
                return;
            }

            if (categoriaSeleccionada == null) {
                // Nueva categoría
                int nuevoId = listaCategorias.Count > 0 ? listaCategorias.Max(c => c.id) + 1 : 1;
                var nuevaCat = new clsCategoria(
                    nuevoId,
                    txtNombreCat.Text.Trim(),
                    txtDescripcionCat.Text.Trim()
                );
                listaCategorias.Add(nuevaCat);
                lblEstado.Text = $"Categoría '{nuevaCat.nombre}' creada";
            }
            else {
                // Editar categoría existente
                categoriaSeleccionada.nombre = txtNombreCat.Text.Trim();
                categoriaSeleccionada.descripcion = txtDescripcionCat.Text.Trim();
                lblEstado.Text = $"Categoría '{categoriaSeleccionada.nombre}' actualizada";
            }

            ActualizarDataGridViews();
            LimpiarCamposCategoria();
            HabilitarCamposCategoria(false);
        }

        // ========== MÉTODOS AUXILIARES ==========
        /*
        private void AbrirFormularioProducto(clsProducto producto) {
            formProducto = new FormProducto(producto, listaLaboratorios, listaCategorias);
            formProducto.ProductoGuardado += (s, productoGuardado) => {
                if (producto == null) {
                    // Nuevo producto
                    listaProductos.Add(productoGuardado);
                    lblEstado.Text = $"Producto '{productoGuardado.nombre}' creado";
                }
                else {
                    // Editar producto existente
                    int index = listaProductos.FindIndex(p => p.id == producto.id);
                    if (index >= 0) {
                        listaProductos[index] = productoGuardado;
                        lblEstado.Text = $"Producto '{productoGuardado.nombre}' actualizado";
                    }
                }
                ActualizarDataGridViews();
            };

            formProducto.ShowDialog();
        }
        */

        // ========== EVENTOS DEL MENÚ ==========

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e) {
            btnNuevoProducto_Click(sender, e);
        }

        private void editarProductoToolStripMenuItem_Click(object sender, EventArgs e) {
            btnEditarProducto_Click(sender, e);
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e) {
            btnEliminarProducto_Click(sender, e);
        }

        private void actualizarListaToolStripMenuItem_Click(object sender, EventArgs e) {
            btnActualizar_Click(sender, e);
        }

        private void guardarCambiosToolStripMenuItem_Click(object sender, EventArgs e) {
            // Guardar cambios en laboratorio o categoría según la pestaña activa
            if (tabControlPrincipal.SelectedTab == tabLaboratorios) {
                GuardarLaboratorio();
            }
            else if (tabControlPrincipal.SelectedTab == tabCategorias) {
                GuardarCategoria();
            }
            else {
                MessageBox.Show("No hay cambios para guardar en esta pestaña", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e) {
            ExportarDatos();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void gestiónDeLaboratoriosToolStripMenuItem_Click(object sender, EventArgs e) {
            tabControlPrincipal.SelectedTab = tabLaboratorios;
        }

        private void gestiónDeCategoríasToolStripMenuItem_Click(object sender, EventArgs e) {
            tabControlPrincipal.SelectedTab = tabCategorias;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Gestión de Productos Farmacéuticos\nVersión 1.0\n© 2024",
                "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportar_Click(object sender, EventArgs e) {
            ExportarDatos();
        }

        private void btnImprimir_Click(object sender, EventArgs e) {
            ImprimirReporte();
        }

        private void ExportarDatos() {
            try {
                using (SaveFileDialog saveDialog = new SaveFileDialog()) {
                    saveDialog.Filter = "Archivo CSV (*.csv)|*.csv|Archivo Excel (*.xlsx)|*.xlsx";
                    saveDialog.FilterIndex = 1;
                    saveDialog.RestoreDirectory = true;

                    if (saveDialog.ShowDialog() == DialogResult.OK) {
                        // Aquí iría la lógica para exportar a CSV o Excel
                        // Por ahora solo mostramos un mensaje
                        MessageBox.Show($"Datos exportados a: {saveDialog.FileName}",
                            "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblEstado.Text = "Datos exportados correctamente";
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImprimirReporte() {
            // Aquí iría la lógica para imprimir
            MessageBox.Show("Funcionalidad de impresión en desarrollo", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e) {
            // Cuando cambia de pestaña, actualizar el estado
            switch (tabControlPrincipal.SelectedIndex) {
                case 0:
                    lblEstado.Text = $"Mostrando {listaProductos.Count} productos";
                    break;
                case 1:
                    lblEstado.Text = $"Mostrando {listaLaboratorios.Count} laboratorios";
                    break;
                case 2:
                    lblEstado.Text = $"Mostrando {listaCategorias.Count} categorías";
                    break;
            }
        }

        // ========== VALIDACIÓN DE DATOS ==========

        private bool ValidarLaboratorio() {
            if (string.IsNullOrWhiteSpace(txtNombreLab.Text)) {
                MessageBox.Show("El nombre es requerido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidarCategoria() {
            if (string.IsNullOrWhiteSpace(txtNombreCat.Text)) {
                MessageBox.Show("El nombre es requerido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // ========== EVENTOS DE VALIDACIÓN ==========

        private void txtNombreLab_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtNombreLab.Text) && txtNombreLab.Enabled) {
                //errorProvider1.SetError(txtNombreLab, "El nombre es requerido");
                e.Cancel = true;
            }
            else {
                //errorProvider1.SetError(txtNombreLab, "");
            }
        }

        private void txtNombreCat_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtNombreCat.Text) && txtNombreCat.Enabled) {
                //errorProvider1.SetError(txtNombreCat, "El nombre es requerido");
                e.Cancel = true;
            }
            else {
                //errorProvider1.SetError(txtNombreCat, "");
            }
        }

        // ========== MÉTODOS PARA PERSISTENCIA (BASE DE DATOS) ==========

        private void GuardarCambiosEnBaseDeDatos() {
            try {
                // Aquí iría la lógica para guardar en base de datos
                // Por ahora solo actualizamos las listas en memoria

                MessageBox.Show("Cambios guardados exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblEstado.Text = "Cambios guardados";
            }
            catch (Exception ex) {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEstado.Text = "Error al guardar cambios";
            }
        }
    }
}
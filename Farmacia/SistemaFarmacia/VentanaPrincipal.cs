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
    public partial class VentanaPrincipal : Form {
        private List<clsProducto> listaProductos = new List<clsProducto>();
        private List<clsLaboratorio> listaLaboratorios = new List<clsLaboratorio>();
        private List<clsCategoria> listaCategorias = new List<clsCategoria>();
        private List<clsUbicacion> listaUbicaciones = new List<clsUbicacion>();

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

        private void VentanaPrincipal_Load(object sender, EventArgs e) {
            CargarDatosIniciales();
            ActualizarContadores();
        }

        private void ConfigurarDataGridViews() {
            // Configurar DataGridView de Productos
            dgvProductos.AutoGenerateColumns = false;
            string[] columnas = {
                "id", "nombre", "descripcion", "principio_activo", "laboratorio",
                "categoria", "concentracion", "unidad_medida", "presentacion",
                "stock_actual", "stock_minimo", "stock_maximo", "ubicacion",
                "precio_unitario", "costo_unitario", "estado"
            };

            string[] encabezados = {
                "ID", "Nombre", "Descripción", "Principio Activo", "Laboratorio",
                "Categoría", "Concentración", "Unidad", "Presentación",
                "Stock Actual", "Stock Min", "Stock Max", "Ubicación",
                "Precio", "Costo", "Estado"
            };

            for (int i = 0; i < columnas.Length; i++) {
                dgvProductos.Columns.Add(columnas[i], encabezados[i]);
            }
            dgvProductos.Columns["precio_unitario"].DefaultCellStyle.Format = "C2";
            dgvProductos.Columns["costo_unitario"].DefaultCellStyle.Format = "C2";

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
            listaProductos.Clear();
            listaLaboratorios.Clear();
            listaCategorias.Clear();
            listaUbicaciones.Clear();

            blProducto bpro = new blProducto();
            try {
                lblEstado.Text = "Cargando datos...";

                // Cargar productos
                for (int i = 1; i < bpro.contar_producto() + 1; i++) {
                    listaProductos.Add(bpro.leer_producto(i));
                }

                // Cargar laboratorios
                blLaboratorio blab = new blLaboratorio();
                for (int i = 1; i < blab.contar_laboratorio() + 1; i++) {
                    listaLaboratorios.Add(blab.leer_laboratorio(i));
                }

                // Cargar categorías
                blCategoria bcat = new blCategoria();
                for (int i = 1; i < bcat.contar_categoria() + 1; i++) {
                    listaCategorias.Add(bcat.leer_categoria(i));
                }

                // Cargar ubicaciones
                blUbicacion bubi = new blUbicacion();
                for (int i = 1; i < bubi.contar_ubicacion() + 1; i++) {
                    listaUbicaciones.Add(bubi.leer_ubicacion(i));
                }

                ActualizarDataGridViews();
                lblEstado.Text = "Datos cargados correctamente";
            }
            catch (Exception ex) {
                MessageBox.Show($"Error, cargar datos: {ex.Message}"
                    , "Error de Carga"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                lblEstado.Text = "Error, cargar datos";
            }
        }
        private string BuscarNombre(List<clsLaboratorio> a, int b) {
            for(int i = 0; i < a.Count; i++) {
                if (a[i].id == b) {
                    return a[i].nombre;
                }
            }
            return "error";
        }
        private string BuscarNombre(List<clsCategoria> a, int b) {
            for (int i = 0; i < a.Count; i++) {
                if (a[i].id == b) {
                    return a[i].nombre;
                }
            }
            return "error";
        }
        private string BuscarNombre(List<clsUbicacion> a, int b) {
            for (int i = 0; i < a.Count; i++) {
                if (a[i].id == b) {
                    return $"{a[i].zona} - {a[i].estante} - {a[i].nivel}";
                }
            }
            return "error";
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
                    BuscarNombre(listaLaboratorios, producto.laboratorio), //falta jalar datos desde laboratorio
                    BuscarNombre(listaCategorias, producto.categoria), //falta jalar datos desde categoria
                    producto.concentracion,
                    producto.unidad_medida,
                    producto.presentacion,
                    producto.stock_actual,
                    producto.stock_minimo,
                    producto.stock_maximo,
                    BuscarNombre(listaUbicaciones, producto.ubicacion), //falta jalar datos desde ubicacion
                    producto.precio_unitario,
                    producto.costo_unitario,
                    producto.estado
                );
            }

            // Actualizar DataGridView de Laboratorios
            dgvLaboratorios.Rows.Clear();
            foreach (var lab in listaLaboratorios) {
                dgvLaboratorios.Rows.Add(lab.id, lab.nombre, lab.direccion, lab.telefono);
            }

            // Actualizar DataGridView de Categorías
            dgvCategorias.Rows.Clear();
            foreach (var cat in listaCategorias) {
                dgvCategorias.Rows.Add(cat.id, cat.nombre, cat.descripcion);
            }

            ActualizarContadores();
        }

        private void ActualizarContadores() {
            lblTotal.Text = $"Total: {listaProductos.Count} productos";
        }
        private void btnNuevoProducto_Click(object sender, EventArgs e) {
            FormularioAgregar ven2 = new FormularioAgregar();
            ven2.FormClosed += (s, args) => {
                CargarDatosIniciales();
                lblEstado.Text = "Producto Añadido Correctamente";
            };
            ven2.Show();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e) {
            FormularioEditar ven3 = new FormularioEditar();
            ven3.FormClosed += (s, args) => {
                CargarDatosIniciales();
                lblEstado.Text = "Producto Editado Correctamente";
            };
            ven3.Show();
        }
        //--------------------------------------------------------
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
                p.id.ToString().ToLower().Contains(textoBusqueda) ||
                p.nombre.ToLower().Contains(textoBusqueda) ||
                p.principio_activo.ToLower().Contains(textoBusqueda) ||
                BuscarNombre(listaLaboratorios, p.laboratorio).Contains(textoBusqueda) ||
                BuscarNombre(listaCategorias, p.categoria).Contains(textoBusqueda) ||
                BuscarNombre(listaUbicaciones, p.ubicacion).Contains(textoBusqueda) ||
                p.presentacion.ToLower().Contains(textoBusqueda) ||
                p.unidad_medida.ToLower().Contains(textoBusqueda) ||
                p.estado.ToLower().Contains(textoBusqueda)
            ).ToList();

            dgvProductos.Rows.Clear();
            foreach (var producto in resultados) {
                dgvProductos.Rows.Add(
                    producto.id,
                    producto.nombre,
                    producto.descripcion,
                    producto.principio_activo,
                    BuscarNombre(listaLaboratorios, producto.laboratorio), //falta jalar datos desde laboratorio
                    BuscarNombre(listaCategorias, producto.categoria), //falta jalar datos desde categoria
                    producto.concentracion,
                    producto.unidad_medida,
                    producto.presentacion,
                    producto.stock_actual,
                    producto.stock_minimo,
                    producto.stock_maximo,
                    BuscarNombre(listaUbicaciones, producto.ubicacion), //falta jalar datos desde ubicacion
                    producto.precio_unitario,
                    producto.costo_unitario,
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
        // ========== EVENTOS DEL MENÚ ==========

        private void tabControlPrincipal_SelectedIndexChanged(object sender, EventArgs e) {
            // Cuando cambia de pestaña, actualizar el estado
            switch (tabControlPrincipal.SelectedIndex) {
                case 0:
                    lblTotal.Text = $"Total: {listaProductos.Count} productos";
                    break;
                case 1:
                    lblTotal.Text = $"Total: {listaLaboratorios.Count} laboratorios";
                    break;
                case 2:
                    lblTotal.Text = $"Total: {listaCategorias.Count} categorías";
                    break;
            }
        }
    }
}
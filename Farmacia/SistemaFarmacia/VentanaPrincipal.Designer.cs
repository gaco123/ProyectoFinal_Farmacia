using System.Windows.Forms;

namespace SistemaFarmacia {
    partial class VentanaPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.splitContainerProductos = new System.Windows.Forms.SplitContainer();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBoxAcciones = new System.Windows.Forms.GroupBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tabLaboratorios = new System.Windows.Forms.TabPage();
            this.splitContainerLaboratorios = new System.Windows.Forms.SplitContainer();
            this.groupBoxListaLaboratorios = new System.Windows.Forms.GroupBox();
            this.dgvLaboratorios = new System.Windows.Forms.DataGridView();
            this.groupBoxAccionesLaboratorio = new System.Windows.Forms.GroupBox();
            this.btnEliminarLaboratorio = new System.Windows.Forms.Button();
            this.btnEditarLaboratorio = new System.Windows.Forms.Button();
            this.btnNuevoLaboratorio = new System.Windows.Forms.Button();
            this.groupBoxDetallesLaboratorio = new System.Windows.Forms.GroupBox();
            this.txtTelefonoLab = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDireccionLab = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNombreLab = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabCategorias = new System.Windows.Forms.TabPage();
            this.splitContainerCategorias = new System.Windows.Forms.SplitContainer();
            this.groupBoxListaCategorias = new System.Windows.Forms.GroupBox();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.groupBoxAccionesCategoria = new System.Windows.Forms.GroupBox();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.btnNuevaCategoria = new System.Windows.Forms.Button();
            this.groupBoxDetallesCategoria = new System.Windows.Forms.GroupBox();
            this.txtDescripcionCat = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNombreCat = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tabControlPrincipal.SuspendLayout();
            this.tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProductos)).BeginInit();
            this.splitContainerProductos.Panel1.SuspendLayout();
            this.splitContainerProductos.Panel2.SuspendLayout();
            this.splitContainerProductos.SuspendLayout();
            this.groupBoxBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBoxAcciones.SuspendLayout();
            this.tabLaboratorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLaboratorios)).BeginInit();
            this.splitContainerLaboratorios.Panel1.SuspendLayout();
            this.splitContainerLaboratorios.Panel2.SuspendLayout();
            this.splitContainerLaboratorios.SuspendLayout();
            this.groupBoxListaLaboratorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).BeginInit();
            this.groupBoxAccionesLaboratorio.SuspendLayout();
            this.groupBoxDetallesLaboratorio.SuspendLayout();
            this.tabCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCategorias)).BeginInit();
            this.splitContainerCategorias.Panel1.SuspendLayout();
            this.splitContainerCategorias.Panel2.SuspendLayout();
            this.splitContainerCategorias.SuspendLayout();
            this.groupBoxListaCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.groupBoxAccionesCategoria.SuspendLayout();
            this.groupBoxDetallesCategoria.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabProductos);
            this.tabControlPrincipal.Controls.Add(this.tabLaboratorios);
            this.tabControlPrincipal.Controls.Add(this.tabCategorias);
            this.tabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(1177, 600);
            this.tabControlPrincipal.TabIndex = 0;
            this.tabControlPrincipal.SelectedIndexChanged += new System.EventHandler(this.tabControlPrincipal_SelectedIndexChanged);
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.splitContainerProductos);
            this.tabProductos.Location = new System.Drawing.Point(4, 22);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(1169, 574);
            this.tabProductos.TabIndex = 0;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // splitContainerProductos
            // 
            this.splitContainerProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerProductos.Location = new System.Drawing.Point(3, 3);
            this.splitContainerProductos.Name = "splitContainerProductos";
            this.splitContainerProductos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerProductos.Panel1
            // 
            this.splitContainerProductos.Panel1.Controls.Add(this.groupBoxBusqueda);
            this.splitContainerProductos.Panel1.Controls.Add(this.dgvProductos);
            // 
            // splitContainerProductos.Panel2
            // 
            this.splitContainerProductos.Panel2.Controls.Add(this.groupBoxAcciones);
            this.splitContainerProductos.Size = new System.Drawing.Size(1163, 568);
            this.splitContainerProductos.SplitterDistance = 468;
            this.splitContainerProductos.TabIndex = 0;
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.btnLimpiarBusqueda);
            this.groupBoxBusqueda.Controls.Add(this.btnBuscar);
            this.groupBoxBusqueda.Controls.Add(this.txtBuscar);
            this.groupBoxBusqueda.Controls.Add(this.label1);
            this.groupBoxBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxBusqueda.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(1163, 70);
            this.groupBoxBusqueda.TabIndex = 1;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Búsqueda de Productos";
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(365, 28);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarBusqueda.TabIndex = 3;
            this.btnLimpiarBusqueda.Text = "Limpiar";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = true;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(284, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(86, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(192, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProductos.Location = new System.Drawing.Point(0, 69);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1163, 399);
            this.dgvProductos.TabIndex = 0;
            // 
            // groupBoxAcciones
            // 
            this.groupBoxAcciones.Controls.Add(this.btnEliminarProducto);
            this.groupBoxAcciones.Controls.Add(this.btnEditarProducto);
            this.groupBoxAcciones.Controls.Add(this.btnNuevoProducto);
            this.groupBoxAcciones.Controls.Add(this.btnActualizar);
            this.groupBoxAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAcciones.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAcciones.Name = "groupBoxAcciones";
            this.groupBoxAcciones.Size = new System.Drawing.Size(1163, 96);
            this.groupBoxAcciones.TabIndex = 0;
            this.groupBoxAcciones.TabStop = false;
            this.groupBoxAcciones.Text = "Acciones";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEliminarProducto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Location = new System.Drawing.Point(260, 19);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(120, 60);
            this.btnEliminarProducto.TabIndex = 3;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarProducto.FlatAppearance.BorderSize = 0;
            this.btnEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEditarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProducto.Location = new System.Drawing.Point(134, 19);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(120, 60);
            this.btnEditarProducto.TabIndex = 2;
            this.btnEditarProducto.Text = "Editar";
            this.btnEditarProducto.UseVisualStyleBackColor = false;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnNuevoProducto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoProducto.Location = new System.Drawing.Point(8, 19);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(120, 60);
            this.btnNuevoProducto.TabIndex = 1;
            this.btnNuevoProducto.Text = "Nuevo";
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(386, 19);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 60);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tabLaboratorios
            // 
            this.tabLaboratorios.Controls.Add(this.splitContainerLaboratorios);
            this.tabLaboratorios.Location = new System.Drawing.Point(4, 22);
            this.tabLaboratorios.Name = "tabLaboratorios";
            this.tabLaboratorios.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaboratorios.Size = new System.Drawing.Size(1169, 574);
            this.tabLaboratorios.TabIndex = 1;
            this.tabLaboratorios.Text = "Laboratorios";
            this.tabLaboratorios.UseVisualStyleBackColor = true;
            // 
            // splitContainerLaboratorios
            // 
            this.splitContainerLaboratorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLaboratorios.Location = new System.Drawing.Point(3, 3);
            this.splitContainerLaboratorios.Name = "splitContainerLaboratorios";
            // 
            // splitContainerLaboratorios.Panel1
            // 
            this.splitContainerLaboratorios.Panel1.Controls.Add(this.groupBoxListaLaboratorios);
            this.splitContainerLaboratorios.Panel1.Controls.Add(this.groupBoxAccionesLaboratorio);
            // 
            // splitContainerLaboratorios.Panel2
            // 
            this.splitContainerLaboratorios.Panel2.Controls.Add(this.groupBoxDetallesLaboratorio);
            this.splitContainerLaboratorios.Size = new System.Drawing.Size(1163, 568);
            this.splitContainerLaboratorios.SplitterDistance = 774;
            this.splitContainerLaboratorios.TabIndex = 0;
            // 
            // groupBoxListaLaboratorios
            // 
            this.groupBoxListaLaboratorios.Controls.Add(this.dgvLaboratorios);
            this.groupBoxListaLaboratorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxListaLaboratorios.Location = new System.Drawing.Point(0, 0);
            this.groupBoxListaLaboratorios.Name = "groupBoxListaLaboratorios";
            this.groupBoxListaLaboratorios.Size = new System.Drawing.Size(774, 524);
            this.groupBoxListaLaboratorios.TabIndex = 0;
            this.groupBoxListaLaboratorios.TabStop = false;
            this.groupBoxListaLaboratorios.Text = "Lista de Laboratorios";
            // 
            // dgvLaboratorios
            // 
            this.dgvLaboratorios.AllowUserToAddRows = false;
            this.dgvLaboratorios.AllowUserToDeleteRows = false;
            this.dgvLaboratorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaboratorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaboratorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLaboratorios.Location = new System.Drawing.Point(3, 16);
            this.dgvLaboratorios.Name = "dgvLaboratorios";
            this.dgvLaboratorios.ReadOnly = true;
            this.dgvLaboratorios.RowHeadersWidth = 51;
            this.dgvLaboratorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaboratorios.Size = new System.Drawing.Size(768, 505);
            this.dgvLaboratorios.TabIndex = 0;
            // 
            // groupBoxAccionesLaboratorio
            // 
            this.groupBoxAccionesLaboratorio.Controls.Add(this.btnEliminarLaboratorio);
            this.groupBoxAccionesLaboratorio.Controls.Add(this.btnEditarLaboratorio);
            this.groupBoxAccionesLaboratorio.Controls.Add(this.btnNuevoLaboratorio);
            this.groupBoxAccionesLaboratorio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxAccionesLaboratorio.Location = new System.Drawing.Point(0, 524);
            this.groupBoxAccionesLaboratorio.Name = "groupBoxAccionesLaboratorio";
            this.groupBoxAccionesLaboratorio.Size = new System.Drawing.Size(774, 44);
            this.groupBoxAccionesLaboratorio.TabIndex = 1;
            this.groupBoxAccionesLaboratorio.TabStop = false;
            // 
            // btnEliminarLaboratorio
            // 
            this.btnEliminarLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEliminarLaboratorio.FlatAppearance.BorderSize = 0;
            this.btnEliminarLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLaboratorio.ForeColor = System.Drawing.Color.White;
            this.btnEliminarLaboratorio.Location = new System.Drawing.Point(172, 10);
            this.btnEliminarLaboratorio.Name = "btnEliminarLaboratorio";
            this.btnEliminarLaboratorio.Size = new System.Drawing.Size(75, 28);
            this.btnEliminarLaboratorio.TabIndex = 2;
            this.btnEliminarLaboratorio.Text = "Eliminar";
            this.btnEliminarLaboratorio.UseVisualStyleBackColor = false;
            // 
            // btnEditarLaboratorio
            // 
            this.btnEditarLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarLaboratorio.FlatAppearance.BorderSize = 0;
            this.btnEditarLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLaboratorio.ForeColor = System.Drawing.Color.White;
            this.btnEditarLaboratorio.Location = new System.Drawing.Point(91, 10);
            this.btnEditarLaboratorio.Name = "btnEditarLaboratorio";
            this.btnEditarLaboratorio.Size = new System.Drawing.Size(75, 28);
            this.btnEditarLaboratorio.TabIndex = 1;
            this.btnEditarLaboratorio.Text = "Editar";
            this.btnEditarLaboratorio.UseVisualStyleBackColor = false;
            // 
            // btnNuevoLaboratorio
            // 
            this.btnNuevoLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnNuevoLaboratorio.FlatAppearance.BorderSize = 0;
            this.btnNuevoLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoLaboratorio.ForeColor = System.Drawing.Color.White;
            this.btnNuevoLaboratorio.Location = new System.Drawing.Point(10, 10);
            this.btnNuevoLaboratorio.Name = "btnNuevoLaboratorio";
            this.btnNuevoLaboratorio.Size = new System.Drawing.Size(75, 28);
            this.btnNuevoLaboratorio.TabIndex = 0;
            this.btnNuevoLaboratorio.Text = "Nuevo";
            this.btnNuevoLaboratorio.UseVisualStyleBackColor = false;
            // 
            // groupBoxDetallesLaboratorio
            // 
            this.groupBoxDetallesLaboratorio.Controls.Add(this.txtTelefonoLab);
            this.groupBoxDetallesLaboratorio.Controls.Add(this.label18);
            this.groupBoxDetallesLaboratorio.Controls.Add(this.txtDireccionLab);
            this.groupBoxDetallesLaboratorio.Controls.Add(this.label17);
            this.groupBoxDetallesLaboratorio.Controls.Add(this.txtNombreLab);
            this.groupBoxDetallesLaboratorio.Controls.Add(this.label16);
            this.groupBoxDetallesLaboratorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetallesLaboratorio.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDetallesLaboratorio.Name = "groupBoxDetallesLaboratorio";
            this.groupBoxDetallesLaboratorio.Size = new System.Drawing.Size(385, 568);
            this.groupBoxDetallesLaboratorio.TabIndex = 0;
            this.groupBoxDetallesLaboratorio.TabStop = false;
            this.groupBoxDetallesLaboratorio.Text = "Detalles del Laboratorio";
            // 
            // txtTelefonoLab
            // 
            this.txtTelefonoLab.Location = new System.Drawing.Point(20, 150);
            this.txtTelefonoLab.Name = "txtTelefonoLab";
            this.txtTelefonoLab.Size = new System.Drawing.Size(280, 20);
            this.txtTelefonoLab.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Teléfono:";
            // 
            // txtDireccionLab
            // 
            this.txtDireccionLab.Location = new System.Drawing.Point(20, 100);
            this.txtDireccionLab.Name = "txtDireccionLab";
            this.txtDireccionLab.Size = new System.Drawing.Size(280, 20);
            this.txtDireccionLab.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Dirección:";
            // 
            // txtNombreLab
            // 
            this.txtNombreLab.Location = new System.Drawing.Point(20, 50);
            this.txtNombreLab.Name = "txtNombreLab";
            this.txtNombreLab.Size = new System.Drawing.Size(280, 20);
            this.txtNombreLab.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Nombre:";
            // 
            // tabCategorias
            // 
            this.tabCategorias.Controls.Add(this.splitContainerCategorias);
            this.tabCategorias.Location = new System.Drawing.Point(4, 22);
            this.tabCategorias.Name = "tabCategorias";
            this.tabCategorias.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategorias.Size = new System.Drawing.Size(1169, 574);
            this.tabCategorias.TabIndex = 2;
            this.tabCategorias.Text = "Categorías";
            this.tabCategorias.UseVisualStyleBackColor = true;
            // 
            // splitContainerCategorias
            // 
            this.splitContainerCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCategorias.Location = new System.Drawing.Point(3, 3);
            this.splitContainerCategorias.Name = "splitContainerCategorias";
            // 
            // splitContainerCategorias.Panel1
            // 
            this.splitContainerCategorias.Panel1.Controls.Add(this.groupBoxListaCategorias);
            this.splitContainerCategorias.Panel1.Controls.Add(this.groupBoxAccionesCategoria);
            // 
            // splitContainerCategorias.Panel2
            // 
            this.splitContainerCategorias.Panel2.Controls.Add(this.groupBoxDetallesCategoria);
            this.splitContainerCategorias.Size = new System.Drawing.Size(1163, 568);
            this.splitContainerCategorias.SplitterDistance = 774;
            this.splitContainerCategorias.TabIndex = 0;
            // 
            // groupBoxListaCategorias
            // 
            this.groupBoxListaCategorias.Controls.Add(this.dgvCategorias);
            this.groupBoxListaCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxListaCategorias.Location = new System.Drawing.Point(0, 0);
            this.groupBoxListaCategorias.Name = "groupBoxListaCategorias";
            this.groupBoxListaCategorias.Size = new System.Drawing.Size(774, 524);
            this.groupBoxListaCategorias.TabIndex = 0;
            this.groupBoxListaCategorias.TabStop = false;
            this.groupBoxListaCategorias.Text = "Lista de Categorías";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategorias.Location = new System.Drawing.Point(3, 16);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(768, 505);
            this.dgvCategorias.TabIndex = 0;
            // 
            // groupBoxAccionesCategoria
            // 
            this.groupBoxAccionesCategoria.Controls.Add(this.btnEliminarCategoria);
            this.groupBoxAccionesCategoria.Controls.Add(this.btnEditarCategoria);
            this.groupBoxAccionesCategoria.Controls.Add(this.btnNuevaCategoria);
            this.groupBoxAccionesCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxAccionesCategoria.Location = new System.Drawing.Point(0, 524);
            this.groupBoxAccionesCategoria.Name = "groupBoxAccionesCategoria";
            this.groupBoxAccionesCategoria.Size = new System.Drawing.Size(774, 44);
            this.groupBoxAccionesCategoria.TabIndex = 1;
            this.groupBoxAccionesCategoria.TabStop = false;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEliminarCategoria.FlatAppearance.BorderSize = 0;
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(172, 10);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 28);
            this.btnEliminarCategoria.TabIndex = 2;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarCategoria.FlatAppearance.BorderSize = 0;
            this.btnEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnEditarCategoria.Location = new System.Drawing.Point(91, 10);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(75, 28);
            this.btnEditarCategoria.TabIndex = 1;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnNuevaCategoria
            // 
            this.btnNuevaCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnNuevaCategoria.FlatAppearance.BorderSize = 0;
            this.btnNuevaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCategoria.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCategoria.Location = new System.Drawing.Point(10, 10);
            this.btnNuevaCategoria.Name = "btnNuevaCategoria";
            this.btnNuevaCategoria.Size = new System.Drawing.Size(75, 28);
            this.btnNuevaCategoria.TabIndex = 0;
            this.btnNuevaCategoria.Text = "Nueva";
            this.btnNuevaCategoria.UseVisualStyleBackColor = false;
            // 
            // groupBoxDetallesCategoria
            // 
            this.groupBoxDetallesCategoria.Controls.Add(this.txtDescripcionCat);
            this.groupBoxDetallesCategoria.Controls.Add(this.label20);
            this.groupBoxDetallesCategoria.Controls.Add(this.txtNombreCat);
            this.groupBoxDetallesCategoria.Controls.Add(this.label19);
            this.groupBoxDetallesCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDetallesCategoria.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDetallesCategoria.Name = "groupBoxDetallesCategoria";
            this.groupBoxDetallesCategoria.Size = new System.Drawing.Size(385, 568);
            this.groupBoxDetallesCategoria.TabIndex = 0;
            this.groupBoxDetallesCategoria.TabStop = false;
            this.groupBoxDetallesCategoria.Text = "Detalles de la Categoría";
            // 
            // txtDescripcionCat
            // 
            this.txtDescripcionCat.Location = new System.Drawing.Point(20, 100);
            this.txtDescripcionCat.Multiline = true;
            this.txtDescripcionCat.Name = "txtDescripcionCat";
            this.txtDescripcionCat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcionCat.Size = new System.Drawing.Size(280, 80);
            this.txtDescripcionCat.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Descripción:";
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.Location = new System.Drawing.Point(20, 50);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.Size = new System.Drawing.Size(280, 20);
            this.txtNombreCat.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Nombre:";
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelInferior.Controls.Add(this.lblEstado);
            this.panelInferior.Controls.Add(this.lblTotal);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 600);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1177, 30);
            this.panelInferior.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 8);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(98, 13);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Listo - Esperando...";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1020, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total: 0 items";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 630);
            this.Controls.Add(this.tabControlPrincipal);
            this.Controls.Add(this.panelInferior);
            this.MinimumSize = new System.Drawing.Size(1016, 668);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabProductos.ResumeLayout(false);
            this.splitContainerProductos.Panel1.ResumeLayout(false);
            this.splitContainerProductos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProductos)).EndInit();
            this.splitContainerProductos.ResumeLayout(false);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBoxAcciones.ResumeLayout(false);
            this.tabLaboratorios.ResumeLayout(false);
            this.splitContainerLaboratorios.Panel1.ResumeLayout(false);
            this.splitContainerLaboratorios.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLaboratorios)).EndInit();
            this.splitContainerLaboratorios.ResumeLayout(false);
            this.groupBoxListaLaboratorios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).EndInit();
            this.groupBoxAccionesLaboratorio.ResumeLayout(false);
            this.groupBoxDetallesLaboratorio.ResumeLayout(false);
            this.groupBoxDetallesLaboratorio.PerformLayout();
            this.tabCategorias.ResumeLayout(false);
            this.splitContainerCategorias.Panel1.ResumeLayout(false);
            this.splitContainerCategorias.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCategorias)).EndInit();
            this.splitContainerCategorias.ResumeLayout(false);
            this.groupBoxListaCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.groupBoxAccionesCategoria.ResumeLayout(false);
            this.groupBoxDetallesCategoria.ResumeLayout(false);
            this.groupBoxDetallesCategoria.PerformLayout();
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.TabPage tabLaboratorios;
        private System.Windows.Forms.TabPage tabCategorias;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.SplitContainer splitContainerProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAcciones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.SplitContainer splitContainerLaboratorios;
        private System.Windows.Forms.GroupBox groupBoxListaLaboratorios;
        private System.Windows.Forms.DataGridView dgvLaboratorios;
        private System.Windows.Forms.GroupBox groupBoxAccionesLaboratorio;
        private System.Windows.Forms.Button btnEliminarLaboratorio;
        private System.Windows.Forms.Button btnEditarLaboratorio;
        private System.Windows.Forms.Button btnNuevoLaboratorio;
        private System.Windows.Forms.GroupBox groupBoxDetallesLaboratorio;
        private System.Windows.Forms.TextBox txtTelefonoLab;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDireccionLab;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNombreLab;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.SplitContainer splitContainerCategorias;
        private System.Windows.Forms.GroupBox groupBoxListaCategorias;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.GroupBox groupBoxAccionesCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Button btnNuevaCategoria;
        private System.Windows.Forms.GroupBox groupBoxDetallesCategoria;
        private System.Windows.Forms.TextBox txtDescripcionCat;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNombreCat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEstado;
    }
}
namespace pryDisenoLavadora
{
    partial class frmLavados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLavados));
            grpDatosLavados = new GroupBox();
            btnRegistrar = new Button();
            grpEntrega = new GroupBox();
            btnExpres = new RadioButton();
            btnNormal = new RadioButton();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            chkClienteFrecuente = new CheckBox();
            txtCantidad = new TextBox();
            cmbServicio = new ComboBox();
            lblFrecuente = new Label();
            lblCantidad = new Label();
            lblServicio = new Label();
            lblPatente = new Label();
            lblCliente = new Label();
            txtPatente = new TextBox();
            txtCliente = new TextBox();
            grpImportes = new GroupBox();
            lblTotal = new Label();
            lblDescuento = new Label();
            lblRecargo = new Label();
            lblSubtotal = new Label();
            lblTituloTotal = new Label();
            lblTituloDescuento = new Label();
            lblTituloRecargo = new Label();
            lblTituloSubtotal = new Label();
            grpConsultaPatente = new GroupBox();
            btnConsultaPatente = new Button();
            txtPatenteConsulta = new TextBox();
            lblConsultaPatente = new Label();
            grpListado = new GroupBox();
            dgvLavados = new DataGridView();
            grpRecaudacion = new GroupBox();
            lblRecaudacionExterior = new Label();
            lblRecaudacionCompleto = new Label();
            lblRecaudacionEncerado = new Label();
            lblLavadoTotal = new Label();
            lblCompletoTotal = new Label();
            lblEnceradoTotal = new Label();
            lblRecaudacionTotal = new Label();
            lblRecaudacionExpres = new Label();
            lblNormalTotal = new Label();
            lblExpresTotal = new Label();
            clmCliente = new DataGridViewTextBoxColumn();
            colPatente = new DataGridViewTextBoxColumn();
            colServicio = new DataGridViewTextBoxColumn();
            colVehiculos = new DataGridViewTextBoxColumn();
            colEntrega = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            lstConsulta = new ListBox();
            lblLavados = new Label();
            grpDatosLavados.SuspendLayout();
            grpEntrega.SuspendLayout();
            grpImportes.SuspendLayout();
            grpConsultaPatente.SuspendLayout();
            grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLavados).BeginInit();
            grpRecaudacion.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosLavados
            // 
            grpDatosLavados.Controls.Add(btnRegistrar);
            grpDatosLavados.Controls.Add(grpEntrega);
            grpDatosLavados.Controls.Add(btnLimpiar);
            grpDatosLavados.Controls.Add(btnCalcular);
            grpDatosLavados.Controls.Add(chkClienteFrecuente);
            grpDatosLavados.Controls.Add(txtCantidad);
            grpDatosLavados.Controls.Add(cmbServicio);
            grpDatosLavados.Controls.Add(lblFrecuente);
            grpDatosLavados.Controls.Add(lblCantidad);
            grpDatosLavados.Controls.Add(lblServicio);
            grpDatosLavados.Controls.Add(lblPatente);
            grpDatosLavados.Controls.Add(lblCliente);
            grpDatosLavados.Controls.Add(txtPatente);
            grpDatosLavados.Controls.Add(txtCliente);
            grpDatosLavados.Location = new Point(25, 28);
            grpDatosLavados.Name = "grpDatosLavados";
            grpDatosLavados.Size = new Size(354, 319);
            grpDatosLavados.TabIndex = 0;
            grpDatosLavados.TabStop = false;
            grpDatosLavados.Text = "Datos del lavado";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(120, 263);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(83, 34);
            btnRegistrar.TabIndex = 13;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // grpEntrega
            // 
            grpEntrega.Controls.Add(btnExpres);
            grpEntrega.Controls.Add(btnNormal);
            grpEntrega.Location = new Point(20, 159);
            grpEntrega.Name = "grpEntrega";
            grpEntrega.Size = new Size(273, 63);
            grpEntrega.TabIndex = 10;
            grpEntrega.TabStop = false;
            grpEntrega.Text = "Entrega";
            // 
            // btnExpres
            // 
            btnExpres.AutoSize = true;
            btnExpres.Location = new Point(140, 28);
            btnExpres.Name = "btnExpres";
            btnExpres.Size = new Size(105, 19);
            btnExpres.TabIndex = 1;
            btnExpres.Text = "Expres (+ 25 %)";
            btnExpres.UseVisualStyleBackColor = true;
            // 
            // btnNormal
            // 
            btnNormal.AutoSize = true;
            btnNormal.Checked = true;
            btnNormal.Location = new Point(18, 28);
            btnNormal.Name = "btnNormal";
            btnNormal.Size = new Size(65, 19);
            btnNormal.TabIndex = 0;
            btnNormal.TabStop = true;
            btnNormal.Text = "Normal";
            btnNormal.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(223, 263);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 34);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(20, 263);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(83, 34);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // chkClienteFrecuente
            // 
            chkClienteFrecuente.AutoSize = true;
            chkClienteFrecuente.Location = new Point(92, 228);
            chkClienteFrecuente.Name = "chkClienteFrecuente";
            chkClienteFrecuente.Size = new Size(173, 19);
            chkClienteFrecuente.TabIndex = 12;
            chkClienteFrecuente.Text = "Cliente Frecuente (5% Extra)";
            chkClienteFrecuente.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(120, 127);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(32, 23);
            txtCantidad.TabIndex = 9;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // cmbServicio
            // 
            cmbServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Items.AddRange(new object[] { "Lavado exterior", "Lavado completo", "Lavado con encerado" });
            cmbServicio.Location = new Point(120, 93);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(145, 23);
            cmbServicio.TabIndex = 8;
            // 
            // lblFrecuente
            // 
            lblFrecuente.AutoSize = true;
            lblFrecuente.Location = new Point(27, 228);
            lblFrecuente.Name = "lblFrecuente";
            lblFrecuente.Size = new Size(59, 15);
            lblFrecuente.TabIndex = 11;
            lblFrecuente.Text = "Frecuente";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(20, 130);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(90, 15);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad (1 a 5)";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(20, 96);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(48, 15);
            lblServicio.TabIndex = 4;
            lblServicio.Text = "Servicio";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(20, 67);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(47, 15);
            lblPatente.TabIndex = 3;
            lblPatente.Text = "Patente";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(20, 35);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente";
            // 
            // txtPatente
            // 
            txtPatente.CharacterCasing = CharacterCasing.Upper;
            txtPatente.Location = new Point(120, 64);
            txtPatente.MaxLength = 7;
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(74, 23);
            txtPatente.TabIndex = 7;
            txtPatente.KeyPress += txtPatente_KeyPress;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(120, 32);
            txtCliente.MaxLength = 40;
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(145, 23);
            txtCliente.TabIndex = 6;
            // 
            // grpImportes
            // 
            grpImportes.Controls.Add(lblTotal);
            grpImportes.Controls.Add(lblDescuento);
            grpImportes.Controls.Add(lblRecargo);
            grpImportes.Controls.Add(lblSubtotal);
            grpImportes.Controls.Add(lblTituloTotal);
            grpImportes.Controls.Add(lblTituloDescuento);
            grpImportes.Controls.Add(lblTituloRecargo);
            grpImportes.Controls.Add(lblTituloSubtotal);
            grpImportes.Location = new Point(25, 353);
            grpImportes.Name = "grpImportes";
            grpImportes.Size = new Size(354, 154);
            grpImportes.TabIndex = 1;
            grpImportes.TabStop = false;
            grpImportes.Text = "Importes";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(160, 114);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "$0,00";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(160, 84);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(34, 15);
            lblDescuento.TabIndex = 6;
            lblDescuento.Text = "$0,00";
            // 
            // lblRecargo
            // 
            lblRecargo.AutoSize = true;
            lblRecargo.Location = new Point(160, 56);
            lblRecargo.Name = "lblRecargo";
            lblRecargo.Size = new Size(34, 15);
            lblRecargo.TabIndex = 5;
            lblRecargo.Text = "$0,00";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(160, 26);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(34, 15);
            lblSubtotal.TabIndex = 4;
            lblSubtotal.Text = "$0,00";
            // 
            // lblTituloTotal
            // 
            lblTituloTotal.AutoSize = true;
            lblTituloTotal.Location = new Point(23, 114);
            lblTituloTotal.Name = "lblTituloTotal";
            lblTituloTotal.Size = new Size(75, 15);
            lblTituloTotal.TabIndex = 3;
            lblTituloTotal.Text = "Total a pagar";
            // 
            // lblTituloDescuento
            // 
            lblTituloDescuento.AutoSize = true;
            lblTituloDescuento.Location = new Point(23, 84);
            lblTituloDescuento.Name = "lblTituloDescuento";
            lblTituloDescuento.Size = new Size(63, 15);
            lblTituloDescuento.TabIndex = 2;
            lblTituloDescuento.Text = "Descuento";
            // 
            // lblTituloRecargo
            // 
            lblTituloRecargo.AutoSize = true;
            lblTituloRecargo.Location = new Point(23, 56);
            lblTituloRecargo.Name = "lblTituloRecargo";
            lblTituloRecargo.Size = new Size(50, 15);
            lblTituloRecargo.TabIndex = 1;
            lblTituloRecargo.Text = "Recargo";
            // 
            // lblTituloSubtotal
            // 
            lblTituloSubtotal.AutoSize = true;
            lblTituloSubtotal.Location = new Point(23, 26);
            lblTituloSubtotal.Name = "lblTituloSubtotal";
            lblTituloSubtotal.Size = new Size(51, 15);
            lblTituloSubtotal.TabIndex = 0;
            lblTituloSubtotal.Text = "Subtotal";
            // 
            // grpConsultaPatente
            // 
            grpConsultaPatente.Controls.Add(lblLavados);
            grpConsultaPatente.Controls.Add(lstConsulta);
            grpConsultaPatente.Controls.Add(btnConsultaPatente);
            grpConsultaPatente.Controls.Add(txtPatenteConsulta);
            grpConsultaPatente.Controls.Add(lblConsultaPatente);
            grpConsultaPatente.Location = new Point(397, 389);
            grpConsultaPatente.Name = "grpConsultaPatente";
            grpConsultaPatente.Size = new Size(339, 118);
            grpConsultaPatente.TabIndex = 2;
            grpConsultaPatente.TabStop = false;
            grpConsultaPatente.Text = "Consulta de lavado por patentes";
            // 
            // btnConsultaPatente
            // 
            btnConsultaPatente.Location = new Point(188, 23);
            btnConsultaPatente.Name = "btnConsultaPatente";
            btnConsultaPatente.Size = new Size(83, 34);
            btnConsultaPatente.TabIndex = 14;
            btnConsultaPatente.Text = "Consultar";
            btnConsultaPatente.UseVisualStyleBackColor = true;
            btnConsultaPatente.Click += btnConsultaPatente_Click;
            // 
            // txtPatenteConsulta
            // 
            txtPatenteConsulta.Location = new Point(71, 30);
            txtPatenteConsulta.Name = "txtPatenteConsulta";
            txtPatenteConsulta.Size = new Size(100, 23);
            txtPatenteConsulta.TabIndex = 1;
            // 
            // lblConsultaPatente
            // 
            lblConsultaPatente.AutoSize = true;
            lblConsultaPatente.Location = new Point(15, 33);
            lblConsultaPatente.Name = "lblConsultaPatente";
            lblConsultaPatente.Size = new Size(50, 15);
            lblConsultaPatente.TabIndex = 0;
            lblConsultaPatente.Text = "Patente:";
            // 
            // grpListado
            // 
            grpListado.Controls.Add(dgvLavados);
            grpListado.Location = new Point(385, 28);
            grpListado.Name = "grpListado";
            grpListado.Size = new Size(472, 189);
            grpListado.TabIndex = 3;
            grpListado.TabStop = false;
            grpListado.Text = "Lavados del día";
            // 
            // dgvLavados
            // 
            dgvLavados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLavados.Columns.AddRange(new DataGridViewColumn[] { clmCliente, colPatente, colServicio, colVehiculos, colEntrega, colTotal });
            dgvLavados.Location = new Point(12, 22);
            dgvLavados.Name = "dgvLavados";
            dgvLavados.Size = new Size(437, 150);
            dgvLavados.TabIndex = 0;
            // 
            // grpRecaudacion
            // 
            grpRecaudacion.Controls.Add(lblExpresTotal);
            grpRecaudacion.Controls.Add(lblNormalTotal);
            grpRecaudacion.Controls.Add(lblRecaudacionExpres);
            grpRecaudacion.Controls.Add(lblRecaudacionTotal);
            grpRecaudacion.Controls.Add(lblEnceradoTotal);
            grpRecaudacion.Controls.Add(lblCompletoTotal);
            grpRecaudacion.Controls.Add(lblLavadoTotal);
            grpRecaudacion.Controls.Add(lblRecaudacionEncerado);
            grpRecaudacion.Controls.Add(lblRecaudacionCompleto);
            grpRecaudacion.Controls.Add(lblRecaudacionExterior);
            grpRecaudacion.Location = new Point(390, 232);
            grpRecaudacion.Name = "grpRecaudacion";
            grpRecaudacion.Size = new Size(355, 141);
            grpRecaudacion.TabIndex = 4;
            grpRecaudacion.TabStop = false;
            grpRecaudacion.Text = "Recaudación";
            // 
            // lblRecaudacionExterior
            // 
            lblRecaudacionExterior.AutoSize = true;
            lblRecaudacionExterior.Location = new Point(25, 33);
            lblRecaudacionExterior.Name = "lblRecaudacionExterior";
            lblRecaudacionExterior.Size = new Size(87, 15);
            lblRecaudacionExterior.TabIndex = 0;
            lblRecaudacionExterior.Text = "Lavado Exterior";
            // 
            // lblRecaudacionCompleto
            // 
            lblRecaudacionCompleto.AutoSize = true;
            lblRecaudacionCompleto.Location = new Point(25, 69);
            lblRecaudacionCompleto.Name = "lblRecaudacionCompleto";
            lblRecaudacionCompleto.Size = new Size(101, 15);
            lblRecaudacionCompleto.TabIndex = 1;
            lblRecaudacionCompleto.Text = "Lavado Completo";
            // 
            // lblRecaudacionEncerado
            // 
            lblRecaudacionEncerado.AutoSize = true;
            lblRecaudacionEncerado.Location = new Point(25, 100);
            lblRecaudacionEncerado.Name = "lblRecaudacionEncerado";
            lblRecaudacionEncerado.Size = new Size(97, 15);
            lblRecaudacionEncerado.TabIndex = 2;
            lblRecaudacionEncerado.Text = "Lavado Encerado";
            // 
            // lblLavadoTotal
            // 
            lblLavadoTotal.AutoSize = true;
            lblLavadoTotal.Location = new Point(139, 33);
            lblLavadoTotal.Name = "lblLavadoTotal";
            lblLavadoTotal.Size = new Size(34, 15);
            lblLavadoTotal.TabIndex = 5;
            lblLavadoTotal.Text = "$0,00";
            // 
            // lblCompletoTotal
            // 
            lblCompletoTotal.AutoSize = true;
            lblCompletoTotal.Location = new Point(139, 69);
            lblCompletoTotal.Name = "lblCompletoTotal";
            lblCompletoTotal.Size = new Size(34, 15);
            lblCompletoTotal.TabIndex = 6;
            lblCompletoTotal.Text = "$0,00";
            // 
            // lblEnceradoTotal
            // 
            lblEnceradoTotal.AutoSize = true;
            lblEnceradoTotal.Location = new Point(139, 100);
            lblEnceradoTotal.Name = "lblEnceradoTotal";
            lblEnceradoTotal.Size = new Size(34, 15);
            lblEnceradoTotal.TabIndex = 7;
            lblEnceradoTotal.Text = "$0,00";
            // 
            // lblRecaudacionTotal
            // 
            lblRecaudacionTotal.AutoSize = true;
            lblRecaudacionTotal.Location = new Point(195, 50);
            lblRecaudacionTotal.Name = "lblRecaudacionTotal";
            lblRecaudacionTotal.Size = new Size(90, 15);
            lblRecaudacionTotal.TabIndex = 8;
            lblRecaudacionTotal.Text = "Entrega Normal";
            // 
            // lblRecaudacionExpres
            // 
            lblRecaudacionExpres.AutoSize = true;
            lblRecaudacionExpres.Location = new Point(195, 78);
            lblRecaudacionExpres.Name = "lblRecaudacionExpres";
            lblRecaudacionExpres.Size = new Size(83, 15);
            lblRecaudacionExpres.TabIndex = 9;
            lblRecaudacionExpres.Text = "Entrega Expres";
            // 
            // lblNormalTotal
            // 
            lblNormalTotal.AutoSize = true;
            lblNormalTotal.Location = new Point(291, 50);
            lblNormalTotal.Name = "lblNormalTotal";
            lblNormalTotal.Size = new Size(34, 15);
            lblNormalTotal.TabIndex = 10;
            lblNormalTotal.Text = "$0,00";
            // 
            // lblExpresTotal
            // 
            lblExpresTotal.AutoSize = true;
            lblExpresTotal.Location = new Point(291, 78);
            lblExpresTotal.Name = "lblExpresTotal";
            lblExpresTotal.Size = new Size(34, 15);
            lblExpresTotal.TabIndex = 11;
            lblExpresTotal.Text = "$0,00";
            // 
            // clmCliente
            // 
            clmCliente.HeaderText = "Cliente";
            clmCliente.Name = "clmCliente";
            // 
            // colPatente
            // 
            colPatente.HeaderText = "Patente";
            colPatente.Name = "colPatente";
            // 
            // colServicio
            // 
            colServicio.HeaderText = "Servicio";
            colServicio.Name = "colServicio";
            // 
            // colVehiculos
            // 
            colVehiculos.HeaderText = "Vehiculos";
            colVehiculos.Name = "colVehiculos";
            // 
            // colEntrega
            // 
            colEntrega.HeaderText = "Entrega";
            colEntrega.Name = "colEntrega";
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            // 
            // lstConsulta
            // 
            lstConsulta.FormattingEnabled = true;
            lstConsulta.Location = new Point(71, 62);
            lstConsulta.Name = "lstConsulta";
            lstConsulta.Size = new Size(247, 34);
            lstConsulta.TabIndex = 15;
            // 
            // lblLavados
            // 
            lblLavados.AutoSize = true;
            lblLavados.Location = new Point(15, 62);
            lblLavados.Name = "lblLavados";
            lblLavados.Size = new Size(50, 15);
            lblLavados.TabIndex = 16;
            lblLavados.Text = "Lavados";
            // 
            // frmLavados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 518);
            Controls.Add(grpRecaudacion);
            Controls.Add(grpListado);
            Controls.Add(grpConsultaPatente);
            Controls.Add(grpImportes);
            Controls.Add(grpDatosLavados);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLavados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lavadero Los Andes - Gestíon de Lavados";
            grpDatosLavados.ResumeLayout(false);
            grpDatosLavados.PerformLayout();
            grpEntrega.ResumeLayout(false);
            grpEntrega.PerformLayout();
            grpImportes.ResumeLayout(false);
            grpImportes.PerformLayout();
            grpConsultaPatente.ResumeLayout(false);
            grpConsultaPatente.PerformLayout();
            grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLavados).EndInit();
            grpRecaudacion.ResumeLayout(false);
            grpRecaudacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosLavados;
        private Label lblCantidad;
        private Label lblServicio;
        private Label lblPatente;
        private Label lblCliente;
        private TextBox txtPatente;
        private TextBox txtCliente;
        private Label lblFrecuente;
        private CheckBox chkClienteFrecuente;
        private TextBox txtCantidad;
        private ComboBox cmbServicio;
        private Button btnLimpiar;
        private Button btnCalcular;
        private GroupBox grpEntrega;
        private RadioButton btnExpres;
        private RadioButton btnNormal;
        private GroupBox grpImportes;
        private Label lblTituloTotal;
        private Label lblTituloDescuento;
        private Label lblTituloRecargo;
        private Label lblTituloSubtotal;
        private Label lblTotal;
        private Label lblDescuento;
        private Label lblRecargo;
        private Label lblSubtotal;
        private Button btnRegistrar;
        private GroupBox grpConsultaPatente;
        private Button btnConsultaPatente;
        private TextBox txtPatenteConsulta;
        private Label lblConsultaPatente;
        private GroupBox grpListado;
        private DataGridView dgvLavados;
        private GroupBox grpRecaudacion;
        private Label lblRecaudacionEncerado;
        private Label lblRecaudacionCompleto;
        private Label lblRecaudacionExterior;
        private Label lblExpresTotal;
        private Label lblNormalTotal;
        private Label lblRecaudacionExpres;
        private Label lblRecaudacionTotal;
        private Label lblEnceradoTotal;
        private Label lblCompletoTotal;
        private Label lblLavadoTotal;
        private DataGridViewTextBoxColumn clmCliente;
        private DataGridViewTextBoxColumn colPatente;
        private DataGridViewTextBoxColumn colServicio;
        private DataGridViewTextBoxColumn colVehiculos;
        private DataGridViewTextBoxColumn colEntrega;
        private DataGridViewTextBoxColumn colTotal;
        private Label lblLavados;
        private ListBox lstConsulta;
    }
}
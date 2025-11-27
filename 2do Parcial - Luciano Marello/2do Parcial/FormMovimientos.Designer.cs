namespace _2do_Parcial
{
    partial class FormMovimientos
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
            gbMovimientos = new GroupBox();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            cmbTipo = new ComboBox();
            cmbCuenta = new ComboBox();
            lblMonto = new Label();
            cmbCliente = new ComboBox();
            txtDescripcion = new TextBox();
            txtMonto = new TextBox();
            lblDescripcion = new Label();
            lblTipo = new Label();
            lblCuenta = new Label();
            lblCliente = new Label();
            dgvMovimientos = new DataGridView();
            lblMovimientos = new Label();
            lblTotalCreditos = new Label();
            lblTotalDebitos = new Label();
            lblSaldoActual = new Label();
            lblCantidadMovimientos = new Label();
            lblEstado = new Label();
            gbMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // gbMovimientos
            // 
            gbMovimientos.Controls.Add(btnLimpiar);
            gbMovimientos.Controls.Add(btnAgregar);
            gbMovimientos.Controls.Add(cmbTipo);
            gbMovimientos.Controls.Add(cmbCuenta);
            gbMovimientos.Controls.Add(lblMonto);
            gbMovimientos.Controls.Add(cmbCliente);
            gbMovimientos.Controls.Add(txtDescripcion);
            gbMovimientos.Controls.Add(txtMonto);
            gbMovimientos.Controls.Add(lblDescripcion);
            gbMovimientos.Controls.Add(lblTipo);
            gbMovimientos.Controls.Add(lblCuenta);
            gbMovimientos.Controls.Add(lblCliente);
            gbMovimientos.Location = new Point(12, 12);
            gbMovimientos.Name = "gbMovimientos";
            gbMovimientos.Size = new Size(368, 530);
            gbMovimientos.TabIndex = 0;
            gbMovimientos.TabStop = false;
            gbMovimientos.Text = "Datos Movimientos";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(202, 412);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 66);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(41, 412);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(121, 66);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Registrar Movimiento";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(97, 145);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(244, 28);
            cmbTipo.TabIndex = 11;
            // 
            // cmbCuenta
            // 
            cmbCuenta.FormattingEnabled = true;
            cmbCuenta.Location = new Point(97, 94);
            cmbCuenta.Name = "cmbCuenta";
            cmbCuenta.Size = new Size(244, 28);
            cmbCuenta.TabIndex = 10;
            cmbCuenta.SelectedIndexChanged += cmbCuenta_SelectedIndexChanged;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(28, 202);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(56, 20);
            lblMonto.TabIndex = 8;
            lblMonto.Text = "Monto:";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(97, 42);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(244, 28);
            cmbCliente.TabIndex = 7;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(124, 255);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(217, 111);
            txtDescripcion.TabIndex = 6;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(97, 199);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(244, 27);
            txtMonto.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(28, 258);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(28, 148);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(42, 20);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo:";
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Location = new Point(28, 97);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(58, 20);
            lblCuenta.TabIndex = 1;
            lblCuenta.Text = "Cuenta:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(28, 45);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Location = new Point(386, 38);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.RowHeadersWidth = 51;
            dgvMovimientos.Size = new Size(563, 340);
            dgvMovimientos.TabIndex = 2;
            // 
            // lblMovimientos
            // 
            lblMovimientos.AutoSize = true;
            lblMovimientos.Location = new Point(386, 15);
            lblMovimientos.Name = "lblMovimientos";
            lblMovimientos.Size = new Size(153, 20);
            lblMovimientos.TabIndex = 13;
            lblMovimientos.Text = "Lista de Movimientos:";
            // 
            // lblTotalCreditos
            // 
            lblTotalCreditos.AutoSize = true;
            lblTotalCreditos.Location = new Point(419, 405);
            lblTotalCreditos.Name = "lblTotalCreditos";
            lblTotalCreditos.Size = new Size(50, 20);
            lblTotalCreditos.TabIndex = 14;
            lblTotalCreditos.Text = "label1";
            // 
            // lblTotalDebitos
            // 
            lblTotalDebitos.AutoSize = true;
            lblTotalDebitos.Location = new Point(419, 459);
            lblTotalDebitos.Name = "lblTotalDebitos";
            lblTotalDebitos.Size = new Size(50, 20);
            lblTotalDebitos.TabIndex = 15;
            lblTotalDebitos.Text = "label2";
            // 
            // lblSaldoActual
            // 
            lblSaldoActual.AutoSize = true;
            lblSaldoActual.Location = new Point(696, 405);
            lblSaldoActual.Name = "lblSaldoActual";
            lblSaldoActual.Size = new Size(50, 20);
            lblSaldoActual.TabIndex = 16;
            lblSaldoActual.Text = "label1";
            // 
            // lblCantidadMovimientos
            // 
            lblCantidadMovimientos.AutoSize = true;
            lblCantidadMovimientos.Location = new Point(696, 459);
            lblCantidadMovimientos.Name = "lblCantidadMovimientos";
            lblCantidadMovimientos.Size = new Size(50, 20);
            lblCantidadMovimientos.TabIndex = 17;
            lblCantidadMovimientos.Text = "label2";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(419, 513);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(50, 20);
            lblEstado.TabIndex = 18;
            lblEstado.Text = "label2";
            // 
            // FormMovimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 570);
            Controls.Add(lblEstado);
            Controls.Add(lblCantidadMovimientos);
            Controls.Add(lblSaldoActual);
            Controls.Add(lblTotalDebitos);
            Controls.Add(lblTotalCreditos);
            Controls.Add(lblMovimientos);
            Controls.Add(dgvMovimientos);
            Controls.Add(gbMovimientos);
            Name = "FormMovimientos";
            Text = "Formulario Movimientos";
            gbMovimientos.ResumeLayout(false);
            gbMovimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbMovimientos;
        private ComboBox cmbTipo;
        private ComboBox cmbCuenta;
        private Label lblMonto;
        private ComboBox cmbCliente;
        private TextBox txtDescripcion;
        private TextBox txtMonto;
        private Label lblDescripcion;
        private Label lblTipo;
        private Label lblCuenta;
        private Label lblCliente;
        private DataGridView dgvMovimientos;
        private Button btnAgregar;
        private Label lblMovimientos;
        private Button btnLimpiar;
        private Label lblTotalCreditos;
        private Label lblTotalDebitos;
        private Label lblSaldoActual;
        private Label lblCantidadMovimientos;
        private Label lblEstado;
    }
}
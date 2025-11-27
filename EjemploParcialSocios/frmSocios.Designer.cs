namespace EjemploParcialSocios
{
    partial class frmSocios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSocios = new DataGridView();
            gbDatosSocios = new GroupBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            chbCuota = new CheckBox();
            dtpFechaNacimiento = new DateTimePicker();
            txtNumSocio = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblCuota = new Label();
            lblNumSocio = new Label();
            lblFechaNacimiento = new Label();
            lblDni = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            btnCantCuota = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            gbDatosSocios.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSocios
            // 
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(12, 287);
            dgvSocios.MultiSelect = false;
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.RowHeadersWidth = 51;
            dgvSocios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSocios.Size = new Size(930, 268);
            dgvSocios.TabIndex = 0;
            dgvSocios.SelectionChanged += dgvSocios_SelectionChanged;
            // 
            // gbDatosSocios
            // 
            gbDatosSocios.Controls.Add(btnCantCuota);
            gbDatosSocios.Controls.Add(btnLimpiar);
            gbDatosSocios.Controls.Add(btnEliminar);
            gbDatosSocios.Controls.Add(btnModificar);
            gbDatosSocios.Controls.Add(btnAgregar);
            gbDatosSocios.Controls.Add(chbCuota);
            gbDatosSocios.Controls.Add(dtpFechaNacimiento);
            gbDatosSocios.Controls.Add(txtNumSocio);
            gbDatosSocios.Controls.Add(txtDni);
            gbDatosSocios.Controls.Add(txtApellido);
            gbDatosSocios.Controls.Add(txtNombre);
            gbDatosSocios.Controls.Add(lblCuota);
            gbDatosSocios.Controls.Add(lblNumSocio);
            gbDatosSocios.Controls.Add(lblFechaNacimiento);
            gbDatosSocios.Controls.Add(lblDni);
            gbDatosSocios.Controls.Add(lblApellido);
            gbDatosSocios.Controls.Add(lblNombre);
            gbDatosSocios.Location = new Point(12, 12);
            gbDatosSocios.Name = "gbDatosSocios";
            gbDatosSocios.Size = new Size(930, 269);
            gbDatosSocios.TabIndex = 1;
            gbDatosSocios.TabStop = false;
            gbDatosSocios.Text = "Datos Socios";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(798, 114);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 52);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(677, 114);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 52);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(798, 40);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(105, 52);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(677, 40);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 52);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // chbCuota
            // 
            chbCuota.AutoSize = true;
            chbCuota.Location = new Point(445, 142);
            chbCuota.Name = "chbCuota";
            chbCuota.Size = new Size(80, 24);
            chbCuota.TabIndex = 11;
            chbCuota.Text = "Pagada";
            chbCuota.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(427, 40);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(214, 27);
            dtpFechaNacimiento.TabIndex = 10;
            // 
            // txtNumSocio
            // 
            txtNumSocio.Location = new Point(427, 90);
            txtNumSocio.Name = "txtNumSocio";
            txtNumSocio.Size = new Size(214, 27);
            txtNumSocio.TabIndex = 9;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(117, 140);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(172, 27);
            txtDni.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(117, 90);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(172, 27);
            txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(117, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(172, 27);
            txtNombre.TabIndex = 6;
            // 
            // lblCuota
            // 
            lblCuota.AutoSize = true;
            lblCuota.Location = new Point(325, 143);
            lblCuota.Name = "lblCuota";
            lblCuota.Size = new Size(96, 20);
            lblCuota.TabIndex = 5;
            lblCuota.Text = "Cuota al dia?";
            // 
            // lblNumSocio
            // 
            lblNumSocio.AutoSize = true;
            lblNumSocio.Location = new Point(325, 93);
            lblNumSocio.Name = "lblNumSocio";
            lblNumSocio.Size = new Size(88, 20);
            lblNumSocio.TabIndex = 4;
            lblNumSocio.Text = "Num. Socio:";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(324, 43);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(89, 20);
            lblFechaNacimiento.TabIndex = 3;
            lblFechaNacimiento.Text = "Nacimiento:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(34, 143);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(38, 20);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(32, 93);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(34, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // btnCantCuota
            // 
            btnCantCuota.Location = new Point(677, 189);
            btnCantCuota.Name = "btnCantCuota";
            btnCantCuota.Size = new Size(226, 53);
            btnCantCuota.TabIndex = 16;
            btnCantCuota.Text = "Contar Cuota al Dia";
            btnCantCuota.UseVisualStyleBackColor = true;
            btnCantCuota.Click += btnCantCuota_Click;
            // 
            // frmSocios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 567);
            Controls.Add(gbDatosSocios);
            Controls.Add(dgvSocios);
            Name = "frmSocios";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            gbDatosSocios.ResumeLayout(false);
            gbDatosSocios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSocios;
        private GroupBox gbDatosSocios;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private CheckBox chbCuota;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtNumSocio;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblCuota;
        private Label lblNumSocio;
        private Label lblFechaNacimiento;
        private Label lblDni;
        private Label lblApellido;
        private Label lblNombre;
        private Button btnCantCuota;
    }
}
